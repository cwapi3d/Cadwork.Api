// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;

namespace Cadwork.Api.Interfaces.Helpers;

/// <summary>
/// 
/// </summary>
public interface ILayerSettings
{
  /// <summary>
  /// 
  /// </summary>
  public LayerSettings Settings { get; set; }

  /// <summary>
  /// 
  /// </summary>
  public int LayerNumber { get; set; }
}
