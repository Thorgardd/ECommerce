using System.Collections.Generic;
using AutoMapper;
using hightqual_it_backend.Dtos.Motherboard;
using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models.Detail;
using hightqual_it_backend.Models.Motherboard;

namespace hightqual_it_backend.Services.Motherboard;

public class MemoryService
{
    private IRepository<Memory> _memoRepo;
    private IRepository<Brand> _brandRepo;
    private readonly IMapper _mapper;

    public MemoryService(IRepository<Memory> memoRepository, IRepository<Brand> brandRepository,IMapper mapper)
    {
        _memoRepo = memoRepository;
        _brandRepo = brandRepository;
        _mapper = mapper;
    }

    #region Get Services

    public IEnumerable<MemoryDto> GetMemories()
    {
        var memories = _memoRepo.GetAll();
        var memoriesDto = _mapper.Map<IEnumerable<MemoryDto>>(memories);
        return memoriesDto;
    }

    public Memory GetMemoryByModel(string model)
    {
        var memory = _memoRepo.SearchOne(m => m.Model == model);
        return memory;
    }
    
    public IEnumerable<Memory> GetMemoryByModels(string model)
    {
        var memorys = _memoRepo.Search(m => m.Model.Contains(model));
        return memorys;
    }

    #endregion

    #region Post Services

    public MemoryDto AddMemory(MemoryDto memoryDto)
    {
        var researchBrand = _brandRepo.SearchOne(b => b.Name == memoryDto.Brand.Name);
        var newMemory = _mapper.Map<Memory>(memoryDto);

        if (researchBrand != null)
        {
            newMemory.Type = memoryDto.Type;
            newMemory.Model = memoryDto.Model;
            newMemory.Capacity = memoryDto.Capacity;
            newMemory.Frequency = memoryDto.Frequency;
            newMemory.Brand = researchBrand;
        }

        var newMemoryDto = _mapper.Map<MemoryDto>(newMemory);
        _memoRepo.Save(newMemory);
        return newMemoryDto;
    }

    #endregion

    #region Delete Services

    public bool DelMemory(string model)
    {
        var memoSearch = GetMemoryByModel(model);
        if (memoSearch != null)
        {
            _memoRepo.Delete(memoSearch);
            return true;
        }
        return false;
    }

    #endregion
}