// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Interop.Wrappers.Helpers;

namespace Cadwork.Api.Extensions;

internal static class GuidListExtensions
{
  internal static ICollection<Guid> ToManagedGuidList(this IntPtr data)
  {
    var wrapper = new StringListWrapper(data);

    var list = new List<Guid>();

    for (uint i = 0; i < wrapper.Count(); i++)
    {
      list.Add(new Guid(wrapper.At(i).ToManagedString()));
    }

    return list;
  }
}
