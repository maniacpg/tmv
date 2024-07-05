namespace TMV
{
    partial class tmv
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxServices;

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
            this.buttonChon = new System.Windows.Forms.Button();
            this.buttonTieptuc = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMaBN = new System.Windows.Forms.ComboBox();
            this.lsbDSDV = new System.Windows.Forms.ListBox();
            this.cbDichVu = new System.Windows.Forms.ComboBox();
            this.txbNam = new System.Windows.Forms.TextBox();
            this.txbThang = new System.Windows.Forms.TextBox();
            this.txbNgay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTenBN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbMaBN = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTenBN = new System.Windows.Forms.Label();
            this.lsbKetQua = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonChon
            // 
            this.buttonChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChon.Location = new System.Drawing.Point(189, 373);
            this.buttonChon.Name = "buttonChon";
            this.buttonChon.Size = new System.Drawing.Size(125, 39);
            this.buttonChon.TabIndex = 6;
            this.buttonChon.Text = "Chọn";
            this.buttonChon.UseVisualStyleBackColor = true;
            this.buttonChon.Click += new System.EventHandler(this.buttonChon_Click);
            // 
            // buttonTieptuc
            // 
            this.buttonTieptuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTieptuc.Location = new System.Drawing.Point(428, 373);
            this.buttonTieptuc.Name = "buttonTieptuc";
            this.buttonTieptuc.Size = new System.Drawing.Size(125, 39);
            this.buttonTieptuc.TabIndex = 7;
            this.buttonTieptuc.Text = "Tiếp tục";
            this.buttonTieptuc.UseVisualStyleBackColor = true;
            this.buttonTieptuc.Click += new System.EventHandler(this.buttonTieptuc_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(659, 373);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(125, 39);
            this.buttonThoat.TabIndex = 8;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMaBN);
            this.groupBox1.Controls.Add(this.lsbDSDV);
            this.groupBox1.Controls.Add(this.cbDichVu);
            this.groupBox1.Controls.Add(this.txbNam);
            this.groupBox1.Controls.Add(this.txbThang);
            this.groupBox1.Controls.Add(this.txbNgay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbTenBN);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbMaBN);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelTenBN);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(979, 334);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bệnh nhân";
            // 
            // cbMaBN
            // 
            this.cbMaBN.FormattingEnabled = true;
            this.cbMaBN.Location = new System.Drawing.Point(192, 41);
            this.cbMaBN.Name = "cbMaBN";
            this.cbMaBN.Size = new System.Drawing.Size(290, 28);
            this.cbMaBN.TabIndex = 19;
            this.cbMaBN.SelectedIndexChanged += new System.EventHandler(this.cbMaBN_SelectedIndexChanged);
            this.cbMaBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbMaBN_KeyPress);
            // 
            // lsbDSDV
            // 
            this.lsbDSDV.FormattingEnabled = true;
            this.lsbDSDV.ItemHeight = 20;
            this.lsbDSDV.Location = new System.Drawing.Point(609, 184);
            this.lsbDSDV.Name = "lsbDSDV";
            this.lsbDSDV.Size = new System.Drawing.Size(350, 144);
            this.lsbDSDV.TabIndex = 18;
            this.lsbDSDV.SelectedIndexChanged += new System.EventHandler(this.lsbDSDV_SelectedIndexChanged);
            // 
            // cbDichVu
            // 
            this.cbDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDichVu.FormattingEnabled = true;
            this.cbDichVu.Location = new System.Drawing.Point(149, 184);
            this.cbDichVu.Name = "cbDichVu";
            this.cbDichVu.Size = new System.Drawing.Size(215, 28);
            this.cbDichVu.TabIndex = 5;
            this.cbDichVu.SelectedIndexChanged += new System.EventHandler(this.cbDichVu_SelectedIndexChanged_1);
            // 
            // txbNam
            // 
            this.txbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNam.Location = new System.Drawing.Point(431, 125);
            this.txbNam.Name = "txbNam";
            this.txbNam.Size = new System.Drawing.Size(51, 27);
            this.txbNam.TabIndex = 4;
            this.txbNam.TextChanged += new System.EventHandler(this.txbNam_TextChanged);
            // 
            // txbThang
            // 
            this.txbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbThang.Location = new System.Drawing.Point(249, 125);
            this.txbThang.Name = "txbThang";
            this.txbThang.Size = new System.Drawing.Size(51, 27);
            this.txbThang.TabIndex = 3;
            this.txbThang.TextChanged += new System.EventHandler(this.txbThang_TextChanged);
            // 
            // txbNgay
            // 
            this.txbNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNgay.Location = new System.Drawing.Point(77, 125);
            this.txbNgay.Name = "txbNgay";
            this.txbNgay.Size = new System.Drawing.Size(51, 27);
            this.txbNgay.TabIndex = 2;
            this.txbNgay.TextChanged += new System.EventHandler(this.txbNgay_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(381, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Năm";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tháng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ngày";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbTenBN
            // 
            this.tbTenBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenBN.Location = new System.Drawing.Point(192, 81);
            this.tbTenBN.Name = "tbTenBN";
            this.tbTenBN.Size = new System.Drawing.Size(290, 27);
            this.tbTenBN.TabIndex = 1;
            this.tbTenBN.TextChanged += new System.EventHandler(this.tbTenBN_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(453, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Danh sách dịch vụ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbMaBN
            // 
            this.lbMaBN.AutoSize = true;
            this.lbMaBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaBN.Location = new System.Drawing.Point(24, 41);
            this.lbMaBN.Name = "lbMaBN";
            this.lbMaBN.Size = new System.Drawing.Size(114, 20);
            this.lbMaBN.TabIndex = 9;
            this.lbMaBN.Text = "Mã bệnh nhân";
            this.lbMaBN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Chọn dịch vụ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTenBN
            // 
            this.labelTenBN.AutoSize = true;
            this.labelTenBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenBN.Location = new System.Drawing.Point(24, 84);
            this.labelTenBN.Name = "labelTenBN";
            this.labelTenBN.Size = new System.Drawing.Size(119, 20);
            this.labelTenBN.TabIndex = 9;
            this.labelTenBN.Text = "Tên bệnh nhân";
            this.labelTenBN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lsbKetQua
            // 
            this.lsbKetQua.FormattingEnabled = true;
            this.lsbKetQua.ItemHeight = 16;
            this.lsbKetQua.Location = new System.Drawing.Point(12, 446);
            this.lsbKetQua.Name = "lsbKetQua";
            this.lsbKetQua.Size = new System.Drawing.Size(979, 180);
            this.lsbKetQua.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kết quả";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChiTiet.BackgroundImage = global::TMV.Properties.Resources.icon;
            this.btnChiTiet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChiTiet.Location = new System.Drawing.Point(930, 373);
            this.btnChiTiet.Margin = new System.Windows.Forms.Padding(0);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(41, 39);
            this.btnChiTiet.TabIndex = 20;
            this.btnChiTiet.UseVisualStyleBackColor = false;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // tmv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 642);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.lsbKetQua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonTieptuc);
            this.Controls.Add(this.buttonChon);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "tmv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thẩm mỹ viện";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonChon;
        private System.Windows.Forms.Button buttonTieptuc;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lsbDSDV;
        private System.Windows.Forms.ComboBox cbDichVu;
        private System.Windows.Forms.TextBox txbNam;
        private System.Windows.Forms.TextBox txbThang;
        private System.Windows.Forms.TextBox txbNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTenBN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTenBN;
        private System.Windows.Forms.ListBox lsbKetQua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMaBN;
        private System.Windows.Forms.ComboBox cbMaBN;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Button btnChiTiet;
    }
}

