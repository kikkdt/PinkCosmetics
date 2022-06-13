using BLL;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraPrinting;
using DTO;
using GUI.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormListOfOrders : DevExpress.XtraEditors.XtraForm
    {
        public FormListOfOrders()
        {
            InitializeComponent();
        }

        #region Prepare data

        private void FormListOfOrders_Load(object sender, EventArgs e)
        {
            LoadDgvOrders();

            Action.UnboundDataType = typeof(object);
        }

        private void LoadDgvOrders()
        {
            List<tb_PhieuDatHang> orders = PhieuDatHangBLL.GetOrders();
            List<tb_NhanVien> employees = NhanVienBLL.GetEmployees();
            gridControl.DataSource = orders.Join(employees, order => order.MaNV, employee => employee.MaNV, (order, employee) => new ViewPhieuDatHang()
            {
                MaPhieuDat = order.MaPhieuDat,
                MaNV = order.MaNV,
                HoTen = employee.HoTen,
                NgayLap = order.NgayLap,
                TrangThai = order.TrangThai
            }).ToList();
        }

        #endregion Prepare data

        #region Handle event

        /// <summary>
        /// Customize columns to display ordinal number columns
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            switch (e.Column.FieldName)
            {
                case "STT":
                    e.DisplayText = (e.ListSourceRowIndex + 1).ToString();
                    break;

                case "TrangThai":
                    e.DisplayText = (bool)e.Value ? "Đã hoàn thành" : "Chưa hoàn thành";
                    break;

                case "NgayLap":
                    e.DisplayText = DateTime.Parse(e.Value.ToString()).ToString("dd/MM/yyyy HH:mm:ss");
                    break;
            }
        }

        private void GridView1_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.RowHandle == gridView1.FocusedRowHandle && e.Column == Action)
                e.RepositoryItem = repositoryItemButtonEdit1;
        }

        private void GridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.RowHandle == gridView1.FocusedRowHandle && e.Column == Action)
                e.RepositoryItem = repositoryItemButtonEdit1;
        }

        private void RepositoryItemButtonEdit1_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            EditorButton button = e.Button;
            int indexRowSelected = gridView1.GetSelectedRows()[0];
            switch (button.Caption)
            {
                case "Xuất file Excel":
                    // Create a report
                    string id = gridView1.GetRowCellValue(indexRowSelected, "MaPhieuDat").ToString();
                    ReportOrder reportOrder = new ReportOrder()
                    {
                        Name = "Thong tin dat hang " + id
                    };
                    reportOrder.Parameters["MaPhieuDat"].Value = id;
                    // Specify export options
                    XlsxExportOptions xlsxExportOptions = new XlsxExportOptions()
                    {
                        ExportMode = XlsxExportMode.SingleFile,
                    };

                    using (var folderBrowserDialog = new FolderBrowserDialog())
                    {
                        DialogResult result = folderBrowserDialog.ShowDialog();

                        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                        {
                            string path = $"{folderBrowserDialog.SelectedPath}\\{reportOrder.Name}.xlsx";
                            // Export the report
                            reportOrder.ExportToXlsx(path, xlsxExportOptions);

                            // Open file after export
                            System.Diagnostics.Process.Start(path);
                        }
                    }
                    break;

                case "Nhập hàng":
                    string orderID = gridView1.GetRowCellValue(indexRowSelected, "MaPhieuDat").ToString();
                    FormImportGoods formImportGoods = new FormImportGoods(PhieuDatHangBLL.GetOrder(orderID));
                    formImportGoods.FormClosed += (o, evt) =>
                    {
                        if (formImportGoods.IsDone)
                        {
                            Close();
                            Program.FormLogin.FormMain.btnListOfOrders.PerformClick();
                        }
                    };
                    formImportGoods.ShowDialog();
                    break;
            }
        }

        #endregion Handle event
    }
}