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
    public partial class frmTheLoai : Form
    {
        ServiceLibraryClient client = new ServiceLibraryClient();
        private int id = 0;
        public frmTheLoai()
        {
            InitializeComponent();
        }

        private void resetform()
        {
            txtTheLoai.Enabled = false;
            btnThemTheLoai.Enabled = true;
            btnHuyTheLoai.Enabled = false;
            btnLuuTheLoai.Enabled = false;
            btnXoaTheLoai.Enabled = false;
            txtTheLoai.Text = "";
            dgvTheLoai.DataSource = client.listAllCategory();
        }

        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            resetform();
        }

        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            resetform();
            txtTheLoai.Enabled = true;
            btnHuyTheLoai.Enabled = true;
            btnLuuTheLoai.Enabled = true;
            btnXoaTheLoai.Enabled = false;
        }

        private void btnHuyTheLoai_Click(object sender, EventArgs e)
        {
            resetform();
        }

        private void btnXoaTheLoai_Click(object sender, EventArgs e)
        {
            try
            {
                if (id != 0)
                {
                    client.deleteCategory(id);
                    resetform();
                    MessageBox.Show("Xóa dữ liệu thành công!", "Chúc mừng", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btnLuuTheLoai_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTheLoai.Text.Equals(""))
                {
                    MessageBox.Show("Bạn cần điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK);
                }
                else
                {
                    DanhMucSach entity = new DanhMucSach();
                    entity.TenDanhMuc = txtTheLoai.Text;
                    client.createCategory(entity);
                    MessageBox.Show("Thêm mới thành công!", "Chúc mừng", MessageBoxButtons.OK);
                    resetform();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm mới thất bại", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void dgvTheLoai_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id = int.Parse(dgvTheLoai.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtTheLoai.Text = dgvTheLoai.Rows[e.RowIndex].Cells[1].Value.ToString();
                btnXoaTheLoai.Enabled = true;
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
