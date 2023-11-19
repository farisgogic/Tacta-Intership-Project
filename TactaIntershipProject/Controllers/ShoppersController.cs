using Microsoft.AspNetCore.Mvc;
using TactaIntershipProject.Model;
using TactaIntershipProject.Model.Request;
using TactaIntershipProject.Service;

namespace TactaIntershipProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShoppersController : Controller
    {
        private readonly IShopperRepository shopperRepository;

        public ShoppersController(IShopperRepository shopperRepository)
        {
            this.shopperRepository = shopperRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Shopper>> GetShopper()
        {
            var shoppers = shopperRepository.GetShoppers();
            return Ok(shoppers);
        }

        [HttpPost("createShoppingList")]
        public ActionResult CreateShoppingList(CreateShoppingListRequest request)
        {
            try
            {
                shopperRepository.CheckItemsInShoppingLists(request);

                var createdShoppingList = shopperRepository.CreateShoppingList(request);

                return Ok(createdShoppingList);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("shoppingLists/{shopperId}")]
        public ActionResult<IEnumerable<ShoppingList>> GetShoppingListsByShopperId(int shopperId)
        {
            var shoppingLists = shopperRepository.GetShoppingListsByShopperId(shopperId);
            return Ok(shoppingLists);
        }



    }
}
