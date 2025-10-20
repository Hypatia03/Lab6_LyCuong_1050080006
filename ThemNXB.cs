using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _1050080006_LyCuong_Tuan8
{
    public partial class ThemNXB : Form
    {
        // Dùng connection string bạn cung cấp
        private string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\Downloads\BTtuan8\1050080006-LyCuong-Tuan8\1050080006-LyCuong-Tuan8\QuanLyBanSach.mdf"";Integrated Security=True";
        private SqlConnection sqlCon = null;

        public ThemNXB()
        {
            InitializeComponent();
        }

        private void MoKetNoi()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }

        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
        }

        private void ThemNXB_Load(object sender, EventArgs e)
        {
            LoadNXBs();
        }

        /// <summary>
        /// Load danh sách NXB bằng stored procedure sp_HienThiNXB
        /// </summary>
        private void LoadNXBs()
        {
            lsvDanhSach.Items.Clear();
            try
            {
                MoKetNoi();
                using (SqlCommand cmd = new SqlCommand("HienThiNXB", sqlCon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
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
                MessageBox.Show("Lỗi khi tải danh sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DongKetNoi();
            }
        }

        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0)
            {
                txtMaXB.Text = txtTenXB.Text = txtDiaChi.Text = "";
                return;
            }

            var item = lsvDanhSach.SelectedItems[0];
            txtMaXB.Text = item.SubItems[0].Text.Trim();
            txtTenXB.Text = item.SubItems[1].Text;
            txtDiaChi.Text = item.SubItems[2].Text;
        }

        /// <summary>
        /// Thêm NXB bằng stored procedure ThemDuLieu (tham số: @maXB, @tenXB, @diaChi)
        /// </summary>
        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            // Validate
            if (string.IsNullOrWhiteSpace(txtMaXB.Text))
            {
                MessageBox.Show("Nhập Mã NXB.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaXB.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenXB.Text))
            {
                MessageBox.Show("Nhập Tên NXB.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenXB.Focus();
                return;
            }

            try
            {
                MoKetNoi();
                using (SqlCommand cmd = new SqlCommand("ThemDuLieu", sqlCon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("@maXB", SqlDbType.Char, 10) { Value = txtMaXB.Text.Trim() };
                    var p2 = new SqlParameter("@tenXB", SqlDbType.NVarChar, 100) { Value = txtTenXB.Text.Trim() };
                    var p3 = new SqlParameter("@diaChi", SqlDbType.NVarChar, 500) { Value = txtDiaChi.Text.Trim() };

                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);

                    int rows = cmd.ExecuteNonQuery();

                    // ExecuteNonQuery trả về số hàng affected; nếu procedure dùng RAISERROR sẽ throw exception
                    if (rows > 0)
                    {
                        MessageBox.Show("Thêm nhà xuất bản thành công.", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadNXBs();
                        // chọn item vừa thêm
                        foreach (ListViewItem it in lsvDanhSach.Items)
                        {
                            if (it.SubItems[0].Text.Trim() == txtMaXB.Text.Trim())
                            {
                                it.Selected = true;
                                it.Focused = true;
                                it.EnsureVisible();
                                break;
                            }
                        }
                    }
                    else
                    {
                        // Một số trường hợp procedure không trả rows > 0 (tùy cách viết). vẫn refresh
                        LoadNXBs();
                        MessageBox.Show("Hoàn tất (không có rows trả về).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("Lỗi SQL: " + sqlex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DongKetNoi();
            }
        }

        private void lblTenXB_Click(object sender, EventArgs e)
        {

        }

        private void txtTenXB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
