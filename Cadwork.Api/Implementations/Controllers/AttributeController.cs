// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Extensions;
using Cadwork.Api.Implementations.Helpers;
using Cadwork.Api.Interfaces.Controllers;
using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Interop.Wrappers.Controllers;
using Cadwork.Api.Interop.Wrappers.Factories;

namespace Cadwork.Api.Implementations.Controllers;

using ElementId = ulong;
using MaterialId = ulong;

internal class AttributeController(ControllerFactoryWrapper factoryWrapper) : IAttributeController
{
  private readonly AttributeControllerWrapper _controllerWrapper = new(factoryWrapper.GetAttributeController());

  public ElementType GetElementType(ElementId elementId)
  {
    return _controllerWrapper.GetElementType(elementId).ToManagedElementType();
  }

  public ExtendedSettings GetExtendedSettings(ElementId elementId)
  {
    return _controllerWrapper.GetExtendedSettings(elementId).ToManagedExtendedSettings();
  }

  public ExtendedSettings GetNameExtendedSettings(string name)
  {
    return _controllerWrapper.GetNameExtendedSettings(name).ToManagedExtendedSettings();
  }

  public IAttributeDisplaySettings GetAttributeDisplaySettingsFor2d()
  {
    return _controllerWrapper.GetAttributeDisplaySettingsFor2D().ToManagedAttributeDisplaySettings();
  }

  public IAttributeDisplaySettings GetAttributeDisplaySettingsFor2dWithLayout()
  {
    return _controllerWrapper.GetAttributeDisplaySettingsFor2DWithLayout().ToManagedAttributeDisplaySettings();
  }

  public IAttributeDisplaySettings GetAttributeDisplaySettingsFor2dWithoutLayout()
  {
    return _controllerWrapper.GetAttributeDisplaySettingsFor2DWithoutLayout().ToManagedAttributeDisplaySettings();
  }

  public IAttributeDisplaySettings GetAttributeDisplaySettingsFor3d()
  {
    return _controllerWrapper.GetAttributeDisplaySettingsFor3D().ToManagedAttributeDisplaySettings();
  }

  public IAttributeDisplaySettings GetAttributeDisplaySettingsForContainer()
  {
    return _controllerWrapper.GetAttributeDisplaySettingsForContainer().ToManagedAttributeDisplaySettings();
  }

  public IAttributeDisplaySettings GetAttributeDisplaySettingsForExportSolid()
  {
    return _controllerWrapper.GetAttributeDisplaySettingsForExportSolid().ToManagedAttributeDisplaySettings();
  }

  public IAttributeDisplaySettings GetAttributeDisplaySettingsForFramedWallAxis()
  {
    return _controllerWrapper.GetAttributeDisplaySettingsForFramedWallAxis().ToManagedAttributeDisplaySettings();
  }

  public IAttributeDisplaySettings GetAttributeDisplaySettingsForFramedWallBeam()
  {
    return _controllerWrapper.GetAttributeDisplaySettingsForFramedWallBeam().ToManagedAttributeDisplaySettings();
  }

  public IAttributeDisplaySettings GetAttributeDisplaySettingsForFramedWallOpening()
  {
    return _controllerWrapper.GetAttributeDisplaySettingsForFramedWallOpening().ToManagedAttributeDisplaySettings();
  }

  public IAttributeDisplaySettings GetAttributeDisplaySettingsForFramedWallPanel()
  {
    return _controllerWrapper.GetAttributeDisplaySettingsForFramedWallPanel().ToManagedAttributeDisplaySettings();
  }

  public IAttributeDisplaySettings GetAttributeDisplaySettingsForLogWallAxis()
  {
    return _controllerWrapper.GetAttributeDisplaySettingsForLogWallAxis().ToManagedAttributeDisplaySettings();
  }

  public IAttributeDisplaySettings GetAttributeDisplaySettingsForLogWallBeam()
  {
    return _controllerWrapper.GetAttributeDisplaySettingsForLogWallBeam().ToManagedAttributeDisplaySettings();
  }

  public IAttributeDisplaySettings GetAttributeDisplaySettingsForLogWallOpening()
  {
    return _controllerWrapper.GetAttributeDisplaySettingsForLogWallOpening().ToManagedAttributeDisplaySettings();
  }

  public IAttributeDisplaySettings GetAttributeDisplaySettingsForLogWallPanel()
  {
    return _controllerWrapper.GetAttributeDisplaySettingsForLogWallPanel().ToManagedAttributeDisplaySettings();
  }

  public IAttributeDisplaySettings GetAttributeDisplaySettingsForMachine()
  {
    return _controllerWrapper.GetAttributeDisplaySettingsForMachine().ToManagedAttributeDisplaySettings();
  }

  public IAttributeDisplaySettings GetAttributeDisplaySettingsForNestingElement()
  {
    return _controllerWrapper.GetAttributeDisplaySettingsForNestingElement().ToManagedAttributeDisplaySettings();
  }

  public IAttributeDisplaySettings GetAttributeDisplaySettingsForNestingVolume()
  {
    return _controllerWrapper.GetAttributeDisplaySettingsForNestingVolume().ToManagedAttributeDisplaySettings();
  }

  public IAttributeDisplaySettings GetAttributeDisplaySettingsForSolidWallAxis()
  {
    return _controllerWrapper.GetAttributeDisplaySettingsForSolidWallAxis().ToManagedAttributeDisplaySettings();
  }

  public IAttributeDisplaySettings GetAttributeDisplaySettingsForSolidWallBeam()
  {
    return _controllerWrapper.GetAttributeDisplaySettingsForSolidWallBeam().ToManagedAttributeDisplaySettings();
  }

  public IAttributeDisplaySettings GetAttributeDisplaySettingsForSolidWallOpening()
  {
    return _controllerWrapper.GetAttributeDisplaySettingsForSolidWallOpening().ToManagedAttributeDisplaySettings();
  }

  public IAttributeDisplaySettings GetAttributeDisplaySettingsForSolidWallPanel()
  {
    return _controllerWrapper.GetAttributeDisplaySettingsForSolidWallPanel().ToManagedAttributeDisplaySettings();
  }

  public ICollection<int> GetPrefabLayerAllAssigned(ElementId elementId)
  {
    return _controllerWrapper.GetPrefabLayerAllAssigned(elementId);
  }

  public ICollection<int> GetPrefabLayerWithDimensions(ElementId elementId)
  {
    return _controllerWrapper.GetPrefabLayerWithDimensions(elementId);
  }

  public ICollection<int> GetPrefabLayerWithoutDimensions(ElementId elementId)
  {
    return _controllerWrapper.GetPrefabLayerWithoutDimensions(elementId);
  }

  public ICollection<string> GetNameListItems()
  {
    return _controllerWrapper.GetNameListItems().ToManagedStringList();
  }

  public ICollection<string> GetNameListItemsByElementType(ElementType elementType)
  {
    return _controllerWrapper.GetNameListItemsByElementType(elementType.ToNativeElementType(factoryWrapper)).ToManagedStringList();
  }

  public IError GetLastError()
  {
    const int errorCode = 0;
    var errorMessage = _controllerWrapper.GetLastError(errorCode);
    return new Error { Code = errorCode, Message = errorMessage.ToManagedString() };
  }

  public NodeSymbolType GetNodeSymbol(ElementId elementId)
  {
    return (_controllerWrapper.GetNodeSymbol(elementId)).ToManagedNodeSymbolType();
  }

  public ProcessType GetNameProcessType(string name)
  {
    return (_controllerWrapper.GetNameProcessType(name)).ToManagedProcessType();
  }

  public ProcessType GetProcessType(ElementId elementId)
  {
    return (_controllerWrapper.GetOutputType(elementId)).ToManagedProcessType();
  }

  public bool DeleteItemFromCommentList(string item)
  {
    return _controllerWrapper.DeleteItemFromCommentList(item);
  }

  public bool DeleteItemFromGroupList(string item)
  {
    return _controllerWrapper.DeleteItemFromGroupList(item);
  }

  public bool DeleteItemFromSkuList(string item)
  {
    return _controllerWrapper.DeleteItemFromSkuList(item);
  }

  public bool DeleteItemFromSubgroupList(string item)
  {
    return _controllerWrapper.DeleteItemFromSubgroupList(item);
  }

  public bool DeleteItemFromUserAttributeList(uint number, string item)
  {
    return _controllerWrapper.DeleteItemFromUserAttributeList(number, item);
  }

  public bool DeleteUserAttribute(uint number)
  {
    return _controllerWrapper.DeleteUserAttribute(number);
  }

  public bool GetIgnoreInConnectorAxisCalculation(ElementId elementId)
  {
    return _controllerWrapper.GetIgnoreInVbaCalculation(elementId);
  }

  public bool IsArchitectureWall2dc(ElementId elementId)
  {
    return _controllerWrapper.IsArchitectureWall2dc(elementId);
  }

  public bool IsArchitectureWallXml(ElementId elementId)
  {
    return _controllerWrapper.IsArchitectureWallXml(elementId);
  }

  public bool IsAttributeDisplayEnabled()
  {
    return _controllerWrapper.IsAttributeDisplayEnabled();
  }

  public bool IsAuxiliary(ElementId elementId)
  {
    return _controllerWrapper.IsAuxiliary(elementId);
  }

  public bool IsBeam(ElementId elementId)
  {
    return _controllerWrapper.IsBeam(elementId);
  }

  public bool IsBtlProcessingGroup(ElementId elementId)
  {
    return _controllerWrapper.IsBtlProcessingGroup(elementId);
  }

  public bool IsCaddyObject(ElementId elementId)
  {
    return _controllerWrapper.IsCaddyObject(elementId);
  }

  public bool IsCircularMep(ElementId elementId)
  {
    return _controllerWrapper.IsCircularMep(elementId);
  }

  public bool IsConnectorAxis(ElementId elementId)
  {
    return _controllerWrapper.IsConnectorAxis(elementId);
  }

  public bool IsContainer(ElementId elementId)
  {
    return _controllerWrapper.IsContainer(elementId);
  }

  public bool IsDrilling(ElementId elementId)
  {
    return _controllerWrapper.IsDrilling(elementId);
  }

  public bool IsElementGroupingByGroup()
  {
    return _controllerWrapper.GetElementGroupingType() == AttributeControllerWrapper.ElementGroupingType.Group;
  }

  public bool IsElementGroupingBySubgroup()
  {
    return _controllerWrapper.GetElementGroupingType() == AttributeControllerWrapper.ElementGroupingType.Subgroup;
  }

  public bool IsEnvelope(ElementId elementId)
  {
    return _controllerWrapper.IsEnvelope(elementId);
  }

  public bool IsExportSolid(ElementId elementId)
  {
    return _controllerWrapper.IsExportSolid(elementId);
  }

  public bool IsFloor(ElementId elementId)
  {
    return _controllerWrapper.IsFloor(elementId);
  }

  public bool IsFramedFloor(ElementId elementId)
  {
    return _controllerWrapper.IsFramedFloor(elementId);
  }

  public bool IsFramedRoof(ElementId elementId)
  {
    return _controllerWrapper.IsFramedRoof(elementId);
  }

  public bool IsFramedWall(ElementId elementId)
  {
    return _controllerWrapper.IsFramedWall(elementId);
  }

  public bool IsHundeggerProcessingGroup(ElementId elementId)
  {
    return _controllerWrapper.IsHundeggerProcessingGroup(elementId);
  }

  public bool IsLine(ElementId elementId)
  {
    return _controllerWrapper.IsLine(elementId);
  }

  public bool IsLogWall(ElementId elementId)
  {
    return _controllerWrapper.IsLogWall(elementId);
  }

  public bool IsMetal(ElementId elementId)
  {
    return _controllerWrapper.IsMetal(elementId);
  }

  public bool IsNestingParent(ElementId elementId)
  {
    return _controllerWrapper.IsNestingParent(elementId);
  }

  public bool IsNestingVolume(ElementId elementId)
  {
    return _controllerWrapper.IsNestingRawPart(elementId);
  }

  public bool IsNode(ElementId elementId)
  {
    return _controllerWrapper.IsNode(elementId);
  }

  public bool IsOpening(ElementId elementId)
  {
    return _controllerWrapper.IsOpening(elementId);
  }

  public bool IsPanel(ElementId elementId)
  {
    return _controllerWrapper.IsPanel(elementId);
  }

  public bool IsProcessing(ElementId elementId)
  {
    return _controllerWrapper.IsProcessing(elementId);
  }

  public bool IsRectangularMep(ElementId elementId)
  {
    return _controllerWrapper.IsRectangularMep(elementId);
  }

  public bool IsRoof(ElementId elementId)
  {
    return _controllerWrapper.IsRoof(elementId);
  }

  public bool IsRoofSurface(ElementId elementId)
  {
    return _controllerWrapper.IsRoofSurface(elementId);
  }

  public bool IsSolidFloor(ElementId elementId)
  {
    return _controllerWrapper.IsSolidFloor(elementId);
  }

  public bool IsSolidRoof(ElementId elementId)
  {
    return _controllerWrapper.IsSolidRoof(elementId);
  }

  public bool IsSolidWall(ElementId elementId)
  {
    return _controllerWrapper.IsSolidWall(elementId);
  }

  public bool IsSurface(ElementId elementId)
  {
    return _controllerWrapper.IsSurface(elementId);
  }

  public bool IsWall(ElementId elementId)
  {
    return _controllerWrapper.IsWall(elementId);
  }

  public bool SetCuttingSet(ICollection<ulong> elementIds, string cuttingSetName)
  {
    return _controllerWrapper.SetCuttingSet(elementIds.ToNativeElementIdList(factoryWrapper), cuttingSetName);
  }

  public string GetAdditionalData(ElementId elementId, string dataId)
  {
    return _controllerWrapper.GetAdditionalData(elementId, dataId).ToManagedString();
  }

  public string GetAdditionalGuid(ElementId elementId, string dataId)
  {
    return _controllerWrapper.GetAdditionalGuid(elementId, dataId).ToManagedString();
  }

  public string GetAssemblyNumber(ElementId elementId)
  {
    return _controllerWrapper.GetAssemblyNumber(elementId).ToManagedString();
  }

  public string GetAssociatedNestingName(ElementId elementId)
  {
    return _controllerWrapper.GetAssociatedNestingName(elementId).ToManagedString();
  }

  public string GetAssociatedNestingNumber(ElementId elementId)
  {
    return _controllerWrapper.GetAssociatedNestingNumber(elementId).ToManagedString();
  }

  public string GetAutoAttribute(ElementId elementId, uint number)
  {
    return _controllerWrapper.GetAutoAttribute(elementId, number).ToManagedString();
  }

  public string GetAutoAttributeName(uint number)
  {
    return _controllerWrapper.GetAutoAttributeName(number).ToManagedString();
  }

  public string GetComment(ElementId elementId)
  {
    return _controllerWrapper.GetComment(elementId).ToManagedString();
  }

  public ICollection<string> GetCommentListItems()
  {
    return _controllerWrapper.GetCommentListItems().ToManagedStringList();
  }

  public string GetContainerNumberWithPrefix(ElementId elementId)
  {
    return _controllerWrapper.GetContainerNumberWithPrefix(elementId).ToManagedString();
  }

  public string GetCuttingSet(ElementId elementId)
  {
    return _controllerWrapper.GetCuttingSet(elementId).ToManagedString();
  }

  public string GetElementMaterialName(ElementId elementId)
  {
    return _controllerWrapper.GetElementMaterialName(elementId).ToManagedString();
  }

  public string GetFasteningAttribute(ElementId elementId)
  {
    return _controllerWrapper.GetFasteningAttribute(elementId).ToManagedString();
  }

  public string GetGroup(ElementId elementId)
  {
    return _controllerWrapper.GetGroup(elementId).ToManagedString();
  }

  public ICollection<string> GetGroupListItems()
  {
    return _controllerWrapper.GetGroupListItems().ToManagedStringList();
  }

  public string GetMachineCalculationSet(ElementId elementId)
  {
    return _controllerWrapper.GetMachineCalculationSet(elementId).ToManagedString();
  }

  public string GetMachineCalculationSetMachineType(ElementId elementId)
  {
    return _controllerWrapper.GetMachineCalculationSetMachineType(elementId).ToManagedString();
  }

  public string GetMachineCalculationState(ElementId elementId)
  {
    return _controllerWrapper.GetMachineCalculationState(elementId).ToManagedString();
  }

  public string GetName(ElementId elementId)
  {
    return _controllerWrapper.GetName(elementId).ToManagedString();
  }

  public string GetPrefabLayer(ElementId elementId)
  {
    return _controllerWrapper.GetPrefabLayer(elementId).ToManagedString();
  }

  public string GetSku(ElementId elementId)
  {
    return _controllerWrapper.GetSku(elementId).ToManagedString();
  }

  public ICollection<string> GetSkuListItems()
  {
    return _controllerWrapper.GetSkuListItems().ToManagedStringList();
  }

  public string GetStandardElementName(ElementId elementId)
  {
    return _controllerWrapper.GetStandardElementName(elementId).ToManagedString();
  }

  public string GetSteelShapeName(ElementId elementId)
  {
    return _controllerWrapper.GetSteelShapeName(elementId).ToManagedString();
  }

  public string GetSubgroup(ElementId elementId)
  {
    return _controllerWrapper.GetSubgroup(elementId).ToManagedString();
  }

  public ICollection<string> GetSubgroupListItems()
  {
    return _controllerWrapper.GetSubgroupListItems().ToManagedStringList();
  }

  public string GetUserAttribute(ElementId elementId, uint number)
  {
    return _controllerWrapper.GetUserAttribute(elementId, number).ToManagedString();
  }

  public ICollection<string> GetUserAttributeListItems(uint number)
  {
    return _controllerWrapper.GetUserAttributeListItems(number).ToManagedStringList();
  }

  public string GetUserAttributeName(uint number)
  {
    return _controllerWrapper.GetUserAttributeName(number).ToManagedString();
  }

  public string GetWallSituation(ElementId elementId)
  {
    return _controllerWrapper.GetWallSituation(elementId).ToManagedString();
  }

  public uint GetContainerNumber(ElementId elementId)
  {
    return _controllerWrapper.GetContainerNumber(elementId);
  }

  public uint GetItemNumber(ElementId elementId)
  {
    return _controllerWrapper.GetPartNumber(elementId);
  }

  public uint GetListQuantity(ElementId elementId)
  {
    return _controllerWrapper.GetListQuantity(elementId);
  }

  public uint GetProductionNumber(ElementId elementId)
  {
    return _controllerWrapper.GetProductionNumber(elementId);
  }

  public uint GetUserAttributeCount()
  {
    return _controllerWrapper.GetUserAttributeCount();
  }

  public void AddItemToCommentList(string item)
  {
    _controllerWrapper.AddItemToCommentList(item);
  }

  public void AddItemToGroupList(string item)
  {
    _controllerWrapper.AddItemToGroupList(item);
  }

  public void AddItemToNameList(string item)
  {
    _controllerWrapper.AddItemToNameList(item);
  }

  public void AddItemToSkuList(string item)
  {
    _controllerWrapper.AddItemToSkuList(item);
  }

  public void AddItemToSubgroupList(string item)
  {
    _controllerWrapper.AddItemToSubgroupList(item);
  }

  public void AddItemToUserAttributeList(uint number, string item)
  {
    _controllerWrapper.AddItemToUserAttributeList(number, item);
  }

  public void ClearErrors()
  {
    _controllerWrapper.ClearErrors();
  }

  public void DeleteAdditionalData(ICollection<ulong> elementIds, string dataId)
  {
    _controllerWrapper.DeleteAdditionalData(elementIds.ToNativeElementIdList(factoryWrapper), dataId);
  }

  public void DisableAttributeDisplay()
  {
    _controllerWrapper.DisableAttributeDisplay();
  }

  public void EnableAttributeDisplay()
  {
    _controllerWrapper.EnableAttributeDisplay();
  }

  public void SetAdditionalData(ICollection<ulong> elementIds, string dataId, string dataText)
  {
    _controllerWrapper.SetAdditionalData(elementIds.ToNativeElementIdList(factoryWrapper), dataId, dataText);
  }

  public void SetAdditionalGuid(ICollection<ulong> elementIds, string dataId, string guid)
  {
    _controllerWrapper.SetAdditionalGuid(elementIds.ToNativeElementIdList(factoryWrapper), dataId, guid);
  }

  public void SetAssemblyNumber(ICollection<ulong> elementIds, string assemblyNumber)
  {
    _controllerWrapper.SetAssemblyNumber(elementIds.ToNativeElementIdList(factoryWrapper), assemblyNumber);
  }

  public void SetAttributeDisplaySettingsFor2d(IAttributeDisplaySettings settings)
  {
    _controllerWrapper.SetAttributeDisplaySettingsFor2D(settings.ToNativeAttributeDisplaySettings(factoryWrapper));
  }

  public void SetAttributeDisplaySettingsFor2dWithLayout(IAttributeDisplaySettings settings)
  {
    _controllerWrapper.SetAttributeDisplaySettingsFor2DWithLayout(settings.ToNativeAttributeDisplaySettings(factoryWrapper));
  }

  public void SetAttributeDisplaySettingsFor2dWithoutLayout(IAttributeDisplaySettings settings)
  {
    _controllerWrapper.SetAttributeDisplaySettingsFor2DWithoutLayout(settings.ToNativeAttributeDisplaySettings(factoryWrapper));
  }

  public void SetAttributeDisplaySettingsFor3d(IAttributeDisplaySettings settings)
  {
    _controllerWrapper.SetAttributeDisplaySettingsFor3D(settings.ToNativeAttributeDisplaySettings(factoryWrapper));
  }

  public void SetAttributeDisplaySettingsForContainer(IAttributeDisplaySettings settings)
  {
    _controllerWrapper.SetAttributeDisplaySettingsForContainer(settings.ToNativeAttributeDisplaySettings(factoryWrapper));
  }

  public void SetAttributeDisplaySettingsForExportSolid(IAttributeDisplaySettings settings)
  {
    _controllerWrapper.SetAttributeDisplaySettingsForExportSolid(settings.ToNativeAttributeDisplaySettings(factoryWrapper));
  }

  public void SetAttributeDisplaySettingsForFramedWallAxis(IAttributeDisplaySettings settings)
  {
    _controllerWrapper.SetAttributeDisplaySettingsForFramedWallAxis(settings.ToNativeAttributeDisplaySettings(factoryWrapper));
  }

  public void SetAttributeDisplaySettingsForFramedWallBeam(IAttributeDisplaySettings settings)
  {
    _controllerWrapper.SetAttributeDisplaySettingsForFramedWallBeam(settings.ToNativeAttributeDisplaySettings(factoryWrapper));
  }

  public void SetAttributeDisplaySettingsForFramedWallOpening(IAttributeDisplaySettings settings)
  {
    _controllerWrapper.SetAttributeDisplaySettingsForFramedWallOpening(settings.ToNativeAttributeDisplaySettings(factoryWrapper));
  }

  public void SetAttributeDisplaySettingsForFramedWallPanel(IAttributeDisplaySettings settings)
  {
    _controllerWrapper.SetAttributeDisplaySettingsForFramedWallPanel(settings.ToNativeAttributeDisplaySettings(factoryWrapper));
  }

  public void SetAttributeDisplaySettingsForLogWallAxis(IAttributeDisplaySettings settings)
  {
    _controllerWrapper.SetAttributeDisplaySettingsForLogWallAxis(settings.ToNativeAttributeDisplaySettings(factoryWrapper));
  }

  public void SetAttributeDisplaySettingsForLogWallBeam(IAttributeDisplaySettings settings)
  {
    _controllerWrapper.SetAttributeDisplaySettingsForLogWallBeam(settings.ToNativeAttributeDisplaySettings(factoryWrapper));
  }

  public void SetAttributeDisplaySettingsForLogWallOpening(IAttributeDisplaySettings settings)
  {
    _controllerWrapper.SetAttributeDisplaySettingsForLogWallOpening(settings.ToNativeAttributeDisplaySettings(factoryWrapper));
  }

  public void SetAttributeDisplaySettingsForLogWallPanel(IAttributeDisplaySettings settings)
  {
    _controllerWrapper.SetAttributeDisplaySettingsForLogWallPanel(settings.ToNativeAttributeDisplaySettings(factoryWrapper));
  }

  public void SetAttributeDisplaySettingsForMachine(IAttributeDisplaySettings settings)
  {
    _controllerWrapper.SetAttributeDisplaySettingsForMachine(settings.ToNativeAttributeDisplaySettings(factoryWrapper));
  }

  public void SetAttributeDisplaySettingsForNestingElement(IAttributeDisplaySettings settings)
  {
    _controllerWrapper.SetAttributeDisplaySettingsForNestingElement(settings.ToNativeAttributeDisplaySettings(factoryWrapper));
  }

  public void SetAttributeDisplaySettingsForNestingVolume(IAttributeDisplaySettings settings)
  {
    _controllerWrapper.SetAttributeDisplaySettingsForNestingVolume(settings.ToNativeAttributeDisplaySettings(factoryWrapper));
  }

  public void SetAttributeDisplaySettingsForSolidWallAxis(IAttributeDisplaySettings settings)
  {
    _controllerWrapper.SetAttributeDisplaySettingsForSolidWallAxis(settings.ToNativeAttributeDisplaySettings(factoryWrapper));
  }

  public void SetAttributeDisplaySettingsForSolidWallBeam(IAttributeDisplaySettings settings)
  {
    _controllerWrapper.SetAttributeDisplaySettingsForSolidWallBeam(settings.ToNativeAttributeDisplaySettings(factoryWrapper));
  }

  public void SetAttributeDisplaySettingsForSolidWallOpening(IAttributeDisplaySettings settings)
  {
    _controllerWrapper.SetAttributeDisplaySettingsForSolidWallOpening(settings.ToNativeAttributeDisplaySettings(factoryWrapper));
  }

  public void SetAttributeDisplaySettingsForSolidWallPanel(IAttributeDisplaySettings settings)
  {
    _controllerWrapper.SetAttributeDisplaySettingsForSolidWallPanel(settings.ToNativeAttributeDisplaySettings(factoryWrapper));
  }

  public void SetComment(ICollection<ulong> elementIds, string comment)
  {
    _controllerWrapper.SetComment(elementIds.ToNativeElementIdList(factoryWrapper), comment);
  }

  public void SetContainerNumber(ICollection<ulong> elementIds, uint number)
  {
    _controllerWrapper.SetContainerNumber(elementIds.ToNativeElementIdList(factoryWrapper), number);
  }

  public void SetElementGroupingByGroup()
  {
    _controllerWrapper.SetElementGroupingType(AttributeControllerWrapper.ElementGroupingType.Group);
  }

  public void SetElementGroupingBySubgroup()
  {
    _controllerWrapper.SetElementGroupingType(AttributeControllerWrapper.ElementGroupingType.Subgroup);
  }

  public void SetElementMaterial(ICollection<ulong> elementIds, MaterialId materialId)
  {
    _controllerWrapper.SetElementMaterial(elementIds.ToNativeElementIdList(factoryWrapper), materialId);
  }

  public void SetExtendedSettings(ICollection<ulong> elementIds, ExtendedSettings extendedSettings)
  {
    _controllerWrapper.SetExtendedSettings(elementIds.ToNativeElementIdList(factoryWrapper), extendedSettings.ToNativeExtendedSettings(factoryWrapper));
  }

  public void SetFasteningAttribute(ICollection<ulong> elementIds, string value)
  {
    _controllerWrapper.SetFasteningAttribute(elementIds.ToNativeElementIdList(factoryWrapper), value);
  }

  public void SetFramedFloor(ICollection<ulong> elementIds)
  {
    _controllerWrapper.SetFramedFloor(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void SetFramedRoof(ICollection<ulong> elementIds)
  {
    _controllerWrapper.SetFramedRoof(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void SetFramedWall(ICollection<ulong> elementIds)
  {
    _controllerWrapper.SetFramedWall(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void SetGroup(ICollection<ulong> elementIds, string group)
  {
    _controllerWrapper.SetGroup(elementIds.ToNativeElementIdList(factoryWrapper), group);
  }

  public void SetIgnoreInConnectorAxisCalculation(ICollection<ulong> elementIds, bool flag)
  {
    _controllerWrapper.SetIgnoreInVbaCalculation(elementIds.ToNativeElementIdList(factoryWrapper), flag);
  }

  public void SetItemNumber(ICollection<ulong> elementIds, uint itemNumber)
  {
    _controllerWrapper.SetPartNumber(elementIds.ToNativeElementIdList(factoryWrapper), itemNumber);
  }

  public void SetLayerSettings(ICollection<ulong> elementIds, ILayerSettings layerSettings)
  {
    _controllerWrapper.SetLayerSettings(elementIds.ToNativeElementIdList(factoryWrapper), layerSettings.ToNativeLayerSettings(factoryWrapper));
  }

  public void SetListQuantity(ICollection<ulong> elementIds, uint listQuantity)
  {
    _controllerWrapper.SetListQuantity(elementIds.ToNativeElementIdList(factoryWrapper), listQuantity);
  }

  public void SetLogWall(ICollection<ulong> elementIds)
  {
    _controllerWrapper.SetLogWall(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void SetName(ICollection<ulong> elementIds, string name)
  {
    _controllerWrapper.SetName(elementIds.ToNativeElementIdList(factoryWrapper), name);
  }

  public void SetNameExtendedSettings(string name, ExtendedSettings extendedSettings)
  {
    _controllerWrapper.SetNameExtendedSettings(name, extendedSettings.ToNativeExtendedSettings(factoryWrapper));
  }

  public void SetNameProcessType(string name, ProcessType processType)
  {
    _controllerWrapper.SetNameProcessType(name, processType.ToNativeProcessType(factoryWrapper));
  }

  public void SetNodeSymbol(ICollection<ulong> elementIds, NodeSymbolType symbol)
  {
    _controllerWrapper.SetNodeSymbol(elementIds.ToNativeElementIdList(factoryWrapper), symbol.ToNativeNodeSymbolType());
  }

  public void SetOpening(ICollection<ulong> elementIds)
  {
    _controllerWrapper.SetOpening(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void SetProcessType(ICollection<ulong> elementIds, ProcessType processType)
  {
    _controllerWrapper.SetOutputType(elementIds.ToNativeElementIdList(factoryWrapper), processType.ToNativeProcessType(factoryWrapper));
  }

  public void SetProcessTypeAndExtendedSettingsFromName(ICollection<ulong> elementIds)
  {
    _controllerWrapper.SetProcessTypeAndExtendedSettingsFromName(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void SetProductionNumber(ICollection<ulong> elementIds, uint productionNumber)
  {
    _controllerWrapper.SetProductionNumber(elementIds.ToNativeElementIdList(factoryWrapper), productionNumber);
  }

  public void SetReferenceWall2dc(ICollection<ulong> elementIds, string fileName)
  {
    _controllerWrapper.SetReferenceWall2dc(elementIds.ToNativeElementIdList(factoryWrapper), fileName);
  }

  public void SetSku(ICollection<ulong> elementIds, string sku)
  {
    _controllerWrapper.SetSku(elementIds.ToNativeElementIdList(factoryWrapper), sku);
  }

  public void SetSolidFloor(ICollection<ulong> elementIds)
  {
    _controllerWrapper.SetSolidFloor(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void SetSolidRoof(ICollection<ulong> elementIds)
  {
    _controllerWrapper.SetSolidRoof(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void SetSolidWall(ICollection<ulong> elementIds)
  {
    _controllerWrapper.SetSolidWall(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void SetStandardPart(ICollection<ulong> elementIds)
  {
    _controllerWrapper.SetStandardPart(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void SetSubgroup(ICollection<ulong> elementIds, string subgroup)
  {
    _controllerWrapper.SetSubgroup(elementIds.ToNativeElementIdList(factoryWrapper), subgroup);
  }

  public void SetUserAttribute(ICollection<ulong> elementIds, uint number, string userAttribute)
  {
    _controllerWrapper.SetUserAttribute(elementIds.ToNativeElementIdList(factoryWrapper), number, userAttribute);
  }

  public void SetUserAttributeName(uint number, string userAttributeName)
  {
    _controllerWrapper.SetUserAttributeName(number, userAttributeName);
  }

  public void UpdateAutoAttributes()
  {
    _controllerWrapper.UpdateAutoAttributes();
  }
}
