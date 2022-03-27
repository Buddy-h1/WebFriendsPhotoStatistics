using System.Windows.Forms;
using MaterialSkin.Controls;

namespace WebFriendsPhotoStatistics
{
    public partial class FacebookAuthorizationForm : MaterialForm
    {
        private MaterialForm mainForm;
        public FacebookAuthorizationForm()
        {
            InitializeComponent();
        }

        public FacebookAuthorizationForm(MaterialForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void backButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }
    }
}
