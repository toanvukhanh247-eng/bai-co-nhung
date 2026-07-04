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
    public partial class ReportVatTu: Form
    {
        public ReportVatTu()
        {
            InitializeComponent();
        }

        private void ReportVatTu_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            reportViewer1.LocalReport.ReportEmbeddedResource = "QUẢN_LÝ_KHÁCH_SẠN.ReportVatTu.rdlc";
            ConnectDb connectDb = new ConnectDb();
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DataSet1";
            reportDataSource.Value = connectDb.ReadData("select * from Materials");
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
