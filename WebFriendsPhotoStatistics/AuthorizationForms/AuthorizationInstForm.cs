using MaterialSkin.Controls;
using System.Windows.Forms;

namespace WebFriendsPhotoStatistics
{
    public partial class InstAuthorizationForm : MaterialForm
    {

        private MaterialForm mainForm;

        public InstAuthorizationForm()
        {
            InitializeComponent();
        }

        public InstAuthorizationForm(MaterialForm mainForm)
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
