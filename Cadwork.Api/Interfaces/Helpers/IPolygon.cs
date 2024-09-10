// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Structs;

namespace Cadwork.Api.Interfaces.Helpers;

/// <summary>
/// 
/// </summary>
public interface IPolygon
{
  /// <summary>
  /// 
  /// </summary>
  public ICollection<Vec3> Vertices { get; set; }
}
