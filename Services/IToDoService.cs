namespace FirstWebApp.Services
{
    public interface IToDoService
    {
        public List<ToDoItem> GetList();
        public ToDoItem GetItem(int id);
        public ToDoItem SetItem(ToDoItem item);
        public int AppendItem(ToDoItem item);
        public int DeleteItem(int id);
    }
}
