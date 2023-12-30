using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace stremio_greek_tv.Models
{
    public class Stream
    {
        public string Url { get; set; }
        public string Name { get; set; }        
        public string Title { get; set; }
    }

    public class StreamResult
    {
        public Stream[] Streams { get; set; }
    }
}
