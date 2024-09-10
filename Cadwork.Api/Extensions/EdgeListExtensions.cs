// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Implementations.Helpers;
using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Interop.Wrappers.Helpers;

namespace Cadwork.Api.Extensions;

internal static class EdgeListExtensions
{
  internal static ICollection<IEdge> ToManagedEdgeList(this IntPtr data)
  {
    var wrapper = new EdgeListWrapper(data);

    var list = new List<IEdge>();

    for (uint i = 0; i < wrapper.Count(); i++)
    {
      var innerWrapper = new VertexListWrapper(wrapper.At(i));

      var edge = new Edge();

      for (uint j = 0; j < innerWrapper.Count(); j++)
      {
        edge.Vertices.Add(innerWrapper.At(j).ToManagedVector());
      }

      list.Add(edge);
    }

    return list;
  }
}
