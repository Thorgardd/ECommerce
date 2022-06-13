using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models.Detail;
using hightqual_it_backend.Tools;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace hightqual_it_backend.Repositories.Detail
{
    public class ColorRepository : BaseRepository, IRepository<Color>
    {
        public ColorRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public Color FindByBestDeal(int nbVente)
        {
            throw new NotImplementedException();
        }

        public Color AvgByRef(string reference)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Color element)
        {
            _dataContext.Colors.Remove(element);
            return _dataContext.SaveChanges() > 0;
        }

        public Color FindById(int id)
        {
            return _dataContext.Colors.Find(id);
        }

        public Color FindByRef(string reference)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Color> GetAll()
        {
            return _dataContext.Colors.Include(c => c.Sample);
        }

        public bool Save(Color element)
        {
            _dataContext.Colors.Add(element);
            return _dataContext.SaveChanges() > 0;
        }

        public IEnumerable<Color> Search(Expression<Func<Color, bool>> predicate)
        {
            return _dataContext.Colors.Where(predicate);
        }

        public Color SearchOne(Expression<Func<Color, bool>> searchMethod)
        {
            return _dataContext.Colors.FirstOrDefault(searchMethod);
        }

        public bool Update(Color element)
        {
            _dataContext.Update(element);
            return _dataContext.SaveChanges() > 0;
        }
    }
}
