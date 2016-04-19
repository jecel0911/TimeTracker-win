using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimeTracker.DB.models;

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
            dbCon = new LocalDBSQLite3("testdatabase");
            dbCon.connect();
        }

        /// <summary>
        /// Each time the application starts, check if database exist, if not, we execute the initial setup.
        /// </summary>
        private void checkCreateDataBaseIfNotExist()
        {

        }

        /// <summary>
        /// Create the database and tables
        /// </summary>
        public void initialSetUp()
        {

        }

        /// <summary>
        /// drop the database
        /// </summary>
        public void deleteDataBase()
        {

        }

        /// <summary>
        /// Add new TimeRecord or update to database
        /// </summary>
        /// <param name="timeRecord"></param>
        public void addorUpdateTimeRecord(TimeRecord timeRecord)
        {

        }

        /// <summary>
        /// delete the time record (by id)
        /// </summary>
        /// <param name="timeRecord"></param>
        public void deleteTimeRecord(TimeRecord timeRecord)
        {

        }

        /// <summary>
        /// List of timeRecords, receive the list of filters
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public List<TimeRecord> getListTimeRecord(List<Filter> filters)
        {
            return new List<TimeRecord>();
        }
    }
}
