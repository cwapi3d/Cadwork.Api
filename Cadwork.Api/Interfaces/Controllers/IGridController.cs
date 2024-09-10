// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Interfaces.Helpers;

namespace Cadwork.Api.Interfaces.Controllers;

/// <summary>
/// 
/// </summary>
public interface IGridController
{
  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  IError GetLastError();
};
