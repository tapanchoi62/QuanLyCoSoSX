﻿namespace QuanLyCoSoSX.GUI
{
    partial class FormSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSanPham));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbCSSX = new System.Windows.Forms.ComboBox();
            this.txtMaCSSX = new System.Windows.Forms.TextBox();
            this.txtDonvitinh = new System.Windows.Forms.TextBox();
            this.txtTensp = new System.Windows.Forms.TextBox();
            this.txtMasp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GetThongTinbt = new System.Windows.Forms.Button();
            this.Xoabt = new System.Windows.Forms.Button();
            this.Suabt = new System.Windows.Forms.Button();
            this.Thembt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TraCuuKiemNghiem = new System.Windows.Forms.Button();
            this.txtFindByID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DGVSanPham = new System.Windows.Forms.DataGridView();
            this.dgvMasp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDVTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCSSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSanPham)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;

            this.label1.Location = new System.Drawing.Point(14, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Location = new System.Drawing.Point(14, 451);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(0, 0);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tra cứu sản phẩm";
            // 
            // cbCSSX
            // 
            this.cbCSSX.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbCSSX.FormattingEnabled = true;
            this.cbCSSX.ItemHeight = 13;
            this.cbCSSX.Location = new System.Drawing.Point(111, 246);
            this.cbCSSX.Name = "cbCSSX";
            this.cbCSSX.Size = new System.Drawing.Size(287, 24);
            this.cbCSSX.TabIndex = 24;
            this.cbCSSX.SelectedIndexChanged += new System.EventHandler(this.cbCSSX_SelectedIndexChanged);
            // 
            // txtMaCSSX
            // 
            this.txtMaCSSX.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMaCSSX.Enabled = false;
            this.txtMaCSSX.Location = new System.Drawing.Point(406, 246);
            this.txtMaCSSX.Name = "txtMaCSSX";
            this.txtMaCSSX.Size = new System.Drawing.Size(132, 22);
            this.txtMaCSSX.TabIndex = 23;
            // 
            // txtDonvitinh
            // 

            this.txtDonvitinh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDonvitinh.Location = new System.Drawing.Point(111, 178);
            this.txtDonvitinh.Name = "txtDonvitinh";
            this.txtDonvitinh.Size = new System.Drawing.Size(525, 22);
            this.txtDonvitinh.TabIndex = 2;
            // 
            // txtTensp
            // 

            this.txtTensp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTensp.Location = new System.Drawing.Point(111, 111);
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.Size = new System.Drawing.Size(525, 22);
            this.txtTensp.TabIndex = 1;
            // 
            // txtMasp
            // 

            this.txtMasp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMasp.Enabled = false;
            this.txtMasp.Location = new System.Drawing.Point(111, 47);
            this.txtMasp.Name = "txtMasp";
            this.txtMasp.Size = new System.Drawing.Size(525, 22);
            this.txtMasp.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mã CSSX";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "CSSX";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Đơn vị tính";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã sản phẩm";
            // 
            // GetThongTinbt
            // 

            this.GetThongTinbt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GetThongTinbt.BackColor = System.Drawing.Color.Orange;
            this.GetThongTinbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetThongTinbt.Image = ((System.Drawing.Image)(resources.GetObject("GetThongTinbt.Image")));
            this.GetThongTinbt.Location = new System.Drawing.Point(384, 296);
            this.GetThongTinbt.Name = "GetThongTinbt";
            this.GetThongTinbt.Size = new System.Drawing.Size(147, 44);
            this.GetThongTinbt.TabIndex = 7;
            this.GetThongTinbt.Text = "Lấy Thông Tin";
            this.GetThongTinbt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GetThongTinbt.UseVisualStyleBackColor = false;
            this.GetThongTinbt.Click += new System.EventHandler(this.GetThongTinbt_Click);
            // 
            // Xoabt
            // 
            this.Xoabt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Xoabt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Xoabt.Image = ((System.Drawing.Image)(resources.GetObject("Xoabt.Image")));
            this.Xoabt.Location = new System.Drawing.Point(264, 297);
            this.Xoabt.Name = "Xoabt";
            this.Xoabt.Size = new System.Drawing.Size(147, 43);
            this.Xoabt.TabIndex = 6;
            this.Xoabt.Text = "Xoá ";
            this.Xoabt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Xoabt.UseVisualStyleBackColor = true;
            this.Xoabt.Click += new System.EventHandler(this.Xoabt_Click);
            // 
            // Suabt
            // 
            this.Suabt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Suabt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Suabt.Image = ((System.Drawing.Image)(resources.GetObject("Suabt.Image")));
            this.Suabt.Location = new System.Drawing.Point(144, 297);
            this.Suabt.Name = "Suabt";
            this.Suabt.Size = new System.Drawing.Size(147, 43);
            this.Suabt.TabIndex = 5;
            this.Suabt.Text = "Sửa";
            this.Suabt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Suabt.UseVisualStyleBackColor = true;
            this.Suabt.Click += new System.EventHandler(this.Suabt_Click);
            // 
            // Thembt
            // 
            this.Thembt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Thembt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Thembt.Image = ((System.Drawing.Image)(resources.GetObject("Thembt.Image")));
            this.Thembt.Location = new System.Drawing.Point(24, 297);
            this.Thembt.Name = "Thembt";
            this.Thembt.Size = new System.Drawing.Size(147, 43);
            this.Thembt.TabIndex = 4;
            this.Thembt.Text = "Thêm ";
            this.Thembt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Thembt.UseVisualStyleBackColor = true;
            this.Thembt.Click += new System.EventHandler(this.Thembt_Click);
            // 
            // panel1
            // 

            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.TraCuuKiemNghiem);
            this.panel1.Controls.Add(this.txtFindByID);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(14, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 111);
            this.panel1.TabIndex = 38;
            // 
            // TraCuuKiemNghiem
            // 
            this.TraCuuKiemNghiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TraCuuKiemNghiem.Image = ((System.Drawing.Image)(resources.GetObject("TraCuuKiemNghiem.Image")));
            this.TraCuuKiemNghiem.Location = new System.Drawing.Point(493, 30);
            this.TraCuuKiemNghiem.Margin = new System.Windows.Forms.Padding(4);
            this.TraCuuKiemNghiem.Name = "TraCuuKiemNghiem";
            this.TraCuuKiemNghiem.Size = new System.Drawing.Size(147, 43);
            this.TraCuuKiemNghiem.TabIndex = 9;
            this.TraCuuKiemNghiem.Text = "Tìm";
            this.TraCuuKiemNghiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TraCuuKiemNghiem.UseVisualStyleBackColor = true;
            this.TraCuuKiemNghiem.Click += new System.EventHandler(this.TraCuuKiemNghiem_Click);
            // 
            // txtFindByID
            // 
            this.txtFindByID.Location = new System.Drawing.Point(21, 48);
            this.txtFindByID.Margin = new System.Windows.Forms.Padding(4);
            this.txtFindByID.Name = "txtFindByID";
            this.txtFindByID.Size = new System.Drawing.Size(425, 22);
            this.txtFindByID.TabIndex = 8;
            this.txtFindByID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFindByID_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(7, 6);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 29);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tra cứu sản phẩm";
            // 
            // DGVSanPham
            // 
            this.DGVSanPham.AllowUserToAddRows = false;
            this.DGVSanPham.AllowUserToDeleteRows = false;
            this.DGVSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMasp,
            this.dgvTenSP,
            this.dgvDVTinh,
            this.dgvCSSX});

            this.DGVSanPham.Location = new System.Drawing.Point(528, 0);
            this.DGVSanPham.MultiSelect = false;
            this.DGVSanPham.Name = "DGVSanPham";
            this.DGVSanPham.ReadOnly = true;
            this.DGVSanPham.RowHeadersVisible = false;
            this.DGVSanPham.RowHeadersWidth = 51;
            this.DGVSanPham.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSanPham.Size = new System.Drawing.Size(523, 561);
            this.DGVSanPham.TabIndex = 10;
            this.DGVSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSanPham_CellClick);
            // 
            // dgvMasp
            // 
            this.dgvMasp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvMasp.HeaderText = "Mã sản phẩm";
            this.dgvMasp.MinimumWidth = 6;
            this.dgvMasp.Name = "dgvMasp";
            this.dgvMasp.ReadOnly = true;
            // 
            // dgvTenSP
            // 
            this.dgvTenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvTenSP.HeaderText = "Tên sản phẩm";
            this.dgvTenSP.MinimumWidth = 6;
            this.dgvTenSP.Name = "dgvTenSP";
            this.dgvTenSP.ReadOnly = true;
            // 
            // dgvDVTinh
            // 
            this.dgvDVTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDVTinh.HeaderText = "Đơn vị tính";
            this.dgvDVTinh.MinimumWidth = 6;
            this.dgvDVTinh.Name = "dgvDVTinh";
            this.dgvDVTinh.ReadOnly = true;
            // 
            // dgvCSSX
            // 
            this.dgvCSSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCSSX.HeaderText = "Cơ sở sản xuất";
            this.dgvCSSX.MinimumWidth = 6;
            this.dgvCSSX.Name = "dgvCSSX";
            this.dgvCSSX.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDonvitinh);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.txtMaCSSX);
            this.panel2.Controls.Add(this.GetThongTinbt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Xoabt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Suabt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Thembt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbCSSX);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtMasp);
            this.panel2.Controls.Add(this.txtTensp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 561);
            this.panel2.TabIndex = 41;
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1051, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DGVSanPham);
            this.MinimumSize = new System.Drawing.Size(1067, 600);
            this.Name = "FormSanPham";
            this.Text = "Quản lý sản phẩm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSanPham_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSanPham)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbCSSX;
        private System.Windows.Forms.TextBox txtMaCSSX;
        private System.Windows.Forms.TextBox txtDonvitinh;
        private System.Windows.Forms.TextBox txtTensp;
        private System.Windows.Forms.TextBox txtMasp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GetThongTinbt;
        private System.Windows.Forms.Button Xoabt;
        private System.Windows.Forms.Button Suabt;
        private System.Windows.Forms.Button Thembt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button TraCuuKiemNghiem;
        private System.Windows.Forms.TextBox txtFindByID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView DGVSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMasp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDVTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCSSX;
        private System.Windows.Forms.Panel panel2;
    }
}