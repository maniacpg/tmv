namespace DiemHoacTap
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbCK = new System.Windows.Forms.TextBox();
            this.txbGK = new System.Windows.Forms.TextBox();
            this.txbCC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxLopHc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxMonHoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb2022 = new System.Windows.Forms.CheckBox();
            this.cb2017 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTinhDiem = new System.Windows.Forms.Button();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbCK);
            this.groupBox1.Controls.Add(this.txbGK);
            this.groupBox1.Controls.Add(this.txbCC);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbxLopHc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxMonHoc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb2022);
            this.groupBox1.Controls.Add(this.cb2017);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbHoTen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // txbCK
            // 
            this.txbCK.Location = new System.Drawing.Point(604, 221);
            this.txbCK.Name = "txbCK";
            this.txbCK.Size = new System.Drawing.Size(67, 22);
            this.txbCK.TabIndex = 8;
            // 
            // txbGK
            // 
            this.txbGK.Location = new System.Drawing.Point(604, 185);
            this.txbGK.Name = "txbGK";
            this.txbGK.Size = new System.Drawing.Size(67, 22);
            this.txbGK.TabIndex = 7;
            // 
            // txbCC
            // 
            this.txbCC.Location = new System.Drawing.Point(604, 149);
            this.txbCC.Name = "txbCC";
            this.txbCC.Size = new System.Drawing.Size(67, 22);
            this.txbCC.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(473, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Điểm cuối kỳ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Điểm giữa kỳ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Điểm chuyên cần";
            // 
            // cbxLopHc
            // 
            this.cbxLopHc.FormattingEnabled = true;
            this.cbxLopHc.Location = new System.Drawing.Point(550, 111);
            this.cbxLopHc.Name = "cbxLopHc";
            this.cbxLopHc.Size = new System.Drawing.Size(121, 24);
            this.cbxLopHc.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lớp HC";
            // 
            // cbxMonHoc
            // 
            this.cbxMonHoc.FormattingEnabled = true;
            this.cbxMonHoc.Location = new System.Drawing.Point(106, 111);
            this.cbxMonHoc.Name = "cbxMonHoc";
            this.cbxMonHoc.Size = new System.Drawing.Size(308, 24);
            this.cbxMonHoc.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Môn học";
            // 
            // cb2022
            // 
            this.cb2022.AutoSize = true;
            this.cb2022.Location = new System.Drawing.Point(318, 73);
            this.cb2022.Name = "cb2022";
            this.cb2022.Size = new System.Drawing.Size(96, 20);
            this.cb2022.TabIndex = 3;
            this.cb2022.Text = "CTĐT 2022";
            this.cb2022.UseVisualStyleBackColor = true;
            // 
            // cb2017
            // 
            this.cb2017.AutoSize = true;
            this.cb2017.Location = new System.Drawing.Point(166, 72);
            this.cb2017.Name = "cb2017";
            this.cb2017.Size = new System.Drawing.Size(96, 20);
            this.cb2017.TabIndex = 2;
            this.cb2017.Text = "CTĐT 2017";
            this.cb2017.UseVisualStyleBackColor = true;
            this.cb2017.CheckedChanged += new System.EventHandler(this.cb2017_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chương trình đào tạo";
            // 
            // txbHoTen
            // 
            this.txbHoTen.Location = new System.Drawing.Point(76, 29);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(251, 22);
            this.txbHoTen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ và tên";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 345);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(776, 164);
            this.listBox1.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(17, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Kết quả";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnTinhDiem
            // 
            this.btnTinhDiem.Location = new System.Drawing.Point(88, 287);
            this.btnTinhDiem.Name = "btnTinhDiem";
            this.btnTinhDiem.Size = new System.Drawing.Size(104, 23);
            this.btnTinhDiem.TabIndex = 9;
            this.btnTinhDiem.Text = "Tính điểm";
            this.btnTinhDiem.UseVisualStyleBackColor = true;
            this.btnTinhDiem.Click += new System.EventHandler(this.btnTinhDiem_Click);
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Location = new System.Drawing.Point(330, 287);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(104, 23);
            this.btnTiepTuc.TabIndex = 10;
            this.btnTiepTuc.Text = "Tiếp tục";
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(585, 287);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.btnTinhDiem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điểm học tập của sinh viên";
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

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxLopHc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxMonHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb2022;
        private System.Windows.Forms.CheckBox cb2017;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCK;
        private System.Windows.Forms.TextBox txbGK;
        private System.Windows.Forms.TextBox txbCC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTinhDiem;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}

