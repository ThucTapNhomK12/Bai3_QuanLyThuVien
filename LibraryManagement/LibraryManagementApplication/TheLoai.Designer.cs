namespace LibraryManagementApplication
{
    partial class frmTheLoai
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
            this.gpThongTin = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnLuuTheLoai = new DevComponents.DotNetBar.ButtonX();
            this.btnHuyTheLoai = new DevComponents.DotNetBar.ButtonX();
            this.btnXoaTheLoai = new DevComponents.DotNetBar.ButtonX();
            this.btnThemTheLoai = new DevComponents.DotNetBar.ButtonX();
            this.lblTheLoai = new DevComponents.DotNetBar.LabelX();
            this.txtTheLoai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.gpDanhSach = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvTheLoai = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip.SuspendLayout();
            this.gpThongTin.SuspendLayout();
            this.gpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).BeginInit();
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
            this.menuStrip.Size = new System.Drawing.Size(516, 29);
            this.menuStrip.TabIndex = 4;
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
            this.lblTitle.Location = new System.Drawing.Point(52, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(408, 39);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Thể loại";
            this.lblTitle.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // gpThongTin
            // 
            this.gpThongTin.BackColor = System.Drawing.Color.Transparent;
            this.gpThongTin.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpThongTin.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpThongTin.Controls.Add(this.btnLuuTheLoai);
            this.gpThongTin.Controls.Add(this.btnHuyTheLoai);
            this.gpThongTin.Controls.Add(this.btnXoaTheLoai);
            this.gpThongTin.Controls.Add(this.btnThemTheLoai);
            this.gpThongTin.Controls.Add(this.lblTheLoai);
            this.gpThongTin.Controls.Add(this.txtTheLoai);
            this.gpThongTin.DisabledBackColor = System.Drawing.Color.Empty;
            this.gpThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpThongTin.Location = new System.Drawing.Point(12, 82);
            this.gpThongTin.Name = "gpThongTin";
            this.gpThongTin.Size = new System.Drawing.Size(489, 131);
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
            this.gpThongTin.TabIndex = 12;
            this.gpThongTin.Text = "Thông tin thể loại";
            // 
            // btnLuuTheLoai
            // 
            this.btnLuuTheLoai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuuTheLoai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuuTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuTheLoai.Location = new System.Drawing.Point(384, 63);
            this.btnLuuTheLoai.Name = "btnLuuTheLoai";
            this.btnLuuTheLoai.Size = new System.Drawing.Size(89, 28);
            this.btnLuuTheLoai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuuTheLoai.TabIndex = 8;
            this.btnLuuTheLoai.Text = "Lưu";
            this.btnLuuTheLoai.Click += new System.EventHandler(this.btnLuuTheLoai_Click);
            // 
            // btnHuyTheLoai
            // 
            this.btnHuyTheLoai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuyTheLoai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuyTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyTheLoai.Location = new System.Drawing.Point(136, 63);
            this.btnHuyTheLoai.Name = "btnHuyTheLoai";
            this.btnHuyTheLoai.Size = new System.Drawing.Size(87, 28);
            this.btnHuyTheLoai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuyTheLoai.TabIndex = 7;
            this.btnHuyTheLoai.Text = "Hủy";
            this.btnHuyTheLoai.Click += new System.EventHandler(this.btnHuyTheLoai_Click);
            // 
            // btnXoaTheLoai
            // 
            this.btnXoaTheLoai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoaTheLoai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoaTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTheLoai.Location = new System.Drawing.Point(262, 63);
            this.btnXoaTheLoai.Name = "btnXoaTheLoai";
            this.btnXoaTheLoai.Size = new System.Drawing.Size(89, 28);
            this.btnXoaTheLoai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoaTheLoai.TabIndex = 6;
            this.btnXoaTheLoai.Text = "Xóa";
            this.btnXoaTheLoai.Click += new System.EventHandler(this.btnXoaTheLoai_Click);
            // 
            // btnThemTheLoai
            // 
            this.btnThemTheLoai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemTheLoai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTheLoai.Location = new System.Drawing.Point(15, 63);
            this.btnThemTheLoai.Name = "btnThemTheLoai";
            this.btnThemTheLoai.Size = new System.Drawing.Size(87, 28);
            this.btnThemTheLoai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemTheLoai.TabIndex = 5;
            this.btnThemTheLoai.Text = "Thêm";
            this.btnThemTheLoai.Click += new System.EventHandler(this.btnThemTheLoai_Click);
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblTheLoai.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheLoai.Location = new System.Drawing.Point(90, 15);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(85, 25);
            this.lblTheLoai.TabIndex = 1;
            this.lblTheLoai.Text = "Thể loại";
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTheLoai.Border.Class = "TextBoxBorder";
            this.txtTheLoai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTheLoai.DisabledBackColor = System.Drawing.Color.White;
            this.txtTheLoai.ForeColor = System.Drawing.Color.Black;
            this.txtTheLoai.Location = new System.Drawing.Point(181, 15);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.PreventEnterBeep = true;
            this.txtTheLoai.Size = new System.Drawing.Size(204, 26);
            this.txtTheLoai.TabIndex = 3;
            // 
            // gpDanhSach
            // 
            this.gpDanhSach.BackColor = System.Drawing.Color.Transparent;
            this.gpDanhSach.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpDanhSach.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpDanhSach.Controls.Add(this.dgvTheLoai);
            this.gpDanhSach.DisabledBackColor = System.Drawing.Color.Empty;
            this.gpDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDanhSach.Location = new System.Drawing.Point(12, 228);
            this.gpDanhSach.Name = "gpDanhSach";
            this.gpDanhSach.Size = new System.Drawing.Size(489, 262);
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
            this.gpDanhSach.TabIndex = 13;
            this.gpDanhSach.Text = "Danh sách thể loại";
            // 
            // dgvTheLoai
            // 
            this.dgvTheLoai.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTheLoai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDanhMuc,
            this.TenDanhMuc});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTheLoai.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTheLoai.EnableHeadersVisualStyles = false;
            this.dgvTheLoai.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvTheLoai.Location = new System.Drawing.Point(4, 16);
            this.dgvTheLoai.Name = "dgvTheLoai";
            this.dgvTheLoai.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTheLoai.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTheLoai.Size = new System.Drawing.Size(469, 216);
            this.dgvTheLoai.TabIndex = 0;
            this.dgvTheLoai.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTheLoai_CellMouseClick);
            // 
            // MaDanhMuc
            // 
            this.MaDanhMuc.DataPropertyName = "MaDanhMuc";
            this.MaDanhMuc.HeaderText = "Mã thể loại";
            this.MaDanhMuc.Name = "MaDanhMuc";
            this.MaDanhMuc.ReadOnly = true;
            this.MaDanhMuc.Width = 120;
            // 
            // TenDanhMuc
            // 
            this.TenDanhMuc.DataPropertyName = "TenDanhMuc";
            this.TenDanhMuc.HeaderText = "Thể loại";
            this.TenDanhMuc.Name = "TenDanhMuc";
            this.TenDanhMuc.ReadOnly = true;
            this.TenDanhMuc.Width = 300;
            // 
            // frmTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 517);
            this.Controls.Add(this.gpDanhSach);
            this.Controls.Add(this.gpThongTin);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip);
            this.Name = "frmTheLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thể loại";
            this.Load += new System.EventHandler(this.frmTheLoai_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.gpThongTin.ResumeLayout(false);
            this.gpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).EndInit();
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
        private DevComponents.DotNetBar.Controls.GroupPanel gpThongTin;
        private DevComponents.DotNetBar.ButtonX btnLuuTheLoai;
        private DevComponents.DotNetBar.ButtonX btnHuyTheLoai;
        private DevComponents.DotNetBar.ButtonX btnXoaTheLoai;
        private DevComponents.DotNetBar.ButtonX btnThemTheLoai;
        private DevComponents.DotNetBar.LabelX lblTheLoai;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTheLoai;
        private DevComponents.DotNetBar.Controls.GroupPanel gpDanhSach;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDanhMuc;
    }
}