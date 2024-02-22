namespace Broswer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            webBrowser.ScriptErrorsSuppressed = true; // Display script errors
            addressBar.Text = "https://www.bingodrive.com";
        }
        private void GoButton_Click(object sender, EventArgs e)
        {
            NavigateToUrl(addressBar.Text);
        }

        private void AddressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NavigateToUrl(addressBar.Text);
                e.SuppressKeyPress = true; // Prevent 'ding' sound
            }
        }

        private void NavigateToUrl(string url)
        {
            if (!string.IsNullOrEmpty(url))
            {
                if (!url.StartsWith("http://") && !url.StartsWith("https://"))
                {
                    url = "http://" + url;
                }
                webBrowser.Navigate(new Uri(url));
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            goButton.PerformClick();
        }
    }
}