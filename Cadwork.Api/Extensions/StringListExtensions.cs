// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Interop.Wrappers.Factories;
using Cadwork.Api.Interop.Wrappers.Helpers;

namespace Cadwork.Api.Extensions;

internal static class StringListExtensions
{
  internal static IntPtr ToNativeStringList(this ICollection<string> data, ControllerFactoryWrapper factory)
  {
    var wrapper = new StringListWrapper(factory.CreateEmptyStringList());

    foreach (var item in data)
    {
      wrapper.Append(item);
    }

    return wrapper.NativePtr;
  }

  internal static ICollection<string> ToManagedStringList(this IntPtr data)
  {
    var wrapper = new StringListWrapper(data);

    var list = new List<string>();

    for (uint i = 0; i < wrapper.Count(); i++)
    {
      list.Add(wrapper.At(i).ToManagedString());
    }

    return list;
  }
}
