// Copyright (C) Cadwork. All rights reserved.

namespace Cadwork.Api.Interfaces.Helpers;

/// <summary>
/// 
/// </summary>
public interface IError
{
  /// <summary>
  /// 
  /// </summary>
  public int Code { get; set; }

  /// <summary>
  /// 
  /// </summary>
  public string Message { get; set; }
}
