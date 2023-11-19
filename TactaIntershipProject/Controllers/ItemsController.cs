using Microsoft.AspNetCore.Mvc;
using TactaIntershipProject.Model;
using TactaIntershipProject.Service;

namespace TactaIntershipProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : Controller
    {
        private readonly IItemRepository itemRepository;

        public ItemsController(IItemRepository itemRepository)
        {
            this.itemRepository = itemRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Shopper>> GetShopper()
        {
            var shoppers = itemRepository.GetItems();
            return Ok(shoppers);
        }
    }
}
