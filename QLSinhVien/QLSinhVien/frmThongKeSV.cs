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
    public partial class frmThongKeSV : Form
    {
        public frmThongKeSV()
        {
            InitializeComponent();
        }

        public void Load_Data()
        {
            string str = @"select * from LyLichSinhVien";
            DataTable dt = conectDB.getDataTable(str);
            dgvSinhvien.DataSource = dt;
            dgvSinhvien.AutoResizeColumns();
            dgvSinhvien.Columns[0].HeaderText = "Mã SV";
            dgvSinhvien.Columns[1].HeaderText = "Tên SV";
            dgvSinhvien.Columns[2].HeaderText = "SĐT";
            dgvSinhvien.Columns[3].HeaderText = "Hộ Khẩu";
            dgvSinhvien.Columns[4].HeaderText = "Email";
            dgvSinhvien.Columns[5].HeaderText = "Ngày Sinh";
            dgvSinhvien.Columns[6].HeaderText = "CCCD";
            dgvSinhvien.Columns[7].HeaderText = "Ngày Cấp";
            dgvSinhvien.Columns[8].HeaderText = "Nơi Cấp";
            dgvSinhvien.Columns[9].HeaderText = "Đối Tượng";
            dgvSinhvien.Columns[10].HeaderText = "Khu Vực";
            dgvSinhvien.Columns[11].HeaderText = "Dân Tộc";
            dgvSinhvien.Columns[12].HeaderText = "Tôn Giáo";
            dgvSinhvien.Columns[13].HeaderText = "Ngày Vào Đoàn";
            dgvSinhvien.Columns[14].HeaderText = "Ngày Vào Đảng";
            dgvSinhvien.Columns[15].HeaderText = "Ngày Vào Hội";
            dgvSinhvien.Columns[16].HeaderText = "Số Năm BD";
            dgvSinhvien.Columns[17].HeaderText = "Họ Tên Cha";
            dgvSinhvien.Columns[18].HeaderText = "Nghề Nghiệp";
            dgvSinhvien.Columns[19].HeaderText = "Họ Tên Mẹ";
            dgvSinhvien.Columns[20].HeaderText = "Nghề nghiệp";
            dgvSinhvien.Columns[21].HeaderText = "Thành Phần GĐ";
            dgvSinhvien.Columns[22].HeaderText = "Họ Tên LL";
            dgvSinhvien.Columns[23].HeaderText = "Địa Chỉ";
            dgvSinhvien.Columns[24].HeaderText = "Địa Chỉ TT";
            dgvSinhvien.Columns[25].HeaderText = "KTX";
            dgvSinhvien.Columns[26].HeaderText = "Mã Lớp";
            //dgvSinhvien.Columns[8].DefaultCellStyle.Format = "N0";
            //dgvSinhvien.Columns[9].DefaultCellStyle.Format = "N0";
        }
        
        public void Load_cbbdt()
        {
            string dt = "select distinct DanToc from LyLichSinhVien";
            cbbDantoc.DisplayMember = "DanToc";
            cbbDantoc.ValueMember = "DanToc";
            cbbDantoc.DataSource = conectDB.getDataTable(dt);
            cbbDantoc.SelectedIndex = -1;

        }
        public void Load_cbblop()
        {
            string dt2 = "select distinct MaLop from LyLichSinhVien";
            cbbLop.DisplayMember = "MaLop";
            cbbLop.ValueMember = "MaLop";
            cbbLop.DataSource = conectDB.getDataTable(dt2);
            cbbLop.SelectedIndex = -1;

        }
        private void txtSearchSV_TextChanged(object sender, EventArgs e)
        {
            if(txtSearchSV.Text != "")
            {
                string ser = "select * from LyLichSinhVien where MaSV like N'" + txtSearchSV.Text
                + "' or TenSV like N'" + txtSearchSV.Text + "' or Sdt like N'" + txtSearchSV.Text
                + "'or CanCuocCD like N'" + txtSearchSV.Text + "'";
                DataTable dtf = conectDB.getDataTable(ser);
                dgvSinhvien.DataSource = dtf;
            }
            else
            {
                Load_Data();
            }
            
        }

        private void frmThongKeSV_Load(object sender, EventArgs e)
        {
            this.Load_Data();
            this.Load_cbbdt();
            this.Load_cbblop();
        }

        private void cbbDantoc_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbbDantoc.Text == "" && cbbLop.Text == "")
            {
                Load_Data();
            }
            else
            {
                if (cbbLop.Text == "")
                {
                    string sosanh = "select * from LyLichSinhVien where DanToc = N'" + cbbDantoc.SelectedValue + "'";
                    DataTable f = conectDB.getDataTable(sosanh);
                    dgvSinhvien.DataSource = f;
                }
                else
                {
                    string sosanh2 = "select * from LyLichSinhVien where DanToc = N'" + cbbDantoc.SelectedValue + "' and MaLop = N'"+cbbLop.SelectedValue+"'";
                    DataTable f2 = conectDB.getDataTable(sosanh2);
                    dgvSinhvien.DataSource = f2;
                }
                
            }
        }

        private void cbbLop_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbDantoc.Text == "" && cbbLop.Text == "")
            {
                Load_Data();
            }
            else
            {
                if (cbbDantoc.Text == "")
                {
                    string sosanh3 = "select * from LyLichSinhVien where MaLop = N'" + cbbLop.SelectedValue + "'";
                    DataTable f3 = conectDB.getDataTable(sosanh3);
                    dgvSinhvien.DataSource = f3;
                }
                else
                {
                    string sosanh2 = "select * from LyLichSinhVien where DanToc = N'" + cbbDantoc.SelectedValue + "' and MaLop = N'" + cbbLop.SelectedValue + "'";
                    DataTable f2 = conectDB.getDataTable(sosanh2);
                    dgvSinhvien.DataSource = f2;
                }

            }
        }

        private void txtSearchSV_TextChanged_1(object sender, EventArgs e)
        {
            if (txtSearchSV.Text != "")
            {
                string ser = "select * from LyLichSinhVien where MaSV like N'" + txtSearchSV.Text
                + "' or TenSV like N'" + txtSearchSV.Text + "' or Sdt like N'" + txtSearchSV.Text
                + "'or CanCuocCD like N'" + txtSearchSV.Text + "'";
                DataTable dtf = conectDB.getDataTable(ser);
                dgvSinhvien.DataSource = dtf;
            }
            else
            {
                Load_Data();
            }
        }

        private void cbbDantoc_TextChanged(object sender, EventArgs e)
        {
            if (cbbDantoc.Text == "" && cbbLop.Text == "")
            {
                Load_Data();
            }
            else
            {
                if (cbbLop.Text == "")
                {
                    string sosanh = "select * from LyLichSinhVien where DanToc = N'" + cbbDantoc.SelectedValue + "'";
                    DataTable f = conectDB.getDataTable(sosanh);
                    dgvSinhvien.DataSource = f;
                }
                else
                {
                    string sosanh2 = "select * from LyLichSinhVien where DanToc = N'" + cbbDantoc.SelectedValue + "' and MaLop = N'" + cbbLop.SelectedValue + "'";
                    DataTable f2 = conectDB.getDataTable(sosanh2);
                    dgvSinhvien.DataSource = f2;
                }

            }
        }

        public void test()
        {
            string sosanh3 = "select * from LyLichSinhVien where MaLop = N'" + cbbLop.SelectedValue + "'";
            DataTable f3 = conectDB.getDataTable(sosanh3);
            dgvSinhvien.DataSource = f3;
        }
        public void test2()
        {
            string sosanh2 = "select * from LyLichSinhVien where DanToc = N'" + cbbDantoc.SelectedValue + "' and MaLop = N'" + cbbLop.SelectedValue + "'";
            DataTable f2 = conectDB.getDataTable(sosanh2);
            dgvSinhvien.DataSource = f2;
        }

        private void cbbLop_TextChanged(object sender, EventArgs e)
        {
            if (cbbDantoc.Text == "" && cbbLop.Text == "")
            {
                Load_Data();
            }
            else
            {
                if (cbbDantoc.Text == "")
                {
                    test();  
                }
                else
                {
                    test2();
                }

            }
        }
    }
}
