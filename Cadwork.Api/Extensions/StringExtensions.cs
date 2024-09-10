// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Interop.Wrappers.Helpers;

namespace Cadwork.Api.Extensions;

internal static class StringExtensions
{
  internal static string ToManagedString(this IntPtr data)
  {
    var wrapper = new StringWrapper(data);
    return wrapper.Data();
  }
}
