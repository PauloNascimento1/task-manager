namespace TaskManager;

public class TaskItem
{
    public int TaskId { get; set; }
    public string? Description { get; set; }
    public DateTime CreationTime { get; set; } = DateTime.Now;
}
