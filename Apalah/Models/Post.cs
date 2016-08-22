using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Apalah.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime PostDate { get; set; }
    }
}