using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;
using Volo.Abp;

namespace Doohlink.InventoryManagement.Screens;

public class Screen : FullAuditedAggregateRoot<Guid>, IMultiTenant
{
    public Screen(Guid id, string name, string macAddress, Guid? tenantId = null) : base(id)
    {
        Update(name, macAddress);
        TenantId = tenantId;
    }

    public string Name
    {
        get; private set;
    }

    public string MacAddress
    {
        get; private set;
    }

    public Guid? TenantId
    {
        get; protected set;
    }

    public void Update(string name, string macAddress)
    {
        Check.NotNullOrEmpty(name, nameof(name));
        Check.Length(name, nameof(name), ScreenConsts.MaxNameLength, ScreenConsts.MinNameLength);

        CheckMacAddress(macAddress);
        Name = name;
        MacAddress = macAddress;
    }

    public void UpdateExternalId(string externalId)
    {
        Check.Length(externalId, nameof(externalId), ScreenConsts.MaxExternalIdLength);
    }


    private void CheckMacAddress(string macAddress)
    {
        Check.NotNullOrEmpty(macAddress, nameof(macAddress));
        Check.Length(macAddress, nameof(macAddress), ScreenConsts.MaxMacAddressLength);
        var match = Regex.Match(macAddress, ScreenConsts.RegexMacAddressValidation, RegexOptions.IgnoreCase);

        if (!match.Success)
        {
            throw new ArgumentException($"{nameof(macAddress)} mac address is not valid!", macAddress);
        }
    }
}
