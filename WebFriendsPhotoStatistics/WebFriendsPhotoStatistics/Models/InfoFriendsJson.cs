
namespace WebFriendsPhotoStatistics.Models
{
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


}
