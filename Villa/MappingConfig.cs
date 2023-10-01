using AutoMapper;
using Villa.Models;
using Villa.Models.DTO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Villa
{
    public class MappingConfig:Profile
    {
        public MappingConfig() {
            CreateMap<Villas, VillaDTO>();
            CreateMap<VillaDTO, Villas>();

            CreateMap<Villas, VillaCreateDTO>().ReverseMap();
            CreateMap<Villas, VillaUpdateDTO>().ReverseMap();

            CreateMap<VillaNumber, VillaNumberDTO>();
            CreateMap<VillaNumber, VillaNumberCreateDTO>().ReverseMap();
            CreateMap<VillaNumber, VillaNumberUpdateDTO>().ReverseMap();
        }
    }
}
