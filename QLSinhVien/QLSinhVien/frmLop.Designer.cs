
namespace QLSinhVien
{
    partial class frmLop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbbGiaoVien = new System.Windows.Forms.GroupBox();
            this.cbbMaGV = new System.Windows.Forms.ComboBox();
            this.btnDeleteGV = new System.Windows.Forms.Button();
            this.btnEditGV = new System.Windows.Forms.Button();
            this.btnAddGV = new System.Windows.Forms.Button();
            this.btnNewGV = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHeDaoTao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.cbbGiaoVien.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbGiaoVien
            // 
            this.cbbGiaoVien.Controls.Add(this.cbbMaGV);
            this.cbbGiaoVien.Controls.Add(this.btnDeleteGV);
            this.cbbGiaoVien.Controls.Add(this.btnEditGV);
            this.cbbGiaoVien.Controls.Add(this.btnAddGV);
            this.cbbGiaoVien.Controls.Add(this.btnNewGV);
            this.cbbGiaoVien.Controls.Add(this.label4);
            this.cbbGiaoVien.Controls.Add(this.txtHeDaoTao);
            this.cbbGiaoVien.Controls.Add(this.label3);
            this.cbbGiaoVien.Controls.Add(this.txtTenLop);
            this.cbbGiaoVien.Controls.Add(this.label2);
            this.cbbGiaoVien.Controls.Add(this.txtMaLop);
            this.cbbGiaoVien.Controls.Add(this.label1);
            this.cbbGiaoVien.Location = new System.Drawing.Point(13, 13);
            this.cbbGiaoVien.Name = "cbbGiaoVien";
            this.cbbGiaoVien.Size = new System.Drawing.Size(298, 425);
            this.cbbGiaoVien.TabIndex = 0;
            this.cbbGiaoVien.TabStop = false;
            this.cbbGiaoVien.Text = "Thông Tin Lớp";
            // 
            // cbbMaGV
            // 
            this.cbbMaGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaGV.FormattingEnabled = true;
            this.cbbMaGV.Location = new System.Drawing.Point(105, 194);
            this.cbbMaGV.Name = "cbbMaGV";
            this.cbbMaGV.Size = new System.Drawing.Size(181, 24);
            this.cbbMaGV.TabIndex = 8;
            // 
            // btnDeleteGV
            // 
            this.btnDeleteGV.Location = new System.Drawing.Point(171, 316);
            this.btnDeleteGV.Name = "btnDeleteGV";
            this.btnDeleteGV.Size = new System.Drawing.Size(115, 35);
            this.btnDeleteGV.TabIndex = 4;
            this.btnDeleteGV.Text = "Xóa";
            this.btnDeleteGV.UseVisualStyleBackColor = true;
            this.btnDeleteGV.Click += new System.EventHandler(this.btnDeleteGV_Click);
            // 
            // btnEditGV
            // 
            this.btnEditGV.Location = new System.Drawing.Point(11, 316);
            this.btnEditGV.Name = "btnEditGV";
            this.btnEditGV.Size = new System.Drawing.Size(115, 35);
            this.btnEditGV.TabIndex = 5;
            this.btnEditGV.Text = "Sửa";
            this.btnEditGV.UseVisualStyleBackColor = true;
            this.btnEditGV.Click += new System.EventHandler(this.btnEditGV_Click);
            // 
            // btnAddGV
            // 
            this.btnAddGV.Location = new System.Drawing.Point(171, 260);
            this.btnAddGV.Name = "btnAddGV";
            this.btnAddGV.Size = new System.Drawing.Size(115, 35);
            this.btnAddGV.TabIndex = 6;
            this.btnAddGV.Text = "Thêm";
            this.btnAddGV.UseVisualStyleBackColor = true;
            this.btnAddGV.Click += new System.EventHandler(this.btnAddGV_Click);
            // 
            // btnNewGV
            // 
            this.btnNewGV.Location = new System.Drawing.Point(11, 260);
            this.btnNewGV.Name = "btnNewGV";
            this.btnNewGV.Size = new System.Drawing.Size(115, 35);
            this.btnNewGV.TabIndex = 7;
            this.btnNewGV.Text = "Làm Mới";
            this.btnNewGV.UseVisualStyleBackColor = true;
            this.btnNewGV.Click += new System.EventHandler(this.btnNewGV_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã GV";
            // 
            // txtHeDaoTao
            // 
            this.txtHeDaoTao.Location = new System.Drawing.Point(105, 139);
            this.txtHeDaoTao.Name = "txtHeDaoTao";
            this.txtHeDaoTao.Size = new System.Drawing.Size(181, 22);
            this.txtHeDaoTao.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hệ Đào Tạo";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(105, 89);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(181, 22);
            this.txtTenLop.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Lớp";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(105, 42);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(181, 22);
            this.txtMaLop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Lớp";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvLop);
            this.groupBox2.Location = new System.Drawing.Point(318, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Lớp Học";
            // 
            // dgvLop
            // 
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Location = new System.Drawing.Point(7, 22);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.RowHeadersWidth = 51;
            this.dgvLop.RowTemplate.Height = 24;
            this.dgvLop.Size = new System.Drawing.Size(657, 398);
            this.dgvLop.TabIndex = 0;
            this.dgvLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLop_CellClick);
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbbGiaoVien);
            this.Name = "frmLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLop";
            this.Load += new System.EventHandler(this.frmLop_Load);
            this.cbbGiaoVien.ResumeLayout(false);
            this.cbbGiaoVien.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cbbGiaoVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHeDaoTao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteGV;
        private System.Windows.Forms.Button btnEditGV;
        private System.Windows.Forms.Button btnAddGV;
        private System.Windows.Forms.Button btnNewGV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.ComboBox cbbMaGV;
    }
}