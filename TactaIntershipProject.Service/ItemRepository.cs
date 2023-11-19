using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TactaIntershipProject.Model;
using TactaIntershipProject.Service.Database;

namespace TactaIntershipProject.Service
{
    public class ItemRepository : IItemRepository
    {
        private readonly TactaIntershipProjectContext context;
        private readonly IMapper mapper;

        public ItemRepository(TactaIntershipProjectContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }


        public IEnumerable<Model.Items> GetItems()
        {
            var items = context.Items.ToList();
            return mapper.Map<IEnumerable<Model.Items>>(items);
        }
    }
}
