// Copyright (C) Cadwork. All rights reserved.

namespace Cadwork.Api.Enums;

/// <summary>
///
/// </summary>
[Flags]
public enum IfcOptionsAggregation
{
  None,
  ConsiderElementModuleAggregation,
  AggregationByGroup,
  AggregationBySubgroup,
  CombineWithAssembly,
  CombineWithModule,
  ExportCoverGeometry,
}
