using System.Collections.Generic;
using AutoMapper;
using hightqual_it_backend.Dtos.Logistic;
using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models.Logistic;

namespace hightqual_it_backend.Services.Detail;

public class CategoryService
{
    private IRepository<Category> _catRepo;
    private readonly IMapper _mapper;
    
    public CategoryService(IRepository<Category> catRepository, IMapper mapper)
    {
        _catRepo = catRepository;
        _mapper = mapper;
    }

    public IEnumerable<CategoryDto> GetCategories()
    {
        var categories = _catRepo.GetAll();
        var catDto = _mapper.Map<IEnumerable<CategoryDto>>(categories);
        return catDto;
    }
}