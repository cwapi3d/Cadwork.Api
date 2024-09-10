// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Implementations.Helpers;
using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Interop.Wrappers.Factories;
using Cadwork.Api.Interop.Wrappers.Helpers;

namespace Cadwork.Api.Extensions;

internal static class ElementModuleExtensions
{
  internal static IntPtr ToNativeElementModule(this IElementModuleProperties data, ControllerFactoryWrapper factory)
  {
    var wrapper = new ElementModulePropertiesWrapper(factory.CreateEmptyElementModuleProperties());
    return wrapper.NativePtr;
  }

  internal static IElementModuleProperties ToManagedElementModule(this IntPtr data)
  {
    return new ElementModuleProperties();
  }
}
