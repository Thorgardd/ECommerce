using AutoMapper;
using hightqual_it_backend.Dtos;
using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models;

using System.Collections.Generic;

using hightqual_it_backend.Models.Detail;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace hightqual_it_backend.Services
{
    public class ComputerService : IComputerService
    {
        private IRepository<Computer> _computerRepository;
        private IMapper _mapper;
        public ComputerService(IRepository<Computer> computerRepository, IMapper mapper)
        {
            _computerRepository = computerRepository;
            _mapper = mapper;
        }

        public override decimal AvgByRef(string reference)
        {
            List<Rank> ranks = _computerRepository.FindByRef(reference).Ranks;
            List<decimal> score = ranks.Select(r => r.Score).ToList();
            if (ranks.Count > 0)
                return score.Sum() / ranks.Count();
            return 0;
        }

        public override ComputerDto FindByRef(string reference)
        {
            var computer = _computerRepository.FindByRef(reference);
            var computerDto = _mapper.Map<ComputerDto>(computer);
            return computerDto;
        }
        
        //public override ComputerDto FindByBestDeal(int nbVente)
        //{
        //    var computer = _computerRepository.FindByBestDeal(nbVente);
        //    var computerDto = _mapper.Map<ComputerDto>(computer);
        //    return computerDto;
        //}

        public override IEnumerable<ComputerDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ComputerDto> GetComputer()
        {
            var computers = _computerRepository.GetAll();
            var computersDto = _mapper.Map<IEnumerable<ComputerDto>>(computers);
            return computersDto;
        }


    }
}
