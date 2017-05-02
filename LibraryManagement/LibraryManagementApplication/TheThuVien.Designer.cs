namespace LibraryManagementApplication
{
    partial class frmCardType
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
            this.gpThongTin = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtSoSach = new DevComponents.Editors.IntegerInput();
            this.btnLuuTheThuVien = new DevComponents.DotNetBar.ButtonX();
            this.btnHuyTheThuVien = new DevComponents.DotNetBar.ButtonX();
            this.btnXoaTheThuVien = new DevComponents.DotNetBar.ButtonX();
            this.btnThemTheThuVien = new DevComponents.DotNetBar.ButtonX();
            this.lblTenThe = new DevComponents.DotNetBar.LabelX();
            this.txtTenThe = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblSoSach = new DevComponents.DotNetBar.LabelX();
            this.gpDanhSach = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvTheThuVien = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaTheThuVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoSachToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle = new DevComponents.DotNetBar.LabelX();
            this.menuStrip.SuspendLayout();
            this.gpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoSach)).BeginInit();
            this.gpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheThuVien)).BeginInit();
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
            this.menuStrip.Size = new System.Drawing.Size(685, 29);
            this.menuStrip.TabIndex = 1;
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
            // gpThongTin
            // 
            this.gpThongTin.BackColor = System.Drawing.Color.Transparent;
            this.gpThongTin.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpThongTin.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpThongTin.Controls.Add(this.txtSoSach);
            this.gpThongTin.Controls.Add(this.btnLuuTheThuVien);
            this.gpThongTin.Controls.Add(this.btnHuyTheThuVien);
            this.gpThongTin.Controls.Add(this.btnXoaTheThuVien);
            this.gpThongTin.Controls.Add(this.btnThemTheThuVien);
            this.gpThongTin.Controls.Add(this.lblTenThe);
            this.gpThongTin.Controls.Add(this.txtTenThe);
            this.gpThongTin.Controls.Add(this.lblSoSach);
            this.gpThongTin.DisabledBackColor = System.Drawing.Color.Empty;
            this.gpThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpThongTin.Location = new System.Drawing.Point(12, 72);
            this.gpThongTin.Name = "gpThongTin";
            this.gpThongTin.Size = new System.Drawing.Size(298, 310);
            // 
            // 
            // 
            this.gpThongTin.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpThongTin.Style.BackColorGradientAngle = 90;
            this.gpThongTin.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpThongTin.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpThongTin.Style.BorderBottomWidth = 1;
            this.gpThongTin.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpThongTin.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpThongTin.Style.BorderLeftWidth = 1;
            this.gpThongTin.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpThongTin.Style.BorderRightWidth = 1;
            this.gpThongTin.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpThongTin.Style.BorderTopWidth = 1;
            this.gpThongTin.Style.CornerDiameter = 4;
            this.gpThongTin.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpThongTin.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpThongTin.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpThongTin.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpThongTin.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpThongTin.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpThongTin.TabIndex = 6;
            this.gpThongTin.Text = "Thông tin thẻ";
            // 
            // txtSoSach
            // 
            // 
            // 
            // 
            this.txtSoSach.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtSoSach.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSoSach.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtSoSach.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.txtSoSach.Location = new System.Drawing.Point(12, 113);
            this.txtSoSach.Name = "txtSoSach";
            this.txtSoSach.ShowUpDown = true;
            this.txtSoSach.Size = new System.Drawing.Size(251, 26);
            this.txtSoSach.TabIndex = 9;
            // 
            // btnLuuTheThuVien
            // 
            this.btnLuuTheThuVien.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuuTheThuVien.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuuTheThuVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuTheThuVien.Location = new System.Drawing.Point(157, 209);
            this.btnLuuTheThuVien.Name = "btnLuuTheThuVien";
            this.btnLuuTheThuVien.Size = new System.Drawing.Size(89, 28);
            this.btnLuuTheThuVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuuTheThuVien.TabIndex = 8;
            this.btnLuuTheThuVien.Text = "Lưu";
            this.btnLuuTheThuVien.Click += new System.EventHandler(this.btnLuuTheThuVien_Click);
            // 
            // btnHuyTheThuVien
            // 
            this.btnHuyTheThuVien.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuyTheThuVien.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuyTheThuVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyTheThuVien.Location = new System.Drawing.Point(31, 209);
            this.btnHuyTheThuVien.Name = "btnHuyTheThuVien";
            this.btnHuyTheThuVien.Size = new System.Drawing.Size(87, 28);
            this.btnHuyTheThuVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuyTheThuVien.TabIndex = 7;
            this.btnHuyTheThuVien.Text = "Hủy";
            this.btnHuyTheThuVien.Click += new System.EventHandler(this.btnHuyTheThuVien_Click);
            // 
            // btnXoaTheThuVien
            // 
            this.btnXoaTheThuVien.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoaTheThuVien.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoaTheThuVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTheThuVien.Location = new System.Drawing.Point(157, 165);
            this.btnXoaTheThuVien.Name = "btnXoaTheThuVien";
            this.btnXoaTheThuVien.Size = new System.Drawing.Size(89, 28);
            this.btnXoaTheThuVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoaTheThuVien.TabIndex = 6;
            this.btnXoaTheThuVien.Text = "Xóa";
            this.btnXoaTheThuVien.Click += new System.EventHandler(this.btnXoaTheThuVien_Click);
            // 
            // btnThemTheThuVien
            // 
            this.btnThemTheThuVien.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemTheThuVien.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemTheThuVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTheThuVien.Location = new System.Drawing.Point(31, 165);
            this.btnThemTheThuVien.Name = "btnThemTheThuVien";
            this.btnThemTheThuVien.Size = new System.Drawing.Size(87, 28);
            this.btnThemTheThuVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemTheThuVien.TabIndex = 5;
            this.btnThemTheThuVien.Text = "Thêm";
            this.btnThemTheThuVien.Click += new System.EventHandler(this.btnThemTheThuVien_Click);
            // 
            // lblTenThe
            // 
            this.lblTenThe.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblTenThe.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTenThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenThe.Location = new System.Drawing.Point(12, 16);
            this.lblTenThe.Name = "lblTenThe";
            this.lblTenThe.Size = new System.Drawing.Size(106, 20);
            this.lblTenThe.TabIndex = 1;
            this.lblTenThe.Text = "Tên loại thẻ";
            // 
            // txtTenThe
            // 
            this.txtTenThe.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTenThe.Border.Class = "TextBoxBorder";
            this.txtTenThe.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenThe.DisabledBackColor = System.Drawing.Color.White;
            this.txtTenThe.ForeColor = System.Drawing.Color.Black;
            this.txtTenThe.Location = new System.Drawing.Point(12, 42);
            this.txtTenThe.Name = "txtTenThe";
            this.txtTenThe.PreventEnterBeep = true;
            this.txtTenThe.Size = new System.Drawing.Size(251, 26);
            this.txtTenThe.TabIndex = 3;
            // 
            // lblSoSach
            // 
            this.lblSoSach.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblSoSach.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSoSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoSach.Location = new System.Drawing.Point(12, 83);
            this.lblSoSach.Name = "lblSoSach";
            this.lblSoSach.Size = new System.Drawing.Size(182, 23);
            this.lblSoSach.TabIndex = 2;
            this.lblSoSach.Text = "Số sách được mượn tối đa";
            // 
            // gpDanhSach
            // 
            this.gpDanhSach.BackColor = System.Drawing.Color.Transparent;
            this.gpDanhSach.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpDanhSach.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpDanhSach.Controls.Add(this.dgvTheThuVien);
            this.gpDanhSach.DisabledBackColor = System.Drawing.Color.Empty;
            this.gpDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDanhSach.Location = new System.Drawing.Point(316, 72);
            this.gpDanhSach.Name = "gpDanhSach";
            this.gpDanhSach.Size = new System.Drawing.Size(361, 310);
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
            this.gpDanhSach.TabIndex = 7;
            this.gpDanhSach.Text = "Danh sách thẻ";
            // 
            // dgvTheThuVien
            // 
            this.dgvTheThuVien.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTheThuVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTheThuVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheThuVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTheThuVien,
            this.TenLoaiThe,
            this.SoSachToiDa});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTheThuVien.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTheThuVien.EnableHeadersVisualStyles = false;
            this.dgvTheThuVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvTheThuVien.Location = new System.Drawing.Point(4, 16);
            this.dgvTheThuVien.Name = "dgvTheThuVien";
            this.dgvTheThuVien.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTheThuVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTheThuVien.Size = new System.Drawing.Size(348, 270);
            this.dgvTheThuVien.TabIndex = 0;
            this.dgvTheThuVien.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTheThuVien_CellMouseClick);
            // 
            // MaTheThuVien
            // 
            this.MaTheThuVien.DataPropertyName = "MaLoaiThe";
            this.MaTheThuVien.HeaderText = "Mã thẻ";
            this.MaTheThuVien.Name = "MaTheThuVien";
            this.MaTheThuVien.ReadOnly = true;
            this.MaTheThuVien.Visible = false;
            this.MaTheThuVien.Width = 5;
            // 
            // TenLoaiThe
            // 
            this.TenLoaiThe.DataPropertyName = "TenLoaiThe";
            this.TenLoaiThe.HeaderText = "Tên thẻ";
            this.TenLoaiThe.Name = "TenLoaiThe";
            this.TenLoaiThe.ReadOnly = true;
            this.TenLoaiThe.Width = 180;
            // 
            // SoSachToiDa
            // 
            this.SoSachToiDa.DataPropertyName = "SoSachToiDa";
            this.SoSachToiDa.HeaderText = "Số sách mượn tối đa";
            this.SoSachToiDa.Name = "SoSachToiDa";
            this.SoSachToiDa.ReadOnly = true;
            this.SoSachToiDa.Width = 125;
            // 
            // lblTitle
            // 
            // 
            // 
            // 
            this.lblTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(140, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(408, 39);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Các loại thẻ thư viện";
            this.lblTitle.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // frmCardType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 396);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gpDanhSach);
            this.Controls.Add(this.gpThongTin);
            this.Controls.Add(this.menuStrip);
            this.Name = "frmCardType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thẻ thư viện";
            this.Load += new System.EventHandler(this.frmCardType_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.gpThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSoSach)).EndInit();
            this.gpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheThuVien)).EndInit();
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
        private DevComponents.DotNetBar.Controls.GroupPanel gpThongTin;
        private DevComponents.DotNetBar.ButtonX btnLuuTheThuVien;
        private DevComponents.DotNetBar.ButtonX btnHuyTheThuVien;
        private DevComponents.DotNetBar.ButtonX btnXoaTheThuVien;
        private DevComponents.DotNetBar.ButtonX btnThemTheThuVien;
        private DevComponents.DotNetBar.LabelX lblTenThe;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenThe;
        private DevComponents.DotNetBar.LabelX lblSoSach;
        private DevComponents.DotNetBar.Controls.GroupPanel gpDanhSach;
        private DevComponents.DotNetBar.LabelX lblTitle;
        private DevComponents.Editors.IntegerInput txtSoSach;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTheThuVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTheThuVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoSachToiDa;
    }
}