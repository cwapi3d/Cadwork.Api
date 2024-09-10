// Copyright (C) Cadwork. All rights reserved.

namespace Cadwork.Api.Enums;

/// <summary>
///
/// </summary>
[Flags]
public enum ElementModuleProperties
{
  None,
  Auxiliary,
  BottomPlate,
  CuttingElement,
  DistributeInAxisDirection,
  DistributeInAxisDirectionUseMaxDistance,
  DistributeInAxisDirectionUseNumber,
  DistributePerpendicularToAxisDirection,
  DistributePerpendicularToAxisDirectionUseMaxDistance,
  DistributePerpendicularToAxisDirectionUseNumber,
  ElementFromDetail,
  KeepInCenterOfLayerCurrentWall,
  KeepInCenterOfLayerNeighbourWall,
  KeepInCenterOfRoughVolume,
  MainElement,
  MoveAccordingLengthAxis,
  MoveAccordingThicknessAxis,
  MoveWithTopOfWall,
  NoCollisionControl,
  NoInsideControl,
  NotCutWithCuttingElement,
  NotPlacedAtEndOfWall,
  NotPlacedAtStartOfWall,
  OpeningLintel,
  OpeningSill,
  SolderInAxisDirection,
  StopDistributionInAxisDirection,
  StopDistributionPerpendicularToAxisDirection,
  StretchAccordingLengthAxis,
  StretchAccordingThicknessAxis,
  StretchInOpeningWidth,
  StretchWithOpeningLintel,
  StretchWithOpeningSill,
  StretchWithTopOfWall,
  TopPlate,
  UniqueLayerName,
  UseForDetailCoordinateSystem,
}
