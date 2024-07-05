using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiemHoacTap
{
    
    public partial class Form1 : Form
    {
        private Dictionary<string, List<string>> monHoc2017 = new Dictionary<string, List<string>>();
        private Dictionary<string, List<string>> monHoc2022 = new Dictionary<string, List<string>>();
        private List<string> lopHC2017 = new List<string>();
        private List<string> lopHC2022 = new List<string>();
        private bool IsInputValid = false;
        private bool IsAnyFieldsNotEmpty = false;
        private ErrorProvider errorProvider;
        public Form1()
        {
            InitializeComponent();
            InitializeData();

            
            cb2017.CheckedChanged += new EventHandler(cb2017_CheckedChanged);
            cb2022.CheckedChanged += new EventHandler(cb2022_CheckedChanged);

            txbHoTen.TextChanged += InputFields_TextChanged;
            txbCC.TextChanged += InputFields_TextChanged;
            txbCK.TextChanged += InputFields_TextChanged;
            txbGK.TextChanged += InputFields_TextChanged;

            
            cb2017.Checked = true;
            
            btnTinhDiem.Enabled = false;
            btnTiepTuc.Enabled = false;
            UpdateComboBoxes();

            errorProvider = new ErrorProvider();

            
            txbCC.TextChanged += new EventHandler(txbCC_TextChanged);
            txbGK.TextChanged += new EventHandler(txbGK_TextChanged);
            txbCK.TextChanged += new EventHandler(txbCK_TextChanged);

            txbCC.KeyPress += new KeyPressEventHandler(txb_KeyPress);
            txbGK.KeyPress += new KeyPressEventHandler(txb_KeyPress);
            txbCK.KeyPress += new KeyPressEventHandler(txb_KeyPress);
            //CheckErrorState();
            InitializeEventHandlers();

        }


        private void InitializeEventHandlers()
        {
            
            txbCC.TextChanged += TxbDiem_TextChanged;
            txbGK.TextChanged += TxbDiem_TextChanged;
            txbCK.TextChanged += TxbDiem_TextChanged;

            
            btnTiepTuc.Click += BtnTiepTuc_Click;
        }
        private void BtnTiepTuc_Click(object sender, EventArgs e)
        {
            
            ResetForm();
        }
        private void ResetForm()
        {
            
            txbCC.Text = string.Empty;
            txbGK.Text = string.Empty;
            txbCK.Text = string.Empty;

            
            btnTinhDiem.Enabled = false;

            
            errorProvider.SetError(txbCC, string.Empty);
            errorProvider.SetError(txbGK, string.Empty);
            errorProvider.SetError(txbCK, string.Empty);
        }

        private void TxbDiem_TextChanged(object sender, EventArgs e)
        {
            
            ValidateDiem(txbCC, "Điểm chuyên cần");
            ValidateDiem(txbGK, "Điểm giữa kỳ");
            ValidateDiem(txbCK, "Điểm cuối kỳ");

            
            btnTinhDiem.Enabled = IsAllDiemValid();
        }

        private bool IsAllDiemValid()
        {
            
            bool isValidCC = ValidateDiem(txbCC, "Điểm chuyên cần");
            bool isValidGK = ValidateDiem(txbGK, "Điểm giữa kỳ");
            bool isValidCK = ValidateDiem(txbCK, "Điểm cuối kỳ");

            
            return isValidCC && isValidGK && isValidCK;
        }
        private void InputFields_TextChanged(object sender, EventArgs e)
        {
            InputValidate();
        }


        
        private void InputValidate()
        {
            string hoVaTen = txbHoTen.Text;
            string diemCC = txbCC.Text;
            string diemGK = txbGK.Text;
            string diemCK = txbCK.Text;

            bool IsNameNotEmpty = !string.IsNullOrEmpty(hoVaTen);
            bool IsDiemCCNotEmpty = !string.IsNullOrEmpty(diemCC);
            bool IsDiemGKNotEmpty = !string.IsNullOrEmpty(diemGK);
            bool IsDiemCKNotEmpty = !string.IsNullOrEmpty(diemCK);

            IsInputValid = IsNameNotEmpty && IsDiemCCNotEmpty && IsDiemGKNotEmpty && IsDiemCKNotEmpty;
            IsAnyFieldsNotEmpty = IsNameNotEmpty || IsDiemCCNotEmpty || IsDiemGKNotEmpty || IsDiemCKNotEmpty;
            btnTinhDiem.Enabled = IsInputValid;
            btnTiepTuc .Enabled = IsAnyFieldsNotEmpty;

        }
        
        private void InitializeData()
        {
            
            monHoc2017.Add("Tin học đại cương", new List<string> { "THDC1", "THDC2" });
            monHoc2017.Add("Thiết kế đồ họa", new List<string> { "TKDH1", "TKDH2" });
            monHoc2017.Add("Ứng dụng UML trong PTTK", new List<string> { "PTTK1", "PTTK2" });
            monHoc2017.Add("Kỹ thuật điện tử số", new List<string> { "DTS1", "DTS2" });
            monHoc2017.Add("Lập trình hệ thống", new List<string> { "LTHT1", "LTHT2" });
            lopHC2017.AddRange(new[] { "1710A01", "1710A02", "1710A03" });

            
            monHoc2022.Add("Khai phá dữ liệu và máy học", new List<string> { "KPDL1", "KPDL2" });
            monHoc2022.Add("Đánh giá hiệu năng mạng máy tính", new List<string> { "HNMMT1", "HNMMT2" });
            monHoc2022.Add("Phát triển ứng dụng vạn vật kết nối", new List<string> { "PTUD1", "PTUD2" });
            monHoc2022.Add("Xử lý dữ liệu lớn", new List<string> { "DLL1", "DLL2" });
            lopHC2022.AddRange(new[] { "2210A01", "2210A02", "2210A03" });
        }

        private void UpdateComboBoxes()
        {
            cbxMonHoc.Items.Clear();
            cbxLopHc.Items.Clear();

            if (cb2022.Checked)
            {
                cbxMonHoc.Items.AddRange(monHoc2022.Keys.ToArray());
                cbxLopHc.Items.AddRange(lopHC2022.ToArray());
            }
            else if (cb2017.Checked)
            {
                cbxMonHoc.Items.AddRange(monHoc2017.Keys.ToArray());
                cbxLopHc.Items.AddRange(lopHC2017.ToArray());
            }

            if (cbxMonHoc.Items.Count > 0)
                cbxMonHoc.SelectedIndex = 0;
            if (cbxLopHc.Items.Count > 0)
                cbxLopHc.SelectedIndex = 0;
        }

        private void cb2017_CheckedChanged(object sender, EventArgs e)
        {
            if (cb2017.Checked)
            {
                cb2022.Checked = false;
                UpdateComboBoxes();
            }
        }

        private void cb2022_CheckedChanged(object sender, EventArgs e)
        {
            if (cb2022.Checked)
            {
                cb2017.Checked = false;
                UpdateComboBoxes();
            }
        }

        private void cbxMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string selectedMonHoc = cbxMonHoc.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedMonHoc))
            {
                List<string> lopHC = cb2017.Checked ? monHoc2017[selectedMonHoc] : monHoc2022[selectedMonHoc];
                
            }
        }

        private void txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            
            TextBox textBox = sender as TextBox;
            if (e.KeyChar == '.' && textBox.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        

        private void txbCC_TextChanged(object sender, EventArgs e)
        {
            ValidateDiem(txbCC, "Điểm chuyên cần");
            CheckErrorState();
        }

        private void txbGK_TextChanged(object sender, EventArgs e)
        {
            ValidateDiem(txbGK, "Điểm giữa kỳ");
            CheckErrorState();
        }

        private void txbCK_TextChanged(object sender, EventArgs e)
        {
            ValidateDiem(txbCK, "Điểm cuối kỳ");
            CheckErrorState();
        }

        private bool ValidateDiem(TextBox textBox, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, string.Empty); // Xóa lỗi nếu không có giá trị
                return false;
            }
            else if (!float.TryParse(textBox.Text, out float diem) || diem < 0 || diem > 10)
            {
                errorProvider.SetError(textBox, $"{fieldName} không hợp lệ. Vui lòng nhập giá trị từ 0 đến 10.");
                return false;
            }
            else
            {
                errorProvider.SetError(textBox, string.Empty); // Xóa lỗi nếu hợp lệ
                return true;
            }
        }
        private void CheckErrorState()
        {
            
            if (!string.IsNullOrEmpty(errorProvider.GetError(txbCC)) &&
                !string.IsNullOrEmpty(errorProvider.GetError(txbGK)) &&
                !string.IsNullOrEmpty(errorProvider.GetError(txbCK)))
            {
                btnTinhDiem.Enabled = false;
            }
            else
            {
                btnTinhDiem.Enabled = true;
            }
        }
        private void btnTinhDiem_Click(object sender, EventArgs e)
        {
            
            string hoTen = txbHoTen.Text;
            string lopHC = cbxLopHc.SelectedItem.ToString();
            string monHoc = cbxMonHoc.SelectedItem.ToString();
            float diemCC = float.Parse(txbCC.Text);
            float diemGK = float.Parse(txbGK.Text);
            float diemCK = float.Parse(txbCK.Text);
            if (!float.TryParse(txbCC.Text, out _) || diemCC < 0 || diemCC > 10)
            {
                MessageBox.Show("Điểm chuyên cần không hợp lệ. Vui lòng nhập giá trị từ 0 đến 10.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!float.TryParse(txbGK.Text, out _) || diemGK < 0 || diemGK > 10)
            {
                MessageBox.Show("Điểm giữa kỳ không hợp lệ. Vui lòng nhập giá trị từ 0 đến 10.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!float.TryParse(txbCK.Text, out _) || diemCK < 0 || diemCK > 10)
            {
                MessageBox.Show("Điểm cuối kỳ không hợp lệ. Vui lòng nhập giá trị từ 0 đến 10.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            float diemTB = (diemCC * 0.1f) + (diemGK * 0.2f) + (diemCK * 0.7f);

            listBox1.Items.Add($"Tên: {hoTen}");
            listBox1.Items.Add($"Lớp hành chính: {lopHC}");
            listBox1.Items.Add($"Môn học: {monHoc}");
            listBox1.Items.Add($"Điểm trung bình: {diemTB:F2}");
            listBox1.Items.Add("");
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txbHoTen.Text = "";
            txbCC.Text = "";
            txbGK.Text = "";
            txbCK.Text = "";
            cb2017.Checked = true;


            listBox1.Items.Clear();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Cảnh Báo");
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
