using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TMV
{
    public partial class ChiTietHD : Form
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                
                if (row != null && row.Cells["Ngay"].Value != null && row.Cells["DichVu"].Value != null)
                {
                    string ngayString = row.Cells["Ngay"].Value.ToString();
                    string dichVu = row.Cells["DichVu"].Value.ToString();

                    
                    if (this.Owner != null && this.Owner is tmv)
                    {
                        ((tmv)this.Owner).NhanDuLieuTuChiTietHD(ngayString, dichVu);

                        
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Form chính (tmv) không hợp lệ.");
                    }
                }
                else
                {
                    MessageBox.Show("Dòng không có dữ liệu hợp lệ.");
                }
            }
            else
            {
                MessageBox.Show("Dòng không hợp lệ.");
            }
        }




    }
}
