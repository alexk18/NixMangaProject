using BLL.DTO;
using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ThashboxService : ITrashboxService
    {
        List<ProductDTO> Tovari = new List<ProductDTO>()
        {
            new ProductDTO(1, "Test", "DESC", 10, 5),
            new ProductDTO(2, "Test", "DESC", 20, 5),
            new ProductDTO(3, "Test", "DESC", 15, 5)
        };
        List<int> TrashboxDTOs = new List<int>();
        public void AddToTrashbox(int ProductId)
        {
            for (int i = 0; i < Tovari.Count; i++)
            {
                Tovari[i].ProductId = ProductId;
                {
                    TrashboxDTOs.Add(Tovari[i].ProductId);
                }
            }
        }

        public void DeleteToTrashbox(int ProductId)
        {
            for (int i = 0; i < Tovari.Count; i++)
            {
                Tovari[i].ProductId = ProductId;
                {
                    TrashboxDTOs.Remove(Tovari[i].ProductId);
                }
            }

        }

        public int GetSum()
        {
            int temp = 0;
            for(int i = 0; i< TrashboxDTOs.Count; i++)
            {
                foreach(var p in Tovari)
                {
                    if(TrashboxDTOs[i] == p.ProductId)
                    {
                        temp += Convert.ToInt32(p.Cost);
                    }
                }
            }
            return temp;
        }
    }
}
