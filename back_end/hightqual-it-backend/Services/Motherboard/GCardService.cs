using System.Collections.Generic;
using AutoMapper;
using hightqual_it_backend.Dtos.Motherboard;
using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models;
using hightqual_it_backend.Models.Detail;
using hightqual_it_backend.Models.Motherboard;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace hightqual_it_backend.Services.Motherboard;

public class GCardService
{
    private IRepository<GraphicProduct> _gProdRepo;
    private IRepository<Brand> _brandRepo;
    private IRepository<Memory> _memoryRepo;
    private IRepository<Computer> _computerRepo;
    private readonly IMapper _mapper;

    public GCardService(IRepository<GraphicProduct> gProdRepository, IRepository<Brand> brandRepository, 
        IRepository<Memory> memoryRepository, IRepository<Computer> computerRepository, IMapper mapper)
    {
        _computerRepo = computerRepository;
        _brandRepo = brandRepository;
        _memoryRepo = memoryRepository;
        _gProdRepo = gProdRepository;
        _mapper = mapper;
    }

    #region Get Services

    public IEnumerable<GraphicProductDto> GetGProd()
    {
        var gProd = _gProdRepo.GetAll();
        var gProdDto = _mapper.Map<IEnumerable<GraphicProductDto>>(gProd);
        return gProdDto;
    }

    public GraphicProduct GetGraphicProductByName(string name)
    {
        var gCard = _gProdRepo.SearchOne(g => g.Type == name);
        return gCard;
    }
    
    public IEnumerable<GraphicProduct> GetGraphicProductByNames(string name)
    {
        var gCards = _gProdRepo.Search(g => g.Type.Contains(name));
        return gCards;
    }

    #endregion

    #region Post Services

    public GraphicProductDto AddGProd(GraphicProductDto gProdDto)
    {
        // TODO - IMPLEMENTER LA METHOD (COMPUTER MISSING)
        var researchBrand = _brandRepo.SearchOne(b => b.Name == gProdDto.Brand.Name);
        var researchMemory = _memoryRepo.SearchOne(b => b.Model == gProdDto.Memory.Model);
        var newGProd = _mapper.Map<GraphicProduct>(gProdDto);
        
        if (researchBrand != null && researchMemory != null)
        {
            newGProd.Type = gProdDto.Type;
            newGProd.Brand = researchBrand;
            newGProd.Memory = researchMemory;
        }

        var newGProdDto = _mapper.Map<GraphicProductDto>(newGProd);
        _gProdRepo.Save(newGProd);
        return gProdDto;
    }

    #endregion

    #region Delete Service

    public bool DelGCard(string name)
    {
        var researchCard = GetGraphicProductByName(name);
        if (researchCard != null)
        {
            _gProdRepo.Delete(researchCard);
            return true;
        }
        return false;
    }

    #endregion
}