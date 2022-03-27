using System;
using MaterialSkin.Controls;

namespace WebFriendsPhotoStatistics
{
    public partial class MainWindowForm : MaterialForm
    {
        public MainWindowForm()
        {
            InitializeComponent();
        }

        private void vkButton_Click(object sender, EventArgs e)
        {
            VkAuthorizationForm vkAuthorizationForm = new VkAuthorizationForm(this);
            this.Hide();
            vkAuthorizationForm.Show();
        }

        private void instagramButton_Click(object sender, EventArgs e)
        {
            InstAuthorizationForm instAuthorizationForm = new InstAuthorizationForm(this);
            this.Hide();
            instAuthorizationForm.Show();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            FacebookAuthorizationForm facebookAuthorizationForm = new FacebookAuthorizationForm(this);
            this.Hide();
            facebookAuthorizationForm.Show();
        }
    }
}
