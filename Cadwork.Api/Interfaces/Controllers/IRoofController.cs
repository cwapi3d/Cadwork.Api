// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Interfaces.Helpers;

namespace Cadwork.Api.Interfaces.Controllers;

using ElementId = ulong;

/// <summary>
/// 
/// </summary>
public interface IRoofController
{
  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  ICollection<ElementId> GetAllCaddyElementIds();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  IError GetLastError();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="edgeType"></param>
  /// <returns></returns>
  double GetEdgeLength(ElementId elementId, RoofEdgeType edgeType);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetProfileLength(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  void ClearErrors();
};
