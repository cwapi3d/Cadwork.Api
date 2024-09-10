// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Interop.Wrappers.Controllers;

namespace Cadwork.Api.Extensions;

internal static class StandardElementTypeExtensions
{
  internal static ElementControllerWrapper.StandardElementType ToNativeStandardElementType(this StandardElementType data)
  {
    return data switch
    {
      StandardElementType.Beam => ElementControllerWrapper.StandardElementType.Beam,
      StandardElementType.Panel => ElementControllerWrapper.StandardElementType.Panel,
      StandardElementType.ConnectorAxis => ElementControllerWrapper.StandardElementType.Vba,
      StandardElementType.ExportSolid => ElementControllerWrapper.StandardElementType.ExportSolid,
      StandardElementType.Container => ElementControllerWrapper.StandardElementType.Container,
      StandardElementType.SteelShape => ElementControllerWrapper.StandardElementType.Metal,
      _ => throw new ArgumentOutOfRangeException(nameof(data), data, null)
    };
  }
}
