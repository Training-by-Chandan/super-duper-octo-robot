using AutoMapper;
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
        private readonly IMapper mapper;

        public ProductService(
            IProductRepository productRepository,
            IMapper mapper
            )
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }

        public List<ProductViewModel> GetAll()
        {
            var data = productRepository.GetAll();

            var ret = mapper.Map<List<Product>, List<ProductViewModel>>(data.ToList());

            return ret;
        }

        public ProductViewModel? GetById(int id)
        {
            var p = productRepository.GetById(id);
            if (p == null)
                return null;

            var productvm = mapper.Map<Product, ProductViewModel>(p);
            return productvm;
        }

        public (bool, string) Create(ProductViewModel model)
        {
            try
            {
                var product = mapper.Map<ProductViewModel, Product>(model);

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
                    existing = mapper.Map<ProductViewModel, Product>(model, existing);

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