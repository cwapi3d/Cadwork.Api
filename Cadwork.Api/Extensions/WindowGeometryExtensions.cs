// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Interop.Wrappers.Structs;
using Cadwork.Api.Structs;

namespace Cadwork.Api.Extensions;

internal static class WindowGeometryExtensions
{
  internal static WindowGeometry ToManagedWindowGeometry(this CWindowGeometry data)
  {
    return new WindowGeometry()
    {
      TopLeft = new Tuple<int, int>(data.TopLeft.X, data.TopLeft.Y),
      TopRight = new Tuple<int, int>(data.TopRight.X, data.TopRight.Y),
      BottomLeft = new Tuple<int, int>(data.BottomLeft.X, data.BottomLeft.Y),
      BottomRight = new Tuple<int, int>(data.BottomRight.X, data.BottomRight.Y),
    };
  }
}
