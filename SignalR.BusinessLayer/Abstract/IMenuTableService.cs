using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Abstract
{
    public interface IMenuTableService:IGenericService<MenuTable>
    {
        int TMenuTableCount();
    }
}
