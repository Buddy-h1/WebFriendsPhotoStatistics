using System.Web;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace PhotosFriendsVK
{
    public partial class AuthorizationVkForm : MaterialForm
    {

        private AccountVk accountVk;

        public AuthorizationVkForm()
        {
            InitializeComponent();
        }

        public void SetUrlWebBrowser(string url)
        {
            webBrowser.Url = new System.Uri(url, System.UriKind.Absolute);
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser.Url.ToString().IndexOf("https://oauth.vk.com/blank.html#error=access_denied") == 0)
            {
                webBrowser.Navigate("https://oauth.vk.com/authorize?client_id=8115994&display=page&redirect_uri=https://oauth.vk.com/blank.html&scope=friends,photos&response_type=token&revoke=1&v=5.131");
                return;
            }
            else if (webBrowser.Url.ToString().IndexOf("https://oauth.vk.com/blank.html") == 0)//если авторизация прошла успешно
            {
                var urlParams = HttpUtility.ParseQueryString(e.Url.Fragment.Substring(1));
                string accessToken = urlParams.Get("access_token");
                string userId = urlParams.Get("user_id");
                accountVk = new AccountVk(userId, accessToken);
                YourAccountVkForm yourAccountVkForm = new YourAccountVkForm(this, accountVk);
                this.Hide();
                yourAccountVkForm.Show();
            }
        }
    }
}
