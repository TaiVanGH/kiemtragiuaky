using KiemTraGiuaKy.QLSP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTraGiuaKy
{
    public partial class frmSanpham : Form
    {
        public frmSanpham()
        {
            InitializeComponent();
        }

        private void frmSanpham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSanphamDataSet1.LoaiSP' table. You can move, or remove it, as needed.
            this.loaiSPTableAdapter.Fill(this.qLSanphamDataSet1.LoaiSP);
            // TODO: This line of code loads data into the 'qLSanphamDataSet.Sanpham' table. You can move, or remove it, as needed.
            this.sanphamTableAdapter.Fill(this.qLSanphamDataSet.Sanpham);
            lvSanpham.Columns[0].Width = (int)(lvSanpham.Width * 0.25);
            lvSanpham.Columns[1].Width = (int)(lvSanpham.Width * 0.25);
            lvSanpham.Columns[2].Width = (int)(lvSanpham.Width * 0.25);
            lvSanpham.Columns[3].Width = (int)(lvSanpham.Width * 0.25);
            lvSanpham.View = View.Details;
           lvSanpham.GridLines = true;
            lvSanpham.FullRowSelect = false;
        }

        public void HienThiDuLieuVao_Combo_LoaiSP()
        {

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvSanpham.Items.Add(txtMaSP.Text);
            item.SubItems.Add(txtTenSP.Text);
            item.SubItems.Add(dtNgaynhap.Value.ToShortDateString());
            //item.SubItems.Add(cboLoaiSP.);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            lvSanpham.SelectedItems[0].SubItems[0].Text = txtMaSP.Text;
            lvSanpham.SelectedItems[0].SubItems[1].Text = txtTenSP.Text;
            lvSanpham.SelectedItems[0].SubItems[2].Text = dtNgaynhap.Value.ToShortDateString();
            lvSanpham.SelectedItems[0].SubItems[3].Text = cboLoaiSP.Text;

        }

        private void lvSanpham_SelectedIndexChanged(object sender, EventArgs e,)
        {

            if (lvSanpham.SelectedItems.Count>0)
            {
                txtMaSP.Text = lvSanpham.SelectedItems[0].SubItems[0].Text;
                txtTenSP.Text = lvSanpham.SelectedItems[0].SubItems[1].Text;
                dtNgaynhap.Text = lvSanpham.SelectedItems[0].SubItems[2].Text;
                cboLoaiSP.Text = lvSanpham.SelectedItems[0].SubItems[3].Text; 
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvSanpham.SelectedItems.Count > 0)
            {
                lvSanpham.Items.Remove(lvSanpham.SelectedItems[0]); 
            }
            else
            {
                MessageBox.Show("Phải chọn ít nhất 1 dòng");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string searchText = txtTim.Text;
            ListViewItem foundItem = lvSanpham.FindItemWithText(searchText);
            if(foundItem!=null)
            {
                lvSanpham.FocusedItem = foundItem;
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu");
            }
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận thoát", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
