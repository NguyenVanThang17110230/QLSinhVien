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
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }

        public void Load_Data()
        {
            string str = @"select * from LyLichSinhVien";
            DataTable dt = conectDB.getDataTable(str);
            dgvSinhVien.DataSource = dt;
            dgvSinhVien.AutoResizeColumns();
            dgvSinhVien.Columns[0].HeaderText = "Mã SV";
            dgvSinhVien.Columns[1].HeaderText = "Tên SV";
            dgvSinhVien.Columns[2].HeaderText = "SĐT";
            dgvSinhVien.Columns[3].HeaderText = "Hộ Khẩu";
            dgvSinhVien.Columns[4].HeaderText = "Email";
            dgvSinhVien.Columns[5].HeaderText = "Ngày Sinh";
            dgvSinhVien.Columns[6].HeaderText = "CCCD";
            dgvSinhVien.Columns[7].HeaderText = "Ngày Cấp";
            dgvSinhVien.Columns[8].HeaderText = "Nơi Cấp";
            dgvSinhVien.Columns[9].HeaderText = "Đối Tượng";
            dgvSinhVien.Columns[10].HeaderText = "Khu Vực";
            dgvSinhVien.Columns[11].HeaderText = "Dân Tộc";
            dgvSinhVien.Columns[12].HeaderText = "Tôn Giáo";
            dgvSinhVien.Columns[13].HeaderText = "Ngày Vào Đoàn";
            dgvSinhVien.Columns[14].HeaderText = "Ngày Vào Đảng";
            dgvSinhVien.Columns[15].HeaderText = "Ngày Vào Hội";
            dgvSinhVien.Columns[16].HeaderText = "Số Năm BD";
            dgvSinhVien.Columns[17].HeaderText = "Họ Tên Cha";
            dgvSinhVien.Columns[18].HeaderText = "Nghề Nghiệp";
            dgvSinhVien.Columns[19].HeaderText = "Họ Tên Mẹ";
            dgvSinhVien.Columns[20].HeaderText = "Nghề nghiệp";
            dgvSinhVien.Columns[21].HeaderText = "Thành Phần GĐ";
            dgvSinhVien.Columns[22].HeaderText = "Họ Tên LL";
            dgvSinhVien.Columns[23].HeaderText = "Địa Chỉ";
            dgvSinhVien.Columns[24].HeaderText = "Địa Chỉ TT";
            dgvSinhVien.Columns[25].HeaderText = "KTX";
            dgvSinhVien.Columns[26].HeaderText = "Mã Lớp";
            //dgvSinhVien.Columns[8].DefaultCellStyle.Format = "N0";
            //dgvSinhVien.Columns[9].DefaultCellStyle.Format = "N0";
        }
        public void Load_New()
        {
            this.txtMasv.Text = "";
            this.txtTensv.Text = "";
            this.txtSdt.Text = "";
            this.txtHokhau.Text = "";
            this.txtEmail.Text = "";
            this.dtpNgaysinh.Text = "";
            this.txtCancuoc.Text = "";
            this.dtpNgaycap.Text = "";
            this.txtNoicap.Text = "";
            this.txtDoituong.Text = "";
            this.txtKhuvuc.Text = "";
            this.txtDantoc.Text = "";
            this.txtTongiao.Text = "";
            this.dtpNgayvaodoan.Text = "";
            this.dtpNgayvaodang.Text = "";
            this.dtpNgayvaohoi.Text = "";
            this.cbbSonambd.Text = "";
            this.txtHotencha.Text = "";
            this.txtNghenghiepcha.Text = "";
            this.txtHotenme.Text = "";
            this.txtNghenghiepme.Text = "";
            this.txtThanhphangd.Text = "";
            this.txtLienlac.Text = "";
            this.txtDiachill.Text = "";
            this.txtDiachitt.Text = "";
            this.txtKtx.Text = "";
            this.cbbMalop.Text = "";
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            Load_New();
        }
        public void Load_cbb()
        {
            string cbb = "select * from Lop";
            cbbMalop.DisplayMember = "TenLop";
            cbbMalop.ValueMember = "MaLop";
            cbbMalop.DataSource = conectDB.getDataTable(cbb);
            cbbMalop.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMasv.Text != "" && 
                txtTensv.Text != "" &&
                txtSdt.Text != "" &&
                txtHokhau.Text != "" &&
                txtEmail.Text != "" &&
                dtpNgaysinh.Text!="" &&
                txtCancuoc.Text !="" &&
                dtpNgaycap.Text != "" &&
                txtNoicap.Text != "" &&
                txtDoituong.Text != "" &&
                txtKhuvuc.Text != "" &&
                txtDantoc.Text != "" &&
                txtTongiao.Text != "" &&
                dtpNgayvaodoan.Text != "" &&
                dtpNgayvaodang.Text != "" &&
                dtpNgayvaohoi.Text != "" &&
                cbbSonambd.Text != "" &&
                txtHotencha.Text != "" &&
                txtNghenghiepcha.Text != "" &&
                txtHotenme.Text != "" &&
                txtNghenghiepme.Text != "" &&
                txtThanhphangd.Text != "" &&
                txtLienlac.Text != "" &&
                txtDiachill.Text != "" &&
                txtDiachitt.Text != "" &&
                txtKtx.Text != "" &&
                cbbMalop.Text != "")
            {
                try
                {
                    string masv = "select * from LyLichSinhVien where MaSV = N'" + txtMasv.Text + "'";
                    DataTable dtma = conectDB.getDataTable(masv);
                    if (dtma.Rows.Count > 0)
                    {
                        MessageBox.Show("Mã sinh viên đã tồn tại!!!", "Thông Báo");
                    }
                    else
                    {
                        string cc = "select * from LyLichSinhVien where CanCuocCD = N'" + txtCancuoc.Text + "'";
                        DataTable dtcc = conectDB.getDataTable(cc);
                        if (dtcc.Rows.Count > 0)
                        {
                            MessageBox.Show("Căn cước công dân đã tồn tại!!!", "Thông Báo");
                        }
                        else
                        {
                            string mail = "select * from LyLichSinhVien where Email = N'" + txtEmail.Text + "'";
                            DataTable dtm = conectDB.getDataTable(mail);
                            if (dtm.Rows.Count > 0)
                            {
                                MessageBox.Show("Email sinh viên đã tồn tại!!!", "Thông Báo");
                            }
                            else
                            {
                                string insert = "Insert Into LyLichSinhVien(MaSV,TenSV," +
                                "SDT,HoKhau,Email,NgaySinh,CancuocCD,NgayCap,NoiCap," +
                                "DoiTuong,KhuVuc,DanToc,TonGiao,NgayVaoDoan,NgayVaoDang," +
                                "NgayVaoHoi,SoNamBoDoi,HoTenCha,NgheNghiepCha,HoTenMe,NgheNghiepMe,ThanhPhanGD," +
                                "HoTenLienLac,DiaChiLienLac,DiaChiTamTru,PhongKTX,MaLop)" +
                                "Values(N'" + txtMasv.Text + "',N'" + txtTensv.Text + "',N'" + txtSdt.Text
                                 + "',N'" + txtHokhau.Text + "',N'" + txtEmail.Text + "',N'" + dtpNgaysinh.Text
                                 + "',N'" + txtCancuoc.Text + "','" + dtpNgaycap.Text + "',N'" + txtNoicap.Text
                                 + "',N'" + txtDoituong.Text + "',N'" + txtKhuvuc.Text + "',N'" + txtDantoc.Text
                                 + "',N'" + txtTongiao.Text + "','" + dtpNgayvaodoan.Text + "','" + dtpNgayvaodang.Text
                                 + "','" + dtpNgayvaohoi.Text + "','" + cbbSonambd.Text + "',N'" + txtHotencha.Text
                                 + "',N'" + txtNghenghiepcha.Text + "',N'" + txtHotenme.Text + "',N'" + txtNghenghiepme.Text
                                 + "',N'" + txtThanhphangd.Text + "',N'" + txtLienlac.Text + "',N'" + txtDiachill.Text
                                 + "',N'" + txtDiachitt.Text + "',N'" + txtKtx.Text + "',N'" + cbbMalop.SelectedValue
                                 + "')";
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMasv.Text != "" &&
                txtTensv.Text != "" &&
                txtSdt.Text != "" &&
                txtHokhau.Text != "" &&
                txtEmail.Text != "" &&
                dtpNgaysinh.Text != "" &&
                txtCancuoc.Text != "" &&
                dtpNgaycap.Text != "" &&
                txtNoicap.Text != "" &&
                txtDoituong.Text != "" &&
                txtKhuvuc.Text != "" &&
                txtDantoc.Text != "" &&
                txtTongiao.Text != "" &&
                dtpNgayvaodoan.Text != "" &&
                dtpNgayvaodang.Text != "" &&
                dtpNgayvaohoi.Text != "" &&
                cbbSonambd.Text != "" &&
                txtHotencha.Text != "" &&
                txtNghenghiepcha.Text != "" &&
                txtHotenme.Text != "" &&
                txtNghenghiepme.Text != "" &&
                txtThanhphangd.Text != "" &&
                txtLienlac.Text != "" &&
                txtDiachill.Text != "" &&
                txtDiachitt.Text != "" &&
                txtKtx.Text != "" &&
                cbbMalop.Text != "")
                {
                    string update = "Update LyLichSinhVien set TenSV=N'" + txtTensv.Text + "',SDT=N'" + txtSdt.Text
                              + "',HoKhau=N'" + txtHokhau.Text + "',Email=N'" + txtEmail.Text + "',NgaySinh=N'" + dtpNgaysinh.Text
                              + "',CanCuocCD=N'" + txtCancuoc.Text + "',NgayCap='" + dtpNgaycap.Text + "',NoiCap=N'" + txtNoicap.Text
                              + "',DoiTuong=N'" + txtDoituong.Text + "',KhuVuc=N'" + txtKhuvuc.Text + "',DanToc=N'" + txtDantoc.Text
                              + "',TonGiao=N'" + txtTongiao.Text + "',NgayVaoDoan='" + dtpNgayvaodoan.Text + "',NgayVaoDang='" + dtpNgayvaodang.Text
                              + "',NgayVaoHoi='" + dtpNgayvaohoi.Text + "',SoNamBoDoi='" + cbbSonambd.Text + "',HoTenCha=N'" + txtHotencha.Text
                              + "',NgheNghiepCha=N'" + txtNghenghiepcha.Text + "',HoTenMe=N'" + txtHotenme.Text + "',NgheNghiepMe=N'" + txtNghenghiepme.Text
                              + "',ThanhPhanGD=N'" + txtThanhphangd.Text + "',HoTenLienLac=N'" + txtLienlac.Text + "',DiaChiLienLac=N'" + txtDiachill.Text
                              + "',DiaChiTamTru=N'" + txtDiachitt.Text + "',PhongKTX=N'" + txtKtx.Text + "',MaLop=N'" + cbbMalop.SelectedValue
                              + "' where MaSV='" + txtMasv.Text + "'";
                    conectDB.executeQuery(update);
                    MessageBox.Show("Sửa Thông Tin Thành Công", "Thông Báo");
                    Load_Data();
                }
                else
                {
                    MessageBox.Show("Hãy nhập đầy đủ thông tin trước khi sửa", "Thông Báo");
                }  
               
            }
            catch
            {
                MessageBox.Show("Nhập sai thông tin rồi!!!!", "Thông Báo");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string xoa = "delete from LyLichSinhVien where MaSV = '" + txtMasv.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa sinh viên:" + txtMasv.Text,
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

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            this.Load_Data();
            this.Load_cbb();
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvSinhVien.Rows[e.RowIndex];
                txtMasv.Text = row.Cells[0].Value.ToString();
                txtTensv.Text = row.Cells[1].Value.ToString();
                txtSdt.Text = row.Cells[2].Value.ToString();
                txtHokhau.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
                dtpNgaysinh.Text = row.Cells[5].Value.ToString();
                txtCancuoc.Text = row.Cells[6].Value.ToString();
                dtpNgaycap.Text = row.Cells[7].Value.ToString();
                txtNoicap.Text = row.Cells[8].Value.ToString();
                txtDoituong.Text = row.Cells[9].Value.ToString();
                txtKhuvuc.Text = row.Cells[10].Value.ToString();
                txtDantoc.Text = row.Cells[11].Value.ToString();
                txtTongiao.Text = row.Cells[12].Value.ToString();
                dtpNgayvaodoan.Text = row.Cells[13].Value.ToString();
                dtpNgayvaodang.Text = row.Cells[14].Value.ToString();
                dtpNgayvaohoi.Text = row.Cells[15].Value.ToString();
                cbbSonambd.Text = row.Cells[16].Value.ToString();
                txtHotencha.Text = row.Cells[17].Value.ToString();
                txtNghenghiepcha.Text = row.Cells[18].Value.ToString();
                txtHotenme.Text = row.Cells[19].Value.ToString();
                txtNghenghiepme.Text = row.Cells[20].Value.ToString();
                txtThanhphangd.Text = row.Cells[21].Value.ToString();
                txtLienlac.Text = row.Cells[22].Value.ToString();
                txtDiachill.Text = row.Cells[23].Value.ToString();
                txtDiachitt.Text = row.Cells[24].Value.ToString();
                txtKtx.Text = row.Cells[25].Value.ToString();
                cbbMalop.Text = row.Cells[26].Value.ToString();
               
            }
            catch (Exception) { }
        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
