using System.Collections.Generic;
using AutoMapper;
using hightqual_it_backend.Dtos.Device;
using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models.Detail;
using hightqual_it_backend.Models.Device;

namespace hightqual_it_backend.Services.Device;

public class MouseService
{
    private readonly IMapper _mapper;
    private IRepository<Brand> _brandRepo;
    private IRepository<Mouse> _mouseRepo;

    public MouseService(IRepository<Mouse> mouseRepository, IRepository<Brand> brandRepository, IMapper mapper)
    {
        _mouseRepo = mouseRepository;
        _brandRepo = brandRepository;
        _mapper = mapper;
    }

    #region Get Services

    public IEnumerable<MouseDto> GetMouses()
    {
        var mouses = _mouseRepo.GetAll();
        var mousesDto = _mapper.Map<IEnumerable<MouseDto>>(mouses);
        return mousesDto;
    }

    public Mouse GetMouseByName(string name)
    {
        var mouse = _mouseRepo.SearchOne(m => m.Reference == name);
        return mouse;
    }

    public IEnumerable<Mouse> GetMouseByNames(string search)
    {
        var mouses = _mouseRepo.Search(m => m.Reference.Contains(search));
        return mouses;
    }

    public MouseDto FindByRef(string reference)
    {
        var mouse = _mouseRepo.FindByRef(reference);
        var mouseDto = _mapper.Map<MouseDto>(mouse);
        return mouseDto;
    }

    #endregion

    #region Post Services

    public MouseDto AddMouse(MouseDto mouseDto)
    {
        var researchBrand = _brandRepo.SearchOne(b => b.Name == mouseDto.Brand.Name);
        var newMouse = _mapper.Map<Mouse>(mouseDto);

        if (researchBrand != null)
        {
            newMouse.Brand = researchBrand;
            newMouse.IsWireless = mouseDto.IsWireless;
            newMouse.Price = mouseDto.Price;
            newMouse.Reference = mouseDto.Reference;
            newMouse.Stock = mouseDto.Stock;
        }

        var newMouseDto = _mapper.Map<MouseDto>(newMouse);
        _mouseRepo.Save(newMouse);
        return newMouseDto;
    }

    #endregion

    #region Delete Services

    public bool DelMouse(string name)
    {
        var mouseResearch = GetMouseByName(name);
        if (mouseResearch != null)
        {
            _mouseRepo.Delete(mouseResearch);
            return true;
        }
        return false;
    }

    #endregion
    
}