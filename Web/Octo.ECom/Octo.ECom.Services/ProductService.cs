using Octo.ECom.Models.Models;
using Octo.ECom.Models.ViewModels;
using Octo.ECom.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octo.ECom.Services
{
    public interface IProductService
    {
        (bool, string) Create(ProductViewModel model);

        (bool, string) Delete(int id);

        (bool, string) Edit(ProductViewModel model);

        List<ProductViewModel> GetAll();

        ProductViewModel? GetById(int id);

        (bool, string) IncreaseStock(int productId, double stock);
    }

    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(
            IProductRepository productRepository
            )
        {
            this.productRepository = productRepository;
        }

        public List<ProductViewModel> GetAll()
        {
            var data = productRepository.GetAll();
            var ret = data.Select(p => new ProductViewModel()
            {
                Id = p.Id,
                Name = p.Name,
                CategoryId = p.CategoryId,
                Brand = p.Brand,
                CategoryName = p.Category == null ? "" : p.Category.Name,
                LongDescription = p.LongDescription,
                PicturePath = p.PicturePath,
                Price = p.Price,
                ShortDescription = p.ShortDescription,
                Stock = p.Stock,
                Unit = p.Unit
            }).ToList();
            return ret;
        }

        public ProductViewModel? GetById(int id)
        {
            var p = productRepository.GetById(id);
            if (p == null)
                return null;

            var productvm = new ProductViewModel()
            {
                Id = p.Id,
                Name = p.Name,
                CategoryId = p.CategoryId,
                Brand = p.Brand,
                CategoryName = p.Category == null ? "" : p.Category.Name,
                LongDescription = p.LongDescription,
                PicturePath = p.PicturePath,
                Price = p.Price,
                ShortDescription = p.ShortDescription,
                Stock = p.Stock,
                Unit = p.Unit
            };
            return productvm;
        }

        public (bool, string) Create(ProductViewModel model)
        {
            try
            {
                var product = new Product()
                {
                    Name = model.Name,
                    CategoryId = model.CategoryId,
                    Brand = model.Brand,
                    LongDescription = model.LongDescription,
                    PicturePath = model.PicturePath,
                    Price = model.Price,
                    ShortDescription = model.ShortDescription,
                    Stock = model.Stock,
                    Unit = model.Unit
                };

                return productRepository.Create(product);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool, string) Edit(ProductViewModel model)
        {
            try
            {
                var existing = productRepository.GetById(model.Id);
                if (existing == null)
                {
                    return (false, "Record does not exists");
                }
                else
                {
                    existing.Name = model.Name;
                    existing.CategoryId = model.CategoryId;
                    existing.Brand = model.Brand;
                    existing.LongDescription = model.LongDescription;
                    existing.PicturePath = model.PicturePath;
                    existing.Price = model.Price;
                    existing.ShortDescription = model.ShortDescription;
                    existing.Stock = model.Stock;
                    existing.Unit = model.Unit;

                    return productRepository.Edit(existing);
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool, string) Delete(int id)
        {
            try
            {
                var existing = productRepository.GetById(id);
                if (existing == null)
                {
                    return (false, "Record does not exists");
                }
                else
                {
                    return productRepository.Delete(existing);
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool, string) IncreaseStock(int productId, double stock)
        {
            try
            {
                try
                {
                    var existing = productRepository.GetById(productId);
                    if (existing == null)
                    {
                        return (false, "Record does not exists");
                    }
                    else
                    {
                        existing.Stock = stock;

                        return productRepository.Edit(existing);
                    }
                }
                catch (Exception ex)
                {
                    return (false, ex.Message);
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}