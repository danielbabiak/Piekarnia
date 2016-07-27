using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace PiekarniaProjekt
{
    class Customer_database
    {
        public void add_customer_to_base(string[] customer_data)
        {
            Program.database.Command.CommandText = @"insert into shop (name, nip, regon, bank, account, street, streetnumber, flatnumber, zipcode, city, phone, email, fax, www) values (@name, @nip, @regon, @bank, @account, @street, @streetnumber, @flatnumber, @zipcode, @city, @phone, @email, @fax, @www)";
            Program.database.Command.Parameters.Add(new SQLiteParameter("@name", customer_data[0]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@nip", customer_data[1]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@regon", customer_data[2]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@bank", customer_data[3]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@account", customer_data[4]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@street", customer_data[5]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@streetnumber", customer_data[6]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@flatnumber", customer_data[7]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@zipcode", customer_data[8]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@city", customer_data[9]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@phone", customer_data[10]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@email", customer_data[11]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@fax", customer_data[12]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@www", customer_data[13]));
            Program.database.execute();
        }

        public bool find_to_update(string name)
        {
            Program.database.Command.CommandText = "select * from shop where name = @name";
            Program.database.Command.Parameters.Add(new SQLiteParameter("@name", name));
            Program.database.executeReader();
            if (!Program.database.Reader.Read())
                return false;
            else
                return true;
        }

        public void update_customer(string[] customer_data, string old_name )
        {
            Program.database.Command.CommandText = @"update shop set name = @name, nip = @nip, regon = @regon, bank = @bank, account = @account, street = @street, streetnumber = @streetnumber, flatnumber = @flatnumber, zipcode = @zipcode, city = @city, phone = @phone, email = @email, fax = @fax, www = @www where name = @old_name";
            Program.database.Command.Parameters.Add(new SQLiteParameter("@name", customer_data[0]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@nip", customer_data[1]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@regon", customer_data[2]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@bank", customer_data[3]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@account", customer_data[4]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@street", customer_data[5]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@streetnumber", customer_data[6]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@flatnumber", customer_data[7]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@zipcode", customer_data[8]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@city", customer_data[9]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@phone", customer_data[10]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@email", customer_data[11]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@fax", customer_data[12]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@www", customer_data[13]));
            Program.database.Command.Parameters.Add(new SQLiteParameter("@old_name", old_name));
            Program.database.execute();
        }

    }
}
