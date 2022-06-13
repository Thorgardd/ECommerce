using AutoMapper;
using hightqual_it_backend.Dtos.Detail;
using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models.Detail;
using System.Collections.Generic;

namespace hightqual_it_backend.Services.Detail
{
    public class ImageService
    {
        private IRepository<Image> _imageRepository;
        private readonly IMapper _mapper;
        public ImageService(IRepository<Image> imageRepository, IMapper mapper)
        {
            _imageRepository = imageRepository;
            _mapper = mapper;
        }

        public IEnumerable<ImageDto> GetImages()
        {
            var images = _imageRepository.GetAll();
            var imagesDto = _mapper.Map<IEnumerable<ImageDto>>(images);
            return (IEnumerable<ImageDto>)imagesDto;
        }

        public ImageDto FindImage(int id)
        {
            var image = _imageRepository.FindById(id);
            var imageDto = _mapper.Map<ImageDto>(image);
            return imageDto;
        }
    }
}
