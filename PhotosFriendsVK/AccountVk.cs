using System;
using System.Text;
using System.Net;
using System.IO;

namespace PhotosFriendsVK
{
    public class AccountVk
    {
        private string accessToken;
        private string userId;
        private string userFnameLname;
        private InfoFriendsJson infoFriends;

        public string AccessToken
        {
            get
            {
                return accessToken;
            }
        }
        public string UserId
        {
            get
            {
                return userId;
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
        }

        public AccountVk(string userId, string accessToken)
        {
            this.userId = userId;
            this.accessToken = accessToken;
            GetUserFnameLname();
            GetInfoFriends();
        }
        public PhotosFriendJson GetPhotosFriend(int id)
        {
            string jsonPhotosFriend = ReadResponse("https://api.vk.com/method/photos.getAll?access_token=" + accessToken + "&owner_id=" + id + "&v=5.131");
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PhotosFriendJson>(jsonPhotosFriend);
        }

        private void GetUserFnameLname()
        {
            String jsonInfoProfile = ReadResponse("https://api.vk.com/method/account.getProfileInfo?access_token=" + accessToken + "&v=5.131");
            InfoProfileJson infoProfileJson = Newtonsoft.Json.JsonConvert.DeserializeObject<InfoProfileJson>(jsonInfoProfile);
            userFnameLname = infoProfileJson.response.first_name + " " + infoProfileJson.response.last_name;
        }

        private void GetInfoFriends()
        {
            String jsonInfoFriends = ReadResponse("https://api.vk.com/method/friends.get?access_token=" + accessToken + "&user_id=" + userId + "&order=name&fields=nickname&v=5.131");
            infoFriends = Newtonsoft.Json.JsonConvert.DeserializeObject<InfoFriendsJson>(jsonInfoFriends);
        }

        private string ReadResponse(string url)
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

        public class InfoProfileJson
        {
            public Response response;
            public class Rootobject
            {
                public Response response { get; set; }
            }

            public class Response
            {
                public int id { get; set; }
                public string home_town { get; set; }
                public string status { get; set; }
                public string first_name { get; set; }
                public string last_name { get; set; }

            }
        }

        public class InfoFriendsJson
        {
            public Response response;
            public class Rootobject
            {
                public Response response { get; set; }
            }

            public class Friend
            {
                public int id { get; set; }
                public string deactivated { get; set; }
                public string first_name { get; set; }
                public string last_name { get; set; }
                public string track_code { get; set; }
            }

            public class Response
            {
                public int count { get; set; }
                public Friend[] items { get; set; }
            }

        }

        public class PhotosFriendJson
        {
            public Response response;
            public class Rootobject
            {
                public Response response { get; set; }
            }

            public class Sizes
            {
                public int height { get; set; }
                public string url { get; set; }
                public string type { get; set; }
                public int width { get; set; }

            }

            public class Photo
            {
                public int album_id { get; set; }
                public int date { get; set; }
                public int id { get; set; }
                public int owner_id { get; set; }
                public int post_id { get; set; }

                public Sizes[] sizes { get; set; }
            }

            public class Response
            {
                public int count { get; set; }
                public Photo[] items { get; set; }
            }

        }

    }
}
