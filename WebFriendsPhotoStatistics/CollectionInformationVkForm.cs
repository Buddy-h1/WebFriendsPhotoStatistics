using System;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Collections.Generic;

namespace WebFriendsPhotoStatistics
{

    public partial class YourAccountVkForm : MaterialForm
    {
        private MaterialForm mainForm;

        private AccountVk yourAccountVk;

        private List<DateTimePhotosFriend> dateTimePhotosFriends = new List<DateTimePhotosFriend>();

        public List<DateTimePhotosFriend> DateTimePhotosFriends
        {
            get
            {
                return dateTimePhotosFriends;
            }
        }
        public YourAccountVkForm()
        {
            InitializeComponent();
        }

        public YourAccountVkForm(MaterialForm mainForm, AccountVk accountVk)
        {
            InitializeComponent();
            this.yourAccountVk = accountVk;
            this.mainForm = mainForm;
        }

        public class DateTimePhotosFriend
        {
            public string firstName;
            public string lastName;
            public List<DateTime> photosUploadDate = new List<DateTime>();
        }

        public class DateCount
        {
            public DateTime dateTime;
            public int count;
        }

        public DateTime GetLessActivePublicationDate(int index)
        {
            if (dateTimePhotosFriends[index].photosUploadDate.Count == 0) return new DateTime(1, 1, 1);
            List<DateTime> noDuplicates = dateTimePhotosFriends[index].photosUploadDate.Distinct().ToList();
            List<DateCount> dateCountList = new List<DateCount>();
            for (int i = 0; i < noDuplicates.Count; i++)
            {
                DateCount dateCount = new DateCount();
                dateCount.dateTime = noDuplicates[i];
                dateCount.count = 0;
                foreach (DateTime dt in dateTimePhotosFriends[index].photosUploadDate)
                {
                    if (noDuplicates[i].Year == dt.Year && noDuplicates[i].Month == dt.Month) dateCount.count++;
                }
                dateCountList.Add(dateCount);
            }

            int minValue = int.MaxValue;
            int indexMax = 0;
            for (int i = 0; i < dateCountList.Count; i++)
            {
                if (dateCountList[i].count < minValue)
                {
                    minValue = dateCountList[i].count;
                    indexMax = i;
                }
            }

            return dateCountList[indexMax].dateTime;

        }

        public void GetDateTimePhotosFriend()
        {
            for (int i = 0; i < yourAccountVk.InfoFriends.response.count; i++)
            {
                DateTimePhotosFriend dtPhotosFriend = new DateTimePhotosFriend();
                dtPhotosFriend.firstName = yourAccountVk.InfoFriends.response.items[i].first_name;
                dtPhotosFriend.lastName = yourAccountVk.InfoFriends.response.items[i].last_name;
                if (yourAccountVk.PhotosAllFriends[i].response == null)
                {
                    dateTimePhotosFriends.Add(dtPhotosFriend);
                    continue;
                }
                for (int j = 0; j < yourAccountVk.PhotosAllFriends[i].response.items.Length; j++)
                {
                    DateTime pDate = (new DateTime(1970, 1, 1, 0, 0, 0, 0)).AddSeconds(yourAccountVk.PhotosAllFriends[i].response.items[j].date);
                    dtPhotosFriend.photosUploadDate.Add(pDate);
                }
                dateTimePhotosFriends.Add(dtPhotosFriend);
            }
        }

        public void OutputFriend()
        {
            for (int i = 0; i < yourAccountVk.InfoFriends.response.count; i++)
            {
                friendsListBox.Items.Add(yourAccountVk.InfoFriends.response.items[i].first_name + " " +
                    yourAccountVk.InfoFriends.response.items[i].last_name + " ( id" +
                    yourAccountVk.InfoFriends.response.items[i].id + " )");
            }
        }

        private void YourAccountVk_Shown(object sender, EventArgs e)
        {
            nameAuthorizedLabel2.Text = yourAccountVk.UserFnameLname;
            OutputFriend();
            GetDateTimePhotosFriend();
            loadingPictureBox.Hide();
            webBrowser.DocumentText = "<!DOCTYPE html><html lang=\"en\"><head><meta charset=\"UTF-8\"><title>Photos</title></head><body style=\"background-color: #cdcdcd; font-family: Roboto; font-size: 40px; font-weight: bold; line-height: 60px; color: white\";><p style=\"margin-top: 85px; text-align: center\">Здесь будут <br> фотографии <br> ваших друзей</p></body></html>";
        }

        public string GetHtmlPage(int index)
        {
            if (yourAccountVk.PhotosAllFriends[index].response == null) return "Нет данных";
            string HtmlPage = "<!DOCTYPE html><html lang=\"en\"><head><meta charset=\"UTF-8\"><title>Photos</title></head><body>";
            for (int i = 0; i < yourAccountVk.PhotosAllFriends[index].response.items.Length; i++)
            {
                HtmlPage += "<img src=\"" + yourAccountVk.PhotosAllFriends[index].response.items[i].sizes[2].url + "\" width=\"445\">";
                HtmlPage += "<p style=\"margin-top: 0px; font-family: Roboto\">" + "Дата публикации: " + dateTimePhotosFriends[index].photosUploadDate[i].Month.ToString("00") + "." + dateTimePhotosFriends[index].photosUploadDate[i].Year + "</p>";
            }
            HtmlPage += "</body></html>";
            return HtmlPage;
        }

        private void friendsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            int index = friendsListBox.SelectedIndex;
            webBrowser.DocumentText = GetHtmlPage(index);

            dateTimePhotosFriendListBox.Items.Clear();
            for (int i = 0; i < dateTimePhotosFriends[index].photosUploadDate.Count; i++)
            {
                dateTimePhotosFriendListBox.Items.Add(dateTimePhotosFriends[index].photosUploadDate[i]);
            }

            DateTime minActivePublicationDate = GetLessActivePublicationDate(index);

            if (minActivePublicationDate.Month == 1 && minActivePublicationDate.Year == 1)
            {
                periodLabel.Text = "Не найдено";
            }
            else
            {
                periodLabel.Text = minActivePublicationDate.Month.ToString("00") + "." + minActivePublicationDate.Year;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            VkAuthorizationForm vkAuthorizationForm = new VkAuthorizationForm(mainForm);
            vkAuthorizationForm.Show();
        }
    }
}
