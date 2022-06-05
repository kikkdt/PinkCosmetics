using BLL;
using DevExpress.XtraEditors.Controls;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

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
            switch (button.Caption)
            {
                case "Xuất file Excel":
                    break;

                case "Nhập hàng":
                    int indexRowSelected = gridView1.GetSelectedRows()[0];
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