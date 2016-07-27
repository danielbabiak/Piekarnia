using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace PiekarniaProjekt
{
    class Shops_database
    {
        public void find_all_shops()
        {
            Program.database.Command.CommandText = "select * from shop order by name";
            Program.database.executeReader();
        }
        public void find_to_edit(string name)
        {
            Program.database.Command.CommandText = "select * from shop where name = @name";
            Program.database.Command.Parameters.Add(new SQLiteParameter("@name", name));
            Program.database.executeReader();
        }
        public void delete_shop(string name)
        {
            Program.database.Command.CommandText = "delete from shop where name = @name";
            Program.database.Command.Parameters.Add(new SQLiteParameter("@name", name));
            Program.database.execute();
        }

    }
}
