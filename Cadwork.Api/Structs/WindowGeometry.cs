// Copyright (C) Cadwork. All rights reserved.

namespace Cadwork.Api.Structs;

/// <summary>
/// 
/// </summary>
public struct WindowGeometry
{
  /// <summary>
  /// 
  /// </summary>
  public Tuple<int, int> TopLeft { get; set; }

  /// <summary>
  /// 
  /// </summary>
  public Tuple<int, int> TopRight { get; set; }

  /// <summary>
  /// 
  /// </summary>
  public Tuple<int, int> BottomLeft { get; set; }

  /// <summary>
  /// 
  /// </summary>
  public Tuple<int, int> BottomRight { get; set; }
}
