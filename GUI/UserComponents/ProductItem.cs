using BLL;
using DTO;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI.UserComponents
{
    public partial class ProductItem : UserControl
    {
        private tb_SanPham _product;
        private int _priceTypeId;
        public tb_SanPham Product { get => _product; set => _product = value; }
        public int PriceTypeId { get => _priceTypeId; set => _priceTypeId = value; }

        private Cart _cart;

        public ProductItem(tb_SanPham product, Panel parent, Cart cart, int priceTypeId)
        {
            Product = product;
            Parent = parent;
            _cart = cart;
            PriceTypeId = priceTypeId;

            InitializeComponent();
            LoadUI();
        }

        #region Prepare UI

        private void LoadUI()
        {
            // Set value
            lblName.Text = Product.TenSP;
            lblPrice.Text = Utilities.FormatWithThousandSeparator((double)GiaBanBLL.GetPrice(PriceTypeId, Product.MaSanPham).GiaBan);

            // If the product image isn't found, set default image
            var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            try
            {
                if (Product.UrlHinh != null)
                {
                    var filePath = Path.Combine(projectFolder, @"assets/image/" + Product.UrlHinh);
                    pictureProduct.Image = Image.FromFile(filePath);
                }
                else
                {
                    var filePath = Path.Combine(projectFolder, @"assets/icon/icons8-nothing-found-48.png");
                    pictureProduct.Image = Image.FromFile(filePath);
                }
            }
            catch
            {
                var filePath = Path.Combine(projectFolder, @"assets/icon/icons8-nothing-found-48.png");
                pictureProduct.Image = Image.FromFile(filePath);
            }
        }

        #endregion Prepare UI

        #region Handle event

        private void ItemProductControl_Click(object sender, EventArgs e)
        {
            // If already have this product in the cart, increase the product quantity
            if (IsExistInCart(Product))
            {
                IncreaseQuantity(Product);
            }
            else
            {
                // Validate the quantity before modifying the quantity of sales invoice detail
                if (SanPhamBLL.IsValidQuantityToGet(Product.MaSanPham, 1))
                {
                    tb_ChiTietHDBan chiTietHDBan = new tb_ChiTietHDBan
                    {
                        MaHDBan = _cart.InvoiceID,
                        MaSanPham = Product.MaSanPham,
                        MaBangGia = PriceTypeId,
                        SoLuong = 1
                    };
                    decimal donGia = GiaBanBLL.GetPrice(PriceTypeId, Product.MaSanPham).GiaBan;
                    chiTietHDBan.DonGia = donGia;
                    chiTietHDBan.ThanhTien = donGia * 1;
                    AddItemCart(_cart, chiTietHDBan, _cart.PanelCart.Controls.Count + 1);
                }
                else // If the quantity isn't valid, reassign the previous quantity
                {
                    MessageBox.Show("Số lượng tồn kho không đủ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ItemProductControl_MouseLeave(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.None;
            toolTipController1.HideHint();
        }

        private void ItemProductControl_MouseHover(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.FixedSingle;
            toolTipController1.ShowHint($"{Product.TenSP} - {lblPrice.Text} - Tồn: {Product.TonKho}");
        }

        #endregion Handle event

        #region Utility methods

        /// <summary>
        /// Increase the quantity of a product.
        /// </summary>
        /// <param name="product">Product</param>
        private void IncreaseQuantity(tb_SanPham product)
        {
            foreach (CartItem item in _cart.PanelCart.Controls)
            {
                if (item.SalesInvoiceDetail.MaSanPham.Equals(product.MaSanPham))
                {
                    item.BtnIncrease_Click(null, null);
                }
            }
        }

        /// <summary>
        /// Check the existence of the product in the cart
        /// </summary>
        /// <param name="product">Products to check</param>
        /// <returns>True if there is a product in the cart; otherwise False</returns>
        private bool IsExistInCart(tb_SanPham product)
        {
            foreach (CartItem item in _cart.PanelCart.Controls)
            {
                if (item.SalesInvoiceDetail.MaSanPham.Equals(product.MaSanPham))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Add product to cart
        /// </summary>
        /// <param name="cart">Container of item</param>
        /// <param name="chiTietHDBan">Sales invoice details</param>
        /// <param name="index">Order in cart</param>
        private void AddItemCart(Cart cart, tb_ChiTietHDBan chiTietHDBan, int index)
        {
            CartItem itemCart = new CartItem(cart, chiTietHDBan, index)
            {
                Parent = _cart.PanelCart,
                Width = _cart.PanelCart.Width-25
            };
            _cart.PanelCart.Controls.Add(itemCart);
        }

        #endregion Utility methods
    }
}