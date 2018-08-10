using Idea_Box.Models;
using SQLite;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace Idea_Box.Data
{
    public class IdeaDatabase
    {
        private SQLiteConnection conn;

        //CREATE
        public IdeaDatabase()
        {
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<Idea>();
        }

        //READ
        public ObservableCollection<Idea> GetIdeas()
        {
            var ideas = (from Ide in conn.Table<Idea>() select Ide);
            return new ObservableCollection<Idea>( ideas.ToList());
        }

        //INSERT
        public string AddIdea(Idea idea)
        {
            conn.Insert(idea);
            return "success";
        }

        //DELETE
        public string DeleteIdea(int id)
        {
            conn.Delete<Idea>(id);
            return "success";
        }
    }
}