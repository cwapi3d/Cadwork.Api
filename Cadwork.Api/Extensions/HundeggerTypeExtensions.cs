// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;

namespace Cadwork.Api.Extensions;

internal static class HundeggerTypeExtensions
{
  internal static uint ToNativeHundeggerType(this HundeggerType data)
  {
    return data switch
    {
      HundeggerType.P810 => 1,
      HundeggerType.K1 => 2,
      HundeggerType.K2 => 3,
      HundeggerType.K2Cambium => 4,
      HundeggerType.K2Uf5 => 5,
      HundeggerType.K2Uf5Cambium => 6,
      HundeggerType.SpeedCut => 7,
      HundeggerType.Pba => 8,
      HundeggerType.PbaBvx => 9,
      HundeggerType.PbaBvx2Cambium => 10,
      HundeggerType.Spm => 12,
      HundeggerType.SpmCambium => 13,
      HundeggerType.RobotDrive => 14,
      HundeggerType.TurboDrive => 15,
      _ => throw new ArgumentOutOfRangeException(nameof(data), data, null)
    };
  }
}
