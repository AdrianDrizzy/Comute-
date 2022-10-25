using AutoMapper;
using Co_Mute.Carpools;

namespace Co_Mute;

public class Co_MuteApplicationAutoMapperProfile : Profile
{
    public Co_MuteApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Carpool, CarpoolDto>();
        CreateMap<CreateUpdateCarpoolDto, Carpool>();
    }
}
