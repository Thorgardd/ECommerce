using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models.Motherboard;
using hightqual_it_backend.Tools;

namespace hightqual_it_backend.Repositories.Device;

public class ConnectorRepository : BaseRepository, IRepository<Connector>
{
    public ConnectorRepository(DataContext dataContext) : base(dataContext)
    {
    }

    public bool Save(Connector element)
    {
        _dataContext.Connectors.Add(element);
        return _dataContext.SaveChanges() > 0;
    }

    public bool Update(Connector element)
    {
        _dataContext.Connectors.Update(element);
        return _dataContext.SaveChanges() > 0;
    }

    public Connector FindById(int id)
    {
        return _dataContext.Connectors.Find(id);
    }

    public IEnumerable<Connector> Search(Expression<Func<Connector, bool>> predicate)
    {
        return _dataContext.Connectors.Where(predicate);
    }

    public Connector SearchOne(Expression<Func<Connector, bool>> searchMethod)
    {
        return _dataContext.Connectors.FirstOrDefault(searchMethod);
    }

    public IEnumerable<Connector> GetAll()
    {
        var connectors = _dataContext.Connectors;
        return connectors;
    }

    public bool Delete(Connector element)
    {
        _dataContext.Connectors.Remove(element);
        return _dataContext.SaveChanges() > 0;
    }

    public Connector FindByRef(string reference)
    {
        throw new NotImplementedException();
    }

    public Connector FindByBestDeal(int nbVente)
    {
        throw new NotImplementedException();
    }

    public Connector AvgByRef(string reference)
    {
        throw new NotImplementedException();
    }
}