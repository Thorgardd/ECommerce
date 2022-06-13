using System.Collections.Generic;
using AutoMapper;
using hightqual_it_backend.Dtos.Motherboard;
using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models.Detail;
using hightqual_it_backend.Models.Logistic;
using hightqual_it_backend.Models.Motherboard;

namespace hightqual_it_backend.Services.Motherboard;

public class PowerSupplyService
{
    private readonly IMapper _mapper;
    private IRepository<Brand> _brandRepo;
    private IRepository<Category> _catRepo;
    private IRepository<PowerSupply> _powerRepo;

    public PowerSupplyService(IRepository<PowerSupply> powerRepository,IRepository<Brand> brandRepository,
        IMapper mapper, IRepository<Category> catRepository)
    {
        _powerRepo = powerRepository;
        _catRepo = catRepository;
        _brandRepo = brandRepository;
        _mapper = mapper;
    }

    #region Get Services

    public IEnumerable<PowerSupplyDto> GetPowerSupplies()
    {
        var power = _powerRepo.GetAll();
        var powerDto = _mapper.Map<IEnumerable<PowerSupplyDto>>(power);
        return powerDto;
    }

    public PowerSupply GetPowerByPower(string powerParam)
    {
        var power = _powerRepo.SearchOne(p => p.Power == powerParam);
        return power;
    }

    public IEnumerable<PowerSupply> GetPowerByPowers(string search)
    {
        var powers = _powerRepo.Search(p => p.Power.Contains(search));
        return powers;
    }

    #endregion

    #region Post Services

    public PowerSupply AddPower(PowerSupplyDto powerSupplyDto)
    {
        var newSupply = _mapper.Map<PowerSupply>(powerSupplyDto);
        var researchedBrand = _brandRepo.SearchOne(b => b.Name == powerSupplyDto.Brand.Name);
        var researchedCateg = _catRepo.SearchOne(b => b.Name == powerSupplyDto.Category.Name);

        if (researchedBrand != null && researchedCateg != null)
        {
            newSupply.Power = powerSupplyDto.Power;
            newSupply.Brand = researchedBrand;
            newSupply.Category = researchedCateg;
        }
        _powerRepo.Save(newSupply);
        return newSupply;
    }

    #endregion

    #region Delete Services

    public bool DelPower(string power)
    {
        var searchPower = GetPowerByPower(power);
        if (searchPower != null)
        {
            _powerRepo.Delete(searchPower);
            return true;
        }
        return false;
    }

    #endregion
}