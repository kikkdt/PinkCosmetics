using BLL;
using DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        public static tb_NhanVien Employee { get; set; }
        public static tb_TaiKhoan Account { get; set; }

        public FormMain(tb_TaiKhoan account)
        {
            InitializeComponent();
            Account = account;
            Employee = NhanVienBLL.GetEmployeeByAccount(account.Username);
        }

        /// <summary>
        /// Perform opening specified form
        /// </summary>
        /// <param name="formChildren">Form to be opened</param>
        /// <param name="formName">Form name</param>
        private void OpenChildForm(Form formChildren, string formName)
        {
            try
            {
                formChildren.MdiParent = this;
                formChildren.Dock = DockStyle.Fill;
                formChildren.FormBorderStyle = FormBorderStyle.None;
                formChildren.Text = $@"{formName} {CountChildForm(formChildren)}";

                formChildren.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Get count of the form in an array of MDI child forms
        /// </summary>
        /// <param name="formChildren">Forms to be counted</param>
        /// <returns></returns>
        private int CountChildForm(Form formChildren)
        {
            return MdiChildren.Count(child => child.Name.Equals(formChildren.Name));
        }

        private void BtnPOS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormPOS formPOS = new FormPOS();
            OpenChildForm(formPOS, "Hoá đơn");
        }

        private void BtnOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormOrder formOrder = new FormOrder();
            OpenChildForm(formOrder, "Đặt hàng");
        }

        private void BtnListOfOrders_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormListOfOrders formListOfOrders = new FormListOfOrders();
            OpenChildForm(formListOfOrders, "Danh sách đặt hàng");
        }
    }
}