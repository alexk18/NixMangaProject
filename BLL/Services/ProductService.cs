using System;
using BLL.Interfaces;
using BLL.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace BLL.Services
{
    public class ProductService : IProductService
    {
        List<ProductDTO> product = new List<ProductDTO>()
        {
            new ProductDTO(1, "Test", "DESC", 10, 5),
            new ProductDTO(2, "Test", "DESC", 20, 5),
            new ProductDTO(3, "Test", "DESC", 15, 5)
        };
        public void DeleteProduct(int id)
        {
            foreach (var item in product)
            {
                if (item.ProductId == id)
                {
                    product.Remove(item);
                }
            }
        }

        public void DescriptionChange(string newdescription, int id)
        {
            foreach (var item in product)
            {
                if (item.ProductId == id)
                {
                    item.Description = newdescription;
                }
            }
        }

        public List<ProductDTO> FindById(int id)
        {
            var temp = new List<ProductDTO>();
            temp = (from products in product where products.ProductId == id select products).ToList();
            return temp;
        }

        public List<ProductDTO> FindByName(string name)
        {
            var temp = new List<ProductDTO>();
            temp = (from products in product where products.Name == name select products).ToList();
            return temp;
        }

        public void Sale(double sale, int i)
        {
            foreach (var item in product)
            {
                if (item.ProductId == i)
                {
                    item.Cost = Convert.ToUInt32(item.Cost * sale);
                }
            }
        }
    }
}
