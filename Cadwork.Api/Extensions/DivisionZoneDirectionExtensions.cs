// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Interop.Wrappers.Controllers;

namespace Cadwork.Api.Extensions;

internal static class DivisionZoneDirectionExtensions
{
  internal static GeometryControllerWrapper.DivisionZoneDirection ToNativeDivisionZoneDirection(this DivisionZoneDirection data)
  {
    return data switch
    {
      DivisionZoneDirection.Positive => GeometryControllerWrapper.DivisionZoneDirection.Positive,
      DivisionZoneDirection.Negative => GeometryControllerWrapper.DivisionZoneDirection.Negative,
      _ => throw new ArgumentOutOfRangeException(nameof(data), data, null)
    };
  }
}
