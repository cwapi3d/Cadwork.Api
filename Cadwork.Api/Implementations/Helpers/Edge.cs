// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Structs;

namespace Cadwork.Api.Implementations.Helpers;

public class Edge : IEdge
{
  public ICollection<Vec3> Vertices { get; set; } = [];
}
