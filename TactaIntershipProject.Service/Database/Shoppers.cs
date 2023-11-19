using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TactaIntershipProject.Service.Database
{
    public class Shoppers
    {
        [Key]
        public int ShopperId { get; set; }
        public string ShopperName { get; set; }
    }
}
