using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class TrashboxDTO
    {
        public Guid TrashboxId { get; set; }
        public int Sum { get; set; }

        public List<ProductDTO> Product { get; set; }
        public Guid UserId { get; set; }
    }
}
