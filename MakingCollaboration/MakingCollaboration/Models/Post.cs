using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakingCollaboration.Models
{
    public class Post
    {
        public string User { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int Upvotes { get; set; }

        public int Downvotes { get; set; }

        public List<string> Tags { get; set; }
        public List<Comment> Comments { get; set; }
    }
}