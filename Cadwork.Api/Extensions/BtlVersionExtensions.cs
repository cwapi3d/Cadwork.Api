// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;

namespace Cadwork.Api.Extensions;

internal static class BtlVersionExtensions
{
  internal static uint ToNativeBtlVersion(this BtlVersion data)
  {
    return data switch
    {
      BtlVersion.BtlX10 => 110,
      BtlVersion.BtlX11 => 111,
      BtlVersion.BtlX20 => 120,
      BtlVersion.BtlX21 => 121,
      BtlVersion.BtlX22 => 122,
      BtlVersion.Btl100 => 100,
      BtlVersion.Btl101 => 101,
      BtlVersion.Btl102 => 102,
      BtlVersion.Btl103 => 103,
      BtlVersion.Btl104 => 104,
      BtlVersion.Btl105 => 105,
      BtlVersion.Btl106 => 106,
      _ => throw new ArgumentOutOfRangeException(nameof(data), data, null)
    };
  }
}
