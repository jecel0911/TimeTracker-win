using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeTracker.DB.models
{
    class Task
    {
        private int id { get; set; }
        private string description { get; set; }

        public Task(int id, string description)
        {
            this.id = id;
            this.description = description;
        }
        
    }
}
