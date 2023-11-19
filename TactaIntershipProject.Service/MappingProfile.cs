using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TactaIntershipProject.Service
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Database.Shoppers, Model.Shopper>();

            CreateMap<Database.Items, Model.Items>();

            CreateMap<Database.ShoppingList, Model.ShoppingList>();


        }
    }
}
