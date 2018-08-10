using Idea_Box.Droid.Data;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(Android_SQLite))]

namespace Idea_Box.Droid.Data
{
    public class Android_SQLite : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var dbName = "Ideas.sqlite";
            var dbPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            var path = System.IO.Path.Combine(dbPath, dbName);
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }
    }
}