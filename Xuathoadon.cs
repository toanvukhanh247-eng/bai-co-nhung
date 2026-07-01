using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.IO;

using System.Drawing.Imaging;

namespace QUẢN_LÝ_KHÁCH_SẠN
{
    public partial class Xuathoadon: Form
    {
        public Xuathoadon(string mahd)
        {
            InitializeComponent();
            lblMaHD.Text = mahd;
            Loaddata();
            LoadSDDV();
            Loadngay();
            TienP();
        }
        ConnectDb Connect = new ConnectDb();
        private void LoadSDDV()
        {
            if (string.IsNullOrEmpty(lblSDDV.Text)) return;

            // Tách chuỗi thành danh sách mã dịch vụ
            string[] dsMaDV = lblSDDV.Text.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (dsMaDV.Length == 0) return;
            string dsMaDV_SQL = string.Join("','", dsMaDV);  // Kết quả: 'Vip01','Vip02'
            string sql = $"SELECT * FROM Service WHERE MaDV IN ('{dsMaDV_SQL}')";
            DataTable dt = Connect.ReadData(sql);
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }
        private void Loaddata()
        {
             string sql = @"
        SELECT *
        FROM CtietHD ct
        JOIN Customers cu ON ct.CCCD = cu.CCCD
        JOIN Booking b ON b.MaHD = ct.MaHD
        JOIN Users u ON u.MaNV = ct.MaNV 
        JOIN Rooms r ON r.MaPhong = ct.MaPhong
        WHERE ct.MaHD = '" + lblMaHD.Text + "'"; // Chỉ rõ ct.MaHD
            DataTable dt = Connect.ReadData(sql);
            if (dt != null)
            {
                lblNhanvien.Text = dt.Rows[0]["TenNV"].ToString();
                lblNgaytt.Text = dt.Rows[0]["NgayThanhToan"].ToString();
                lblTongTine.Text = dt.Rows[0]["TongTien"].ToString();
                lblMaP.Text = dt.Rows[0]["MaPhong"].ToString();
                lblTenKH.Text = dt.Rows[0]["TenKH"].ToString();
                lblDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
                lblSdt.Text = dt.Rows[0]["SDT"].ToString();
                lblSDDV.Text = dt.Rows[0]["MaSDDV"].ToString();
                lblNgayden.Text = dt.Rows[0]["NgayDen"].ToString();
                lblNgaydi.Text = dt.Rows[0]["NgayDi"].ToString();
                lblTrangthai.Text = dt.Rows[0]["TrangThai"].ToString();
                lblTienphong.Text = dt.Rows[0]["GiaPhong"].ToString();
            }
            
        }
        private void TienP()
        {
            lblTongphong.Text = (int.Parse(lblTienphong.Text) * int.Parse(lblSongay.Text)).ToString();
        }
        private void Loadngay()
        {
            DateTime ngayden = DateTime.Parse(lblNgayden.Text);
            DateTime ngaydi = DateTime.Parse(lblNgaydi.Text);
            TimeSpan time = ngaydi - ngayden;
            int songay = time.Days+1;
            lblSongay.Text = songay.ToString();
        }
        private void XuatHD()
        {
            // Chụp lại giao diện form
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));//Chụp lại nội dung hiển thị trên form rồi vẽ lên đối tượng bmp.

            // Hộp thoại chọn nơi lưu
            using (SaveFileDialog sfd = new SaveFileDialog())//Mở hộp thoại để người dùng chọn nơi lưu file PDF.
            {
                sfd.Filter = "PDF files (*.pdf)|*.pdf";
                sfd.Title = "Chọn nơi lưu hóa đơn";
                sfd.FileName = $"HoaDon_{lblMaHD.Text}.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (MemoryStream ms = new MemoryStream())//Tạo một bộ nhớ tạm (stream) để chứa ảnh đã chụp (ảnh dạng PNG).
                    {
                        bmp.Save(ms, ImageFormat.Png);
                        ms.Position = 0;

                        using (PdfDocument doc = new PdfDocument())//Tạo một đối tượng tài liệu PDF mới (từ thư viện PdfSharp).
                        {
                            PdfPage page = doc.AddPage();
                            page.Width = bmp.Width;
                            page.Height = bmp.Height;

                            using (XGraphics gfx = XGraphics.FromPdfPage(page))//Tạo đối tượng XGraphics để vẽ nội dung lên trang PDF.
                            using (XImage img = XImage.FromStream(ms))////Tạo hình ảnh XImage từ stream ms.
                            {
                                gfx.DrawImage(img, 0, 0);
                            }

                            doc.Save(sfd.FileName);//Lưu tài liệu PDF vào vị trí đã chọn trong hộp thoại.
                            MessageBox.Show("✅ 👌👌👌 Đã lưu hóa đơn thành công tại:\n" + sfd.FileName, "Thông báo");
                        }
                    }
                }
            }
        }



        private void guna2Button1_Click(object sender, EventArgs e)
        {   
            btnXuatHD.Visible = false;
            btnExit.Visible = false;
            XuatHD();
            btnXuatHD.Visible = true;
            btnExit.Visible = true;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
