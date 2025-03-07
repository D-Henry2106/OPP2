using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP2
{
    internal class Todolist
    {
        List<Task> tasks = new List<Task>();
        public void insertTask(Task task)
        {
            tasks.Add(task);
        }
        public void displayTasks()
        {
            int i = 1;
            foreach (var task in tasks)
            {
                Console.Write(i + ": ");
                Console.WriteLine(task.getDescription());
                i++;
            }
        }
    }
}
