
namespace QLSinhVien
{
    partial class frmMain
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
            this.btnSinhVien = new System.Windows.Forms.Button();
            this.btnLop = new System.Windows.Forms.Button();
            this.btnGiaoVien = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qlsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qllopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qlgvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhvienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Location = new System.Drawing.Point(41, 154);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.Size = new System.Drawing.Size(202, 86);
            this.btnSinhVien.TabIndex = 0;
            this.btnSinhVien.Text = "Quản Lý Thông Tin Sinh Viên";
            this.btnSinhVien.UseVisualStyleBackColor = true;
            this.btnSinhVien.Click += new System.EventHandler(this.btnSinhVien_Click);
            // 
            // btnLop
            // 
            this.btnLop.Location = new System.Drawing.Point(264, 154);
            this.btnLop.Name = "btnLop";
            this.btnLop.Size = new System.Drawing.Size(202, 86);
            this.btnLop.TabIndex = 0;
            this.btnLop.Text = "Quản Lý Thông Tin Lớp Học";
            this.btnLop.UseVisualStyleBackColor = true;
            this.btnLop.Click += new System.EventHandler(this.btnLop_Click);
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.Location = new System.Drawing.Point(490, 154);
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.Size = new System.Drawing.Size(202, 86);
            this.btnGiaoVien.TabIndex = 0;
            this.btnGiaoVien.Text = "Quản Lý Thông Tin Giáo Viên";
            this.btnGiaoVien.UseVisualStyleBackColor = true;
            this.btnGiaoVien.Click += new System.EventHandler(this.btnGiaoVien_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(256, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chức Năng";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(747, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qlsvToolStripMenuItem,
            this.qllopToolStripMenuItem,
            this.qlgvToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức Năng";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinhvienToolStripMenuItem});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.thốngKêToolStripMenuItem.Text = "Thống Kê";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            // 
            // qlsvToolStripMenuItem
            // 
            this.qlsvToolStripMenuItem.Name = "qlsvToolStripMenuItem";
            this.qlsvToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.qlsvToolStripMenuItem.Text = "Quản lý sinh viên";
            // 
            // qllopToolStripMenuItem
            // 
            this.qllopToolStripMenuItem.Name = "qllopToolStripMenuItem";
            this.qllopToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.qllopToolStripMenuItem.Text = "Quan lý lớp học";
            // 
            // qlgvToolStripMenuItem
            // 
            this.qlgvToolStripMenuItem.Name = "qlgvToolStripMenuItem";
            this.qlgvToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.qlgvToolStripMenuItem.Text = "Quản lý giáo viên";
            // 
            // sinhvienToolStripMenuItem
            // 
            this.sinhvienToolStripMenuItem.Name = "sinhvienToolStripMenuItem";
            this.sinhvienToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sinhvienToolStripMenuItem.Text = "Sinh viên";
            this.sinhvienToolStripMenuItem.Click += new System.EventHandler(this.sinhvienToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 312);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGiaoVien);
            this.Controls.Add(this.btnLop);
            this.Controls.Add(this.btnSinhVien);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSinhVien;
        private System.Windows.Forms.Button btnLop;
        private System.Windows.Forms.Button btnGiaoVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qlsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qllopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qlgvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhvienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}