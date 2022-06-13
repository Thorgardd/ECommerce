using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models.Motherboard;
using hightqual_it_backend.Tools;

namespace hightqual_it_backend.Repositories.Motherboard;

public class CpuRepository : BaseRepository, IRepository<Cpu>
{
    public CpuRepository(DataContext dataContext) : base(dataContext)
    {
    }

    public bool Save(Cpu element)
    {
        _dataContext.Cpus.Add(element);
        return _dataContext.SaveChanges() > 0;
    }

    public bool Update(Cpu element)
    {
        _dataContext.Cpus.Update(element);
        return _dataContext.SaveChanges() > 0;
    }

    public Cpu FindById(int id)
    {
        return _dataContext.Cpus.Find(id);
    }

    public IEnumerable<Cpu> Search(Expression<Func<Cpu, bool>> predicate)
    {
        return _dataContext.Cpus.Where(predicate);
    }

    public Cpu SearchOne(Expression<Func<Cpu, bool>> searchMethod)
    {
        return _dataContext.Cpus.FirstOrDefault(searchMethod);
    }

    public IEnumerable<Cpu> GetAll()
    {
        var cpu = _dataContext.Cpus;
        return cpu;
    }

    public bool Delete(Cpu element)
    {
        _dataContext.Cpus.Remove(element);
        return _dataContext.SaveChanges() > 0;
    }

    public Cpu FindByRef(string reference)
    {
        throw new NotImplementedException();
    }

    public Cpu FindByBestDeal(int nbVente)
    {
        throw new NotImplementedException();
    }

    public Cpu AvgByRef(string reference)
    {
        throw new NotImplementedException();
    }
}