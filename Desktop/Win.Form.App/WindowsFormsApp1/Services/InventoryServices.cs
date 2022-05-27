using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Models;
using WindowsFormsApp.Repository;
using WindowsFormsApp.Viewmodel;

namespace WindowsFormsApp.Services
{
    public class InventoryServices
    {
        public InventoryRepository iventory = new InventoryRepository();

        public List<InventoryListViewModel> GetAll()
        {
            var data = iventory.GetAll();
            var res = data.Select(p => new InventoryListViewModel
            {
                Id = p.Id,
                CategoryName = p.Category == null ? "" : p.Category.Name,
                Name = p.Name,
                Description = p.Description,
                DateOfPurchase = p.DateOfPurchase,
                Price = p.Price,
                Stock = p.Stock
            }).ToList();
            return res;
        }

        public InventoryListViewModel GetByID(int Id)
        {
            var data = iventory.GetById(Id);
            var res = new InventoryListViewModel
            {
                Id = data.Id,
                CategoryName = data.Category == null ? "" : data.Category.Name,
                Name = data.Name,
                Description = data.Description,
                DateOfPurchase = data.DateOfPurchase,
                Price = data.Price,
                Stock = data.Stock
            };
            return res;
        }

        public (bool, string) Create(InventoryCreateEditViewModel model)
        {
            try
            {
                var invModel = new Inventory()
                {
                    CategoryId = model.CategoryId,
                    DateOfPurchase = model.DateOfPurchase,
                    Description = model.Description,
                    Name = model.Name,
                    Price = model.Price,
                    Stock = model.Stock
                };
                return iventory.Create(invModel);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool, string) Edit(InventoryCreateEditViewModel model)
        {
            try
            {
                var invModel = new Inventory()
                {
                    CategoryId = model.CategoryId,
                    DateOfPurchase = model.DateOfPurchase,
                    Description = model.Description,
                    Name = model.Name,
                    Price = model.Price,
                    Stock = model.Stock,
                    Id = model.Id
                };
                return iventory.Edit(invModel);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool, string) Delete(int Id)
        {
            return iventory.Delete(Id);
        }
    }
}