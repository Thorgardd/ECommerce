using System;
using System.Collections.Generic;
using AutoMapper;
using hightqual_it_backend.Dtos.Detail;
using hightqual_it_backend.Dtos.Motherboard;
using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models.Detail;
using hightqual_it_backend.Models.Motherboard;

namespace hightqual_it_backend.Services.Motherboard;

public class CpuService
{
    private IRepository<Cpu> _cpuRepo;
    private IRepository<Brand> _brandRepo;
    private IRepository<Memory> _memoryRepo;
    private readonly IMapper _mapper;
    
    public CpuService(IRepository<Cpu> cpuRepository, IMapper mapper, 
        IRepository<Brand> brandRepository, IRepository<Memory> memoryRepository)
    {
        _cpuRepo = cpuRepository;
        _memoryRepo = memoryRepository;
        _brandRepo = brandRepository;
        _mapper = mapper;
    }

    #region Get Services

    public IEnumerable<CpuDto> GetCpu()
    {
        var cpus = _cpuRepo.GetAll();
        var cpusDto = _mapper.Map<IEnumerable<CpuDto>>(cpus);
        return cpusDto;
    }

    public Cpu GetCpuByName(string name)
    {
        var cpu = _cpuRepo.SearchOne(c => c.Model == name);
        return cpu;
    }
    
    public IEnumerable<Cpu> GetCpuByNames(string name)
    {
        var cpus = _cpuRepo.Search(c => c.Model.Contains(name));
        return cpus;
    }

    #endregion

    #region Post Services

    public CpuDto AddCpu(CpuDto cpusDto)
    {
        var researchBrand = _brandRepo.SearchOne(b => b.Name == cpusDto.Brand.Name);
        var researchMemory = _memoryRepo.SearchOne(b => b.Model == cpusDto.CpuMemory.Model);
        var newCpu = _mapper.Map<Cpu>(cpusDto);
        
        if (researchBrand != null && researchMemory != null)
        {
            newCpu.Brand = researchBrand;
            newCpu.Frequency = cpusDto.Frequency;
            newCpu.CpuMemory = researchMemory;
            newCpu.NbCore = cpusDto.NbCore;
        }
        
        var newCpuDto = _mapper.Map<CpuDto>(newCpu);
        _cpuRepo.Save(newCpu);
        return newCpuDto;
    }

    #endregion

    #region Delete Services

    public bool DelCpu(string name)
    {
        var cpuResearch = GetCpuByName(name);
        if (cpuResearch != null)
        {
            _cpuRepo.Delete(cpuResearch);
            return true;
        }
        return false;
    }

    #endregion
}