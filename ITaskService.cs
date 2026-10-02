


public interface ITaskService
{
    void AddTask(TaskItem task);
    List<TaskItem> DisplayTasks();
    void CompleteTask(int id);
    void DeleteTask(int id);
    void SearchByTitle(string title);
    void GetByPriority(TaskItem.Priority priority);
}