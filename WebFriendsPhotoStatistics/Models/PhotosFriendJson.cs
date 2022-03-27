using System;

namespace WebFriendsPhotoStatistics.Models
{
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