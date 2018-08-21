using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Facebook
{
    public class Image
    {
        public int height { get; set; }
        public string src { get; set; }
        public int width { get; set; }
    }

    public class Media
    {
        public Image image { get; set; }
    }

    public class Target
    {
        public string url { get; set; }
    }

    public class Datum2
    {
        public string description { get; set; }
        public Media media { get; set; }
        public Target target { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Attachments
    {
        public List<Datum2> data { get; set; }
    }

    public class Datum
    {
        public string message { get; set; }
        public string id { get; set; }
        public string link { get; set; }
        public Attachments attachments { get; set; }
    }

    public class Paging
    {
        public string previous { get; set; }
        public string next { get; set; }
    }

    public class RootObject
    {
        public List<Datum> data { get; set; }
        public Paging paging { get; set; }
    }
}
