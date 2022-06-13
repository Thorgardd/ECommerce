using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models.Motherboard;
using hightqual_it_backend.Tools;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace hightqual_it_backend.Repositories.Motherboard
{
    public class OsRepository : BaseRepository, IRepository<Os>
    {
        public OsRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public bool Delete(Os element)
        {
            _dataContext.Oss.Remove(element);
            return _dataContext.SaveChanges() > 0;
        }

        public Os FindById(int id)
        {
            return _dataContext.Oss.Find(id);
        }

        public Os FindByRef(string reference)
        {
            throw new NotImplementedException();
        }

        public Os FindByBestDeal(int nbVente)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Os> GetAll()
        {

            var oss = _dataContext.Oss;
            return oss;

            //return _dataContext.Oss.Select(o => new Os()
            //{
            //    Name = o.Name,
            //    Version = o.Version,
            //});
        }

        public bool Save(Os element)
        {
            _dataContext.Oss.Add(element);
            return _dataContext.SaveChanges() > 0;
        }

        public IEnumerable<Os> Search(Expression<Func<Os, bool>> predicate)
        {
            return _dataContext.Oss.Where(predicate);
        }

        public Os SearchOne(Expression<Func<Os, bool>> searchMethod)
        {
            return _dataContext.Oss.FirstOrDefault(searchMethod);
        }

        public bool Update(Os element)
        {
            _dataContext.Oss.Update(element);
            return _dataContext.SaveChanges() > 0;
        }

        Os IRepository<Os>.AvgByRef(string reference)
        {
            throw new NotImplementedException();
        }
    }
}
