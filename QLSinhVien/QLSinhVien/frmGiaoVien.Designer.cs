
namespace QLSinhVien
{
    partial class frmGiaoVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDTGV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoMon = new System.Windows.Forms.TextBox();
            this.btnNewGV = new System.Windows.Forms.Button();
            this.btnAddGV = new System.Windows.Forms.Button();
            this.btnEditGV = new System.Windows.Forms.Button();
            this.btnDeleteGV = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvGiaoVien = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteGV);
            this.groupBox1.Controls.Add(this.btnEditGV);
            this.groupBox1.Controls.Add(this.btnAddGV);
            this.groupBox1.Controls.Add(this.btnNewGV);
            this.groupBox1.Controls.Add(this.txtBoMon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSDTGV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenGV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaGV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 380);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Giáo Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Giáo Viên";
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(126, 37);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(176, 22);
            this.txtMaGV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Giáo Viên";
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(126, 84);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(176, 22);
            this.txtTenGV.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "SĐT Giáo Viên";
            // 
            // txtSDTGV
            // 
            this.txtSDTGV.Location = new System.Drawing.Point(126, 130);
            this.txtSDTGV.Name = "txtSDTGV";
            this.txtSDTGV.Size = new System.Drawing.Size(176, 22);
            this.txtSDTGV.TabIndex = 1;
            this.txtSDTGV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDTGV_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(126, 177);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(176, 22);
            this.txtEmail.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bộ Môn";
            // 
            // txtBoMon
            // 
            this.txtBoMon.Location = new System.Drawing.Point(126, 222);
            this.txtBoMon.Name = "txtBoMon";
            this.txtBoMon.Size = new System.Drawing.Size(176, 22);
            this.txtBoMon.TabIndex = 1;
            // 
            // btnNewGV
            // 
            this.btnNewGV.Location = new System.Drawing.Point(13, 274);
            this.btnNewGV.Name = "btnNewGV";
            this.btnNewGV.Size = new System.Drawing.Size(115, 35);
            this.btnNewGV.TabIndex = 2;
            this.btnNewGV.Text = "Làm Mới";
            this.btnNewGV.UseVisualStyleBackColor = true;
            this.btnNewGV.Click += new System.EventHandler(this.btnNewGV_Click);
            // 
            // btnAddGV
            // 
            this.btnAddGV.Location = new System.Drawing.Point(187, 274);
            this.btnAddGV.Name = "btnAddGV";
            this.btnAddGV.Size = new System.Drawing.Size(115, 35);
            this.btnAddGV.TabIndex = 2;
            this.btnAddGV.Text = "Thêm";
            this.btnAddGV.UseVisualStyleBackColor = true;
            this.btnAddGV.Click += new System.EventHandler(this.btnAddGV_Click);
            // 
            // btnEditGV
            // 
            this.btnEditGV.Location = new System.Drawing.Point(13, 330);
            this.btnEditGV.Name = "btnEditGV";
            this.btnEditGV.Size = new System.Drawing.Size(115, 35);
            this.btnEditGV.TabIndex = 2;
            this.btnEditGV.Text = "Sửa";
            this.btnEditGV.UseVisualStyleBackColor = true;
            this.btnEditGV.Click += new System.EventHandler(this.btnEditGV_Click);
            // 
            // btnDeleteGV
            // 
            this.btnDeleteGV.Location = new System.Drawing.Point(187, 330);
            this.btnDeleteGV.Name = "btnDeleteGV";
            this.btnDeleteGV.Size = new System.Drawing.Size(115, 35);
            this.btnDeleteGV.TabIndex = 2;
            this.btnDeleteGV.Text = "Xóa";
            this.btnDeleteGV.UseVisualStyleBackColor = true;
            this.btnDeleteGV.Click += new System.EventHandler(this.btnDeleteGV_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvGiaoVien);
            this.groupBox2.Location = new System.Drawing.Point(332, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(835, 380);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Giáo Viên";
            // 
            // dgvGiaoVien
            // 
            this.dgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoVien.Location = new System.Drawing.Point(6, 21);
            this.dgvGiaoVien.Name = "dgvGiaoVien";
            this.dgvGiaoVien.RowHeadersWidth = 51;
            this.dgvGiaoVien.RowTemplate.Height = 24;
            this.dgvGiaoVien.Size = new System.Drawing.Size(817, 353);
            this.dgvGiaoVien.TabIndex = 0;
            this.dgvGiaoVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaoVien_CellClick);
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 401);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGiaoVien";
            this.Load += new System.EventHandler(this.frmGiaoVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoMon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDTGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteGV;
        private System.Windows.Forms.Button btnEditGV;
        private System.Windows.Forms.Button btnAddGV;
        private System.Windows.Forms.Button btnNewGV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvGiaoVien;
    }
}