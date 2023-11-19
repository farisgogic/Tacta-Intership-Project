using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TactaIntershipProject.Model;
using TactaIntershipProject.Model.Request;

namespace TactaIntershipProject.Service
{
    public interface IShopperRepository
    {
        IEnumerable<Shopper> GetShoppers();
        IEnumerable<Model.ShoppingList> CreateShoppingList(CreateShoppingListRequest request);
        IEnumerable<ShoppingList> GetShoppingListsByShopperId(int shopperId);
        public void CheckItemsInShoppingLists(CreateShoppingListRequest request);

    }
}
