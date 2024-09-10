// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Helpers;

public class ElementTypeWrapper
{
  public readonly IntPtr NativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public ElementTypeWrapper(IntPtr nativePtr)
  {
    NativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<ElementTypeInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(DestroyDelegate), Marshal.GetDelegateForFunctionPointer<DestroyDelegate>(vTable!.destroyFunctionPtr) },
      { typeof(IsNoneDelegate), Marshal.GetDelegateForFunctionPointer<IsNoneDelegate>(vTable.isNoneFunctionPtr) },
      { typeof(IsNormalNodeDelegate), Marshal.GetDelegateForFunctionPointer<IsNormalNodeDelegate>(vTable.isNormalNodeFunctionPtr) },
      { typeof(IsConnectorNodeDelegate), Marshal.GetDelegateForFunctionPointer<IsConnectorNodeDelegate>(vTable.isConnectorNodeFunctionPtr) },
      { typeof(IsWireAxisDelegate), Marshal.GetDelegateForFunctionPointer<IsWireAxisDelegate>(vTable.isWireAxisFunctionPtr) },
      { typeof(IsEaveAxisDelegate), Marshal.GetDelegateForFunctionPointer<IsEaveAxisDelegate>(vTable.isEaveAxisFunctionPtr) },
      { typeof(IsRectangularAxisDelegate), Marshal.GetDelegateForFunctionPointer<IsRectangularAxisDelegate>(vTable.isRectangularAxisFunctionPtr) },
      { typeof(IsCircularAxisDelegate), Marshal.GetDelegateForFunctionPointer<IsCircularAxisDelegate>(vTable.isCircularAxisFunctionPtr) },
      { typeof(IsDrillingAxisDelegate), Marshal.GetDelegateForFunctionPointer<IsDrillingAxisDelegate>(vTable.isDrillingAxisFunctionPtr) },
      { typeof(IsConnectorAxisDelegate), Marshal.GetDelegateForFunctionPointer<IsConnectorAxisDelegate>(vTable.isConnectorAxisFunctionPtr) },
      { typeof(IsLineDelegate), Marshal.GetDelegateForFunctionPointer<IsLineDelegate>(vTable.isLineFunctionPtr) },
      { typeof(IsSurfaceDelegate), Marshal.GetDelegateForFunctionPointer<IsSurfaceDelegate>(vTable.isSurfaceFunctionPtr) },
      { typeof(IsCadworkDelegate), Marshal.GetDelegateForFunctionPointer<IsCadworkDelegate>(vTable.isCadworkFunctionPtr) },
      { typeof(IsGlobalCutDelegate), Marshal.GetDelegateForFunctionPointer<IsGlobalCutDelegate>(vTable.isGlobalCutFunctionPtr) },
      { typeof(IsWallDelegate), Marshal.GetDelegateForFunctionPointer<IsWallDelegate>(vTable.isWallFunctionPtr) },
      { typeof(IsOpeningDelegate), Marshal.GetDelegateForFunctionPointer<IsOpeningDelegate>(vTable.isOpeningFunctionPtr) },
      { typeof(IsFloorDelegate), Marshal.GetDelegateForFunctionPointer<IsFloorDelegate>(vTable.isFloorFunctionPtr) },
      { typeof(IsRoofDelegate), Marshal.GetDelegateForFunctionPointer<IsRoofDelegate>(vTable.isRoofFunctionPtr) },
      { typeof(IsContainerDelegate), Marshal.GetDelegateForFunctionPointer<IsContainerDelegate>(vTable.isContainerFunctionPtr) },
      { typeof(IsExportSolidDelegate), Marshal.GetDelegateForFunctionPointer<IsExportSolidDelegate>(vTable.isExportSolidFunctionPtr) },
      { typeof(IsAuxiliaryDelegate), Marshal.GetDelegateForFunctionPointer<IsAuxiliaryDelegate>(vTable.isAuxiliaryFunctionPtr) },
      { typeof(IsNestingParentDelegate), Marshal.GetDelegateForFunctionPointer<IsNestingParentDelegate>(vTable.isNestingParentFunctionPtr) },
      { typeof(IsRectangularBeamDelegate), Marshal.GetDelegateForFunctionPointer<IsRectangularBeamDelegate>(vTable.isRectangularBeamFunctionPtr) },
      { typeof(IsCircularBeamDelegate), Marshal.GetDelegateForFunctionPointer<IsCircularBeamDelegate>(vTable.isCircularBeamFunctionPtr) },
      { typeof(IsSteelShapeDelegate), Marshal.GetDelegateForFunctionPointer<IsSteelShapeDelegate>(vTable.isSteelShapeFunctionPtr) },
      { typeof(IsPanelDelegate), Marshal.GetDelegateForFunctionPointer<IsPanelDelegate>(vTable.isPanelFunctionPtr) },
      { typeof(IsRotationElementDelegate), Marshal.GetDelegateForFunctionPointer<IsRotationElementDelegate>(vTable.isRotationElementFunctionPtr) },
      { typeof(IsAdditionalElementDelegate), Marshal.GetDelegateForFunctionPointer<IsAdditionalElementDelegate>(vTable.isAdditionalElementFunctionPtr) },
      { typeof(IsRoomDelegate), Marshal.GetDelegateForFunctionPointer<IsRoomDelegate>(vTable.isRoomFunctionPtr) },
      { typeof(IsGraphicalObjectDelegate), Marshal.GetDelegateForFunctionPointer<IsGraphicalObjectDelegate>(vTable.isGraphicalObjectFunctionPtr) },
      { typeof(IsDimensionDelegate), Marshal.GetDelegateForFunctionPointer<IsDimensionDelegate>(vTable.isDimensionFunctionPtr) },
      { typeof(IsTextDocumentDelegate), Marshal.GetDelegateForFunctionPointer<IsTextDocumentDelegate>(vTable.isTextDocumentFunctionPtr) },
      { typeof(IsExportSolidSceneDelegate), Marshal.GetDelegateForFunctionPointer<IsExportSolidSceneDelegate>(vTable.isExportSolidSceneFunctionPtr) },
      { typeof(IsSectionTraceDelegate), Marshal.GetDelegateForFunctionPointer<IsSectionTraceDelegate>(vTable.isSectionTraceFunctionPtr) },
      { typeof(IsFramedWallDelegate), Marshal.GetDelegateForFunctionPointer<IsFramedWallDelegate>(vTable.isFramedWallFunctionPtr) },
      { typeof(IsSolidWoodWallDelegate), Marshal.GetDelegateForFunctionPointer<IsSolidWoodWallDelegate>(vTable.isSolidWoodWallFunctionPtr) },
      { typeof(IsLogWallDelegate), Marshal.GetDelegateForFunctionPointer<IsLogWallDelegate>(vTable.isLogWallFunctionPtr) },
      { typeof(IsFramedFloorDelegate), Marshal.GetDelegateForFunctionPointer<IsFramedFloorDelegate>(vTable.isFramedFloorFunctionPtr) },
      { typeof(IsSolidWoodFloorDelegate), Marshal.GetDelegateForFunctionPointer<IsSolidWoodFloorDelegate>(vTable.isSolidWoodFloorFunctionPtr) },
      { typeof(IsFramedRoofDelegate), Marshal.GetDelegateForFunctionPointer<IsFramedRoofDelegate>(vTable.isFramedRoofFunctionPtr) },
      { typeof(IsSolidWoodRoofDelegate), Marshal.GetDelegateForFunctionPointer<IsSolidWoodRoofDelegate>(vTable.isSolidWoodRoofFunctionPtr) },
      { typeof(IsCircularMepDelegate), Marshal.GetDelegateForFunctionPointer<IsCircularMepDelegate>(vTable.isCircularMEPFunctionPtr) },
      { typeof(IsRectangularMepDelegate), Marshal.GetDelegateForFunctionPointer<IsRectangularMepDelegate>(vTable.isRectangularMEPFunctionPtr) },
      { typeof(SetNoneDelegate), Marshal.GetDelegateForFunctionPointer<SetNoneDelegate>(vTable.setNoneFunctionPtr) },
      { typeof(SetNormalNodeDelegate), Marshal.GetDelegateForFunctionPointer<SetNormalNodeDelegate>(vTable.setNormalNodeFunctionPtr) },
      { typeof(SetConnectorNodeDelegate), Marshal.GetDelegateForFunctionPointer<SetConnectorNodeDelegate>(vTable.setConnectorNodeFunctionPtr) },
      { typeof(SetWireAxisDelegate), Marshal.GetDelegateForFunctionPointer<SetWireAxisDelegate>(vTable.setWireAxisFunctionPtr) },
      { typeof(SetEaveAxisDelegate), Marshal.GetDelegateForFunctionPointer<SetEaveAxisDelegate>(vTable.setEaveAxisFunctionPtr) },
      { typeof(SetRectangularAxisDelegate), Marshal.GetDelegateForFunctionPointer<SetRectangularAxisDelegate>(vTable.setRectangularAxisFunctionPtr) },
      { typeof(SetCircularAxisDelegate), Marshal.GetDelegateForFunctionPointer<SetCircularAxisDelegate>(vTable.setCircularAxisFunctionPtr) },
      { typeof(SetDrillingAxisDelegate), Marshal.GetDelegateForFunctionPointer<SetDrillingAxisDelegate>(vTable.setDrillingAxisFunctionPtr) },
      { typeof(SetConnectorAxisDelegate), Marshal.GetDelegateForFunctionPointer<SetConnectorAxisDelegate>(vTable.setConnectorAxisFunctionPtr) },
      { typeof(SetLineDelegate), Marshal.GetDelegateForFunctionPointer<SetLineDelegate>(vTable.setLineFunctionPtr) },
      { typeof(SetSurfaceDelegate), Marshal.GetDelegateForFunctionPointer<SetSurfaceDelegate>(vTable.setSurfaceFunctionPtr) },
      { typeof(SetCadworkDelegate), Marshal.GetDelegateForFunctionPointer<SetCadworkDelegate>(vTable.setCadworkFunctionPtr) },
      { typeof(SetGlobalCutDelegate), Marshal.GetDelegateForFunctionPointer<SetGlobalCutDelegate>(vTable.setGlobalCutFunctionPtr) },
      { typeof(SetOpeningDelegate), Marshal.GetDelegateForFunctionPointer<SetOpeningDelegate>(vTable.setOpeningFunctionPtr) },
      { typeof(SetContainerDelegate), Marshal.GetDelegateForFunctionPointer<SetContainerDelegate>(vTable.setContainerFunctionPtr) },
      { typeof(SetExportSolidDelegate), Marshal.GetDelegateForFunctionPointer<SetExportSolidDelegate>(vTable.setExportSolidFunctionPtr) },
      { typeof(SetAuxiliaryDelegate), Marshal.GetDelegateForFunctionPointer<SetAuxiliaryDelegate>(vTable.setAuxiliaryFunctionPtr) },
      { typeof(SetNestingParentDelegate), Marshal.GetDelegateForFunctionPointer<SetNestingParentDelegate>(vTable.setNestingParentFunctionPtr) },
      { typeof(SetRectangularBeamDelegate), Marshal.GetDelegateForFunctionPointer<SetRectangularBeamDelegate>(vTable.setRectangularBeamFunctionPtr) },
      { typeof(SetCircularBeamDelegate), Marshal.GetDelegateForFunctionPointer<SetCircularBeamDelegate>(vTable.setCircularBeamFunctionPtr) },
      { typeof(SetSteelShapeDelegate), Marshal.GetDelegateForFunctionPointer<SetSteelShapeDelegate>(vTable.setSteelShapeFunctionPtr) },
      { typeof(SetPanelDelegate), Marshal.GetDelegateForFunctionPointer<SetPanelDelegate>(vTable.setPanelFunctionPtr) },
      { typeof(SetRotationElementDelegate), Marshal.GetDelegateForFunctionPointer<SetRotationElementDelegate>(vTable.setRotationElementFunctionPtr) },
      { typeof(SetAdditionalElementDelegate), Marshal.GetDelegateForFunctionPointer<SetAdditionalElementDelegate>(vTable.setAdditionalElementFunctionPtr) },
      { typeof(SetRoomDelegate), Marshal.GetDelegateForFunctionPointer<SetRoomDelegate>(vTable.setRoomFunctionPtr) },
      { typeof(SetGraphicalObjectDelegate), Marshal.GetDelegateForFunctionPointer<SetGraphicalObjectDelegate>(vTable.setGraphicalObjectFunctionPtr) },
      { typeof(SetDimensionDelegate), Marshal.GetDelegateForFunctionPointer<SetDimensionDelegate>(vTable.setDimensionFunctionPtr) },
      { typeof(SetTextDocumentDelegate), Marshal.GetDelegateForFunctionPointer<SetTextDocumentDelegate>(vTable.setTextDocumentFunctionPtr) },
      { typeof(SetExportSolidSceneDelegate), Marshal.GetDelegateForFunctionPointer<SetExportSolidSceneDelegate>(vTable.setExportSolidSceneFunctionPtr) },
      { typeof(SetSectionTraceDelegate), Marshal.GetDelegateForFunctionPointer<SetSectionTraceDelegate>(vTable.setSectionTraceFunctionPtr) },
      { typeof(SetFramedWallDelegate), Marshal.GetDelegateForFunctionPointer<SetFramedWallDelegate>(vTable.setFramedWallFunctionPtr) },
      { typeof(SetSolidWoodWallDelegate), Marshal.GetDelegateForFunctionPointer<SetSolidWoodWallDelegate>(vTable.setSolidWoodWallFunctionPtr) },
      { typeof(SetLogWallDelegate), Marshal.GetDelegateForFunctionPointer<SetLogWallDelegate>(vTable.setLogWallFunctionPtr) },
      { typeof(SetFramedFloorDelegate), Marshal.GetDelegateForFunctionPointer<SetFramedFloorDelegate>(vTable.setFramedFloorFunctionPtr) },
      { typeof(SetSolidWoodFloorDelegate), Marshal.GetDelegateForFunctionPointer<SetSolidWoodFloorDelegate>(vTable.setSolidWoodFloorFunctionPtr) },
      { typeof(SetFramedRoofDelegate), Marshal.GetDelegateForFunctionPointer<SetFramedRoofDelegate>(vTable.setFramedRoofFunctionPtr) },
      { typeof(SetSolidWoodRoofDelegate), Marshal.GetDelegateForFunctionPointer<SetSolidWoodRoofDelegate>(vTable.setSolidWoodRoofFunctionPtr) },
      { typeof(SetCircularMepDelegate), Marshal.GetDelegateForFunctionPointer<SetCircularMepDelegate>(vTable.setCircularMEPFunctionPtr) },
      { typeof(SetRectangularMepDelegate), Marshal.GetDelegateForFunctionPointer<SetRectangularMepDelegate>(vTable.setRectangularMEPFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public void Destroy() => GetDelegate<DestroyDelegate>().Invoke(NativePtr);
  public bool IsNone() => GetDelegate<IsNoneDelegate>().Invoke(NativePtr);
  public bool IsNormalNode() => GetDelegate<IsNormalNodeDelegate>().Invoke(NativePtr);
  public bool IsConnectorNode() => GetDelegate<IsConnectorNodeDelegate>().Invoke(NativePtr);
  public bool IsWireAxis() => GetDelegate<IsWireAxisDelegate>().Invoke(NativePtr);
  public bool IsEaveAxis() => GetDelegate<IsEaveAxisDelegate>().Invoke(NativePtr);
  public bool IsRectangularAxis() => GetDelegate<IsRectangularAxisDelegate>().Invoke(NativePtr);
  public bool IsCircularAxis() => GetDelegate<IsCircularAxisDelegate>().Invoke(NativePtr);
  public bool IsDrillingAxis() => GetDelegate<IsDrillingAxisDelegate>().Invoke(NativePtr);
  public bool IsConnectorAxis() => GetDelegate<IsConnectorAxisDelegate>().Invoke(NativePtr);
  public bool IsLine() => GetDelegate<IsLineDelegate>().Invoke(NativePtr);
  public bool IsSurface() => GetDelegate<IsSurfaceDelegate>().Invoke(NativePtr);
  public bool IsCadwork() => GetDelegate<IsCadworkDelegate>().Invoke(NativePtr);
  public bool IsGlobalCut() => GetDelegate<IsGlobalCutDelegate>().Invoke(NativePtr);
  public bool IsWall() => GetDelegate<IsWallDelegate>().Invoke(NativePtr);
  public bool IsOpening() => GetDelegate<IsOpeningDelegate>().Invoke(NativePtr);
  public bool IsFloor() => GetDelegate<IsFloorDelegate>().Invoke(NativePtr);
  public bool IsRoof() => GetDelegate<IsRoofDelegate>().Invoke(NativePtr);
  public bool IsContainer() => GetDelegate<IsContainerDelegate>().Invoke(NativePtr);
  public bool IsExportSolid() => GetDelegate<IsExportSolidDelegate>().Invoke(NativePtr);
  public bool IsAuxiliary() => GetDelegate<IsAuxiliaryDelegate>().Invoke(NativePtr);
  public bool IsNestingParent() => GetDelegate<IsNestingParentDelegate>().Invoke(NativePtr);
  public bool IsRectangularBeam() => GetDelegate<IsRectangularBeamDelegate>().Invoke(NativePtr);
  public bool IsCircularBeam() => GetDelegate<IsCircularBeamDelegate>().Invoke(NativePtr);
  public bool IsSteelShape() => GetDelegate<IsSteelShapeDelegate>().Invoke(NativePtr);
  public bool IsPanel() => GetDelegate<IsPanelDelegate>().Invoke(NativePtr);
  public bool IsRotationElement() => GetDelegate<IsRotationElementDelegate>().Invoke(NativePtr);
  public bool IsAdditionalElement() => GetDelegate<IsAdditionalElementDelegate>().Invoke(NativePtr);
  public bool IsRoom() => GetDelegate<IsRoomDelegate>().Invoke(NativePtr);
  public bool IsGraphicalObject() => GetDelegate<IsGraphicalObjectDelegate>().Invoke(NativePtr);
  public bool IsDimension() => GetDelegate<IsDimensionDelegate>().Invoke(NativePtr);
  public bool IsTextDocument() => GetDelegate<IsTextDocumentDelegate>().Invoke(NativePtr);
  public bool IsExportSolidScene() => GetDelegate<IsExportSolidSceneDelegate>().Invoke(NativePtr);
  public bool IsSectionTrace() => GetDelegate<IsSectionTraceDelegate>().Invoke(NativePtr);
  public bool IsFramedWall() => GetDelegate<IsFramedWallDelegate>().Invoke(NativePtr);
  public bool IsSolidWoodWall() => GetDelegate<IsSolidWoodWallDelegate>().Invoke(NativePtr);
  public bool IsLogWall() => GetDelegate<IsLogWallDelegate>().Invoke(NativePtr);
  public bool IsFramedFloor() => GetDelegate<IsFramedFloorDelegate>().Invoke(NativePtr);
  public bool IsSolidWoodFloor() => GetDelegate<IsSolidWoodFloorDelegate>().Invoke(NativePtr);
  public bool IsFramedRoof() => GetDelegate<IsFramedRoofDelegate>().Invoke(NativePtr);
  public bool IsSolidWoodRoof() => GetDelegate<IsSolidWoodRoofDelegate>().Invoke(NativePtr);
  public bool IsCircularMep() => GetDelegate<IsCircularMepDelegate>().Invoke(NativePtr);
  public bool IsRectangularMep() => GetDelegate<IsRectangularMepDelegate>().Invoke(NativePtr);
  public void SetNone() => GetDelegate<SetNoneDelegate>().Invoke(NativePtr);
  public void SetNormalNode() => GetDelegate<SetNormalNodeDelegate>().Invoke(NativePtr);
  public void SetConnectorNode() => GetDelegate<SetConnectorNodeDelegate>().Invoke(NativePtr);
  public void SetWireAxis() => GetDelegate<SetWireAxisDelegate>().Invoke(NativePtr);
  public void SetEaveAxis() => GetDelegate<SetEaveAxisDelegate>().Invoke(NativePtr);
  public void SetRectangularAxis() => GetDelegate<SetRectangularAxisDelegate>().Invoke(NativePtr);
  public void SetCircularAxis() => GetDelegate<SetCircularAxisDelegate>().Invoke(NativePtr);
  public void SetDrillingAxis() => GetDelegate<SetDrillingAxisDelegate>().Invoke(NativePtr);
  public void SetConnectorAxis() => GetDelegate<SetConnectorAxisDelegate>().Invoke(NativePtr);
  public void SetLine() => GetDelegate<SetLineDelegate>().Invoke(NativePtr);
  public void SetSurface() => GetDelegate<SetSurfaceDelegate>().Invoke(NativePtr);
  public void SetCadwork() => GetDelegate<SetCadworkDelegate>().Invoke(NativePtr);
  public void SetGlobalCut() => GetDelegate<SetGlobalCutDelegate>().Invoke(NativePtr);
  public void SetOpening() => GetDelegate<SetOpeningDelegate>().Invoke(NativePtr);
  public void SetContainer() => GetDelegate<SetContainerDelegate>().Invoke(NativePtr);
  public void SetExportSolid() => GetDelegate<SetExportSolidDelegate>().Invoke(NativePtr);
  public void SetAuxiliary() => GetDelegate<SetAuxiliaryDelegate>().Invoke(NativePtr);
  public void SetNestingParent() => GetDelegate<SetNestingParentDelegate>().Invoke(NativePtr);
  public void SetRectangularBeam() => GetDelegate<SetRectangularBeamDelegate>().Invoke(NativePtr);
  public void SetCircularBeam() => GetDelegate<SetCircularBeamDelegate>().Invoke(NativePtr);
  public void SetSteelShape() => GetDelegate<SetSteelShapeDelegate>().Invoke(NativePtr);
  public void SetPanel() => GetDelegate<SetPanelDelegate>().Invoke(NativePtr);
  public void SetRotationElement() => GetDelegate<SetRotationElementDelegate>().Invoke(NativePtr);
  public void SetAdditionalElement() => GetDelegate<SetAdditionalElementDelegate>().Invoke(NativePtr);
  public void SetRoom() => GetDelegate<SetRoomDelegate>().Invoke(NativePtr);
  public void SetGraphicalObject() => GetDelegate<SetGraphicalObjectDelegate>().Invoke(NativePtr);
  public void SetDimension() => GetDelegate<SetDimensionDelegate>().Invoke(NativePtr);
  public void SetTextDocument() => GetDelegate<SetTextDocumentDelegate>().Invoke(NativePtr);
  public void SetExportSolidScene() => GetDelegate<SetExportSolidSceneDelegate>().Invoke(NativePtr);
  public void SetSectionTrace() => GetDelegate<SetSectionTraceDelegate>().Invoke(NativePtr);
  public void SetFramedWall() => GetDelegate<SetFramedWallDelegate>().Invoke(NativePtr);
  public void SetSolidWoodWall() => GetDelegate<SetSolidWoodWallDelegate>().Invoke(NativePtr);
  public void SetLogWall() => GetDelegate<SetLogWallDelegate>().Invoke(NativePtr);
  public void SetFramedFloor() => GetDelegate<SetFramedFloorDelegate>().Invoke(NativePtr);
  public void SetSolidWoodFloor() => GetDelegate<SetSolidWoodFloorDelegate>().Invoke(NativePtr);
  public void SetFramedRoof() => GetDelegate<SetFramedRoofDelegate>().Invoke(NativePtr);
  public void SetSolidWoodRoof() => GetDelegate<SetSolidWoodRoofDelegate>().Invoke(NativePtr);
  public void SetCircularMep() => GetDelegate<SetCircularMepDelegate>().Invoke(NativePtr);
  public void SetRectangularMep() => GetDelegate<SetRectangularMepDelegate>().Invoke(NativePtr);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class ElementTypeInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr destroyFunctionPtr;
    internal IntPtr isNoneFunctionPtr;
    internal IntPtr isNormalNodeFunctionPtr;
    internal IntPtr isConnectorNodeFunctionPtr;
    internal IntPtr isWireAxisFunctionPtr;
    internal IntPtr isEaveAxisFunctionPtr;
    internal IntPtr isRectangularAxisFunctionPtr;
    internal IntPtr isCircularAxisFunctionPtr;
    internal IntPtr isDrillingAxisFunctionPtr;
    internal IntPtr isConnectorAxisFunctionPtr;
    internal IntPtr isLineFunctionPtr;
    internal IntPtr isSurfaceFunctionPtr;
    internal IntPtr isCadworkFunctionPtr;
    internal IntPtr isGlobalCutFunctionPtr;
    internal IntPtr isWallFunctionPtr;
    internal IntPtr isOpeningFunctionPtr;
    internal IntPtr isFloorFunctionPtr;
    internal IntPtr isRoofFunctionPtr;
    internal IntPtr isContainerFunctionPtr;
    internal IntPtr isExportSolidFunctionPtr;
    internal IntPtr isAuxiliaryFunctionPtr;
    internal IntPtr isNestingParentFunctionPtr;
    internal IntPtr isRectangularBeamFunctionPtr;
    internal IntPtr isCircularBeamFunctionPtr;
    internal IntPtr isSteelShapeFunctionPtr;
    internal IntPtr isPanelFunctionPtr;
    internal IntPtr isRotationElementFunctionPtr;
    internal IntPtr isAdditionalElementFunctionPtr;
    internal IntPtr isRoomFunctionPtr;
    internal IntPtr isGraphicalObjectFunctionPtr;
    internal IntPtr isDimensionFunctionPtr;
    internal IntPtr isTextDocumentFunctionPtr;
    internal IntPtr isExportSolidSceneFunctionPtr;
    internal IntPtr isSectionTraceFunctionPtr;
    internal IntPtr isFramedWallFunctionPtr;
    internal IntPtr isSolidWoodWallFunctionPtr;
    internal IntPtr isLogWallFunctionPtr;
    internal IntPtr isFramedFloorFunctionPtr;
    internal IntPtr isSolidWoodFloorFunctionPtr;
    internal IntPtr isFramedRoofFunctionPtr;
    internal IntPtr isSolidWoodRoofFunctionPtr;
    internal IntPtr isCircularMEPFunctionPtr;
    internal IntPtr isRectangularMEPFunctionPtr;
    internal IntPtr setNoneFunctionPtr;
    internal IntPtr setNormalNodeFunctionPtr;
    internal IntPtr setConnectorNodeFunctionPtr;
    internal IntPtr setWireAxisFunctionPtr;
    internal IntPtr setEaveAxisFunctionPtr;
    internal IntPtr setRectangularAxisFunctionPtr;
    internal IntPtr setCircularAxisFunctionPtr;
    internal IntPtr setDrillingAxisFunctionPtr;
    internal IntPtr setConnectorAxisFunctionPtr;
    internal IntPtr setLineFunctionPtr;
    internal IntPtr setSurfaceFunctionPtr;
    internal IntPtr setCadworkFunctionPtr;
    internal IntPtr setGlobalCutFunctionPtr;
    internal IntPtr setOpeningFunctionPtr;
    internal IntPtr setContainerFunctionPtr;
    internal IntPtr setExportSolidFunctionPtr;
    internal IntPtr setAuxiliaryFunctionPtr;
    internal IntPtr setNestingParentFunctionPtr;
    internal IntPtr setRectangularBeamFunctionPtr;
    internal IntPtr setCircularBeamFunctionPtr;
    internal IntPtr setSteelShapeFunctionPtr;
    internal IntPtr setPanelFunctionPtr;
    internal IntPtr setRotationElementFunctionPtr;
    internal IntPtr setAdditionalElementFunctionPtr;
    internal IntPtr setRoomFunctionPtr;
    internal IntPtr setGraphicalObjectFunctionPtr;
    internal IntPtr setDimensionFunctionPtr;
    internal IntPtr setTextDocumentFunctionPtr;
    internal IntPtr setExportSolidSceneFunctionPtr;
    internal IntPtr setSectionTraceFunctionPtr;
    internal IntPtr setFramedWallFunctionPtr;
    internal IntPtr setSolidWoodWallFunctionPtr;
    internal IntPtr setLogWallFunctionPtr;
    internal IntPtr setFramedFloorFunctionPtr;
    internal IntPtr setSolidWoodFloorFunctionPtr;
    internal IntPtr setFramedRoofFunctionPtr;
    internal IntPtr setSolidWoodRoofFunctionPtr;
    internal IntPtr setCircularMEPFunctionPtr;
    internal IntPtr setRectangularMEPFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DestroyDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsNoneDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsNormalNodeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsConnectorNodeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsWireAxisDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsEaveAxisDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsRectangularAxisDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsCircularAxisDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsDrillingAxisDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsConnectorAxisDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsLineDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsSurfaceDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsCadworkDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsGlobalCutDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsWallDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsOpeningDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsFloorDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsRoofDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsContainerDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsExportSolidDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsAuxiliaryDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsNestingParentDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsRectangularBeamDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsCircularBeamDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsSteelShapeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsPanelDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsRotationElementDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsAdditionalElementDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsRoomDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsGraphicalObjectDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsDimensionDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsTextDocumentDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsExportSolidSceneDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsSectionTraceDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsFramedWallDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsSolidWoodWallDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsLogWallDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsFramedFloorDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsSolidWoodFloorDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsFramedRoofDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsSolidWoodRoofDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsCircularMepDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsRectangularMepDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetNoneDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetNormalNodeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetConnectorNodeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetWireAxisDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetEaveAxisDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetRectangularAxisDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCircularAxisDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetDrillingAxisDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetConnectorAxisDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetLineDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetSurfaceDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCadworkDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetGlobalCutDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetOpeningDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetContainerDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetExportSolidDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetAuxiliaryDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetNestingParentDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetRectangularBeamDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCircularBeamDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetSteelShapeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetPanelDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetRotationElementDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetAdditionalElementDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetRoomDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetGraphicalObjectDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetDimensionDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetTextDocumentDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetExportSolidSceneDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetSectionTraceDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetFramedWallDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetSolidWoodWallDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetLogWallDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetFramedFloorDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetSolidWoodFloorDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetFramedRoofDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetSolidWoodRoofDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCircularMepDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetRectangularMepDelegate(IntPtr thisPtr);
}
