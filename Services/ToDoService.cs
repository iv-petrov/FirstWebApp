namespace FirstWebApp.Services
{
    public class ToDoService : IToDoService
    {
        private List<ToDoItem> _items;
        /// <summary>
        /// Контспуктор создаёт тестовый набор
        /// </summary>
        public ToDoService()
        {
            _items = new List<ToDoItem>();
            _items.Add(new ToDoItem(1, "Задача №1", false));
            _items.Add(new ToDoItem(2, "Задача №2", false));
            _items.Add(new ToDoItem(3, "Задача №3", false));
        }
        /// <summary>
        /// Получить список дел
        /// </summary>
        /// <returns></returns>
        public List<ToDoItem> GetList()
        {
            return _items;
        }
        /// <summary>
        /// Получить пункт списка по его ид
        /// </summary>
        /// <param name="inId">Ид пункта в списке</param>
        /// <returns></returns>
        public ToDoItem? GetItem(int inId)
        {
            return _items.Find(item => item.Id == inId);
        }
        /// <summary>
        /// Обновляет пункт в списке (или добавляет новый, если ид пункта на входе = 0)
        /// </summary>
        /// <param name="inItem">Заменяемый или добавляемый пункт</param>
        /// <returns></returns>
        public ToDoItem SetItem(ToDoItem inItem)
        {
            if (inItem.Id == 0) 
            { 
                inItem.Id = _items[_items.Count - 1].Id + 1;
                _items.Add(inItem);
            }
            int i = _items.FindIndex(item => item.Id == inItem.Id);
            if (i == -1)
            {
                _items.Add(inItem);
            }
            else
            {
                _items[i] = inItem;
            }
            return GetItem(inItem.Id);
        }
        /// <summary>
        /// Добавление нового пункта в список
        /// </summary>
        /// <param name="inItem">Добавляемый пункт</param>
        /// <returns></returns>
        public int AppendItem(ToDoItem inItem)
        {
            if (inItem.Id == 0) 
            { 
                inItem.Id = _items[_items.Count - 1].Id + 1; 
            }
            _items.Add(inItem);
            return (_items.Count - 1);
        }
        ///
        public int DeleteItem(int inId)
        {
            int i = _items.FindIndex(item => item.Id == inId);
            if (i >= 0) _items.RemoveAt(i);
            return i;
        }
    }
}
