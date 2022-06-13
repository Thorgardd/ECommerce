using hightqual_it_backend.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace hightqual_it_backend.Interfaces
{
    public interface IRepository<T>
    {
        bool Save(T element);
        bool Update(T element);
        T FindById(int id);
        T FindByRef(string reference);
        //T FindByBestDeal(int nbVente);

        T AvgByRef(string reference);
        IEnumerable<T> Search(Expression<Func<T, bool>> predicate);
        T SearchOne(Expression<Func<T, bool>> searchMethod);
        IEnumerable<T> GetAll();
        bool Delete(T element);
    }
}
