
namespace WebFriendsPhotoStatistics.Models
{
    class InfoProfileJson
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
}
