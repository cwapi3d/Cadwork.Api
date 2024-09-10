// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;

namespace Cadwork.Api.Extensions;

internal static class ConnectorAxisTypeExtensions
{
  internal static ulong ToNativeConnectorAxisType(this ConnectorAxisItemType data)
  {
    return data switch
    {
      ConnectorAxisItemType.None => 0,
      ConnectorAxisItemType.Nut => 1,
      ConnectorAxisItemType.Washer => 2,
      ConnectorAxisItemType.SpecialRing => 3,
      ConnectorAxisItemType.SquareWasher => 4,
      ConnectorAxisItemType.WoodenPlug => 5,
      ConnectorAxisItemType.BoltWithHead => 10001,
      ConnectorAxisItemType.BoltWithoutHead => 10002,
      ConnectorAxisItemType.LagBolt => 10003,
      ConnectorAxisItemType.BoltPeg => 10004,
      ConnectorAxisItemType.NormalScrew => 10005,
      ConnectorAxisItemType.WoodenDowel => 10006,
      ConnectorAxisItemType.BoltAnchor => 10007,
      ConnectorAxisItemType.BoltWithMushroomHead => 10008,
      ConnectorAxisItemType.BoltWithConicalHead => 10009,
      ConnectorAxisItemType.BoltWithHeadAndWasher => 10010,
      ConnectorAxisItemType.HangerBolt => 10011,
      ConnectorAxisItemType.ConnectionScrew => 10012,
      _ => throw new ArgumentOutOfRangeException(nameof(data), data, null)
    };
  }
}
