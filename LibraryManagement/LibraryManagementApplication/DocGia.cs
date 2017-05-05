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
    public partial class frmDocGia : Form
    {
        ServiceLibraryClient client = new ServiceLibraryClient();
        private int id = 0;
        private int check = 0;
        public frmDocGia()
        {
            InitializeComponent();
        }

        private void resetform()
        {
            txtTenDocGia.Enabled = false;
            dtNgaySinhDocGia.Enabled = false;
            txtDiaChiDocGia.Enabled = false;
            txtDienThoaiDocGia.Enabled = false;
            txtEmailDocGia.Enabled = false;
            cbKhoaDocGia.Enabled = false;
            cbTheDocGia.Enabled = false;
            btnThemDocGia.Enabled = true;
            btnSuaDocGia.Enabled = false;
            btnXoaDocGia.Enabled = false;
            btnHuyDocGia.Enabled = false;
            btnLuuDocGia.Enabled = false;
            txtTenDocGia.Text = "";
            dtNgaySinhDocGia.Text = "";
            txtDiaChiDocGia.Text = "";
            txtDienThoaiDocGia.Text = "";
            txtEmailDocGia.Text = "";
            cbKhoaDocGia.Text = "";
            cbTheDocGia.Text = "";
            cbKhoaDocGia.DataSource = client.listAllTrade();
            cbKhoaDocGia.DisplayMember = "TenKhoa";
            cbKhoaDocGia.ValueMember = "MaKhoa";
            cbTheDocGia.DataSource = client.listAllCardType();
            cbTheDocGia.DisplayMember = "TenLoaiThe";
            cbTheDocGia.ValueMember = "MaLoaiThe";
            dgvDocGia.DataSource = client.listAllReader();
        }

        private void frmDocGia_Load(object sender, EventArgs e)
        {
            resetform();
        }

        private void btnThemDocGia_Click(object sender, EventArgs e)
        {
            resetform();
            txtTenDocGia.Enabled = true;
            dtNgaySinhDocGia.Enabled = true;
            txtDiaChiDocGia.Enabled = true;
            txtDienThoaiDocGia.Enabled = true;
            txtEmailDocGia.Enabled = true;
            cbKhoaDocGia.Enabled = true;
            cbTheDocGia.Enabled = true;
            btnHuyDocGia.Enabled = true;
            btnLuuDocGia.Enabled = true;
            check = 1;
        }

        private void btnHuyDocGia_Click(object sender, EventArgs e)
        {
            resetform();
        }

        private void btnSuaDocGia_Click(object sender, EventArgs e)
        {
            txtTenDocGia.Enabled = true;
            dtNgaySinhDocGia.Enabled = true;
            txtDiaChiDocGia.Enabled = true;
            txtDienThoaiDocGia.Enabled = true;
            txtEmailDocGia.Enabled = true;
            cbKhoaDocGia.Enabled = true;
            cbTheDocGia.Enabled = true;
            btnHuyDocGia.Enabled = true;
            btnLuuDocGia.Enabled = true;
            check = 2;
        }

        private void btnLuuDocGia_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                try
                {
                    if (txtTenDocGia.Text.Equals("") || txtDiaChiDocGia.Text.Equals("") || dtNgaySinhDocGia.Value == null ||
                        txtDienThoaiDocGia.Text.Equals("") || txtEmailDocGia.Text.Equals(""))
                    {
                        MessageBox.Show("Bạn cần điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        DocGia entity = new DocGia();
                        entity.HoTen = txtTenDocGia.Text;
                        entity.NgaySinh = dtNgaySinhDocGia.Value;
                        entity.DiaChi = txtDiaChiDocGia.Text;
                        entity.SoDienThoai = txtDienThoaiDocGia.Text;
                        entity.Email = txtEmailDocGia.Text;
                        entity.MaKhoa = int.Parse(cbKhoaDocGia.SelectedValue.ToString());
                        entity.MaLoaiThe = int.Parse(cbTheDocGia.SelectedValue.ToString());
                        client.createReader(entity);
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
                    if (txtTenDocGia.Text.Equals("") || txtDiaChiDocGia.Text.Equals("") || dtNgaySinhDocGia.Value == null ||
                        txtDienThoaiDocGia.Text.Equals("") || txtEmailDocGia.Text.Equals(""))
                    {
                        MessageBox.Show("Bạn cần điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        DocGia entity = new DocGia();
                        entity.MaDocGia = id;
                        entity.HoTen = txtTenDocGia.Text;
                        entity.NgaySinh = dtNgaySinhDocGia.Value;
                        entity.DiaChi = txtDiaChiDocGia.Text;
                        entity.SoDienThoai = txtDienThoaiDocGia.Text;
                        entity.Email = txtEmailDocGia.Text;
                        entity.MaKhoa = int.Parse(cbKhoaDocGia.SelectedValue.ToString());
                        entity.MaLoaiThe = int.Parse(cbTheDocGia.SelectedValue.ToString());
                        client.editReader(entity);
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

        private void dgvDocGia_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id = int.Parse(dgvDocGia.Rows[e.RowIndex].Cells[5].Value.ToString());
                txtTenDocGia.Text = dgvDocGia.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtNgaySinhDocGia.Text = dgvDocGia.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtDiaChiDocGia.Text = dgvDocGia.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtDienThoaiDocGia.Text = dgvDocGia.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtEmailDocGia.Text = dgvDocGia.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbKhoaDocGia.SelectedValue = dgvDocGia.Rows[e.RowIndex].Cells[6].Value;
                cbTheDocGia.SelectedValue = dgvDocGia.Rows[e.RowIndex].Cells[7].Value;
                btnSuaDocGia.Enabled = true;
                btnXoaDocGia.Enabled = true;
                btnHuyDocGia.Enabled = true;
                btnLuuDocGia.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Click chuột sai vị trí", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btnXoaDocGia_Click(object sender, EventArgs e)
        {
            try
            {
                client.deleteReader(id);
                resetform();
                MessageBox.Show("Xóa dữ liệu thành công!", "Chúc mừng", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btnTimKiemDocGia_Click(object sender, EventArgs e)
        {
            if (txtTimKiemDocGia.Text.Equals(""))
            {
                dgvDocGia.DataSource = client.listAllReader();
            }
            else
            {
                dgvDocGia.DataSource = client.searchReader(txtTimKiemDocGia.Text);
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
