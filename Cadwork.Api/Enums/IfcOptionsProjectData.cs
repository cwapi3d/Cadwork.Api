// Copyright (C) Cadwork. All rights reserved.

namespace Cadwork.Api.Enums;

/// <summary>
///
/// </summary>
[Flags]
public enum IfcOptionsProjectData
{
  None,
  ExportProjectNameAsIfcProject,
  ExportAddressInIfcSite,
  ExportCoordinatesInIfcSite,
  ExportTrueNorthInGeometricContext,
  ExportTrueNorthInObjectPlacement,
}
