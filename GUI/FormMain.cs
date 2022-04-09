using System.Windows.Forms;

namespace GUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnPOS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormPOS formPOS = new FormPOS
            {
                MdiParent = this,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None
            };
            formPOS.Show();
        }
    }
}