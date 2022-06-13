using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models.Detail;
using hightqual_it_backend.Tools;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace hightqual_it_backend.Repositories.Detail
{
    public class ImageRepository : BaseRepository, IRepository<Image>
    {
        public ImageRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public Image FindByBestDeal(int nbVente)
        {
            throw new NotImplementedException();
        }

        public Image AvgByRef(string reference)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Image element)
        {
            _dataContext.Remove(element);
            return _dataContext.SaveChanges() > 0;
        }

        public Image FindById(int id)
        {
            return _dataContext.Images.Find(id);
        }

        public Image FindByRef(string reference)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Image> GetAll()
        {
            return _dataContext.Images;
        }

        public bool Save(Image element)
        {
            _dataContext.Add(element);
            return _dataContext.SaveChanges() > 0;
        }

        public IEnumerable<Image> Search(Expression<Func<Image, bool>> predicate)
        {
            return _dataContext.Images.Where(predicate);
        }

        public Image SearchOne(Expression<Func<Image, bool>> searchMethod)
        {
            return _dataContext.Images.FirstOrDefault(searchMethod);
        }

        public bool Update(Image element)
        {
            _dataContext.Images.Update(element);
            return _dataContext.SaveChanges() > 0;
        }
    }
}
