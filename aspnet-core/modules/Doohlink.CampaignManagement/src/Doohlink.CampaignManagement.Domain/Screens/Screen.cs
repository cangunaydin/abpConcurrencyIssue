using System;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Doohlink.CampaignManagement.Screens;

public class Screen : CreationAuditedAggregateRoot<Guid>, IMultiTenant
{
    public Guid? TenantId { get; }

    public int Width { get; private set; }

    public int Height { get; private set; }

    public double AspectRatio { get; private set; }

    private Screen()
    {
    }

    public Screen(Guid id, int width, int height, Guid? tenantId = null) : base(id)
    {
        TenantId = tenantId;
        UpdateResolution(width, height);
      
    }
    public void UpdateResolution(int width,int height)
    {
        if (width < ScreenConsts.WidthMinLength)
        {
            throw new ArgumentOutOfRangeException(nameof(width), width,
                "The value of 'width' cannot be lower than " + ScreenConsts.WidthMinLength);
        }

        if (width > ScreenConsts.WidthMaxLength)
        {
            throw new ArgumentOutOfRangeException(nameof(width), width,
                "The value of 'width' cannot be greater than " + ScreenConsts.WidthMaxLength);
        }

        if (height < ScreenConsts.HeightMinLength)
        {
            throw new ArgumentOutOfRangeException(nameof(height), height,
                "The value of 'height' cannot be lower than " + ScreenConsts.HeightMinLength);
        }

        if (height > ScreenConsts.HeightMaxLength)
        {
            throw new ArgumentOutOfRangeException(nameof(height), height,
                "The value of 'height' cannot be greater than " + ScreenConsts.HeightMaxLength);
        }

        Width = width;
        Height = height;
        AspectRatio = Math.Round(Width / (double)Height, 2);
    }

}
