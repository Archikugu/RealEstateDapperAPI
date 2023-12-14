using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapperAPI.Repositories.ToDoListRepositories;

namespace RealEstateDapperAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListsController : ControllerBase
    {
        private readonly IToDoListRepository _ToDoListRepository;
        public ToDoListsController(IToDoListRepository ToDoListRepository)
        {
            _ToDoListRepository = ToDoListRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ToDoListList()
        {
            var values = await _ToDoListRepository.GetAllToDoListAsync();
            return Ok(values);
        }
    }
}
