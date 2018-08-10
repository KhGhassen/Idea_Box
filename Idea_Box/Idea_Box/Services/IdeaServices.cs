using Idea_Box.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idea_Box.Services
{
    public class IdeaServices : IideaServices
    {
        public List<Idea> GetIdeas()
        {
            return new List<Idea>
           {
               new Idea {Title="Idea 1" ,  Description = "Description of the idea ,blablabla ..."},
                new Idea {Title="Idea 2" ,  Description = "this is a shitty idea,^^"},
           };
        }
    }
}
