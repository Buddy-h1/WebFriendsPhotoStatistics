using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace PhotosFriendsVK
{
    public partial class YourAccountVkForm : MaterialForm
    {
        private AuthorizationVkForm parentForm;
        private AccountVk yourAccountVk;
        private List<DateTime> datesUploadPhotosSelectedFriend = new List<DateTime>();

        public YourAccountVkForm()
        {
            InitializeComponent();
        }

        public YourAccountVkForm(AuthorizationVkForm mainForm, AccountVk accountVk)
        {
            InitializeComponent();
            this.yourAccountVk = accountVk;
            this.parentForm = mainForm;
        }

        private void OutputFriend()
        {
            for (int i = 0; i < yourAccountVk.InfoFriends.response.count; i++)
            {
                friendsListBox.Items.Add(yourAccountVk.InfoFriends.response.items[i].first_name + " " +
                    yourAccountVk.InfoFriends.response.items[i].last_name + " ( id" +
                    yourAccountVk.InfoFriends.response.items[i].id + " )");
            }
        }

        private void YourAccountVkForm_Shown(object sender, EventArgs e)
        {
            nameAuthorizedLabel2.Text = yourAccountVk.UserFnameLname;
            OutputFriend();
            webBrowser.DocumentText = "<!DOCTYPE html>" +
                                      "<html lang=\"en\">" +
                                      "<head>" +
                                        "<meta charset=\"UTF-8\">" +
                                        "<title>Photos</title>" +
                                      "</head>" +
                                      "<body style=\"background-color: #cdcdcd; font-family: Roboto; font-size: 40px; font-weight: bold; line-height: 60px; color: white\";>" +
                                      "<p style=\"margin-top: 85px; text-align: center\">Здесь будут <br> фотографии <br> ваших друзей</p>" +
                                      "</body>" +
                                      "</html>";

        }

        private void friendsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            datesUploadPhotosSelectedFriend.Clear();
            int index = friendsListBox.SelectedIndex;
            int idFriend = yourAccountVk.InfoFriends.response.items[index].id;
            AccountVk.PhotosFriendJson photosFriendJson = yourAccountVk.GetPhotosFriend(idFriend);
            datesPhotosFriendsListBox.Items.Clear();
            if (photosFriendJson.response == null)
            {
                datesPhotosFriendsListBox.Items.Clear();
                webBrowser.DocumentText = "<!DOCTYPE html>" +
                                      "<html lang=\"en\">" +
                                      "<head>" +
                                        "<meta charset=\"UTF-8\">" +
                                        "<title>Photos</title>" +
                                      "</head>" +
                                      "<body style=\"background-color: #cdcdcd; font-family: Roboto; font-size: 40px; font-weight: bold; line-height: 60px; color: white\";>" +
                                      "<p style=\"margin-top: 85px; text-align: center\">Здесь будут <br> фотографии <br> ваших друзей</p>" +
                                      "</body>" +
                                      "</html>";
                periodLabel.Text = "Не найдено";
                return;
            }
            for (int i = 0; i < photosFriendJson.response.items.Length; i++)
            {
                DateTime dateUploadPhoto = (new DateTime(1970, 1, 1, 0, 0, 0, 0)).AddSeconds(photosFriendJson.response.items[i].date);
                datesUploadPhotosSelectedFriend.Add(dateUploadPhoto);
                datesPhotosFriendsListBox.Items.Add(dateUploadPhoto);
            }

            webBrowser.DocumentText = GetHtmlPage(photosFriendJson);

            DateTime minActivePublicationDate = GetLessActivePublicationDate();

            if (minActivePublicationDate.Month == 1 && minActivePublicationDate.Year == 1)
            {
                periodLabel.Text = "Не найдено";
            }
            else
            {
                periodLabel.Text = minActivePublicationDate.Month.ToString("00") + "." + minActivePublicationDate.Year;
            }
        }

        private class DateCount
        {
            public DateTime dateTime;
            public int count;
        }

        private DateTime GetLessActivePublicationDate()
        {
            if (datesUploadPhotosSelectedFriend.Count == 0) return new DateTime(1, 1, 1);
            List<DateTime> noDuplicates = datesUploadPhotosSelectedFriend.Distinct().ToList();
            List<DateCount> dateCountList = new List<DateCount>();
            for (int i = 0; i < noDuplicates.Count; i++)
            {
                DateCount dateCount = new DateCount();
                dateCount.dateTime = noDuplicates[i];
                dateCount.count = 0;
                foreach (DateTime dt in datesUploadPhotosSelectedFriend)
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

        private string GetHtmlPage(AccountVk.PhotosFriendJson photosFriendJson)
        {
            if (photosFriendJson.response == null || photosFriendJson.response.count == 0) return "Нет данных";
            string HtmlPage = "<!DOCTYPE html><html lang=\"en\"><head><meta charset=\"UTF-8\"><title>Photos</title></head><body>";
            for (int i = 0; i < photosFriendJson.response.items.Length; i++)
            {
                HtmlPage += "<img src=\"" + photosFriendJson.response.items[i].sizes[2].url + "\" width=\"445\">";
                HtmlPage += "<p style=\"margin-top: 0px; font-family: Roboto\">" + "Дата публикации: " + datesUploadPhotosSelectedFriend[i].Month.ToString("00") + "." + datesUploadPhotosSelectedFriend[i].Year + "</p>";
            }
            HtmlPage += "</body></html>";
            return HtmlPage;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.SetUrlWebBrowser("https://oauth.vk.com/authorize?client_id=8115994&display=page&redirect_uri=https://oauth.vk.com/blank.html&scope=friends,photos&response_type=token&revoke=1&v=5.131");
            parentForm.Show();
        }
    }
}
