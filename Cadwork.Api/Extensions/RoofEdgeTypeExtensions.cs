// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;

namespace Cadwork.Api.Extensions;

internal static class RoofEdgeTypeExtensions
{
  internal static string ToNativeRoofEdgeType(this RoofEdgeType data)
  {
    return data switch
    {
      RoofEdgeType.Eave => "eave",
      RoofEdgeType.RoofVergeRight => "vergeright",
      RoofEdgeType.RoofVergeLeft => "vergeleft",
      RoofEdgeType.RoofVergeOblique => "vergeoblique",
      RoofEdgeType.Ridge => "ridge",
      RoofEdgeType.Hip => "hip",
      RoofEdgeType.Valley => "valley",
      RoofEdgeType.WallConnection => "wallconnection",
      RoofEdgeType.UserDefined1 => "userdefined1",
      RoofEdgeType.UserDefined2 => "userdefined2",
      RoofEdgeType.UserDefinedMitreJoint1 => "userdefinedmitrejoint1",
      RoofEdgeType.UserDefinedMitreJoint2 => "userdefinedmitrejoint2",
      RoofEdgeType.WallConnectionRight => "wallconnectionright",
      RoofEdgeType.WallConnectionLeft => "wallconnectionleft",
      RoofEdgeType.WallConnectionTop => "wallconnectiontop",
      RoofEdgeType.WallConnectionBottom => "wallconnectionbottom",
      RoofEdgeType.RoofCutOut => "roofcutout",
      RoofEdgeType.RoofCutOutRight => "roofcutoutright",
      RoofEdgeType.RoofCutOutLeft => "roofcutoutleft",
      RoofEdgeType.RoofCutOutTop => "roofcutouttop",
      RoofEdgeType.RoofCutOutBottom => "roofcutoutbottom",
      RoofEdgeType.RoofEdgeOnTopRoofSurface => "roofedgeontoproofsurface",
      RoofEdgeType.RoofEdgeOnBottomRoofSurface => "roofedgeonbottomroofsurface",
      _ => throw new ArgumentOutOfRangeException(nameof(data), data, null)
    };
  }
}
