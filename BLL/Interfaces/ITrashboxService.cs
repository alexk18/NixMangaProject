using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ITrashboxService
    {
        void AddToTrashbox(int ProductId);
        void DeleteToTrashbox(int ProductId);
        int GetSum();
    }
}
