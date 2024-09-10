// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct CColorRgb
{
  public uint R;
  public uint G;
  public uint B;
}
