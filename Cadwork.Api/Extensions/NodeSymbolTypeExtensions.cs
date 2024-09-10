// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;

namespace Cadwork.Api.Extensions;

internal static class NodeSymbolTypeExtensions
{
  internal static int ToNativeNodeSymbolType(this NodeSymbolType data)
  {
    return data switch
    {
      NodeSymbolType.Type1 => 0,
      NodeSymbolType.Type2 => 1,
      NodeSymbolType.Type3 => 2,
      NodeSymbolType.Type4 => 3,
      NodeSymbolType.Type5 => 4,
      NodeSymbolType.Type6 => 5,
      NodeSymbolType.Type7 => 6,
      NodeSymbolType.Type8 => 7,
      NodeSymbolType.Type9 => 8,
      _ => throw new ArgumentOutOfRangeException(nameof(data), data, null)
    };
  }

  internal static NodeSymbolType ToManagedNodeSymbolType(this int data)
  {
    if (data == 0)
    {
      return NodeSymbolType.Type1;
    }

    if (data == 1)
    {
      return NodeSymbolType.Type2;
    }

    if (data == 2)
    {
      return NodeSymbolType.Type3;
    }

    if (data == 3)
    {
      return NodeSymbolType.Type4;
    }

    if (data == 4)
    {
      return NodeSymbolType.Type5;
    }

    if (data == 5)
    {
      return NodeSymbolType.Type6;
    }

    if (data == 6)
    {
      return NodeSymbolType.Type7;
    }

    if (data == 7)
    {
      return NodeSymbolType.Type8;
    }

    if (data == 8)
    {
      return NodeSymbolType.Type9;
    }

    return NodeSymbolType.Type1;
  }
}
