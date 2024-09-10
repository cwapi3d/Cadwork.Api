// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct CVector3
{
  public double X;
  public double Y;
  public double Z;
}
