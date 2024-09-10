// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Interfaces.Helpers;

namespace Cadwork.Api.Implementations.Helpers;

public class IfcOptions : IIfcOptions
{
  public IfcOptionsAggregation Aggregation { get; set; }
  public IfcOptionsLevelOfDetail LevelOfDetail { get; set; }
  public IfcOptionsProjectData ProjectData { get; set; }
  public IfcOptionsProperties Properties { get; set; }
}
