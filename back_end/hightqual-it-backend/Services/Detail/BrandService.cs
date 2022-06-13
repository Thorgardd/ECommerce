using AutoMapper;
using hightqual_it_backend.Dtos.Detail;
using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models.Detail;
using System.Collections.Generic;

namespace hightqual_it_backend.Services.Detail
{
    public class BrandService
    {
        private IRepository<Brand> _brandRepository;
        private readonly IMapper _mapper;
        public BrandService(IRepository<Brand> brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        public IEnumerable<BrandDto> GetBrands()
        {
            var brands = _brandRepository.GetAll();
            var brandsDto = _mapper.Map<IEnumerable<BrandDto>>(brands);
            return brandsDto;
        }

        public BrandDto GetBrandByRef(string reference)
        {
            var brands = _brandRepository.FindByRef(reference);
            var brandDto = _mapper.Map<BrandDto>(brands);
            return brandDto;
        }

        public Brand GetBrandByReference(BrandDto reference)
        {
            var brands = _brandRepository.FindByRef(reference.Name);
            //var brandDto = _mapper.Map<BrandDto>(brands);
            return brands;
        }

        public Brand AddBrand(BrandDto brandDto)
        {
            var newBrand = _mapper.Map<Brand>(brandDto);
            _brandRepository.Save(newBrand);
            return newBrand;
        }

        //public BrandDto SearchByRef(string name)
        //{
        //    var newBrand = _brandRepository.SearchOne(b => b.Name == name);
        //    if (newBrand == null)
        //    {
        //        //var bDto = _mapper.Map<BrandDto>(newBrand);
        //        //return bDto;
        //    }
        //    return default(BrandDto);
        //}
    }
}
