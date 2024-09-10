// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Structs;

namespace Cadwork.Api.Interfaces.Controllers;

using ElementId = ulong;

/// <summary>
/// 
/// </summary>
public interface IConnectorAxisController
{
  /// <summary>
  /// 
  /// </summary>
  /// <param name="diameter"></param>
  /// <param name="startPoint"></param>
  /// <param name="endPoint"></param>
  /// <returns></returns>
  ElementId CreateBlankConnectorAxis(double diameter, Vec3 startPoint, Vec3 endPoint);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="name"></param>
  /// <param name="startPoint"></param>
  /// <param name="endPoint"></param>
  /// <returns></returns>
  ElementId CreateStandardConnectorAxis(string name, Vec3 startPoint, Vec3 endPoint);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="sectionIndex"></param>
  /// <returns></returns>
  ElementId GetSectionContactElement(ElementId elementId, uint sectionIndex);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  ICollection<Guid> GetAxisItemsGuids(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  ICollection<string> GetStandardConnectors();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  IError GetLastError();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool CheckAxis(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool GetBoltLengthAutomatic(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetBoltDiameter(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetBoltLength(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetBoltOverLength(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="sectionIndex"></param>
  /// <returns></returns>
  double GetSectionDiameter(ElementId elementId, uint sectionIndex);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  int GetSectionCount(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="guid"></param>
  /// <returns></returns>
  string GetAxisItemMaterial(Guid guid);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="guid"></param>
  /// <returns></returns>
  string GetAxisItemName(Guid guid);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="guid"></param>
  /// <returns></returns>
  string GetAxisItemNorm(Guid guid);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="guid"></param>
  /// <returns></returns>
  string GetAxisItemOrderNumber(Guid guid);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="guid"></param>
  /// <returns></returns>
  string GetAxisItemStrengthCategory(Guid guid);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="guid"></param>
  /// <param name="userItemIndex"></param>
  /// <returns></returns>
  string GetAxisItemUserField(Guid guid, int userItemIndex);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  Guid GetBoltItemGuid(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  string GetBoltOrderNumber(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="name"></param>
  /// <param name="type"></param>
  /// <returns></returns>
  Guid GetItemGuidByName(string name, ConnectorAxisItemType type);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="sectionIndex"></param>
  /// <returns></returns>
  string GetSectionMaterialName(ElementId elementId, uint sectionIndex);

  /// <summary>
  /// 
  /// </summary>
  void ClearErrors();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="fileName"></param>
  void ImportFromFile(string fileName);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="guid"></param>
  void SetBoltItem(ElementId elementId, Guid guid);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="length"></param>
  void SetBoltLength(ElementId elementId, double length);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="useAutomaticLength"></param>
  void SetBoltLengthAutomatic(ElementId elementId, bool useAutomaticLength);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="overLength"></param>
  void SetBoltOverLength(ElementId elementId, double overLength);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="diameter"></param>
  void SetDiameter(ElementId elementId, double diameter);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="sectionIndex"></param>
  /// <param name="diameter"></param>
  void SetSectionDiameter(ElementId elementId, uint sectionIndex, double diameter);

  /// <summary>
  /// 
  /// </summary>
  void StartConfigurationDialog();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void UpdateAxisCuttingAbility(ICollection<ElementId> elementIds);
}
