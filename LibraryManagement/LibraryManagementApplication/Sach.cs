using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementApplication.ServiceLibrary;

namespace LibraryManagementApplication
{
    public partial class frmSach : Form
    {
        ServiceLibraryClient client = new ServiceLibraryClient();
        private int check = 0;
        private int id = 0;
        public frmSach()
        {
            InitializeComponent();
        }

        private void resetform()
        {
            txtTieuDeSach.Enabled = false;
            txtMoTaSach.Enabled = false;
            txtSoTrangSach.Enabled = false;
            txtGiaSach.Enabled = false;
            dtNgayNhapSach.Enabled = false;
            txtSoLuongSach.Enabled = false;
            txtNamXBSach.Enabled = false;
            cbNXBSach.Enabled = false;
            cbTheLoaiSach.Enabled = false;
            btnThemSach.Enabled = true;
            btnSuaSach.Enabled = false;
            btnXoaSach.Enabled = false;
            btnHuySach.Enabled = false;
            btnLuuSach.Enabled = false;
            txtTieuDeSach.Text = "";
            txtMoTaSach.Text = "";
            txtSoTrangSach.Text = "";
            txtGiaSach.Text = "";
            dtNgayNhapSach.Text = "";
            txtSoLuongSach.Text = "";
            txtNamXBSach.Text = "";
            cbNXBSach.DataSource = client.listAllPublisher();
            cbNXBSach.DisplayMember = "TenNXB";
            cbNXBSach.ValueMember = "MaNXB";
            cbTheLoaiSach.DataSource = client.listAllCategory();
            cbTheLoaiSach.DisplayMember = "TenDanhMuc";
            cbTheLoaiSach.ValueMember = "MaDanhMuc";
            dgvSach.DataSource = client.listAllBook();
            List<string> listStr = new List<string>(){"Nhà xuất bản", "Tác giả", "Thể loại", "Tiêu đề sách"};
            cbTimKiem.DataSource = listStr;
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            resetform();
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            resetform();
            txtTieuDeSach.Enabled = true;
            txtMoTaSach.Enabled = true;
            txtSoTrangSach.Enabled = true;
            txtGiaSach.Enabled = true;
            dtNgayNhapSach.Enabled = true;
            txtSoLuongSach.Enabled = true;
            txtNamXBSach.Enabled = true;
            cbNXBSach.Enabled = true;
            cbTheLoaiSach.Enabled = true;
            btnHuySach.Enabled = true;
            btnLuuSach.Enabled = true;
            check = 1;
        }

        private void btnHuySach_Click(object sender, EventArgs e)
        {
            resetform();
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            txtTieuDeSach.Enabled = true;
            txtMoTaSach.Enabled = true;
            txtSoTrangSach.Enabled = true;
            txtGiaSach.Enabled = true;
            dtNgayNhapSach.Enabled = true;
            txtSoLuongSach.Enabled = true;
            txtNamXBSach.Enabled = true;
            cbNXBSach.Enabled = true;
            cbTheLoaiSach.Enabled = true;
            btnHuySach.Enabled = true;
            btnLuuSach.Enabled = true;
            check = 2;
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            try
            {
                client.deleteBook(id);
                resetform();
                MessageBox.Show("Xóa dữ liệu thành công!", "Chúc mừng", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btnLuuSach_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                try
                {
                    if (txtTieuDeSach.Text.Equals("") || txtMoTaSach.Text.Equals("") || dtNgayNhapSach.Value == null ||
                        txtSoTrangSach.Text.Equals("") || txtSoLuongSach.Text.Equals("") || txtGiaSach.Text.Equals("") || 
                        txtNamXBSach.Text.Equals(""))
                    {
                        MessageBox.Show("Bạn cần điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        Sach entity = new Sach();
                        entity.TieuDeSach = txtTieuDeSach.Text;
                        entity.MoTa = txtMoTaSach.Text;
                        entity.SoTrang = int.Parse(txtSoTrangSach.Text);
                        entity.GiaTien = int.Parse(txtGiaSach.Text);
                        entity.NgayNhapKho = dtNgayNhapSach.Value;
                        entity.SoLuongTon = int.Parse(txtSoLuongSach.Text);
                        entity.NamXuatBan = int.Parse(txtNamXBSach.Text);
                        entity.MaNXB = int.Parse(cbNXBSach.SelectedValue.ToString());
                        entity.MaDanhMuc = int.Parse(cbTheLoaiSach.SelectedValue.ToString());
                        client.createBook(entity);
                        MessageBox.Show("Thêm mới thành công!", "Chúc mừng", MessageBoxButtons.OK);
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm mới thất bại", "Lỗi", MessageBoxButtons.OK);
                }
            }
            if (check == 2)
            {
                try
                {
                    if (txtTieuDeSach.Text.Equals("") || txtMoTaSach.Text.Equals("") || dtNgayNhapSach.Value == null ||
                        txtSoTrangSach.Text.Equals("") || txtSoLuongSach.Text.Equals("") || txtGiaSach.Text.Equals("") ||
                        txtNamXBSach.Text.Equals(""))
                    {
                        MessageBox.Show("Bạn cần điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        Sach entity = new Sach();
                        entity.MaSach = id;
                        entity.TieuDeSach = txtTieuDeSach.Text;
                        entity.MoTa = txtMoTaSach.Text;
                        entity.SoTrang = int.Parse(txtSoTrangSach.Text);
                        entity.GiaTien = int.Parse(txtGiaSach.Text);
                        entity.NgayNhapKho = dtNgayNhapSach.Value;
                        entity.SoLuongTon = int.Parse(txtSoLuongSach.Text);
                        entity.NamXuatBan = int.Parse(txtNamXBSach.Text);
                        entity.MaNXB = int.Parse(cbNXBSach.SelectedValue.ToString());
                        entity.MaDanhMuc = int.Parse(cbTheLoaiSach.SelectedValue.ToString());
                        client.editBook(entity);
                        MessageBox.Show("Sửa thông tin thành công!", "Chúc mừng", MessageBoxButtons.OK);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa thông tin thất bại", "Lỗi", MessageBoxButtons.OK);
                }
            }
            resetform();
        }

        private void btnTimKiemSach_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTimKiemSach.Text.Equals(""))
                {
                    dgvSach.DataSource = client.listAllBook();
                }
                else
                {
                    dgvSach.DataSource = client.searchBook(txtTimKiemSach.Text, cbTimKiem.SelectedValue.ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void dgvSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id = int.Parse(dgvSach.Rows[e.RowIndex].Cells[2].Value.ToString());
                txtTieuDeSach.Text = dgvSach.Rows[e.RowIndex].Cells[11].Value.ToString();
                txtMoTaSach.Text = dgvSach.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtSoTrangSach.Text = dgvSach.Rows[e.RowIndex].Cells[10].Value.ToString();
                txtGiaSach.Text = dgvSach.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtNgayNhapSach.Text = dgvSach.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtSoLuongSach.Text = dgvSach.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtNamXBSach.Text = dgvSach.Rows[e.RowIndex].Cells[6].Value.ToString();
                cbNXBSach.SelectedValue = dgvSach.Rows[e.RowIndex].Cells[3].Value;
                cbTheLoaiSach.SelectedValue = dgvSach.Rows[e.RowIndex].Cells[4].Value;
                btnSuaSach.Enabled = true;
                btnXoaSach.Enabled = true;
                btnHuySach.Enabled = true;
                btnLuuSach.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Click chuột sai vị trí", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhoa x = new frmKhoa();
            x.Show();
            this.Hide();
        }

        private void thẻThưViệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCardType x = new frmCardType();
            x.Show();
            this.Hide();
        }

        private void độcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDocGia x = new frmDocGia();
            x.Show();
            this.Hide();
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTacGia x = new frmTacGia();
            x.Show();
            this.Hide();
        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNXB x = new frmNXB();
            x.Show();
            this.Hide();
        }

        private void thểLoạiSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTheLoai x = new frmTheLoai();
            x.Show();
            this.Hide();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSach x = new frmSach();
            x.Show();
            this.Hide();
        }

        private void thủThưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThuThu x = new frmThuThu();
            x.Show();
            this.Hide();
        }

        private void phiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuMuon x = new frmPhieuMuon();
            x.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void giaoDiệnChínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHome x = new frmHome();
            x.Show();
            this.Hide();
        }

    }
}
