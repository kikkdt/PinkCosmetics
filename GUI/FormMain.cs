using BLL;
using DevExpress.XtraBars;
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

            GrantPermission();
        }

        /// <summary>
        /// Grant permission
        /// </summary>
        private void GrantPermission()
        {
            var permissions = PhanQuyenBLL.GetPermission(Account.Username);
            foreach (var permission in permissions)
            {
                switch (permission.MaChucNang)
                {
                    case "btnAddBrand":
                        btnAddBrand.Visibility = (bool)permission.CoQuyen ? BarItemVisibility.Always : BarItemVisibility.Never;
                        break;

                    case "btnAddGroupOfGoods":
                        btnAddGroupOfGoods.Visibility = (bool)permission.CoQuyen ? BarItemVisibility.Always : BarItemVisibility.Never;
                        break;

                    case "btnBrand":
                        btnBrand.Visibility = (bool)permission.CoQuyen ? BarItemVisibility.Always : BarItemVisibility.Never;
                        break;

                    case "btnChangePassword":
                        btnChangePassword.Visibility = (bool)permission.CoQuyen ? BarItemVisibility.Always : BarItemVisibility.Never;
                        break;

                    case "btnGoods":
                        btnGoods.Visibility = (bool)permission.CoQuyen ? BarItemVisibility.Always : BarItemVisibility.Never;
                        break;

                    case "btnGroupOfGoods":
                        btnGroupOfGoods.Visibility = (bool)permission.CoQuyen ? BarItemVisibility.Always : BarItemVisibility.Never;
                        break;

                    case "btnInventory":
                        btnInventory.Visibility = (bool)permission.CoQuyen ? BarItemVisibility.Always : BarItemVisibility.Never;
                        break;

                    case "btnInvoiceHistory":
                        btnInvoiceHistory.Visibility = (bool)permission.CoQuyen ? BarItemVisibility.Always : BarItemVisibility.Never;
                        break;

                    case "btnListOfOrders":
                        btnListOfOrders.Visibility = (bool)permission.CoQuyen ? BarItemVisibility.Always : BarItemVisibility.Never;
                        break;

                    case "btnLogOut":
                        btnLogOut.Visibility = (bool)permission.CoQuyen ? BarItemVisibility.Always : BarItemVisibility.Never;
                        break;

                    case "btnOrder":
                        btnOrder.Visibility = (bool)permission.CoQuyen ? BarItemVisibility.Always : BarItemVisibility.Never;
                        break;

                    case "btnPermission":
                        btnPermission.Visibility = (bool)permission.CoQuyen ? BarItemVisibility.Always : BarItemVisibility.Never;
                        break;

                    case "btnPOS":
                        btnPOS.Visibility = (bool)permission.CoQuyen ? BarItemVisibility.Always : BarItemVisibility.Never;
                        break;

                    case "btnPriceSetting":
                        btnPriceSetting.Visibility = (bool)permission.CoQuyen ? BarItemVisibility.Always : BarItemVisibility.Never;
                        break;

                    case "ribbonAccount":
                        ribbonAccount.Visible = (bool)permission.CoQuyen;
                        break;

                    case "ribbonGoods":
                        ribbonGoods.Visible = (bool)permission.CoQuyen;
                        break;

                    case "ribbonSystem":
                        ribbonSystem.Visible = (bool)permission.CoQuyen;
                        break;

                    case "ribbonTransaction":
                        ribbonTransaction.Visible = (bool)permission.CoQuyen;
                        break;
                }
            }
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

        private void BtnLogOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            Hide();
            Program.FormLogin.FormClosed += (o, evt) =>
            {
                Program.FormLogin = new FormLogin();
                Program.FormLogin.ShowDialog();
            };
            Close();
        }

        private void BtnPermission_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormGrantPermission formGrantPermission = new FormGrantPermission();
            OpenChildForm(formGrantPermission, "Phân quyền");
        }

        private void BtnChangePassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormChangePassword formChangePassword = new FormChangePassword();
            formChangePassword.ShowDialog();
        }

        private void btnInvoiceHistory_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormListOfInvoices formListOfInvoices = new FormListOfInvoices();
            OpenChildForm(formListOfInvoices, "Lịch sử hoá đơn");
        }

        private void BtnGroupOfGoods_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormListOfProductGroups formListOfProductGroups = new FormListOfProductGroups();
            OpenChildForm(formListOfProductGroups, "Nhóm hàng hoá");
        }

        private void BtnAddGroupOfGoods_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormProductGroups formProductGroups = new FormProductGroups();
            formProductGroups.ShowDialog();
        }
    }
}