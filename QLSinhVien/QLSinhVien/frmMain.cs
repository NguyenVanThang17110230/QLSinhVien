using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            Form sv = new frmSinhVien();
            sv.ShowDialog();
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            Form lop = new frmLop();
            lop.ShowDialog();
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            Form gv = new frmGiaoVien();
            gv.ShowDialog();
        }

        private void sinhvienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form tk = new frmThongKeSV();
            tk.ShowDialog();
        }
    }
}
