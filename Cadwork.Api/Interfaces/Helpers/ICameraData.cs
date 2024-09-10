// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Structs;

namespace Cadwork.Api.Interfaces.Helpers;

/// <summary>
/// 
/// </summary>
public interface ICameraData
{
  /// <summary>
  /// 
  /// </summary>
  public ProjectionType Projection { get; set; }

  /// <summary>
  /// 
  /// </summary>
  public Vec3 Position { get; set; }

  /// <summary>
  /// 
  /// </summary>
  public Vec3 Target { get; set; }

  /// <summary>
  /// 
  /// </summary>
  public Vec3 Up { get; set; }

  /// <summary>
  /// 
  /// </summary>
  public float FieldHeight { get; set; }

  /// <summary>
  /// 
  /// </summary>
  public float FieldOfView { get; set; }

  /// <summary>
  /// 
  /// </summary>
  public float FieldWidth { get; set; }
}
