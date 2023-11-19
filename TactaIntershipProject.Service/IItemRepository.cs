using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TactaIntershipProject.Model;

namespace TactaIntershipProject.Service
{
    public interface IItemRepository
    {
        IEnumerable<Items> GetItems();
    }
}
