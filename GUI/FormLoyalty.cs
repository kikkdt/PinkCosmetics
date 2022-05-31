using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormLoyalty : Form
    {
        private int _loyaltyUse = 0;
        public tb_KhachHang Customer { get; set; }
        public int LoyaltyUse { get => _loyaltyUse; set => _loyaltyUse = value; }

        public FormLoyalty(tb_KhachHang customer)
        {
            InitializeComponent();
            Customer = customer;
        }

        private void FormLoyalty_Load(object sender, EventArgs e)
        {
            lblLoyalty.Text = Utilities.FormatWithThousandSeparator((double)Customer.DiemTichLuy);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (KhachHangBLL.IsValidLoyaltyUse(Customer, (int)spinLoyaltyUse.Value))
            {
                LoyaltyUse = (int)spinLoyaltyUse.Value;
                Close();
            }
            else
            {
                MessageBox.Show("Điểm muốn sử dụng không hợp lệ, vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}