using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMV
{
    public partial class fInBC : Form
    {
        private string connectionString = "Data Source=MANIAC\\SQLEXPRESS;Initial Catalog=TMV;Integrated Security=True";
        public fInBC()
        {
            InitializeComponent();
        }
        public void ShowReport(string tenBC, string tenProc, string reportFilter)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = tenProc;
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                adapter.Fill(dt);

                                //Load du lieu len bao cao
                                ReportDocument report = new ReportDocument();
                                string path = string.Format("{0}\\BaoCao\\{1}", Application.StartupPath, tenBC);
                                report.Load(path);

                                report.Database.Tables[tenProc].SetDataSource(dt);

                                report.SetParameterValue("sNguoiLapBieu", "KDQ");

                                //đặt điều kiện để lọc các bản ghi hiển thị lên báo cáo
                                if (reportFilter != null)
                                {
                                    report.RecordSelectionFormula = reportFilter;
                                }


                                crystalReportViewer.ReportSource = report;
                                crystalReportViewer.Refresh();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
        }
        /*public void ShowReport()
        {
            ReportDocument report = new ReportDocument();
            string path = "C:\\Users\\Maniac\\Documents\\HSK\\TMV\\TMV\\BaoCao\\dskbTime.rpt";
            //string path = string.Format("{0}\\BaoCao\\{1}", Application.StartupPath, tenBaoCao);
            report.Load(path);

            crystalReportViewer.ReportSource = report;
            crystalReportViewer.Refresh();
        }*/
    }
}
