// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Interop.Wrappers.Factories;
using Cadwork.Api.Interop.Wrappers.Helpers;

namespace Cadwork.Api.Extensions;

internal static class LayerSettingsExtensions
{
  internal static IntPtr ToNativeLayerSettings(this ILayerSettings data, ControllerFactoryWrapper factory)
  {
    var wrapper = new LayerSettingsWrapper(factory.CreateEmptyLayerSettings());

    wrapper.SetLayer(data.LayerNumber);

    if (data.Settings.HasFlag(LayerSettings.WithoutOutput))
    {
      wrapper.SetWithoutOutput();
    }

    if (data.Settings.HasFlag(LayerSettings.WithDimensionsOutput))
    {
      wrapper.SetWithDimensionsOutput();
    }

    if (data.Settings.HasFlag(LayerSettings.WithoutDimensionsOutput))
    {
      wrapper.SetWithoutDimensionsOutput();
    }

    if (data.Settings.HasFlag(LayerSettings.WithAttributesOutput))
    {
      wrapper.SetWithAttributesOutput();
    }

    return wrapper.NativePtr;
  }
}
