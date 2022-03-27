using System;
using System.Web;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace WebFriendsPhotoStatistics
{
    public partial class VkAuthorizationForm : MaterialForm
    {
        private MaterialForm mainForm;

        private AccountVk accountVk = new AccountVk();
        public VkAuthorizationForm()
        {
            InitializeComponent();
        }

        public VkAuthorizationForm(MaterialForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser.Url.ToString().IndexOf("https://oauth.vk.com/blank.html#error=access_denied") == 0)
            {
                webBrowser.Navigate("https://oauth.vk.com/authorize?client_id=8115994&display=page&redirect_uri=https://oauth.vk.com/blank.html&scope=friends,photos&response_type=token&revoke=1&v=5.131");
                return;
            }
            else if (webBrowser.Url.ToString().IndexOf("https://oauth.vk.com/blank.html") == 0)//если авторизация прошла успешно
            {
                var urlParams = HttpUtility.ParseQueryString(e.Url.Fragment.Substring(1));
                accountVk.AccessToken = urlParams.Get("access_token");
                accountVk.UserId = urlParams.Get("user_id");
                YourAccountVkForm yourAccountVkForm = new YourAccountVkForm(mainForm, accountVk);
                yourAccountVkForm.Show();
                this.Close();
                accountVk.GetUserFnameLname();
                accountVk.GetInfoFriends();
                accountVk.GetPhotosFriends();
            }
        }
    }
}
