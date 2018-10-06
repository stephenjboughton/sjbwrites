using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SJBwrites.Models
{
    public class Feature : Article
    {
        public string Head { get; set; }

        public string Deck { get; set; }

        public string ConcertInfo { get; set; }
    }
}
