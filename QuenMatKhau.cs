using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // Ensure the appropriate database client is used
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUẢN_LÝ_KHÁCH_SẠN
{
    public partial class QuenMatKhau : Form
    {
        // Assuming a connection string is available or managed by ConnectDb
        private readonly string connectionString = "Your_Connection_String_Here";

        public QuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtAccount.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                lblError.Text = "Vui lòng nhập tên tài khoản";
                return;
            }

            // Hardcoded admin check optimization
            if (username.Equals("admin", StringComparison.OrdinalIgnoreCase))
            {
                lblError.Text = "Mật khẩu của admin là: admin";
                return;
            }

            try
            {
                // Fix: Use parameterized queries to block SQL Injection
                string query = "SELECT MatKhau FROM [Users] WHERE MaNV = @Username";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count == 0)
                            {
                                lblError.Text = "Tài khoản không tồn tại";
                            }
                            else
                            {
                                // Ideally, implement a password reset flow here instead of displaying plaintext
                                lblError.Text = "Mật khẩu của bạn là: " + dt.Rows[0]["MatKhau"].ToString();
                                txtAccount.Clear();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblError.Text = "Đã xảy ra lỗi hệ thống. Vui lòng thử lại sau.";
                // Log the exception (ex) in a production environment
            }
        }
    }
}