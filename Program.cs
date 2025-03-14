namespace OPP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToDoList list1 = new ToDoList();
            Task task1 = new Task("Get up");
            Task task2 = new Task("Have breakfast");
            Task task3 = new Task("Go to school");
            Task task4 = new Task("Play");
            Task task5 = new Task("Go home");
            Task task6 = new Task("Have dinner");
            Task task7 = new Task("Study");
            Task task8 = new Task("Sleep");

            list1.InsertTask(task1);
            list1.InsertTask(task2);
            list1.InsertTask(task3);
            list1.InsertTask(task4);
            list1.InsertTask(task5);
            list1.InsertTask(task6);
            list1.InsertTask(task7);
            list1.InsertTask(task8);
            list1.DisplayTasks();

            Console.WriteLine("----------------");
            list1.UpdateTask(1, "Drink");
            list1.DisplayTasks();

            Console.WriteLine("----------------");
            list1.RemoveTask(0);
            list1.DisplayTasks();

        }
    }
}
