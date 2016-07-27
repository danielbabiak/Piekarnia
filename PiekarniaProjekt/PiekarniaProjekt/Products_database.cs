using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace PiekarniaProjekt
{
    class Products_database
    {
        public void find_all_products()
        {
            Program.database.Command.CommandText = "select * from product";
            Program.database.executeReader();
        }
        public void find_to_edit(string name)
        {
            Program.database.Command.CommandText = "select * from product where name = @name";
            Program.database.Command.Parameters.Add(new SQLiteParameter("@name", name));
            Program.database.executeReader();
        }
        public void delete_product(string name)
        {
            Program.database.Command.CommandText = "delete from product where name = @name";
            Program.database.Command.Parameters.Add(new SQLiteParameter("@name", name));
            Program.database.execute();
        }
    }
}
