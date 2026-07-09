using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace QUẢN_LÝ_KHÁCH_SẠN
{
    public partial class ReportKhachHang : Form
    {
        public ReportKhachHang()
        {
            InitializeComponent();
        }

        private void ReportKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Assign the embedded report definition path
                reportViewer1.LocalReport.ReportEmbeddedResource = "QUẢN_LÝ_KHÁCH_SẠN.ReportKhachHang.rdlc";

                // 2. Fetch the customer data
                ConnectDb connectDb = new ConnectDb();
                DataTable dtCustomers = connectDb.ReadData("SELECT * FROM Customers");

                // 3. Initialize the data source cleanly using modern syntax
                ReportDataSource reportDataSource = new ReportDataSource
                {
                    Name = "DataSet1",
                    Value = dtCustomers
                };

                // 4. Safely clear old data mappings and bind the fresh data source
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                // 5. Trigger a single rendering update
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải báo cáo khách hàng: " + ex.Message, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}