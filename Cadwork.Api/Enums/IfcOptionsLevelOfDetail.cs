// Copyright (C) Cadwork. All rights reserved.

namespace Cadwork.Api.Enums;

/// <summary>
///
/// </summary>
[Flags]
public enum IfcOptionsLevelOfDetail
{
  None,
  ExportEndTypes,
  CutEndTypeCounterparts,
  CutConnectorAxesDrillingAxes,
  ExportConnectorAxesComponents,
  CutDrillingAxes,
  ExportRoundMepElements,
  ExportRectangularMepElements,
  CutRoundMepElements,
  CutRectangularMepElements,
  ExportSweptSolidForSimpleGeometry,
}
