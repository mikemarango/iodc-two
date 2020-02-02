using AutoMapper;
using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Mappings
{
    public class PhotoProfile : Profile
    {
        public PhotoProfile()
        {
            CreateMap<Photo, PhotoDto>();
            CreateMap<PhotoCreateDto, Photo>();
            CreateMap<PhotoUpdateDto, Photo>();
        }
    }
}
