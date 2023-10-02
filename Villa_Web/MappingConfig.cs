using AutoMapper;
using Villa_Web.Models;
using Villa_Web.Models.DTO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Villa_Web
{
    public class MappingConfig:Profile
    {
        public MappingConfig() {
            CreateMap<VillaDTO, VillaCreateDTO>().ReverseMap();
            CreateMap<VillaDTO, VillaUpdateDTO>().ReverseMap();

            CreateMap<VillaNumberDTO, VillaNumberCreateDTO>().ReverseMap();
            CreateMap<VillaNumberDTO, VillaNumberUpdateDTO>().ReverseMap();
        }
    }
}
