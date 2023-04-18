using System;
using Volo.Abp.Domain.Repositories;

namespace Doohlink.CampaignManagement.Screens;

public interface IScreenRepository : IRepository<Screen, Guid>
{
}
