using System;
using System.Collections.Generic;
using System.Text;

namespace TactaIntershipProject.Model.Request
{
    public class CreateShoppingListRequest
    {
        public int ShopperId { get; set; }
        public List<int> ItemId { get; set; }
    }
}
