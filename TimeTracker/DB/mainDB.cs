using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
    Main Class for Storing Data
    */
namespace TimeTracker.DB
{
    class MainDB
    {
        ILocalDataBase dbCon; //database Connection

        /// <summary>
        /// Constructor
        /// </summary>
        public MainDB()
        {
            //if x == SQLite3
            dbCon = new LocalDBSQLite3();
        }

    }
}
