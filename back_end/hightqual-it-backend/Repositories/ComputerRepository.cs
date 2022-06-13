using hightqual_it_backend.Models;
using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Tools;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace hightqual_it_backend.Repositories
{
    public class ComputerRepository : BaseRepository, IRepository<Computer>
    {
        public ComputerRepository(DataContext dataContext) : base(dataContext)
        {

        }

        public bool Save(Computer element)
        {
            _dataContext.Computers.Add(element);
            return _dataContext.SaveChanges() > 0;
        }

        Computer IRepository<Computer>.AvgByRef(string reference)
        {
            throw new NotImplementedException();
        }

        bool IRepository<Computer>.Delete(Computer element)
        {
            throw new NotImplementedException();
        }

        Computer IRepository<Computer>.FindById(int id)
        {
            throw new NotImplementedException();
        }

        Computer  IRepository<Computer>.FindByRef(string reference)
        {
            return _dataContext.Computers.Include(c => c.Brand).Include(c => c.Cpu).Include(c => c.PowerSupply).Include(c => c.Mouse).Include(c => c.Screen)
                .Include(c => c.Sound).Include(c => c.Category).Include(c => c.Stock).Include(c => c.CriticalStock).Include(c => c.Ranks).Include(c => c.Colors)
                .Include(c => c.HardDisks).Include(c => c.GraphProds).Include(c => c.Memories).Include(c => c.Images).Include(c => c.Commentaries).Include(c=> c.Os)
                .FirstOrDefault(c => c.Reference == reference);
        }
        //Computer  IRepository<Computer>.FindByBestDeal(int nbVente)
        //{
        //    return _dataContext.Computers.Include(c => c.Brand).Include(c => c.Cpu).Include(c => c.PowerSupply).Include(c => c.Mouse).Include(c => c.Screen)
        //        .Include(c => c.Sound).Include(c => c.Category).Include(c => c.Stock).Include(c => c.CriticalStock).Include(c => c.Ranks).Include(c => c.Colors)
        //        .Include(c => c.HardDisks).Include(c => c.GraphProds).Include(c => c.Memories).Include(c => c.Images).Include(c => c.Commentaries).Include(c=> c.Os).Include(c=> c.Reference)
        //        .FirstOrDefault(c => c.NbVente == nbVente);
        //}

        IEnumerable<Computer> IRepository<Computer>.GetAll()
        {
            return _dataContext.Computers.Include(c => c.Brand).Include(c => c.Cpu).ThenInclude(cpu => cpu.Brand)
                .Include(c => c.Os).Include(c => c.Mouse).ThenInclude(m => m.Brand).Include(c => c.Screen).ThenInclude(s => s.Brand)
                .Include(c => c.PowerSupply).ThenInclude(pS => pS.Brand).Include(c => c.Sound).ThenInclude(s => s.Brand)
                .Include(c => c.Category).Include(c => c.Commentaries).Include(c => c.Stock).Include(c => c.Ranks);
        }

        IEnumerable<Computer> IRepository<Computer>.Search(Expression<Func<Computer, bool>> predicate)
        {
            throw new NotImplementedException();  
        }

        Computer IRepository<Computer>.SearchOne(Expression<Func<Computer, bool>> searchMethod)
        {
            return _dataContext.Computers.FirstOrDefault(searchMethod);
        }

        bool IRepository<Computer>.Update(Computer element)
        {
            throw new NotImplementedException();
        }
    }
}
