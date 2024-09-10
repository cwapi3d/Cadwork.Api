// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Interop.Wrappers.Controllers;

namespace Cadwork.Api.Extensions;

internal static class ShortcutKeyExtensions
{
  internal static UtilityControllerWrapper.ShortcutKey ToNativeShortcutKey(this ShortcutKey data)
  {
    return data switch
    {
      ShortcutKey.F1 => UtilityControllerWrapper.ShortcutKey.F1,
      ShortcutKey.F2 => UtilityControllerWrapper.ShortcutKey.F2,
      ShortcutKey.F3 => UtilityControllerWrapper.ShortcutKey.F3,
      ShortcutKey.F4 => UtilityControllerWrapper.ShortcutKey.F4,
      ShortcutKey.F5 => UtilityControllerWrapper.ShortcutKey.F5,
      ShortcutKey.F6 => UtilityControllerWrapper.ShortcutKey.F6,
      ShortcutKey.F7 => UtilityControllerWrapper.ShortcutKey.F7,
      ShortcutKey.F8 => UtilityControllerWrapper.ShortcutKey.F8,
      ShortcutKey.F9 => UtilityControllerWrapper.ShortcutKey.F9,
      ShortcutKey.F10 => UtilityControllerWrapper.ShortcutKey.F10,
      ShortcutKey.F11 => UtilityControllerWrapper.ShortcutKey.F11,
      ShortcutKey.F12 => UtilityControllerWrapper.ShortcutKey.F12,
      _ => throw new ArgumentOutOfRangeException(nameof(data), data, null)
    };
  }
}
