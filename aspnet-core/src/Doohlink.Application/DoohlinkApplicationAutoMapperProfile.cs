using AutoMapper;
using Doohlink.Screens;
using Volo.Abp.AutoMapper;

namespace Doohlink;

public class DoohlinkApplicationAutoMapperProfile : Profile
{
    public DoohlinkApplicationAutoMapperProfile()
    {
        CreateMap<InventoryManagement.Screens.ScreenDto, Screens.ScreenDto>()
           .Ignore(o => o.Width)
           .Ignore(o => o.Height);

        CreateMap<CampaignManagement.Screens.ScreenDto, Screens.ScreenDto>()
            .Ignore(o => o.Name)
            .Ignore(o => o.MacAddress);


        CreateMap<CreateScreenDto, InventoryManagement.Screens.CreateScreenDto>();

        CreateMap<CreateScreenDto, CampaignManagement.Screens.CreateScreenDto>();

        CreateMap<UpdateScreenDto, InventoryManagement.Screens.UpdateScreenDto>();

        CreateMap<UpdateScreenDto, CampaignManagement.Screens.UpdateScreenDto>();
    }
}
