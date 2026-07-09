using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace QUẢN_LÝ_KHÁCH_SẠN
{
    public partial class ReportVatTu : Form
    {
        public ReportVatTu()
        {
            InitializeComponent();
        }

        private void ReportVatTu_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Assign the embedded report definition path mapping
                reportViewer1.LocalReport.ReportEmbeddedResource = "QUẢN_LÝ_KHÁCH_SẠN.ReportVatTu.rdlc";

                // 2. Fetch the inventory/materials dataset from the database
                ConnectDb connectDb = new ConnectDb();
                DataTable dtMaterials = connectDb.ReadData("SELECT * FROM Materials");

                // 3. Modern initialization matching the RDLC configuration name
                ReportDataSource reportDataSource = new ReportDataSource
                {
                    Name = "DataSet1",
                    Value = dtMaterials
                };

                // 4. Safely clear old references to prevent duplicate runtime exceptions
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                // 5. Trigger a single, unified display rendering execution pass
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải báo cáo vật tư: " + ex.Message, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
