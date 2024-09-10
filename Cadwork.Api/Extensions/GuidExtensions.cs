// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Interop.Wrappers.Helpers;

namespace Cadwork.Api.Extensions;

internal static class GuidExtensions
{
  internal static string ToNativeGuid(this Guid data)
  {
    return data.ToString();
  }

  internal static Guid ToManagedGuid(this IntPtr data)
  {
    var wrapper = new StringWrapper(data);
    return new Guid(wrapper.Data());
  }
}
