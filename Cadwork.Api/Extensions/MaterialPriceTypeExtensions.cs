// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Interop.Wrappers.Helpers;

namespace Cadwork.Api.Extensions;

internal static class MaterialPriceTypeExtensions
{
  internal static string ToNativeMaterialPriceType(this MaterialPriceType data)
  {
    return data switch
    {
      MaterialPriceType.BoardFoot => "bdft",
      MaterialPriceType.CubicFoot => "ft3",
      MaterialPriceType.CubicMeter => "m3",
      MaterialPriceType.Foot => "ft",
      MaterialPriceType.KiloGram => "kg",
      MaterialPriceType.Meter => "m",
      MaterialPriceType.PerUnit => "Piece",
      MaterialPriceType.Pound => "lb",
      MaterialPriceType.SquareFoot => "ft2",
      MaterialPriceType.SquareMeter => "m2",
      _ => throw new ArgumentOutOfRangeException(nameof(data), data, null)
    };
  }

  internal static MaterialPriceType ToManagedMaterialPriceType(this IntPtr data)
  {
    var wrapper = new StringWrapper(data);

    if (wrapper.Data() == "bdft")
    {
      return MaterialPriceType.BoardFoot;
    }

    if (wrapper.Data() == "ft3")
    {
      return MaterialPriceType.CubicFoot;
    }

    if (wrapper.Data() == "m3")
    {
      return MaterialPriceType.CubicMeter;
    }

    if (wrapper.Data() == "ft")
    {
      return MaterialPriceType.Foot;
    }

    if (wrapper.Data() == "kg")
    {
      return MaterialPriceType.KiloGram;
    }

    if (wrapper.Data() == "m")
    {
      return MaterialPriceType.Meter;
    }

    if (wrapper.Data() == "Piece")
    {
      return MaterialPriceType.PerUnit;
    }

    if (wrapper.Data() == "lb")
    {
      return MaterialPriceType.Pound;
    }

    if (wrapper.Data() == "ft2")
    {
      return MaterialPriceType.SquareFoot;
    }

    if (wrapper.Data() == "m2")
    {
      return MaterialPriceType.SquareMeter;
    }

    return MaterialPriceType.KiloGram;
  }
}
