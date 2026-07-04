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
    public partial class QuenMatKhau: Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtAccount.Text.Trim()== "")
            {
                lblError.Text = "Vui lòng nhập tên tài khoản";
                return;
            }
            else
            {
                string sql = "select * from [Users] where MaNV = '" + txtAccount.Text + "'";
                if(txtAccount.Text == "admin")
                {
                    lblError.Text = "Mật khẩu của admin là: admin";
                }
                else
                {
                    ConnectDb con = new ConnectDb();
                    DataTable dt = con.ReadData(sql);
                    if (dt == null)
                    {
                        lblError.Text = "Tài khoản không tồn tại";
                    }
                    else
                    {
                        lblError.Text = "Mật khẩu của bạn là: " + dt.Rows[0]["MatKhau"].ToString();
                        txtAccount.Text = "";
                    }
                }
            }
        }
    }
}
