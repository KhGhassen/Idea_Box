using System;
using System.Collections.Generic;
using System.Text;

namespace Idea_Box.Models
{
    public class Idea
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public override string ToString()
        {
            return $"{Title}  {Likes}  likes";
        }
    }
}
