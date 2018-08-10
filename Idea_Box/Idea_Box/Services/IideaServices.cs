using Idea_Box.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idea_Box.Services
{
  public  interface IideaServices
    {
        List<Idea> GetIdeas();
    }
}
