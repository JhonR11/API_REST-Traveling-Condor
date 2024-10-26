using API_RESTCV.DTOs;
using API_RESTCV.ENTITY;
using AutoMapper;

namespace API_RESTCV.Utilidades
{
    public class AutoMapperProfiles : Profile
    {
       public AutoMapperProfiles() {
            CreateMap<UsuarioCreacionDTO, Usuario>();
            CreateMap<RutaCreacionDTO, Ruta>();
            CreateMap<PuntodeInteresCreacionDTO, PuntoDeInteres>();
            CreateMap<Usuario, UsuarioDTO>();
            CreateMap<PuntoDeInteres, PuntodeInteresDTO>();
            CreateMap<RutaUpdateDTO, Ruta>();
       }
    }
}
