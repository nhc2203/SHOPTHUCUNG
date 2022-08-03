namespace GUI
{
    partial class frmDoiSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiSanPham));
            this.dataGridView_SanPham = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Tien = new System.Windows.Forms.TextBox();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_chon = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txt_mota = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_loai = new System.Windows.Forms.TextBox();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_tim = new System.Windows.Forms.Button();
            this.txt_Timkiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SanPham)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_SanPham
            // 
            this.dataGridView_SanPham.AllowUserToDeleteRows = false;
            this.dataGridView_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView_SanPham.Location = new System.Drawing.Point(11, 22);
            this.dataGridView_SanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_SanPham.Name = "dataGridView_SanPham";
            this.dataGridView_SanPham.RowTemplate.Height = 24;
            this.dataGridView_SanPham.Size = new System.Drawing.Size(528, 186);
            this.dataGridView_SanPham.TabIndex = 55;
            this.dataGridView_SanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SanPham_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên sản phẩm";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Đơn giá";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mô tả";
            this.Column3.Name = "Column3";
            this.Column3.Width = 135;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "loại ";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "hình ảnh";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Controls.Add(this.txt_Tien);
            this.groupBox4.Location = new System.Drawing.Point(583, 57);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(444, 306);
            this.groupBox4.TabIndex = 84;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sản phẩm đổi trả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 260);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng tiền";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column6,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(421, 215);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Tên sản phẩm";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Sô lượng ";
            this.Column8.Name = "Column8";
            this.Column8.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Đơn giá";
            this.Column6.Name = "Column6";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Thành tiền";
            this.Column9.Name = "Column9";
            // 
            // txt_Tien
            // 
            this.txt_Tien.Location = new System.Drawing.Point(248, 254);
            this.txt_Tien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Tien.Name = "txt_Tien";
            this.txt_Tien.Size = new System.Drawing.Size(184, 22);
            this.txt_Tien.TabIndex = 75;
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(232, 49);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(4);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(131, 52);
            this.btn_huy.TabIndex = 78;
            this.btn_huy.Text = "Hủy chọn";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_chon
            // 
            this.btn_chon.Location = new System.Drawing.Point(68, 49);
            this.btn_chon.Margin = new System.Windows.Forms.Padding(4);
            this.btn_chon.Name = "btn_chon";
            this.btn_chon.Size = new System.Drawing.Size(137, 52);
            this.btn_chon.TabIndex = 78;
            this.btn_chon.Text = "Chọn sản phẩm trả";
            this.btn_chon.UseVisualStyleBackColor = true;
            this.btn_chon.Click += new System.EventHandler(this.btn_chon_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_XacNhan);
            this.groupBox5.Controls.Add(this.btn_huy);
            this.groupBox5.Controls.Add(this.btn_chon);
            this.groupBox5.Location = new System.Drawing.Point(583, 380);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(444, 196);
            this.groupBox5.TabIndex = 85;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chức năng";
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Location = new System.Drawing.Point(156, 108);
            this.btn_XacNhan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(137, 50);
            this.btn_XacNhan.TabIndex = 78;
            this.btn_XacNhan.Text = "Xác nhận ";
            this.btn_XacNhan.UseVisualStyleBackColor = true;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_SanPham);
            this.groupBox2.Location = new System.Drawing.Point(15, 368);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(552, 223);
            this.groupBox2.TabIndex = 83;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.txt_mota);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_loai);
            this.groupBox1.Controls.Add(this.txt_gia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_tensp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(15, 130);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(552, 233);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(139, 134);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(189, 22);
            this.numericUpDown1.TabIndex = 48;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown1_KeyPress);
            // 
            // txt_mota
            // 
            this.txt_mota.Location = new System.Drawing.Point(136, 174);
            this.txt_mota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mota.Multiline = true;
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(191, 47);
            this.txt_mota.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.AliceBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 46;
            this.label7.Text = "Mô tả";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(353, 25);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(181, 192);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 45;
            this.pictureBox5.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.AliceBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "Loai sp";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.AliceBlue;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 18);
            this.label11.TabIndex = 39;
            this.label11.Text = "Số lượng ";
            // 
            // txt_loai
            // 
            this.txt_loai.Location = new System.Drawing.Point(136, 97);
            this.txt_loai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_loai.Name = "txt_loai";
            this.txt_loai.Size = new System.Drawing.Size(191, 22);
            this.txt_loai.TabIndex = 38;
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(136, 60);
            this.txt_gia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(191, 22);
            this.txt_gia.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Đơn giá";
            // 
            // txt_tensp
            // 
            this.txt_tensp.Location = new System.Drawing.Point(133, 26);
            this.txt_tensp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.Size = new System.Drawing.Size(196, 22);
            this.txt_tensp.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.AliceBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Tên sản phẩm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_tim);
            this.groupBox3.Controls.Add(this.txt_Timkiem);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(15, 57);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(552, 69);
            this.groupBox3.TabIndex = 81;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm sản phẩm";
            // 
            // bt_tim
            // 
            this.bt_tim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_tim.BackgroundImage")));
            this.bt_tim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_tim.FlatAppearance.BorderSize = 0;
            this.bt_tim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_tim.Location = new System.Drawing.Point(476, 22);
            this.bt_tim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(37, 34);
            this.bt_tim.TabIndex = 77;
            this.bt_tim.Tag = "";
            this.bt_tim.UseVisualStyleBackColor = true;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // txt_Timkiem
            // 
            this.txt_Timkiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_Timkiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_Timkiem.Location = new System.Drawing.Point(139, 23);
            this.txt_Timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Timkiem.Name = "txt_Timkiem";
            this.txt_Timkiem.Size = new System.Drawing.Size(313, 22);
            this.txt_Timkiem.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 31;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 43);
            this.label2.TabIndex = 82;
            this.label2.Text = "Đổi sản phẩm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDoiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 596);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Name = "frmDoiSanPham";
            this.Text = "frmDoiSanPham";
            this.Load += new System.EventHandler(this.frmDoiSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SanPham)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_SanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.TextBox txt_Tien;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_chon;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_XacNhan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txt_mota;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_loai;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tensp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.TextBox txt_Timkiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;

    }
}