using AutoMapper;
using hightqual_it_backend.Dtos.Detail;
using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models.Detail;
using System.Collections.Generic;

namespace hightqual_it_backend.Services.Detail
{
    public class CommentaryService
    {
        private IRepository<Commentary> _commentaryRepository;
        private readonly IMapper _mapper;
        public CommentaryService(IRepository<Commentary> commentaryRepository, IMapper mapper)
        {
            _commentaryRepository = commentaryRepository;
            _mapper = mapper;
        }

        public IEnumerable<CommentaryDto> GetCommentaries()
        {
            var commentaries = _commentaryRepository.GetAll();
            var commentariesDto = _mapper.Map<IEnumerable<CommentaryDto>>(commentaries);
            return commentariesDto;
        }

        public CommentaryDto GetCommentaryByRef(string reference)
        {
            var commentaries = _commentaryRepository.FindByRef(reference);
            var commentaryDto = _mapper.Map<CommentaryDto>(commentaries);
            return commentaryDto;
        }

        public Commentary GetCommentaryByReference(CommentaryDto reference)
        {
            var commentaries = _commentaryRepository.FindByRef(reference.Content);
            //var brandDto = _mapper.Map<BrandDto>(brands);
            return commentaries;
        }

        public Commentary AddCommentary(CommentaryDto commentaryDto)
        {
            var newCommentary = _mapper.Map<Commentary>(commentaryDto);
            _commentaryRepository.Save(newCommentary);
            return newCommentary;
        }

        //public CommentaryDto SearchByRef(string name)
        //{
        //    var newCommentary = _commentaryRepository.SearchOne(c => c.Name == name);
        //    if (newCommentary == null)
        //    {
        //        //var cDto = _mapper.Map<CommentaryDto>(newCommentary);
        //        //return cDto;
        //    }
        //    return default(CommentaryDto);
        //}
    }
}
