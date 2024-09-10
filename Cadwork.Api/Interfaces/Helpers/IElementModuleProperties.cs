// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;

namespace Cadwork.Api.Interfaces.Helpers;

/// <summary>
/// 
/// </summary>
public interface IElementModuleProperties
{
  /// <summary>
  /// 
  /// </summary>
  public ElementModuleProperties Properties { get; set; }

  /// <summary>
  /// 
  /// </summary>
  public double DistributeInAxisDirectionDistance { get; set; }

  /// <summary>
  /// 
  /// </summary>
  public double DistributePerpendicularToAxisDirectionDistance { get; set; }

  public string KeepInCenterOfLayerCurrentWall { get; set; } // TODO: Verify

  public string KeepInCenterOfLayerNeighbourWall { get; set; } // TODO: Verify

  public string UniqueLayerName { get; set; } // TODO: Verify

  /// <summary>
  /// 
  /// </summary>
  public uint CuttingElementPriority { get; set; }

  public uint DistributeInAxisDirectionNumber { get; set; } // TODO: Verify

  public uint DistributePerpendicularToAxisDirectionNumber { get; set; } // TODO: Verify
}
