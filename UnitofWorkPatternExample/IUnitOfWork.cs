using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitofWorkPatternExample
{
    public interface IUnitOfWork
    {
        IGenericRepository<Model> ModelRepository { get; }
        void Save();
    }
}
