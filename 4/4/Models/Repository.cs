using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace _4.Models
{
    public class Repository : IRepository<Data>
    {
        private ApplicationContext db;
        public Repository()
        {
            this.db = new ApplicationContext();
        }

        public Data Find(int id)
        {
            return db.Data.Find(id);
        }

        public void Create(Data item)
        {
            db.Data.Add(item);
        }

        public void Delete(Data item)
        {
            db.Entry(item).State = EntityState.Deleted;
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public Data GetDirectory(int id)
        {
            return db.Data.Find(id);
        }

        public IEnumerable<Data> GetDirectoryList()
        {
            return db.Data;
        }

        public bool Save()
        {
            try
            {
                db.SaveChanges();
                return true;

            }
            catch (Exception e)
            {
                return false;
            }

        }

        public void Update(Data item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}