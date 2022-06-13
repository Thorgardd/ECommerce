using hightqual_it_backend.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace hightqual_it_backend.Services
{
    public abstract class IComputerService
    {
        public abstract IEnumerable<ComputerDto> GetAll();
        public abstract ComputerDto FindByRef(string reference);
        //public abstract ComputerDto FindByBestDeal(int nbVente);

        public abstract decimal AvgByRef(string reference);
    }
}
