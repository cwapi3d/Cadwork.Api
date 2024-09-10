// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Interfaces.Helpers;

namespace Cadwork.Api.Interfaces.Controllers;

using MenuIndex = int;

/// <summary>
/// 
/// </summary>
public interface IMenuController
{
  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  IError GetLastError();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  IMenu CreateMenu();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  MenuIndex GetSelectedMenuItem();

  /// <summary>
  /// 
  /// </summary>
  void CleanupAllMenus();

  /// <summary>
  /// 
  /// </summary>
  void ClearErrors();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="menu"></param>
  void DisplayMenu(IMenu menu);
};
