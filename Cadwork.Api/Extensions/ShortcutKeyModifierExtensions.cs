// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Interop.Wrappers.Controllers;

namespace Cadwork.Api.Extensions;

internal static class ShortcutKeyModifierExtensions
{
  internal static UtilityControllerWrapper.ShortcutKeyModifier ToNativeShortcutKeyModifier(this ShortcutKeyModifier data)
  {
    return data switch
    {
      ShortcutKeyModifier.Alt => UtilityControllerWrapper.ShortcutKeyModifier.Alt,
      ShortcutKeyModifier.Control => UtilityControllerWrapper.ShortcutKeyModifier.Control,
      ShortcutKeyModifier.Shift => UtilityControllerWrapper.ShortcutKeyModifier.Shift,
      _ => throw new ArgumentOutOfRangeException(nameof(data), data, null)
    };
  }
}
