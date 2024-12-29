namespace BaiTap5
{
    partial class frmSoanThaoVanBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSoanThaoVanBan));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoVănBảnMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuNộiDungVănBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.btnBold = new System.Windows.Forms.ToolStripButton();
            this.btnIttalic = new System.Windows.Forms.ToolStripButton();
            this.btnUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmbFont = new System.Windows.Forms.ToolStripComboBox();
            this.cmbSize = new System.Windows.Forms.ToolStripComboBox();
            this.rtbVanBan = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSystem,
            this.menuFormat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuSystem
            // 
            this.menuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoVănBảnMớiToolStripMenuItem,
            this.toolStripMenuItemOpenFile,
            this.lưuNộiDungVănBảnToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuSystem.Name = "menuSystem";
            this.menuSystem.Size = new System.Drawing.Size(69, 20);
            this.menuSystem.Text = "Hệ thống";
            // 
            // menuFormat
            // 
            this.menuFormat.Name = "menuFormat";
            this.menuFormat.Size = new System.Drawing.Size(74, 20);
            this.menuFormat.Text = "Định dạng";
            // 
            // tạoVănBảnMớiToolStripMenuItem
            // 
            this.tạoVănBảnMớiToolStripMenuItem.Name = "tạoVănBảnMớiToolStripMenuItem";
            this.tạoVănBảnMớiToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.tạoVănBảnMớiToolStripMenuItem.Text = "Tạo văn bản mới";
            // 
            // toolStripMenuItemOpenFile
            // 
            this.toolStripMenuItemOpenFile.Name = "toolStripMenuItemOpenFile";
            this.toolStripMenuItemOpenFile.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItemOpenFile.Text = "Mở tập tin";
            this.toolStripMenuItemOpenFile.Click += new System.EventHandler(this.toolStripMenuItemOpenFile_Click);
            // 
            // lưuNộiDungVănBảnToolStripMenuItem
            // 
            this.lưuNộiDungVănBảnToolStripMenuItem.Name = "lưuNộiDungVănBảnToolStripMenuItem";
            this.lưuNộiDungVănBảnToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.lưuNộiDungVănBảnToolStripMenuItem.Text = "Lưu nội dung văn bản";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnSave,
            this.toolStripSeparator,
            this.btnBold,
            this.btnIttalic,
            this.btnUnderline,
            this.toolStripSeparator1,
            this.cmbFont,
            this.cmbSize});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNew
            // 
            this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(23, 22);
            this.btnNew.Text = "&New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // btnBold
            // 
            this.btnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnBold.Image = ((System.Drawing.Image)(resources.GetObject("btnBold.Image")));
            this.btnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(48, 22);
            this.btnBold.Text = "In đậm";
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnIttalic
            // 
            this.btnIttalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnIttalic.Image = ((System.Drawing.Image)(resources.GetObject("btnIttalic.Image")));
            this.btnIttalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIttalic.Name = "btnIttalic";
            this.btnIttalic.Size = new System.Drawing.Size(70, 22);
            this.btnIttalic.Text = "In Nghiêng";
            this.btnIttalic.Click += new System.EventHandler(this.btnIttalic_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnUnderline.Image = ((System.Drawing.Image)(resources.GetObject("btnUnderline.Image")));
            this.btnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(67, 22);
            this.btnUnderline.Text = "Gạch chân";
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // cmbFont
            // 
            this.cmbFont.Name = "cmbFont";
            this.cmbFont.Size = new System.Drawing.Size(121, 25);
            // 
            // cmbSize
            // 
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(121, 25);
            // 
            // rtbVanBan
            // 
            this.rtbVanBan.Location = new System.Drawing.Point(0, 52);
            this.rtbVanBan.Name = "rtbVanBan";
            this.rtbVanBan.Size = new System.Drawing.Size(799, 398);
            this.rtbVanBan.TabIndex = 2;
            this.rtbVanBan.Text = "";
            // 
            // frmSoanThaoVanBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbVanBan);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSoanThaoVanBan";
            this.Text = "Soạn thảo văn bản ";
            this.Load += new System.EventHandler(this.frmSoanThaoVanBan_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSystem;
        private System.Windows.Forms.ToolStripMenuItem tạoVănBảnMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpenFile;
        private System.Windows.Forms.ToolStripMenuItem lưuNộiDungVănBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuFormat;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton btnBold;
        private System.Windows.Forms.ToolStripButton btnIttalic;
        private System.Windows.Forms.ToolStripButton btnUnderline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox cmbFont;
        private System.Windows.Forms.ToolStripComboBox cmbSize;
        private System.Windows.Forms.RichTextBox rtbVanBan;
    }
}

