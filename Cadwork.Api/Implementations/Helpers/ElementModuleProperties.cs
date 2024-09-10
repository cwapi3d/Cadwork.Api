// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Interfaces.Helpers;

namespace Cadwork.Api.Implementations.Helpers;

public class ElementModuleProperties : IElementModuleProperties
{
  public Enums.ElementModuleProperties Properties { get; set; }
  public double DistributeInAxisDirectionDistance { get; set; }
  public double DistributePerpendicularToAxisDirectionDistance { get; set; }
  public string KeepInCenterOfLayerCurrentWall { get; set; } = "";
  public string KeepInCenterOfLayerNeighbourWall { get; set; } = "";
  public string UniqueLayerName { get; set; } = "";
  public uint CuttingElementPriority { get; set; }
  public uint DistributeInAxisDirectionNumber { get; set; }
  public uint DistributePerpendicularToAxisDirectionNumber { get; set; }
}
