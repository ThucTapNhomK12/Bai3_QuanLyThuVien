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
    public partial class frmPhieuMuon : Form
    {
        ServiceLibraryClient client = new ServiceLibraryClient();
        private int ktPhieuMuon = 0;
        private int ktChiTietMuon = 0;
        private int idPhieuMuon = 0;
        private int sumBook = 0;
        private bool checkOverTime = false;
        public frmPhieuMuon()
        {
            InitializeComponent();
        }

        private void resetleftform()
        {
            dtNgayMuon.Enabled = false;
            dtHanTra.Enabled = false;
            dtNgayTra.Enabled = false;
            cbTinhTrang.Enabled = false;
            cbDocGia.Enabled = false;
            cbThuThu.Enabled = false;
            btnThemPhieuMuon.Enabled = true;
            btnSuaPhieuMuon.Enabled = false;
            btnXoaPhieuMuon.Enabled = false;
            btnLuuPhieuMuon.Enabled = false;
            btnHuyPhieuMuon.Enabled = false;
            btnThemChiTietMuon.Enabled = false;
            dtNgayMuon.Text = "";
            dtHanTra.Text = "";
            dtNgayTra.Text = "";
            cbDocGia.DataSource = client.listAllReader();
            cbDocGia.DisplayMember = "HoTen";
            cbDocGia.ValueMember = "MaDocGia";
            cbThuThu.DataSource = client.listAllLibrarian();
            cbThuThu.DisplayMember = "HoTen";
            cbThuThu.ValueMember = "MaThuThu";
            dgvPhieuMuon.DataSource = client.listAllRentCard();
        }

        private void resetrightform()
        {
            txtMaPhieu.Enabled = false;
            cbSach.Enabled = false;
            txtSoLuong.Enabled = false;
            btnThemChiTietMuon.Enabled = true;
            btnXoaChiTietMuon.Enabled = false;
            btnSuaChiTietMuon.Enabled = false;
            btnHuyChiTietMuon.Enabled = false;
            btnLuuChiTietMuon.Enabled = false;
            txtSoLuong.Text = "";
            cbSach.DataSource = client.listAllBook();
            cbSach.DisplayMember = "TieuDeSach";
            cbSach.ValueMember = "MaSach";
            lblTongSoSach.Text = "Tổng số sách mượn: " + sumBook.ToString();
        }

        private void frmPhieuMuon_Load(object sender, EventArgs e)
        {
            resetrightform();
            resetleftform();
            cbTinhTrang.Items.Add("Đã trả");
            cbTinhTrang.Items.Add("Chưa trả");
        }

        private void btnThemPhieuMuon_Click(object sender, EventArgs e)
        {
            resetleftform();
            dtNgayMuon.Enabled = true;
            dtHanTra.Enabled = true;
            dtNgayTra.Enabled = true;
            cbTinhTrang.Enabled = true;
            cbDocGia.Enabled = true;
            cbThuThu.Enabled = true;
            btnHuyPhieuMuon.Enabled = true;
            btnLuuPhieuMuon.Enabled = true;
            ktPhieuMuon = 1;
        }

        private void btnHuyPhieuMuon_Click(object sender, EventArgs e)
        {
            resetleftform();
        }

        private void btnSuaPhieuMuon_Click(object sender, EventArgs e)
        {
            dtNgayTra.Enabled = true;
            dtHanTra.Enabled = true;
            cbTinhTrang.Enabled = true;
            btnHuyPhieuMuon.Enabled = true;
            btnLuuPhieuMuon.Enabled = true;
            ktPhieuMuon = 2;
        }

        private void dgvPhieuMuon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if(checkOverTime == false)
                {
                    resetleftform();
                }
                idPhieuMuon = int.Parse(dgvPhieuMuon.Rows[e.RowIndex].Cells[3].Value.ToString());
                dtNgayMuon.Text = dgvPhieuMuon.Rows[e.RowIndex].Cells[5].Value.ToString();
                dtHanTra.Text = dgvPhieuMuon.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtNgayTra.Text = dgvPhieuMuon.Rows[e.RowIndex].Cells[6].Value.ToString();
                if (dgvPhieuMuon.Rows[e.RowIndex].Cells[8].Value.ToString().Equals("True"))
                    cbTinhTrang.Text = "Đã trả";
                else
                    cbTinhTrang.Text = "Chưa trả";
                cbDocGia.SelectedValue = dgvPhieuMuon.Rows[e.RowIndex].Cells[2].Value;
                cbThuThu.SelectedValue = dgvPhieuMuon.Rows[e.RowIndex].Cells[4].Value;
                btnSuaPhieuMuon.Enabled = true;
                btnLuuPhieuMuon.Enabled = true;
                btnHuyPhieuMuon.Enabled = true;
                btnXoaPhieuMuon.Enabled = true;
                dgvChiTietMuon.DataSource = client.listAllRentDetail(idPhieuMuon);
                txtMaPhieu.Text = idPhieuMuon.ToString();
                btnThemChiTietMuon.Enabled = true;
                resetrightform();
                sumBook = client.countQuantityBookBorrowed(idPhieuMuon);
            }
            catch (Exception)
            {
                MessageBox.Show("Click chuột sai vị trí", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btnXoaPhieuMuon_Click(object sender, EventArgs e)
        {
            try
            {
                client.deleteRentCard(idPhieuMuon);
                resetleftform();
                MessageBox.Show("Xóa dữ liệu thành công!", "Chúc mừng", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btnLuuPhieuMuon_Click(object sender, EventArgs e)
        {
            if (ktPhieuMuon == 1)
            {
                try
                {
                    if (dtNgayMuon.Text.Equals("") || dtHanTra.Text.Equals(""))
                    {
                        MessageBox.Show("Bạn cần điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        PhieuMuon entity = new PhieuMuon();
                        entity.NgayMuon = dtNgayMuon.Value;
                        entity.HanTra = dtHanTra.Value;
                        entity.NgayTra = dtNgayTra.Value;
                        if (cbTinhTrang.Text.Equals("Đã trả"))
                            entity.TinhTrangTra = true;
                        else
                            entity.TinhTrangTra = false;
                        entity.MaDocGia = int.Parse(cbDocGia.SelectedValue.ToString());
                        entity.MaThuThu = cbThuThu.SelectedValue.ToString();
                        client.createRentCard(entity);
                        MessageBox.Show("Thêm mới thành công!", "Chúc mừng", MessageBoxButtons.OK);
                        resetleftform();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm mới thất bại", "Lỗi", MessageBoxButtons.OK);
                }
            }
            if (ktPhieuMuon == 2)
            {
                try
                {
                    if (dtNgayMuon.Text.Equals("") || dtHanTra.Text.Equals(""))
                    {
                        MessageBox.Show("Bạn cần điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        PhieuMuon entity = new PhieuMuon();
                        entity.MaPhieuMuon = idPhieuMuon;
                        entity.NgayMuon = dtNgayMuon.Value;
                        entity.HanTra = dtHanTra.Value;
                        entity.NgayTra = dtNgayTra.Value;
                        if (cbTinhTrang.Text.Equals("Đã trả"))
                            entity.TinhTrangTra = true;
                        else
                            entity.TinhTrangTra = false;
                        entity.MaDocGia = int.Parse(cbDocGia.SelectedValue.ToString());
                        entity.MaThuThu = cbThuThu.SelectedValue.ToString();
                        client.editRentCard(entity);
                        MessageBox.Show("Sửa thông tin thành công!", "Chúc mừng", MessageBoxButtons.OK);
                        resetleftform();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa thông tin thất bại", "Lỗi", MessageBoxButtons.OK);
                }
            }
            else
            {
                resetleftform();
            }
        }

        private void btnThemChiTietMuon_Click(object sender, EventArgs e)
        {
            resetrightform();
            cbSach.Enabled = true;
            txtSoLuong.Enabled = true;
            btnHuyChiTietMuon.Enabled = true;
            btnLuuChiTietMuon.Enabled = true;
            ktChiTietMuon = 1;
        }

        private void btnHuyChiTietMuon_Click(object sender, EventArgs e)
        {
            resetrightform();
        }

        private void btnSuaChiTietMuon_Click(object sender, EventArgs e)
        {
            txtSoLuong.Enabled = true;
            btnHuyChiTietMuon.Enabled = true;
            btnLuuChiTietMuon.Enabled = true;
            ktChiTietMuon = 2;
        }

        private void btnXoaChiTietMuon_Click(object sender, EventArgs e)
        {
            try
            {
                client.deleteRentDetail(idPhieuMuon, int.Parse(cbSach.SelectedValue.ToString()));
                resetrightform();
                MessageBox.Show("Xóa dữ liệu thành công!", "Chúc mừng", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btnLuuChiTietMuon_Click(object sender, EventArgs e)
        {
            if (ktChiTietMuon == 1)
            {
                try
                {
                    if (txtSoLuong.Text.Equals(""))
                    {
                        MessageBox.Show("Bạn cần điền số lượng!", "Cảnh báo", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        ChiTietMuon entity = new ChiTietMuon();
                        entity.MaPhieuMuon = idPhieuMuon;
                        entity.MaSach = int.Parse(cbSach.SelectedValue.ToString());
                        entity.SoLuong = int.Parse(txtSoLuong.Text);
                        string mess = client.createRentDetail(entity);
                        MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK);
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm mới thất bại", "Lỗi", MessageBoxButtons.OK);
                }
            }
            if (ktChiTietMuon == 2)
            {
                try
                {
                    if (txtSoLuong.Text.Equals(""))
                    {
                        MessageBox.Show("Bạn cần điền số lượng!", "Cảnh báo", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        ChiTietMuon entity = new ChiTietMuon();
                        entity.MaPhieuMuon = idPhieuMuon;
                        entity.MaSach = int.Parse(cbSach.SelectedValue.ToString());
                        entity.SoLuong = int.Parse(txtSoLuong.Text);
                        client.editRentDetail(entity);
                        MessageBox.Show("Sửa thông tin thành công!", "Chúc mừng", MessageBoxButtons.OK);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa thông tin thất bại", "Lỗi", MessageBoxButtons.OK);
                }
            }
            resetrightform();
            dgvChiTietMuon.DataSource = client.listAllRentDetail(idPhieuMuon);
        }

        private void dgvChiTietMuon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                resetrightform();
                cbSach.SelectedValue = dgvChiTietMuon.Rows[e.RowIndex].Cells[1].Value;
                txtSoLuong.Text = dgvChiTietMuon.Rows[e.RowIndex].Cells[4].Value.ToString();
                btnSuaChiTietMuon.Enabled = true;
                btnHuyChiTietMuon.Enabled = true;
                btnXoaChiTietMuon.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Click chuột sai vị trí", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btnViewOverTime_Click(object sender, EventArgs e)
        {
            dgvPhieuMuon.DataSource = client.listRentOverTime();
            checkOverTime = true;
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
