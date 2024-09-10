// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Interop.Wrappers.Structs;
using Cadwork.Api.Structs;

namespace Cadwork.Api.Extensions;

internal static class ColorExtensions
{
  internal static CColorRgb ToNativeColor(this ColorRgb data)
  {
    return new CColorRgb()
    {
      R = data.Red,
      G = data.Green,
      B = data.Blue,
    };
  }

  internal static ColorRgb ToManagedColor(this CColorRgb data)
  {
    return new ColorRgb()
    {
      Red = data.R,
      Green = data.G,
      Blue = data.B,
    };
  }
}
