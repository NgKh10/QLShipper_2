using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLShipper.GUI
{
    public partial class KhachHang : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public KhachHang()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.Manual; // Tự định vị form
            this.Bounds = Screen.PrimaryScreen.Bounds; // Chiếm toàn bộ màn hình
        }


        private void KhachHangForm_Click(object sender, EventArgs e)
        {

        }

        private void accordionControl1_Click(object sender, EventArgs e)
        {

        }


        private void imageSlider1_Click(object sender, EventArgs e)
        {

        }

        private void fluentDesignFormControl1_Click(object sender, EventArgs e)
        {

        }

        private void Ttincanhan_Click(object sender, EventArgs e)
        {
            TtincanhanKH.SelectedTab = tabTtincanhanKH;

        }

        private void DonHangofKh_Click(object sender, EventArgs e)
        {
            TtincanhanKH.SelectedTab = tabDonhangKH;
        }

        private void Voucher_Click(object sender, EventArgs e)
        {
            TtincanhanKH.SelectedTab = tabVoucher;
        }

        private void DanhGia_Click(object sender, EventArgs e)
        {
            TtincanhanKH.SelectedTab = tabDanhgia;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); // Đóng all 
            }

        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
            this.Close();
        }


        private void ThongtincanhanPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void DonhangPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabPage4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabPage3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Donhang_Paint(object sender, PaintEventArgs e)
        {

        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewDonHang_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            TtincanhanKH.Appearance = TabAppearance.FlatButtons;
            TtincanhanKH.ItemSize = new Size(0, 1);  // Thu nho header tab 
            TtincanhanKH.SizeMode = TabSizeMode.Fixed;
        }

        private void TimDH_Enter(object sender, EventArgs e)
        {
            if (TimDH.Text == "Tìm")
            {
                TimDH.Text = "";
                TimDH.ForeColor = Color.Black;
            }
        }

        private void TimDH_Leave(object sender, EventArgs e)
        {
            if (TimDH.Text == "")
            {
                TimDH.Text = "Tìm";
                TimDH.ForeColor = Color.Gainsboro;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
