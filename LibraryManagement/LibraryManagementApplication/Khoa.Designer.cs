namespace LibraryManagementApplication
{
    partial class frmKhoa
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
            this.lblTenKhoa = new DevComponents.DotNetBar.LabelX();
            this.lblThongTin = new DevComponents.DotNetBar.LabelX();
            this.txtTenKhoa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtThongTin = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.gpThongTin = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnLuuKhoa = new DevComponents.DotNetBar.ButtonX();
            this.btnHuyKhoa = new DevComponents.DotNetBar.ButtonX();
            this.btnXoaKhoa = new DevComponents.DotNetBar.ButtonX();
            this.btnThemKhoa = new DevComponents.DotNetBar.ButtonX();
            this.gpDanhSach = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvKhoa = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThongTin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle = new DevComponents.DotNetBar.LabelX();
            this.menuStrip.SuspendLayout();
            this.gpThongTin.SuspendLayout();
            this.gpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).BeginInit();
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
            this.menuStrip.Size = new System.Drawing.Size(794, 29);
            this.menuStrip.TabIndex = 0;
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
            // lblTenKhoa
            // 
            this.lblTenKhoa.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblTenKhoa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTenKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhoa.Location = new System.Drawing.Point(12, 16);
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.Size = new System.Drawing.Size(69, 20);
            this.lblTenKhoa.TabIndex = 1;
            this.lblTenKhoa.Text = "Tên Khoa";
            // 
            // lblThongTin
            // 
            this.lblThongTin.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblThongTin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTin.Location = new System.Drawing.Point(12, 60);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(69, 23);
            this.lblThongTin.TabIndex = 2;
            this.lblThongTin.Text = "Thông tin";
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTenKhoa.Border.Class = "TextBoxBorder";
            this.txtTenKhoa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenKhoa.DisabledBackColor = System.Drawing.Color.White;
            this.txtTenKhoa.Enabled = false;
            this.txtTenKhoa.ForeColor = System.Drawing.Color.Black;
            this.txtTenKhoa.Location = new System.Drawing.Point(87, 16);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.PreventEnterBeep = true;
            this.txtTenKhoa.Size = new System.Drawing.Size(204, 26);
            this.txtTenKhoa.TabIndex = 3;
            // 
            // txtThongTin
            // 
            // 
            // 
            // 
            this.txtThongTin.BackgroundStyle.Class = "RichTextBoxBorder";
            this.txtThongTin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtThongTin.Enabled = false;
            this.txtThongTin.Location = new System.Drawing.Point(87, 60);
            this.txtThongTin.Name = "txtThongTin";
            this.txtThongTin.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft S" +
    "ans Serif;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs24\\par\r\n}\r\n";
            this.txtThongTin.Size = new System.Drawing.Size(204, 178);
            this.txtThongTin.TabIndex = 4;
            // 
            // gpThongTin
            // 
            this.gpThongTin.BackColor = System.Drawing.Color.Transparent;
            this.gpThongTin.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpThongTin.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpThongTin.Controls.Add(this.btnLuuKhoa);
            this.gpThongTin.Controls.Add(this.btnHuyKhoa);
            this.gpThongTin.Controls.Add(this.btnXoaKhoa);
            this.gpThongTin.Controls.Add(this.btnThemKhoa);
            this.gpThongTin.Controls.Add(this.txtThongTin);
            this.gpThongTin.Controls.Add(this.lblTenKhoa);
            this.gpThongTin.Controls.Add(this.txtTenKhoa);
            this.gpThongTin.Controls.Add(this.lblThongTin);
            this.gpThongTin.DisabledBackColor = System.Drawing.Color.Empty;
            this.gpThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpThongTin.Location = new System.Drawing.Point(12, 83);
            this.gpThongTin.Name = "gpThongTin";
            this.gpThongTin.Size = new System.Drawing.Size(312, 366);
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
            this.gpThongTin.TabIndex = 5;
            this.gpThongTin.Text = "Thông tin";
            // 
            // btnLuuKhoa
            // 
            this.btnLuuKhoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuuKhoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuuKhoa.Enabled = false;
            this.btnLuuKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuKhoa.Location = new System.Drawing.Point(157, 304);
            this.btnLuuKhoa.Name = "btnLuuKhoa";
            this.btnLuuKhoa.Size = new System.Drawing.Size(89, 28);
            this.btnLuuKhoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuuKhoa.TabIndex = 8;
            this.btnLuuKhoa.Text = "Lưu";
            this.btnLuuKhoa.Click += new System.EventHandler(this.btnLuuKhoa_Click);
            // 
            // btnHuyKhoa
            // 
            this.btnHuyKhoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuyKhoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuyKhoa.Enabled = false;
            this.btnHuyKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyKhoa.Location = new System.Drawing.Point(31, 304);
            this.btnHuyKhoa.Name = "btnHuyKhoa";
            this.btnHuyKhoa.Size = new System.Drawing.Size(87, 28);
            this.btnHuyKhoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuyKhoa.TabIndex = 7;
            this.btnHuyKhoa.Text = "Hủy";
            this.btnHuyKhoa.Click += new System.EventHandler(this.btnHuyKhoa_Click);
            // 
            // btnXoaKhoa
            // 
            this.btnXoaKhoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoaKhoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoaKhoa.Enabled = false;
            this.btnXoaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKhoa.Location = new System.Drawing.Point(157, 260);
            this.btnXoaKhoa.Name = "btnXoaKhoa";
            this.btnXoaKhoa.Size = new System.Drawing.Size(89, 28);
            this.btnXoaKhoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoaKhoa.TabIndex = 6;
            this.btnXoaKhoa.Text = "Xóa";
            this.btnXoaKhoa.Click += new System.EventHandler(this.btnXoaKhoa_Click);
            // 
            // btnThemKhoa
            // 
            this.btnThemKhoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemKhoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKhoa.Location = new System.Drawing.Point(31, 260);
            this.btnThemKhoa.Name = "btnThemKhoa";
            this.btnThemKhoa.Size = new System.Drawing.Size(87, 28);
            this.btnThemKhoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemKhoa.TabIndex = 5;
            this.btnThemKhoa.Text = "Thêm";
            this.btnThemKhoa.Click += new System.EventHandler(this.btnThemKhoa_Click);
            // 
            // gpDanhSach
            // 
            this.gpDanhSach.BackColor = System.Drawing.Color.Transparent;
            this.gpDanhSach.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpDanhSach.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpDanhSach.Controls.Add(this.dgvKhoa);
            this.gpDanhSach.DisabledBackColor = System.Drawing.Color.Empty;
            this.gpDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDanhSach.Location = new System.Drawing.Point(330, 83);
            this.gpDanhSach.Name = "gpDanhSach";
            this.gpDanhSach.Size = new System.Drawing.Size(452, 366);
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
            this.gpDanhSach.TabIndex = 6;
            this.gpDanhSach.Text = "Danh sách khoa";
            // 
            // dgvKhoa
            // 
            this.dgvKhoa.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhoa,
            this.TenKhoa,
            this.ThongTin});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhoa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhoa.EnableHeadersVisualStyles = false;
            this.dgvKhoa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvKhoa.Location = new System.Drawing.Point(4, 16);
            this.dgvKhoa.Name = "dgvKhoa";
            this.dgvKhoa.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhoa.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKhoa.Size = new System.Drawing.Size(439, 316);
            this.dgvKhoa.TabIndex = 0;
            this.dgvKhoa.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvKhoa_CellMouseClick);
            // 
            // MaKhoa
            // 
            this.MaKhoa.DataPropertyName = "MaKhoa";
            this.MaKhoa.HeaderText = "Mã khoa";
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.ReadOnly = true;
            this.MaKhoa.Visible = false;
            // 
            // TenKhoa
            // 
            this.TenKhoa.DataPropertyName = "TenKhoa";
            this.TenKhoa.HeaderText = "Tên khoa";
            this.TenKhoa.Name = "TenKhoa";
            this.TenKhoa.ReadOnly = true;
            this.TenKhoa.Width = 155;
            // 
            // ThongTin
            // 
            this.ThongTin.DataPropertyName = "ThongTin";
            this.ThongTin.HeaderText = "Thông tin";
            this.ThongTin.Name = "ThongTin";
            this.ThongTin.ReadOnly = true;
            this.ThongTin.Width = 237;
            // 
            // lblTitle
            // 
            // 
            // 
            // 
            this.lblTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(172, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(408, 39);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Khoa / Ngành";
            this.lblTitle.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // frmKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 465);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gpDanhSach);
            this.Controls.Add(this.gpThongTin);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmKhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khoa";
            this.Load += new System.EventHandler(this.frmKhoa_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.gpThongTin.ResumeLayout(false);
            this.gpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).EndInit();
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
        private DevComponents.DotNetBar.LabelX lblTenKhoa;
        private DevComponents.DotNetBar.LabelX lblThongTin;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenKhoa;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx txtThongTin;
        private DevComponents.DotNetBar.Controls.GroupPanel gpThongTin;
        private DevComponents.DotNetBar.ButtonX btnLuuKhoa;
        private DevComponents.DotNetBar.ButtonX btnHuyKhoa;
        private DevComponents.DotNetBar.ButtonX btnXoaKhoa;
        private DevComponents.DotNetBar.ButtonX btnThemKhoa;
        private DevComponents.DotNetBar.Controls.GroupPanel gpDanhSach;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvKhoa;
        private DevComponents.DotNetBar.LabelX lblTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThongTin;
    }
}

