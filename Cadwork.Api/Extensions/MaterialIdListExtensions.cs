// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Interop.Wrappers.Helpers;

namespace Cadwork.Api.Extensions;

internal static class MaterialIdListExtensions
{
  internal static ICollection<ulong> ToManagedMaterialIdList(this IntPtr data)
  {
    var wrapper = new MaterialIdListWrapper(data);

    var list = new List<ulong>();

    for (uint i = 0; i < wrapper.Count(); i++)
    {
      list.Add(wrapper.At(i));
    }

    return list;
  }
}
