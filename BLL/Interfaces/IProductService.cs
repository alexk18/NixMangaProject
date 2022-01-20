using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;

namespace BLL.Interfaces
{
    public interface IProductService
    {
        List<ProductDTO> FindByName(string name);
        List<ProductDTO> FindById(int id);
        void DeleteProduct(int id);
        void DescriptionChange(string newdescription, int i);
        void Sale(double sale, int id);
    }
}
