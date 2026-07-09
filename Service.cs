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
    public partial class Service : Form
    {
        private readonly ConnectDb connect = new ConnectDb();

        public Service()
        {
            InitializeComponent();
        }

        private void LoaddataGridService()
        {
            string sql = "SELECT * FROM Service";
            DataTable dt = connect.ReadData(sql);
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void Service_Load(object sender, EventArgs e)
        {
            LoaddataGridService();
        }

        // Fix: Changed from CellContentClick to CellClick for a better user experience
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtMaDV.Text = dataGridView1.CurrentRow.Cells[0].Value?.ToString() ?? "";
                txtTenDV.Text = dataGridView1.CurrentRow.Cells[1].Value?.ToString() ?? "";
                txtGiaTien.Text = dataGridView1.CurrentRow.Cells[2].Value?.ToString() ?? "";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string madv = txtMaDV.Text.Trim();
            string tendv = txtTenDV.Text.Trim();
            string giadv = txtGiaTien.Text.Trim();

            if (string.IsNullOrEmpty(madv) || string.IsNullOrEmpty(tendv))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin dịch vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = $"INSERT INTO Service (MaDV, TenDV, GiaTien) VALUES ('{madv}', N'{tendv}', '{giadv}')";
            int kq = connect.WriteData(sql);

            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công! 👍", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoaddataGridService();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Thêm thất bại. Vui lòng kiểm tra lại dữ liệu.", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string madv = txtMaDV.Text.Trim();
            string tendv = txtTenDV.Text.Trim();
            string giadv = txtGiaTien.Text.Trim();

            if (string.IsNullOrEmpty(madv))
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = $"UPDATE Service SET TenDV = N'{tendv}', GiaTien = '{giadv}' WHERE MaDV = '{madv}'";
            int kq = connect.WriteData(sql);

            if (kq > 0)
            {
                MessageBox.Show("Cập nhật thành công! 👍", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoaddataGridService();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại.", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string madv = txtMaDV.Text.Trim();

            if (string.IsNullOrEmpty(madv))
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa dịch vụ này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                string sql = $"DELETE FROM Service WHERE MaDV = '{madv}'";
                int kq = connect.WriteData(sql);

                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công! 👍", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoaddataGridService();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại.", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                LoaddataGridService();
                return;
            }

            string sql = $"SELECT * FROM Service WHERE MaDV LIKE '%{keyword}%' OR TenDV LIKE N'%{keyword}%'";
            DataTable dt = connect.ReadData(sql);

            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void ClearInputs()
        {
            txtMaDV.Clear();
            txtTenDV.Clear();
            txtGiaTien.Clear();
        }
    }
}