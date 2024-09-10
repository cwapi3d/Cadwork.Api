// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;

namespace Cadwork.Api.Extensions;

internal static class WeinmannMfbVersionExtensions
{
  internal static uint ToNativeWeinmannMfbVersion(this WeinmannMfbVersion data)
  {
    return data switch
    {
      WeinmannMfbVersion.Wup20 => 22,
      WeinmannMfbVersion.Wup31 => 31,
      WeinmannMfbVersion.Wup32 => 32,
      WeinmannMfbVersion.Wup33 => 33,
      WeinmannMfbVersion.Wup34 => 34,
      WeinmannMfbVersion.Wup35 => 35,
      _ => throw new ArgumentOutOfRangeException(nameof(data), data, null)
    };
  }
}
