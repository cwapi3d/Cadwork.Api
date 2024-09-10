// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Interop.Wrappers.Helpers;
using Cadwork.Api.Structs;

namespace Cadwork.Api.Extensions;

internal static class CoordinateSystemDataExtensions
{
  internal static CoordinateSystemData ToManagedCoordinateSystemData(this IntPtr data)
  {
    var wrapper = new CoordinateSystemDataWrapper(data);
    return new CoordinateSystemData()
    {
      P1 = wrapper.GetP1().ToManagedVector(),
      P2 = wrapper.GetP2().ToManagedVector(),
      P3 = wrapper.GetP3().ToManagedVector(),
    };
  }
}
