using DTO;
using System;
using System.Windows.Forms;

namespace GUI.UserComponents
{
    public partial class ItemCartControl : UserControl
    {
        private SanPham_DTO _product;
        public SanPham_DTO Product { get => _product; set => _product = value; }

        public ItemCartControl(SanPham_DTO product)
        {
            _product = product;

            InitializeComponent();
            lblItemName.Text = Product.TenSanPham;
            lblUnitPrice.Text = string.Format("{0:#,##0}", Product.GiaVon);
            lblTotalPrice.Text = string.Format("{0:#,##0}", Product.GiaVon * (double)spinQuantity.Value);
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
            lblTotalPrice.Text = string.Format("{0:#,##0}", Product.GiaVon * (double)spinQuantity.Value);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            foreach (Control item in Parent.Controls)
            {
                if (item == this)
                {
                    Parent.Controls.Remove(item);
                }
            }
        }
    }
}