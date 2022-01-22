using System;
using BLL.Interfaces;
using BLL.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using DataLayer;

namespace BLL.Services
{
    public class ProductService : IProductService
    {
        ProductRepository rep = new ProductRepository();

        public void DeleteProduct(int id)
        {
            foreach (var item in rep.productlist )
            {
                if (item.ProductId == id)
                {
                    rep.productlist.Remove(item);
                }
            }
        }

        public void DescriptionChange(string newdescription, int id)
        {
            foreach (var item in rep.productlist)
            {
                if (item.ProductId == id)
                {
                    item.Description = newdescription;
                }
            }
        }

        public List<Product> FindById(int id)
        {
            var temp = new List<Product>();
            temp = (from products in rep.productlist where products.ProductId == id select products).ToList();
            return temp;
        }

        public List<Product> FindByName(string name)
        {
            var temp = new List<Product>();
            temp = (from products in rep.productlist where products.Name == name select products).ToList();
            return temp;
        }

        public void Sale(double sale, int i)
        {
            foreach (var item in rep.productlist)
            {
                if (item.ProductId == i)
                {
                    item.Cost = Convert.ToUInt32(item.Cost * sale);
                }
            }
        }
    }
}
