using MenuItemService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuItemService.Repository
{
    public class MenuItemRepository : IMenuItemRepository
    {
        /*List<Category> category = new List<Category>()
        {
            new Category(){Id=1, Name="Main Course"},
            new Category(){Id=2, Name="Starter"},
            new Category(){Id=3, Name="Dessert"}
        };*/
        static List<MenuItem> menuItems = new List<MenuItem>()
        {
            new MenuItem(){Id=1,Name="Biriyani ",Price=250,Active=true,DateOfLaunch=DateTime.Parse("09/10/2010"),FreeDelivery=true,CategoryName="Main Course"},
            new MenuItem(){Id=2,Name="Vegrole",Price=150,Active=true,DateOfLaunch=DateTime.Parse("02/13/2007"),FreeDelivery=true,CategoryName="Starter"},
            new MenuItem(){Id=3,Name="Fried Rice",Price=300,Active=true,DateOfLaunch=DateTime.Parse("09/12/2017"),FreeDelivery=false,CategoryName="Main course"},
            new MenuItem(){Id=4,Name="Samosa",Price=130,Active=false,DateOfLaunch=DateTime.Parse("19/12/2017"),FreeDelivery=true,CategoryName="Starter"},
            new MenuItem(){Id=5,Name="Brownie",Price=300,Active=true,DateOfLaunch=DateTime.Parse("11/01/2020"),FreeDelivery=true,CategoryName="Dessert"}
        };
        public bool AddMenuItem(MenuItem item)
        {
            var duplicate = menuItems.SingleOrDefault(x => x.Id == item.Id);
            if (duplicate == null)
            {
                menuItems.Add(item);
                return true;
            }
            return false;
        }

        public IEnumerable<MenuItem> GetAll()
        {
            var items=menuItems.ToList();
            return items;
        }

        public bool RemoveMenuItem(int id)
        {
            var itemToRemove = menuItems.SingleOrDefault(x => x.Id == id);
            if (itemToRemove != null)
            {
                menuItems.Remove(itemToRemove);
                return true;
            }
            return false;    
        }
    }
}
