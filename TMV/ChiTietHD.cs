using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TMV
{
    public partial class ChiTietHD : Form, iChitietHD
    {
        private string connectionString = "Data Source=MANIAC\\SQLEXPRESS;Initial Catalog=TMV;Integrated Security=True";

        public ChiTietHD()
        {
            InitializeComponent();
        }

        private void ChiTietHD_Load(object sender, EventArgs e)
        {
            
        }

        public void LoadHopDong(string maBenhNhan)
        {
            dataGridView1.Rows.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("sp_GetHopDongByMaBN", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MaBN", maBenhNhan);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string ngayString = reader["Ngay"].ToString(); 
                            string maBN = reader["MaBN"].ToString();
                            string dichVu = reader["DichVu"].ToString();

                            
                            dataGridView1.Rows.Add(ngayString, maBN, dichVu);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không có hợp đồng nào.");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;

            if (row != null && row.Cells["Ngay"].Value != null && row.Cells["DichVu"].Value != null)
            {
                if (this.Owner is iChitietHD receiver)
                {
                    DateTime ngay;
                    if (DateTime.TryParse(row.Cells["Ngay"].Value.ToString(), out ngay))
                    {
                        string dichVu = row.Cells["DichVu"].Value.ToString();
                        receiver.NhanDuLieuTuChiTietHD(ngay, dichVu);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ngày không hợp lệ.");
                    }
                }
                else
                {
                    MessageBox.Show("Form chính không hỗ trợ nhận dữ liệu.");
                }
            }
            else
            {
                MessageBox.Show("Dòng không có dữ liệu hợp lệ.");
            }
        }

        public void NhanDuLieuTuChiTietHD(DateTime ngay, string dichVu)
        {
            throw new NotImplementedException();
        }
    }
}
