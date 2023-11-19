using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TactaIntershipProject.Model;
using TactaIntershipProject.Model.Request;
using TactaIntershipProject.Service.Database;

namespace TactaIntershipProject.Service
{
    public class ShopperRepository : IShopperRepository
    {
        private readonly TactaIntershipProjectContext context;
        private readonly IMapper mapper;

        public ShopperRepository(TactaIntershipProjectContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public IEnumerable<Model.ShoppingList> CreateShoppingList(CreateShoppingListRequest request)
        {
            CheckItemsInShoppingLists(request);

            var shoppingLists = new List<Database.ShoppingList>();

            foreach (var itemId in request.ItemId)
            {
                var shoppingList = new Database.ShoppingList
                {
                    ShopperId = request.ShopperId,
                    ItemId = itemId
                };

                context.ShoppingLists.Add(shoppingList);
                shoppingLists.Add(shoppingList);
            }

            context.SaveChanges();

            return mapper.Map<IEnumerable<Model.ShoppingList>>(shoppingLists);

        }

        public void CheckItemsInShoppingLists(CreateShoppingListRequest request)
        {
            var existingShoppingListsCount = context.ShoppingLists.Count(sl => request.ItemId.Contains(sl.ItemId));


            foreach (var itemId in request.ItemId)
            {
                var itemName = context.Items.FirstOrDefault(item => item.ItemId == itemId)?.ItemName;

                if (existingShoppingListsCount + request.ItemId.Count > 3)
                {
                    throw new Exception($"This item '{itemName}' is already in three shopping lists.");
                }

                //if (context.ShoppingLists.Any(sl => sl.ItemId == itemId && sl.ShopperId == request.ShopperId))
                //{
                //    throw new Exception($"Item '{itemName}' is already in the shopping list.");
                //}
            }
        }


        public virtual IEnumerable<Shopper> GetShoppers()
        {
            var shoppers = context.Shoppers.ToList();
            return mapper.Map<IEnumerable<Shopper>>(shoppers);
        }


        public IEnumerable<Model.ShoppingList> GetShoppingListsByShopperId(int shopperId)
        {
            var list = context.ShoppingLists
                .Where(sl => sl.ShopperId == shopperId)
                .ToList();

            return mapper.Map<IEnumerable<Model.ShoppingList>>(list);
        }

    }
}
