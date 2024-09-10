// Copyright (C) Cadwork. All rights reserved.

namespace Cadwork.Api.Interfaces.Helpers;

using MenuIndex = int;

/// <summary>
/// 
/// </summary>
public interface IMenu
{
  /// <summary>
  /// 
  /// </summary>
  /// <param name="label"></param>
  /// <returns></returns>
  public MenuIndex AddButton(string label);

  /// <summary>
  /// 
  /// </summary>
  public void AddBlank();
}
