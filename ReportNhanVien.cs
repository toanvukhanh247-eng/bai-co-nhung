using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace QUẢN_LÝ_KHÁCH_SẠN
{
    public partial class ReportNhanVien : Form
    {
        public ReportNhanVien()
        {
            InitializeComponent();
        }

        private void ReportNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Assign the embedded report definition path mapping
                reportViewer1.LocalReport.ReportEmbeddedResource = "QUẢN_LÝ_KHÁCH_SẠN.ReportNhanVien.rdlc";

                // 2. Fetch staff/user dataset from database
                ConnectDb connectDb = new ConnectDb();
                DataTable dtEmployees = connectDb.ReadData("SELECT * FROM Users");

                // 3. Clean initialization matching the RDLC configuration name
                ReportDataSource reportDataSource = new ReportDataSource
                {
                    Name = "DataSet1",
                    Value = dtEmployees
                };

                // 4. Safely purge older references to prevent duplicate runtime exceptions
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                // 5. Trigger a single, unified display rendering execution pass
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải báo cáo nhân viên: " + ex.Message, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}