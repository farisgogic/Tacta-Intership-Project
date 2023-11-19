using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TactaIntershipProject.Service.Database
{
    public class ShoppingList
    {
        public int ShoppingListId { get; set; }
        public int ShopperId { get; set; }
        public int ItemId { get; set; }

        public Shoppers Shopper { get; set; }
        public Items Item { get; set; }
    }
}
