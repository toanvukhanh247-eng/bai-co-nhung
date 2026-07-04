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
    public partial class Service: Form
    {
        public Service()
        {
            InitializeComponent();
        }
        ConnectDb Connect = new ConnectDb();
        private void LoaddataGrigService()
        {
            string sql = "select * from Service";
            DataTable dt = new DataTable();
            dt = Connect.ReadData(sql);
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }

        }
        private void Service_Load(object sender, EventArgs e)
        {
            LoaddataGrigService();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenDV.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtGiaTien.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string madv = txtMaDV.Text;
            string tendv = txtTenDV.Text;
            string giadv = txtGiaTien.Text;
            string sql = $"INSERT INTO Service VALUES ('{madv}',N'{tendv}','{giadv}')";
            int kq = Connect.WriteData(sql);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công 👍👍👍👍");
                LoaddataGrigService();
            }
            else
            {
                MessageBox.Show("Lỗi rồi mẹ ạ");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string madv = txtMaDV.Text;
            string tendv = txtTenDV.Text;
            string giadv = txtGiaTien.Text;
            string sql= "UPDATE Service SET TenDV=N'" + tendv + "',GiaTien='" + giadv + "' WHERE MaDV='" + madv + "'";
            int kq = Connect.WriteData(sql);
            if (kq > 0)
            {
                MessageBox.Show("Sửa thành công 👍👍👍👍");
                LoaddataGrigService();
            }
            else
            {
                MessageBox.Show("Lỗi rồi mẹ ạ");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string madv = txtMaDV.Text;
            string sql = "DELETE FROM Service WHERE MaDV='" + madv + "'";
            int kq = Connect.WriteData(sql);
            if (kq > 0)
            {
                MessageBox.Show("Xóa thành công 👍👍👍👍");
                LoaddataGrigService();
            }
            else
            {
                MessageBox.Show("Lỗi rồi mẹ ạ");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Service WHERE MaDV LIKE '%" + txtSearch.Text + "%' OR TenDV LIKE N'%" + txtSearch.Text + "%'";
            DataTable dt = new DataTable();
            dt = Connect.ReadData(sql);
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                LoaddataGrigService();
            }
        }
    }
}
