using AutoMapper;
using hightqual_it_backend.Dtos.Detail;
using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models.Detail;

using System.Collections.Generic;

namespace hightqual_it_backend.Services.Detail
{
    public class ColorService
    {
        private IRepository<Color> _colorRepository;
        private IRepository<Image> _imageRepository;
        private readonly IMapper _mapper;

        public ColorService(IRepository<Color> colorRepository, IRepository<Image> imageRepository, IMapper mapper)
        {
            _colorRepository = colorRepository;
            _imageRepository = imageRepository;
            _mapper = mapper;
        }

        public IEnumerable<ColorDto> GetColors()
        {
            var colors = _colorRepository.GetAll();
            var colorsDto = _mapper.Map<IEnumerable<ColorDto>>(colors);
            return (IEnumerable<ColorDto>)colorsDto;
        }

        public Color AddColor(ColorDto colorDto)
        {
            Color newColor = _mapper.Map<Color>(colorDto);
            _colorRepository.Save(newColor);
            return newColor;
        }

        public ImageDto FindImage(string url)
        {
            Image image = _imageRepository.SearchOne(i => i.Url == url);
            ImageDto imageDto = _mapper.Map<ImageDto>(image);
            return imageDto;
        }
    }
}
