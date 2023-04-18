using AutoMapper;
using Doohlink.CampaignManagement.Screens;

namespace Doohlink.CampaignManagement;

public class CampaignManagementApplicationAutoMapperProfile : Profile
{
    public CampaignManagementApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Screen, ScreenDto>();
    }
}
