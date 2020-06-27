namespace CefSharp.RequestIntercept
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
            this.PnlNav = new System.Windows.Forms.Panel();
            this.PnlMid = new System.Windows.Forms.Panel();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.PnlLeft = new System.Windows.Forms.Panel();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnForward = new System.Windows.Forms.Button();
            this.PnlRight = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.PnlWebBrowser = new System.Windows.Forms.Panel();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.PnlNav.SuspendLayout();
            this.PnlMid.SuspendLayout();
            this.PnlLeft.SuspendLayout();
            this.PnlRight.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlNav
            // 
            this.PnlNav.Controls.Add(this.PnlMid);
            this.PnlNav.Controls.Add(this.PnlLeft);
            this.PnlNav.Controls.Add(this.PnlRight);
            this.PnlNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlNav.Location = new System.Drawing.Point(0, 41);
            this.PnlNav.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(1224, 79);
            this.PnlNav.TabIndex = 0;
            // 
            // PnlMid
            // 
            this.PnlMid.Controls.Add(this.TxtAddress);
            this.PnlMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMid.Location = new System.Drawing.Point(293, 0);
            this.PnlMid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlMid.Name = "PnlMid";
            this.PnlMid.Size = new System.Drawing.Size(701, 79);
            this.PnlMid.TabIndex = 5;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAddress.Location = new System.Drawing.Point(27, 21);
            this.TxtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(650, 39);
            this.TxtAddress.TabIndex = 0;
            this.TxtAddress.Text = "D:\\Projects\\CefSharp-Projects\\CefSharp.RequestIntercept\\CefSharp.RequestIntercept" +
    "\\Web\\index.html";
            // 
            // PnlLeft
            // 
            this.PnlLeft.Controls.Add(this.BtnRefresh);
            this.PnlLeft.Controls.Add(this.BtnBack);
            this.PnlLeft.Controls.Add(this.BtnForward);
            this.PnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlLeft.Location = new System.Drawing.Point(0, 0);
            this.PnlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlLeft.Name = "PnlLeft";
            this.PnlLeft.Size = new System.Drawing.Size(293, 79);
            this.PnlLeft.TabIndex = 5;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Image = global::CefSharp.RequestIntercept.Properties.Resources.Refresh;
            this.BtnRefresh.Location = new System.Drawing.Point(210, 15);
            this.BtnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(50, 50);
            this.BtnRefresh.TabIndex = 3;
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Transparent;
            this.BtnBack.Image = global::CefSharp.RequestIntercept.Properties.Resources.Back;
            this.BtnBack.Location = new System.Drawing.Point(32, 15);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(50, 50);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnForward
            // 
            this.BtnForward.Image = global::CefSharp.RequestIntercept.Properties.Resources.Forward;
            this.BtnForward.Location = new System.Drawing.Point(121, 15);
            this.BtnForward.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnForward.Name = "BtnForward";
            this.BtnForward.Size = new System.Drawing.Size(50, 50);
            this.BtnForward.TabIndex = 2;
            this.BtnForward.UseVisualStyleBackColor = true;
            this.BtnForward.Click += new System.EventHandler(this.BtnForward_Click);
            // 
            // PnlRight
            // 
            this.PnlRight.Controls.Add(this.label1);
            this.PnlRight.Controls.Add(this.BtnLoad);
            this.PnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlRight.Location = new System.Drawing.Point(994, 0);
            this.PnlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlRight.Name = "PnlRight";
            this.PnlRight.Size = new System.Drawing.Size(230, 79);
            this.PnlRight.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Loading";
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(19, 15);
            this.BtnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(68, 50);
            this.BtnLoad.TabIndex = 4;
            this.BtnLoad.Text = "GO";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // PnlWebBrowser
            // 
            this.PnlWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlWebBrowser.Location = new System.Drawing.Point(0, 120);
            this.PnlWebBrowser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlWebBrowser.Name = "PnlWebBrowser";
            this.PnlWebBrowser.Size = new System.Drawing.Size(1224, 516);
            this.PnlWebBrowser.TabIndex = 1;
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.MenuStrip1.Size = new System.Drawing.Size(1224, 41);
            this.MenuStrip1.TabIndex = 2;
            this.MenuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(105, 35);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.StatusStrip1.Location = new System.Drawing.Point(0, 636);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.StatusStrip1.Size = new System.Drawing.Size(1224, 22);
            this.StatusStrip1.TabIndex = 3;
            this.StatusStrip1.Text = "statusStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 658);
            this.Controls.Add(this.PnlWebBrowser);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.PnlNav);
            this.Controls.Add(this.MenuStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.MenuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.PnlNav.ResumeLayout(false);
            this.PnlMid.ResumeLayout(false);
            this.PnlMid.PerformLayout();
            this.PnlLeft.ResumeLayout(false);
            this.PnlRight.ResumeLayout(false);
            this.PnlRight.PerformLayout();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlNav;
        private System.Windows.Forms.Panel PnlWebBrowser;
        private System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip StatusStrip1;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnForward;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Panel PnlRight;
        private System.Windows.Forms.Panel PnlMid;
        private System.Windows.Forms.Panel PnlLeft;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.Label label1;
    }
}

