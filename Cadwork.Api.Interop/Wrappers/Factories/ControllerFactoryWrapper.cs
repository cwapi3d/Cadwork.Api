// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Factories;

public class ControllerFactoryWrapper
{
  private readonly IntPtr _nativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public ControllerFactoryWrapper(IntPtr nativePtr)
  {
    _nativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<ControllerFactoryInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(GetAttributeControllerDelegate), Marshal.GetDelegateForFunctionPointer<GetAttributeControllerDelegate>(vTable!.getAttributeControllerFunctionPtr) },
      { typeof(GetConnectorAxisControllerDelegate), Marshal.GetDelegateForFunctionPointer<GetConnectorAxisControllerDelegate>(vTable.getConnectorAxisControllerFunctionPtr) },
      { typeof(GetElementControllerDelegate), Marshal.GetDelegateForFunctionPointer<GetElementControllerDelegate>(vTable.getElementControllerFunctionPtr) },
      { typeof(GetFileControllerDelegate), Marshal.GetDelegateForFunctionPointer<GetFileControllerDelegate>(vTable.getFileControllerFunctionPtr) },
      { typeof(GetGeometryControllerDelegate), Marshal.GetDelegateForFunctionPointer<GetGeometryControllerDelegate>(vTable.getGeometryControllerFunctionPtr) },
      { typeof(GetListControllerDelegate), Marshal.GetDelegateForFunctionPointer<GetListControllerDelegate>(vTable.getListControllerFunctionPtr) },
      { typeof(GetMachineControllerDelegate), Marshal.GetDelegateForFunctionPointer<GetMachineControllerDelegate>(vTable.getMachineControllerFunctionPtr) },
      { typeof(GetMaterialControllerDelegate), Marshal.GetDelegateForFunctionPointer<GetMaterialControllerDelegate>(vTable.getMaterialControllerFunctionPtr) },
      { typeof(GetMenuControllerDelegate), Marshal.GetDelegateForFunctionPointer<GetMenuControllerDelegate>(vTable.getMenuControllerFunctionPtr) },
      { typeof(GetSceneControllerDelegate), Marshal.GetDelegateForFunctionPointer<GetSceneControllerDelegate>(vTable.getSceneControllerFunctionPtr) },
      { typeof(GetShopDrawingControllerDelegate), Marshal.GetDelegateForFunctionPointer<GetShopDrawingControllerDelegate>(vTable.getShopDrawingControllerFunctionPtr) },
      { typeof(GetUtilityControllerDelegate), Marshal.GetDelegateForFunctionPointer<GetUtilityControllerDelegate>(vTable.getUtilityControllerFunctionPtr) },
      { typeof(GetVisualizationControllerDelegate), Marshal.GetDelegateForFunctionPointer<GetVisualizationControllerDelegate>(vTable.getVisualizationControllerFunctionPtr) },
      { typeof(CreateEmptyElementIdListDelegate), Marshal.GetDelegateForFunctionPointer<CreateEmptyElementIdListDelegate>(vTable.createEmptyElementIDListFunctionPtr) },
      { typeof(CreateEmptyVertexListDelegate), Marshal.GetDelegateForFunctionPointer<CreateEmptyVertexListDelegate>(vTable.createEmptyVertexListFunctionPtr) },
      { typeof(CreateElementFilterDelegate), Marshal.GetDelegateForFunctionPointer<CreateElementFilterDelegate>(vTable.createElementFilterFunctionPtr) },
      { typeof(CreateElementMapQueryDelegate), Marshal.GetDelegateForFunctionPointer<CreateElementMapQueryDelegate>(vTable.createElementMapQueryFunctionPtr) },
      { typeof(GetEndTypeControllerDelegate), Marshal.GetDelegateForFunctionPointer<GetEndTypeControllerDelegate>(vTable.getEndTypeControllerFunctionPtr) },
      { typeof(CreateElementIdListFromElementDelegate), Marshal.GetDelegateForFunctionPointer<CreateElementIdListFromElementDelegate>(vTable.createElementIDListFromElementFunctionPtr) },
      { typeof(CreateEmptyElementModulePropertiesDelegate), Marshal.GetDelegateForFunctionPointer<CreateEmptyElementModulePropertiesDelegate>(vTable.createEmptyElementModulePropertiesFunctionPtr) },
      { typeof(GetRoofControllerDelegate), Marshal.GetDelegateForFunctionPointer<GetRoofControllerDelegate>(vTable.getRoofControllerFunctionPtr) },
      { typeof(GetBimControllerDelegate), Marshal.GetDelegateForFunctionPointer<GetBimControllerDelegate>(vTable.getBimControllerFunctionPtr) },
      { typeof(CreateEmptyLayerSettingsDelegate), Marshal.GetDelegateForFunctionPointer<CreateEmptyLayerSettingsDelegate>(vTable.createEmptyLayerSettingsFunctionPtr) },
      { typeof(CreateEmptyDisplayAttributeDelegate), Marshal.GetDelegateForFunctionPointer<CreateEmptyDisplayAttributeDelegate>(vTable.createEmptyDisplayAttributeFunctionPtr) },
      { typeof(CreateEmptyStringListDelegate), Marshal.GetDelegateForFunctionPointer<CreateEmptyStringListDelegate>(vTable.createEmptyStringListFunctionPtr) },
      { typeof(CreateEmptyPolygonListDelegate), Marshal.GetDelegateForFunctionPointer<CreateEmptyPolygonListDelegate>(vTable.createEmptyPolygonListFunctionPtr) },
      { typeof(GetDimensionControllerDelegate), Marshal.GetDelegateForFunctionPointer<GetDimensionControllerDelegate>(vTable.getDimensionControllerFunctionPtr) },
      { typeof(GetGridControllerDelegate), Marshal.GetDelegateForFunctionPointer<GetGridControllerDelegate>(vTable.getGridControllerFunctionPtr) },
      { typeof(CreateEmptyExtendedSettingsDelegate), Marshal.GetDelegateForFunctionPointer<CreateEmptyExtendedSettingsDelegate>(vTable.createEmptyExtendedSettingsFunctionPtr) },
      { typeof(CreateRhinoOptionsDelegate), Marshal.GetDelegateForFunctionPointer<CreateRhinoOptionsDelegate>(vTable.createRhinoOptionsFunctionPtr) },
      { typeof(CreateIfcOptionsDelegate), Marshal.GetDelegateForFunctionPointer<CreateIfcOptionsDelegate>(vTable.createIfcOptionsFunctionPtr) },
      { typeof(CreateTextObjectOptionsDelegate), Marshal.GetDelegateForFunctionPointer<CreateTextObjectOptionsDelegate>(vTable.createTextObjectOptionsFunctionPtr) },
      { typeof(CreateCameraDataDelegate), Marshal.GetDelegateForFunctionPointer<CreateCameraDataDelegate>(vTable.createCameraDataFunctionPtr) },
      { typeof(GetMultiLayerCoverControllerDelegate), Marshal.GetDelegateForFunctionPointer<GetMultiLayerCoverControllerDelegate>(vTable.getMultiLayerCoverControllerFunctionPtr) },
      { typeof(CreateImport3dcOptionsDelegate), Marshal.GetDelegateForFunctionPointer<CreateImport3dcOptionsDelegate>(vTable.createImport3dcOptionsFunctionPtr) },
      { typeof(CreateEmptyEndTypeIdListDelegate), Marshal.GetDelegateForFunctionPointer<CreateEmptyEndTypeIdListDelegate>(vTable.createEmptyEndTypeIDListFunctionPtr) },
      { typeof(CreateElementTypeDelegate), Marshal.GetDelegateForFunctionPointer<CreateElementTypeDelegate>(vTable.createElementTypeFunctionPtr) },
      { typeof(CreateEmptyActivationStateDelegate), Marshal.GetDelegateForFunctionPointer<CreateEmptyActivationStateDelegate>(vTable.createEmptyActivationStateFunctionPtr) },
      { typeof(CreateEmptyAttributeDisplaySettingsDelegate), Marshal.GetDelegateForFunctionPointer<CreateEmptyAttributeDisplaySettingsDelegate>(vTable.createEmptyAttributeDisplaySettingsFunctionPtr) },
      { typeof(CreateEmptyCoordinateSystemDataDelegate), Marshal.GetDelegateForFunctionPointer<CreateEmptyCoordinateSystemDataDelegate>(vTable.createEmptyCoordinateSystemDataFunctionPtr) },
      { typeof(CreateEmptyEdgeListDelegate), Marshal.GetDelegateForFunctionPointer<CreateEmptyEdgeListDelegate>(vTable.createEmptyEdgeListFunctionPtr) },
      { typeof(CreateEmptyFacetListDelegate), Marshal.GetDelegateForFunctionPointer<CreateEmptyFacetListDelegate>(vTable.createEmptyFacetListFunctionPtr) },
      { typeof(CreateEmptyIfc2X3ElementTypeDelegate), Marshal.GetDelegateForFunctionPointer<CreateEmptyIfc2X3ElementTypeDelegate>(vTable.createEmptyIfc2x3ElementTypeFunctionPtr) },
      { typeof(CreateEmptyIfcPredefinedTypeDelegate), Marshal.GetDelegateForFunctionPointer<CreateEmptyIfcPredefinedTypeDelegate>(vTable.createEmptyIfcPredefinedTypeFunctionPtr) },
      { typeof(CreateEmptyMaterialIdListDelegate), Marshal.GetDelegateForFunctionPointer<CreateEmptyMaterialIdListDelegate>(vTable.createEmptyMaterialIDListFunctionPtr) },
      { typeof(CreateEmptyProcessTypeDelegate), Marshal.GetDelegateForFunctionPointer<CreateEmptyProcessTypeDelegate>(vTable.createEmptyProcessTypeFunctionPtr) },
      { typeof(CreateEmptyVisibilityStateDelegate), Marshal.GetDelegateForFunctionPointer<CreateEmptyVisibilityStateDelegate>(vTable.createEmptyVisibilityStateFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public IntPtr GetAttributeController() => GetDelegate<GetAttributeControllerDelegate>().Invoke(_nativePtr);
  public IntPtr GetConnectorAxisController() => GetDelegate<GetConnectorAxisControllerDelegate>().Invoke(_nativePtr);
  public IntPtr GetElementController() => GetDelegate<GetElementControllerDelegate>().Invoke(_nativePtr);
  public IntPtr GetFileController() => GetDelegate<GetFileControllerDelegate>().Invoke(_nativePtr);
  public IntPtr GetGeometryController() => GetDelegate<GetGeometryControllerDelegate>().Invoke(_nativePtr);
  public IntPtr GetListController() => GetDelegate<GetListControllerDelegate>().Invoke(_nativePtr);
  public IntPtr GetMachineController() => GetDelegate<GetMachineControllerDelegate>().Invoke(_nativePtr);
  public IntPtr GetMaterialController() => GetDelegate<GetMaterialControllerDelegate>().Invoke(_nativePtr);
  public IntPtr GetMenuController() => GetDelegate<GetMenuControllerDelegate>().Invoke(_nativePtr);
  public IntPtr GetSceneController() => GetDelegate<GetSceneControllerDelegate>().Invoke(_nativePtr);
  public IntPtr GetShopDrawingController() => GetDelegate<GetShopDrawingControllerDelegate>().Invoke(_nativePtr);
  public IntPtr GetUtilityController() => GetDelegate<GetUtilityControllerDelegate>().Invoke(_nativePtr);
  public IntPtr GetVisualizationController() => GetDelegate<GetVisualizationControllerDelegate>().Invoke(_nativePtr);
  public IntPtr CreateEmptyElementIdList() => GetDelegate<CreateEmptyElementIdListDelegate>().Invoke(_nativePtr);
  public IntPtr CreateEmptyVertexList() => GetDelegate<CreateEmptyVertexListDelegate>().Invoke(_nativePtr);
  public IntPtr CreateElementFilter() => GetDelegate<CreateElementFilterDelegate>().Invoke(_nativePtr);
  public IntPtr CreateElementMapQuery() => GetDelegate<CreateElementMapQueryDelegate>().Invoke(_nativePtr);
  public IntPtr GetEndTypeController() => GetDelegate<GetEndTypeControllerDelegate>().Invoke(_nativePtr);
  public IntPtr CreateElementIdListFromElement(ulong aId) => GetDelegate<CreateElementIdListFromElementDelegate>().Invoke(_nativePtr, aId);
  public IntPtr CreateEmptyElementModuleProperties() => GetDelegate<CreateEmptyElementModulePropertiesDelegate>().Invoke(_nativePtr);
  public IntPtr GetRoofController() => GetDelegate<GetRoofControllerDelegate>().Invoke(_nativePtr);
  public IntPtr GetBimController() => GetDelegate<GetBimControllerDelegate>().Invoke(_nativePtr);
  public IntPtr CreateEmptyLayerSettings() => GetDelegate<CreateEmptyLayerSettingsDelegate>().Invoke(_nativePtr);
  public IntPtr CreateEmptyDisplayAttribute() => GetDelegate<CreateEmptyDisplayAttributeDelegate>().Invoke(_nativePtr);
  public IntPtr CreateEmptyStringList() => GetDelegate<CreateEmptyStringListDelegate>().Invoke(_nativePtr);
  public IntPtr CreateEmptyPolygonList() => GetDelegate<CreateEmptyPolygonListDelegate>().Invoke(_nativePtr);
  public IntPtr GetDimensionController() => GetDelegate<GetDimensionControllerDelegate>().Invoke(_nativePtr);
  public IntPtr GetGridController() => GetDelegate<GetGridControllerDelegate>().Invoke(_nativePtr);
  public IntPtr CreateEmptyExtendedSettings() => GetDelegate<CreateEmptyExtendedSettingsDelegate>().Invoke(_nativePtr);
  public IntPtr CreateRhinoOptions() => GetDelegate<CreateRhinoOptionsDelegate>().Invoke(_nativePtr);
  public IntPtr CreateIfcOptions() => GetDelegate<CreateIfcOptionsDelegate>().Invoke(_nativePtr);
  public IntPtr CreateTextObjectOptions() => GetDelegate<CreateTextObjectOptionsDelegate>().Invoke(_nativePtr);
  public IntPtr CreateCameraData() => GetDelegate<CreateCameraDataDelegate>().Invoke(_nativePtr);
  public IntPtr GetMultiLayerWallController() => GetDelegate<GetMultiLayerCoverControllerDelegate>().Invoke(_nativePtr);
  public IntPtr CreateImport3dcOptions() => GetDelegate<CreateImport3dcOptionsDelegate>().Invoke(_nativePtr);
  public IntPtr CreateEmptyEndTypeIdList() => GetDelegate<CreateEmptyEndTypeIdListDelegate>().Invoke(_nativePtr);
  public IntPtr CreateElementType() => GetDelegate<CreateElementTypeDelegate>().Invoke(_nativePtr);
  public IntPtr CreateEmptyActivationState() => GetDelegate<CreateEmptyActivationStateDelegate>().Invoke(_nativePtr);
  public IntPtr CreateEmptyAttributeDisplaySettings() => GetDelegate<CreateEmptyAttributeDisplaySettingsDelegate>().Invoke(_nativePtr);
  public IntPtr CreateEmptyCoordinateSystemData() => GetDelegate<CreateEmptyCoordinateSystemDataDelegate>().Invoke(_nativePtr);
  public IntPtr CreateEmptyEdgeList() => GetDelegate<CreateEmptyEdgeListDelegate>().Invoke(_nativePtr);
  public IntPtr CreateEmptyFacetList() => GetDelegate<CreateEmptyFacetListDelegate>().Invoke(_nativePtr);
  public IntPtr CreateEmptyIfcElementType() => GetDelegate<CreateEmptyIfc2X3ElementTypeDelegate>().Invoke(_nativePtr);
  public IntPtr CreateEmptyIfcPredefinedType() => GetDelegate<CreateEmptyIfcPredefinedTypeDelegate>().Invoke(_nativePtr);
  public IntPtr CreateEmptyMaterialIdList() => GetDelegate<CreateEmptyMaterialIdListDelegate>().Invoke(_nativePtr);
  public IntPtr CreateEmptyProcessType() => GetDelegate<CreateEmptyProcessTypeDelegate>().Invoke(_nativePtr);
  public IntPtr CreateEmptyVisibilityState() => GetDelegate<CreateEmptyVisibilityStateDelegate>().Invoke(_nativePtr);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class ControllerFactoryInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr getAttributeControllerFunctionPtr;
    internal IntPtr getConnectorAxisControllerFunctionPtr;
    internal IntPtr getElementControllerFunctionPtr;
    internal IntPtr getFileControllerFunctionPtr;
    internal IntPtr getGeometryControllerFunctionPtr;
    internal IntPtr getListControllerFunctionPtr;
    internal IntPtr getMachineControllerFunctionPtr;
    internal IntPtr getMaterialControllerFunctionPtr;
    internal IntPtr getMenuControllerFunctionPtr;
    internal IntPtr getSceneControllerFunctionPtr;
    internal IntPtr getShopDrawingControllerFunctionPtr;
    internal IntPtr getUtilityControllerFunctionPtr;
    internal IntPtr getVisualizationControllerFunctionPtr;
    internal IntPtr createEmptyElementIDListFunctionPtr;
    internal IntPtr createEmptyVertexListFunctionPtr;
    internal IntPtr createElementFilterFunctionPtr;
    internal IntPtr createElementMapQueryFunctionPtr;
    internal IntPtr getEndTypeControllerFunctionPtr;
    internal IntPtr createElementIDListFromElementFunctionPtr;
    internal IntPtr createEmptyElementModulePropertiesFunctionPtr;
    internal IntPtr getRoofControllerFunctionPtr;
    internal IntPtr getBimControllerFunctionPtr;
    internal IntPtr createEmptyLayerSettingsFunctionPtr;
    internal IntPtr createEmptyDisplayAttributeFunctionPtr;
    internal IntPtr createEmptyStringListFunctionPtr;
    internal IntPtr createEmptyPolygonListFunctionPtr;
    internal IntPtr getDimensionControllerFunctionPtr;
    internal IntPtr getGridControllerFunctionPtr;
    internal IntPtr createEmptyExtendedSettingsFunctionPtr;
    internal IntPtr createRhinoOptionsFunctionPtr;
    internal IntPtr createIfcOptionsFunctionPtr;
    internal IntPtr createTextObjectOptionsFunctionPtr;
    internal IntPtr createCameraDataFunctionPtr;
    internal IntPtr getMultiLayerCoverControllerFunctionPtr;
    internal IntPtr createImport3dcOptionsFunctionPtr;
    internal IntPtr createEmptyEndTypeIDListFunctionPtr;
    internal IntPtr createElementTypeFunctionPtr;
    internal IntPtr createEmptyActivationStateFunctionPtr;
    internal IntPtr createEmptyAttributeDisplaySettingsFunctionPtr;
    internal IntPtr createEmptyCoordinateSystemDataFunctionPtr;
    internal IntPtr createEmptyEdgeListFunctionPtr;
    internal IntPtr createEmptyFacetListFunctionPtr;
    internal IntPtr createEmptyIfc2x3ElementTypeFunctionPtr;
    internal IntPtr createEmptyIfcPredefinedTypeFunctionPtr;
    internal IntPtr createEmptyMaterialIDListFunctionPtr;
    internal IntPtr createEmptyProcessTypeFunctionPtr;
    internal IntPtr createEmptyVisibilityStateFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAttributeControllerDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetConnectorAxisControllerDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetElementControllerDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetFileControllerDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetGeometryControllerDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetListControllerDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetMachineControllerDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetMaterialControllerDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetMenuControllerDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetSceneControllerDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetShopDrawingControllerDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetUtilityControllerDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetVisualizationControllerDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CreateEmptyElementIdListDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CreateEmptyVertexListDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CreateElementFilterDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CreateElementMapQueryDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetEndTypeControllerDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CreateElementIdListFromElementDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CreateEmptyElementModulePropertiesDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetRoofControllerDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetBimControllerDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CreateEmptyLayerSettingsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CreateEmptyDisplayAttributeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CreateEmptyStringListDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CreateEmptyPolygonListDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetDimensionControllerDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetGridControllerDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CreateEmptyExtendedSettingsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CreateRhinoOptionsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CreateIfcOptionsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CreateTextObjectOptionsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CreateCameraDataDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetMultiLayerCoverControllerDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CreateImport3dcOptionsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CreateEmptyEndTypeIdListDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CreateElementTypeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CreateEmptyActivationStateDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CreateEmptyAttributeDisplaySettingsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CreateEmptyCoordinateSystemDataDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CreateEmptyEdgeListDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CreateEmptyFacetListDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CreateEmptyIfc2X3ElementTypeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CreateEmptyIfcPredefinedTypeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CreateEmptyMaterialIdListDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CreateEmptyProcessTypeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CreateEmptyVisibilityStateDelegate(IntPtr thisPtr);
}
