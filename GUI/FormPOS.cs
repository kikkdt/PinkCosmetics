using BLL;
using DevExpress.XtraEditors.Controls;
using DTO;
using GUI.UserComponents;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormPOS : Form
    {
        private Cart _cart;

        public FormPOS()
        {
            InitializeComponent();

            LoadCart();
            LoadPriceTypeComboBox();
            LoadProductItems();
            LoadListboxCustomer();
        }

        #region Prepare data

        /// <summary>
        /// Initialize cart control
        /// </summary>
        private void LoadCart()
        {
            _cart = new Cart
            {
                Parent = panelCartContainer,
                Dock = DockStyle.Fill
            };
        }

        /// <summary>
        /// Load all products
        /// </summary>
        private void LoadProductItems()
        {
            var lstProductItem = SanPhamBLL.GetProducts();
            foreach (var item in lstProductItem)
            {
                var itemComponent = new ProductItem(item, panelProducts, _cart, int.Parse(cboxBangGia.SelectedValue.ToString()));
                panelProducts.Controls.Add(itemComponent);
            }
        }

        /// <summary>
        /// Load price type from database
        /// </summary>
        private void LoadPriceTypeComboBox()
        {
            var lstPriceType = BangGiaBLL.GetPriceTypes();
            cboxBangGia.DataSource = lstPriceType;
            cboxBangGia.DisplayMember = "TenBangGia";
            cboxBangGia.ValueMember = "MaBangGia";
            cboxBangGia.SelectedIndex = 0; // Default type
        }

        /// <summary>
        /// Load and binding all customers to list box
        /// </summary>
        private void LoadListboxCustomer()
        {
            List<tb_KhachHang> khachHangs = KhachHangBLL.GetCustomers();
            listBoxCustomer.DataSource = khachHangs;
            searchCustomer.ClearFilter();
        }

        #endregion Prepare data

        #region Handle event

        /// <summary>
        /// Handle resize child control to fit container when form firing resize
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void FormPOS_Resize(object sender, EventArgs e)
        {
            foreach (Control item in _cart.PanelCart.Controls)
            {
                item.Width = item.Parent.Width - 25;
            }
        }

        #endregion Handle event

        /// <summary>
        /// Handle customer search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchCustomer_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchCustomer.Text))
            {
                listBoxCustomer.Visible = false;
                _cart.Customer = null;
            }
            else
            {
                listBoxCustomer.Visible = true;
            }
        }

        /// <summary>
        /// Get selected customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCustomer.SelectedValue != null)
            {
                tb_KhachHang customer = (listBoxCustomer.SelectedValue as tb_KhachHang);
                searchCustomer.Text = customer.HoTen;
                listBoxCustomer.Visible = false;
                _cart.Customer = customer;
            }
        }

        /// <summary>
        /// Open new customer form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchCustomer_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            EditorButton button = e.Button;
            if (button.Kind.ToString().Equals("Plus"))
            {
                MessageBox.Show("Clicked");
            }
        }

        /// <summary>
        /// Open the payment form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPayout_Click(object sender, EventArgs e)
        {
            // Initialize sales invoice
            tb_HoaDonBan salesInvoice = new tb_HoaDonBan
            {
                MaHDBan = _cart.InvoiceID,
                MaNV = FormMain.UserLogin.MaNV,
                MaKH = _cart.Customer?.MaKH,
                NgayLap = DateTime.Now,
                TongTien = (decimal)_cart.GetTotalAmount(),
                GiamGia = 0,
                ThanhTien = (decimal)_cart.GetTotalAmount(),
                TrangThai = false
            };

            //
            List<tb_ChiTietHDBan> salesInvoiceDetails = new List<tb_ChiTietHDBan>();
            foreach (CartItem cartItem in _cart.PanelCart.Controls)
            {
                salesInvoiceDetails.Add(cartItem.SalesInvoiceDetail);
            }

            FormPayment formPayment = new FormPayment(salesInvoice, salesInvoiceDetails);
            formPayment.FormClosed += (o, evt) =>
            {
                if (formPayment.IsSuccess)
                {
                    Close();
                }
            };
            formPayment.ShowDialog();
        }
    }
}