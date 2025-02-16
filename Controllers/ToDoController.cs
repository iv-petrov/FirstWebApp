using FirstWebApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoController : ControllerBase
    {
        private readonly IToDoService _service;
        private readonly ILoggingService _logger;

        public ToDoController(IToDoService service, ILoggingService logger)
        {
            _logger = logger;
            _service = service;
        }
        [HttpGet(Name = "GetList")]
        public IEnumerable<ToDoItem> GetList()
        {
            _logger.Log($"Запрос списка задач. ({_service.GetTitle()})");
            return _service.GetList();
        }
        [HttpGet("{id}",Name = "GetItem")]
        public ToDoItem GetItem(int id)
        {
            _logger.Log($"Запрос задачи ид={id}");
            return _service.GetItem(id);
        }
        [HttpPost(Name = "PostItem")]
        public int ToDoItem(ToDoItem item)
        {
            _logger.Log($"Добавление задачи ид={item.Id}, name={item.TaskName}, isdone={item.IsDone.ToString()}");
            return _service.AppendItem(item);
        }
        [HttpPut(Name = "PutItem")]
        public ToDoItem PutItem(ToDoItem item)
        {
            _logger.Log($"Обновление задачи ид={item.Id}");
            return _service.SetItem(item);
        }
        [HttpDelete("{id}",Name = "DeleteItem")]
        public int DeleteItem(int id)
        {
            _logger.Log($"Удаление задачи ид={id}");
            return _service.DeleteItem(id);
        }
    }
}
