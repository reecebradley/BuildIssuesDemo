using System;
using AutoMapper;
using DonglesAreGreat.Core.Models;
using DonglesAreGreat.Infrastructure.Entities;

namespace DonglesAreGreat.Infrastructure.Mapping
{
    class DongleEntityToDongleProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<DongleEntity, Dongle>()
                .ForMember(dest => dest.Description,opt => opt.MapFrom(src => string.Format("{0} : {1}", src.Sku, src.Name)))
                .ForMember(dest => dest.IsBroken, opt => opt.MapFrom(src => src.IsBroken))
                .ForMember(dest => dest.Owner, opt => opt.NullSubstitute("Glenn"));



        }
    }
}