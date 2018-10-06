using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SJBwrites.Models
{
    public class Article
    {
        public string ArtistName { get; set; }

        public string StoryType { get; set; }

        public DateTime PublishDate { get; set; }

        public string Url { get; set; }

        public string Image { get; set; }

        public string StoryBody { get; set; }
    }
}
