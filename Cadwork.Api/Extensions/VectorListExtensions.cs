// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Interop.Wrappers.Factories;
using Cadwork.Api.Interop.Wrappers.Helpers;
using Cadwork.Api.Structs;

namespace Cadwork.Api.Extensions;

internal static class VectorListExtensions
{
  internal static IntPtr ToNativeVectorList(this ICollection<Vec3> data, ControllerFactoryWrapper factory)
  {
    var wrapper = new VertexListWrapper(factory.CreateEmptyVertexList());

    foreach (var item in data)
    {
      wrapper.Append(item.ToNativeVector());
    }

    return wrapper.NativePtr;
  }

  internal static ICollection<Vec3> ToManagedVectorList(this IntPtr data)
  {
    var wrapper = new VertexListWrapper(data);

    var list = new List<Vec3>();

    for (uint i = 0; i < wrapper.Count(); i++)
    {
      list.Add(wrapper.At(i).ToManagedVector());
    }

    return list;
  }
}
