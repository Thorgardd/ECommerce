using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models.Motherboard;
using hightqual_it_backend.Tools;
using Microsoft.EntityFrameworkCore;

namespace hightqual_it_backend.Repositories.Device;

public class SoundRepository : BaseRepository, IRepository<Sound>
{
    public SoundRepository(DataContext dataContext) : base(dataContext)
    {
    }

    public bool Save(Sound element)
    {
        _dataContext.Sounds.Add(element);
        return _dataContext.SaveChanges() > 0;
    }

    public bool Update(Sound element)
    {
        _dataContext.Sounds.Update(element);
        return _dataContext.SaveChanges() > 0;
    }

    public Sound FindById(int id)
    {
        return _dataContext.Sounds.Find(id);
    }

    public IEnumerable<Sound> Search(Expression<Func<Sound, bool>> predicate)
    {
        return _dataContext.Sounds.Include(s => s.Brand).Where(predicate);
    }

    public Sound SearchOne(Expression<Func<Sound, bool>> searchMethod)
    {
        return _dataContext.Sounds.Include(s => s.Brand).FirstOrDefault(searchMethod);
    }

    public IEnumerable<Sound> GetAll()
    {
        var sounds = _dataContext.Sounds.Include(s => s.Brand);
        return sounds;
    }

    public bool Delete(Sound element)
    {
        _dataContext.Sounds.Remove(element);
        return _dataContext.SaveChanges() > 0;
    }

    public Sound FindByRef(string reference)
    {
        throw new NotImplementedException();
    }

    public Sound FindByBestDeal(int nbVente)
    {
        throw new NotImplementedException();
    }

    public Sound AvgByRef(string reference)
    {
        throw new NotImplementedException();
    }
}