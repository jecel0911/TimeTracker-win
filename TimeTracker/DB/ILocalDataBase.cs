using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeTracker.DB
{
    interface ILocalDataBase
    {
        void connect();
        void initialSetUp();
        void deleteDataBase();
        void executeNonQuery(string txtQuery);
        List<object> executeSelect(string txtQuery);
    }
}
