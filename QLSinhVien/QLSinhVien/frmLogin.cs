using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Data.SqlClient;
using System.Data;
using QLSinhVienDB;


namespace QLSinhVien
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản và mật khẩu", "Thông báo");
                return;
            }
            DataTable dt = conectDB.getDataTable("select * from TaiKhoan where UserName = '" + txtUsername.Text
                + "' and PassWord = '" + txtPassword.Text + "'");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Xin chào " + txtUsername.Text + "! Bạn đã đăng nhập thành công!", "Thông báo");
                this.Hide();
                Form main = new frmMain();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công!", "Thông báo");
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }
    }
}
