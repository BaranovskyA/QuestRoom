using DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuestRoomCatalog.DataLayer.UnitOfWork;

namespace QuestRoomCatalog.DataLayer.UnitOfWork
{
    public class UnitOfWork<T> : IDisposable, IUnitOfWork<T> where T:class
    {
        private Model1 db;
        private bool disposed = false;
        Repository<T> _genericRepository;

        public Repository<T> GenericUowRepository
        {
            get
            {
                if (this._genericRepository == null)
                    _genericRepository = new Repository<T>(db);
                return _genericRepository;
            }
        }

        public UnitOfWork()
        {
            db = new Model1();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void BeginTransaction()
        {
            db.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            db.Database.CurrentTransaction.Commit();
        }
        protected virtual void Dispose(bool disposing)
        {
            if(this.disposed)
            {
                if(disposing)
                {
                    if(db != null)
                    {
                        db.Dispose();
                    }
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}