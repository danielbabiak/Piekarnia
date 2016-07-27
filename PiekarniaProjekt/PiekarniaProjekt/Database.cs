using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace PiekarniaProjekt
{
    class Database
    {
        private SQLiteConnection connection;
        private SQLiteCommand command;
        private SQLiteDataReader reader;

        public SQLiteDataReader Reader
        {
            get
            {
                return reader;
            }

            set
            {
                reader = value;
            }
        }

        public SQLiteCommand Command
        {
            get
            {
                return command;
            }

            set
            {
                command = value;
            }
        }

        public Database()
        {
            connection = new SQLiteConnection("Data Source=Database.s3db");
            Command = new SQLiteCommand(connection);
        }
        
        public void closeConnect()
        {
            Reader.Close();
            connection.Close();
        }

        public void execute()
        {
            connection.Open();
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e);
            }
            finally
            {
                connection.Close();
            }
        }

       public void executeReader()
        {
            connection.Open();
            try
            {
                Reader = Command.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e);
            }           
        }
    }
}
