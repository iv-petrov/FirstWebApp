namespace FirstWebApp
{
    public class ToDoItem(int id, string? taskName, bool isDone)
    {
        public int Id { get; set; } = id;
        public string? TaskName { get; set; } = taskName;
        public bool IsDone { get; set; } = isDone;
    }
}
