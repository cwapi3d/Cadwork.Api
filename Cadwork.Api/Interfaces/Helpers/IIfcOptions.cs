// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;

namespace Cadwork.Api.Interfaces.Helpers;

/// <summary>
/// 
/// </summary>
public interface IIfcOptions
{
  /// <summary>
  /// 
  /// </summary>
  public IfcOptionsAggregation Aggregation { get; set; }

  /// <summary>
  /// 
  /// </summary>
  public IfcOptionsLevelOfDetail LevelOfDetail { get; set; }

  /// <summary>
  /// 
  /// </summary>
  public IfcOptionsProjectData ProjectData { get; set; }

  /// <summary>
  /// 
  /// </summary>
  public IfcOptionsProperties Properties { get; set; }
}
