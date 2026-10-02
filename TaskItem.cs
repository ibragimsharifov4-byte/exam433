


public class TaskItem
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public Priority priority = new Priority();
    public DateTime DeadLine { get; set; }
    public bool IsDone { get; set; }
    
    public enum Priority
    {
        Low,
        Medium,
        High
    }
}