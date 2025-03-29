namespace QLShipper.GUI
{
    partial class Nhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nhanvien));
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.ThongtincanhanNv = new System.Windows.Forms.TabControl();
            this.tabTtcnNV = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabDsdhNV = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.Ttincanhan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Dsdonhang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.fluentDesignFormContainer1.SuspendLayout();
            this.ThongtincanhanNv.SuspendLayout();
            this.tabTtcnNV.SuspendLayout();
            this.tabDsdhNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.AutoScroll = false;
            this.fluentDesignFormContainer1.Controls.Add(this.ThongtincanhanNv);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(319, 62);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(1358, 968);
            this.fluentDesignFormContainer1.TabIndex = 0;
            this.fluentDesignFormContainer1.Click += new System.EventHandler(this.fluentDesignFormContainer1_Click);
            // 
            // ThongtincanhanNv
            // 
            this.ThongtincanhanNv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThongtincanhanNv.Controls.Add(this.tabTtcnNV);
            this.ThongtincanhanNv.Controls.Add(this.tabDsdhNV);
            this.ThongtincanhanNv.Location = new System.Drawing.Point(0, 0);
            this.ThongtincanhanNv.Name = "ThongtincanhanNv";
            this.ThongtincanhanNv.SelectedIndex = 0;
            this.ThongtincanhanNv.Size = new System.Drawing.Size(1358, 968);
            this.ThongtincanhanNv.TabIndex = 0;
            // 
            // tabTtcnNV
            // 
            this.tabTtcnNV.BackColor = System.Drawing.SystemColors.Window;
            this.tabTtcnNV.Controls.Add(this.panel1);
            this.tabTtcnNV.Location = new System.Drawing.Point(8, 39);
            this.tabTtcnNV.Name = "tabTtcnNV";
            this.tabTtcnNV.Padding = new System.Windows.Forms.Padding(3);
            this.tabTtcnNV.Size = new System.Drawing.Size(1342, 921);
            this.tabTtcnNV.TabIndex = 0;
            this.tabTtcnNV.Text = "Thông tin cá nhân ";
            this.tabTtcnNV.Click += new System.EventHandler(this.tabTtcnNV_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(535, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 130);
            this.panel1.TabIndex = 0;
            // 
            // tabDsdhNV
            // 
            this.tabDsdhNV.BackColor = System.Drawing.SystemColors.Window;
            this.tabDsdhNV.Controls.Add(this.button1);
            this.tabDsdhNV.Controls.Add(this.dataGridView1);
            this.tabDsdhNV.Location = new System.Drawing.Point(8, 39);
            this.tabDsdhNV.Name = "tabDsdhNV";
            this.tabDsdhNV.Padding = new System.Windows.Forms.Padding(3);
            this.tabDsdhNV.Size = new System.Drawing.Size(1342, 921);
            this.tabDsdhNV.TabIndex = 1;
            this.tabDsdhNV.Text = "Danh sách đơn hàng ";
            this.tabDsdhNV.Click += new System.EventHandler(this.tabDsdhNV_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 679);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 73);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hiển thị ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(106, 331);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1198, 234);
            this.dataGridView1.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.BackColor = System.Drawing.Color.LightBlue;
            this.accordionControl1.Appearance.AccordionControl.Options.UseBackColor = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.Ttincanhan,
            this.Dsdonhang,
            this.accordionControlElement1,
            this.accordionControlElement2});
            this.accordionControl1.Location = new System.Drawing.Point(0, 62);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accordionControl1.Size = new System.Drawing.Size(319, 968);
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
            // Dsdonhang
            // 
            this.Dsdonhang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Dsdonhang.ImageOptions.Image")));
            this.Dsdonhang.Name = "Dsdonhang";
            this.Dsdonhang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Dsdonhang.Text = "Danh sách đơn hàng";
            this.Dsdonhang.Click += new System.EventHandler(this.Dsdonhang_Click);
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement1.ImageOptions.Image")));
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement1.Text = "Quay lại trang trước";
            this.accordionControlElement1.Click += new System.EventHandler(this.ReturnNv_Click);
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement2.ImageOptions.Image")));
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement2.Text = "Thoát";
            this.accordionControlElement2.Click += new System.EventHandler(this.ThoatNv_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1677, 62);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            // 
            // Nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1677, 1030);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "Nhanvien";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Nhanvien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Nhanvien_Load);
            this.fluentDesignFormContainer1.ResumeLayout(false);
            this.ThongtincanhanNv.ResumeLayout(false);
            this.tabTtcnNV.ResumeLayout(false);
            this.tabDsdhNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Dsdonhang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Ttincanhan;
        private System.Windows.Forms.TabControl ThongtincanhanNv;
        private System.Windows.Forms.TabPage tabTtcnNV;
        private System.Windows.Forms.TabPage tabDsdhNV;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}