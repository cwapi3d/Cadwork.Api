// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Interfaces.Helpers;

namespace Cadwork.Api.Interfaces.Controllers;

using ElementId = ulong;

/// <summary>
/// 
/// </summary>
public interface IListController
{
  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  ICollection<ElementId> CheckItemListPositionNumber();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  ICollection<ElementId> CheckProductionListPositionNumbers();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  IError GetLastError();

  /// <summary>
  /// 
  /// </summary>
  void ClearErrors();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="fileName"></param>
  void ExportItemList(ICollection<ElementId> elementIds, string fileName);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="fileName"></param>
  /// <param name="settings"></param>
  void ExportItemListWithSettings(ICollection<ElementId> elementIds, string fileName, string settings);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="fileName"></param>
  void ExportProductionList(ICollection<ElementId> elementIds, string fileName);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="fileName"></param>
  /// <param name="settings"></param>
  void ExportProductionListWithSettings(ICollection<ElementId> elementIds, string fileName, string settings);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="fileName"></param>
  void ExportRoughVolumeList(ICollection<ElementId> elementIds, string fileName);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="fileName"></param>
  /// <param name="settings"></param>
  void ExportRoughVolumeListWithSettings(ICollection<ElementId> elementIds, string fileName, string settings);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="settings"></param>
  void LoadItemListCalculationSettings(string settings);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="settings"></param>
  void LoadProductionListCalculationSettings(string settings);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void RegenerateItemListNumbers(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="startNumber"></param>
  /// <param name="keepExistingNumbers"></param>
  /// <param name="withContainers"></param>
  void RegenerateItemListNumbersSilently(ICollection<ElementId> elementIds, uint startNumber, bool keepExistingNumbers, bool withContainers);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void RegenerateProductionListNumbers(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="startNumber"></param>
  /// <param name="keepExistingNumbers"></param>
  /// <param name="withContainers"></param>
  void RegenerateProductionListNumbersSilently(ICollection<ElementId> elementIds, uint startNumber, bool keepExistingNumbers, bool withContainers);
};
