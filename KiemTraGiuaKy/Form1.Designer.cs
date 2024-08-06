namespace KiemTraGiuaKy
{
    partial class frmSanpham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lvSanpham = new System.Windows.Forms.ListView();
            this.colMaSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgaynhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLoaiSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.MaSP = new System.Windows.Forms.Label();
            this.tensp = new System.Windows.Forms.Label();
            this.ngaynhap = new System.Windows.Forms.Label();
            this.LoaiSP = new System.Windows.Forms.Label();
            this.cboLoaiSP = new System.Windows.Forms.ComboBox();
            this.loaiSPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSanphamDataSet1 = new KiemTraGiuaKy.QLSanphamDataSet1();
            this.sanphamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSanphamDataSet = new KiemTraGiuaKy.QLSanphamDataSet();
            this.dtNgaynhap = new System.Windows.Forms.DateTimePicker();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnKLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.sanphamTableAdapter = new KiemTraGiuaKy.QLSanphamDataSetTableAdapters.SanphamTableAdapter();
            this.loaiSPTableAdapter = new KiemTraGiuaKy.QLSanphamDataSet1TableAdapters.LoaiSPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSanphamDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanphamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSanphamDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC SẢN PHẨM";
            // 
            // lvSanpham
            // 
            this.lvSanpham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaSP,
            this.colTenSP,
            this.colNgaynhap,
            this.colLoaiSP});
            this.lvSanpham.HideSelection = false;
            this.lvSanpham.Location = new System.Drawing.Point(30, 112);
            this.lvSanpham.Name = "lvSanpham";
            this.lvSanpham.Size = new System.Drawing.Size(480, 297);
            this.lvSanpham.TabIndex = 1;
            this.lvSanpham.UseCompatibleStateImageBehavior = false;
            this.lvSanpham.View = System.Windows.Forms.View.Details;
            // 
            // colMaSP
            // 
            this.colMaSP.Text = "Mã SP";
            this.colMaSP.Width = 81;
            // 
            // colTenSP
            // 
            this.colTenSP.Text = "Tên sản phẩm";
            this.colTenSP.Width = 173;
            // 
            // colNgaynhap
            // 
            this.colNgaynhap.Text = "Ngày nhập";
            this.colNgaynhap.Width = 117;
            // 
            // colLoaiSP
            // 
            this.colLoaiSP.Text = "Loại sản phẩm";
            this.colLoaiSP.Width = 104;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(73, 56);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(100, 22);
            this.txtTim.TabIndex = 2;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(202, 56);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // MaSP
            // 
            this.MaSP.AutoSize = true;
            this.MaSP.Location = new System.Drawing.Point(543, 112);
            this.MaSP.Name = "MaSP";
            this.MaSP.Size = new System.Drawing.Size(50, 16);
            this.MaSP.TabIndex = 4;
            this.MaSP.Text = "Mã SP:";
            // 
            // tensp
            // 
            this.tensp.AutoSize = true;
            this.tensp.Location = new System.Drawing.Point(543, 182);
            this.tensp.Name = "tensp";
            this.tensp.Size = new System.Drawing.Size(55, 16);
            this.tensp.TabIndex = 5;
            this.tensp.Text = "Tên SP:";
            // 
            // ngaynhap
            // 
            this.ngaynhap.AutoSize = true;
            this.ngaynhap.Location = new System.Drawing.Point(543, 252);
            this.ngaynhap.Name = "ngaynhap";
            this.ngaynhap.Size = new System.Drawing.Size(79, 16);
            this.ngaynhap.TabIndex = 6;
            this.ngaynhap.Text = "Ngày Nhập:";
            // 
            // LoaiSP
            // 
            this.LoaiSP.AutoSize = true;
            this.LoaiSP.Location = new System.Drawing.Point(543, 320);
            this.LoaiSP.Name = "LoaiSP";
            this.LoaiSP.Size = new System.Drawing.Size(57, 16);
            this.LoaiSP.TabIndex = 7;
            this.LoaiSP.Text = "Loại SP:";
            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.DataSource = this.loaiSPBindingSource;
            this.cboLoaiSP.DisplayMember = "TenLoai";
            this.cboLoaiSP.FormattingEnabled = true;
            this.cboLoaiSP.Location = new System.Drawing.Point(628, 317);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Size = new System.Drawing.Size(121, 24);
            this.cboLoaiSP.TabIndex = 8;
            this.cboLoaiSP.ValueMember = "TenLoai";
            // 
            // loaiSPBindingSource
            // 
            this.loaiSPBindingSource.DataMember = "LoaiSP";
            this.loaiSPBindingSource.DataSource = this.qLSanphamDataSet1;
            // 
            // qLSanphamDataSet1
            // 
            this.qLSanphamDataSet1.DataSetName = "QLSanphamDataSet1";
            this.qLSanphamDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sanphamBindingSource
            // 
            this.sanphamBindingSource.DataMember = "Sanpham";
            this.sanphamBindingSource.DataSource = this.qLSanphamDataSet;
            // 
            // qLSanphamDataSet
            // 
            this.qLSanphamDataSet.DataSetName = "QLSanphamDataSet";
            this.qLSanphamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtNgaynhap
            // 
            this.dtNgaynhap.Location = new System.Drawing.Point(628, 247);
            this.dtNgaynhap.Name = "dtNgaynhap";
            this.dtNgaynhap.Size = new System.Drawing.Size(200, 22);
            this.dtNgaynhap.TabIndex = 9;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(628, 176);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(170, 22);
            this.txtTenSP.TabIndex = 10;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(628, 105);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(126, 22);
            this.txtMaSP.TabIndex = 11;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(73, 442);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(202, 442);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(331, 442);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(453, 442);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnKLuu
            // 
            this.btnKLuu.Location = new System.Drawing.Point(580, 442);
            this.btnKLuu.Name = "btnKLuu";
            this.btnKLuu.Size = new System.Drawing.Size(75, 23);
            this.btnKLuu.TabIndex = 16;
            this.btnKLuu.Text = "K.Lưu";
            this.btnKLuu.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(707, 442);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // sanphamTableAdapter
            // 
            this.sanphamTableAdapter.ClearBeforeFill = true;
            // 
            // loaiSPTableAdapter
            // 
            this.loaiSPTableAdapter.ClearBeforeFill = true;
            // 
            // frmSanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 517);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnKLuu);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.dtNgaynhap);
            this.Controls.Add(this.cboLoaiSP);
            this.Controls.Add(this.LoaiSP);
            this.Controls.Add(this.ngaynhap);
            this.Controls.Add(this.tensp);
            this.Controls.Add(this.MaSP);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.lvSanpham);
            this.Controls.Add(this.label1);
            this.Name = "frmSanpham";
            this.Text = "QuanLySanPham";
            this.Load += new System.EventHandler(this.frmSanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loaiSPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSanphamDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanphamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSanphamDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvSanpham;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label MaSP;
        private System.Windows.Forms.Label tensp;
        private System.Windows.Forms.Label ngaynhap;
        private System.Windows.Forms.Label LoaiSP;
        private System.Windows.Forms.ComboBox cboLoaiSP;
        private System.Windows.Forms.DateTimePicker dtNgaynhap;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnKLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ColumnHeader colMaSP;
        private System.Windows.Forms.ColumnHeader colTenSP;
        private System.Windows.Forms.ColumnHeader colNgaynhap;
        private System.Windows.Forms.ColumnHeader colLoaiSP;
        private QLSanphamDataSet qLSanphamDataSet;
        private System.Windows.Forms.BindingSource sanphamBindingSource;
        private QLSanphamDataSetTableAdapters.SanphamTableAdapter sanphamTableAdapter;
        private QLSanphamDataSet1 qLSanphamDataSet1;
        private System.Windows.Forms.BindingSource loaiSPBindingSource;
        private QLSanphamDataSet1TableAdapters.LoaiSPTableAdapter loaiSPTableAdapter;
    }
}

