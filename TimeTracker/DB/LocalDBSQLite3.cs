using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeTracker.DB
{
    class LocalDBSQLite3 : ILocalDataBase
    {
        public LocalDBSQLite3()
        {

        }

        public void closeConnection()
        {
            throw new NotImplementedException();
        }

        public void createConnection()
        {
            throw new NotImplementedException();
        }

        public void executeQuery(string txtQuery)
        {
            throw new NotImplementedException();
        }

        public List<object> executeSelect(string txtQuery)
        {
            throw new NotImplementedException();
        }
    }
}
