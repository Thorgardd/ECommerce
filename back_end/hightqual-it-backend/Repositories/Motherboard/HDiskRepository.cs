using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models.Motherboard;
using hightqual_it_backend.Tools;

namespace hightqual_it_backend.Repositories.Motherboard;

public class HDiskRepository : BaseRepository, IRepository<HardDisk>
{
    public HDiskRepository(DataContext dataContext) : base(dataContext)
    {
    }

    public bool Save(HardDisk element)
    {
        _dataContext.HardDisks.Add(element);
        return _dataContext.SaveChanges() > 0;
    }

    public bool Update(HardDisk element)
    {
        _dataContext.HardDisks.Update(element);
        return _dataContext.SaveChanges() > 0;
    }

    public HardDisk FindById(int id)
    {
        return _dataContext.HardDisks.Find(id);
    }

    public IEnumerable<HardDisk> Search(Expression<Func<HardDisk, bool>> predicate)
    {
        return _dataContext.HardDisks.Where(predicate);
    }

    public HardDisk SearchOne(Expression<Func<HardDisk, bool>> searchMethod)
    {
        return _dataContext.HardDisks.FirstOrDefault(searchMethod);
    }

    public IEnumerable<HardDisk> GetAll()
    {
        var hardDisk = _dataContext.HardDisks;
        return hardDisk;
    }

    public bool Delete(HardDisk element)
    {
        _dataContext.HardDisks.Remove(element);
        return _dataContext.SaveChanges() > 0;
    }

    public HardDisk FindByRef(string reference)
    {
        throw new NotImplementedException();
    }

    public HardDisk FindByBestDeal(int nbVente)
    {
        throw new NotImplementedException();
    }

    public HardDisk AvgByRef(string reference)
    {
        throw new NotImplementedException();
    }
}