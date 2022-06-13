using System.Collections.Generic;
using AutoMapper;
using hightqual_it_backend.Dtos.Motherboard;
using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models.Detail;
using hightqual_it_backend.Models.Motherboard;

namespace hightqual_it_backend.Services.Motherboard;

public class HDiskService
{
    private IRepository<HardDisk> _hDiskRepo;
    private IRepository<Brand> _brandRepo;
    private readonly IMapper _mapper;

    public HDiskService(IRepository<HardDisk> hDiskRepository, IRepository<Brand> brandRepository,IMapper mapper)
    {
        _hDiskRepo = hDiskRepository;
        _brandRepo = brandRepository;
        _mapper = mapper;
    }

    #region Get Services

    public IEnumerable<HardDiskDto> GetHardDisks()
    {
        var hDisk = _hDiskRepo.GetAll();
        var hDiskDto = _mapper.Map<IEnumerable<HardDiskDto>>(hDisk);
        return hDiskDto;
    }

    public HardDisk GetHardDiskById(int id)
    {
        var hardDisk = _hDiskRepo.SearchOne(h => h.Id == id);
        return hardDisk;
    }

    #endregion

    #region Post Services

    public HardDiskDto AddHDisk(HardDiskDto hardDiskDto)
    {
        // TODO - IMPLEMENTER LA METHOD (COMPUTER MISSING)
        var researchBrand = _brandRepo.SearchOne(b => b.Name == hardDiskDto.Brand.Name);
        var newHDisk = _mapper.Map<HardDisk>(hardDiskDto);

        if (researchBrand != null)
        {
            newHDisk.Capacity = hardDiskDto.Capacity;
            newHDisk.Type = hardDiskDto.Type;
            newHDisk.IsExternal = hardDiskDto.IsExternal;
            newHDisk.Brand = researchBrand;
            newHDisk.Computer = null;
        }

        var newHDiskDto = _mapper.Map<HardDiskDto>(newHDisk);
        _hDiskRepo.Save(newHDisk);
        return newHDiskDto;
    }

    #endregion

    #region Delete Services

    public bool DelDisk(int id)
    {
        var researchDisk = GetHardDiskById(id);
        if (researchDisk != null)
        {
            _hDiskRepo.Delete(researchDisk);
            return true;
        }
        return false;
    }

    #endregion
}