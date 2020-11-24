using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IAccess<T>
    {
        void Add(T obj);

        void Update(T obj);

        void Remove(T obj);

        List<T> GetList();
    }
}
