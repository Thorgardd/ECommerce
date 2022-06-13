using AutoMapper;
using hightqual_it_backend.Dtos.Motherboard;
using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models.Motherboard;
using System.Collections.Generic;
using hightqual_it_backend.Models.Detail;
using Microsoft.AspNetCore.Mvc;

namespace hightqual_it_backend.Services.Motherboard
{
    public class OsService
    {
        private IRepository<Os> _osRepository;
        private IMapper _mapper;
        public OsService(IRepository<Os> osRepository,IMapper mapper)
        {
            _osRepository = osRepository;
            _mapper = mapper;
        }

        #region Get Services
        
        public IEnumerable<OsDto> GetAll()
        {
            var oss = _osRepository.GetAll();
            var ossDto = _mapper.Map<IEnumerable<OsDto>>(oss);
            return ossDto;
        }

        public Os GetOsByVersion(string version)
        {
            var os = _osRepository.SearchOne(o => o.Version == version);
            return os;
        }

        public IEnumerable<Os> GetOsByName(string name)
        {
            var oss = _osRepository.Search(s => s.Name == name);
            return oss;
        }
        
        #endregion

        #region Post Services

        public OsDto AddOs(OsDto osDto)
        {
            var newOs = _mapper.Map<Os>(osDto);

            if (osDto != null)
            {
                newOs.Name = osDto.Name;
                newOs.Version = osDto.Version;
            }

            var newOsDto = _mapper.Map<OsDto>(newOs);
            _osRepository.Save(newOs);
            return newOsDto;
        }

        #endregion

        #region Delete Services

        [HttpDelete]
        public bool DelOs(string version)
        {
            var osSearch = GetOsByVersion(version);
            if (osSearch != null)
            {
                _osRepository.Delete(osSearch);
                return true;
            }
            return false;
        }

        #endregion
    }
}
