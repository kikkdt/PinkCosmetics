using BLL;
using DTO;
using System.Windows.Forms;

namespace GUI.UserComponents
{
    public partial class Cart : UserControl
    {
        /// <summary>
        /// Sales invoice ID
        /// </summary>
        public string InvoiceID { get; set; }

        /// <summary>
        /// Customer
        /// </summary>
        public tb_KhachHang Customer { get; set; }

        /// <summary>
        /// Container of cart item
        /// </summary>
        public FlowLayoutPanel PanelCart { get => panelCart; set => panelCart = value; }

        public Label LabelTotalAmount { get => lblTotalAmount; set => lblTotalAmount = value; }

        public Cart()
        {
            InitializeComponent();

            InvoiceID = HoaDonBanBLL.CreateSalesInvoiceID();
        }

        /// <summary>
        /// Calculate the total amount of all products currently in the cart
        /// </summary>
        /// <returns>Total amount of cart</returns>
        public double GetTotalAmount()
        {
            double totalAmount = 0;
            foreach (CartItem item in panelCart.Controls)
            {
                totalAmount += (double)item.SalesInvoiceDetail.ThanhTien;
            }
            return totalAmount;
        }

        /// <summary>
        /// Display the total amount of all products currently in the cart
        /// </summary>
        public void UpdateTotalAmount()
        {
            lblTotalAmount.Text = Utilities.FormatWithThousandSeparator(GetTotalAmount(), "VNĐ");
        }

        private void PanelCart_ControlAdded(object sender, ControlEventArgs e)
        {
            UpdateTotalAmount();
        }

        private void PanelCart_ControlRemoved(object sender, ControlEventArgs e)
        {
            UpdateTotalAmount();
        }
    }
}