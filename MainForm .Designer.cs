namespace Broswer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addressBar = new TextBox();
            goButton = new Button();
            webBrowser = new WebBrowser();
            SuspendLayout();
            // 
            // addressBar
            // 
            addressBar.Dock = DockStyle.Top;
            addressBar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressBar.Location = new Point(0, 0);
            addressBar.Name = "addressBar";
            addressBar.Size = new Size(800, 29);
            addressBar.TabIndex = 0;
            addressBar.KeyDown += AddressBar_KeyDown;
            // 
            // goButton
            // 
            goButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            goButton.Location = new Point(725, 3);
            goButton.Name = "goButton";
            goButton.Size = new Size(70, 24);
            goButton.TabIndex = 0;
            goButton.Text = "Go";
            goButton.Click += GoButton_Click;
            // 
            // webBrowser
            // 
            webBrowser.Dock = DockStyle.Fill;
            webBrowser.Location = new Point(0, 29);
            webBrowser.Name = "webBrowser";
            webBrowser.ScriptErrorsSuppressed = true;
            webBrowser.Size = new Size(800, 421);
            webBrowser.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(webBrowser);
            Controls.Add(goButton);
            Controls.Add(addressBar);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Browser";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox addressBar;
        private Button goButton;
        private WebBrowser webBrowser;
    }
}
