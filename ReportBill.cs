using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUẢN_LÝ_KHÁCH_SẠN
{
    public partial class ReportBill: Form
    {
        public ReportBill()
        {
            InitializeComponent();
        }

        private void ReportBill_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            reportViewer1.LocalReport.ReportEmbeddedResource = "QUẢN_LÝ_KHÁCH_SẠN.ReportBill.rdlc";
            ConnectDb connectDb = new ConnectDb();
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DataSet1";
            reportDataSource.Value = connectDb.ReadData("select * from CtietHD");
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
