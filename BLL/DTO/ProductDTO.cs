using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class ProductDTO
    {
 
        public ProductDTO (int i, string a, string b, uint d, int c)
        {
            ProductId = i;
            Name = a;
            Description = b;
            Cost = d;
            Count = c;

        }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public uint Cost { get; set; }
        public int Count { get; set; }

        public bool Aviable
        {
            get { return Aviable; }
            private set
            {
                if (Count == 0)
                {
                    Aviable = false;
                }
                else
                {
                    Aviable = true;
                }
            }
        }
    }
}
