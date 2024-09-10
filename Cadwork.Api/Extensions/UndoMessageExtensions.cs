// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;

namespace Cadwork.Api.Extensions;

internal static class UndoMessageExtensions
{
  internal static int ToNativeUndoMessage(this UndoMessage data)
  {
    return data switch
    {
      UndoMessage.Add => 1,
      // UndoMessage.Axis => expr,
      // UndoMessage.Copy => expr,
      // UndoMessage.Cut => expr,
      // UndoMessage.Delete => expr,
      // UndoMessage.EndType => expr,
      // UndoMessage.Match => expr,
      UndoMessage.Modify => 2,
      // UndoMessage.Move => expr,
      // UndoMessage.Optimize => expr,
      // UndoMessage.Regenerate => expr,
      // UndoMessage.Rotate => expr,
      // UndoMessage.Scene => expr,
      // UndoMessage.Solder => expr,
      // UndoMessage.Stretch => expr,
      // UndoMessage.Symmetry => expr,
      _ => throw new ArgumentOutOfRangeException(nameof(data), data, null)
    };
  }
}
