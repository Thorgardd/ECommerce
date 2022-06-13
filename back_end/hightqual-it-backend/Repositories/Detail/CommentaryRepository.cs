using hightqual_it_backend.Dtos;
using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models.Detail;
using hightqual_it_backend.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace hightqual_it_backend.Repositories.Detail
{
    public class CommentaryRepository : BaseRepository, IRepository<Commentary>
    {
        public CommentaryRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public bool Delete(Commentary element)
        {
            _dataContext.Remove(element);
            return _dataContext.SaveChanges() > 0;
        }


        public Commentary FindById(int id)
        {
            return _dataContext.Commentaries.Find(id);
        }

        public Commentary FindByRef(string reference)
        {
            return _dataContext.Commentaries.FirstOrDefault(c => c.Content == reference);
        }

        public IEnumerable<Commentary> GetAll()
        {
            return _dataContext.Commentaries;
        }

        public bool Save(Commentary element)
        {
            _dataContext.Commentaries.Add(element);
            return _dataContext.SaveChanges() > 0;
        }

        public IEnumerable<Commentary> Search(Expression<Func<Commentary, bool>> predicate)
        {
            return _dataContext.Commentaries.Where(predicate);
        }

        public Commentary SearchOne(Expression<Func<Commentary, bool>> searchMethod)
        {
            return _dataContext.Commentaries.FirstOrDefault(searchMethod);
        }

        public bool Update(Commentary element)
        {
            _dataContext.Update(element);
            return _dataContext.SaveChanges() > 0;
        }

        Commentary IRepository<Commentary>.AvgByRef(string reference)
        {
            throw new NotImplementedException();
        }
    }
}

