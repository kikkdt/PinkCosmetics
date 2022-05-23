using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormMain : Form
    {
        public static tb_NhanVien UserLogin = NhanVienBLL.GetEmployee("NV00001");

        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnPOS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                FormPOS formPOS = new FormPOS
                {
                    MdiParent = this,
                    Dock = DockStyle.Fill,
                    FormBorderStyle = FormBorderStyle.None
                };
                formPOS.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}