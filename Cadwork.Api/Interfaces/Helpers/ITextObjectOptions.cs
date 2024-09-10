// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;

namespace Cadwork.Api.Interfaces.Helpers;

/// <summary>
/// 
/// </summary>
public interface ITextObjectOptions
{
  /// <summary>
  /// 
  /// </summary>
  public TextElementType ElementType { get; set; }

  /// <summary>
  /// 
  /// </summary>
  public bool Bold { get; set; }

  /// <summary>
  /// 
  /// </summary>
  public bool HeightIsRelative { get; set; }

  /// <summary>
  /// 
  /// </summary>
  public bool Italic { get; set; }

  /// <summary>
  /// 
  /// </summary>
  public double Height { get; set; }

  /// <summary>
  /// 
  /// </summary>
  public double Thickness { get; set; }

  /// <summary>
  /// 
  /// </summary>
  public int Color { get; set; }

  /// <summary>
  /// 
  /// </summary>
  public string FontName { get; set; }

  /// <summary>
  /// 
  /// </summary>
  public string Text { get; set; }
}
