//task1
//enum eto tip dannih v kotorom mi ukazivayem statusi i davat im znacheniya i esli mi ego vizovem to nam pokazhut ego znacheniye po umalchaniyu nachinayetsya s 1

//task2
// Datetime eto structura kotoraya ne pokazivayet vremya mi mozhem dat emu znahceniye day , month , year , hour , minute, second
//i u nego est svoi funktsii takiye kak Now , Today itd

//task3
//koroche try mi tam pishem svoy kod i kogda on nahodit oshibku catch ego lovit i pokazivayet to chto mi emu skazali ,a finally nevazhno , no  svoy otvet on pokazhet

//task4
//nasledovaniye kogda drugiye papki mogut bart nasledstvo ot odnoy glavnoy ,  a polymorfizm eto kogda odin metod mozhet po raznomu ispolzovatsya v raznih klassah


//task5
/* try
{
    var book1 = new Book();
    book1.Title = "Sibir";
    book1.Author = "Mihail Kamishov";
    book1.BorrowDate = new DateTime(2024,01,10);
    book1.DueDate = new DateTime(2024,03,10);
    book1.IsOverdue = true;
    book1.status = Book.BookStatus.Available;
    book1.Boorrow(5);
    DateTime date = new DateTime(2024,03,13);
    book1.Return(date);
    
}
catch(FormatException ex)
{
    System.Console.WriteLine($"Error in format - {ex.Message}");
} */

//task6
/* try
{
    var task1 = new TaskItem()
    {
        Id = 1,
        Title = "Pro",
        priority = TaskItem.Priority.Medium,
        DeadLine = new DateTime(2011,02,20)
    };
    var task2 = new TaskItem()
    {
        Id = 2,
        Title = "Pro",
        priority = TaskItem.Priority.High,
        DeadLine = new DateTime(2012,02,11)
    };
    var task3 = new TaskItem()
    {
        Id = 3,
        Title = "Low",
        priority = TaskItem.Priority.Medium,
        DeadLine = new DateTime(2015,04,21)
    };
    var taskService = new TaskService();
    taskService.AddTask(task1);
    taskService.AddTask(task2);
    taskService.AddTask(task3);
    var tasks = taskService.DisplayTasks();
    foreach (var item in tasks)
    {
        System.Console.WriteLine($"ID: {item.Id}");
        System.Console.WriteLine($"TITLE: {item.Title}");
        System.Console.WriteLine($"PRIORITY: {item.priority}");
        System.Console.WriteLine($"DEADLINE: {item.DeadLine}");
    }
    taskService.DeleteTask(1);
    foreach (var item in tasks)
    {
        System.Console.WriteLine($"ID: {item.Id}");
        System.Console.WriteLine($"TITLE: {item.Title}");
        System.Console.WriteLine($"PRIORITY: {item.priority}");
        System.Console.WriteLine($"DEADLINE: {item.DeadLine}");
    }
    taskService.GetByPriority(TaskItem.Priority.Medium);
}
catch(FormatException ex)
{
    System.Console.WriteLine($"Error in format - {ex.Message}");
} */