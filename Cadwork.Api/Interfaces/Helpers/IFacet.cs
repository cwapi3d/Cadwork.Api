// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Structs;

namespace Cadwork.Api.Interfaces.Helpers;

/// <summary>
/// 
/// </summary>
public interface IFacet
{
  /// <summary>
  /// 
  /// </summary>
  public ICollection<IPolygon> InternalPolygons { get; set; }

  /// <summary>
  /// 
  /// </summary>
  public ICollection<Vec3> Vertices { get; set; }

  /// <summary>
  /// 
  /// </summary>
  public IPolygon? ExternalPolygon { get; set; }

  /// <summary>
  /// 
  /// </summary>
  public Vec3 NormalVector { get; set; }

  /// <summary>
  /// 
  /// </summary>
  public bool IsReferenceFace { get; set; }

  /// <summary>
  /// 
  /// </summary>
  public double DistanceToOrigin { get; set; }
};
