using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace TMV
{
    public partial class tmv : Form, iChitietHD
    {
        private string connectionString = "Data Source=MANIAC\\SQLEXPRESS;Initial Catalog=TMV;Integrated Security=True";

        private bool isAnyFieldNotEmpty = false;
        private ErrorProvider errorProvider = new ErrorProvider();

        public tmv()
        {
            InitializeComponent();



            cbDichVu.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            // Khởi tạo ban đầu
            buttonChon.Enabled = false;
            buttonTieptuc.Enabled = false;


        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            ValidateInput();
        }




        private void ValidateInput()
        {
            string tenBenhNhan = tbTenBN.Text;
            string ngay = txbNgay.Text;
            string thang = txbThang.Text;
            string nam = txbNam.Text;

            bool isTenNotEmpty = !string.IsNullOrWhiteSpace(tenBenhNhan);
            bool isNgayValid = IsValidNgay(ngay);
            bool isThangValid = IsValidThang(thang);
            bool isNamValid = IsValidNam(nam);

            bool hasSelectedService = lsbDSDV.Items.Count > 0;

            // Xóa các thông báo lỗi cũ
            errorProvider.SetError(txbNgay, null);
            errorProvider.SetError(txbThang, null);
            errorProvider.SetError(txbNam, null);
            errorProvider.SetError(tbTenBN, null);

            // Kiểm tra xem có bất kỳ trường nào không trống
            bool isAnyFieldNotEmpty = isTenNotEmpty || !string.IsNullOrWhiteSpace(ngay) || !string.IsNullOrWhiteSpace(thang) || !string.IsNullOrWhiteSpace(nam);

            // Kiểm tra điều kiện để kích hoạt nút "Chọn"
            buttonChon.Enabled = isTenNotEmpty && isNgayValid && isThangValid && isNamValid && hasSelectedService;

            // Kích hoạt nút "Tiếp tục" nếu có bất kỳ trường nào không trống
            buttonTieptuc.Enabled = isAnyFieldNotEmpty;
        }



        private void Clear()
        {
            cbMaBN.SelectedIndex = -1;
            tbTenBN.Text = "";
            txbNgay.Text = "";
            txbThang.Text = "";
            txbNam.Text = "";
            cbDichVu.SelectedIndex = 0;

            lsbDSDV.Items.Clear();
            lsbKetQua.Items.Clear();

            // Xóa thông báo lỗi khi tiếp tục
            errorProvider.Clear();
        }

        private void buttonTieptuc_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonChon_Click(object sender, EventArgs e)
        {


            string maBenhNhan = cbMaBN.Text.Trim();
            string tenBenhNhan = tbTenBN.Text.Trim();
            string ngayKham = $"{txbNgay.Text.Trim()}/{txbThang.Text.Trim()}/{txbNam.Text.Trim()}";
            string dichVuDaChon = string.Join(", ", lsbDSDV.Items.Cast<string>().ToArray());


            if (!KiemtraBNYoN(maBenhNhan))
            {

                InsertBenhNhan(maBenhNhan, tenBenhNhan);
            }


            InsertHopDong(DateTime.Parse(ngayKham), maBenhNhan, dichVuDaChon);



            lsbKetQua.Items.Clear();
            lsbKetQua.Items.Add($"Tên bệnh nhân: {tenBenhNhan}");
            lsbKetQua.Items.Add($"Ngày khám: {ngayKham}");
            lsbKetQua.Items.Add($"Dịch vụ đã chọn: {dichVuDaChon}");
        }

        private void InsertBenhNhan(string maBN, string tenBN)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("sp_InsertBenhNhan", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaBN", maBN);
                    command.Parameters.AddWithValue("@TenBN", tenBN);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                MessageBox.Show($"Đã thêm bệnh nhân {tenBN} vào cơ sở dữ liệu.");

                // Load lại thông tin của bệnh nhân vừa thêm vào các ô tương ứng
                
                LoadBenhNhan();
                LoadThongTinBenhNhan(maBN);

                // Cập nhật lại combobox cbMaBN để hiển thị danh sách bệnh nhân mới
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadThongTinBenhNhan(string maBN)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT MaBN, TenBN FROM tblBenhNhan WHERE MaBN = @MaBN", connection);
                command.Parameters.AddWithValue("@MaBN", maBN);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        cbMaBN.Text = reader["MaBN"].ToString();
                        tbTenBN.Text = reader["TenBN"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void InsertHopDong(DateTime ngay, string maBN, string dichVu)
        {
            try
            {

                bool hasExistingContract = KiemtraHDBN(maBN);


                if (hasExistingContract)
                {
                    ThemDVvaoHD(maBN, dichVu);
                    MessageBox.Show($"Đã cập nhật hợp đồng cho bệnh nhân có mã {maBN} trong cơ sở dữ liệu.");
                }
                else
                {

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand("sp_InsertHopDong", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Ngay", ngay);
                        command.Parameters.AddWithValue("@MaBN", maBN);
                        command.Parameters.AddWithValue("@DichVu", dichVu);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Đã lưu hợp đồng cho bệnh nhân có mã {maBN} vào cơ sở dữ liệu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool KiemtraHDBN(string maBenhNhan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM tblHopDong WHERE MaBN = @MaBN", connection);
                command.Parameters.AddWithValue("@MaBN", maBenhNhan);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        private void ThemDVvaoHD(string maBenhNhan, string dichVu)
        {
            // Xây dựng ngày từ các ô nhập liệu
            string ngay = txbNam.Text + "-" + txbThang.Text + "-" + txbNgay.Text;

            try
            {
                // Kiểm tra xem hợp đồng của ngày hiện tại đã tồn tại chưa
                bool contractExists = KTHD(maBenhNhan, ngay);

                if (contractExists)
                {
                    // Lấy danh sách dịch vụ hiện tại trong hợp đồng của bệnh nhân
                    List<string> currentServices = LayDanhSachDV(maBenhNhan, ngay);

                    // Thêm mới dịch vụ vào hợp đồng nếu chưa tồn tại
                    if (!currentServices.Contains(dichVu))
                    {
                        // Thực hiện cập nhật dịch vụ vào hợp đồng
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        using (SqlCommand command = new SqlCommand("UPDATE tblHopDong SET DichVu = @DichVu WHERE MaBN = @MaBN AND Ngay = @Ngay", connection))
                        {
                            command.Parameters.AddWithValue("@MaBN", maBenhNhan);
                            command.Parameters.AddWithValue("@Ngay", ngay);

                            // Tạo danh sách mới bao gồm cả dịch vụ cũ và mới
                            currentServices.Add(dichVu);
                            string updatedServices = string.Join(", ", currentServices);

                            command.Parameters.AddWithValue("@DichVu", updatedServices);

                            connection.Open();
                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show($"Đã thêm dịch vụ {dichVu} cho bệnh nhân có mã {maBenhNhan} vào hợp đồng.");
                    }
                    else
                    {
                        MessageBox.Show($"Dịch vụ {dichVu} đã tồn tại trong hợp đồng của bệnh nhân.");
                    }
                }
                else
                {
                    // Tạo hợp đồng mới và thêm dịch vụ vào
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand("INSERT INTO tblHopDong (MaBN, DichVu, Ngay) VALUES (@MaBN, @DichVu, @Ngay)", connection))
                    {
                        command.Parameters.AddWithValue("@MaBN", maBenhNhan);
                        command.Parameters.AddWithValue("@DichVu", dichVu);
                        command.Parameters.AddWithValue("@Ngay", ngay);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Đã tạo hợp đồng mới và thêm dịch vụ {dichVu} cho bệnh nhân có mã {maBenhNhan}.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private List<string> LayDanhSachDV(string maBenhNhan, string ngay)
        {
            List<string> currentServices = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT DichVu FROM tblHopDong WHERE MaBN = @MaBN AND Ngay = @Ngay", connection);
                command.Parameters.AddWithValue("@MaBN", maBenhNhan);
                command.Parameters.AddWithValue("@Ngay", ngay);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string[] services = reader["DichVu"].ToString().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                    currentServices.AddRange(services);
                }
                reader.Close();
            }

            return currentServices;
        }

        private bool KTHD(string maBenhNhan, string ngay)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM tblHopDong WHERE MaBN = @MaBN AND Ngay = @Ngay", connection);
                command.Parameters.AddWithValue("@MaBN", maBenhNhan);
                command.Parameters.AddWithValue("@Ngay", ngay);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }



        private bool KTDV(string maBenhNhan, string dichVu)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM tblHopDong WHERE MaBN = @MaBN AND CHARINDEX(@DichVu, DichVu) > 0", connection);
                command.Parameters.AddWithValue("@MaBN", maBenhNhan);
                command.Parameters.AddWithValue("@DichVu", dichVu);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }






        private bool KiemtraBNYoN(string maBenhNhan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM tblBenhNhan WHERE MaBN = @MaBN", connection);
                command.Parameters.AddWithValue("@MaBN", maBenhNhan);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBenhNhan();
            LoadDichVu();

            lsbDSDV.Items.Clear();
            tbTenBN.Text = "";
        }

        private void LoadBenhNhan()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT MaBN, TenBN FROM tblBenhNhan", connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    cbMaBN.DataSource = dataTable;
                    cbMaBN.DisplayMember = "MaBN";
                    cbMaBN.ValueMember = "MaBN";
                    cbMaBN.SelectedIndex = -1;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void cbMaBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateInput();
            if (cbMaBN.SelectedItem is DataRowView rowView)
            {
                string maBenhNhan = rowView["MaBN"].ToString();


                string query = "SELECT TenBN FROM tblBenhNhan WHERE MaBN = @MaBN";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaBN", maBenhNhan);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            tbTenBN.Text = reader["TenBN"].ToString();
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void LoadDichVu()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT IDDV, TenDV FROM tblDichVu", connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    cbDichVu.DataSource = dataTable;
                    cbDichVu.DisplayMember = "TenDV";
                    cbDichVu.ValueMember = "IDDV";
                    cbDichVu.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void cbDichVu_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (cbDichVu.SelectedItem is DataRowView rowView)
            {
                string tenDichVu = rowView["TenDV"].ToString();


                if (!lsbDSDV.Items.Contains(tenDichVu))
                {
                    lsbDSDV.Items.Add(tenDichVu);
                }
            }
        }

        private void cbMaBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string maBenhNhan = cbMaBN.Text.Trim();


                if (KiemtraBNYoN(maBenhNhan))
                {

                    LoadTenBenhNhan(maBenhNhan);
                }
                else
                {

                    MessageBox.Show("Mã bệnh nhân không tồn tại!");
                }
            }
        }

        private void LoadTenBenhNhan(string maBenhNhan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT TenBN FROM tblBenhNhan WHERE MaBN = @MaBN", connection);
                    command.Parameters.AddWithValue("@MaBN", maBenhNhan);
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        tbTenBN.Text = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void txbNgay_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();

            if (!IsValidNgay(txbNgay.Text))
            {
                errorProvider.SetError(txbNgay, "Ngày không hợp lệ");
            }
            else
            {
                errorProvider.SetError(txbNgay, "");
            }
        }

        private void txbThang_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();

            if (!IsValidThang(txbThang.Text))
            {
                errorProvider.SetError(txbThang, "Tháng không hợp lệ");
            }
            else
            {
                errorProvider.SetError(txbThang, "");
            }
        }

        private void txbNam_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();

            if (!IsValidNam(txbNam.Text))
            {
                errorProvider.SetError(txbNam, "Năm không hợp lệ");
            }
            else
            {
                errorProvider.SetError(txbNam, "");
            }
        }
        private bool IsValidNgay(string ngay)
        {

            int ngayValue;
            return int.TryParse(ngay, out ngayValue) && ngayValue >= 1 && ngayValue <= 31;
        }

        private bool IsValidThang(string thang)
        {

            int thangValue;
            return int.TryParse(thang, out thangValue) && thangValue >= 1 && thangValue <= 12;
        }

        private bool IsValidNam(string nam)
        {

            int namValue;
            return int.TryParse(nam, out namValue) && namValue >= 1900 && namValue <= 2100;
        }

        private void lsbDSDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void tbTenBN_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }




        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            string maBenhNhan = cbMaBN.Text.Trim();

            
            if (KiemtraHDBN(maBenhNhan))
            {
                
                ChiTietHD chiTietHDForm = new ChiTietHD();
                chiTietHDForm.Owner = this;
                chiTietHDForm.LoadHopDong(maBenhNhan); 
                chiTietHDForm.Show();
            }
            else
            {
                MessageBox.Show("Không có bản ghi nào.");
            }
        }           

        public void NhanDuLieuTuChiTietHD(DateTime ngay, string dichVu)
        {            
            
            txbNgay.Text = ngay.Day.ToString();
            txbThang.Text = ngay.Month.ToString();
            txbNam.Text = ngay.Year.ToString();
            
            lsbDSDV.Items.Clear();
            lsbDSDV.Items.Add(dichVu);

            string ketQua = $"Ngày: {ngay.ToShortDateString()}, Dịch vụ: {dichVu}";
            lsbKetQua.Items.Add(ketQua);
        }

        private void btnDSKBTN_Click(object sender, EventArgs e)
        {
            fInBC f = new fInBC();
            f.Show();
            f.ShowReport("dskbTime.rpt", "Select_ThongTinKhamTheoNgay", null);
            
        }

        private void btnIn1Nguoi_Click(object sender, EventArgs e)
        {
            if(cbMaBN.Text.Length>0)
            {
                string maBenhNhan = cbMaBN.Text.Trim();
                if (KiemtraHDBN(maBenhNhan))
                {
                    string reportFilter = "NOT(ISNULL({Select_ThongTinKhamTheoNgay.MaBN}))";
                    if (!string.IsNullOrEmpty(cbMaBN.Text))
                    {
                        reportFilter += string.Format(" AND {0} LIKE '*{1}*'", "{Select_ThongTinKhamTheoNgay.MaBN}", cbMaBN.Text);
                    }
                    if (!string.IsNullOrEmpty(tbTenBN.Text))
                    {
                        reportFilter += string.Format(" AND {0} LIKE '*{1}*'", "{Select_ThongTinKhamTheoNgay.TenBN}", tbTenBN.Text);
                    }
                    fInBC f = new fInBC();
                    f.Show();
                    f.ShowReport("sokhambenh.rpt", "Select_ThongTinKhamTheoNgay", reportFilter);
                }
                else
                {
                    MessageBox.Show("Bệnh nhân chưa sử dụng dịch vụ nào!");
                }
                
            }
            
            else
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân trước khi in Sổ khám bệnh!");
            }
            //liệt kê các trường dữ liệu khác


            
        }
    }
}
