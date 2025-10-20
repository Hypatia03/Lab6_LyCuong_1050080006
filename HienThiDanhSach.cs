using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _1050080006_LyCuong_Tuan8
{
    public partial class HienThiDanhSach : Form
    {
        // Chỉnh chuỗi kết nối cho phù hợp với môi trường của bạn
        // Ví dụ: @"Server=DESKTOP-KQS8PTG;Database=NET;Integrated Security=True;";
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\Downloads\BTtuan8\1050080006-LyCuong-Tuan8\1050080006-LyCuong-Tuan8\QuanLyBanSach.mdf"";Integrated Security=True";

        public HienThiDanhSach()
        {
            InitializeComponent();
        }

        private void HienThiDanhSach_Load(object sender, EventArgs e)
        {
            LoadNXBs();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadNXBs();
        }

        /// <summary>
        /// Gọi stored procedure sp_HienThiNXB để load danh sách NXB vào ListView
        /// </summary>
        private void LoadNXBs()
        {
            lsvDanhSach.Items.Clear();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("HienThiNXB", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string ma = reader.IsDBNull(0) ? "" : reader.GetString(0).Trim();
                            string ten = reader.IsDBNull(1) ? "" : reader.GetString(1);
                            string diachi = reader.IsDBNull(2) ? "" : reader.GetString(2);

                            ListViewItem lvi = new ListViewItem(ma);
                            lvi.SubItems.Add(ten);
                            lvi.SubItems.Add(diachi);
                            lsvDanhSach.Items.Add(lvi);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gọi stored procedure sp_HienThiChiTietNXB để lấy chi tiết theo mã NXB
        /// </summary>
        /// <param name="maNXB"></param>
        private void LoadNXBDetail(string maNXB)
        {
            txtMaNXB.Text = txtTenNXB.Text = txtDiaChi.Text = "";

            if (string.IsNullOrEmpty(maNXB)) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("HienThiChiTietNXB", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // tham số CHAR(10) — đảm bảo truyền đúng kích thước nếu cần
                    SqlParameter p = new SqlParameter("@MaNXB", SqlDbType.Char, 10);
                    p.Value = maNXB;
                    cmd.Parameters.Add(p);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtMaNXB.Text = reader.IsDBNull(0) ? "" : reader.GetString(0).Trim();
                            txtTenNXB.Text = reader.IsDBNull(1) ? "" : reader.GetString(1);
                            txtDiaChi.Text = reader.IsDBNull(2) ? "" : reader.GetString(2);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải chi tiết: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0)
            {
                txtMaNXB.Text = txtTenNXB.Text = txtDiaChi.Text = "";
                return;
            }

            var item = lsvDanhSach.SelectedItems[0];
            string ma = item.SubItems[0].Text.Trim();

            // Lấy chi tiết từ database bằng stored procedure
            LoadNXBDetail(ma);
        }
    }
}
