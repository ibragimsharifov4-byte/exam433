


public class TaskService : ITaskService
{
    public List<TaskItem> taskItems = new List<TaskItem>{};
    public void AddTask(TaskItem task)
    {
        taskItems.Add(task);
    }
    public void CompleteTask(int id)
    {
        foreach (var item in taskItems)
        {
            if(item.IsDone == true)
            {
                System.Console.WriteLine($"The task with id {item.Id} is complated");
                return;
            }
        }
    }
    public void DeleteTask(int id)
    {
        foreach (var item in taskItems)
        {
            if(item.Id == id)
            {
                taskItems.Remove(item);
                return;
            }
        }
        System.Console.WriteLine("Task not found");
    }

    public List<TaskItem> DisplayTasks()
    {
        return taskItems;
    }

    public void GetByPriority(TaskItem.Priority priority)
    {
        foreach (var item in taskItems)
        {
            if(item.priority == priority)
            {
                System.Console.WriteLine($"From PRiORITY: {item.priority}");
                System.Console.WriteLine($"ID: {item.Id}");
                System.Console.WriteLine($"TITLE: {item.Title}");
                System.Console.WriteLine($"DEADLINE: {item.DeadLine}");
            }
        }
    }

    public void SearchByTitle(string title)
    {
        foreach (var item in taskItems)
        {
            if(item.Title == title)
            {
                System.Console.WriteLine($"ID: {item.Id}");
                System.Console.WriteLine($"TITLE: {item.Title}");
                System.Console.WriteLine($"PRIORITY: {item.priority}");
                System.Console.WriteLine($"DEADLINE: {item.DeadLine}");
            }
        }
    }
}