using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderPattern
{
    public class SocialMediaPost
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }      
        public DateTime DatePost { get; set; }
        public List<string> Tags { get; set; }
        public Uri ImageUri { get; set; }   
        public List<Uri>Link { get; set; }
       

    }
}
