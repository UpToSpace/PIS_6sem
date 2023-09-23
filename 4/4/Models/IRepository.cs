using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _4.Models
{
    interface IRepository<T> : IDisposable
    where T : class
    {
        IEnumerable<T> GetDirectoryList();
        T GetDirectory(int id);
        T Find(int id);
        void Create(T item);
        void Update(T item);
        void Delete(T item);
        bool Save();
    }
}