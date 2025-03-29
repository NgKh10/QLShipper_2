namespace QLShipper.GUI
{
    partial class KhachHang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHang));
            this.KhachHangForm = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.TtincanhanKH = new System.Windows.Forms.TabControl();
            this.tabTtincanhanKH = new System.Windows.Forms.TabPage();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.button1 = new System.Windows.Forms.Button();
            this.tabDonhangKH = new System.Windows.Forms.TabPage();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.button4 = new System.Windows.Forms.Button();
            this.tabVoucher = new System.Windows.Forms.TabPage();
            this.tabDanhgia = new System.Windows.Forms.TabPage();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.Ttincanhan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.DonHangofKh = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Voucher = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.DanhGia = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Return = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Exit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TimDH = new System.Windows.Forms.TextBox();
            this.KhachHangForm.SuspendLayout();
            this.TtincanhanKH.SuspendLayout();
            this.tabTtincanhanKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.tabDonhangKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // KhachHangForm
            // 
            this.KhachHangForm.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.KhachHangForm.Appearance.Options.UseBackColor = true;
            this.KhachHangForm.Controls.Add(this.TtincanhanKH);
            this.KhachHangForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KhachHangForm.Location = new System.Drawing.Point(330, 62);
            this.KhachHangForm.Name = "KhachHangForm";
            this.KhachHangForm.Size = new System.Drawing.Size(1495, 964);
            this.KhachHangForm.TabIndex = 0;
            this.KhachHangForm.Click += new System.EventHandler(this.KhachHangForm_Click);
            // 
            // TtincanhanKH
            // 
            this.TtincanhanKH.Controls.Add(this.tabTtincanhanKH);
            this.TtincanhanKH.Controls.Add(this.tabDonhangKH);
            this.TtincanhanKH.Controls.Add(this.tabVoucher);
            this.TtincanhanKH.Controls.Add(this.tabDanhgia);
            this.TtincanhanKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TtincanhanKH.Location = new System.Drawing.Point(0, 0);
            this.TtincanhanKH.Name = "TtincanhanKH";
            this.TtincanhanKH.SelectedIndex = 0;
            this.TtincanhanKH.Size = new System.Drawing.Size(1495, 964);
            this.TtincanhanKH.TabIndex = 0;
            // 
            // tabTtincanhanKH
            // 
            this.tabTtincanhanKH.BackColor = System.Drawing.SystemColors.Window;
            this.tabTtincanhanKH.Controls.Add(this.tablePanel1);
            this.tabTtincanhanKH.Location = new System.Drawing.Point(8, 39);
            this.tabTtincanhanKH.Name = "tabTtincanhanKH";
            this.tabTtincanhanKH.Padding = new System.Windows.Forms.Padding(3);
            this.tabTtincanhanKH.Size = new System.Drawing.Size(1479, 917);
            this.tabTtincanhanKH.TabIndex = 0;
            this.tabTtincanhanKH.Text = "Thông tin cá nhân ";
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10.95F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 49.05F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.button1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(3, 3);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 68.5F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 439.5F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1473, 911);
            this.tablePanel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel1.SetColumn(this.button1, 2);
            this.button1.Location = new System.Drawing.Point(555, 670);
            this.button1.Name = "button1";
            this.tablePanel1.SetRow(this.button1, 2);
            this.button1.Size = new System.Drawing.Size(454, 79);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cập nhật";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabDonhangKH
            // 
            this.tabDonhangKH.BackColor = System.Drawing.SystemColors.Window;
            this.tabDonhangKH.Controls.Add(this.tablePanel2);
            this.tabDonhangKH.Location = new System.Drawing.Point(8, 39);
            this.tabDonhangKH.Name = "tabDonhangKH";
            this.tabDonhangKH.Padding = new System.Windows.Forms.Padding(3);
            this.tabDonhangKH.Size = new System.Drawing.Size(1479, 917);
            this.tabDonhangKH.TabIndex = 1;
            this.tabDonhangKH.Text = "Đơn hàng ";
            this.tabDonhangKH.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tablePanel2
            // 
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10.95F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 49.05F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel2.Controls.Add(this.panel2);
            this.tablePanel2.Controls.Add(this.button4);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(3, 3);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 59F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 449F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(1473, 911);
            this.tablePanel2.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(555, 670);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(454, 79);
            this.button4.TabIndex = 0;
            this.button4.Text = "Cập nhật";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tabVoucher
            // 
            this.tabVoucher.BackColor = System.Drawing.SystemColors.Window;
            this.tabVoucher.Location = new System.Drawing.Point(8, 39);
            this.tabVoucher.Name = "tabVoucher";
            this.tabVoucher.Padding = new System.Windows.Forms.Padding(3);
            this.tabVoucher.Size = new System.Drawing.Size(1479, 917);
            this.tabVoucher.TabIndex = 2;
            this.tabVoucher.Text = "Voucher";
            // 
            // tabDanhgia
            // 
            this.tabDanhgia.BackColor = System.Drawing.SystemColors.Window;
            this.tabDanhgia.Location = new System.Drawing.Point(8, 39);
            this.tabDanhgia.Name = "tabDanhgia";
            this.tabDanhgia.Padding = new System.Windows.Forms.Padding(3);
            this.tabDanhgia.Size = new System.Drawing.Size(1479, 917);
            this.tabDanhgia.TabIndex = 3;
            this.tabDanhgia.Text = "Đánh giá ";
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.BackColor = System.Drawing.Color.LightBlue;
            this.accordionControl1.Appearance.AccordionControl.Options.UseBackColor = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.Ttincanhan,
            this.DonHangofKh,
            this.Voucher,
            this.DanhGia,
            this.Return,
            this.Exit});
            this.accordionControl1.Location = new System.Drawing.Point(0, 62);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accordionControl1.Size = new System.Drawing.Size(330, 964);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            this.accordionControl1.Click += new System.EventHandler(this.accordionControl1_Click);
            // 
            // Ttincanhan
            // 
            this.Ttincanhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Ttincanhan.ImageOptions.Image")));
            this.Ttincanhan.Name = "Ttincanhan";
            this.Ttincanhan.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Ttincanhan.Text = "Thông tin cá nhân ";
            this.Ttincanhan.Click += new System.EventHandler(this.Ttincanhan_Click);
            // 
            // DonHangofKh
            // 
            this.DonHangofKh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DonHangofKh.ImageOptions.Image")));
            this.DonHangofKh.ImageOptions.ImageIndex = 1;
            this.DonHangofKh.Name = "DonHangofKh";
            this.DonHangofKh.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.DonHangofKh.Text = "Đơn hàng";
            this.DonHangofKh.Click += new System.EventHandler(this.DonHangofKh_Click);
            // 
            // Voucher
            // 
            this.Voucher.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Voucher.ImageOptions.Image")));
            this.Voucher.Name = "Voucher";
            this.Voucher.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Voucher.Text = "Voucher";
            this.Voucher.Click += new System.EventHandler(this.Voucher_Click);
            // 
            // DanhGia
            // 
            this.DanhGia.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DanhGia.ImageOptions.Image")));
            this.DanhGia.Name = "DanhGia";
            this.DanhGia.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.DanhGia.Text = "Đánh giá";
            this.DanhGia.Click += new System.EventHandler(this.DanhGia_Click);
            // 
            // Return
            // 
            this.Return.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Return.ImageOptions.Image")));
            this.Return.Name = "Return";
            this.Return.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Return.Text = "Quay lại trang trước";
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Exit
            // 
            this.Exit.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Left),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.Exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Exit.ImageOptions.Image")));
            this.Exit.Name = "Exit";
            this.Exit.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Exit.Text = "Thoát ";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1825, 62);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.Click += new System.EventHandler(this.fluentDesignFormControl1_Click);
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.MaxItemId = 1;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Thông tin cá nhân ";
            this.accordionControlElement1.Click += new System.EventHandler(this.accordionControlElement1_Click);
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "Thông tin cá nhân ";
            this.accordionControlElement2.Click += new System.EventHandler(this.accordionControlElement2_Click);
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Text = "Thông tin cá nhân ";
            this.accordionControlElement3.Click += new System.EventHandler(this.accordionControlElement3_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(352, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "ok";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.TimDH);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(951, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 53);
            this.panel2.TabIndex = 2;
            // 
            // TimDH
            // 
            this.TimDH.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TimDH.ForeColor = System.Drawing.Color.Gainsboro;
            this.TimDH.Location = new System.Drawing.Point(12, 7);
            this.TimDH.Name = "TimDH";
            this.TimDH.Size = new System.Drawing.Size(325, 43);
            this.TimDH.TabIndex = 1;
            this.TimDH.Text = "Tìm đơn hàng ";
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1825, 1026);
            this.ControlContainer = this.KhachHangForm;
            this.Controls.Add(this.KhachHangForm);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "KhachHang";
            this.NavigationControl = this.accordionControl1;
            this.RightToLeftLayout = true;
            this.Text = "KhachHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KhachHang_Load);
            this.KhachHangForm.ResumeLayout(false);
            this.TtincanhanKH.ResumeLayout(false);
            this.tabTtincanhanKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tabDonhangKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer KhachHangForm;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Ttincanhan;
        private DevExpress.XtraBars.Navigation.AccordionControlElement DonHangofKh;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Voucher;
        private DevExpress.XtraBars.Navigation.AccordionControlElement DanhGia;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Exit;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Return;
        private System.Windows.Forms.TabControl TtincanhanKH;
        private System.Windows.Forms.TabPage tabDonhangKH;
        private System.Windows.Forms.TabPage tabVoucher;
        private System.Windows.Forms.TabPage tabDanhgia;
        private System.Windows.Forms.TabPage tabTtincanhanKH;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.Button button1;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TimDH;
    }
}