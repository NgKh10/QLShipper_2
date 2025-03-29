using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace QLShipper.GUI
{
    public partial class Nhanvien : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        string connectstring = @"Data Source=NGOCKHUE_10;Initial Catalog=QuanLigiaonhanhang;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();
        public Nhanvien()
        {
            
            InitializeComponent();
        }

        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControl1_Click(object sender, EventArgs e)
        {

        }

        private void Ttincanhan_Click(object sender, EventArgs e)
        {
            ThongtincanhanNv.SelectedTab = tabTtcnNV;
        }

        private void ThoatNv_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); // Đóng all 
            }
        }

        private void ReturnNv_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
            this.Close();
        }

        private void Dsdonhang_Click(object sender, EventArgs e)
        {
            ThongtincanhanNv.SelectedTab = tabDsdhNV;
        }

        private void tabDsdhNV_Click(object sender, EventArgs e)
        {

        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectstring); 
          }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
                con.Open();
                cmd = new SqlCommand("Select * FROM dm_NhanVien", con);
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            } 
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabTtcnNV_Click(object sender, EventArgs e)
        {

        }
    }
}
