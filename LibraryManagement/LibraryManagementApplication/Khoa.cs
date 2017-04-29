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
    public partial class frmKhoa : Form
    {
        ServiceLibrary.ServiceLibraryClient client = new ServiceLibrary.ServiceLibraryClient();
        private int id = 0;
        public frmKhoa()
        {
            InitializeComponent();
        }

        private void resetform()
        {
            txtTenKhoa.Enabled = false;
            txtThongTin.Enabled = false;
            btnThemKhoa.Enabled = true;
            btnHuyKhoa.Enabled = false;
            btnLuuKhoa.Enabled = false;
            txtTenKhoa.Text = "";
            txtThongTin.Text = "";
            dgvKhoa.DataSource = client.listAllTrade();
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            resetform();
        }

        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            resetform();
            txtTenKhoa.Enabled = true;
            txtThongTin.Enabled = true;
            btnHuyKhoa.Enabled = true;
            btnLuuKhoa.Enabled = true;
            btnXoaKhoa.Enabled = false;
        }

        private void btnHuyKhoa_Click(object sender, EventArgs e)
        {
            resetform();
        }

        private void btnLuuKhoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenKhoa.Text.Equals(""))
                {
                    MessageBox.Show("Bạn cần điền tên khoa!", "Cảnh báo", MessageBoxButtons.OK);
                }
                else
                {
                    Khoa entity = new Khoa();
                    entity.TenKhoa = txtTenKhoa.Text;
                    entity.ThongTin = txtThongTin.Text;
                    client.createTrade(entity);
                    MessageBox.Show("Thêm mới thành công!", "Chúc mừng", MessageBoxButtons.OK);
                    resetform();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm mới thất bại", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void dgvKhoa_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id = int.Parse(dgvKhoa.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtTenKhoa.Text = dgvKhoa.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtThongTin.Text = dgvKhoa.Rows[e.RowIndex].Cells[2].Value.ToString();
                btnXoaKhoa.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Click chuột sai vị trí", "Lỗi", MessageBoxButtons.OK);
            }
            
        }

        private void btnXoaKhoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (id != 0)
                {
                    client.deleteTrade(id);
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
