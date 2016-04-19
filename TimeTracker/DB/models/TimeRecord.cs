using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeTracker.DB.models
{
    class TimeRecord
    {
        private DateTime startTime { get; set; }
        private DateTime endTime { get; set; }
        private Task taks { get; set; }
        private string description { get; set; }

        public TimeRecord()
        {

        }
        
        public TimeRecord(DateTime startTime, DateTime endTime, Task task, string description)
        {
            this.startTime = startTime;
            this.endTime = endTime;
            this.taks = task;
            this.description = description;
        }
    }
}
