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
    public partial class frmTacGia : Form
    {
        ServiceLibraryClient client = new ServiceLibraryClient();
        private int id = 0;
        private int bookId = 0;
        private int authorId = 0;
        public frmTacGia()
        {
            InitializeComponent();
        }

        private void resetform()
        {
            txtHoTen.Enabled = false;
            txtVaiTro.Enabled = false;
            cbSach.Enabled = false;
            cbTacGia.Enabled = false;
            btnThemTacGia.Enabled = true;
            btnHuyTacGia.Enabled = false;
            btnLuuTacGia.Enabled = false;
            btnXoaTacGia.Enabled = false;
            btnThemThamGia.Enabled = true;
            btnHuyThamGia.Enabled = false;
            btnLuuThamGia.Enabled = false;
            btnXoaThamGia.Enabled = false;
            txtHoTen.Text = "";
            txtVaiTro.Text = "";
            cbSach.DataSource = client.listAllBook();
            cbSach.DisplayMember = "TieuDeSach";
            cbSach.ValueMember = "MaSach";
            cbTacGia.DataSource = client.listAllAuthor();
            cbTacGia.DisplayMember = "HoTen";
            cbTacGia.ValueMember = "MaTacGia";
            dgvTacGia.DataSource = client.listAllAuthor();
            dgvThamGia.DataSource = client.listAllAttend();
        }
        private void frmTacGia_Load(object sender, EventArgs e)
        {
            resetform();
        }

        private void btnThemTacGia_Click(object sender, EventArgs e)
        {
            resetform();
            txtHoTen.Enabled = true;
            btnHuyTacGia.Enabled = true;
            btnLuuTacGia.Enabled = true;
        }

        private void btnHuyTacGia_Click(object sender, EventArgs e)
        {
            resetform();
        }

        private void btnXoaTacGia_Click(object sender, EventArgs e)
        {
            try
            {
                if (id != 0)
                {
                    client.deleteAuthor(id);
                    resetform();
                    MessageBox.Show("Xóa dữ liệu thành công!", "Chúc mừng", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btnLuuTacGia_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHoTen.Text.Equals(""))
                {
                    MessageBox.Show("Bạn cần điền tên tác giả!", "Cảnh báo", MessageBoxButtons.OK);
                }
                else
                {
                    TacGia entity = new TacGia();
                    entity.HoTen = txtHoTen.Text;
                    client.createAuthor(entity);
                    MessageBox.Show("Thêm mới thành công!", "Chúc mừng", MessageBoxButtons.OK);
                    resetform();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm mới thất bại", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void dgvTacGia_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id = int.Parse(dgvTacGia.Rows[e.RowIndex].Cells[1].Value.ToString());
                txtHoTen.Text = dgvTacGia.Rows[e.RowIndex].Cells[0].Value.ToString();
                btnXoaTacGia.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Click chuột sai vị trí", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btnThemThamGia_Click(object sender, EventArgs e)
        {
            resetform();
            cbSach.Enabled = true;
            cbTacGia.Enabled = true;
            txtVaiTro.Enabled = true;
            btnHuyThamGia.Enabled = true;
            btnLuuThamGia.Enabled = true;
        }

        private void btnHuyThamGia_Click(object sender, EventArgs e)
        {
            resetform();
        }

        private void btnXoaThamGia_Click(object sender, EventArgs e)
        {
            try
            {
                if (bookId != 0 && authorId != 0)
                {
                    client.deleteAttend(bookId, authorId);
                    resetform();
                    MessageBox.Show("Xóa dữ liệu thành công!", "Chúc mừng", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btnLuuThamGia_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtVaiTro.Text.Equals(""))
                {
                    MessageBox.Show("Bạn cần điền vai trò của tác giả!", "Cảnh báo", MessageBoxButtons.OK);
                }
                else
                {
                    ThamGia entity = new ThamGia();
                    entity.MaSach = int.Parse(cbSach.SelectedValue.ToString());
                    entity.MaTacGia = int.Parse(cbTacGia.SelectedValue.ToString());
                    entity.VaiTro = txtVaiTro.Text;
                    client.createAttend(entity);
                    MessageBox.Show("Thêm mới thành công!", "Chúc mừng", MessageBoxButtons.OK);
                    resetform();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm mới thất bại", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void dgvThamGia_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                bookId = int.Parse(dgvThamGia.Rows[e.RowIndex].Cells[0].Value.ToString());
                authorId = int.Parse(dgvThamGia.Rows[e.RowIndex].Cells[1].Value.ToString());
                cbSach.SelectedValue = bookId;
                cbTacGia.SelectedValue = authorId;
                txtVaiTro.Text = dgvThamGia.Rows[e.RowIndex].Cells[4].Value.ToString();
                btnXoaThamGia.Enabled = true;
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
