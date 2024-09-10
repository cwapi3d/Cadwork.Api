// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Interop.Wrappers.Factories;
using Cadwork.Api.Interop.Wrappers.Helpers;

namespace Cadwork.Api.Extensions;

internal static class ExtendedSettingsExtensions
{
  internal static IntPtr ToNativeExtendedSettings(this ExtendedSettings data, ControllerFactoryWrapper factory)
  {
    var wrapper = new ExtendedSettingsWrapper(factory.CreateEmptyExtendedSettings());

    wrapper.SetPieceByPieceExportWithDimensions(data.HasFlag(ExtendedSettings.PieceByPieceExportWithDimensions));
    wrapper.SetPieceByPieceExportWithoutDimensions(data.HasFlag(ExtendedSettings.PieceByPieceExportWithoutDimensions));
    wrapper.SetWallExport(data.HasFlag(ExtendedSettings.WallExport));
    wrapper.SetGroupExport(data.HasFlag(ExtendedSettings.GroupExport));
    wrapper.SetChiefElement(data.HasFlag(ExtendedSettings.ChiefElement));
    wrapper.SetMfbExport(data.HasFlag(ExtendedSettings.MfbExport));
    wrapper.SetLogHomeExport(data.HasFlag(ExtendedSettings.LogHomeExport));
    wrapper.SetBtlWallExport(data.HasFlag(ExtendedSettings.BtlWallExport));
    wrapper.SetLogMacroExport(data.HasFlag(ExtendedSettings.LogMacroExport));
    wrapper.SetOutline(data.HasFlag(ExtendedSettings.Outline));
    wrapper.SetIgnoreForConnectorAxis(data.HasFlag(ExtendedSettings.IgnoreForConnectorAxis));

    return wrapper.NativePtr;
  }

  internal static ExtendedSettings ToManagedExtendedSettings(this IntPtr data)
  {
    var wrapper = new ExtendedSettingsWrapper(data);

    var settings = new ExtendedSettings();

    if (wrapper.GetPieceByPieceExportWithDimensions())
    {
      settings |= ExtendedSettings.PieceByPieceExportWithDimensions;
    }

    if (wrapper.GetPieceByPieceExportWithoutDimensions())
    {
      settings |= ExtendedSettings.PieceByPieceExportWithoutDimensions;
    }

    if (wrapper.GetWallExport())
    {
      settings |= ExtendedSettings.WallExport;
    }

    if (wrapper.GetGroupExport())
    {
      settings |= ExtendedSettings.GroupExport;
    }

    if (wrapper.GetChiefElement())
    {
      settings |= ExtendedSettings.ChiefElement;
    }

    if (wrapper.GetMfbExport())
    {
      settings |= ExtendedSettings.MfbExport;
    }

    if (wrapper.GetLogHomeExport())
    {
      settings |= ExtendedSettings.LogHomeExport;
    }

    if (wrapper.GetBtlWallExport())
    {
      settings |= ExtendedSettings.BtlWallExport;
    }

    if (wrapper.GetLogMacroExport())
    {
      settings |= ExtendedSettings.LogMacroExport;
    }

    if (wrapper.GetOutline())
    {
      settings |= ExtendedSettings.Outline;
    }

    if (wrapper.GetIgnoreForConnectorAxis())
    {
      settings |= ExtendedSettings.IgnoreForConnectorAxis;
    }

    return settings;
  }
}
