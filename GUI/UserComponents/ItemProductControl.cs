using DTO;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI.UserComponents
{
    public partial class ItemProductControl : UserControl
    {
        private SanPham_DTO _product;
        public SanPham_DTO Product { get => _product; set => _product = value; }

        public ItemProductControl(SanPham_DTO product, Panel parent)
        {
            InitializeComponent();
            _product = product;
            Parent = parent;
            // Handle text-overflow
            //lblName.Text = product.TenSanPham.Length > 35 ? string.Concat(product.TenSanPham.Substring(0, 35), "...") : product.TenSanPham;
            lblName.Text = product.TenSanPham;
            lblPrice.Text = string.Format("{0:#,##0}", product.GiaVon);
            // If the product image isn't found, set default image
            if (product.UrlHinh != null)
            {
                pictureProduct.Image = Image.FromFile(product.UrlHinh);
            }
            else
            {
                var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                var filePath = Path.Combine(projectFolder, @"assets/icon/icons8-nothing-found-48.png");
                pictureProduct.Image = Image.FromFile(filePath);
            }

            HoverEvent(Controls);
        }

        private void HoverEvent(ControlCollection control)
        {
            // Using a recursive function to cover events for all child controls
            foreach (Control childControl in control)
            {
                childControl.MouseHover += ChildControl_MouseHover;
                childControl.MouseLeave += ChildControl_MouseLeave;
                if (childControl.HasChildren)
                {
                    HoverEvent(childControl.Controls);
                }
            }
        }

        private void ChildControl_MouseLeave(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.None;
            toolTipController1.HideHint();
        }

        private void ChildControl_MouseHover(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.FixedSingle;
            toolTipController1.ShowHint(Product.TenSanPham + " - " + lblPrice.Text);
        }
    }
}