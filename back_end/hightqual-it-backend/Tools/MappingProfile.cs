using AutoMapper;
using hightqual_it_backend.Dtos;

using hightqual_it_backend.Models;
using hightqual_it_backend.Dtos.Motherboard;
using hightqual_it_backend.Models.Motherboard;
using hightqual_it_backend.Dtos.Detail;
using hightqual_it_backend.Dtos.Device;
using hightqual_it_backend.Dtos.Logistic;
using hightqual_it_backend.Models.Detail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hightqual_it_backend.Models.Device;
using hightqual_it_backend.Models.Logistic;


namespace hightqual_it_backend.Tools
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Computer, ComputerDto>().ReverseMap();

            CreateMap<Brand, BrandDto>().ReverseMap();
            CreateMap<Color, ColorDto>().ReverseMap();
            CreateMap<Commentary, CommentaryDto>().ReverseMap();
            CreateMap<Image, ImageDto>().ReverseMap();
            CreateMap<Rank, RankDto>().ReverseMap();

            // Device
            CreateMap<Mouse, MouseDto>().ReverseMap();
            CreateMap<Screen, ScreenDto>().ReverseMap();

            // Logistic
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<CriticalStock, CriticalStockDto>().ReverseMap();
            CreateMap<Stock, StockDto>().ReverseMap();
            CreateMap<Tag, TagDto>().ReverseMap();
            CreateMap<Cart, CartDto>().ReverseMap();
            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<OrderDetail, OrderDetailDto>().ReverseMap();

            // Motherboard
            CreateMap<Connector, ConnectorDto>().ReverseMap();
            CreateMap<Cpu, CpuDto>().ReverseMap();
            CreateMap<GraphicProduct, GraphicProductDto>().ReverseMap();
            CreateMap<HardDisk, HardDiskDto>().ReverseMap();
            CreateMap<Memory, MemoryDto>().ReverseMap();
            CreateMap<Os, OsDto>().ReverseMap();

            CreateMap<PowerSupply, PowerSupplyDto>().ReverseMap();
            CreateMap<Sound, SoundDto>().ReverseMap();
        }
    }
}
