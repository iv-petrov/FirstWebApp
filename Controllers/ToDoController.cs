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
            _logger.Log($"������ ������ �����. ({_service.GetTitle()})");
            return _service.GetList();
        }
        [HttpGet("{id}",Name = "GetItem")]
        public ToDoItem GetItem(int id)
        {
            _logger.Log($"������ ������ ��={id}");
            return _service.GetItem(id);
        }
        [HttpPost(Name = "PostItem")]
        public int ToDoItem(ToDoItem item)
        {
            _logger.Log($"���������� ������ ��={item.Id}, name={item.TaskName}, isdone={item.IsDone.ToString()}");
            return _service.AppendItem(item);
        }
        [HttpPut(Name = "PutItem")]
        public ToDoItem PutItem(ToDoItem item)
        {
            _logger.Log($"���������� ������ ��={item.Id}");
            return _service.SetItem(item);
        }
        [HttpDelete("{id}",Name = "DeleteItem")]
        public int DeleteItem(int id)
        {
            _logger.Log($"�������� ������ ��={id}");
            return _service.DeleteItem(id);
        }
    }
}
