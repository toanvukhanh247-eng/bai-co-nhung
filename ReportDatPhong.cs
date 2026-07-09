using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace QUẢN_LÝ_KHÁCH_SẠN
{
    public partial class ReportDatPhong : Form
    {
        public ReportDatPhong()
        {
            InitializeComponent();
        }

        private void ReportDatPhong_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Bind the RDLC layout report to the viewer
                reportViewer1.LocalReport.ReportEmbeddedResource = "QUẢN_LÝ_KHÁCH_SẠN.ReportDatPhong.rdlc";

                // 2. Fetch booking data from the database
                ConnectDb connectDb = new ConnectDb();

                // Note: Change 'DatPhong' to your exact database table name if it differs
                DataTable dtBookingData = connectDb.ReadData("SELECT * FROM DatPhong");

                // 3. Set up the data source matching the RDLC dataset name
                ReportDataSource rds = new ReportDataSource
                {
                    Name = "DataSet1", // Ensure this matches the dataset name inside your RDLC file
                    Value = dtBookingData
                };

                // 4. Clear old data and attach the fresh data source
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);

                // 5. Render the report single time on screen loading
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải báo cáo đặt phòng: " + ex.Message, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}