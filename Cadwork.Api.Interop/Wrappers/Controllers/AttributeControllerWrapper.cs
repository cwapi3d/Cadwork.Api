// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Controllers;

public class AttributeControllerWrapper
{
  private readonly IntPtr _nativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public AttributeControllerWrapper(IntPtr nativePtr)
  {
    _nativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<AttributeControllerInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(GetLastErrorDelegate), Marshal.GetDelegateForFunctionPointer<GetLastErrorDelegate>(vTable!.getLastErrorFunctionPtr) },
      { typeof(GetNameDelegate), Marshal.GetDelegateForFunctionPointer<GetNameDelegate>(vTable.getNameFunctionPtr) },
      { typeof(SetNameDelegate), Marshal.GetDelegateForFunctionPointer<SetNameDelegate>(vTable.setNameFunctionPtr) },
      { typeof(GetGroupDelegate), Marshal.GetDelegateForFunctionPointer<GetGroupDelegate>(vTable.getGroupFunctionPtr) },
      { typeof(SetGroupDelegate), Marshal.GetDelegateForFunctionPointer<SetGroupDelegate>(vTable.setGroupFunctionPtr) },
      { typeof(GetSubgroupDelegate), Marshal.GetDelegateForFunctionPointer<GetSubgroupDelegate>(vTable.getSubgroupFunctionPtr) },
      { typeof(SetSubgroupDelegate), Marshal.GetDelegateForFunctionPointer<SetSubgroupDelegate>(vTable.setSubgroupFunctionPtr) },
      { typeof(GetCommentDelegate), Marshal.GetDelegateForFunctionPointer<GetCommentDelegate>(vTable.getCommentFunctionPtr) },
      { typeof(SetCommentDelegate), Marshal.GetDelegateForFunctionPointer<SetCommentDelegate>(vTable.setCommentFunctionPtr) },
      { typeof(GetUserAttributeDelegate), Marshal.GetDelegateForFunctionPointer<GetUserAttributeDelegate>(vTable.getUserAttributeFunctionPtr) },
      { typeof(SetUserAttributeDelegate), Marshal.GetDelegateForFunctionPointer<SetUserAttributeDelegate>(vTable.setUserAttributeFunctionPtr) },
      { typeof(GetSkuDelegate), Marshal.GetDelegateForFunctionPointer<GetSkuDelegate>(vTable.getSKUFunctionPtr) },
      { typeof(SetSkuDelegate), Marshal.GetDelegateForFunctionPointer<SetSkuDelegate>(vTable.setSKUFunctionPtr) },
      { typeof(GetProductionNumberDelegate), Marshal.GetDelegateForFunctionPointer<GetProductionNumberDelegate>(vTable.getProductionNumberFunctionPtr) },
      { typeof(SetProductionNumberDelegate), Marshal.GetDelegateForFunctionPointer<SetProductionNumberDelegate>(vTable.setProductionNumberFunctionPtr) },
      { typeof(GetPartNumberDelegate), Marshal.GetDelegateForFunctionPointer<GetPartNumberDelegate>(vTable.getPartNumberFunctionPtr) },
      { typeof(SetPartNumberDelegate), Marshal.GetDelegateForFunctionPointer<SetPartNumberDelegate>(vTable.setPartNumberFunctionPtr) },
      { typeof(GetAdditionalDataDelegate), Marshal.GetDelegateForFunctionPointer<GetAdditionalDataDelegate>(vTable.getAdditionalDataFunctionPtr) },
      { typeof(SetAdditionalDataDelegate), Marshal.GetDelegateForFunctionPointer<SetAdditionalDataDelegate>(vTable.setAdditionalDataFunctionPtr) },
      { typeof(DeleteAdditionalDataDelegate), Marshal.GetDelegateForFunctionPointer<DeleteAdditionalDataDelegate>(vTable.deleteAdditionalDataFunctionPtr) },
      { typeof(GetUserAttributeNameDelegate), Marshal.GetDelegateForFunctionPointer<GetUserAttributeNameDelegate>(vTable.getUserAttributeNameFunctionPtr) },
      { typeof(SetUserAttributeNameDelegate), Marshal.GetDelegateForFunctionPointer<SetUserAttributeNameDelegate>(vTable.setUserAttributeNameFunctionPtr) },
      { typeof(GetWallSituationDelegate), Marshal.GetDelegateForFunctionPointer<GetWallSituationDelegate>(vTable.getWallSituationFunctionPtr) },
      { typeof(IsBeamDelegate), Marshal.GetDelegateForFunctionPointer<IsBeamDelegate>(vTable.isBeamFunctionPtr) },
      { typeof(IsPanelDelegate), Marshal.GetDelegateForFunctionPointer<IsPanelDelegate>(vTable.isPanelFunctionPtr) },
      { typeof(IsOpeningDelegate), Marshal.GetDelegateForFunctionPointer<IsOpeningDelegate>(vTable.isOpeningFunctionPtr) },
      { typeof(IsWallDelegate), Marshal.GetDelegateForFunctionPointer<IsWallDelegate>(vTable.isWallFunctionPtr) },
      { typeof(IsFloorDelegate), Marshal.GetDelegateForFunctionPointer<IsFloorDelegate>(vTable.isFloorFunctionPtr) },
      { typeof(IsRoofDelegate), Marshal.GetDelegateForFunctionPointer<IsRoofDelegate>(vTable.isRoofFunctionPtr) },
      { typeof(IsMetalDelegate), Marshal.GetDelegateForFunctionPointer<IsMetalDelegate>(vTable.isMetalFunctionPtr) },
      { typeof(IsExportSolidDelegate), Marshal.GetDelegateForFunctionPointer<IsExportSolidDelegate>(vTable.isExportSolidFunctionPtr) },
      { typeof(IsContainerDelegate), Marshal.GetDelegateForFunctionPointer<IsContainerDelegate>(vTable.isContainerFunctionPtr) },
      { typeof(IsConnectorAxisDelegate), Marshal.GetDelegateForFunctionPointer<IsConnectorAxisDelegate>(vTable.isConnectorAxisFunctionPtr) },
      { typeof(IsDrillingDelegate), Marshal.GetDelegateForFunctionPointer<IsDrillingDelegate>(vTable.isDrillingFunctionPtr) },
      { typeof(IsNodeDelegate), Marshal.GetDelegateForFunctionPointer<IsNodeDelegate>(vTable.isNodeFunctionPtr) },
      { typeof(IsAuxiliaryDelegate), Marshal.GetDelegateForFunctionPointer<IsAuxiliaryDelegate>(vTable.isAuxiliaryFunctionPtr) },
      { typeof(GetElementMaterialNameDelegate), Marshal.GetDelegateForFunctionPointer<GetElementMaterialNameDelegate>(vTable.getElementMaterialNameFunctionPtr) },
      { typeof(GetPrefabLayerDelegate), Marshal.GetDelegateForFunctionPointer<GetPrefabLayerDelegate>(vTable.getPrefabLayerFunctionPtr) },
      { typeof(GetMachineCalculationSetDelegate), Marshal.GetDelegateForFunctionPointer<GetMachineCalculationSetDelegate>(vTable.getMachineCalculationSetFunctionPtr) },
      { typeof(GetCuttingSetDelegate), Marshal.GetDelegateForFunctionPointer<GetCuttingSetDelegate>(vTable.getCuttingSetFunctionPtr) },
      { typeof(SetProcessTypeAndExtendedSettingsFromNameDelegate), Marshal.GetDelegateForFunctionPointer<SetProcessTypeAndExtendedSettingsFromNameDelegate>(vTable.setProcessTypeAndExtendedSettingsFromNameFunctionPtr) },
      { typeof(SetNameProcessTypeDelegate), Marshal.GetDelegateForFunctionPointer<SetNameProcessTypeDelegate>(vTable.setNameProcessTypeFunctionPtr) },
      { typeof(GetNameProcessTypeDelegate), Marshal.GetDelegateForFunctionPointer<GetNameProcessTypeDelegate>(vTable.getNameProcessTypeFunctionPtr) },
      { typeof(SetNameExtendedSettingsDelegate), Marshal.GetDelegateForFunctionPointer<SetNameExtendedSettingsDelegate>(vTable.setNameExtendedSettingsFunctionPtr) },
      { typeof(GetNameExtendedSettingsDelegate), Marshal.GetDelegateForFunctionPointer<GetNameExtendedSettingsDelegate>(vTable.getNameExtendedSettingsFunctionPtr) },
      { typeof(GetOutputTypeDelegate), Marshal.GetDelegateForFunctionPointer<GetOutputTypeDelegate>(vTable.getOutputTypeFunctionPtr) },
      { typeof(SetOutputTypeDelegate), Marshal.GetDelegateForFunctionPointer<SetOutputTypeDelegate>(vTable.setOutputTypeFunctionPtr) },
      { typeof(GetExtendedSettingsDelegate), Marshal.GetDelegateForFunctionPointer<GetExtendedSettingsDelegate>(vTable.getExtendedSettingsFunctionPtr) },
      { typeof(SetExtendedSettingsDelegate), Marshal.GetDelegateForFunctionPointer<SetExtendedSettingsDelegate>(vTable.setExtendedSettingsFunctionPtr) },
      { typeof(GetElementTypeDelegate), Marshal.GetDelegateForFunctionPointer<GetElementTypeDelegate>(vTable.getElementTypeFunctionPtr) },
      { typeof(SetWallDelegate), Marshal.GetDelegateForFunctionPointer<SetWallDelegate>(vTable.setWallFunctionPtr) },
      { typeof(SetFloorDelegate), Marshal.GetDelegateForFunctionPointer<SetFloorDelegate>(vTable.setFloorFunctionPtr) },
      { typeof(SetOpeningDelegate), Marshal.GetDelegateForFunctionPointer<SetOpeningDelegate>(vTable.setOpeningFunctionPtr) },
      { typeof(GetFasteningAttributeDelegate), Marshal.GetDelegateForFunctionPointer<GetFasteningAttributeDelegate>(vTable.getFasteningAttributeFunctionPtr) },
      { typeof(SetFasteningAttributeDelegate), Marshal.GetDelegateForFunctionPointer<SetFasteningAttributeDelegate>(vTable.setFasteningAttributeFunctionPtr) },
      { typeof(IsRoofSurfaceDelegate), Marshal.GetDelegateForFunctionPointer<IsRoofSurfaceDelegate>(vTable.isRoofSurfaceFunctionPtr) },
      { typeof(IsCaddyObjectDelegate), Marshal.GetDelegateForFunctionPointer<IsCaddyObjectDelegate>(vTable.isCaddyObjectFunctionPtr) },
      { typeof(SetElementMaterialDelegate), Marshal.GetDelegateForFunctionPointer<SetElementMaterialDelegate>(vTable.setElementMaterialFunctionPtr) },
      { typeof(GetAssemblyNumberDelegate), Marshal.GetDelegateForFunctionPointer<GetAssemblyNumberDelegate>(vTable.getAssemblyNumberFunctionPtr) },
      { typeof(SetAssemblyNumberDelegate), Marshal.GetDelegateForFunctionPointer<SetAssemblyNumberDelegate>(vTable.setAssemblyNumberFunctionPtr) },
      { typeof(GetListQuantityDelegate), Marshal.GetDelegateForFunctionPointer<GetListQuantityDelegate>(vTable.getListQuantityFunctionPtr) },
      { typeof(SetListQuantityDelegate), Marshal.GetDelegateForFunctionPointer<SetListQuantityDelegate>(vTable.setListQuantityFunctionPtr) },
      { typeof(IsEnvelopeDelegate), Marshal.GetDelegateForFunctionPointer<IsEnvelopeDelegate>(vTable.isEnvelopeFunctionPtr) },
      { typeof(SetLayerSettingsDelegate), Marshal.GetDelegateForFunctionPointer<SetLayerSettingsDelegate>(vTable.setLayerSettingsFunctionPtr) },
      { typeof(SetIgnoreInVbaCalculationDelegate), Marshal.GetDelegateForFunctionPointer<SetIgnoreInVbaCalculationDelegate>(vTable.setIgnoreInVBACalculationFunctionPtr) },
      { typeof(GetIgnoreInVbaCalculationDelegate), Marshal.GetDelegateForFunctionPointer<GetIgnoreInVbaCalculationDelegate>(vTable.getIgnoreInVBACalculationFunctionPtr) },
      { typeof(ClearErrorsDelegate), Marshal.GetDelegateForFunctionPointer<ClearErrorsDelegate>(vTable.clearErrorsFunctionPtr) },
      { typeof(IsArchitectureWall2dcDelegate), Marshal.GetDelegateForFunctionPointer<IsArchitectureWall2dcDelegate>(vTable.isArchitectureWall2dcFunctionPtr) },
      { typeof(IsArchitectureWallXmlDelegate), Marshal.GetDelegateForFunctionPointer<IsArchitectureWallXmlDelegate>(vTable.isArchitectureWallXmlFunctionPtr) },
      { typeof(SetReferenceWall2dcDelegate), Marshal.GetDelegateForFunctionPointer<SetReferenceWall2dcDelegate>(vTable.setReferenceWall2dcFunctionPtr) },
      { typeof(IsSurfaceDelegate), Marshal.GetDelegateForFunctionPointer<IsSurfaceDelegate>(vTable.isSurfaceFunctionPtr) },
      { typeof(IsLineDelegate), Marshal.GetDelegateForFunctionPointer<IsLineDelegate>(vTable.isLineFunctionPtr) },
      { typeof(GetAttributeDisplaySettingsFor3DDelegate), Marshal.GetDelegateForFunctionPointer<GetAttributeDisplaySettingsFor3DDelegate>(vTable.getAttributeDisplaySettingsFor3DFunctionPtr) },
      { typeof(SetAttributeDisplaySettingsFor3DDelegate), Marshal.GetDelegateForFunctionPointer<SetAttributeDisplaySettingsFor3DDelegate>(vTable.setAttributeDisplaySettingsFor3DFunctionPtr) },
      { typeof(GetAttributeDisplaySettingsFor2DDelegate), Marshal.GetDelegateForFunctionPointer<GetAttributeDisplaySettingsFor2DDelegate>(vTable.getAttributeDisplaySettingsFor2DFunctionPtr) },
      { typeof(SetAttributeDisplaySettingsFor2DDelegate), Marshal.GetDelegateForFunctionPointer<SetAttributeDisplaySettingsFor2DDelegate>(vTable.setAttributeDisplaySettingsFor2DFunctionPtr) },
      { typeof(GetAttributeDisplaySettingsFor2DWithoutLayoutDelegate), Marshal.GetDelegateForFunctionPointer<GetAttributeDisplaySettingsFor2DWithoutLayoutDelegate>(vTable.getAttributeDisplaySettingsFor2DWithoutLayoutFunctionPtr) },
      { typeof(SetAttributeDisplaySettingsFor2DWithoutLayoutDelegate), Marshal.GetDelegateForFunctionPointer<SetAttributeDisplaySettingsFor2DWithoutLayoutDelegate>(vTable.setAttributeDisplaySettingsFor2DWithoutLayoutFunctionPtr) },
      { typeof(GetAttributeDisplaySettingsFor2DWithLayoutDelegate), Marshal.GetDelegateForFunctionPointer<GetAttributeDisplaySettingsFor2DWithLayoutDelegate>(vTable.getAttributeDisplaySettingsFor2DWithLayoutFunctionPtr) },
      { typeof(SetAttributeDisplaySettingsFor2DWithLayoutDelegate), Marshal.GetDelegateForFunctionPointer<SetAttributeDisplaySettingsFor2DWithLayoutDelegate>(vTable.setAttributeDisplaySettingsFor2DWithLayoutFunctionPtr) },
      { typeof(GetAttributeDisplaySettingsForExportSolidDelegate), Marshal.GetDelegateForFunctionPointer<GetAttributeDisplaySettingsForExportSolidDelegate>(vTable.getAttributeDisplaySettingsForExportSolidFunctionPtr) },
      { typeof(SetAttributeDisplaySettingsForExportSolidDelegate), Marshal.GetDelegateForFunctionPointer<SetAttributeDisplaySettingsForExportSolidDelegate>(vTable.setAttributeDisplaySettingsForExportSolidFunctionPtr) },
      { typeof(GetAttributeDisplaySettingsForContainerDelegate), Marshal.GetDelegateForFunctionPointer<GetAttributeDisplaySettingsForContainerDelegate>(vTable.getAttributeDisplaySettingsForContainerFunctionPtr) },
      { typeof(SetAttributeDisplaySettingsForContainerDelegate), Marshal.GetDelegateForFunctionPointer<SetAttributeDisplaySettingsForContainerDelegate>(vTable.setAttributeDisplaySettingsForContainerFunctionPtr) },
      { typeof(GetAttributeDisplaySettingsForMachineDelegate), Marshal.GetDelegateForFunctionPointer<GetAttributeDisplaySettingsForMachineDelegate>(vTable.getAttributeDisplaySettingsForMachineFunctionPtr) },
      { typeof(SetAttributeDisplaySettingsForMachineDelegate), Marshal.GetDelegateForFunctionPointer<SetAttributeDisplaySettingsForMachineDelegate>(vTable.setAttributeDisplaySettingsForMachineFunctionPtr) },
      { typeof(GetAttributeDisplaySettingsForLogWallBeamDelegate), Marshal.GetDelegateForFunctionPointer<GetAttributeDisplaySettingsForLogWallBeamDelegate>(vTable.getAttributeDisplaySettingsForLogWallBeamFunctionPtr) },
      { typeof(SetAttributeDisplaySettingsForLogWallBeamDelegate), Marshal.GetDelegateForFunctionPointer<SetAttributeDisplaySettingsForLogWallBeamDelegate>(vTable.setAttributeDisplaySettingsForLogWallBeamFunctionPtr) },
      { typeof(GetAttributeDisplaySettingsForLogWallPanelDelegate), Marshal.GetDelegateForFunctionPointer<GetAttributeDisplaySettingsForLogWallPanelDelegate>(vTable.getAttributeDisplaySettingsForLogWallPanelFunctionPtr) },
      { typeof(SetAttributeDisplaySettingsForLogWallPanelDelegate), Marshal.GetDelegateForFunctionPointer<SetAttributeDisplaySettingsForLogWallPanelDelegate>(vTable.setAttributeDisplaySettingsForLogWallPanelFunctionPtr) },
      { typeof(GetAttributeDisplaySettingsForLogWallAxisDelegate), Marshal.GetDelegateForFunctionPointer<GetAttributeDisplaySettingsForLogWallAxisDelegate>(vTable.getAttributeDisplaySettingsForLogWallAxisFunctionPtr) },
      { typeof(SetAttributeDisplaySettingsForLogWallAxisDelegate), Marshal.GetDelegateForFunctionPointer<SetAttributeDisplaySettingsForLogWallAxisDelegate>(vTable.setAttributeDisplaySettingsForLogWallAxisFunctionPtr) },
      { typeof(GetAttributeDisplaySettingsForLogWallOpeningDelegate), Marshal.GetDelegateForFunctionPointer<GetAttributeDisplaySettingsForLogWallOpeningDelegate>(vTable.getAttributeDisplaySettingsForLogWallOpeningFunctionPtr) },
      { typeof(SetAttributeDisplaySettingsForLogWallOpeningDelegate), Marshal.GetDelegateForFunctionPointer<SetAttributeDisplaySettingsForLogWallOpeningDelegate>(vTable.setAttributeDisplaySettingsForLogWallOpeningFunctionPtr) },
      { typeof(GetAttributeDisplaySettingsForFramedWallBeamDelegate), Marshal.GetDelegateForFunctionPointer<GetAttributeDisplaySettingsForFramedWallBeamDelegate>(vTable.getAttributeDisplaySettingsForFramedWallBeamFunctionPtr) },
      { typeof(SetAttributeDisplaySettingsForFramedWallBeamDelegate), Marshal.GetDelegateForFunctionPointer<SetAttributeDisplaySettingsForFramedWallBeamDelegate>(vTable.setAttributeDisplaySettingsForFramedWallBeamFunctionPtr) },
      { typeof(GetAttributeDisplaySettingsForFramedWallPanelDelegate), Marshal.GetDelegateForFunctionPointer<GetAttributeDisplaySettingsForFramedWallPanelDelegate>(vTable.getAttributeDisplaySettingsForFramedWallPanelFunctionPtr) },
      { typeof(SetAttributeDisplaySettingsForFramedWallPanelDelegate), Marshal.GetDelegateForFunctionPointer<SetAttributeDisplaySettingsForFramedWallPanelDelegate>(vTable.setAttributeDisplaySettingsForFramedWallPanelFunctionPtr) },
      { typeof(GetAttributeDisplaySettingsForFramedWallAxisDelegate), Marshal.GetDelegateForFunctionPointer<GetAttributeDisplaySettingsForFramedWallAxisDelegate>(vTable.getAttributeDisplaySettingsForFramedWallAxisFunctionPtr) },
      { typeof(SetAttributeDisplaySettingsForFramedWallAxisDelegate), Marshal.GetDelegateForFunctionPointer<SetAttributeDisplaySettingsForFramedWallAxisDelegate>(vTable.setAttributeDisplaySettingsForFramedWallAxisFunctionPtr) },
      { typeof(GetAttributeDisplaySettingsForFramedWallOpeningDelegate), Marshal.GetDelegateForFunctionPointer<GetAttributeDisplaySettingsForFramedWallOpeningDelegate>(vTable.getAttributeDisplaySettingsForFramedWallOpeningFunctionPtr) },
      { typeof(SetAttributeDisplaySettingsForFramedWallOpeningDelegate), Marshal.GetDelegateForFunctionPointer<SetAttributeDisplaySettingsForFramedWallOpeningDelegate>(vTable.setAttributeDisplaySettingsForFramedWallOpeningFunctionPtr) },
      { typeof(GetAttributeDisplaySettingsForSolidWallBeamDelegate), Marshal.GetDelegateForFunctionPointer<GetAttributeDisplaySettingsForSolidWallBeamDelegate>(vTable.getAttributeDisplaySettingsForSolidWallBeamFunctionPtr) },
      { typeof(SetAttributeDisplaySettingsForSolidWallBeamDelegate), Marshal.GetDelegateForFunctionPointer<SetAttributeDisplaySettingsForSolidWallBeamDelegate>(vTable.setAttributeDisplaySettingsForSolidWallBeamFunctionPtr) },
      { typeof(GetAttributeDisplaySettingsForSolidWallPanelDelegate), Marshal.GetDelegateForFunctionPointer<GetAttributeDisplaySettingsForSolidWallPanelDelegate>(vTable.getAttributeDisplaySettingsForSolidWallPanelFunctionPtr) },
      { typeof(SetAttributeDisplaySettingsForSolidWallPanelDelegate), Marshal.GetDelegateForFunctionPointer<SetAttributeDisplaySettingsForSolidWallPanelDelegate>(vTable.setAttributeDisplaySettingsForSolidWallPanelFunctionPtr) },
      { typeof(GetAttributeDisplaySettingsForSolidWallAxisDelegate), Marshal.GetDelegateForFunctionPointer<GetAttributeDisplaySettingsForSolidWallAxisDelegate>(vTable.getAttributeDisplaySettingsForSolidWallAxisFunctionPtr) },
      { typeof(SetAttributeDisplaySettingsForSolidWallAxisDelegate), Marshal.GetDelegateForFunctionPointer<SetAttributeDisplaySettingsForSolidWallAxisDelegate>(vTable.setAttributeDisplaySettingsForSolidWallAxisFunctionPtr) },
      { typeof(GetAttributeDisplaySettingsForSolidWallOpeningDelegate), Marshal.GetDelegateForFunctionPointer<GetAttributeDisplaySettingsForSolidWallOpeningDelegate>(vTable.getAttributeDisplaySettingsForSolidWallOpeningFunctionPtr) },
      { typeof(SetAttributeDisplaySettingsForSolidWallOpeningDelegate), Marshal.GetDelegateForFunctionPointer<SetAttributeDisplaySettingsForSolidWallOpeningDelegate>(vTable.setAttributeDisplaySettingsForSolidWallOpeningFunctionPtr) },
      { typeof(GetAttributeDisplaySettingsForNestingVolumeDelegate), Marshal.GetDelegateForFunctionPointer<GetAttributeDisplaySettingsForNestingVolumeDelegate>(vTable.getAttributeDisplaySettingsForNestingVolumeFunctionPtr) },
      { typeof(SetAttributeDisplaySettingsForNestingVolumeDelegate), Marshal.GetDelegateForFunctionPointer<SetAttributeDisplaySettingsForNestingVolumeDelegate>(vTable.setAttributeDisplaySettingsForNestingVolumeFunctionPtr) },
      { typeof(GetAttributeDisplaySettingsForNestingElementDelegate), Marshal.GetDelegateForFunctionPointer<GetAttributeDisplaySettingsForNestingElementDelegate>(vTable.getAttributeDisplaySettingsForNestingElementFunctionPtr) },
      { typeof(SetAttributeDisplaySettingsForNestingElementDelegate), Marshal.GetDelegateForFunctionPointer<SetAttributeDisplaySettingsForNestingElementDelegate>(vTable.setAttributeDisplaySettingsForNestingElementFunctionPtr) },
      { typeof(GetUserAttributeCountDelegate), Marshal.GetDelegateForFunctionPointer<GetUserAttributeCountDelegate>(vTable.getUserAttributeCountFunctionPtr) },
      { typeof(SetStandardPartDelegate), Marshal.GetDelegateForFunctionPointer<SetStandardPartDelegate>(vTable.setStandardPartFunctionPtr) },
      { typeof(SetSolidWallDelegate), Marshal.GetDelegateForFunctionPointer<SetSolidWallDelegate>(vTable.setSolidWallFunctionPtr) },
      { typeof(SetLogWallDelegate), Marshal.GetDelegateForFunctionPointer<SetLogWallDelegate>(vTable.setLogWallFunctionPtr) },
      { typeof(SetSolidFloorDelegate), Marshal.GetDelegateForFunctionPointer<SetSolidFloorDelegate>(vTable.setSolidFloorFunctionPtr) },
      { typeof(SetRoofDelegate), Marshal.GetDelegateForFunctionPointer<SetRoofDelegate>(vTable.setRoofFunctionPtr) },
      { typeof(SetSolidRoofDelegate), Marshal.GetDelegateForFunctionPointer<SetSolidRoofDelegate>(vTable.setSolidRoofFunctionPtr) },
      { typeof(GetNodeSymbolDelegate), Marshal.GetDelegateForFunctionPointer<GetNodeSymbolDelegate>(vTable.getNodeSymbolFunctionPtr) },
      { typeof(SetNodeSymbolDelegate), Marshal.GetDelegateForFunctionPointer<SetNodeSymbolDelegate>(vTable.setNodeSymbolFunctionPtr) },
      { typeof(IsProcessingDelegate), Marshal.GetDelegateForFunctionPointer<IsProcessingDelegate>(vTable.isProcessingFunctionPtr) },
      { typeof(GetStandardElementNameDelegate), Marshal.GetDelegateForFunctionPointer<GetStandardElementNameDelegate>(vTable.getStandardElementNameFunctionPtr) },
      { typeof(GetSteelShapeNameDelegate), Marshal.GetDelegateForFunctionPointer<GetSteelShapeNameDelegate>(vTable.getSteelShapeNameFunctionPtr) },
      { typeof(GetAssociatedNestingNumberDelegate), Marshal.GetDelegateForFunctionPointer<GetAssociatedNestingNumberDelegate>(vTable.getAssociatedNestingNumberFunctionPtr) },
      { typeof(GetAssociatedNestingNameDelegate), Marshal.GetDelegateForFunctionPointer<GetAssociatedNestingNameDelegate>(vTable.getAssociatedNestingNameFunctionPtr) },
      { typeof(EnableAttributeDisplayDelegate), Marshal.GetDelegateForFunctionPointer<EnableAttributeDisplayDelegate>(vTable.enableAttributeDisplayFunctionPtr) },
      { typeof(DisableAttributeDisplayDelegate), Marshal.GetDelegateForFunctionPointer<DisableAttributeDisplayDelegate>(vTable.disableAttributeDisplayFunctionPtr) },
      { typeof(IsAttributeDisplayEnabledDelegate), Marshal.GetDelegateForFunctionPointer<IsAttributeDisplayEnabledDelegate>(vTable.isAttributeDisplayEnabledFunctionPtr) },
      { typeof(GetAutoAttributeDelegate), Marshal.GetDelegateForFunctionPointer<GetAutoAttributeDelegate>(vTable.getAutoAttributeFunctionPtr) },
      { typeof(GetAutoAttributeNameDelegate), Marshal.GetDelegateForFunctionPointer<GetAutoAttributeNameDelegate>(vTable.getAutoAttributeNameFunctionPtr) },
      { typeof(UpdateAutoAttributesDelegate), Marshal.GetDelegateForFunctionPointer<UpdateAutoAttributesDelegate>(vTable.updateAutoAttributesFunctionPtr) },
      { typeof(IsFramedWallDelegate), Marshal.GetDelegateForFunctionPointer<IsFramedWallDelegate>(vTable.isFramedWallFunctionPtr) },
      { typeof(IsSolidWallDelegate), Marshal.GetDelegateForFunctionPointer<IsSolidWallDelegate>(vTable.isSolidWallFunctionPtr) },
      { typeof(IsLogWallDelegate), Marshal.GetDelegateForFunctionPointer<IsLogWallDelegate>(vTable.isLogWallFunctionPtr) },
      { typeof(IsFramedFloorDelegate), Marshal.GetDelegateForFunctionPointer<IsFramedFloorDelegate>(vTable.isFramedFloorFunctionPtr) },
      { typeof(IsSolidFloorDelegate), Marshal.GetDelegateForFunctionPointer<IsSolidFloorDelegate>(vTable.isSolidFloorFunctionPtr) },
      { typeof(IsFramedRoofDelegate), Marshal.GetDelegateForFunctionPointer<IsFramedRoofDelegate>(vTable.isFramedRoofFunctionPtr) },
      { typeof(IsSolidRoofDelegate), Marshal.GetDelegateForFunctionPointer<IsSolidRoofDelegate>(vTable.isSolidRoofFunctionPtr) },
      { typeof(GetAdditionalGuidDelegate), Marshal.GetDelegateForFunctionPointer<GetAdditionalGuidDelegate>(vTable.getAdditionalGuidFunctionPtr) },
      { typeof(SetAdditionalGuidDelegate), Marshal.GetDelegateForFunctionPointer<SetAdditionalGuidDelegate>(vTable.setAdditionalGuidFunctionPtr) },
      { typeof(GetPrefabLayerAllAssignedDelegate), Marshal.GetDelegateForFunctionPointer<GetPrefabLayerAllAssignedDelegate>(vTable.getPrefabLayerAllAssignedFunctionPtr) },
      { typeof(GetPrefabLayerWithDimensionsDelegate), Marshal.GetDelegateForFunctionPointer<GetPrefabLayerWithDimensionsDelegate>(vTable.getPrefabLayerWithDimensionsFunctionPtr) },
      { typeof(GetPrefabLayerWithoutDimensionsDelegate), Marshal.GetDelegateForFunctionPointer<GetPrefabLayerWithoutDimensionsDelegate>(vTable.getPrefabLayerWithoutDimensionsFunctionPtr) },
      { typeof(IsNestingParentDelegate), Marshal.GetDelegateForFunctionPointer<IsNestingParentDelegate>(vTable.isNestingParentFunctionPtr) },
      { typeof(IsNestingRawPartDelegate), Marshal.GetDelegateForFunctionPointer<IsNestingRawPartDelegate>(vTable.isNestingRawPartFunctionPtr) },
      { typeof(GetGroupListItemsDelegate), Marshal.GetDelegateForFunctionPointer<GetGroupListItemsDelegate>(vTable.getGroupListItemsFunctionPtr) },
      { typeof(GetSubgroupListItemsDelegate), Marshal.GetDelegateForFunctionPointer<GetSubgroupListItemsDelegate>(vTable.getSubgroupListItemsFunctionPtr) },
      { typeof(GetCommentListItemsDelegate), Marshal.GetDelegateForFunctionPointer<GetCommentListItemsDelegate>(vTable.getCommentListItemsFunctionPtr) },
      { typeof(GetSkuListItemsDelegate), Marshal.GetDelegateForFunctionPointer<GetSkuListItemsDelegate>(vTable.getSkuListItemsFunctionPtr) },
      { typeof(GetUserAttributeListItemsDelegate), Marshal.GetDelegateForFunctionPointer<GetUserAttributeListItemsDelegate>(vTable.getUserAttributeListItemsFunctionPtr) },
      { typeof(AddItemToGroupListDelegate), Marshal.GetDelegateForFunctionPointer<AddItemToGroupListDelegate>(vTable.addItemToGroupListFunctionPtr) },
      { typeof(AddItemToSubgroupListDelegate), Marshal.GetDelegateForFunctionPointer<AddItemToSubgroupListDelegate>(vTable.addItemToSubgroupListFunctionPtr) },
      { typeof(AddItemToCommentListDelegate), Marshal.GetDelegateForFunctionPointer<AddItemToCommentListDelegate>(vTable.addItemToCommentListFunctionPtr) },
      { typeof(AddItemToSkuListDelegate), Marshal.GetDelegateForFunctionPointer<AddItemToSkuListDelegate>(vTable.addItemToSkuListFunctionPtr) },
      { typeof(AddItemToUserAttributeListDelegate), Marshal.GetDelegateForFunctionPointer<AddItemToUserAttributeListDelegate>(vTable.addItemToUserAttributeListFunctionPtr) },
      { typeof(IsCircularMepDelegate), Marshal.GetDelegateForFunctionPointer<IsCircularMepDelegate>(vTable.isCircularMEPFunctionPtr) },
      { typeof(IsRectangularMepDelegate), Marshal.GetDelegateForFunctionPointer<IsRectangularMepDelegate>(vTable.isRectangularMEPFunctionPtr) },
      { typeof(DeleteItemFromGroupListDelegate), Marshal.GetDelegateForFunctionPointer<DeleteItemFromGroupListDelegate>(vTable.deleteItemFromGroupListFunctionPtr) },
      { typeof(DeleteItemFromSubgroupListDelegate), Marshal.GetDelegateForFunctionPointer<DeleteItemFromSubgroupListDelegate>(vTable.deleteItemFromSubgroupListFunctionPtr) },
      { typeof(DeleteItemFromCommentListDelegate), Marshal.GetDelegateForFunctionPointer<DeleteItemFromCommentListDelegate>(vTable.deleteItemFromCommentListFunctionPtr) },
      { typeof(DeleteItemFromSkuListDelegate), Marshal.GetDelegateForFunctionPointer<DeleteItemFromSkuListDelegate>(vTable.deleteItemFromSkuListFunctionPtr) },
      { typeof(DeleteItemFromUserAttributeListDelegate), Marshal.GetDelegateForFunctionPointer<DeleteItemFromUserAttributeListDelegate>(vTable.deleteItemFromUserAttributeListFunctionPtr) },
      { typeof(GetNameListItemsDelegate), Marshal.GetDelegateForFunctionPointer<GetNameListItemsDelegate>(vTable.getNameListItemsFunctionPtr) },
      { typeof(AddItemToNameListDelegate), Marshal.GetDelegateForFunctionPointer<AddItemToNameListDelegate>(vTable.addItemToNameListFunctionPtr) },
      { typeof(GetContainerNumberWithPrefixDelegate), Marshal.GetDelegateForFunctionPointer<GetContainerNumberWithPrefixDelegate>(vTable.getContainerNumberWithPrefixFunctionPtr) },
      { typeof(GetContainerNumberDelegate), Marshal.GetDelegateForFunctionPointer<GetContainerNumberDelegate>(vTable.getContainerNumberFunctionPtr) },
      { typeof(SetContainerNumberDelegate), Marshal.GetDelegateForFunctionPointer<SetContainerNumberDelegate>(vTable.setContainerNumberFunctionPtr) },
      { typeof(GetMachineCalculationStateDelegate), Marshal.GetDelegateForFunctionPointer<GetMachineCalculationStateDelegate>(vTable.getMachineCalculationStateFunctionPtr) },
      { typeof(GetMachineCalculationSetMachineTypeDelegate), Marshal.GetDelegateForFunctionPointer<GetMachineCalculationSetMachineTypeDelegate>(vTable.getMachineCalculationSetMachineTypeFunctionPtr) },
      { typeof(IsBtlProcessingGroupDelegate), Marshal.GetDelegateForFunctionPointer<IsBtlProcessingGroupDelegate>(vTable.isBTLProcessingGroupFunctionPtr) },
      { typeof(IsHundeggerProcessingGroupDelegate), Marshal.GetDelegateForFunctionPointer<IsHundeggerProcessingGroupDelegate>(vTable.isHundeggerProcessingGroupFunctionPtr) },
      { typeof(GetElementGroupingTypeDelegate), Marshal.GetDelegateForFunctionPointer<GetElementGroupingTypeDelegate>(vTable.getElementGroupingTypeFunctionPtr) },
      { typeof(SetElementGroupingTypeDelegate), Marshal.GetDelegateForFunctionPointer<SetElementGroupingTypeDelegate>(vTable.setElementGroupingTypeFunctionPtr) },
      { typeof(SetFramedWallDelegate), Marshal.GetDelegateForFunctionPointer<SetFramedWallDelegate>(vTable.setFramedWallFunctionPtr) },
      { typeof(DeleteUserAttributeDelegate), Marshal.GetDelegateForFunctionPointer<DeleteUserAttributeDelegate>(vTable.deleteUserAttributeFunctionPtr) },
      { typeof(SetFramedFloorDelegate), Marshal.GetDelegateForFunctionPointer<SetFramedFloorDelegate>(vTable.setFramedFloorFunctionPtr) },
      { typeof(SetFramedRoofDelegate), Marshal.GetDelegateForFunctionPointer<SetFramedRoofDelegate>(vTable.setFramedRoofFunctionPtr) },
      { typeof(GetNameListItemsByElementTypeDelegate), Marshal.GetDelegateForFunctionPointer<GetNameListItemsByElementTypeDelegate>(vTable.getNameListItemsByElementTypeFunctionPtr) },
      { typeof(IsAttributeVisibleInModifyWindowDelegate), Marshal.GetDelegateForFunctionPointer<IsAttributeVisibleInModifyWindowDelegate>(vTable.isAttributeVisibleInModifyWindowFunctionPtr) },
      { typeof(SetAttributeVisibilityInModifyWindowDelegate), Marshal.GetDelegateForFunctionPointer<SetAttributeVisibilityInModifyWindowDelegate>(vTable.setAttributeVisibilityInModifyWindowFunctionPtr) },
      { typeof(SetCuttingSetDelegate), Marshal.GetDelegateForFunctionPointer<SetCuttingSetDelegate>(vTable.setCuttingSetFunctionPtr) },
    };
  }

  public enum ElementGroupingType
  {
    Group = 1,
    Subgroup = 2,
    None = 3
  };

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public IntPtr GetLastError(IntPtr aErrorCode) => GetDelegate<GetLastErrorDelegate>().Invoke(_nativePtr, aErrorCode);
  public IntPtr GetName(ulong aId) => GetDelegate<GetNameDelegate>().Invoke(_nativePtr, aId);
  public void SetName(IntPtr aElementIdList, string aName) => GetDelegate<SetNameDelegate>().Invoke(_nativePtr, aElementIdList, aName);
  public IntPtr GetGroup(ulong aId) => GetDelegate<GetGroupDelegate>().Invoke(_nativePtr, aId);
  public void SetGroup(IntPtr aElementIdList, string aGroup) => GetDelegate<SetGroupDelegate>().Invoke(_nativePtr, aElementIdList, aGroup);
  public IntPtr GetSubgroup(ulong aId) => GetDelegate<GetSubgroupDelegate>().Invoke(_nativePtr, aId);
  public void SetSubgroup(IntPtr aElementIdList, string aSubgroup) => GetDelegate<SetSubgroupDelegate>().Invoke(_nativePtr, aElementIdList, aSubgroup);
  public IntPtr GetComment(ulong aId) => GetDelegate<GetCommentDelegate>().Invoke(_nativePtr, aId);
  public void SetComment(IntPtr aElementIdList, string aComment) => GetDelegate<SetCommentDelegate>().Invoke(_nativePtr, aElementIdList, aComment);
  public IntPtr GetUserAttribute(ulong aId, uint aNumber) => GetDelegate<GetUserAttributeDelegate>().Invoke(_nativePtr, aId, aNumber);
  public void SetUserAttribute(IntPtr aElementIdList, uint aNumber, string aUserAttribute) => GetDelegate<SetUserAttributeDelegate>().Invoke(_nativePtr, aElementIdList, aNumber, aUserAttribute);
  public IntPtr GetSku(ulong aId) => GetDelegate<GetSkuDelegate>().Invoke(_nativePtr, aId);
  public void SetSku(IntPtr aElementIdList, string aSku) => GetDelegate<SetSkuDelegate>().Invoke(_nativePtr, aElementIdList, aSku);
  public uint GetProductionNumber(ulong aId) => GetDelegate<GetProductionNumberDelegate>().Invoke(_nativePtr, aId);
  public void SetProductionNumber(IntPtr aElementIdList, uint aProductionNumber) => GetDelegate<SetProductionNumberDelegate>().Invoke(_nativePtr, aElementIdList, aProductionNumber);
  public uint GetPartNumber(ulong aId) => GetDelegate<GetPartNumberDelegate>().Invoke(_nativePtr, aId);
  public void SetPartNumber(IntPtr aElementIdList, uint aPartNumber) => GetDelegate<SetPartNumberDelegate>().Invoke(_nativePtr, aElementIdList, aPartNumber);
  public IntPtr GetAdditionalData(ulong aId, string aDataId) => GetDelegate<GetAdditionalDataDelegate>().Invoke(_nativePtr, aId, aDataId);
  public void SetAdditionalData(IntPtr aElementIdList, string aDataId, string aDataText) => GetDelegate<SetAdditionalDataDelegate>().Invoke(_nativePtr, aElementIdList, aDataId, aDataText);
  public void DeleteAdditionalData(IntPtr aElementIdList, string aDataId) => GetDelegate<DeleteAdditionalDataDelegate>().Invoke(_nativePtr, aElementIdList, aDataId);
  public IntPtr GetUserAttributeName(uint aNumber) => GetDelegate<GetUserAttributeNameDelegate>().Invoke(_nativePtr, aNumber);
  public void SetUserAttributeName(uint aNumber, string aUserAttributeName) => GetDelegate<SetUserAttributeNameDelegate>().Invoke(_nativePtr, aNumber, aUserAttributeName);
  public IntPtr GetWallSituation(ulong aId) => GetDelegate<GetWallSituationDelegate>().Invoke(_nativePtr, aId);
  public bool IsBeam(ulong aId) => GetDelegate<IsBeamDelegate>().Invoke(_nativePtr, aId);
  public bool IsPanel(ulong aId) => GetDelegate<IsPanelDelegate>().Invoke(_nativePtr, aId);
  public bool IsOpening(ulong aId) => GetDelegate<IsOpeningDelegate>().Invoke(_nativePtr, aId);
  public bool IsWall(ulong aId) => GetDelegate<IsWallDelegate>().Invoke(_nativePtr, aId);
  public bool IsFloor(ulong aId) => GetDelegate<IsFloorDelegate>().Invoke(_nativePtr, aId);
  public bool IsRoof(ulong aId) => GetDelegate<IsRoofDelegate>().Invoke(_nativePtr, aId);
  public bool IsMetal(ulong aId) => GetDelegate<IsMetalDelegate>().Invoke(_nativePtr, aId);
  public bool IsExportSolid(ulong aId) => GetDelegate<IsExportSolidDelegate>().Invoke(_nativePtr, aId);
  public bool IsContainer(ulong aId) => GetDelegate<IsContainerDelegate>().Invoke(_nativePtr, aId);
  public bool IsConnectorAxis(ulong aId) => GetDelegate<IsConnectorAxisDelegate>().Invoke(_nativePtr, aId);
  public bool IsDrilling(ulong aId) => GetDelegate<IsDrillingDelegate>().Invoke(_nativePtr, aId);
  public bool IsNode(ulong aId) => GetDelegate<IsNodeDelegate>().Invoke(_nativePtr, aId);
  public bool IsAuxiliary(ulong aId) => GetDelegate<IsAuxiliaryDelegate>().Invoke(_nativePtr, aId);
  public IntPtr GetElementMaterialName(ulong aId) => GetDelegate<GetElementMaterialNameDelegate>().Invoke(_nativePtr, aId);
  public IntPtr GetPrefabLayer(ulong aId) => GetDelegate<GetPrefabLayerDelegate>().Invoke(_nativePtr, aId);
  public IntPtr GetMachineCalculationSet(ulong aId) => GetDelegate<GetMachineCalculationSetDelegate>().Invoke(_nativePtr, aId);
  public IntPtr GetCuttingSet(ulong aId) => GetDelegate<GetCuttingSetDelegate>().Invoke(_nativePtr, aId);
  public void SetProcessTypeAndExtendedSettingsFromName(IntPtr aElementIdList) => GetDelegate<SetProcessTypeAndExtendedSettingsFromNameDelegate>().Invoke(_nativePtr, aElementIdList);
  public void SetNameProcessType(string aName, IntPtr aProcessType) => GetDelegate<SetNameProcessTypeDelegate>().Invoke(_nativePtr, aName, aProcessType);
  public IntPtr GetNameProcessType(string aName) => GetDelegate<GetNameProcessTypeDelegate>().Invoke(_nativePtr, aName);
  public void SetNameExtendedSettings(string aName, IntPtr aExtendedSettings) => GetDelegate<SetNameExtendedSettingsDelegate>().Invoke(_nativePtr, aName, aExtendedSettings);
  public IntPtr GetNameExtendedSettings(string aName) => GetDelegate<GetNameExtendedSettingsDelegate>().Invoke(_nativePtr, aName);
  public IntPtr GetOutputType(ulong aId) => GetDelegate<GetOutputTypeDelegate>().Invoke(_nativePtr, aId);
  public void SetOutputType(IntPtr aElementIdList, IntPtr aProcessType) => GetDelegate<SetOutputTypeDelegate>().Invoke(_nativePtr, aElementIdList, aProcessType);
  public IntPtr GetExtendedSettings(ulong aId) => GetDelegate<GetExtendedSettingsDelegate>().Invoke(_nativePtr, aId);
  public void SetExtendedSettings(IntPtr aElementIdList, IntPtr aExtendedSettings) => GetDelegate<SetExtendedSettingsDelegate>().Invoke(_nativePtr, aElementIdList, aExtendedSettings);
  public IntPtr GetElementType(ulong aId) => GetDelegate<GetElementTypeDelegate>().Invoke(_nativePtr, aId);
  public void SetWall(IntPtr aElementIdList) => GetDelegate<SetWallDelegate>().Invoke(_nativePtr, aElementIdList);
  public void SetFloor(IntPtr aElementIdList) => GetDelegate<SetFloorDelegate>().Invoke(_nativePtr, aElementIdList);
  public void SetOpening(IntPtr aElementIdList) => GetDelegate<SetOpeningDelegate>().Invoke(_nativePtr, aElementIdList);
  public IntPtr GetFasteningAttribute(ulong aId) => GetDelegate<GetFasteningAttributeDelegate>().Invoke(_nativePtr, aId);
  public void SetFasteningAttribute(IntPtr aElementIdList, string aValue) => GetDelegate<SetFasteningAttributeDelegate>().Invoke(_nativePtr, aElementIdList, aValue);
  public bool IsRoofSurface(ulong aId) => GetDelegate<IsRoofSurfaceDelegate>().Invoke(_nativePtr, aId);
  public bool IsCaddyObject(ulong aId) => GetDelegate<IsCaddyObjectDelegate>().Invoke(_nativePtr, aId);
  public void SetElementMaterial(IntPtr aElementIdList, ulong aMaterial) => GetDelegate<SetElementMaterialDelegate>().Invoke(_nativePtr, aElementIdList, aMaterial);
  public IntPtr GetAssemblyNumber(ulong aId) => GetDelegate<GetAssemblyNumberDelegate>().Invoke(_nativePtr, aId);
  public void SetAssemblyNumber(IntPtr aElementIdList, string aAssemblyNumber) => GetDelegate<SetAssemblyNumberDelegate>().Invoke(_nativePtr, aElementIdList, aAssemblyNumber);
  public uint GetListQuantity(ulong aId) => GetDelegate<GetListQuantityDelegate>().Invoke(_nativePtr, aId);
  public void SetListQuantity(IntPtr aElementIdList, uint aListQuantity) => GetDelegate<SetListQuantityDelegate>().Invoke(_nativePtr, aElementIdList, aListQuantity);
  public bool IsEnvelope(ulong aId) => GetDelegate<IsEnvelopeDelegate>().Invoke(_nativePtr, aId);
  public void SetLayerSettings(IntPtr aElementIdList, IntPtr aLayerSettings) => GetDelegate<SetLayerSettingsDelegate>().Invoke(_nativePtr, aElementIdList, aLayerSettings);
  public void SetIgnoreInVbaCalculation(IntPtr aElements, bool aIgnore) => GetDelegate<SetIgnoreInVbaCalculationDelegate>().Invoke(_nativePtr, aElements, aIgnore);
  public bool GetIgnoreInVbaCalculation(ulong aElement) => GetDelegate<GetIgnoreInVbaCalculationDelegate>().Invoke(_nativePtr, aElement);
  public void ClearErrors() => GetDelegate<ClearErrorsDelegate>().Invoke(_nativePtr);
  public bool IsArchitectureWall2dc(ulong aElement) => GetDelegate<IsArchitectureWall2dcDelegate>().Invoke(_nativePtr, aElement);
  public bool IsArchitectureWallXml(ulong aElement) => GetDelegate<IsArchitectureWallXmlDelegate>().Invoke(_nativePtr, aElement);
  public void SetReferenceWall2dc(IntPtr aElements, string a2dcFilePath) => GetDelegate<SetReferenceWall2dcDelegate>().Invoke(_nativePtr, aElements, a2dcFilePath);
  public bool IsSurface(ulong aId) => GetDelegate<IsSurfaceDelegate>().Invoke(_nativePtr, aId);
  public bool IsLine(ulong aId) => GetDelegate<IsLineDelegate>().Invoke(_nativePtr, aId);
  public IntPtr GetAttributeDisplaySettingsFor3D() => GetDelegate<GetAttributeDisplaySettingsFor3DDelegate>().Invoke(_nativePtr);
  public void SetAttributeDisplaySettingsFor3D(IntPtr aSettings) => GetDelegate<SetAttributeDisplaySettingsFor3DDelegate>().Invoke(_nativePtr, aSettings);
  public IntPtr GetAttributeDisplaySettingsFor2D() => GetDelegate<GetAttributeDisplaySettingsFor2DDelegate>().Invoke(_nativePtr);
  public void SetAttributeDisplaySettingsFor2D(IntPtr aSettings) => GetDelegate<SetAttributeDisplaySettingsFor2DDelegate>().Invoke(_nativePtr, aSettings);
  public IntPtr GetAttributeDisplaySettingsFor2DWithoutLayout() => GetDelegate<GetAttributeDisplaySettingsFor2DWithoutLayoutDelegate>().Invoke(_nativePtr);
  public void SetAttributeDisplaySettingsFor2DWithoutLayout(IntPtr aSettings) => GetDelegate<SetAttributeDisplaySettingsFor2DWithoutLayoutDelegate>().Invoke(_nativePtr, aSettings);
  public IntPtr GetAttributeDisplaySettingsFor2DWithLayout() => GetDelegate<GetAttributeDisplaySettingsFor2DWithLayoutDelegate>().Invoke(_nativePtr);
  public void SetAttributeDisplaySettingsFor2DWithLayout(IntPtr aSettings) => GetDelegate<SetAttributeDisplaySettingsFor2DWithLayoutDelegate>().Invoke(_nativePtr, aSettings);
  public IntPtr GetAttributeDisplaySettingsForExportSolid() => GetDelegate<GetAttributeDisplaySettingsForExportSolidDelegate>().Invoke(_nativePtr);
  public void SetAttributeDisplaySettingsForExportSolid(IntPtr aSettings) => GetDelegate<SetAttributeDisplaySettingsForExportSolidDelegate>().Invoke(_nativePtr, aSettings);
  public IntPtr GetAttributeDisplaySettingsForContainer() => GetDelegate<GetAttributeDisplaySettingsForContainerDelegate>().Invoke(_nativePtr);
  public void SetAttributeDisplaySettingsForContainer(IntPtr aSettings) => GetDelegate<SetAttributeDisplaySettingsForContainerDelegate>().Invoke(_nativePtr, aSettings);
  public IntPtr GetAttributeDisplaySettingsForMachine() => GetDelegate<GetAttributeDisplaySettingsForMachineDelegate>().Invoke(_nativePtr);
  public void SetAttributeDisplaySettingsForMachine(IntPtr aSettings) => GetDelegate<SetAttributeDisplaySettingsForMachineDelegate>().Invoke(_nativePtr, aSettings);
  public IntPtr GetAttributeDisplaySettingsForLogWallBeam() => GetDelegate<GetAttributeDisplaySettingsForLogWallBeamDelegate>().Invoke(_nativePtr);
  public void SetAttributeDisplaySettingsForLogWallBeam(IntPtr aSettings) => GetDelegate<SetAttributeDisplaySettingsForLogWallBeamDelegate>().Invoke(_nativePtr, aSettings);
  public IntPtr GetAttributeDisplaySettingsForLogWallPanel() => GetDelegate<GetAttributeDisplaySettingsForLogWallPanelDelegate>().Invoke(_nativePtr);
  public void SetAttributeDisplaySettingsForLogWallPanel(IntPtr aSettings) => GetDelegate<SetAttributeDisplaySettingsForLogWallPanelDelegate>().Invoke(_nativePtr, aSettings);
  public IntPtr GetAttributeDisplaySettingsForLogWallAxis() => GetDelegate<GetAttributeDisplaySettingsForLogWallAxisDelegate>().Invoke(_nativePtr);
  public void SetAttributeDisplaySettingsForLogWallAxis(IntPtr aSettings) => GetDelegate<SetAttributeDisplaySettingsForLogWallAxisDelegate>().Invoke(_nativePtr, aSettings);
  public IntPtr GetAttributeDisplaySettingsForLogWallOpening() => GetDelegate<GetAttributeDisplaySettingsForLogWallOpeningDelegate>().Invoke(_nativePtr);
  public void SetAttributeDisplaySettingsForLogWallOpening(IntPtr aSettings) => GetDelegate<SetAttributeDisplaySettingsForLogWallOpeningDelegate>().Invoke(_nativePtr, aSettings);
  public IntPtr GetAttributeDisplaySettingsForFramedWallBeam() => GetDelegate<GetAttributeDisplaySettingsForFramedWallBeamDelegate>().Invoke(_nativePtr);
  public void SetAttributeDisplaySettingsForFramedWallBeam(IntPtr aSettings) => GetDelegate<SetAttributeDisplaySettingsForFramedWallBeamDelegate>().Invoke(_nativePtr, aSettings);
  public IntPtr GetAttributeDisplaySettingsForFramedWallPanel() => GetDelegate<GetAttributeDisplaySettingsForFramedWallPanelDelegate>().Invoke(_nativePtr);
  public void SetAttributeDisplaySettingsForFramedWallPanel(IntPtr aSettings) => GetDelegate<SetAttributeDisplaySettingsForFramedWallPanelDelegate>().Invoke(_nativePtr, aSettings);
  public IntPtr GetAttributeDisplaySettingsForFramedWallAxis() => GetDelegate<GetAttributeDisplaySettingsForFramedWallAxisDelegate>().Invoke(_nativePtr);
  public void SetAttributeDisplaySettingsForFramedWallAxis(IntPtr aSettings) => GetDelegate<SetAttributeDisplaySettingsForFramedWallAxisDelegate>().Invoke(_nativePtr, aSettings);
  public IntPtr GetAttributeDisplaySettingsForFramedWallOpening() => GetDelegate<GetAttributeDisplaySettingsForFramedWallOpeningDelegate>().Invoke(_nativePtr);
  public void SetAttributeDisplaySettingsForFramedWallOpening(IntPtr aSettings) => GetDelegate<SetAttributeDisplaySettingsForFramedWallOpeningDelegate>().Invoke(_nativePtr, aSettings);
  public IntPtr GetAttributeDisplaySettingsForSolidWallBeam() => GetDelegate<GetAttributeDisplaySettingsForSolidWallBeamDelegate>().Invoke(_nativePtr);
  public void SetAttributeDisplaySettingsForSolidWallBeam(IntPtr aSettings) => GetDelegate<SetAttributeDisplaySettingsForSolidWallBeamDelegate>().Invoke(_nativePtr, aSettings);
  public IntPtr GetAttributeDisplaySettingsForSolidWallPanel() => GetDelegate<GetAttributeDisplaySettingsForSolidWallPanelDelegate>().Invoke(_nativePtr);
  public void SetAttributeDisplaySettingsForSolidWallPanel(IntPtr aSettings) => GetDelegate<SetAttributeDisplaySettingsForSolidWallPanelDelegate>().Invoke(_nativePtr, aSettings);
  public IntPtr GetAttributeDisplaySettingsForSolidWallAxis() => GetDelegate<GetAttributeDisplaySettingsForSolidWallAxisDelegate>().Invoke(_nativePtr);
  public void SetAttributeDisplaySettingsForSolidWallAxis(IntPtr aSettings) => GetDelegate<SetAttributeDisplaySettingsForSolidWallAxisDelegate>().Invoke(_nativePtr, aSettings);
  public IntPtr GetAttributeDisplaySettingsForSolidWallOpening() => GetDelegate<GetAttributeDisplaySettingsForSolidWallOpeningDelegate>().Invoke(_nativePtr);
  public void SetAttributeDisplaySettingsForSolidWallOpening(IntPtr aSettings) => GetDelegate<SetAttributeDisplaySettingsForSolidWallOpeningDelegate>().Invoke(_nativePtr, aSettings);
  public IntPtr GetAttributeDisplaySettingsForNestingVolume() => GetDelegate<GetAttributeDisplaySettingsForNestingVolumeDelegate>().Invoke(_nativePtr);
  public void SetAttributeDisplaySettingsForNestingVolume(IntPtr aSettings) => GetDelegate<SetAttributeDisplaySettingsForNestingVolumeDelegate>().Invoke(_nativePtr, aSettings);
  public IntPtr GetAttributeDisplaySettingsForNestingElement() => GetDelegate<GetAttributeDisplaySettingsForNestingElementDelegate>().Invoke(_nativePtr);
  public void SetAttributeDisplaySettingsForNestingElement(IntPtr aSettings) => GetDelegate<SetAttributeDisplaySettingsForNestingElementDelegate>().Invoke(_nativePtr, aSettings);
  public uint GetUserAttributeCount() => GetDelegate<GetUserAttributeCountDelegate>().Invoke(_nativePtr);
  public void SetStandardPart(IntPtr aElements) => GetDelegate<SetStandardPartDelegate>().Invoke(_nativePtr, aElements);
  public void SetSolidWall(IntPtr aElements) => GetDelegate<SetSolidWallDelegate>().Invoke(_nativePtr, aElements);
  public void SetLogWall(IntPtr aElements) => GetDelegate<SetLogWallDelegate>().Invoke(_nativePtr, aElements);
  public void SetSolidFloor(IntPtr aElements) => GetDelegate<SetSolidFloorDelegate>().Invoke(_nativePtr, aElements);
  public void SetRoof(IntPtr aElements) => GetDelegate<SetRoofDelegate>().Invoke(_nativePtr, aElements);
  public void SetSolidRoof(IntPtr aElements) => GetDelegate<SetSolidRoofDelegate>().Invoke(_nativePtr, aElements);
  public int GetNodeSymbol(ulong aElement) => GetDelegate<GetNodeSymbolDelegate>().Invoke(_nativePtr, aElement);
  public void SetNodeSymbol(IntPtr aElements, int aSymbol) => GetDelegate<SetNodeSymbolDelegate>().Invoke(_nativePtr, aElements, aSymbol);
  public bool IsProcessing(ulong aId) => GetDelegate<IsProcessingDelegate>().Invoke(_nativePtr, aId);
  public IntPtr GetStandardElementName(ulong aId) => GetDelegate<GetStandardElementNameDelegate>().Invoke(_nativePtr, aId);
  public IntPtr GetSteelShapeName(ulong aId) => GetDelegate<GetSteelShapeNameDelegate>().Invoke(_nativePtr, aId);
  public IntPtr GetAssociatedNestingNumber(ulong aId) => GetDelegate<GetAssociatedNestingNumberDelegate>().Invoke(_nativePtr, aId);
  public IntPtr GetAssociatedNestingName(ulong aId) => GetDelegate<GetAssociatedNestingNameDelegate>().Invoke(_nativePtr, aId);
  public void EnableAttributeDisplay() => GetDelegate<EnableAttributeDisplayDelegate>().Invoke(_nativePtr);
  public void DisableAttributeDisplay() => GetDelegate<DisableAttributeDisplayDelegate>().Invoke(_nativePtr);
  public bool IsAttributeDisplayEnabled() => GetDelegate<IsAttributeDisplayEnabledDelegate>().Invoke(_nativePtr);
  public IntPtr GetAutoAttribute(ulong aId, uint aNumber) => GetDelegate<GetAutoAttributeDelegate>().Invoke(_nativePtr, aId, aNumber);
  public IntPtr GetAutoAttributeName(uint aNumber) => GetDelegate<GetAutoAttributeNameDelegate>().Invoke(_nativePtr, aNumber);
  public void UpdateAutoAttributes() => GetDelegate<UpdateAutoAttributesDelegate>().Invoke(_nativePtr);
  public bool IsFramedWall(ulong aId) => GetDelegate<IsFramedWallDelegate>().Invoke(_nativePtr, aId);
  public bool IsSolidWall(ulong aId) => GetDelegate<IsSolidWallDelegate>().Invoke(_nativePtr, aId);
  public bool IsLogWall(ulong aId) => GetDelegate<IsLogWallDelegate>().Invoke(_nativePtr, aId);
  public bool IsFramedFloor(ulong aId) => GetDelegate<IsFramedFloorDelegate>().Invoke(_nativePtr, aId);
  public bool IsSolidFloor(ulong aId) => GetDelegate<IsSolidFloorDelegate>().Invoke(_nativePtr, aId);
  public bool IsFramedRoof(ulong aId) => GetDelegate<IsFramedRoofDelegate>().Invoke(_nativePtr, aId);
  public bool IsSolidRoof(ulong aId) => GetDelegate<IsSolidRoofDelegate>().Invoke(_nativePtr, aId);
  public IntPtr GetAdditionalGuid(ulong aId, string aDataId) => GetDelegate<GetAdditionalGuidDelegate>().Invoke(_nativePtr, aId, aDataId);
  public void SetAdditionalGuid(IntPtr aElementIdList, string aDataId, string aGuid) => GetDelegate<SetAdditionalGuidDelegate>().Invoke(_nativePtr, aElementIdList, aDataId, aGuid);
  public List<int> GetPrefabLayerAllAssigned(ulong aId) => GetDelegate<GetPrefabLayerAllAssignedDelegate>().Invoke(_nativePtr, aId);
  public List<int> GetPrefabLayerWithDimensions(ulong aId) => GetDelegate<GetPrefabLayerWithDimensionsDelegate>().Invoke(_nativePtr, aId);
  public List<int> GetPrefabLayerWithoutDimensions(ulong aId) => GetDelegate<GetPrefabLayerWithoutDimensionsDelegate>().Invoke(_nativePtr, aId);
  public bool IsNestingParent(ulong aId) => GetDelegate<IsNestingParentDelegate>().Invoke(_nativePtr, aId);
  public bool IsNestingRawPart(ulong aId) => GetDelegate<IsNestingRawPartDelegate>().Invoke(_nativePtr, aId);
  public IntPtr GetGroupListItems() => GetDelegate<GetGroupListItemsDelegate>().Invoke(_nativePtr);
  public IntPtr GetSubgroupListItems() => GetDelegate<GetSubgroupListItemsDelegate>().Invoke(_nativePtr);
  public IntPtr GetCommentListItems() => GetDelegate<GetCommentListItemsDelegate>().Invoke(_nativePtr);
  public IntPtr GetSkuListItems() => GetDelegate<GetSkuListItemsDelegate>().Invoke(_nativePtr);
  public IntPtr GetUserAttributeListItems(uint aNumber) => GetDelegate<GetUserAttributeListItemsDelegate>().Invoke(_nativePtr, aNumber);
  public void AddItemToGroupList(string aItem) => GetDelegate<AddItemToGroupListDelegate>().Invoke(_nativePtr, aItem);
  public void AddItemToSubgroupList(string aItem) => GetDelegate<AddItemToSubgroupListDelegate>().Invoke(_nativePtr, aItem);
  public void AddItemToCommentList(string aItem) => GetDelegate<AddItemToCommentListDelegate>().Invoke(_nativePtr, aItem);
  public void AddItemToSkuList(string aItem) => GetDelegate<AddItemToSkuListDelegate>().Invoke(_nativePtr, aItem);
  public void AddItemToUserAttributeList(uint aNumber, string aItem) => GetDelegate<AddItemToUserAttributeListDelegate>().Invoke(_nativePtr, aNumber, aItem);
  public bool IsCircularMep(ulong aId) => GetDelegate<IsCircularMepDelegate>().Invoke(_nativePtr, aId);
  public bool IsRectangularMep(ulong aId) => GetDelegate<IsRectangularMepDelegate>().Invoke(_nativePtr, aId);
  public bool DeleteItemFromGroupList(string aItem) => GetDelegate<DeleteItemFromGroupListDelegate>().Invoke(_nativePtr, aItem);
  public bool DeleteItemFromSubgroupList(string aItem) => GetDelegate<DeleteItemFromSubgroupListDelegate>().Invoke(_nativePtr, aItem);
  public bool DeleteItemFromCommentList(string aItem) => GetDelegate<DeleteItemFromCommentListDelegate>().Invoke(_nativePtr, aItem);
  public bool DeleteItemFromSkuList(string aItem) => GetDelegate<DeleteItemFromSkuListDelegate>().Invoke(_nativePtr, aItem);
  public bool DeleteItemFromUserAttributeList(uint aNumber, string aItem) => GetDelegate<DeleteItemFromUserAttributeListDelegate>().Invoke(_nativePtr, aNumber, aItem);
  public IntPtr GetNameListItems() => GetDelegate<GetNameListItemsDelegate>().Invoke(_nativePtr);
  public void AddItemToNameList(string aItem) => GetDelegate<AddItemToNameListDelegate>().Invoke(_nativePtr, aItem);
  public IntPtr GetContainerNumberWithPrefix(ulong aId) => GetDelegate<GetContainerNumberWithPrefixDelegate>().Invoke(_nativePtr, aId);
  public uint GetContainerNumber(ulong aId) => GetDelegate<GetContainerNumberDelegate>().Invoke(_nativePtr, aId);
  public void SetContainerNumber(IntPtr aElements, uint aNumber) => GetDelegate<SetContainerNumberDelegate>().Invoke(_nativePtr, aElements, aNumber);
  public IntPtr GetMachineCalculationState(ulong aId) => GetDelegate<GetMachineCalculationStateDelegate>().Invoke(_nativePtr, aId);
  public IntPtr GetMachineCalculationSetMachineType(ulong aId) => GetDelegate<GetMachineCalculationSetMachineTypeDelegate>().Invoke(_nativePtr, aId);
  public bool IsBtlProcessingGroup(ulong aId) => GetDelegate<IsBtlProcessingGroupDelegate>().Invoke(_nativePtr, aId);
  public bool IsHundeggerProcessingGroup(ulong aId) => GetDelegate<IsHundeggerProcessingGroupDelegate>().Invoke(_nativePtr, aId);
  public ElementGroupingType GetElementGroupingType() => GetDelegate<GetElementGroupingTypeDelegate>().Invoke(_nativePtr);
  public void SetElementGroupingType(ElementGroupingType aType) => GetDelegate<SetElementGroupingTypeDelegate>().Invoke(_nativePtr, aType);
  public void SetFramedWall(IntPtr aElementIdList) => GetDelegate<SetFramedWallDelegate>().Invoke(_nativePtr, aElementIdList);
  public bool DeleteUserAttribute(uint aNumber) => GetDelegate<DeleteUserAttributeDelegate>().Invoke(_nativePtr, aNumber);
  public void SetFramedFloor(IntPtr aElementIdList) => GetDelegate<SetFramedFloorDelegate>().Invoke(_nativePtr, aElementIdList);
  public void SetFramedRoof(IntPtr aElementIdList) => GetDelegate<SetFramedRoofDelegate>().Invoke(_nativePtr, aElementIdList);
  public IntPtr GetNameListItemsByElementType(IntPtr aType) => GetDelegate<GetNameListItemsByElementTypeDelegate>().Invoke(_nativePtr, aType);
  public bool IsAttributeVisibleInModifyWindow(uint aNumber) => GetDelegate<IsAttributeVisibleInModifyWindowDelegate>().Invoke(_nativePtr, aNumber);
  public void SetAttributeVisibilityInModifyWindow(uint aNumber, bool aVisibility) => GetDelegate<SetAttributeVisibilityInModifyWindowDelegate>().Invoke(_nativePtr, aNumber, aVisibility);
  public bool SetCuttingSet(IntPtr aElementIdList, string aCuttingSetName) => GetDelegate<SetCuttingSetDelegate>().Invoke(_nativePtr, aElementIdList, aCuttingSetName);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class AttributeControllerInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr getLastErrorFunctionPtr;
    internal IntPtr getNameFunctionPtr;
    internal IntPtr setNameFunctionPtr;
    internal IntPtr getGroupFunctionPtr;
    internal IntPtr setGroupFunctionPtr;
    internal IntPtr getSubgroupFunctionPtr;
    internal IntPtr setSubgroupFunctionPtr;
    internal IntPtr getCommentFunctionPtr;
    internal IntPtr setCommentFunctionPtr;
    internal IntPtr getUserAttributeFunctionPtr;
    internal IntPtr setUserAttributeFunctionPtr;
    internal IntPtr getSKUFunctionPtr;
    internal IntPtr setSKUFunctionPtr;
    internal IntPtr getProductionNumberFunctionPtr;
    internal IntPtr setProductionNumberFunctionPtr;
    internal IntPtr getPartNumberFunctionPtr;
    internal IntPtr setPartNumberFunctionPtr;
    internal IntPtr getAdditionalDataFunctionPtr;
    internal IntPtr setAdditionalDataFunctionPtr;
    internal IntPtr deleteAdditionalDataFunctionPtr;
    internal IntPtr getUserAttributeNameFunctionPtr;
    internal IntPtr setUserAttributeNameFunctionPtr;
    internal IntPtr getWallSituationFunctionPtr;
    internal IntPtr isBeamFunctionPtr;
    internal IntPtr isPanelFunctionPtr;
    internal IntPtr isOpeningFunctionPtr;
    internal IntPtr isWallFunctionPtr;
    internal IntPtr isFloorFunctionPtr;
    internal IntPtr isRoofFunctionPtr;
    internal IntPtr isMetalFunctionPtr;
    internal IntPtr isExportSolidFunctionPtr;
    internal IntPtr isContainerFunctionPtr;
    internal IntPtr isConnectorAxisFunctionPtr;
    internal IntPtr isDrillingFunctionPtr;
    internal IntPtr isNodeFunctionPtr;
    internal IntPtr isAuxiliaryFunctionPtr;
    internal IntPtr getElementMaterialNameFunctionPtr;
    internal IntPtr getPrefabLayerFunctionPtr;
    internal IntPtr getMachineCalculationSetFunctionPtr;
    internal IntPtr getCuttingSetFunctionPtr;
    internal IntPtr setProcessTypeAndExtendedSettingsFromNameFunctionPtr;
    internal IntPtr setNameProcessTypeFunctionPtr;
    internal IntPtr getNameProcessTypeFunctionPtr;
    internal IntPtr setNameExtendedSettingsFunctionPtr;
    internal IntPtr getNameExtendedSettingsFunctionPtr;
    internal IntPtr getOutputTypeFunctionPtr;
    internal IntPtr setOutputTypeFunctionPtr;
    internal IntPtr getExtendedSettingsFunctionPtr;
    internal IntPtr setExtendedSettingsFunctionPtr;
    internal IntPtr getElementTypeFunctionPtr;
    internal IntPtr setWallFunctionPtr;
    internal IntPtr setFloorFunctionPtr;
    internal IntPtr setOpeningFunctionPtr;
    internal IntPtr getFasteningAttributeFunctionPtr;
    internal IntPtr setFasteningAttributeFunctionPtr;
    internal IntPtr isRoofSurfaceFunctionPtr;
    internal IntPtr isCaddyObjectFunctionPtr;
    internal IntPtr setElementMaterialFunctionPtr;
    internal IntPtr getAssemblyNumberFunctionPtr;
    internal IntPtr setAssemblyNumberFunctionPtr;
    internal IntPtr getListQuantityFunctionPtr;
    internal IntPtr setListQuantityFunctionPtr;
    internal IntPtr isEnvelopeFunctionPtr;
    internal IntPtr setLayerSettingsFunctionPtr;
    internal IntPtr setIgnoreInVBACalculationFunctionPtr;
    internal IntPtr getIgnoreInVBACalculationFunctionPtr;
    internal IntPtr clearErrorsFunctionPtr;
    internal IntPtr isArchitectureWall2dcFunctionPtr;
    internal IntPtr isArchitectureWallXmlFunctionPtr;
    internal IntPtr setReferenceWall2dcFunctionPtr;
    internal IntPtr isSurfaceFunctionPtr;
    internal IntPtr isLineFunctionPtr;
    internal IntPtr getAttributeDisplaySettingsFor3DFunctionPtr;
    internal IntPtr setAttributeDisplaySettingsFor3DFunctionPtr;
    internal IntPtr getAttributeDisplaySettingsFor2DFunctionPtr;
    internal IntPtr setAttributeDisplaySettingsFor2DFunctionPtr;
    internal IntPtr getAttributeDisplaySettingsFor2DWithoutLayoutFunctionPtr;
    internal IntPtr setAttributeDisplaySettingsFor2DWithoutLayoutFunctionPtr;
    internal IntPtr getAttributeDisplaySettingsFor2DWithLayoutFunctionPtr;
    internal IntPtr setAttributeDisplaySettingsFor2DWithLayoutFunctionPtr;
    internal IntPtr getAttributeDisplaySettingsForExportSolidFunctionPtr;
    internal IntPtr setAttributeDisplaySettingsForExportSolidFunctionPtr;
    internal IntPtr getAttributeDisplaySettingsForContainerFunctionPtr;
    internal IntPtr setAttributeDisplaySettingsForContainerFunctionPtr;
    internal IntPtr getAttributeDisplaySettingsForMachineFunctionPtr;
    internal IntPtr setAttributeDisplaySettingsForMachineFunctionPtr;
    internal IntPtr getAttributeDisplaySettingsForLogWallBeamFunctionPtr;
    internal IntPtr setAttributeDisplaySettingsForLogWallBeamFunctionPtr;
    internal IntPtr getAttributeDisplaySettingsForLogWallPanelFunctionPtr;
    internal IntPtr setAttributeDisplaySettingsForLogWallPanelFunctionPtr;
    internal IntPtr getAttributeDisplaySettingsForLogWallAxisFunctionPtr;
    internal IntPtr setAttributeDisplaySettingsForLogWallAxisFunctionPtr;
    internal IntPtr getAttributeDisplaySettingsForLogWallOpeningFunctionPtr;
    internal IntPtr setAttributeDisplaySettingsForLogWallOpeningFunctionPtr;
    internal IntPtr getAttributeDisplaySettingsForFramedWallBeamFunctionPtr;
    internal IntPtr setAttributeDisplaySettingsForFramedWallBeamFunctionPtr;
    internal IntPtr getAttributeDisplaySettingsForFramedWallPanelFunctionPtr;
    internal IntPtr setAttributeDisplaySettingsForFramedWallPanelFunctionPtr;
    internal IntPtr getAttributeDisplaySettingsForFramedWallAxisFunctionPtr;
    internal IntPtr setAttributeDisplaySettingsForFramedWallAxisFunctionPtr;
    internal IntPtr getAttributeDisplaySettingsForFramedWallOpeningFunctionPtr;
    internal IntPtr setAttributeDisplaySettingsForFramedWallOpeningFunctionPtr;
    internal IntPtr getAttributeDisplaySettingsForSolidWallBeamFunctionPtr;
    internal IntPtr setAttributeDisplaySettingsForSolidWallBeamFunctionPtr;
    internal IntPtr getAttributeDisplaySettingsForSolidWallPanelFunctionPtr;
    internal IntPtr setAttributeDisplaySettingsForSolidWallPanelFunctionPtr;
    internal IntPtr getAttributeDisplaySettingsForSolidWallAxisFunctionPtr;
    internal IntPtr setAttributeDisplaySettingsForSolidWallAxisFunctionPtr;
    internal IntPtr getAttributeDisplaySettingsForSolidWallOpeningFunctionPtr;
    internal IntPtr setAttributeDisplaySettingsForSolidWallOpeningFunctionPtr;
    internal IntPtr getAttributeDisplaySettingsForNestingVolumeFunctionPtr;
    internal IntPtr setAttributeDisplaySettingsForNestingVolumeFunctionPtr;
    internal IntPtr getAttributeDisplaySettingsForNestingElementFunctionPtr;
    internal IntPtr setAttributeDisplaySettingsForNestingElementFunctionPtr;
    internal IntPtr getUserAttributeCountFunctionPtr;
    internal IntPtr setStandardPartFunctionPtr;
    internal IntPtr setSolidWallFunctionPtr;
    internal IntPtr setLogWallFunctionPtr;
    internal IntPtr setSolidFloorFunctionPtr;
    internal IntPtr setRoofFunctionPtr;
    internal IntPtr setSolidRoofFunctionPtr;
    internal IntPtr getNodeSymbolFunctionPtr;
    internal IntPtr setNodeSymbolFunctionPtr;
    internal IntPtr isProcessingFunctionPtr;
    internal IntPtr getStandardElementNameFunctionPtr;
    internal IntPtr getSteelShapeNameFunctionPtr;
    internal IntPtr getAssociatedNestingNumberFunctionPtr;
    internal IntPtr getAssociatedNestingNameFunctionPtr;
    internal IntPtr enableAttributeDisplayFunctionPtr;
    internal IntPtr disableAttributeDisplayFunctionPtr;
    internal IntPtr isAttributeDisplayEnabledFunctionPtr;
    internal IntPtr getAutoAttributeFunctionPtr;
    internal IntPtr getAutoAttributeNameFunctionPtr;
    internal IntPtr updateAutoAttributesFunctionPtr;
    internal IntPtr isFramedWallFunctionPtr;
    internal IntPtr isSolidWallFunctionPtr;
    internal IntPtr isLogWallFunctionPtr;
    internal IntPtr isFramedFloorFunctionPtr;
    internal IntPtr isSolidFloorFunctionPtr;
    internal IntPtr isFramedRoofFunctionPtr;
    internal IntPtr isSolidRoofFunctionPtr;
    internal IntPtr getAdditionalGuidFunctionPtr;
    internal IntPtr setAdditionalGuidFunctionPtr;
    internal IntPtr getPrefabLayerAllAssignedFunctionPtr;
    internal IntPtr getPrefabLayerWithDimensionsFunctionPtr;
    internal IntPtr getPrefabLayerWithoutDimensionsFunctionPtr;
    internal IntPtr isNestingParentFunctionPtr;
    internal IntPtr isNestingRawPartFunctionPtr;
    internal IntPtr getGroupListItemsFunctionPtr;
    internal IntPtr getSubgroupListItemsFunctionPtr;
    internal IntPtr getCommentListItemsFunctionPtr;
    internal IntPtr getSkuListItemsFunctionPtr;
    internal IntPtr getUserAttributeListItemsFunctionPtr;
    internal IntPtr addItemToGroupListFunctionPtr;
    internal IntPtr addItemToSubgroupListFunctionPtr;
    internal IntPtr addItemToCommentListFunctionPtr;
    internal IntPtr addItemToSkuListFunctionPtr;
    internal IntPtr addItemToUserAttributeListFunctionPtr;
    internal IntPtr isCircularMEPFunctionPtr;
    internal IntPtr isRectangularMEPFunctionPtr;
    internal IntPtr deleteItemFromGroupListFunctionPtr;
    internal IntPtr deleteItemFromSubgroupListFunctionPtr;
    internal IntPtr deleteItemFromCommentListFunctionPtr;
    internal IntPtr deleteItemFromSkuListFunctionPtr;
    internal IntPtr deleteItemFromUserAttributeListFunctionPtr;
    internal IntPtr getNameListItemsFunctionPtr;
    internal IntPtr addItemToNameListFunctionPtr;
    internal IntPtr getContainerNumberWithPrefixFunctionPtr;
    internal IntPtr getContainerNumberFunctionPtr;
    internal IntPtr setContainerNumberFunctionPtr;
    internal IntPtr getMachineCalculationStateFunctionPtr;
    internal IntPtr getMachineCalculationSetMachineTypeFunctionPtr;
    internal IntPtr isBTLProcessingGroupFunctionPtr;
    internal IntPtr isHundeggerProcessingGroupFunctionPtr;
    internal IntPtr getElementGroupingTypeFunctionPtr;
    internal IntPtr setElementGroupingTypeFunctionPtr;
    internal IntPtr setFramedWallFunctionPtr;
    internal IntPtr deleteUserAttributeFunctionPtr;
    internal IntPtr setFramedFloorFunctionPtr;
    internal IntPtr setFramedRoofFunctionPtr;
    internal IntPtr getNameListItemsByElementTypeFunctionPtr;
    internal IntPtr isAttributeVisibleInModifyWindowFunctionPtr;
    internal IntPtr setAttributeVisibilityInModifyWindowFunctionPtr;
    internal IntPtr setCuttingSetFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetLastErrorDelegate(IntPtr thisPtr, IntPtr aErrorCode);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetNameDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetNameDelegate(IntPtr thisPtr, IntPtr aElementIdList, [MarshalAs(UnmanagedType.LPWStr)] string aName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetGroupDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetGroupDelegate(IntPtr thisPtr, IntPtr aElementIdList, [MarshalAs(UnmanagedType.LPWStr)] string aGroup);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetSubgroupDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetSubgroupDelegate(IntPtr thisPtr, IntPtr aElementIdList, [MarshalAs(UnmanagedType.LPWStr)] string aSubgroup);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetCommentDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCommentDelegate(IntPtr thisPtr, IntPtr aElementIdList, [MarshalAs(UnmanagedType.LPWStr)] string aComment);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetUserAttributeDelegate(IntPtr thisPtr, ulong aId, uint aNumber);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetUserAttributeDelegate(IntPtr thisPtr, IntPtr aElementIdList, uint aNumber, [MarshalAs(UnmanagedType.LPWStr)] string aUserAttribute);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetSkuDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetSkuDelegate(IntPtr thisPtr, IntPtr aElementIdList, [MarshalAs(UnmanagedType.LPWStr)] string aSku);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate uint GetProductionNumberDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetProductionNumberDelegate(IntPtr thisPtr, IntPtr aElementIdList, uint aProductionNumber);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate uint GetPartNumberDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetPartNumberDelegate(IntPtr thisPtr, IntPtr aElementIdList, uint aPartNumber);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAdditionalDataDelegate(IntPtr thisPtr, ulong aId, [MarshalAs(UnmanagedType.LPWStr)] string aDataId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetAdditionalDataDelegate(IntPtr thisPtr, IntPtr aElementIdList, [MarshalAs(UnmanagedType.LPWStr)] string aDataId, [MarshalAs(UnmanagedType.LPWStr)] string aDataText);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DeleteAdditionalDataDelegate(IntPtr thisPtr, IntPtr aElementIdList, [MarshalAs(UnmanagedType.LPWStr)] string aDataId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetUserAttributeNameDelegate(IntPtr thisPtr, uint aNumber);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetUserAttributeNameDelegate(IntPtr thisPtr, uint aNumber, [MarshalAs(UnmanagedType.LPWStr)] string aUserAttributeName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetWallSituationDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsBeamDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsPanelDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsOpeningDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsWallDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsFloorDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsRoofDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsMetalDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsExportSolidDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsContainerDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsConnectorAxisDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsDrillingDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsNodeDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsAuxiliaryDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetElementMaterialNameDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetPrefabLayerDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetMachineCalculationSetDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetCuttingSetDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetProcessTypeAndExtendedSettingsFromNameDelegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetNameProcessTypeDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aName, IntPtr aProcessType);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetNameProcessTypeDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetNameExtendedSettingsDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aName, IntPtr aExtendedSettings);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetNameExtendedSettingsDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetOutputTypeDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetOutputTypeDelegate(IntPtr thisPtr, IntPtr aElementIdList, IntPtr aProcessType);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetExtendedSettingsDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetExtendedSettingsDelegate(IntPtr thisPtr, IntPtr aElementIdList, IntPtr aExtendedSettings);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetElementTypeDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetWallDelegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetFloorDelegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetOpeningDelegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetFasteningAttributeDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetFasteningAttributeDelegate(IntPtr thisPtr, IntPtr aElementIdList, [MarshalAs(UnmanagedType.LPWStr)] string aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsRoofSurfaceDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsCaddyObjectDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetElementMaterialDelegate(IntPtr thisPtr, IntPtr aElementIdList, ulong aMaterial);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAssemblyNumberDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetAssemblyNumberDelegate(IntPtr thisPtr, IntPtr aElementIdList, [MarshalAs(UnmanagedType.LPWStr)] string aAssemblyNumber);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate uint GetListQuantityDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetListQuantityDelegate(IntPtr thisPtr, IntPtr aElementIdList, uint aListQuantity);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsEnvelopeDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetLayerSettingsDelegate(IntPtr thisPtr, IntPtr aElementIdList, IntPtr aLayerSettings);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIgnoreInVbaCalculationDelegate(IntPtr thisPtr, IntPtr aElements, bool aIgnore);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetIgnoreInVbaCalculationDelegate(IntPtr thisPtr, ulong aElement);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ClearErrorsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsArchitectureWall2dcDelegate(IntPtr thisPtr, ulong aElement);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsArchitectureWallXmlDelegate(IntPtr thisPtr, ulong aElement);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetReferenceWall2dcDelegate(IntPtr thisPtr, IntPtr aElements, [MarshalAs(UnmanagedType.LPWStr)] string a2dcFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsSurfaceDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsLineDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAttributeDisplaySettingsFor3DDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetAttributeDisplaySettingsFor3DDelegate(IntPtr thisPtr, IntPtr aSettings);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAttributeDisplaySettingsFor2DDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetAttributeDisplaySettingsFor2DDelegate(IntPtr thisPtr, IntPtr aSettings);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAttributeDisplaySettingsFor2DWithoutLayoutDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetAttributeDisplaySettingsFor2DWithoutLayoutDelegate(IntPtr thisPtr, IntPtr aSettings);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAttributeDisplaySettingsFor2DWithLayoutDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetAttributeDisplaySettingsFor2DWithLayoutDelegate(IntPtr thisPtr, IntPtr aSettings);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAttributeDisplaySettingsForExportSolidDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetAttributeDisplaySettingsForExportSolidDelegate(IntPtr thisPtr, IntPtr aSettings);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAttributeDisplaySettingsForContainerDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetAttributeDisplaySettingsForContainerDelegate(IntPtr thisPtr, IntPtr aSettings);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAttributeDisplaySettingsForMachineDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetAttributeDisplaySettingsForMachineDelegate(IntPtr thisPtr, IntPtr aSettings);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAttributeDisplaySettingsForLogWallBeamDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetAttributeDisplaySettingsForLogWallBeamDelegate(IntPtr thisPtr, IntPtr aSettings);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAttributeDisplaySettingsForLogWallPanelDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetAttributeDisplaySettingsForLogWallPanelDelegate(IntPtr thisPtr, IntPtr aSettings);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAttributeDisplaySettingsForLogWallAxisDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetAttributeDisplaySettingsForLogWallAxisDelegate(IntPtr thisPtr, IntPtr aSettings);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAttributeDisplaySettingsForLogWallOpeningDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetAttributeDisplaySettingsForLogWallOpeningDelegate(IntPtr thisPtr, IntPtr aSettings);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAttributeDisplaySettingsForFramedWallBeamDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetAttributeDisplaySettingsForFramedWallBeamDelegate(IntPtr thisPtr, IntPtr aSettings);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAttributeDisplaySettingsForFramedWallPanelDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetAttributeDisplaySettingsForFramedWallPanelDelegate(IntPtr thisPtr, IntPtr aSettings);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAttributeDisplaySettingsForFramedWallAxisDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetAttributeDisplaySettingsForFramedWallAxisDelegate(IntPtr thisPtr, IntPtr aSettings);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAttributeDisplaySettingsForFramedWallOpeningDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetAttributeDisplaySettingsForFramedWallOpeningDelegate(IntPtr thisPtr, IntPtr aSettings);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAttributeDisplaySettingsForSolidWallBeamDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetAttributeDisplaySettingsForSolidWallBeamDelegate(IntPtr thisPtr, IntPtr aSettings);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAttributeDisplaySettingsForSolidWallPanelDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetAttributeDisplaySettingsForSolidWallPanelDelegate(IntPtr thisPtr, IntPtr aSettings);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAttributeDisplaySettingsForSolidWallAxisDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetAttributeDisplaySettingsForSolidWallAxisDelegate(IntPtr thisPtr, IntPtr aSettings);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAttributeDisplaySettingsForSolidWallOpeningDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetAttributeDisplaySettingsForSolidWallOpeningDelegate(IntPtr thisPtr, IntPtr aSettings);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAttributeDisplaySettingsForNestingVolumeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetAttributeDisplaySettingsForNestingVolumeDelegate(IntPtr thisPtr, IntPtr aSettings);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAttributeDisplaySettingsForNestingElementDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetAttributeDisplaySettingsForNestingElementDelegate(IntPtr thisPtr, IntPtr aSettings);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate uint GetUserAttributeCountDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetStandardPartDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetSolidWallDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetLogWallDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetSolidFloorDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetRoofDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetSolidRoofDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate int GetNodeSymbolDelegate(IntPtr thisPtr, ulong aElement);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetNodeSymbolDelegate(IntPtr thisPtr, IntPtr aElements, int aSymbol);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsProcessingDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetStandardElementNameDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetSteelShapeNameDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAssociatedNestingNumberDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAssociatedNestingNameDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void EnableAttributeDisplayDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DisableAttributeDisplayDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsAttributeDisplayEnabledDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAutoAttributeDelegate(IntPtr thisPtr, ulong aId, uint aNumber);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAutoAttributeNameDelegate(IntPtr thisPtr, uint aNumber);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void UpdateAutoAttributesDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsFramedWallDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsSolidWallDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsLogWallDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsFramedFloorDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsSolidFloorDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsFramedRoofDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsSolidRoofDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAdditionalGuidDelegate(IntPtr thisPtr, ulong aId, [MarshalAs(UnmanagedType.LPWStr)] string aDataId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetAdditionalGuidDelegate(IntPtr thisPtr, IntPtr aElementIdList, [MarshalAs(UnmanagedType.LPWStr)] string aDataId, [MarshalAs(UnmanagedType.LPWStr)] string aGuid);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate List<int> GetPrefabLayerAllAssignedDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate List<int> GetPrefabLayerWithDimensionsDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate List<int> GetPrefabLayerWithoutDimensionsDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsNestingParentDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsNestingRawPartDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetGroupListItemsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetSubgroupListItemsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetCommentListItemsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetSkuListItemsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetUserAttributeListItemsDelegate(IntPtr thisPtr, uint aNumber);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void AddItemToGroupListDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aItem);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void AddItemToSubgroupListDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aItem);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void AddItemToCommentListDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aItem);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void AddItemToSkuListDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aItem);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void AddItemToUserAttributeListDelegate(IntPtr thisPtr, uint aNumber, [MarshalAs(UnmanagedType.LPWStr)] string aItem);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsCircularMepDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsRectangularMepDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool DeleteItemFromGroupListDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aItem);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool DeleteItemFromSubgroupListDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aItem);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool DeleteItemFromCommentListDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aItem);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool DeleteItemFromSkuListDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aItem);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool DeleteItemFromUserAttributeListDelegate(IntPtr thisPtr, uint aNumber, [MarshalAs(UnmanagedType.LPWStr)] string aItem);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetNameListItemsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void AddItemToNameListDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aItem);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetContainerNumberWithPrefixDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate uint GetContainerNumberDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetContainerNumberDelegate(IntPtr thisPtr, IntPtr aElements, uint aNumber);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetMachineCalculationStateDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetMachineCalculationSetMachineTypeDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsBtlProcessingGroupDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsHundeggerProcessingGroupDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ElementGroupingType GetElementGroupingTypeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetElementGroupingTypeDelegate(IntPtr thisPtr, ElementGroupingType aType);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetFramedWallDelegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool DeleteUserAttributeDelegate(IntPtr thisPtr, uint aNumber);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetFramedFloorDelegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetFramedRoofDelegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetNameListItemsByElementTypeDelegate(IntPtr thisPtr, IntPtr aType);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsAttributeVisibleInModifyWindowDelegate(IntPtr thisPtr, uint aNumber);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetAttributeVisibilityInModifyWindowDelegate(IntPtr thisPtr, uint aNumber, bool aVisibility);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool SetCuttingSetDelegate(IntPtr thisPtr, IntPtr aElementIdList, [MarshalAs(UnmanagedType.LPWStr)] string aCuttingSetName);
}
