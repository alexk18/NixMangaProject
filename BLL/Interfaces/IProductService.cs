using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using DataLayer;

namespace BLL.Interfaces
{
    public interface IProductService
    {
        List<Product> FindByName(string name);
        List<Product> FindById(int id);
        void DeleteProduct(int id);
        void DescriptionChange(string newdescription, int i);
        void Sale(double sale, int id);
    }
}
