// Trong form ChiTietHD, sửa đổi phần designer và mã để sử dụng DataGridView

namespace TMV
{
    partial class ChiTietHD
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 428);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lịch sử thăm khám của bệnh nhân";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ngay,
            this.MaBn,
            this.DichVu});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(770, 407);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ngay
            // 
            this.ngay.DataPropertyName = "Ngay";
            this.ngay.HeaderText = "Ngày tháng";
            this.ngay.MinimumWidth = 6;
            this.ngay.Name = "ngay";
            this.ngay.ReadOnly = true;
            // 
            // MaBn
            // 
            this.MaBn.DataPropertyName = "MaBN";
            this.MaBn.HeaderText = "Mã bệnh nhân";
            this.MaBn.MinimumWidth = 6;
            this.MaBn.Name = "MaBn";
            this.MaBn.ReadOnly = true;
            // 
            // DichVu
            // 
            this.DichVu.DataPropertyName = "DichVu";
            this.DichVu.HeaderText = "Dịch vụ";
            this.DichVu.MinimumWidth = 6;
            this.DichVu.Name = "DichVu";
            this.DichVu.ReadOnly = true;
            // 
            // ChiTietHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChiTietHD";
            this.Text = "ChiTietHD";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DichVu;
    }
}
