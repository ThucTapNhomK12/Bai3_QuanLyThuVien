namespace LibraryManagementApplication
{
    partial class frmNXB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaoDiệnChínhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thẻThưViệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.độcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàXuấtBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thểLoạiSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thủThưToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new DevComponents.DotNetBar.LabelX();
            this.gpThongTinTacGia = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtSoDT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDiaChi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblSoDTNXB = new DevComponents.DotNetBar.LabelX();
            this.lblDiaChiNXB = new DevComponents.DotNetBar.LabelX();
            this.btnLuuNXB = new DevComponents.DotNetBar.ButtonX();
            this.btnHuyNXB = new DevComponents.DotNetBar.ButtonX();
            this.btnXoaNXB = new DevComponents.DotNetBar.ButtonX();
            this.btnThemNXB = new DevComponents.DotNetBar.ButtonX();
            this.lblTenNXB = new DevComponents.DotNetBar.LabelX();
            this.txtTenNXB = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.gpDanhSach = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvNXB = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip.SuspendLayout();
            this.gpThongTinTacGia.SuspendLayout();
            this.gpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.khoaToolStripMenuItem,
            this.thẻThưViệnToolStripMenuItem,
            this.độcGiảToolStripMenuItem,
            this.sáchToolStripMenuItem,
            this.thủThưToolStripMenuItem,
            this.phiếuMượnToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(610, 29);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giaoDiệnChínhToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // giaoDiệnChínhToolStripMenuItem
            // 
            this.giaoDiệnChínhToolStripMenuItem.Name = "giaoDiệnChínhToolStripMenuItem";
            this.giaoDiệnChínhToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.giaoDiệnChínhToolStripMenuItem.Text = "Giao diện chính";
            this.giaoDiệnChínhToolStripMenuItem.Click += new System.EventHandler(this.giaoDiệnChínhToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // khoaToolStripMenuItem
            // 
            this.khoaToolStripMenuItem.Name = "khoaToolStripMenuItem";
            this.khoaToolStripMenuItem.Size = new System.Drawing.Size(57, 25);
            this.khoaToolStripMenuItem.Text = "Khoa";
            this.khoaToolStripMenuItem.Click += new System.EventHandler(this.khoaToolStripMenuItem_Click);
            // 
            // thẻThưViệnToolStripMenuItem
            // 
            this.thẻThưViệnToolStripMenuItem.Name = "thẻThưViệnToolStripMenuItem";
            this.thẻThưViệnToolStripMenuItem.Size = new System.Drawing.Size(107, 25);
            this.thẻThưViệnToolStripMenuItem.Text = "Thẻ thư viện";
            this.thẻThưViệnToolStripMenuItem.Click += new System.EventHandler(this.thẻThưViệnToolStripMenuItem_Click);
            // 
            // độcGiảToolStripMenuItem
            // 
            this.độcGiảToolStripMenuItem.Name = "độcGiảToolStripMenuItem";
            this.độcGiảToolStripMenuItem.Size = new System.Drawing.Size(74, 25);
            this.độcGiảToolStripMenuItem.Text = "Độc giả";
            this.độcGiảToolStripMenuItem.Click += new System.EventHandler(this.độcGiảToolStripMenuItem_Click);
            // 
            // sáchToolStripMenuItem
            // 
            this.sáchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tácGiảToolStripMenuItem,
            this.nhàXuấtBảnToolStripMenuItem,
            this.thểLoạiSáchToolStripMenuItem,
            this.quảnLýSáchToolStripMenuItem});
            this.sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            this.sáchToolStripMenuItem.Size = new System.Drawing.Size(55, 25);
            this.sáchToolStripMenuItem.Text = "Sách";
            // 
            // tácGiảToolStripMenuItem
            // 
            this.tácGiảToolStripMenuItem.Name = "tácGiảToolStripMenuItem";
            this.tácGiảToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.tácGiảToolStripMenuItem.Text = "Tác giả";
            this.tácGiảToolStripMenuItem.Click += new System.EventHandler(this.tácGiảToolStripMenuItem_Click);
            // 
            // nhàXuấtBảnToolStripMenuItem
            // 
            this.nhàXuấtBảnToolStripMenuItem.Name = "nhàXuấtBảnToolStripMenuItem";
            this.nhàXuấtBảnToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.nhàXuấtBảnToolStripMenuItem.Text = "Nhà xuất bản";
            this.nhàXuấtBảnToolStripMenuItem.Click += new System.EventHandler(this.nhàXuấtBảnToolStripMenuItem_Click);
            // 
            // thểLoạiSáchToolStripMenuItem
            // 
            this.thểLoạiSáchToolStripMenuItem.Name = "thểLoạiSáchToolStripMenuItem";
            this.thểLoạiSáchToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.thểLoạiSáchToolStripMenuItem.Text = "Thể loại sách";
            this.thểLoạiSáchToolStripMenuItem.Click += new System.EventHandler(this.thểLoạiSáchToolStripMenuItem_Click);
            // 
            // quảnLýSáchToolStripMenuItem
            // 
            this.quảnLýSáchToolStripMenuItem.Name = "quảnLýSáchToolStripMenuItem";
            this.quảnLýSáchToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.quảnLýSáchToolStripMenuItem.Text = "Quản lý sách";
            this.quảnLýSáchToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSáchToolStripMenuItem_Click);
            // 
            // thủThưToolStripMenuItem
            // 
            this.thủThưToolStripMenuItem.Name = "thủThưToolStripMenuItem";
            this.thủThưToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.thủThưToolStripMenuItem.Text = "Thủ thư";
            this.thủThưToolStripMenuItem.Click += new System.EventHandler(this.thủThưToolStripMenuItem_Click);
            // 
            // phiếuMượnToolStripMenuItem
            // 
            this.phiếuMượnToolStripMenuItem.Name = "phiếuMượnToolStripMenuItem";
            this.phiếuMượnToolStripMenuItem.Size = new System.Drawing.Size(107, 25);
            this.phiếuMượnToolStripMenuItem.Text = "Phiếu mượn";
            this.phiếuMượnToolStripMenuItem.Click += new System.EventHandler(this.phiếuMượnToolStripMenuItem_Click);
            // 
            // lblTitle
            // 
            // 
            // 
            // 
            this.lblTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(107, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(408, 39);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Quản lý nhà xuất bản";
            this.lblTitle.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // gpThongTinTacGia
            // 
            this.gpThongTinTacGia.BackColor = System.Drawing.Color.Transparent;
            this.gpThongTinTacGia.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpThongTinTacGia.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpThongTinTacGia.Controls.Add(this.txtSoDT);
            this.gpThongTinTacGia.Controls.Add(this.txtDiaChi);
            this.gpThongTinTacGia.Controls.Add(this.lblSoDTNXB);
            this.gpThongTinTacGia.Controls.Add(this.lblDiaChiNXB);
            this.gpThongTinTacGia.Controls.Add(this.btnLuuNXB);
            this.gpThongTinTacGia.Controls.Add(this.btnHuyNXB);
            this.gpThongTinTacGia.Controls.Add(this.btnXoaNXB);
            this.gpThongTinTacGia.Controls.Add(this.btnThemNXB);
            this.gpThongTinTacGia.Controls.Add(this.lblTenNXB);
            this.gpThongTinTacGia.Controls.Add(this.txtTenNXB);
            this.gpThongTinTacGia.DisabledBackColor = System.Drawing.Color.Empty;
            this.gpThongTinTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpThongTinTacGia.Location = new System.Drawing.Point(23, 87);
            this.gpThongTinTacGia.Name = "gpThongTinTacGia";
            this.gpThongTinTacGia.Size = new System.Drawing.Size(562, 176);
            // 
            // 
            // 
            this.gpThongTinTacGia.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpThongTinTacGia.Style.BackColorGradientAngle = 90;
            this.gpThongTinTacGia.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpThongTinTacGia.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpThongTinTacGia.Style.BorderBottomWidth = 1;
            this.gpThongTinTacGia.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpThongTinTacGia.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpThongTinTacGia.Style.BorderLeftWidth = 1;
            this.gpThongTinTacGia.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpThongTinTacGia.Style.BorderRightWidth = 1;
            this.gpThongTinTacGia.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpThongTinTacGia.Style.BorderTopWidth = 1;
            this.gpThongTinTacGia.Style.CornerDiameter = 4;
            this.gpThongTinTacGia.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpThongTinTacGia.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpThongTinTacGia.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpThongTinTacGia.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpThongTinTacGia.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpThongTinTacGia.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpThongTinTacGia.TabIndex = 11;
            this.gpThongTinTacGia.Text = "Thông tin nhà xuất bản";
            // 
            // txtSoDT
            // 
            this.txtSoDT.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSoDT.Border.Class = "TextBoxBorder";
            this.txtSoDT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSoDT.DisabledBackColor = System.Drawing.Color.White;
            this.txtSoDT.ForeColor = System.Drawing.Color.Black;
            this.txtSoDT.Location = new System.Drawing.Point(124, 111);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.PreventEnterBeep = true;
            this.txtSoDT.Size = new System.Drawing.Size(173, 26);
            this.txtSoDT.TabIndex = 3;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDiaChi.Border.Class = "TextBoxBorder";
            this.txtDiaChi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDiaChi.DisabledBackColor = System.Drawing.Color.White;
            this.txtDiaChi.ForeColor = System.Drawing.Color.Black;
            this.txtDiaChi.Location = new System.Drawing.Point(124, 63);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PreventEnterBeep = true;
            this.txtDiaChi.Size = new System.Drawing.Size(173, 26);
            this.txtDiaChi.TabIndex = 2;
            // 
            // lblSoDTNXB
            // 
            this.lblSoDTNXB.AntiAlias = false;
            this.lblSoDTNXB.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblSoDTNXB.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSoDTNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDTNXB.Location = new System.Drawing.Point(21, 111);
            this.lblSoDTNXB.Name = "lblSoDTNXB";
            this.lblSoDTNXB.Size = new System.Drawing.Size(97, 26);
            this.lblSoDTNXB.TabIndex = 14;
            this.lblSoDTNXB.Text = "Số điện thoại";
            // 
            // lblDiaChiNXB
            // 
            this.lblDiaChiNXB.AntiAlias = false;
            this.lblDiaChiNXB.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblDiaChiNXB.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDiaChiNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChiNXB.Location = new System.Drawing.Point(21, 63);
            this.lblDiaChiNXB.Name = "lblDiaChiNXB";
            this.lblDiaChiNXB.Size = new System.Drawing.Size(97, 26);
            this.lblDiaChiNXB.TabIndex = 13;
            this.lblDiaChiNXB.Text = "Địa chỉ";
            // 
            // btnLuuNXB
            // 
            this.btnLuuNXB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuuNXB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuuNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuNXB.Location = new System.Drawing.Point(438, 84);
            this.btnLuuNXB.Name = "btnLuuNXB";
            this.btnLuuNXB.Size = new System.Drawing.Size(93, 30);
            this.btnLuuNXB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuuNXB.TabIndex = 7;
            this.btnLuuNXB.Text = "Lưu";
            this.btnLuuNXB.Click += new System.EventHandler(this.btnLuuNXB_Click);
            // 
            // btnHuyNXB
            // 
            this.btnHuyNXB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuyNXB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuyNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyNXB.Location = new System.Drawing.Point(335, 86);
            this.btnHuyNXB.Name = "btnHuyNXB";
            this.btnHuyNXB.Size = new System.Drawing.Size(87, 28);
            this.btnHuyNXB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuyNXB.TabIndex = 6;
            this.btnHuyNXB.Text = "Hủy";
            this.btnHuyNXB.Click += new System.EventHandler(this.btnHuyNXB_Click);
            // 
            // btnXoaNXB
            // 
            this.btnXoaNXB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoaNXB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoaNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNXB.Location = new System.Drawing.Point(438, 36);
            this.btnXoaNXB.Name = "btnXoaNXB";
            this.btnXoaNXB.Size = new System.Drawing.Size(93, 28);
            this.btnXoaNXB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoaNXB.TabIndex = 5;
            this.btnXoaNXB.Text = "Xóa";
            this.btnXoaNXB.Click += new System.EventHandler(this.btnXoaNXB_Click);
            // 
            // btnThemNXB
            // 
            this.btnThemNXB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemNXB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNXB.Location = new System.Drawing.Point(335, 36);
            this.btnThemNXB.Name = "btnThemNXB";
            this.btnThemNXB.Size = new System.Drawing.Size(87, 28);
            this.btnThemNXB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemNXB.TabIndex = 4;
            this.btnThemNXB.Text = "Thêm";
            this.btnThemNXB.Click += new System.EventHandler(this.btnThemNXB_Click);
            // 
            // lblTenNXB
            // 
            this.lblTenNXB.AntiAlias = false;
            this.lblTenNXB.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblTenNXB.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTenNXB.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTenNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNXB.Location = new System.Drawing.Point(21, 18);
            this.lblTenNXB.Name = "lblTenNXB";
            this.lblTenNXB.Size = new System.Drawing.Size(97, 26);
            this.lblTenNXB.TabIndex = 1;
            this.lblTenNXB.Text = "Tên NXB";
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTenNXB.Border.Class = "TextBoxBorder";
            this.txtTenNXB.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenNXB.DisabledBackColor = System.Drawing.Color.White;
            this.txtTenNXB.ForeColor = System.Drawing.Color.Black;
            this.txtTenNXB.Location = new System.Drawing.Point(124, 18);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.PreventEnterBeep = true;
            this.txtTenNXB.Size = new System.Drawing.Size(173, 26);
            this.txtTenNXB.TabIndex = 1;
            // 
            // gpDanhSach
            // 
            this.gpDanhSach.BackColor = System.Drawing.Color.Transparent;
            this.gpDanhSach.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpDanhSach.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpDanhSach.Controls.Add(this.dgvNXB);
            this.gpDanhSach.DisabledBackColor = System.Drawing.Color.Empty;
            this.gpDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDanhSach.Location = new System.Drawing.Point(23, 283);
            this.gpDanhSach.Name = "gpDanhSach";
            this.gpDanhSach.Size = new System.Drawing.Size(562, 262);
            // 
            // 
            // 
            this.gpDanhSach.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpDanhSach.Style.BackColorGradientAngle = 90;
            this.gpDanhSach.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpDanhSach.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpDanhSach.Style.BorderBottomWidth = 1;
            this.gpDanhSach.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpDanhSach.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpDanhSach.Style.BorderLeftWidth = 1;
            this.gpDanhSach.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpDanhSach.Style.BorderRightWidth = 1;
            this.gpDanhSach.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpDanhSach.Style.BorderTopWidth = 1;
            this.gpDanhSach.Style.CornerDiameter = 4;
            this.gpDanhSach.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpDanhSach.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpDanhSach.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpDanhSach.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpDanhSach.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpDanhSach.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpDanhSach.TabIndex = 12;
            this.gpDanhSach.Text = "Danh sách nhà xuất bản";
            // 
            // dgvNXB
            // 
            this.dgvNXB.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNXB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNXB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNXB,
            this.TenNXB,
            this.DiaChi,
            this.SoDienThoai});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNXB.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNXB.EnableHeadersVisualStyles = false;
            this.dgvNXB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvNXB.Location = new System.Drawing.Point(10, 16);
            this.dgvNXB.Name = "dgvNXB";
            this.dgvNXB.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNXB.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNXB.Size = new System.Drawing.Size(549, 216);
            this.dgvNXB.TabIndex = 0;
            this.dgvNXB.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNXB_CellMouseClick);
            // 
            // MaNXB
            // 
            this.MaNXB.DataPropertyName = "MaNXB";
            this.MaNXB.HeaderText = "Mã NXB";
            this.MaNXB.Name = "MaNXB";
            this.MaNXB.ReadOnly = true;
            this.MaNXB.Visible = false;
            // 
            // TenNXB
            // 
            this.TenNXB.DataPropertyName = "TenNXB";
            this.TenNXB.HeaderText = "Tên NXB";
            this.TenNXB.Name = "TenNXB";
            this.TenNXB.ReadOnly = true;
            this.TenNXB.Width = 180;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 180;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "Số điện thoại";
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            this.SoDienThoai.Width = 140;
            // 
            // frmNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 557);
            this.Controls.Add(this.gpDanhSach);
            this.Controls.Add(this.gpThongTinTacGia);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip);
            this.Name = "frmNXB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà xuất bản";
            this.Load += new System.EventHandler(this.frmNXB_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.gpThongTinTacGia.ResumeLayout(false);
            this.gpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaoDiệnChínhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thẻThưViệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem độcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhàXuấtBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thểLoạiSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thủThưToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuMượnToolStripMenuItem;
        private DevComponents.DotNetBar.LabelX lblTitle;
        private DevComponents.DotNetBar.Controls.GroupPanel gpThongTinTacGia;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoDT;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiaChi;
        private DevComponents.DotNetBar.LabelX lblSoDTNXB;
        private DevComponents.DotNetBar.ButtonX btnLuuNXB;
        private DevComponents.DotNetBar.ButtonX btnHuyNXB;
        private DevComponents.DotNetBar.ButtonX btnXoaNXB;
        private DevComponents.DotNetBar.ButtonX btnThemNXB;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenNXB;
        private DevComponents.DotNetBar.Controls.GroupPanel gpDanhSach;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvNXB;
        private DevComponents.DotNetBar.LabelX lblDiaChiNXB;
        private DevComponents.DotNetBar.LabelX lblTenNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
    }
}