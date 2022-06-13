using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models.Device;
using hightqual_it_backend.Tools;

namespace hightqual_it_backend.Repositories.Device;

public class ScreenRepository : BaseRepository, IRepository<Screen>
{
    public ScreenRepository(DataContext dataContext) : base(dataContext)
    {
    }

    public bool Save(Screen element)
    {
        _dataContext.Screens.Add(element);
        return _dataContext.SaveChanges() > 0;
    }

    public bool Update(Screen element)
    {
        _dataContext.Screens.Update(element);
        return _dataContext.SaveChanges() > 0;
    }

    public Screen FindById(int id)
    {
        return _dataContext.Screens.Find(id);
    }

    public IEnumerable<Screen> Search(Expression<Func<Screen, bool>> predicate)
    {
        return _dataContext.Screens.Where(predicate);
    }

    public Screen SearchOne(Expression<Func<Screen, bool>> searchMethod)
    {
        return _dataContext.Screens.FirstOrDefault(searchMethod);
    }

    public IEnumerable<Screen> GetAll()
    {
        var allScreen = _dataContext.Screens;
        return allScreen;
    }

    public bool Delete(Screen element)
    {
        _dataContext.Screens.Remove(element);
        return _dataContext.SaveChanges() > 0;
    }

    public Screen FindByRef(string reference)
    {
        throw new NotImplementedException();
    }

    public Screen FindByBestDeal(int nbVente)
    {
        throw new NotImplementedException();
    }

    public Screen AvgByRef(string reference)
    {
        throw new NotImplementedException();
    }
}