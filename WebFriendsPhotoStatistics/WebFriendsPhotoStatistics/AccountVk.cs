using System;
using WebFriendsPhotoStatistics.Models;
using System.Text;
using System.Net;
using System.IO;
using System.Collections.Generic;

namespace WebFriendsPhotoStatistics
{
    public class AccountVk
    {
        private string accessToken;
        private string userId;
        private string userFnameLname;
        private InfoFriendsJson infoFriends;
        private List<PhotosFriendJson> photosAllFriends = new List<PhotosFriendJson>();

        public string AccessToken
        {
            get
            {
                return accessToken;
            }
            set
            {
                accessToken = value;
            }
        }
        public string UserId
        {
            get
            {
                return userId;
            }
            set
            {
                userId = value;
            }
        }
        public string UserFnameLname
        {
            get
            {
                return userFnameLname;
            }
        }
        public InfoFriendsJson InfoFriends
        {
            get
            {
                return infoFriends;
            }
            set
            {
                infoFriends = value;
            }
        }
        public List<PhotosFriendJson> PhotosAllFriends
        {
            get
            {
                return photosAllFriends;
            }
            set
            {
                photosAllFriends = value;
            }
        }

        public void GetUserFnameLname()
        {
            String jsoninfoProfile = ReadResponse("https://api.vk.com/method/account.getProfileInfo?access_token=" + accessToken + "&v=5.131");
            InfoProfileJson infoProfileJson = Newtonsoft.Json.JsonConvert.DeserializeObject<InfoProfileJson>(jsoninfoProfile);
            userFnameLname = infoProfileJson.response.first_name + " " + infoProfileJson.response.last_name;
        }

        public void GetInfoFriends()
        {
            String jsonInfoFriends = ReadResponse("https://api.vk.com/method/friends.get?access_token=" + accessToken + "&user_id=" + userId + "&order=name&fields=nickname&v=5.131");
            infoFriends = Newtonsoft.Json.JsonConvert.DeserializeObject<InfoFriendsJson>(jsonInfoFriends);
        }

        private bool CheckResponse(String jsonStr)
        {
            string substring = "\"error_code\":6";
            int indexOfSubstring = jsonStr.IndexOf(substring);
            if (indexOfSubstring == -1)
                return true;
            else return false;
        }

        public void GetPhotosFriends()
        {
            for (int i = 0; i < infoFriends.response.count; i++)
            {
                String jsonPhotosFriend = ReadResponse("https://api.vk.com/method/photos.getAll?access_token=" + accessToken + "&owner_id=" + infoFriends.response.items[i].id + "&v=5.131");
                while (CheckResponse(jsonPhotosFriend) == false)
                {
                    jsonPhotosFriend = ReadResponse("https://api.vk.com/method/photos.getAll?access_token=" + accessToken + "&owner_id=" + infoFriends.response.items[i].id + "&v=5.131");
                }
                PhotosFriendJson photosFriend = Newtonsoft.Json.JsonConvert.DeserializeObject<PhotosFriendJson>(jsonPhotosFriend);
                photosAllFriends.Add(photosFriend);
            }
        }

        static public string ReadResponse(string url)
        {
            StringBuilder sb = new StringBuilder();
            byte[] buf = new byte[8192];
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream resStream = response.GetResponseStream();
            int count = 0;
            do
            {
                count = resStream.Read(buf, 0, buf.Length);
                if (count != 0)
                {
                    sb.Append(Encoding.UTF8.GetString(buf, 0, count));
                }
            }
            while (count > 0);
            return sb.ToString();
        }
    }
}
