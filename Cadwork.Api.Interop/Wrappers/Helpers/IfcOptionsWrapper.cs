// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Helpers;

public class IfcOptionsWrapper
{
  public readonly IntPtr NativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public IfcOptionsWrapper(IntPtr nativePtr)
  {
    NativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<IfcOptionsInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(DestroyDelegate), Marshal.GetDelegateForFunctionPointer<DestroyDelegate>(vTable!.destroyFunctionPtr) },
      { typeof(GetCwApi3DIfcOptionsProjectDataDelegate), Marshal.GetDelegateForFunctionPointer<GetCwApi3DIfcOptionsProjectDataDelegate>(vTable.getCwAPI3DIfcOptionsProjectDataFunctionPtr) },
      { typeof(GetCwApi3DIfcOptionsPropertiesDelegate), Marshal.GetDelegateForFunctionPointer<GetCwApi3DIfcOptionsPropertiesDelegate>(vTable.getCwAPI3DIfcOptionsPropertiesFunctionPtr) },
      { typeof(GetCwApi3DIfcOptionsLevelOfDetailDelegate), Marshal.GetDelegateForFunctionPointer<GetCwApi3DIfcOptionsLevelOfDetailDelegate>(vTable.getCwAPI3DIfcOptionsLevelOfDetailFunctionPtr) },
      { typeof(GetCwApi3DIfcOptionsAggregationDelegate), Marshal.GetDelegateForFunctionPointer<GetCwApi3DIfcOptionsAggregationDelegate>(vTable.getCwAPI3DIfcOptionsAggregationFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public void Destroy() => GetDelegate<DestroyDelegate>().Invoke(NativePtr);
  public IntPtr GetCwApi3DIfcOptionsProjectData() => GetDelegate<GetCwApi3DIfcOptionsProjectDataDelegate>().Invoke(NativePtr);
  public IntPtr GetCwApi3DIfcOptionsProperties() => GetDelegate<GetCwApi3DIfcOptionsPropertiesDelegate>().Invoke(NativePtr);
  public IntPtr GetCwApi3DIfcOptionsLevelOfDetail() => GetDelegate<GetCwApi3DIfcOptionsLevelOfDetailDelegate>().Invoke(NativePtr);
  public IntPtr GetCwApi3DIfcOptionsAggregation() => GetDelegate<GetCwApi3DIfcOptionsAggregationDelegate>().Invoke(NativePtr);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class IfcOptionsInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr destroyFunctionPtr;
    internal IntPtr getCwAPI3DIfcOptionsProjectDataFunctionPtr;
    internal IntPtr getCwAPI3DIfcOptionsPropertiesFunctionPtr;
    internal IntPtr getCwAPI3DIfcOptionsLevelOfDetailFunctionPtr;
    internal IntPtr getCwAPI3DIfcOptionsAggregationFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DestroyDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetCwApi3DIfcOptionsProjectDataDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetCwApi3DIfcOptionsPropertiesDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetCwApi3DIfcOptionsLevelOfDetailDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetCwApi3DIfcOptionsAggregationDelegate(IntPtr thisPtr);
}

public class IfcOptionsProjectDataWrapper
{
  private readonly IntPtr _nativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public IfcOptionsProjectDataWrapper(IntPtr nativePtr)
  {
    _nativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<IfcOptionsProjectDataInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(GetExportProjectNameAsIfcProjectDelegate), Marshal.GetDelegateForFunctionPointer<GetExportProjectNameAsIfcProjectDelegate>(vTable!.getExportProjectNameAsIfcProjectFunctionPtr) },
      { typeof(SetExportProjectNameAsIfcProjectDelegate), Marshal.GetDelegateForFunctionPointer<SetExportProjectNameAsIfcProjectDelegate>(vTable.setExportProjectNameAsIfcProjectFunctionPtr) },
      { typeof(GetExportAddressInIfcSiteDelegate), Marshal.GetDelegateForFunctionPointer<GetExportAddressInIfcSiteDelegate>(vTable.getExportAddressInIfcSiteFunctionPtr) },
      { typeof(SetExportAddressInIfcSiteDelegate), Marshal.GetDelegateForFunctionPointer<SetExportAddressInIfcSiteDelegate>(vTable.setExportAddressInIfcSiteFunctionPtr) },
      { typeof(GetExportCoordinatesInIfcSiteDelegate), Marshal.GetDelegateForFunctionPointer<GetExportCoordinatesInIfcSiteDelegate>(vTable.getExportCoordinatesInIfcSiteFunctionPtr) },
      { typeof(SetExportCoordinatesInIfcSiteDelegate), Marshal.GetDelegateForFunctionPointer<SetExportCoordinatesInIfcSiteDelegate>(vTable.setExportCoordinatesInIfcSiteFunctionPtr) },
      { typeof(GetExportTrueNorthInGeometricContextDelegate), Marshal.GetDelegateForFunctionPointer<GetExportTrueNorthInGeometricContextDelegate>(vTable.getExportTrueNorthInGeometricContextFunctionPtr) },
      { typeof(SetExportTrueNorthInGeometricContextDelegate), Marshal.GetDelegateForFunctionPointer<SetExportTrueNorthInGeometricContextDelegate>(vTable.setExportTrueNorthInGeometricContextFunctionPtr) },
      { typeof(GetExportTrueNorthInObjectPlacementDelegate), Marshal.GetDelegateForFunctionPointer<GetExportTrueNorthInObjectPlacementDelegate>(vTable.getExportTrueNorthInObjectPlacementFunctionPtr) },
      { typeof(SetExportTrueNorthInObjectPlacementDelegate), Marshal.GetDelegateForFunctionPointer<SetExportTrueNorthInObjectPlacementDelegate>(vTable.setExportTrueNorthInObjectPlacementFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public bool GetExportProjectNameAsIfcProject() => GetDelegate<GetExportProjectNameAsIfcProjectDelegate>().Invoke(_nativePtr);
  public void SetExportProjectNameAsIfcProject(bool aValue) => GetDelegate<SetExportProjectNameAsIfcProjectDelegate>().Invoke(_nativePtr, aValue);
  public bool GetExportAddressInIfcSite() => GetDelegate<GetExportAddressInIfcSiteDelegate>().Invoke(_nativePtr);
  public void SetExportAddressInIfcSite(bool aValue) => GetDelegate<SetExportAddressInIfcSiteDelegate>().Invoke(_nativePtr, aValue);
  public bool GetExportCoordinatesInIfcSite() => GetDelegate<GetExportCoordinatesInIfcSiteDelegate>().Invoke(_nativePtr);
  public void SetExportCoordinatesInIfcSite(bool aValue) => GetDelegate<SetExportCoordinatesInIfcSiteDelegate>().Invoke(_nativePtr, aValue);
  public bool GetExportTrueNorthInGeometricContext() => GetDelegate<GetExportTrueNorthInGeometricContextDelegate>().Invoke(_nativePtr);
  public void SetExportTrueNorthInGeometricContext(bool aValue) => GetDelegate<SetExportTrueNorthInGeometricContextDelegate>().Invoke(_nativePtr, aValue);
  public bool GetExportTrueNorthInObjectPlacement() => GetDelegate<GetExportTrueNorthInObjectPlacementDelegate>().Invoke(_nativePtr);
  public void SetExportTrueNorthInObjectPlacement(bool aValue) => GetDelegate<SetExportTrueNorthInObjectPlacementDelegate>().Invoke(_nativePtr, aValue);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class IfcOptionsProjectDataInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr getExportProjectNameAsIfcProjectFunctionPtr;
    internal IntPtr setExportProjectNameAsIfcProjectFunctionPtr;
    internal IntPtr getExportAddressInIfcSiteFunctionPtr;
    internal IntPtr setExportAddressInIfcSiteFunctionPtr;
    internal IntPtr getExportCoordinatesInIfcSiteFunctionPtr;
    internal IntPtr setExportCoordinatesInIfcSiteFunctionPtr;
    internal IntPtr getExportTrueNorthInGeometricContextFunctionPtr;
    internal IntPtr setExportTrueNorthInGeometricContextFunctionPtr;
    internal IntPtr getExportTrueNorthInObjectPlacementFunctionPtr;
    internal IntPtr setExportTrueNorthInObjectPlacementFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetExportProjectNameAsIfcProjectDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetExportProjectNameAsIfcProjectDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetExportAddressInIfcSiteDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetExportAddressInIfcSiteDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetExportCoordinatesInIfcSiteDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetExportCoordinatesInIfcSiteDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetExportTrueNorthInGeometricContextDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetExportTrueNorthInGeometricContextDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetExportTrueNorthInObjectPlacementDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetExportTrueNorthInObjectPlacementDelegate(IntPtr thisPtr, bool aValue);
}

public class IfcOptionsPropertiesWrapper
{
  private readonly IntPtr _nativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public IfcOptionsPropertiesWrapper(IntPtr nativePtr)
  {
    _nativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<IfcOptionsPropertiesInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(GetCadworkAttributeForIfcLayerDelegate), Marshal.GetDelegateForFunctionPointer<GetCadworkAttributeForIfcLayerDelegate>(vTable!.getCadworkAttributeForIfcLayerFunctionPtr) },
      { typeof(SetCadworkAttributeForIfcLayerDelegate), Marshal.GetDelegateForFunctionPointer<SetCadworkAttributeForIfcLayerDelegate>(vTable.setCadworkAttributeForIfcLayerFunctionPtr) },
      { typeof(GetCadworkAttributeForIfcTagDelegate), Marshal.GetDelegateForFunctionPointer<GetCadworkAttributeForIfcTagDelegate>(vTable.getCadworkAttributeForIfcTagFunctionPtr) },
      { typeof(SetCadworkAttributeForIfcTagDelegate), Marshal.GetDelegateForFunctionPointer<SetCadworkAttributeForIfcTagDelegate>(vTable.setCadworkAttributeForIfcTagFunctionPtr) },
      { typeof(GetExportEmptyBuildingAndStoreysDelegate), Marshal.GetDelegateForFunctionPointer<GetExportEmptyBuildingAndStoreysDelegate>(vTable.getExportEmptyBuildingAndStoreysFunctionPtr) },
      { typeof(SetExportEmptyBuildingAndStoreysDelegate), Marshal.GetDelegateForFunctionPointer<SetExportEmptyBuildingAndStoreysDelegate>(vTable.setExportEmptyBuildingAndStoreysFunctionPtr) },
      { typeof(GetExportCadwork3dPSetDelegate), Marshal.GetDelegateForFunctionPointer<GetExportCadwork3dPSetDelegate>(vTable.getExportCadwork3dPSetFunctionPtr) },
      { typeof(SetExportCadwork3dPSetDelegate), Marshal.GetDelegateForFunctionPointer<SetExportCadwork3dPSetDelegate>(vTable.setExportCadwork3dPSetFunctionPtr) },
      { typeof(GetIgnoreUserAttributesUsedInUserPSetsDelegate), Marshal.GetDelegateForFunctionPointer<GetIgnoreUserAttributesUsedInUserPSetsDelegate>(vTable.getIgnoreUserAttributesUsedInUserPSetsFunctionPtr) },
      { typeof(SetIgnoreUserAttributesUsedInUserPSetsDelegate), Marshal.GetDelegateForFunctionPointer<SetIgnoreUserAttributesUsedInUserPSetsDelegate>(vTable.setIgnoreUserAttributesUsedInUserPSetsFunctionPtr) },
      { typeof(GetExportBimWoodPropertyDelegate), Marshal.GetDelegateForFunctionPointer<GetExportBimWoodPropertyDelegate>(vTable.getExportBIMWoodPropertyFunctionPtr) },
      { typeof(SetExportBimWoodPropertyDelegate), Marshal.GetDelegateForFunctionPointer<SetExportBimWoodPropertyDelegate>(vTable.setExportBIMWoodPropertyFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public uint GetCadworkAttributeForIfcLayer() => GetDelegate<GetCadworkAttributeForIfcLayerDelegate>().Invoke(_nativePtr);
  public void SetCadworkAttributeForIfcLayer(uint aAttribute) => GetDelegate<SetCadworkAttributeForIfcLayerDelegate>().Invoke(_nativePtr, aAttribute);
  public uint GetCadworkAttributeForIfcTag() => GetDelegate<GetCadworkAttributeForIfcTagDelegate>().Invoke(_nativePtr);
  public void SetCadworkAttributeForIfcTag(uint aAttribute) => GetDelegate<SetCadworkAttributeForIfcTagDelegate>().Invoke(_nativePtr, aAttribute);
  public bool GetExportEmptyBuildingAndStoreys() => GetDelegate<GetExportEmptyBuildingAndStoreysDelegate>().Invoke(_nativePtr);
  public void SetExportEmptyBuildingAndStoreys(bool aValue) => GetDelegate<SetExportEmptyBuildingAndStoreysDelegate>().Invoke(_nativePtr, aValue);
  public bool GetExportCadwork3dPSet() => GetDelegate<GetExportCadwork3dPSetDelegate>().Invoke(_nativePtr);
  public void SetExportCadwork3dPSet(bool aValue) => GetDelegate<SetExportCadwork3dPSetDelegate>().Invoke(_nativePtr, aValue);
  public bool GetIgnoreUserAttributesUsedInUserPSets() => GetDelegate<GetIgnoreUserAttributesUsedInUserPSetsDelegate>().Invoke(_nativePtr);
  public void SetIgnoreUserAttributesUsedInUserPSets(bool aValue) => GetDelegate<SetIgnoreUserAttributesUsedInUserPSetsDelegate>().Invoke(_nativePtr, aValue);
  public bool GetExportBimWoodProperty() => GetDelegate<GetExportBimWoodPropertyDelegate>().Invoke(_nativePtr);
  public void SetExportBimWoodProperty(bool aValue) => GetDelegate<SetExportBimWoodPropertyDelegate>().Invoke(_nativePtr, aValue);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class IfcOptionsPropertiesInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr getCadworkAttributeForIfcLayerFunctionPtr;
    internal IntPtr setCadworkAttributeForIfcLayerFunctionPtr;
    internal IntPtr getCadworkAttributeForIfcTagFunctionPtr;
    internal IntPtr setCadworkAttributeForIfcTagFunctionPtr;
    internal IntPtr getExportEmptyBuildingAndStoreysFunctionPtr;
    internal IntPtr setExportEmptyBuildingAndStoreysFunctionPtr;
    internal IntPtr getExportCadwork3dPSetFunctionPtr;
    internal IntPtr setExportCadwork3dPSetFunctionPtr;
    internal IntPtr getIgnoreUserAttributesUsedInUserPSetsFunctionPtr;
    internal IntPtr setIgnoreUserAttributesUsedInUserPSetsFunctionPtr;
    internal IntPtr getExportBIMWoodPropertyFunctionPtr;
    internal IntPtr setExportBIMWoodPropertyFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate uint GetCadworkAttributeForIfcLayerDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCadworkAttributeForIfcLayerDelegate(IntPtr thisPtr, uint aAttribute);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate uint GetCadworkAttributeForIfcTagDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCadworkAttributeForIfcTagDelegate(IntPtr thisPtr, uint aAttribute);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetExportEmptyBuildingAndStoreysDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetExportEmptyBuildingAndStoreysDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetExportCadwork3dPSetDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetExportCadwork3dPSetDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetIgnoreUserAttributesUsedInUserPSetsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIgnoreUserAttributesUsedInUserPSetsDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetExportBimWoodPropertyDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetExportBimWoodPropertyDelegate(IntPtr thisPtr, bool aValue);
}

public class IfcOptionsLevelOfDetailWrapper
{
  private readonly IntPtr _nativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public IfcOptionsLevelOfDetailWrapper(IntPtr nativePtr)
  {
    _nativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<IfcOptionsLevelOfDetailInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(GetExportEndTypeMaterializationDelegate), Marshal.GetDelegateForFunctionPointer<GetExportEndTypeMaterializationDelegate>(vTable!.getExportEndTypeMaterializationFunctionPtr) },
      { typeof(SetExportEndTypeMaterializationDelegate), Marshal.GetDelegateForFunctionPointer<SetExportEndTypeMaterializationDelegate>(vTable.setExportEndTypeMaterializationFunctionPtr) },
      { typeof(GetCutEndTypeCounterpartsDelegate), Marshal.GetDelegateForFunctionPointer<GetCutEndTypeCounterpartsDelegate>(vTable.getCutEndTypeCounterpartsFunctionPtr) },
      { typeof(SetCutEndTypeCounterpartsDelegate), Marshal.GetDelegateForFunctionPointer<SetCutEndTypeCounterpartsDelegate>(vTable.setCutEndTypeCounterpartsFunctionPtr) },
      { typeof(GetExportVbaDrillingsDelegate), Marshal.GetDelegateForFunctionPointer<GetExportVbaDrillingsDelegate>(vTable.getExportVbaDrillingsFunctionPtr) },
      { typeof(SetExportVbaDrillingsDelegate), Marshal.GetDelegateForFunctionPointer<SetExportVbaDrillingsDelegate>(vTable.setExportVbaDrillingsFunctionPtr) },
      { typeof(GetExportVbaComponentsDelegate), Marshal.GetDelegateForFunctionPointer<GetExportVbaComponentsDelegate>(vTable.getExportVbaComponentsFunctionPtr) },
      { typeof(SetExportVbaComponentsDelegate), Marshal.GetDelegateForFunctionPointer<SetExportVbaComponentsDelegate>(vTable.setExportVbaComponentsFunctionPtr) },
      { typeof(GetCutDrillingsDelegate), Marshal.GetDelegateForFunctionPointer<GetCutDrillingsDelegate>(vTable.getCutDrillingsFunctionPtr) },
      { typeof(SetCutDrillingsDelegate), Marshal.GetDelegateForFunctionPointer<SetCutDrillingsDelegate>(vTable.setCutDrillingsFunctionPtr) },
      { typeof(GetExportInstallationRoundMaterializationDelegate), Marshal.GetDelegateForFunctionPointer<GetExportInstallationRoundMaterializationDelegate>(vTable.getExportInstallationRoundMaterializationFunctionPtr) },
      { typeof(SetExportInstallationRoundMaterializationDelegate), Marshal.GetDelegateForFunctionPointer<SetExportInstallationRoundMaterializationDelegate>(vTable.setExportInstallationRoundMaterializationFunctionPtr) },
      { typeof(GetExportInstallationRectangularMaterializationDelegate), Marshal.GetDelegateForFunctionPointer<GetExportInstallationRectangularMaterializationDelegate>(vTable.getExportInstallationRectangularMaterializationFunctionPtr) },
      { typeof(SetExportInstallationRectangularMaterializationDelegate), Marshal.GetDelegateForFunctionPointer<SetExportInstallationRectangularMaterializationDelegate>(vTable.setExportInstallationRectangularMaterializationFunctionPtr) },
      { typeof(GetCutInstallationRoundDelegate), Marshal.GetDelegateForFunctionPointer<GetCutInstallationRoundDelegate>(vTable.getCutInstallationRoundFunctionPtr) },
      { typeof(SetCutInstallationRoundDelegate), Marshal.GetDelegateForFunctionPointer<SetCutInstallationRoundDelegate>(vTable.setCutInstallationRoundFunctionPtr) },
      { typeof(GetCutInstallationRectangularDelegate), Marshal.GetDelegateForFunctionPointer<GetCutInstallationRectangularDelegate>(vTable.getCutInstallationRectangularFunctionPtr) },
      { typeof(SetCutInstallationRectangularDelegate), Marshal.GetDelegateForFunctionPointer<SetCutInstallationRectangularDelegate>(vTable.setCutInstallationRectangularFunctionPtr) },
      { typeof(GetExportSweptSolidForSimpleGeometryDelegate), Marshal.GetDelegateForFunctionPointer<GetExportSweptSolidForSimpleGeometryDelegate>(vTable.getExportSweptSolidForSimpleGeometryFunctionPtr) },
      { typeof(SetExportSweptSolidForSimpleGeometryDelegate), Marshal.GetDelegateForFunctionPointer<SetExportSweptSolidForSimpleGeometryDelegate>(vTable.setExportSweptSolidForSimpleGeometryFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public bool GetExportEndTypeMaterialization() => GetDelegate<GetExportEndTypeMaterializationDelegate>().Invoke(_nativePtr);
  public void SetExportEndTypeMaterialization(bool aValue) => GetDelegate<SetExportEndTypeMaterializationDelegate>().Invoke(_nativePtr, aValue);
  public bool GetCutEndTypeCounterparts() => GetDelegate<GetCutEndTypeCounterpartsDelegate>().Invoke(_nativePtr);
  public void SetCutEndTypeCounterparts(bool aValue) => GetDelegate<SetCutEndTypeCounterpartsDelegate>().Invoke(_nativePtr, aValue);
  public bool GetExportConnectorAxesDrillingAxes() => GetDelegate<GetExportVbaDrillingsDelegate>().Invoke(_nativePtr);
  public void SetExportConnectorAxesDrillingAxes(bool aValue) => GetDelegate<SetExportVbaDrillingsDelegate>().Invoke(_nativePtr, aValue);
  public bool GetExportConnectorAxesComponents() => GetDelegate<GetExportVbaComponentsDelegate>().Invoke(_nativePtr);
  public void SetExportConnectorAxesComponents(bool aValue) => GetDelegate<SetExportVbaComponentsDelegate>().Invoke(_nativePtr, aValue);
  public bool GetCutDrillingAxes() => GetDelegate<GetCutDrillingsDelegate>().Invoke(_nativePtr);
  public void SetCutDrillingAxes(bool aValue) => GetDelegate<SetCutDrillingsDelegate>().Invoke(_nativePtr, aValue);
  public bool GetExportInstallationRoundMaterialization() => GetDelegate<GetExportInstallationRoundMaterializationDelegate>().Invoke(_nativePtr);
  public void SetExportInstallationRoundMaterialization(bool aValue) => GetDelegate<SetExportInstallationRoundMaterializationDelegate>().Invoke(_nativePtr, aValue);
  public bool GetExportInstallationRectangularMaterialization() => GetDelegate<GetExportInstallationRectangularMaterializationDelegate>().Invoke(_nativePtr);
  public void SetExportInstallationRectangularMaterialization(bool aValue) => GetDelegate<SetExportInstallationRectangularMaterializationDelegate>().Invoke(_nativePtr, aValue);
  public bool GetCutInstallationRound() => GetDelegate<GetCutInstallationRoundDelegate>().Invoke(_nativePtr);
  public void SetCutInstallationRound(bool aValue) => GetDelegate<SetCutInstallationRoundDelegate>().Invoke(_nativePtr, aValue);
  public bool GetCutInstallationRectangular() => GetDelegate<GetCutInstallationRectangularDelegate>().Invoke(_nativePtr);
  public void SetCutInstallationRectangular(bool aValue) => GetDelegate<SetCutInstallationRectangularDelegate>().Invoke(_nativePtr, aValue);
  public bool GetExportSweptSolidForSimpleGeometry() => GetDelegate<GetExportSweptSolidForSimpleGeometryDelegate>().Invoke(_nativePtr);
  public void SetExportSweptSolidForSimpleGeometry(bool aValue) => GetDelegate<SetExportSweptSolidForSimpleGeometryDelegate>().Invoke(_nativePtr, aValue);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class IfcOptionsLevelOfDetailInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr getExportEndTypeMaterializationFunctionPtr;
    internal IntPtr setExportEndTypeMaterializationFunctionPtr;
    internal IntPtr getCutEndTypeCounterpartsFunctionPtr;
    internal IntPtr setCutEndTypeCounterpartsFunctionPtr;
    internal IntPtr getExportVbaDrillingsFunctionPtr;
    internal IntPtr setExportVbaDrillingsFunctionPtr;
    internal IntPtr getExportVbaComponentsFunctionPtr;
    internal IntPtr setExportVbaComponentsFunctionPtr;
    internal IntPtr getCutDrillingsFunctionPtr;
    internal IntPtr setCutDrillingsFunctionPtr;
    internal IntPtr getExportInstallationRoundMaterializationFunctionPtr;
    internal IntPtr setExportInstallationRoundMaterializationFunctionPtr;
    internal IntPtr getExportInstallationRectangularMaterializationFunctionPtr;
    internal IntPtr setExportInstallationRectangularMaterializationFunctionPtr;
    internal IntPtr getCutInstallationRoundFunctionPtr;
    internal IntPtr setCutInstallationRoundFunctionPtr;
    internal IntPtr getCutInstallationRectangularFunctionPtr;
    internal IntPtr setCutInstallationRectangularFunctionPtr;
    internal IntPtr getExportSweptSolidForSimpleGeometryFunctionPtr;
    internal IntPtr setExportSweptSolidForSimpleGeometryFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetExportEndTypeMaterializationDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetExportEndTypeMaterializationDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetCutEndTypeCounterpartsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCutEndTypeCounterpartsDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetExportVbaDrillingsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetExportVbaDrillingsDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetExportVbaComponentsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetExportVbaComponentsDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetCutDrillingsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCutDrillingsDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetExportInstallationRoundMaterializationDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetExportInstallationRoundMaterializationDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetExportInstallationRectangularMaterializationDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetExportInstallationRectangularMaterializationDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetCutInstallationRoundDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCutInstallationRoundDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetCutInstallationRectangularDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCutInstallationRectangularDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetExportSweptSolidForSimpleGeometryDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetExportSweptSolidForSimpleGeometryDelegate(IntPtr thisPtr, bool aValue);
}

public class IfcOptionsAggregationWrapper
{
  private readonly IntPtr _nativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public IfcOptionsAggregationWrapper(IntPtr nativePtr)
  {
    _nativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<IfcOptionsAggregationInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(GetConsiderElementModuleAggregationDelegate), Marshal.GetDelegateForFunctionPointer<GetConsiderElementModuleAggregationDelegate>(vTable!.getConsiderElementModuleAggregationFunctionPtr) },
      { typeof(SetConsiderElementModuleAggregationDelegate), Marshal.GetDelegateForFunctionPointer<SetConsiderElementModuleAggregationDelegate>(vTable.setConsiderElementModuleAggregationFunctionPtr) },
      { typeof(GetElementModuleAggregationAttributeDelegate), Marshal.GetDelegateForFunctionPointer<GetElementModuleAggregationAttributeDelegate>(vTable.getElementModuleAggregationAttributeFunctionPtr) },
      { typeof(SetElementModuleAggregationAttributeDelegate), Marshal.GetDelegateForFunctionPointer<SetElementModuleAggregationAttributeDelegate>(vTable.setElementModuleAggregationAttributeFunctionPtr) },
      { typeof(GetExportElementCombineBehaviorDelegate), Marshal.GetDelegateForFunctionPointer<GetExportElementCombineBehaviorDelegate>(vTable.getExportElementCombineBehaviorFunctionPtr) },
      { typeof(SetExportElementCombineBehaviorDelegate), Marshal.GetDelegateForFunctionPointer<SetExportElementCombineBehaviorDelegate>(vTable.setExportElementCombineBehaviorFunctionPtr) },
      { typeof(GetExportCoverGeometryDelegate), Marshal.GetDelegateForFunctionPointer<GetExportCoverGeometryDelegate>(vTable.getExportCoverGeometryFunctionPtr) },
      { typeof(SetExportCoverGeometryDelegate), Marshal.GetDelegateForFunctionPointer<SetExportCoverGeometryDelegate>(vTable.setExportCoverGeometryFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public enum ElementGroupingType
  {
    Group = 1,
    Subgroup = 2,
    None = 3
  };

  public enum IfcElementCombineBehaviour
  {
    ElementModule = 0,
    ElementAssembly = 1,
  };

  public bool GetConsiderElementModuleAggregation() => GetDelegate<GetConsiderElementModuleAggregationDelegate>().Invoke(_nativePtr);
  public void SetConsiderElementModuleAggregation(bool aValue) => GetDelegate<SetConsiderElementModuleAggregationDelegate>().Invoke(_nativePtr, aValue);
  public ElementGroupingType GetElementModuleAggregationAttribute() => GetDelegate<GetElementModuleAggregationAttributeDelegate>().Invoke(_nativePtr);
  public void SetElementModuleAggregationAttribute(ElementGroupingType aAttribute) => GetDelegate<SetElementModuleAggregationAttributeDelegate>().Invoke(_nativePtr, aAttribute);
  public IfcElementCombineBehaviour GetExportElementCombineBehavior() => GetDelegate<GetExportElementCombineBehaviorDelegate>().Invoke(_nativePtr);
  public void SetExportElementCombineBehavior(IfcElementCombineBehaviour aState) => GetDelegate<SetExportElementCombineBehaviorDelegate>().Invoke(_nativePtr, aState);
  public bool GetExportCoverGeometry() => GetDelegate<GetExportCoverGeometryDelegate>().Invoke(_nativePtr);
  public void SetExportCoverGeometry(bool aValue) => GetDelegate<SetExportCoverGeometryDelegate>().Invoke(_nativePtr, aValue);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class IfcOptionsAggregationInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr getConsiderElementModuleAggregationFunctionPtr;
    internal IntPtr setConsiderElementModuleAggregationFunctionPtr;
    internal IntPtr getElementModuleAggregationAttributeFunctionPtr;
    internal IntPtr setElementModuleAggregationAttributeFunctionPtr;
    internal IntPtr getExportElementCombineBehaviorFunctionPtr;
    internal IntPtr setExportElementCombineBehaviorFunctionPtr;
    internal IntPtr getExportCoverGeometryFunctionPtr;
    internal IntPtr setExportCoverGeometryFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetConsiderElementModuleAggregationDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetConsiderElementModuleAggregationDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ElementGroupingType GetElementModuleAggregationAttributeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetElementModuleAggregationAttributeDelegate(IntPtr thisPtr, ElementGroupingType aAttribute);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IfcElementCombineBehaviour GetExportElementCombineBehaviorDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetExportElementCombineBehaviorDelegate(IntPtr thisPtr, IfcElementCombineBehaviour aState);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetExportCoverGeometryDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetExportCoverGeometryDelegate(IntPtr thisPtr, bool aValue);
}
