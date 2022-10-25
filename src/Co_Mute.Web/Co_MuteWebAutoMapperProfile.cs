using AutoMapper;
using Co_Mute.Carpools;

namespace Co_Mute.Web;

public class Co_MuteWebAutoMapperProfile : Profile
{
    public Co_MuteWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
        CreateMap<CarpoolDto, CreateUpdateCarpoolDto>();
    }
}
