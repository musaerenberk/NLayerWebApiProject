using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.IUnitofWork
{
    public interface IUnitofWork
    {
        Task CommitAsync();
        void Commit();
    }
}
