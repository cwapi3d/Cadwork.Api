// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;

namespace Cadwork.Api.Interfaces.Helpers;

/// <summary>
/// 
/// </summary>
public interface IAttributeDisplaySettings
{
  /// <summary>
  /// 
  /// </summary>
  public AttributeDisplayTextPositionType Type { get; set; }

  /// <summary>
  /// 
  /// </summary>
  public uint Value { get; set; }
};
