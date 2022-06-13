using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models.Motherboard;
using hightqual_it_backend.Tools;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace hightqual_it_backend.Repositories.Motherboard;

public class MemoryRepository : BaseRepository, IRepository<Memory>
{
    public MemoryRepository(DataContext dataContext) : base(dataContext)
    {
    }

    public bool Save(Memory element)
    {
        _dataContext.Memories.Add(element);
        return _dataContext.SaveChanges() > 0;
    }

    public bool Update(Memory element)
    {
        _dataContext.Memories.Update(element);
        return _dataContext.SaveChanges() > 0;
    }

    public Memory FindById(int id)
    {
        return _dataContext.Memories.Find(id);
    }

    public IEnumerable<Memory> Search(Expression<Func<Memory, bool>> predicate)
    {
        return _dataContext.Memories.Where(predicate);
    }

    public Memory SearchOne(Expression<Func<Memory, bool>> searchMethod)
    {
        return _dataContext.Memories.FirstOrDefault(searchMethod);
    }

    public IEnumerable<Memory> GetAll()
    {
        var memories = _dataContext.Memories;
        return memories;
    }

    public bool Delete(Memory element)
    {
        _dataContext.Memories.Remove(element);
        return _dataContext.SaveChanges() > 0;
    }

    public Memory FindByRef(string reference)
    {
        throw new NotImplementedException();
    }

    public Memory FindByBestDeal(int nbVente)
    {
        throw new NotImplementedException();
    }

    public Memory AvgByRef(string reference)
    {
        throw new NotImplementedException();
    }
}