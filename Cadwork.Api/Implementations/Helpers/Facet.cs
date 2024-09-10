// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Structs;

namespace Cadwork.Api.Implementations.Helpers;

public class Facet : IFacet
{
  public ICollection<IPolygon> InternalPolygons { get; set; } = [];
  public ICollection<Vec3> Vertices { get; set; } = [];
  public IPolygon? ExternalPolygon { get; set; } = null;
  public Vec3 NormalVector { get; set; }
  public bool IsReferenceFace { get; set; }
  public double DistanceToOrigin { get; set; }
};
