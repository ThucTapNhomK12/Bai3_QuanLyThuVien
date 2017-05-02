using LibraryManagementApplication.ServiceLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementApplication
{
    public partial class frmCardType : Form
    {
        ServiceLibrary.ServiceLibraryClient client = new ServiceLibrary.ServiceLibraryClient();
        private int id = 0;
        public frmCardType()
        {
            InitializeComponent();
        }
        private void resetform()
        {
            txtTenThe.Enabled = false;
            txtSoSach.Enabled = false;
            btnThemTheThuVien.Enabled = true;
            btnHuyTheThuVien.Enabled = false;
            btnLuuTheThuVien.Enabled = false;
            btnXoaTheThuVien.Enabled = false;
            txtTenThe.Text = "";
            txtSoSach.Text = "";
            dgvTheThuVien.DataSource = client.listAllCardType();
        }
        private void frmCardType_Load(object sender, EventArgs e)
        {
            resetform();
        }

        private void btnThemTheThuVien_Click(object sender, EventArgs e)
        {
            resetform();
            txtTenThe.Enabled = true;
            txtSoSach.Enabled = true;
            btnHuyTheThuVien.Enabled = true;
            btnLuuTheThuVien.Enabled = true;
            btnXoaTheThuVien.Enabled = false;
        }

        private void btnXoaTheThuVien_Click(object sender, EventArgs e)
        {
            try
            {
                if (id != 0)
                {
                    client.deleteCardType(id);
                    resetform();
                    MessageBox.Show("Xóa dữ liệu thành công!", "Chúc mừng", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btnHuyTheThuVien_Click(object sender, EventArgs e)
        {
            resetform();
        }

        private void btnLuuTheThuVien_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenThe.Text.Equals("") && txtSoSach.Text.Equals(""))
                {
                    MessageBox.Show("Bạn cần điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK);
                }
                else
                {
                    LoaiTheThuVien entity = new LoaiTheThuVien();
                    entity.TenLoaiThe = txtTenThe.Text;
                    entity.SoSachToiDa = txtSoSach.Value;
                    client.createCardType(entity);
                    MessageBox.Show("Thêm mới thành công!", "Chúc mừng", MessageBoxButtons.OK);
                    resetform();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm mới thất bại", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void dgvTheThuVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id = int.Parse(dgvTheThuVien.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtTenThe.Text = dgvTheThuVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSoSach.Value = Convert.ToInt32(dgvTheThuVien.Rows[e.RowIndex].Cells[1].Value);
                btnXoaTheThuVien.Enabled = true;
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
