// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Interop.Wrappers.Factories;
using Cadwork.Api.Interop.Wrappers.Helpers;

namespace Cadwork.Api.Extensions;

internal static class ElementIdListExtensions
{
  internal static IntPtr ToNativeElementIdList(this ICollection<ulong> data, ControllerFactoryWrapper factory)
  {
    var wrapper = new ElementIdListWrapper(factory.CreateEmptyElementIdList());

    foreach (var item in data)
    {
      wrapper.Append(item);
    }

    return wrapper.NativePtr;
  }

  internal static ICollection<ulong> ToManagedElementIdList(this IntPtr data)
  {
    var wrapper = new ElementIdListWrapper(data);

    var list = new List<ulong>();

    for (uint i = 0; i < wrapper.Count(); i++)
    {
      list.Add(wrapper.At(i));
    }

    return list;
  }
}
