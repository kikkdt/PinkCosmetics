using BLL;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.UI;
using GUI.Reports;
using System;
using System.Linq;

namespace GUI
{
    public partial class FormListOfInvoices : DevExpress.XtraEditors.XtraForm
    {
        public FormListOfInvoices()
        {
            InitializeComponent();
        }

        #region Prepare data

        private void FormListOfInvoices_Load(object sender, EventArgs e)
        {
            LoadDgv();
        }

        private void LoadDgv()
        {
            var employees = NhanVienBLL.GetEmployees();
            var customers = KhachHangBLL.GetCustomers();

            gridControl.DataSource = HoaDonBanBLL.GetSalesInvoices().Join(employees, invoice => invoice.MaNV,
                employee => employee.MaNV, (invoice, employee) => new
                {
                    invoice,
                    employee
                }).Join(customers, invoiceAndEmployee => invoiceAndEmployee.invoice.MaKH, customer => customer.MaKH,
                (invoiceAndEmployee, customer) => new
                {
                    MaHDBan = invoiceAndEmployee.invoice.MaHDBan,
                    HoTenNhanVien = invoiceAndEmployee.employee.HoTen,
                    HoTenKhachHang = customer.HoTen,
                    ThanhTien = invoiceAndEmployee.invoice.ThanhTien,
                    NgayLap = invoiceAndEmployee.invoice.NgayLap,
                    TrangThai = invoiceAndEmployee.invoice.TrangThai
                }).ToList();
        }

        #endregion Prepare data

        #region Handle event

        /// <summary>
        /// Customize columns to display ordinal number columns
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            switch (e.Column.FieldName)
            {
                case "STT":
                    e.DisplayText = (e.ListSourceRowIndex + 1).ToString();
                    break;

                case "ThanhTien":
                    e.DisplayText = Utilities.FormatWithThousandSeparator(Convert.ToDouble(e.Value));
                    break;

                case "NgayLap":
                    e.DisplayText = DateTime.Parse(e.Value.ToString()).ToString("dd/MM/yyyy HH:mm:ss");
                    break;

                case "TrangThai":
                    e.DisplayText = Convert.ToBoolean(e.Value) ? "Đã thanh toán" : "Chưa thanh toán";
                    break;
            }
        }

        private void RepositoryItemButtonEdit1_ButtonClick(object sender,
            DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            EditorButton button = e.Button;
            int indexRowSelected = gridView1.GetSelectedRows()[0];
            // Print a copy of the invoice
            if (button.Caption == "Print")
            {
                ReportInvoiceDuplicate reportInvoice = new ReportInvoiceDuplicate();
                reportInvoice.Parameters["mahdban"].Value =
                    gridView1.GetRowCellValue(indexRowSelected, "MaHDBan").ToString();
                reportInvoice.ShowPreview();
            }
        }

        #endregion Handle event
    }
}