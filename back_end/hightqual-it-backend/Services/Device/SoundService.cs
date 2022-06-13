using System.Collections;
using System.Collections.Generic;
using AutoMapper;
using hightqual_it_backend.Dtos.Detail;
using hightqual_it_backend.Dtos.Motherboard;
using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models.Detail;
using hightqual_it_backend.Models.Motherboard;
using Newtonsoft.Json;

namespace hightqual_it_backend.Services.Device;

public class SoundService
{
    private IRepository<Sound> _soundRepo;
    private IRepository<Brand> _brandRepo;
    private readonly IMapper _mapper;

    public SoundService(IRepository<Sound> soundRepository, IRepository<Brand> brandRepository, IMapper mapper)
    {
        _soundRepo = soundRepository;
        _brandRepo = brandRepository;
        _mapper = mapper;
    }

    #region Get Services

    public IEnumerable<SoundDto> GetSounds()
    {
        var sounds = _soundRepo.GetAll();
        var soundDto = _mapper.Map<IEnumerable<SoundDto>>(sounds);
        return soundDto;
    }

    public Sound GetSoundById(int id)
    {
        var sound = _soundRepo.SearchOne(s => s.Id == id);
        return sound;
    }

    #endregion

    #region Post Services

    public SoundDto AddSound(SoundDto soundDto)
    {
        var researchBrand = _brandRepo.SearchOne(b => b.Name == soundDto.Brand.Name);
        var newSound = _mapper.Map<Sound>(soundDto);

        if (researchBrand != null)
        {
            newSound.Brand = researchBrand;
            newSound.Format = soundDto.Format;
            newSound.Power = soundDto.Power;
        }
        var newSoundDto = _mapper.Map<SoundDto>(newSound);
        _soundRepo.Save(newSound);
        return newSoundDto;
    }

    #endregion

    #region Delete Services

    public bool DelSound(int id)
    {
        var soundResearch = GetSoundById(id);
        if (soundResearch != null)
        {
            _soundRepo.Delete(soundResearch);
            return true;
        }
        return false;
    }

    #endregion
}