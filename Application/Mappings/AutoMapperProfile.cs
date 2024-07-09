using Application.Entity1.Responses;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Domain.Entities.Entity1, Entity1Response>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Prop2, opt => opt.MapFrom(src => src.Prop2))
                .ForMember(dest => dest.Prop3, opt => opt.MapFrom(src => src.Prop3))
                .ForMember(dest => dest.Prop4, opt => opt.MapFrom(src => src.Prop4))
                .ForMember(dest => dest.Prop5, opt => opt.MapFrom(src => src.Prop5));
        }
    }
}
