using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TactaIntershipProject.Service.Database
{
    public class Items
    {
        [Key]
        public int ItemId { get; set; }
        public string ItemName { get; set; }
    }
}
