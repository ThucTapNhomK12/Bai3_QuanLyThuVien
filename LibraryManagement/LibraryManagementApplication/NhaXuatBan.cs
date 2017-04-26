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
    public partial class frmNXB : Form
    {
        ServiceLibraryClient client = new ServiceLibraryClient();
        private int id = 0;
        public frmNXB()
        {
            InitializeComponent();
        }
        private void resetform()
        {
            txtTenNXB.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSoDT.Enabled = false;
            btnThemNXB.Enabled = true;
            btnHuyNXB.Enabled = false;
            btnLuuNXB.Enabled = false;
            btnXoaNXB.Enabled = false;
            txtTenNXB.Text = "";
            txtDiaChi.Text = "";
            txtSoDT.Text = "";
            dgvNXB.DataSource = client.listAllPublisher(); 
        }
        private void frmNXB_Load(object sender, EventArgs e)
        {
            resetform();
        }

        private void dgvNXB_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id = int.Parse(dgvNXB.Rows[e.RowIndex].Cells[1].Value.ToString());
                txtTenNXB.Text = dgvNXB.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDiaChi.Text = dgvNXB.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtSoDT.Text = dgvNXB.Rows[e.RowIndex].Cells[2].Value.ToString();
                btnXoaNXB.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Click chuột sai vị trí", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            resetform();
            txtTenNXB.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSoDT.Enabled = true;
            btnHuyNXB.Enabled = true;
            btnLuuNXB.Enabled = true;
            btnXoaNXB.Enabled = false;
        }

        private void btnHuyNXB_Click(object sender, EventArgs e)
        {
            resetform();
        }

        private void btnLuuNXB_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenNXB.Text.Equals(""))
                {
                    MessageBox.Show("Bạn cần điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK);
                }
                else
                {
                    NhaXuatBan entity = new NhaXuatBan();
                    entity.TenNXB = txtTenNXB.Text;
                    entity.DiaChi = txtDiaChi.Text;
                    entity.SoDienThoai = txtSoDT.Text;
                    client.createPublisher(entity);
                    MessageBox.Show("Thêm mới thành công!", "Chúc mừng", MessageBoxButtons.OK);
                    resetform();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm mới thất bại", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btnXoaNXB_Click(object sender, EventArgs e)
        {
            try
            {
                if (id != 0)
                {
                    client.deletePublisher(id);
                    resetform();
                    MessageBox.Show("Xóa dữ liệu thành công!", "Chúc mừng", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK);
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
