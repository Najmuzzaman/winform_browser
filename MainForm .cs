namespace Broswer
{
    public partial class MainForm : Form
    {
        private WebBrowser webBrowser;

        public MainForm()
        {
            InitializeComponent();
            InitializeWebBrowser();
        }

        private void InitializeWebBrowser()
        {
            webBrowser = new WebBrowser();
            webBrowser.Dock = DockStyle.Fill;
            webBrowser.ScriptErrorsSuppressed = false; // Suppress script errors (optional)
            Controls.Add(webBrowser);
            webBrowser.Navigate("https://www.bingodrive.com");
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (webBrowser != null)
            {
                webBrowser.Width = ClientSize.Width;
                webBrowser.Height = ClientSize.Height;
            }
        }
    }
}
