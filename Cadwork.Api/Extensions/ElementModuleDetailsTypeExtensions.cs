// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;

namespace Cadwork.Api.Extensions;

internal static class ElementModuleDetailsTypeExtensions
{
  internal static int ToNativeElementModuleDetailsType(this ElementModuleDetailType data)
  {
    return data switch
    {
      ElementModuleDetailType.Angle => 1,
      ElementModuleDetailType.Area => 2,
      ElementModuleDetailType.Cross => 3,
      ElementModuleDetailType.Edge => 4,
      ElementModuleDetailType.End => 5,
      ElementModuleDetailType.FloorArea => 9,
      ElementModuleDetailType.FloorEnd => 10,
      ElementModuleDetailType.FloorLine => 11,
      ElementModuleDetailType.FloorOpening => 12,
      ElementModuleDetailType.Line => 6,
      ElementModuleDetailType.Opening => 7,
      ElementModuleDetailType.T => 8,
      _ => throw new ArgumentOutOfRangeException(nameof(data), data, null)
    };
  }
}
