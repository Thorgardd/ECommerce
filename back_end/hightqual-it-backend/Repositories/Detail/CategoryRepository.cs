using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models.Logistic;
using hightqual_it_backend.Tools;

namespace hightqual_it_backend.Repositories.Detail;

public class CategoryRepository : BaseRepository,IRepository<Category>
{
    public CategoryRepository(DataContext dataContext) : base(dataContext)
    {
    }

    public bool Save(Category element)
    {
        throw new NotImplementedException();
    }

    public bool Update(Category element)
    {
        throw new NotImplementedException();
    }

    public Category FindById(int id)
    {
        throw new NotImplementedException();
    }

    public Category FindByRef(string reference)
    {
        throw new NotImplementedException();
    }

    public Category FindByBestDeal(int nbVente)
    {
        throw new NotImplementedException();
    }

    public Category AvgByRef(string reference)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Category> Search(Expression<Func<Category, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Category SearchOne(Expression<Func<Category, bool>> searchMethod)
    {
        return _dataContext.Categories.FirstOrDefault(searchMethod);
    }

    public IEnumerable<Category> GetAll()
    {
        return _dataContext.Categories;
    }

    public bool Delete(Category element)
    {
        throw new NotImplementedException();
    }
}