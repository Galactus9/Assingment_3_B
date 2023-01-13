using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_3_B.Data.Repository
{
    public interface IRepository<TEntity> 
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        void Add (TEntity entity);
        void Update (TEntity entity);
        bool Delete (int id);
    }
}
