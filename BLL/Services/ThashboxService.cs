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
        List<int> trashboxDTOs = new List<int>();
        ProductRepository rep = new ProductRepository();
        public void AddToTrashbox(int ProductId)
        {
            for (int i = 0; i < rep.productlist.Count; i++)
            {
                rep.productlist[i].ProductId = ProductId;
                {
                    trashboxDTOs.Add(rep.productlist[i].ProductId);
                }
            }
        }

        public void DeleteToTrashbox(int ProductId)
        {
            for (int i = 0; i < rep.productlist[i].Count; i++)
            {
                rep.productlist[i].ProductId = ProductId;
                {
                    trashboxDTOs.Remove(rep.productlist[i].ProductId);
                }
            }

        }

        public int GetSum()
        {
            int temp = 0;
            for(int i = 0; i< trashboxDTOs.Count; i++)
            {
                foreach(var p in rep.productlist)
                {
                    if(trashboxDTOs[i] == p.ProductId)
                    {
                        temp += Convert.ToInt32(p.Cost);
                    }
                }
            }
            return temp;
        }
    }
}
