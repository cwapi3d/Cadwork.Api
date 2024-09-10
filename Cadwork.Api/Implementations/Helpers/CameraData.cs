// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Structs;

namespace Cadwork.Api.Implementations.Helpers;

public class CameraData : ICameraData
{
  public ProjectionType Projection { get; set; }
  public Vec3 Position { get; set; }
  public Vec3 Target { get; set; }
  public Vec3 Up { get; set; }
  public float FieldHeight { get; set; }
  public float FieldOfView { get; set; }
  public float FieldWidth { get; set; }
}
