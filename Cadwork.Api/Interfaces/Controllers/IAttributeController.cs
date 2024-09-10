// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Interfaces.Helpers;

namespace Cadwork.Api.Interfaces.Controllers;

using ElementId = ulong;
using MaterialId = ulong;

/// <summary>
/// 
/// </summary>
public interface IAttributeController
{
  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  ElementType GetElementType(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  ExtendedSettings GetExtendedSettings(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="name"></param>
  /// <returns></returns>
  ExtendedSettings GetNameExtendedSettings(string name);

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  IAttributeDisplaySettings GetAttributeDisplaySettingsFor2d();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  IAttributeDisplaySettings GetAttributeDisplaySettingsFor2dWithLayout();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  IAttributeDisplaySettings GetAttributeDisplaySettingsFor2dWithoutLayout();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  IAttributeDisplaySettings GetAttributeDisplaySettingsFor3d();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  IAttributeDisplaySettings GetAttributeDisplaySettingsForContainer();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  IAttributeDisplaySettings GetAttributeDisplaySettingsForExportSolid();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  IAttributeDisplaySettings GetAttributeDisplaySettingsForFramedWallAxis();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  IAttributeDisplaySettings GetAttributeDisplaySettingsForFramedWallBeam();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  IAttributeDisplaySettings GetAttributeDisplaySettingsForFramedWallOpening();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  IAttributeDisplaySettings GetAttributeDisplaySettingsForFramedWallPanel();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  IAttributeDisplaySettings GetAttributeDisplaySettingsForLogWallAxis();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  IAttributeDisplaySettings GetAttributeDisplaySettingsForLogWallBeam();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  IAttributeDisplaySettings GetAttributeDisplaySettingsForLogWallOpening();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  IAttributeDisplaySettings GetAttributeDisplaySettingsForLogWallPanel();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  IAttributeDisplaySettings GetAttributeDisplaySettingsForMachine();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  IAttributeDisplaySettings GetAttributeDisplaySettingsForNestingElement();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  IAttributeDisplaySettings GetAttributeDisplaySettingsForNestingVolume();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  IAttributeDisplaySettings GetAttributeDisplaySettingsForSolidWallAxis();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  IAttributeDisplaySettings GetAttributeDisplaySettingsForSolidWallBeam();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  IAttributeDisplaySettings GetAttributeDisplaySettingsForSolidWallOpening();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  IAttributeDisplaySettings GetAttributeDisplaySettingsForSolidWallPanel();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  ICollection<int> GetPrefabLayerAllAssigned(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  ICollection<int> GetPrefabLayerWithDimensions(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  ICollection<int> GetPrefabLayerWithoutDimensions(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  ICollection<string> GetNameListItems();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementType"></param>
  /// <returns></returns>
  ICollection<string> GetNameListItemsByElementType(ElementType elementType);

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
  NodeSymbolType GetNodeSymbol(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="name"></param>
  /// <returns></returns>
  ProcessType GetNameProcessType(string name);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  ProcessType GetProcessType(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="item"></param>
  /// <returns></returns>
  bool DeleteItemFromCommentList(string item);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="item"></param>
  /// <returns></returns>
  bool DeleteItemFromGroupList(string item);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="item"></param>
  /// <returns></returns>
  bool DeleteItemFromSkuList(string item);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="item"></param>
  /// <returns></returns>
  bool DeleteItemFromSubgroupList(string item);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="number"></param>
  /// <param name="item"></param>
  /// <returns></returns>
  bool DeleteItemFromUserAttributeList(uint number, string item);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="number"></param>
  /// <returns></returns>
  bool DeleteUserAttribute(uint number);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool GetIgnoreInConnectorAxisCalculation(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsArchitectureWall2dc(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsArchitectureWallXml(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  bool IsAttributeDisplayEnabled();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsAuxiliary(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsBeam(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsBtlProcessingGroup(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsCaddyObject(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsCircularMep(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsConnectorAxis(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsContainer(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsDrilling(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  bool IsElementGroupingByGroup();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  bool IsElementGroupingBySubgroup();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsEnvelope(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsExportSolid(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsFloor(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsFramedFloor(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsFramedRoof(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsFramedWall(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsHundeggerProcessingGroup(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsLine(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsLogWall(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsMetal(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsNestingParent(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsNestingVolume(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsNode(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsOpening(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsPanel(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsProcessing(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsRectangularMep(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsRoof(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsRoofSurface(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsSolidFloor(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsSolidRoof(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsSolidWall(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsSurface(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsWall(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="cuttingSetName"></param>
  /// <returns></returns>
  bool SetCuttingSet(ICollection<ElementId> elementIds, string cuttingSetName);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="dataId"></param>
  /// <returns></returns>
  string GetAdditionalData(ElementId elementId, string dataId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="dataId"></param>
  /// <returns></returns>
  string GetAdditionalGuid(ElementId elementId, string dataId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  string GetAssemblyNumber(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  string GetAssociatedNestingName(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  string GetAssociatedNestingNumber(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="number"></param>
  /// <returns></returns>
  string GetAutoAttribute(ElementId elementId, uint number);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="number"></param>
  /// <returns></returns>
  string GetAutoAttributeName(uint number);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  string GetComment(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  ICollection<string> GetCommentListItems();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  string GetContainerNumberWithPrefix(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  string GetCuttingSet(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  string GetElementMaterialName(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  string GetFasteningAttribute(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  string GetGroup(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  ICollection<string> GetGroupListItems();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  string GetMachineCalculationSet(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  string GetMachineCalculationSetMachineType(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  string GetMachineCalculationState(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  string GetName(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  string GetPrefabLayer(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  string GetSku(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  ICollection<string> GetSkuListItems();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  string GetStandardElementName(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  string GetSteelShapeName(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  string GetSubgroup(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  ICollection<string> GetSubgroupListItems();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="number"></param>
  /// <returns></returns>
  string GetUserAttribute(ElementId elementId, uint number);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="number"></param>
  /// <returns></returns>
  ICollection<string> GetUserAttributeListItems(uint number);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="number"></param>
  /// <returns></returns>
  string GetUserAttributeName(uint number);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  string GetWallSituation(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  uint GetContainerNumber(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  uint GetItemNumber(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  uint GetListQuantity(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  uint GetProductionNumber(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  uint GetUserAttributeCount();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="item"></param>
  void AddItemToCommentList(string item);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="item"></param>
  void AddItemToGroupList(string item);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="item"></param>
  void AddItemToNameList(string item);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="item"></param>
  void AddItemToSkuList(string item);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="item"></param>
  void AddItemToSubgroupList(string item);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="number"></param>
  /// <param name="item"></param>
  void AddItemToUserAttributeList(uint number, string item);

  /// <summary>
  /// 
  /// </summary>
  void ClearErrors();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="dataId"></param>
  void DeleteAdditionalData(ICollection<ElementId> elementIds, string dataId);

  /// <summary>
  /// 
  /// </summary>
  void DisableAttributeDisplay();

  /// <summary>
  /// 
  /// </summary>
  void EnableAttributeDisplay();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="dataId"></param>
  /// <param name="dataText"></param>
  void SetAdditionalData(ICollection<ElementId> elementIds, string dataId, string dataText);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="dataId"></param>
  /// <param name="guid"></param>
  void SetAdditionalGuid(ICollection<ElementId> elementIds, string dataId, string guid);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="assemblyNumber"></param>
  void SetAssemblyNumber(ICollection<ElementId> elementIds, string assemblyNumber);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="settings"></param>
  void SetAttributeDisplaySettingsFor2d(IAttributeDisplaySettings settings);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="settings"></param>
  void SetAttributeDisplaySettingsFor2dWithLayout(IAttributeDisplaySettings settings);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="settings"></param>
  void SetAttributeDisplaySettingsFor2dWithoutLayout(IAttributeDisplaySettings settings);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="settings"></param>
  void SetAttributeDisplaySettingsFor3d(IAttributeDisplaySettings settings);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="settings"></param>
  void SetAttributeDisplaySettingsForContainer(IAttributeDisplaySettings settings);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="settings"></param>
  void SetAttributeDisplaySettingsForExportSolid(IAttributeDisplaySettings settings);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="settings"></param>
  void SetAttributeDisplaySettingsForFramedWallAxis(IAttributeDisplaySettings settings);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="settings"></param>
  void SetAttributeDisplaySettingsForFramedWallBeam(IAttributeDisplaySettings settings);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="settings"></param>
  void SetAttributeDisplaySettingsForFramedWallOpening(IAttributeDisplaySettings settings);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="settings"></param>
  void SetAttributeDisplaySettingsForFramedWallPanel(IAttributeDisplaySettings settings);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="settings"></param>
  void SetAttributeDisplaySettingsForLogWallAxis(IAttributeDisplaySettings settings);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="settings"></param>
  void SetAttributeDisplaySettingsForLogWallBeam(IAttributeDisplaySettings settings);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="settings"></param>
  void SetAttributeDisplaySettingsForLogWallOpening(IAttributeDisplaySettings settings);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="settings"></param>
  void SetAttributeDisplaySettingsForLogWallPanel(IAttributeDisplaySettings settings);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="settings"></param>
  void SetAttributeDisplaySettingsForMachine(IAttributeDisplaySettings settings);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="settings"></param>
  void SetAttributeDisplaySettingsForNestingElement(IAttributeDisplaySettings settings);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="settings"></param>
  void SetAttributeDisplaySettingsForNestingVolume(IAttributeDisplaySettings settings);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="settings"></param>
  void SetAttributeDisplaySettingsForSolidWallAxis(IAttributeDisplaySettings settings);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="settings"></param>
  void SetAttributeDisplaySettingsForSolidWallBeam(IAttributeDisplaySettings settings);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="settings"></param>
  void SetAttributeDisplaySettingsForSolidWallOpening(IAttributeDisplaySettings settings);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="settings"></param>
  void SetAttributeDisplaySettingsForSolidWallPanel(IAttributeDisplaySettings settings);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="comment"></param>
  void SetComment(ICollection<ElementId> elementIds, string comment);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="number"></param>
  void SetContainerNumber(ICollection<ElementId> elementIds, uint number);

  /// <summary>
  /// 
  /// </summary>
  void SetElementGroupingByGroup();

  /// <summary>
  /// 
  /// </summary>
  void SetElementGroupingBySubgroup();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="materialId"></param>
  void SetElementMaterial(ICollection<ElementId> elementIds, MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="extendedSettings"></param>
  void SetExtendedSettings(ICollection<ElementId> elementIds, ExtendedSettings extendedSettings);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="value"></param>
  void SetFasteningAttribute(ICollection<ElementId> elementIds, string value);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void SetFramedFloor(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void SetFramedRoof(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void SetFramedWall(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="group"></param>
  void SetGroup(ICollection<ElementId> elementIds, string group);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="flag"></param>
  void SetIgnoreInConnectorAxisCalculation(ICollection<ElementId> elementIds, bool flag);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="itemNumber"></param>
  void SetItemNumber(ICollection<ElementId> elementIds, uint itemNumber);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="layerSettings"></param>
  void SetLayerSettings(ICollection<ElementId> elementIds, ILayerSettings layerSettings);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="listQuantity"></param>
  void SetListQuantity(ICollection<ElementId> elementIds, uint listQuantity);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void SetLogWall(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="name"></param>
  void SetName(ICollection<ElementId> elementIds, string name);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="name"></param>
  /// <param name="extendedSettings"></param>
  void SetNameExtendedSettings(string name, ExtendedSettings extendedSettings);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="name"></param>
  /// <param name="processType"></param>
  void SetNameProcessType(string name, ProcessType processType);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="symbol"></param>
  void SetNodeSymbol(ICollection<ElementId> elementIds, NodeSymbolType symbol);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void SetOpening(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="processType"></param>
  void SetProcessType(ICollection<ElementId> elementIds, ProcessType processType);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void SetProcessTypeAndExtendedSettingsFromName(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="productionNumber"></param>
  void SetProductionNumber(ICollection<ElementId> elementIds, uint productionNumber);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="fileName"></param>
  void SetReferenceWall2dc(ICollection<ElementId> elementIds, string fileName);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="sku"></param>
  void SetSku(ICollection<ElementId> elementIds, string sku);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void SetSolidFloor(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void SetSolidRoof(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void SetSolidWall(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void SetStandardPart(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="subgroup"></param>
  void SetSubgroup(ICollection<ElementId> elementIds, string subgroup);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="number"></param>
  /// <param name="userAttribute"></param>
  void SetUserAttribute(ICollection<ElementId> elementIds, uint number, string userAttribute);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="number"></param>
  /// <param name="userAttributeName"></param>
  void SetUserAttributeName(uint number, string userAttributeName);

  /// <summary>
  /// 
  /// </summary>
  void UpdateAutoAttributes();
}
