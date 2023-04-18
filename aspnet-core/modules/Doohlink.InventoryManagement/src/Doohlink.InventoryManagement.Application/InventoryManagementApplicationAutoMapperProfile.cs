using AutoMapper;
using Doohlink.InventoryManagement.Screens;

namespace Doohlink.InventoryManagement;

public class InventoryManagementApplicationAutoMapperProfile : Profile
{
    public InventoryManagementApplicationAutoMapperProfile()
    {
        CreateMap<Screen, ScreenDto>();
    }
}
