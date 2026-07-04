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
    public partial class ReportNhanVien: Form
    {
        public ReportNhanVien()
        {
            InitializeComponent();
        }

        private void ReportNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "QUẢN_LÝ_KHÁCH_SẠN.ReportNhanVien.rdlc";
                ConnectDb connectDb = new ConnectDb();
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet1";
                reportDataSource.Value = connectDb.ReadData("select * from Users");
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
