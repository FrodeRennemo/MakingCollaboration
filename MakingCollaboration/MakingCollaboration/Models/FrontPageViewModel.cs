using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakingCollaboration.Models
{
    public class FrontPageViewModel
    {
        public List<Post> Posts { get; set; }

        public FrontPageViewModel()
        {
            var comments = new List<Comment>();
            Posts = new List<Post>();
            comments.Add(new Comment() { Content = "This is a really helpful post, thanks bro.", User = "praelly" });
            comments.Add(new Comment() { Content = "This helped my team", User = "TechLeadMan" });
            comments.Add(new Comment() { Content = "Im 12 years old and what is this", User = "#NoScope" });
            Posts.Add(new Post() { Comments = comments, Content = "Emacs and vi is too damn hard.", Downvotes = 1, Upvotes = 10, Tags = new List<string>() { "text editors", "emacs,vi,nano" }, Title = "Why nano is so much better than vi and emacs combined.", User = "BestProgrammer" });
        }

    }
}