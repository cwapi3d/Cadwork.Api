// Copyright (C) Cadwork. All rights reserved.

namespace Cadwork.Api.Enums;

/// <summary>
///
/// </summary>
[Flags]
public enum IfcOptionsProperties
{
  None,
  CadworkAttributeForIfcLayer,
  CadworkAttributeForIfcTag,
  ExportEmptyBuildingAndStoreys,
  ExportCadworkPSet,
  IgnoreUserAttributesUsedInUserPSets,
  ExportBimWoodProperty,
}
