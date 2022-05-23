﻿using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormPayment : Form
    {
        public tb_HoaDonBan SalesInvoice { get; set; }
        public List<tb_ChiTietHDBan> SalesInvoiceDetails { get; set; }

        /// <summary>
        /// Flag for successful payment
        /// </summary>
        public bool IsSuccess = false;

        public FormPayment(tb_HoaDonBan salesInvoice, List<tb_ChiTietHDBan> salesInvoiceDetails)
        {
            InitializeComponent();
            SalesInvoice = salesInvoice;
            SalesInvoiceDetails = salesInvoiceDetails;
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            if (SalesInvoice.MaKH != null)
            {
                tb_KhachHang customer = KhachHangBLL.GetCustomer(SalesInvoice.MaKH);
                lblCustomerName.Text = customer.HoTen;
                linkLoyalty.Text = $"Điểm tích luỹ: {Utilities.FormatWithThousandSeparator((double)customer.DiemTichLuy)}";
            }
            else
            {
                lblCustomerName.Text = "Khách lẻ";
                linkLoyalty.Visible = false;
            }
            lblTotalAmount.Text = Utilities.FormatWithThousandSeparator((double)SalesInvoice.TongTien);
            lblDiscount.Text = "0";
            lblNeedToPay.Text = Utilities.FormatWithThousandSeparator((double)SalesInvoice.ThanhTien);
            lblExcessCash.Text = "0";
        }

        /// <summary>
        /// Perform payout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPayout_Click(object sender, EventArgs e)
        {
            if (IsValidForm() && HoaDonBanHangBLL.Insert(SalesInvoice, SalesInvoiceDetails))
            {
                IsSuccess = true;
                Close();
            }
        }

        /// <summary>
        /// Open form loyalty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkLoyalty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLoyalty formLoyalty = new FormLoyalty(KhachHangBLL.GetCustomer(SalesInvoice.MaKH));
            formLoyalty.FormClosed += (o, evt) =>
            {
                // Update discount for sales invoice
                SalesInvoice.GiamGia = formLoyalty.LoyaltyUse;
                SalesInvoice.ThanhTien = SalesInvoice.TongTien - SalesInvoice.GiamGia;
                // Refresh label
                lblDiscount.Text = Utilities.FormatWithThousandSeparator((double)SalesInvoice.GiamGia);
                lblNeedToPay.Text = Utilities.FormatWithThousandSeparator((double)SalesInvoice.ThanhTien);
            };
            formLoyalty.ShowDialog();
        }

        private void SpinMoneyGiven_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private ErrorProvider error = new ErrorProvider();

        private void SpinMoneyGiven_TextChanged(object sender, EventArgs e)
        {
            double excessCash = double.Parse(spinMoneyGiven.Text) - double.Parse(lblNeedToPay.Text);
            lblExcessCash.Text = Utilities.FormatWithThousandSeparator(excessCash);

            if (excessCash < 0)
            {
                error.SetError(spinMoneyGiven, "Tiền khách đưa không hợp lệ.");
            }
            else
            {
                error.Clear();
            }
        }

        private bool IsValidForm()
        {
            double excessCash = double.Parse(spinMoneyGiven.Text) - double.Parse(lblNeedToPay.Text);
            return double.Parse(spinMoneyGiven.Text) >= 0 && excessCash >= 0;
        }
    }
}