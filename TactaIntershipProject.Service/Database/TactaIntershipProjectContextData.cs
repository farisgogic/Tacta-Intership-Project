using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TactaIntershipProject.Service.Database
{
    partial class TactaIntershipProjectContext
    {
        partial void onModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Items>().HasData(new Items
            {
                ItemId = 1,
                ItemName = "item1",
            });
            modelBuilder.Entity<Items>().HasData(new Items
            {
                ItemId = 2,
                ItemName = "item2",
            });
            modelBuilder.Entity<Items>().HasData(new Items
            {
                ItemId = 3,
                ItemName = "item3",
            });
            modelBuilder.Entity<Items>().HasData(new Items
            {
                ItemId = 4,
                ItemName = "item4",
            });
            modelBuilder.Entity<Items>().HasData(new Items
            {
                ItemId = 5,
                ItemName = "item5",
            });


            modelBuilder.Entity<Shoppers>().HasData(new Shoppers
            {
                ShopperId = 1,
                ShopperName = "shopper1",
            });
            modelBuilder.Entity<Shoppers>().HasData(new Shoppers
            {
                ShopperId = 2,
                ShopperName = "shopper2",
            });
            modelBuilder.Entity<Shoppers>().HasData(new Shoppers
            {
                ShopperId = 3,
                ShopperName = "shopper3",
            });
            modelBuilder.Entity<Shoppers>().HasData(new Shoppers
            {
                ShopperId = 4,
                ShopperName = "shopper4",
            });
            modelBuilder.Entity<Shoppers>().HasData(new Shoppers
            {
                ShopperId = 5,
                ShopperName = "shopper5",
            });

            modelBuilder.Entity<ShoppingList>().HasData(new ShoppingList
            {
                ShoppingListId = 1,
                ShopperId = 1,
                ItemId = 2,
            });
            modelBuilder.Entity<ShoppingList>().HasData(new ShoppingList
            {
                ShoppingListId = 2,
                ShopperId = 3,
                ItemId = 1,
            });
            modelBuilder.Entity<ShoppingList>().HasData(new ShoppingList
            {
                ShoppingListId = 3,
                ShopperId = 4,
                ItemId = 5,
            });
        }
    }
}
