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
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien()
        {
            InitializeComponent();
        }

        public void Load_Data()
        {
            string str = @"select * from GiaoVien";
            DataTable dt = conectDB.getDataTable(str);
            dgvGiaoVien.DataSource = dt;
            dgvGiaoVien.AutoResizeColumns();
            dgvGiaoVien.Columns[0].HeaderText = "Mã GV";
            dgvGiaoVien.Columns[1].HeaderText = "Tên";
            dgvGiaoVien.Columns[2].HeaderText = "SĐT";
            dgvGiaoVien.Columns[3].HeaderText = "Email";
            dgvGiaoVien.Columns[4].HeaderText = "Bộ Môn";
            //set width
            dgvGiaoVien.Columns[0].Width = 80;
            dgvGiaoVien.Columns[1].Width = 120;
            dgvGiaoVien.Columns[2].Width = 120;
            dgvGiaoVien.Columns[3].Width = 120;
            dgvGiaoVien.Columns[4].Width = 120;

        }
        public void Load_New()
        {
            txtMaGV.Text = "";
            txtTenGV.Text = "";
            txtSDTGV.Text = "";
            txtEmail.Text = "";
            txtBoMon.Text = "";
            txtMaGV.Enabled = true;
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            this.Load_Data();
        }

        private void btnNewGV_Click(object sender, EventArgs e)
        {
            Load_New();
        }

        private void btnAddGV_Click(object sender, EventArgs e)
        {
            if (txtMaGV.Text != "" &&
               txtTenGV.Text != "" &&
               txtSDTGV.Text != "" &&
               txtEmail.Text != "" &&
               txtBoMon.Text != "")
            {
                try
                {
                    string set = "select * from GiaoVien where MaGV = N'" + txtMaGV.Text + "'";
                    DataTable dtt = conectDB.getDataTable(set);
                    if (dtt.Rows.Count > 0)
                    {
                        MessageBox.Show("Mã giáo viên đã tồn tại!!!", "Thông Báo");
                    }
                    else
                    {
                        string sdt = "select * from GiaoVien where SDTGV = N'" + txtSDTGV.Text + "'";
                        DataTable dtsdt = conectDB.getDataTable(sdt);
                        if (dtsdt.Rows.Count > 0)
                        {
                            MessageBox.Show("Số điện thoại đã tồn tại!!!", "Thông Báo");
                        }
                        else
                        {
                            string email = "select * from GiaoVien where Email = N'" + txtEmail.Text + "'";
                            DataTable dte = conectDB.getDataTable(email);
                            if (dte.Rows.Count > 0)
                            {
                                MessageBox.Show("Email giáo viên đã tồn tại!!!", "Thông Báo");
                            }
                            else
                            {
                                string insert = "Insert Into GiaoVien(MaGV,TenGV," +
                                "SDTGV,Email,BoMon)" + "Values(N'" + txtMaGV.Text + "',N'" + txtTenGV.Text + "',N'" + txtSDTGV.Text
                                + "',N'" + txtEmail.Text + "',N'" + txtBoMon.Text + "')";
                                conectDB.executeQuery(insert);
                                MessageBox.Show("Thêm Thanh Công!!", "Thông Báo");
                                Load_Data();
                                Load_New();
                            }
                        }
                        
                    }    
                }
                catch
                {
                    MessageBox.Show("Nhập sai rồi đó!!!", "Thông Báo");
                }

            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin trước khi thêm!!!", "Thông Báo");
            }
        }

        private void btnEditGV_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaGV.Text != "" &&
                    txtTenGV.Text != "" &&
                    txtSDTGV.Text != "" &&
                    txtEmail.Text != "" &&
                    txtBoMon.Text != "")
                {
                    string update = "Update GiaoVien set TenGV=N'" + txtTenGV.Text + "',SDTGV=N'" + txtSDTGV.Text
                              + "',Email=N'" + txtEmail.Text + "',BoMon=N'" + txtBoMon.Text + "' where MaGV='" + txtMaGV.Text + "'";
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
            string xoa = "delete from GiaoVien where MaGV = '" + txtMaGV.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa giao viên viên:" + txtMaGV.Text,
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

        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvGiaoVien.Rows[e.RowIndex];
                txtMaGV.Text = row.Cells[0].Value.ToString();
                txtTenGV.Text = row.Cells[1].Value.ToString();
                txtSDTGV.Text = row.Cells[2].Value.ToString();
                txtEmail.Text = row.Cells[3].Value.ToString();
                txtBoMon.Text = row.Cells[4].Value.ToString();
                txtMaGV.Enabled = false;
            }
            catch (Exception) { }
        }

        private void txtSDTGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
