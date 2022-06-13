using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models.Device;
using hightqual_it_backend.Tools;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace hightqual_it_backend.Repositories.Device;

public class _mouseRepository : BaseRepository, IRepository<Mouse>
{
    public _mouseRepository(DataContext dataContext) : base(dataContext)
    {
    }

    public bool Save(Mouse element)
    {
        _dataContext.Mouses.Add(element);
        return _dataContext.SaveChanges() > 0;
    }

    public bool Update(Mouse element)
    {
        _dataContext.Mouses.Update(element);
        return _dataContext.SaveChanges() > 0;
    }

    public Mouse FindById(int id)
    {
        return _dataContext.Mouses.Include(b => b.Brand).FirstOrDefault(a => a.Id == id);
        
    }

    public IEnumerable<Mouse> Search(Expression<Func<Mouse, bool>> predicate)
    {
        return _dataContext.Mouses.Where(predicate).Include(b => b.Brand);
    }


    public Mouse SearchOne(Expression<Func<Mouse, bool>> searchMethod)
    {
        return _dataContext.Mouses.Include(b => b.Brand).FirstOrDefault(searchMethod);
    }

    public IEnumerable<Mouse> GetAll()
    {
        var mouses = _dataContext.Mouses.Include(b => b.Brand);
        return mouses;
    }

    public bool Delete(Mouse element)
    {
        _dataContext.Mouses.Remove(element);
        return _dataContext.SaveChanges() > 0;
    }

    internal static object FindByRef(string reference)
    {
        throw new NotImplementedException();
    }
    
    Mouse IRepository<Mouse>.FindByRef(string reference)
    {
        return _dataContext.Mouses.Include(c => c.Brand)
            .FirstOrDefault(c => c.Reference == reference);
    }

    public Mouse FindByBestDeal(int nbVente)
    {
        throw new NotImplementedException();
    }

    public Mouse AvgByRef(string reference)
    {
        throw new NotImplementedException();
    }
}