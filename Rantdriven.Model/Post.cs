using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rantdriven.Persistence
{
    public class Post
    {
        public string Tags { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime DatePublished { get; set; }
        public bool IsPublished { get; set; }
        public List<string> Categories { get; set; }
    }
}
