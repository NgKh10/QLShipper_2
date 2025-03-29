using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLShipper.GUI
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogoLogin_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void User_Textbox(object sender, EventArgs e)
        {
            
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Tên đăng nhập")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;

            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Tên đăng nhập";
                txtUser.ForeColor = Color.Gainsboro;

            }
        }

        private void Password_Textbox(object sender, EventArgs e)
        {

        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "Mật khẩu")
            {
                txtpassword.Text = "";
                txtpassword.ForeColor = Color.Black;
                txtpassword.UseSystemPasswordChar = true;

            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "Mật khẩu";
                txtpassword.ForeColor = Color.Gainsboro;
                txtpassword.UseSystemPasswordChar = false;


            }
        }

        private void DangNhapButton_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtpassword.Text == "123")
            {
                this.Hide();
                KhachHang khachHang = new KhachHang();
                khachHang.ShowDialog();
                this.Close();
            }
            else if(txtUser.Text == "nv123" && txtpassword.Text == "123")
            {
                this.Hide();
                Nhanvien nhanvien = new Nhanvien(); 
                nhanvien.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc sai mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ThoatButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
           toolTip2.SetToolTip(txtUser, "Tên đăng nhập không phân biệt chữ hoa chữ thường");
           //toolTip.SetToolTip(btnEyePass, "Hiển thị mật khẩu");
           //toolTip.SetToolTip(btnEyeClosePass, "Ẩn mật khẩu");
           //toolTip.SetToolTip(btnKhach, "Đăng nhập với tư cách là khách hàng (người xem) không cần tên đăng nhập và mật khẩu");
           txtUser_Leave(null, new EventArgs());
           txtpassword_Leave(null, new EventArgs());
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}

