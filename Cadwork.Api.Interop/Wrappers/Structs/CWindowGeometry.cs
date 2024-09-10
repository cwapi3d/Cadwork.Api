// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct CWindowGeometry
{
  public struct CWindowGeometryPoint
  {
    public int X;
    public int Y;
  }

  public CWindowGeometryPoint BottomLeft;
  public CWindowGeometryPoint BottomRight;
  public CWindowGeometryPoint TopLeft;
  public CWindowGeometryPoint TopRight;
}
