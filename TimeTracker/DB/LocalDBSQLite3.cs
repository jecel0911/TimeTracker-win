using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace TimeTracker.DB
{
    class LocalDBSQLite3 : ILocalDataBase
    {
        private SQLiteConnection m_dbConnection;
        private string databaseName;

        public LocalDBSQLite3(string databaseName)
        {
            this.databaseName = databaseName;
        }

        public void connect()
        {
            this.m_dbConnection = new SQLiteConnection("Data Source="+this.databaseName+".sqlite;Version=3;");
        }

        /// <summary>
        /// Initial setup (create database)
        /// </summary>
        public void initialSetUp()
        {
            SQLiteConnection.CreateFile(this.databaseName + ".sqlite");
        }

        public void deleteDataBase()
        {

        }

        public void executeNonQuery(string txtQuery)
        {
            this.m_dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand(txtQuery, this.m_dbConnection);
            command.ExecuteNonQuery();
            this.m_dbConnection.Close();
        }

        public List<object> executeSelect(string txtQuery)
        {
            this.m_dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand(txtQuery, this.m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            Console.WriteLine(reader);
            return new List<object>();

            this.m_dbConnection.Close();
        }
    }
}
