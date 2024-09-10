// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Interop.Wrappers.Structs;
using Cadwork.Api.Structs;

namespace Cadwork.Api.Extensions;

internal static class VectorExtensions
{
  internal static CVector3 ToNativeVector(this Vec3 data)
  {
    return new CVector3()
    {
      X = data.X,
      Y = data.Y,
      Z = data.Z,
    };
  }

  internal static Vec3 ToManagedVector(this CVector3 data)
  {
    return new Vec3()
    {
      X = data.X,
      Y = data.Y,
      Z = data.Z,
    };
  }
}
