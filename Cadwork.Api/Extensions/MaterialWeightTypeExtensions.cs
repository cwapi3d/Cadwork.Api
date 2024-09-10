// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Interop.Wrappers.Helpers;

namespace Cadwork.Api.Extensions;

internal static class MaterialWeightTypeExtensions
{
  internal static string ToNativeMaterialWeightType(this MaterialWeightType data)
  {
    return data switch
    {
      MaterialWeightType.KiloNewtonPerCubicMeter => "kNperM3",
      MaterialWeightType.KiloNewtonPerMeter => "kNperM",
      MaterialWeightType.KiloNewtonPerPiece => "kNperPiece",
      MaterialWeightType.KiloNewtonPerSquareMeter => "kNperM2",
      _ => throw new ArgumentOutOfRangeException(nameof(data), data, null)
    };
  }

  internal static MaterialWeightType ToManagedMaterialWeightType(this IntPtr data)
  {
    var wrapper = new StringWrapper(data);

    if (wrapper.Data() == "kNperM3")
    {
      return MaterialWeightType.KiloNewtonPerCubicMeter;
    }

    if (wrapper.Data() == "kNperM")
    {
      return MaterialWeightType.KiloNewtonPerMeter;
    }

    if (wrapper.Data() == "kNperPiece")
    {
      return MaterialWeightType.KiloNewtonPerPiece;
    }

    if (wrapper.Data() == "kNperM2")
    {
      return MaterialWeightType.KiloNewtonPerSquareMeter;
    }

    return MaterialWeightType.KiloNewtonPerMeter;
  }
}
