namespace _1050080006_LyCuong_Tuan8
{
    partial class ThemNXB
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView lsvDanhSach;
        private System.Windows.Forms.ColumnHeader colMaNXB;
        private System.Windows.Forms.ColumnHeader colTenNXB;
        private System.Windows.Forms.ColumnHeader colDiaChi;

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblMaXB;
        private System.Windows.Forms.Label lblTenXB;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtMaXB;
        private System.Windows.Forms.TextBox txtTenXB;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnThemNXB;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lsvDanhSach = new System.Windows.Forms.ListView();
            this.colMaNXB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenNXB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblMaXB = new System.Windows.Forms.Label();
            this.txtMaXB = new System.Windows.Forms.TextBox();
            this.lblTenXB = new System.Windows.Forms.Label();
            this.txtTenXB = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnThemNXB = new System.Windows.Forms.Button();
            this.grpInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(760, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thêm dữ liệu";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lsvDanhSach
            // 
            this.lsvDanhSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaNXB,
            this.colTenNXB,
            this.colDiaChi});
            this.lsvDanhSach.FullRowSelect = true;
            this.lsvDanhSach.GridLines = true;
            this.lsvDanhSach.HideSelection = false;
            this.lsvDanhSach.Location = new System.Drawing.Point(12, 60);
            this.lsvDanhSach.MultiSelect = false;
            this.lsvDanhSach.Name = "lsvDanhSach";
            this.lsvDanhSach.Size = new System.Drawing.Size(460, 320);
            this.lsvDanhSach.TabIndex = 0;
            this.lsvDanhSach.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSach.View = System.Windows.Forms.View.Details;
            this.lsvDanhSach.SelectedIndexChanged += new System.EventHandler(this.lsvDanhSach_SelectedIndexChanged);
            // 
            // colMaNXB
            // 
            this.colMaNXB.Text = "Mã NXB";
            this.colMaNXB.Width = 80;
            // 
            // colTenNXB
            // 
            this.colTenNXB.Text = "Tên NXB";
            this.colTenNXB.Width = 180;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Text = "Địa chỉ";
            this.colDiaChi.Width = 200;
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.lblMaXB);
            this.grpInput.Controls.Add(this.txtMaXB);
            this.grpInput.Controls.Add(this.lblTenXB);
            this.grpInput.Controls.Add(this.txtTenXB);
            this.grpInput.Controls.Add(this.lblDiaChi);
            this.grpInput.Controls.Add(this.txtDiaChi);
            this.grpInput.Location = new System.Drawing.Point(490, 60);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(282, 200);
            this.grpInput.TabIndex = 1;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Thông tin nhập liệu:";
            // 
            // lblMaXB
            // 
            this.lblMaXB.AutoSize = true;
            this.lblMaXB.Location = new System.Drawing.Point(16, 30);
            this.lblMaXB.Name = "lblMaXB";
            this.lblMaXB.Size = new System.Drawing.Size(59, 16);
            this.lblMaXB.TabIndex = 0;
            this.lblMaXB.Text = "Mã NXB:";
            // 
            // txtMaXB
            // 
            this.txtMaXB.Location = new System.Drawing.Point(90, 27);
            this.txtMaXB.Name = "txtMaXB";
            this.txtMaXB.Size = new System.Drawing.Size(170, 22);
            this.txtMaXB.TabIndex = 1;
            // 
            // lblTenXB
            // 
            this.lblTenXB.AutoSize = true;
            this.lblTenXB.Location = new System.Drawing.Point(16, 93);
            this.lblTenXB.Name = "lblTenXB";
            this.lblTenXB.Size = new System.Drawing.Size(64, 16);
            this.lblTenXB.TabIndex = 2;
            this.lblTenXB.Text = "Tên NXB:";
            this.lblTenXB.Click += new System.EventHandler(this.lblTenXB_Click);
            // 
            // txtTenXB
            // 
            this.txtTenXB.Location = new System.Drawing.Point(90, 90);
            this.txtTenXB.Name = "txtTenXB";
            this.txtTenXB.Size = new System.Drawing.Size(170, 22);
            this.txtTenXB.TabIndex = 3;
            this.txtTenXB.TextChanged += new System.EventHandler(this.txtTenXB_TextChanged);
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(16, 154);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(50, 16);
            this.lblDiaChi.TabIndex = 4;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(90, 151);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(170, 22);
            this.txtDiaChi.TabIndex = 5;
            // 
            // btnThemNXB
            // 
            this.btnThemNXB.BackColor = System.Drawing.Color.LightGreen;
            this.btnThemNXB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemNXB.Location = new System.Drawing.Point(529, 317);
            this.btnThemNXB.Name = "btnThemNXB";
            this.btnThemNXB.Size = new System.Drawing.Size(210, 40);
            this.btnThemNXB.TabIndex = 2;
            this.btnThemNXB.Text = "Thêm nhà xuất bản";
            this.btnThemNXB.UseVisualStyleBackColor = false;
            this.btnThemNXB.Click += new System.EventHandler(this.btnThemNXB_Click);
            // 
            // ThemNXB
            // 
            this.ClientSize = new System.Drawing.Size(784, 401);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lsvDanhSach);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.btnThemNXB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ThemNXB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LyCuong-100080006-ThemDuLieu";
            this.Load += new System.EventHandler(this.ThemNXB_Load);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
