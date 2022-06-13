using System.Collections.Generic;
using AutoMapper;
using hightqual_it_backend.Dtos.Device;
using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models.Detail;
using hightqual_it_backend.Models.Device;

namespace hightqual_it_backend.Services.Device;

public class ScreenService
{
    private IRepository<Screen> _screenRepo;
    private IRepository<Brand> _brandRepo;
    private readonly IMapper _mapper;

    public ScreenService(IRepository<Screen> screenRepository, IRepository<Brand> brandRepository,IMapper mapper)
    {
        _screenRepo = screenRepository;
        _brandRepo = brandRepository;
        _mapper = mapper;
    }

    #region Get Services

    public IEnumerable<ScreenDto> GetScreen()
    {
        var screens = _screenRepo.GetAll();
        var screenDto = _mapper.Map<IEnumerable<ScreenDto>>(screens);
        return screenDto;
    }

    public Screen GetScreenByName(string name)
    {
        var screen = _screenRepo.SearchOne(s => s.Reference == name);
        return screen;
    }

    public IEnumerable<Screen> GetScreenByNames(string search)
    {
        var screens = _screenRepo.Search(s => s.Reference.Contains(search));
        return screens;
    }

    #endregion

    #region Post Services

    public ScreenDto AddScreen(ScreenDto screenDto)
    {
        var researchBrand = _brandRepo.SearchOne(b => b.Name == screenDto.Brand.Name);
        var newScreen = _mapper.Map<Screen>(screenDto);

        if (researchBrand != null)
        {
            newScreen.Brand = researchBrand;
            newScreen.Quality = screenDto.Quality;
            newScreen.Reference = screenDto.Reference;
            newScreen.Size = screenDto.Size;
        }

        var newScreenDto = _mapper.Map<ScreenDto>(newScreen);
        _screenRepo.Save(newScreen);
        return newScreenDto;
    }

    #endregion

    #region Delete Services

    public bool DelScreen(string name)
    {
        var screen = GetScreenByName(name);
        if (screen != null)
        {
            _screenRepo.Delete(screen);
            return true;
        }
        return false;
    }

    #endregion
}