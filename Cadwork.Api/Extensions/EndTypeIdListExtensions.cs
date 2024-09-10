// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Interop.Wrappers.Helpers;

namespace Cadwork.Api.Extensions;

internal static class EndTypeIdListExtensions
{
  internal static ICollection<ulong> ToManagedEndTypeIdList(this IntPtr data)
  {
    var wrapper = new EndTypeIdListWrapper(data);

    var list = new List<ulong>();

    for (uint i = 0; i < wrapper.Count(); i++)
    {
      list.Add(wrapper.At(i));
    }

    return list;
  }
}
