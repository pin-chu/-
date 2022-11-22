namespace EBookStore
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.維護商品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.維護商品類別ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.維護使用者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.維護商品ToolStripMenuItem,
            this.維護商品類別ToolStripMenuItem,
            this.維護使用者ToolStripMenuItem,
            this.登出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(875, 34);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 維護商品ToolStripMenuItem
            // 
            this.維護商品ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.維護商品ToolStripMenuItem.Name = "維護商品ToolStripMenuItem";
            this.維護商品ToolStripMenuItem.Size = new System.Drawing.Size(108, 30);
            this.維護商品ToolStripMenuItem.Text = "維護書籍";
            this.維護商品ToolStripMenuItem.Click += new System.EventHandler(this.維護書籍ToolStripMenuItem_Click);
            // 
            // 維護商品類別ToolStripMenuItem
            // 
            this.維護商品類別ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.維護商品類別ToolStripMenuItem.Name = "維護商品類別ToolStripMenuItem";
            this.維護商品類別ToolStripMenuItem.Size = new System.Drawing.Size(150, 30);
            this.維護商品類別ToolStripMenuItem.Text = "維護書籍類別";
            this.維護商品類別ToolStripMenuItem.Click += new System.EventHandler(this.維護書籍類別ToolStripMenuItem_Click);
            // 
            // 維護使用者ToolStripMenuItem
            // 
            this.維護使用者ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.維護使用者ToolStripMenuItem.Name = "維護使用者ToolStripMenuItem";
            this.維護使用者ToolStripMenuItem.Size = new System.Drawing.Size(129, 30);
            this.維護使用者ToolStripMenuItem.Text = "維護使用者";
            this.維護使用者ToolStripMenuItem.Click += new System.EventHandler(this.維護使用者ToolStripMenuItem_Click);
            // 
            // 登出ToolStripMenuItem
            // 
            this.登出ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.登出ToolStripMenuItem.Name = "登出ToolStripMenuItem";
            this.登出ToolStripMenuItem.Size = new System.Drawing.Size(66, 30);
            this.登出ToolStripMenuItem.Text = "登出";
            this.登出ToolStripMenuItem.Click += new System.EventHandler(this.登出ToolStripMenuItem_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TimeLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(648, 6);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(53, 23);
            this.TimeLabel.TabIndex = 3;
            this.TimeLabel.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::EBookStore.Properties.Resources.IMG_0083;
            this.ClientSize = new System.Drawing.Size(875, 661);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 維護商品ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 維護商品類別ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 維護使用者ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登出ToolStripMenuItem;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer timer1;
    }
}