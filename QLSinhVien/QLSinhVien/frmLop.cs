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
    public partial class frmLop : Form
    {
        public frmLop()
        {
            InitializeComponent();
        }
        public void Load_Data()
        {
            string str = @"select * from Lop";
            DataTable dt = conectDB.getDataTable(str);
            dgvLop.DataSource = dt;
            dgvLop.AutoResizeColumns();
            dgvLop.Columns[0].HeaderText = "Mã Lớp";
            dgvLop.Columns[1].HeaderText = "Tên Lớp";
            dgvLop.Columns[2].HeaderText = "Hệ Đào Tạo";
            dgvLop.Columns[3].HeaderText = "Mã GV";
            //set width
            dgvLop.Columns[0].Width = 80;
            dgvLop.Columns[1].Width = 120;
            dgvLop.Columns[2].Width = 120;
            dgvLop.Columns[3].Width = 120;
            

        }
        public void Load_New()
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtHeDaoTao.Text = "";
            cbbMaGV.Text = "";
        }
        public void Load_cbb()
        {
            string cbb = "select * from GiaoVien";
            cbbMaGV.DisplayMember = "TenGV";
            cbbMaGV.ValueMember = "MaGV";
            cbbMaGV.DataSource = conectDB.getDataTable(cbb);
            cbbMaGV.SelectedIndex = -1;
        }
        private void frmLop_Load(object sender, EventArgs e)
        {
            Load_Data();
            this.Load_cbb();
        }

        private void btnNewGV_Click(object sender, EventArgs e)
        {
            Load_New();
        }

        private void btnAddGV_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text != "" &&
               txtTenLop.Text != "" &&
               txtHeDaoTao.Text != "" &&
               cbbMaGV.Text != "")
            {
                try
                {
                    string ma = "select * from Lop where MaLop=N'" + txtMaLop.Text + "'";
                    DataTable dt =conectDB.getDataTable(ma);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Mã lớp này đã tồn tại rồi!!!", "Thông Báo");
                    }
                    else
                    {
                        string insert = "Insert Into Lop(MaLop,TenLop," +
                        "HeDaoTao,MaGV)" + "Values(N'" + txtMaLop.Text + "',N'" + txtTenLop.Text + "',N'" + txtHeDaoTao.Text
                             + "',N'" + cbbMaGV.Text + "')";
                        conectDB.executeQuery(insert);
                        MessageBox.Show("Thêm Thanh Công!!", "Thông Báo");
                        Load_Data();
                        Load_New();
                    }
                }
                catch
                {
                    MessageBox.Show("Nhập sai rồi đó!!!", "Thông Báo");
                }

            }
            else
            {
                MessageBox.Show("Nhập thiếu rồi hãy nhập đủ trước khi thêm!!!", "Thông Báo");
            }
        }

        private void btnEditGV_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtMaLop.Text != "" &&
                   txtTenLop.Text != "" &&
                   txtHeDaoTao.Text != "" &&
                   cbbMaGV.Text != "")
                {
                    string update = "Update Lop set TenLop=N'" + txtTenLop.Text + "',HeDaoTao=N'" + txtHeDaoTao.Text
                                    + "',MaGV=N'" + cbbMaGV.SelectedValue + "' where MaLop='" + txtMaLop.Text + "'";
                    conectDB.executeQuery(update);
                    MessageBox.Show("Sửa Thông Tin Thành Công", "Thông Báo");
                    Load_Data();
                }
                else
                {
                    MessageBox.Show("Hãy nhập đầy đủ thông tin trước khi sửa!!!", "Thông Báo");
                }
            }
            catch
            {
                MessageBox.Show("Nhập sai thông tin rồi!!!!", "Thông Báo");
            }
        }

        private void btnDeleteGV_Click(object sender, EventArgs e)
        {
            string xoa = "delete from Lop where MaLop = '" + txtMaLop.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa giao viên viên:" + txtMaLop.Text,
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    conectDB.executeQuery(xoa);
                    Load_Data();
                    Load_New();
                }
                catch
                {
                    MessageBox.Show("Không Xóa Được Đâu!!!!", "Thông Báo");
                }
            }
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvLop.Rows[e.RowIndex];
                txtMaLop.Text = row.Cells[0].Value.ToString();
                txtTenLop.Text = row.Cells[1].Value.ToString();
                txtHeDaoTao.Text = row.Cells[2].Value.ToString();
                cbbMaGV.Text = row.Cells[3].Value.ToString();
                txtMaLop.Enabled = false;
               
            }
            catch (Exception) { }
        }
    }
}
