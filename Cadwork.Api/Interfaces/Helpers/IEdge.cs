// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Structs;

namespace Cadwork.Api.Interfaces.Helpers;

/// <summary>
/// 
/// </summary>
public interface IEdge
{
  /// <summary>
  /// 
  /// </summary>
  public ICollection<Vec3> Vertices { get; set; }
}
