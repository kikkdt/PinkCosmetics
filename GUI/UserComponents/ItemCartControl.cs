using DTO;
using System;
using System.Windows.Forms;

namespace GUI.UserComponents
{
    public partial class ItemCartControl : UserControl
    {
        private tb_SanPham _product;
        public tb_SanPham Product { get => _product; set => _product = value; }

        public ItemCartControl(tb_SanPham product)
        {
            _product = product;

            InitializeComponent();
            lblItemName.Text = Product.TenSP;
            lblUnitPrice.Text = string.Format("{0:#,##0}", Product.GiaVon);
            lblTotalPrice.Text = string.Format("{0:#,##0}", (double)Product.GiaVon * (double)spinQuantity.Value);
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
            lblTotalPrice.Text = string.Format("{0:#,##0}", (double)Product.GiaVon * (double)spinQuantity.Value);
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