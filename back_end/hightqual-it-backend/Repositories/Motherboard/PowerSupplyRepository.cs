using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models.Motherboard;
using hightqual_it_backend.Tools;
using Microsoft.EntityFrameworkCore;

namespace hightqual_it_backend.Repositories.Motherboard;

public class PowerSupplyRepository : BaseRepository, IRepository<PowerSupply>
{
    public PowerSupplyRepository(DataContext dataContext) : base(dataContext)
    {
    }

    public bool Save(PowerSupply element)
    {
        _dataContext.PowerSupplies.Add(element);
        return _dataContext.SaveChanges() > 0;
    }

    public bool Update(PowerSupply element)
    {
        _dataContext.PowerSupplies.Update(element);
        return _dataContext.SaveChanges() > 0;
    }

    public PowerSupply FindById(int id)
    {
        return _dataContext.PowerSupplies.Find(id);
    }

    public IEnumerable<PowerSupply> Search(Expression<Func<PowerSupply, bool>> predicate)
    {
        return _dataContext.PowerSupplies.Include(p => p.Category).Where(predicate);
    }

    public PowerSupply SearchOne(Expression<Func<PowerSupply, bool>> searchMethod)
    {
        return _dataContext.PowerSupplies.Include(p => p.Category).FirstOrDefault(searchMethod);
    }

    public IEnumerable<PowerSupply> GetAll()
    {
        var power = _dataContext.PowerSupplies;
        return power;
    }

    public bool Delete(PowerSupply element)
    {
        _dataContext.PowerSupplies.Remove(element);
        return _dataContext.SaveChanges() > 0;
    }

    public PowerSupply FindByRef(string reference)
    {
        throw new NotImplementedException();
    }

    public PowerSupply FindByBestDeal(int nbVente)
    {
        throw new NotImplementedException();
    }

    public PowerSupply AvgByRef(string reference)
    {
        throw new NotImplementedException();
    }
}