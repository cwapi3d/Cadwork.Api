// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Implementations.Helpers;
using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Interop.Wrappers.Helpers;

namespace Cadwork.Api.Extensions;

internal static class FacetListExtensions
{
  internal static ICollection<IFacet> ToManagedFacetList(this IntPtr data)
  {
    var wrapper = new FacetListWrapper(data);

    var list = new List<IFacet>();

    for (uint i = 0; i < wrapper.Count(); i++)
    {
      // TODO: Implement
      list.Add(new Facet());
    }

    return list;
  }
}
