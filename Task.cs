using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP2
{
    internal class Task
    {
        protected string description;
        public Task()
        {
            this.setDescription("Default task");
        }
        public Task(string description)
        {
            this.setDescription(description);
        }
        public string getDescription() 
        {
            return description;
        }
        public void setDescription(string description)
        {
            this.description = description;
        }
        public void displayTask()
        {
        }
    }
}
