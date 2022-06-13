using hightqual_it_backend.Dtos;
using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models.Detail;
using hightqual_it_backend.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace hightqual_it_backend.Repositories.Detail
{
    public class BrandRepository : BaseRepository, IRepository<Brand>
    {
        public BrandRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public bool Delete(Brand element)
        {
            _dataContext.Remove(element);
            return _dataContext.SaveChanges() > 0;
        }

        public Brand FindById(int id)
        {
            return _dataContext.Brands.Find(id);
        }

        public Brand FindByRef(string reference)
        {
            return _dataContext.Brands.FirstOrDefault(b => b.Name == reference);
        }

        public Brand FindByBestDeal(int nbVente)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Brand> GetAll()
        {
            return _dataContext.Brands;
        }

        public bool Save(Brand element)
        {
            _dataContext.Brands.Add(element);
            return _dataContext.SaveChanges() > 0;
        }

        public IEnumerable<Brand> Search(Expression<Func<Brand, bool>> predicate)
        {
            return _dataContext.Brands.Where(predicate);
        }

        public Brand SearchOne(Expression<Func<Brand, bool>> searchMethod)
        {
            return _dataContext.Brands.FirstOrDefault(searchMethod);
        }

        public bool Update(Brand element)
        {
            _dataContext.Update(element);
            return _dataContext.SaveChanges() > 0;
        }

        Brand IRepository<Brand>.AvgByRef(string reference)
        {
            throw new NotImplementedException();
        }
    }
}
