using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI.UserComponents
{
    public partial class CartItem : UserControl
    {
        private Cart _cart;
        public tb_ChiTietHDBan SalesInvoiceDetail { get; set; }
        public int Index { get; set; }

        public CartItem(Cart cart, tb_ChiTietHDBan salesInvoiceDetail, int index)
        {
            _cart = cart;
            SalesInvoiceDetail = salesInvoiceDetail;
            Index = index;

            InitializeComponent();

            // Set value for UI
            lblNumOrder.Text = Index.ToString();
            lblItemName.Text = SanPhamBLL.GetProduct(salesInvoiceDetail.MaSanPham).TenSP;
            lblUnitPrice.Text = Utilities.FormatWithThousandSeparator((double)salesInvoiceDetail.DonGia);
            lblTotalPrice.Text = Utilities.FormatWithThousandSeparator((double)salesInvoiceDetail.ThanhTien);
        }

        public void BtnDecrease_Click(object sender, EventArgs e)
        {
            if (spinQuantity.Value - 1 > 0)
            {
                spinQuantity.Value--;
            }
        }

        public void BtnIncrease_Click(object sender, EventArgs e)
        {
            if (spinQuantity.Value + 1 < 1000)
            {
                spinQuantity.Value++;
            }
        }

        private void SpinQuantity_EditValueChanged(object sender, EventArgs e)
        {
            SalesInvoiceDetail.SoLuong = (int)spinQuantity.Value;
            SalesInvoiceDetail.ThanhTien = (decimal)(SalesInvoiceDetail.SoLuong * SalesInvoiceDetail.DonGia);
            lblTotalPrice.Text = Utilities.FormatWithThousandSeparator((double)SalesInvoiceDetail.ThanhTien, "VNĐ");

            _cart.UpdateTotalAmount();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            foreach (Control item in Parent.Controls)
            {
                if (item == this)
                {
                    Parent.Controls.Remove(item);
                    _cart.UpdateTotalAmount();
                }
            }
        }
    }
}