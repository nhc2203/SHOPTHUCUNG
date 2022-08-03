namespace GUI
{
    partial class frmNhapHang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapHang));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.dt_ctnhaphang = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bt_luu2 = new System.Windows.Forms.Button();
            this.cbo_sp = new System.Windows.Forms.ComboBox();
            this.bt_xoa2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bt_them = new System.Windows.Forms.Button();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.NumericUpDown();
            this.cboMaNhap = new System.Windows.Forms.ComboBox();
            this.bt_reset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_mua = new System.Windows.Forms.Button();
            this.dt_nhaphang = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemSua = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ctnhaphang)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_nhaphang)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Cyan;
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtSL);
            this.groupBox3.Controls.Add(this.dt_ctnhaphang);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(-3, 290);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1065, 209);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết phiếu nhập hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(271, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 78;
            this.label8.Text = "VNĐ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 183);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 77;
            this.label5.Text = "Tổng Nhập";
            // 
            // txtSL
            // 
            this.txtSL.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSL.Enabled = false;
            this.txtSL.Location = new System.Drawing.Point(102, 179);
            this.txtSL.Margin = new System.Windows.Forms.Padding(4);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(162, 22);
            this.txtSL.TabIndex = 76;
            // 
            // dt_ctnhaphang
            // 
            this.dt_ctnhaphang.Location = new System.Drawing.Point(21, 25);
            this.dt_ctnhaphang.Name = "dt_ctnhaphang";
            this.dt_ctnhaphang.Size = new System.Drawing.Size(531, 139);
            this.dt_ctnhaphang.TabIndex = 79;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.bt_luu2);
            this.groupBox4.Controls.Add(this.cbo_sp);
            this.groupBox4.Controls.Add(this.bt_xoa2);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.bt_them);
            this.groupBox4.Controls.Add(this.txt_dongia);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.number);
            this.groupBox4.Controls.Add(this.cboMaNhap);
            this.groupBox4.Controls.Add(this.bt_reset);
            this.groupBox4.Location = new System.Drawing.Point(579, 25);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(421, 139);
            this.groupBox4.TabIndex = 63;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi Tiết Nhập Hàng";
            // 
            // bt_luu2
            // 
            this.bt_luu2.BackColor = System.Drawing.Color.Transparent;
            this.bt_luu2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_luu2.BackgroundImage")));
            this.bt_luu2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_luu2.Enabled = false;
            this.bt_luu2.FlatAppearance.BorderSize = 0;
            this.bt_luu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_luu2.Location = new System.Drawing.Point(283, 73);
            this.bt_luu2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_luu2.Name = "bt_luu2";
            this.bt_luu2.Size = new System.Drawing.Size(59, 46);
            this.bt_luu2.TabIndex = 63;
            this.bt_luu2.UseVisualStyleBackColor = false;
            this.bt_luu2.Click += new System.EventHandler(this.bt_luu2_Click);
            // 
            // cbo_sp
            // 
            this.cbo_sp.FormattingEnabled = true;
            this.cbo_sp.Location = new System.Drawing.Point(99, 47);
            this.cbo_sp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_sp.Name = "cbo_sp";
            this.cbo_sp.Size = new System.Drawing.Size(157, 24);
            this.cbo_sp.TabIndex = 62;
            // 
            // bt_xoa2
            // 
            this.bt_xoa2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_xoa2.BackgroundImage")));
            this.bt_xoa2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_xoa2.FlatAppearance.BorderSize = 0;
            this.bt_xoa2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_xoa2.Location = new System.Drawing.Point(340, 17);
            this.bt_xoa2.Margin = new System.Windows.Forms.Padding(4);
            this.bt_xoa2.Name = "bt_xoa2";
            this.bt_xoa2.Size = new System.Drawing.Size(64, 50);
            this.bt_xoa2.TabIndex = 56;
            this.bt_xoa2.UseVisualStyleBackColor = true;
            this.bt_xoa2.Click += new System.EventHandler(this.bt_xoa2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Mã nhập:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(11, 50);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(49, 17);
            this.label.TabIndex = 30;
            this.label.Text = "Mã SP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "Số Lượng:";
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.Transparent;
            this.bt_them.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_them.BackgroundImage")));
            this.bt_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_them.FlatAppearance.BorderSize = 0;
            this.bt_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_them.Location = new System.Drawing.Point(283, 18);
            this.bt_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(59, 48);
            this.bt_them.TabIndex = 47;
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(99, 108);
            this.txt_dongia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(157, 22);
            this.txt_dongia.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Đơn Giá:";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(99, 80);
            this.number.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(157, 22);
            this.number.TabIndex = 34;
            // 
            // cboMaNhap
            // 
            this.cboMaNhap.Location = new System.Drawing.Point(99, 19);
            this.cboMaNhap.Name = "cboMaNhap";
            this.cboMaNhap.Size = new System.Drawing.Size(157, 24);
            this.cboMaNhap.TabIndex = 64;
            // 
            // bt_reset
            // 
            this.bt_reset.BackColor = System.Drawing.Color.Transparent;
            this.bt_reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_reset.BackgroundImage")));
            this.bt_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_reset.FlatAppearance.BorderSize = 0;
            this.bt_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_reset.Location = new System.Drawing.Point(347, 71);
            this.bt_reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(57, 46);
            this.bt_reset.TabIndex = 44;
            this.bt_reset.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Cyan;
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.bt_mua);
            this.groupBox2.Controls.Add(this.dt_nhaphang);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(-3, 1);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1065, 281);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập Hàng";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(858, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 238);
            this.panel1.TabIndex = 78;
            // 
            // bt_mua
            // 
            this.bt_mua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_mua.BackgroundImage")));
            this.bt_mua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_mua.FlatAppearance.BorderSize = 0;
            this.bt_mua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_mua.Location = new System.Drawing.Point(634, 150);
            this.bt_mua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_mua.Name = "bt_mua";
            this.bt_mua.Size = new System.Drawing.Size(88, 85);
            this.bt_mua.TabIndex = 76;
            this.bt_mua.UseVisualStyleBackColor = true;
            this.bt_mua.Click += new System.EventHandler(this.bt_mua_Click);
            // 
            // dt_nhaphang
            // 
            this.dt_nhaphang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_nhaphang.Location = new System.Drawing.Point(21, 30);
            this.dt_nhaphang.Name = "dt_nhaphang";
            this.dt_nhaphang.RowTemplate.Height = 24;
            this.dt_nhaphang.Size = new System.Drawing.Size(455, 205);
            this.dt_nhaphang.TabIndex = 63;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboNCC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnThemSua);
            this.groupBox1.Location = new System.Drawing.Point(521, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(314, 90);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm Sửa Nhập";
            // 
            // cboNCC
            // 
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(122, 23);
            this.cboNCC.Margin = new System.Windows.Forms.Padding(4);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(126, 24);
            this.cboNCC.TabIndex = 2;
            this.cboNCC.SelectedIndexChanged += new System.EventHandler(this.cboNCC_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhà cung cấp";
            // 
            // btnThemSua
            // 
            this.btnThemSua.BackColor = System.Drawing.Color.Transparent;
            this.btnThemSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemSua.BackgroundImage")));
            this.btnThemSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemSua.FlatAppearance.BorderSize = 0;
            this.btnThemSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSua.Location = new System.Drawing.Point(266, 21);
            this.btnThemSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemSua.Name = "btnThemSua";
            this.btnThemSua.Size = new System.Drawing.Size(59, 48);
            this.btnThemSua.TabIndex = 48;
            this.btnThemSua.UseVisualStyleBackColor = false;
            this.btnThemSua.Click += new System.EventHandler(this.btnThemSua_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 500);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmNhapHang";
            this.Text = "frmNhapHang";
            this.Load += new System.EventHandler(this.frmNhapHang_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ctnhaphang)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt_nhaphang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dt_ctnhaphang;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bt_luu2;
        private System.Windows.Forms.ComboBox cbo_sp;
        private System.Windows.Forms.Button bt_xoa2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown number;
        private System.Windows.Forms.ComboBox cboMaNhap;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_mua;
        private System.Windows.Forms.DataGridView dt_nhaphang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemSua;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSL;

    }
}