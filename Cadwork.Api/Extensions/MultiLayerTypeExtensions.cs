// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Interop.Wrappers.Controllers;

namespace Cadwork.Api.Extensions;

internal static class MultiLayerTypeExtensions
{
  internal static MultiLayerWallControllerWrapper.MultiLayerType ToNativeMultiLayerType(this MultiLayerType data)
  {
    return data switch
    {
      MultiLayerType.Air => MultiLayerWallControllerWrapper.MultiLayerType.Air,
      MultiLayerType.Covering => MultiLayerWallControllerWrapper.MultiLayerType.Covering,
      MultiLayerType.Lathing => MultiLayerWallControllerWrapper.MultiLayerType.Lathing,
      MultiLayerType.Panel => MultiLayerWallControllerWrapper.MultiLayerType.Panel,
      MultiLayerType.Structure => MultiLayerWallControllerWrapper.MultiLayerType.Structure,
      MultiLayerType.Undefined => MultiLayerWallControllerWrapper.MultiLayerType.Undefined,
      _ => throw new ArgumentOutOfRangeException(nameof(data), data, null)
    };
  }

  internal static MultiLayerType ToManagedMultiLayerType(this MultiLayerWallControllerWrapper.MultiLayerType data)
  {
    return data switch
    {
      MultiLayerWallControllerWrapper.MultiLayerType.Undefined => MultiLayerType.Undefined,
      MultiLayerWallControllerWrapper.MultiLayerType.Structure => MultiLayerType.Structure,
      MultiLayerWallControllerWrapper.MultiLayerType.Panel => MultiLayerType.Panel,
      MultiLayerWallControllerWrapper.MultiLayerType.Lathing => MultiLayerType.Lathing,
      MultiLayerWallControllerWrapper.MultiLayerType.Air => MultiLayerType.Air,
      MultiLayerWallControllerWrapper.MultiLayerType.Covering => MultiLayerType.Covering,
      _ => throw new ArgumentOutOfRangeException(nameof(data), data, null)
    };
  }
}
