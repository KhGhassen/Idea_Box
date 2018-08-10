using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idea_Box
{
   public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
