using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models.Motherboard;
using hightqual_it_backend.Tools;

namespace hightqual_it_backend.Repositories.Motherboard;

public class GProductRepository : BaseRepository, IRepository<GraphicProduct>
{
    public GProductRepository(DataContext dataContext) : base(dataContext)
    {
    }

    public bool Save(GraphicProduct element)
    {
        _dataContext.GraphicProducts.Add(element);
        return _dataContext.SaveChanges() > 0;
    }

    public bool Update(GraphicProduct element)
    {
        _dataContext.GraphicProducts.Update(element);
        return _dataContext.SaveChanges() > 0;
    }

    public GraphicProduct FindById(int id)
    {
        return _dataContext.GraphicProducts.Find(id);
    }

    public IEnumerable<GraphicProduct> Search(Expression<Func<GraphicProduct, bool>> predicate)
    {
        return _dataContext.GraphicProducts.Where(predicate);
    }

    public GraphicProduct SearchOne(Expression<Func<GraphicProduct, bool>> searchMethod)
    {
        return _dataContext.GraphicProducts.FirstOrDefault(searchMethod);
    }

    public IEnumerable<GraphicProduct> GetAll()
    {
        var gProd = _dataContext.GraphicProducts;
        return gProd;
    }

    public bool Delete(GraphicProduct element)
    {
        _dataContext.GraphicProducts.Remove(element);
        return _dataContext.SaveChanges() > 0;
    }

    public GraphicProduct FindByRef(string reference)
    {
        throw new NotImplementedException();
    }

    public GraphicProduct FindByBestDeal(int nbVente)
    {
        throw new NotImplementedException();
    }

    public GraphicProduct AvgByRef(string reference)
    {
        throw new NotImplementedException();
    }
}