// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Implementations.Helpers;
using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Interop.Wrappers.Factories;
using Cadwork.Api.Interop.Wrappers.Helpers;

namespace Cadwork.Api.Extensions;

internal static class AttributeDisplaySettingsExtensions
{
  internal static IntPtr ToNativeAttributeDisplaySettings(this IAttributeDisplaySettings data, ControllerFactoryWrapper factory)
  {
    var wrapper = new AttributeDisplaySettingsWrapper(factory.CreateEmptyAttributeDisplaySettings());

    switch (data.Type)
    {
      case AttributeDisplayTextPositionType.Absolute:
        wrapper.SetTextPositionTypeAbsolute(true);
        wrapper.SetTextPositionAbsolute(data.Value);
        break;
      case AttributeDisplayTextPositionType.Percentage:
        wrapper.SetTextPositionTypePercentage(true);
        wrapper.SetTextPositionPercentage(data.Value);
        break;
      default:
        throw new ArgumentOutOfRangeException();
    }

    return wrapper.NativePtr;
  }

  internal static IAttributeDisplaySettings ToManagedAttributeDisplaySettings(this IntPtr data)
  {
    var wrapper = new AttributeDisplaySettingsWrapper(data);

    var settings = new AttributeDisplaySettings();

    if (wrapper.IsTextPositionTypeAbsolute())
    {
      settings.Type = AttributeDisplayTextPositionType.Absolute;
      settings.Value = wrapper.GetTextPositionAbsolute();
    }

    if (wrapper.IsTextPositionTypePercentage())
    {
      settings.Type = AttributeDisplayTextPositionType.Percentage;
      settings.Value = wrapper.GetTextPositionPercentage();
    }

    return settings;
  }
}
