using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace PiekarniaProjekt
{
    class Product_database
    {
        public void add_product_to_base(string[] product_data)
        {
            Program.database.Command.CommandText = @"insert into product (name, pkwiu, price, unit, vat, currency) values (@name, @pkwiu, @price, @unit, @vat, @currency)";
            Program.database.Command.Parameters.Add(new SQLiteParameter("@name", product_data[0]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@pkwiu", product_data[1]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@price", product_data[2]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@unit", product_data[3]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@vat", product_data[4]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@currency", product_data[5]));
            Program.database.execute();
        }

        public bool find_to_update(string name)
        {
            Program.database.Command.CommandText = "select * from product where name = @name";
            Program.database.Command.Parameters.Add(new SQLiteParameter("@name", name));
            Program.database.executeReader();
            if (!Program.database.Reader.Read())
                return false;
            else
                return true;
        }

        public void update_product(string[] product_data, string old_name)
        {
            Program.database.Command.CommandText = @"update product set name = @name, pkwiu = @pkwiu, price = @price, unit = @unit, vat = @vat, currency = @currency where name = @old_name";
            Program.database.Command.Parameters.Add(new SQLiteParameter("@name", product_data[0]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@pkwiu", product_data[1]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@price", product_data[2]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@unit", product_data[3]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@vat", product_data[4]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@currency", product_data[5]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@old_name", old_name));
            Program.database.execute();
        }
    }
}
