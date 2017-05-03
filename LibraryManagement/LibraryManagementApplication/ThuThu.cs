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
    public partial class frmThuThu : Form
    {
        ServiceLibraryClient client = new ServiceLibraryClient();
        private int check = 0;
        public frmThuThu()
        {
            InitializeComponent();
        }
        private void resetform()
        {
            txtMaThuThu.Enabled = false;
            txtTenThuThu.Enabled = false;
            dtNgaySinhThuThu.Enabled = false;
            txtDiaChiThuThu.Enabled = false;
            txtDienThoaiThuThu.Enabled = false;
            txtEmailThuThu.Enabled = false;
            txtTaiKhoanThuThu.Enabled = false;
            txtMatKhauThuThu.Enabled = false;
            cbPhanQuyenThuThu.Enabled = false;
            btnThemThuThu.Enabled = true;
            btnSuaThuThu.Enabled = false;
            btnXoaThuThu.Enabled = false;
            btnHuyThuThu.Enabled = false;
            btnLuuThuThu.Enabled = false;
            txtTimKiemThuThu.Enabled = true;
            btnTimKiemThuThu.Enabled = true;
            txtMaThuThu.Text = "";
            txtTenThuThu.Text = "";
            dtNgaySinhThuThu.Text = "";
            txtDiaChiThuThu.Text = "";
            txtDienThoaiThuThu.Text = "";
            txtEmailThuThu.Text = "";
            txtTaiKhoanThuThu.Text = "";
            txtMatKhauThuThu.Text = "";
            cbPhanQuyenThuThu.Text = "";
            dgvThuThu.DataSource = client.listAllLibrarian();
        }
        private void frmThuThu_Load(object sender, EventArgs e)
        {
            resetform();
            cbPhanQuyenThuThu.Items.Add("Nhân viên");
            cbPhanQuyenThuThu.Items.Add("Quản lý");
        }

        private void dgvThuThu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                resetform();
                txtMaThuThu.Text = dgvThuThu.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTenThuThu.Text = dgvThuThu.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtNgaySinhThuThu.Text = dgvThuThu.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtDiaChiThuThu.Text = dgvThuThu.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtDienThoaiThuThu.Text = dgvThuThu.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtEmailThuThu.Text = dgvThuThu.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTaiKhoanThuThu.Text = dgvThuThu.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtMatKhauThuThu.Text = dgvThuThu.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (dgvThuThu.Rows[e.RowIndex].Cells[6].Value.ToString().Equals("True"))
                    cbPhanQuyenThuThu.Text = "Quản lý";
                else
                    cbPhanQuyenThuThu.Text = "Nhân viên";
                btnSuaThuThu.Enabled = true;
                btnLuuThuThu.Enabled = true;
                btnHuyThuThu.Enabled = true;
                btnXoaThuThu.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Click chuột sai vị trí", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btnThemThuThu_Click(object sender, EventArgs e)
        {
            resetform();
            txtMaThuThu.Enabled = true;
            txtTenThuThu.Enabled = true;
            dtNgaySinhThuThu.Enabled = true;
            txtDiaChiThuThu.Enabled = true;
            txtDienThoaiThuThu.Enabled = true;
            txtEmailThuThu.Enabled = true;
            txtTaiKhoanThuThu.Enabled = true;
            txtMatKhauThuThu.Enabled = true;
            cbPhanQuyenThuThu.Enabled = true;
            btnHuyThuThu.Enabled = true;
            btnLuuThuThu.Enabled = true;
            check = 1;
        }

        private void btnHuyThuThu_Click(object sender, EventArgs e)
        {
            resetform();
        }

        private void btnSuaThuThu_Click(object sender, EventArgs e)
        {
            txtTenThuThu.Enabled = true;
            dtNgaySinhThuThu.Enabled = true;
            txtDiaChiThuThu.Enabled = true;
            txtDienThoaiThuThu.Enabled = true;
            txtEmailThuThu.Enabled = true;
            txtMatKhauThuThu.Enabled = true;
            cbPhanQuyenThuThu.Enabled = true;
            check = 2;
        }

        private void btnLuuThuThu_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                try
                {
                    if (txtMaThuThu.Text.Equals("") || txtTenThuThu.Text.Equals("") || dtNgaySinhThuThu.Value == null ||
                        txtDiaChiThuThu.Text.Equals("") || txtDienThoaiThuThu.Text.Equals("") || txtEmailThuThu.Text.Equals("")
                        || txtTaiKhoanThuThu.Text.Equals("") || cbPhanQuyenThuThu.Text.Equals(""))
                    {
                        MessageBox.Show("Bạn cần điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        ThuThu entity = new ThuThu();
                        entity.MaThuThu = txtMaThuThu.Text;
                        entity.HoTen = txtTenThuThu.Text;
                        entity.NgaySinh = dtNgaySinhThuThu.Value;
                        entity.DiaChi = txtDiaChiThuThu.Text;
                        entity.SoDienThoai = txtDienThoaiThuThu.Text;
                        entity.Email = txtEmailThuThu.Text;
                        entity.TaiKhoan = txtTaiKhoanThuThu.Text;
                        entity.MatKhau = txtMatKhauThuThu.Text;
                        if (cbPhanQuyenThuThu.Text.Equals("Nhân viên"))
                            entity.PhanCap = false;
                        else
                            entity.PhanCap = true;
                        client.createLibrarian(entity);
                        MessageBox.Show("Thêm mới thành công!", "Chúc mừng", MessageBoxButtons.OK);
                        resetform();
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
                    if (txtMaThuThu.Text.Equals("") || txtTenThuThu.Text.Equals("") || dtNgaySinhThuThu.Value == null ||
                        txtDiaChiThuThu.Text.Equals("") || txtDienThoaiThuThu.Text.Equals("") || txtEmailThuThu.Text.Equals("")
                        || txtTaiKhoanThuThu.Text.Equals("") || cbPhanQuyenThuThu.Text.Equals(""))
                    {
                        MessageBox.Show("Bạn cần điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        ThuThu entity = new ThuThu();
                        entity.MaThuThu = txtMaThuThu.Text;
                        entity.HoTen = txtTenThuThu.Text;
                        entity.NgaySinh = dtNgaySinhThuThu.Value;
                        entity.DiaChi = txtDiaChiThuThu.Text;
                        entity.SoDienThoai = txtDienThoaiThuThu.Text;
                        entity.Email = txtEmailThuThu.Text;
                        entity.TaiKhoan = txtTaiKhoanThuThu.Text;
                        entity.MatKhau = txtMatKhauThuThu.Text;
                        if (cbPhanQuyenThuThu.Text.Equals("Nhân viên"))
                            entity.PhanCap = false;
                        else
                            entity.PhanCap = true;
                        client.editLibrarian(entity);
                        MessageBox.Show("Sửa thông tin thành công!", "Chúc mừng", MessageBoxButtons.OK);
                        resetform();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa thông tin thất bại", "Lỗi", MessageBoxButtons.OK);
                }
            }
            else
            {
                resetform();
            }
        }

        private void btnXoaThuThu_Click(object sender, EventArgs e)
        {
            try
            {
                client.deleteLibrarian(txtMaThuThu.Text);
                resetform();
                MessageBox.Show("Xóa dữ liệu thành công!", "Chúc mừng", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btnTimKiemThuThu_Click(object sender, EventArgs e)
        {
            if(txtTimKiemThuThu.Text.Equals(""))
            {
                dgvThuThu.DataSource = client.listAllLibrarian();
            }
            else
            {
                dgvThuThu.DataSource = client.searchLibrarian(txtTimKiemThuThu.Text);
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
