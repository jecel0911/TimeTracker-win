using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeTracker.DB
{
    interface ILocalDataBase
    {
        void createConnection();
        void executeQuery(string txtQuery);
        List<Object> executeSelect(string txtQuery);
        void closeConnection();
    }
}
