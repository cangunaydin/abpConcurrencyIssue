using System;
using System.Collections.Generic;
using System.Text;

namespace Doohlink.InventoryManagement.Screens;

public class ScreenConsts
{
    public const string DefaultSorting = "Name desc";
    public const int MinNameLength = 3;
    public const int MaxNameLength = 512;

    public const int MaxMacAddressLength = 32;

    public const int MaxExternalIdLength = 50;

    public const string RegexMacAddressValidation = "^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$";
}
