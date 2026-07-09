using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace QUẢN_LÝ_KHÁCH_SẠN
{
    public partial class ReportBill : Form
    {
        public ReportBill()
        {
            InitializeComponent();
        }

        private void ReportBill_Load(object sender, EventArgs e)
        {
            // 1. Set the embedded report path definition first
            reportViewer1.LocalReport.ReportEmbeddedResource = "QUẢN_LÝ_KHÁCH_SẠN.ReportBill.rdlc";

            // 2. Retrieve data and bind it to the report layout
            ConnectDb connectDb = new ConnectDb();
            DataTable dtReportData = connectDb.ReadData("SELECT * FROM CtietHD");

            ReportDataSource reportDataSource = new ReportDataSource
            {
                Name = "DataSet1",
                Value = dtReportData
            };

            // 3. Clear existing sources to prevent duplication and append the fresh source
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            // 4. Refresh the report single time once configurations are complete
            this.reportViewer1.RefreshReport();
        }
    }
}