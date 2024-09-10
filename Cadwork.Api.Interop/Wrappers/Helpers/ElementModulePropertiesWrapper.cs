// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Helpers;

public class ElementModulePropertiesWrapper
{
  public readonly IntPtr NativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public ElementModulePropertiesWrapper(IntPtr nativePtr)
  {
    NativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<ElementModulePropertiesInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(DestroyDelegate), Marshal.GetDelegateForFunctionPointer<DestroyDelegate>(vTable!.destroyFunctionPtr) },
      { typeof(IsStretchWithTopOfWallDelegate), Marshal.GetDelegateForFunctionPointer<IsStretchWithTopOfWallDelegate>(vTable.isStretchWithTopOfWallFunctionPtr) },
      { typeof(IsMoveWithTopOfWallDelegate), Marshal.GetDelegateForFunctionPointer<IsMoveWithTopOfWallDelegate>(vTable.isMoveWithTopOfWallFunctionPtr) },
      { typeof(IsDistributeInAxisDirectionDelegate), Marshal.GetDelegateForFunctionPointer<IsDistributeInAxisDirectionDelegate>(vTable.isDistributeInAxisDirectionFunctionPtr) },
      { typeof(IsDistributePerpendicularToAxisDirectionDelegate), Marshal.GetDelegateForFunctionPointer<IsDistributePerpendicularToAxisDirectionDelegate>(vTable.isDistributePerpendicularToAxisDirectionFunctionPtr) },
      { typeof(IsStopDistributionInAxisDirectionDelegate), Marshal.GetDelegateForFunctionPointer<IsStopDistributionInAxisDirectionDelegate>(vTable.isStopDistributionInAxisDirectionFunctionPtr) },
      { typeof(IsStopDistributionPerpendicularToAxisDirectionDelegate), Marshal.GetDelegateForFunctionPointer<IsStopDistributionPerpendicularToAxisDirectionDelegate>(vTable.isStopDistributionPerpendicularToAxisDirectionFunctionPtr) },
      { typeof(IsBottomPlateDelegate), Marshal.GetDelegateForFunctionPointer<IsBottomPlateDelegate>(vTable.isBottomPlateFunctionPtr) },
      { typeof(IsTopPlateDelegate), Marshal.GetDelegateForFunctionPointer<IsTopPlateDelegate>(vTable.isTopPlateFunctionPtr) },
      { typeof(IsOpeningSillDelegate), Marshal.GetDelegateForFunctionPointer<IsOpeningSillDelegate>(vTable.isOpeningSillFunctionPtr) },
      { typeof(IsOpeningLintelDelegate), Marshal.GetDelegateForFunctionPointer<IsOpeningLintelDelegate>(vTable.isOpeningLintelFunctionPtr) },
      { typeof(IsCuttingElementDelegate), Marshal.GetDelegateForFunctionPointer<IsCuttingElementDelegate>(vTable.isCuttingElementFunctionPtr) },
      { typeof(IsNotCutWithCuttingElementDelegate), Marshal.GetDelegateForFunctionPointer<IsNotCutWithCuttingElementDelegate>(vTable.isNotCutWithCuttingElementFunctionPtr) },
      { typeof(IsAuxiliaryDelegate), Marshal.GetDelegateForFunctionPointer<IsAuxiliaryDelegate>(vTable.isAuxiliaryFunctionPtr) },
      { typeof(IsNotPlacedAtEndOfWallDelegate), Marshal.GetDelegateForFunctionPointer<IsNotPlacedAtEndOfWallDelegate>(vTable.isNotPlacedAtEndOfWallFunctionPtr) },
      { typeof(IsNotPlacedAtStartOfWallDelegate), Marshal.GetDelegateForFunctionPointer<IsNotPlacedAtStartOfWallDelegate>(vTable.isNotPlacedAtStartOfWallFunctionPtr) },
      { typeof(IsStretchWithOpeningLintelDelegate), Marshal.GetDelegateForFunctionPointer<IsStretchWithOpeningLintelDelegate>(vTable.isStretchWithOpeningLintelFunctionPtr) },
      { typeof(IsStretchWithOpeningSillDelegate), Marshal.GetDelegateForFunctionPointer<IsStretchWithOpeningSillDelegate>(vTable.isStretchWithOpeningSillFunctionPtr) },
      { typeof(IsSolderInAxisDirectionDelegate), Marshal.GetDelegateForFunctionPointer<IsSolderInAxisDirectionDelegate>(vTable.isSolderInAxisDirectionFunctionPtr) },
      { typeof(IsNoCollisionControlDelegate), Marshal.GetDelegateForFunctionPointer<IsNoCollisionControlDelegate>(vTable.isNoCollisionControlFunctionPtr) },
      { typeof(IsNoInsideControlDelegate), Marshal.GetDelegateForFunctionPointer<IsNoInsideControlDelegate>(vTable.isNoInsideControlFunctionPtr) },
      { typeof(IsUseForDetailCoordinateSystemDelegate), Marshal.GetDelegateForFunctionPointer<IsUseForDetailCoordinateSystemDelegate>(vTable.isUseForDetailCoordinateSystemFunctionPtr) },
      { typeof(SetStretchWithTopOfWallDelegate), Marshal.GetDelegateForFunctionPointer<SetStretchWithTopOfWallDelegate>(vTable.setStretchWithTopOfWallFunctionPtr) },
      { typeof(SetMoveWithTopOfWallDelegate), Marshal.GetDelegateForFunctionPointer<SetMoveWithTopOfWallDelegate>(vTable.setMoveWithTopOfWallFunctionPtr) },
      { typeof(SetDistributeInAxisDirectionDelegate), Marshal.GetDelegateForFunctionPointer<SetDistributeInAxisDirectionDelegate>(vTable.setDistributeInAxisDirectionFunctionPtr) },
      { typeof(SetDistributePerpendicularToAxisDirectionDelegate), Marshal.GetDelegateForFunctionPointer<SetDistributePerpendicularToAxisDirectionDelegate>(vTable.setDistributePerpendicularToAxisDirectionFunctionPtr) },
      { typeof(SetStopDistributionInAxisDirectionDelegate), Marshal.GetDelegateForFunctionPointer<SetStopDistributionInAxisDirectionDelegate>(vTable.setStopDistributionInAxisDirectionFunctionPtr) },
      { typeof(SetStopDistributionPerpendicularToAxisDirectionDelegate), Marshal.GetDelegateForFunctionPointer<SetStopDistributionPerpendicularToAxisDirectionDelegate>(vTable.setStopDistributionPerpendicularToAxisDirectionFunctionPtr) },
      { typeof(SetBottomPlateDelegate), Marshal.GetDelegateForFunctionPointer<SetBottomPlateDelegate>(vTable.setBottomPlateFunctionPtr) },
      { typeof(SetTopPlateDelegate), Marshal.GetDelegateForFunctionPointer<SetTopPlateDelegate>(vTable.setTopPlateFunctionPtr) },
      { typeof(SetOpeningSillDelegate), Marshal.GetDelegateForFunctionPointer<SetOpeningSillDelegate>(vTable.setOpeningSillFunctionPtr) },
      { typeof(SetOpeningLintelDelegate), Marshal.GetDelegateForFunctionPointer<SetOpeningLintelDelegate>(vTable.setOpeningLintelFunctionPtr) },
      { typeof(SetCuttingElementDelegate), Marshal.GetDelegateForFunctionPointer<SetCuttingElementDelegate>(vTable.setCuttingElementFunctionPtr) },
      { typeof(SetNotCutWithCuttingElementDelegate), Marshal.GetDelegateForFunctionPointer<SetNotCutWithCuttingElementDelegate>(vTable.setNotCutWithCuttingElementFunctionPtr) },
      { typeof(SetAuxiliaryDelegate), Marshal.GetDelegateForFunctionPointer<SetAuxiliaryDelegate>(vTable.setAuxiliaryFunctionPtr) },
      { typeof(SetNotPlacedAtEndOfWallDelegate), Marshal.GetDelegateForFunctionPointer<SetNotPlacedAtEndOfWallDelegate>(vTable.setNotPlacedAtEndOfWallFunctionPtr) },
      { typeof(SetNotPlacedAtStartOfWallDelegate), Marshal.GetDelegateForFunctionPointer<SetNotPlacedAtStartOfWallDelegate>(vTable.setNotPlacedAtStartOfWallFunctionPtr) },
      { typeof(SetStretchWithOpeningLintelDelegate), Marshal.GetDelegateForFunctionPointer<SetStretchWithOpeningLintelDelegate>(vTable.setStretchWithOpeningLintelFunctionPtr) },
      { typeof(SetStretchWithOpeningSillDelegate), Marshal.GetDelegateForFunctionPointer<SetStretchWithOpeningSillDelegate>(vTable.setStretchWithOpeningSillFunctionPtr) },
      { typeof(SetSolderInAxisDirectionDelegate), Marshal.GetDelegateForFunctionPointer<SetSolderInAxisDirectionDelegate>(vTable.setSolderInAxisDirectionFunctionPtr) },
      { typeof(SetNoCollisionControlDelegate), Marshal.GetDelegateForFunctionPointer<SetNoCollisionControlDelegate>(vTable.setNoCollisionControlFunctionPtr) },
      { typeof(SetNoInsideControlDelegate), Marshal.GetDelegateForFunctionPointer<SetNoInsideControlDelegate>(vTable.setNoInsideControlFunctionPtr) },
      { typeof(SetUseForDetailCoordinateSystemDelegate), Marshal.GetDelegateForFunctionPointer<SetUseForDetailCoordinateSystemDelegate>(vTable.setUseForDetailCoordinateSystemFunctionPtr) },
      { typeof(GetDistributeInAxisDirectionDistanceDelegate), Marshal.GetDelegateForFunctionPointer<GetDistributeInAxisDirectionDistanceDelegate>(vTable.getDistributeInAxisDirectionDistanceFunctionPtr) },
      { typeof(GetDistributePerpendicularToAxisDirectionDistanceDelegate), Marshal.GetDelegateForFunctionPointer<GetDistributePerpendicularToAxisDirectionDistanceDelegate>(vTable.getDistributePerpendicularToAxisDirectionDistanceFunctionPtr) },
      { typeof(GetCuttingElementPriorityDelegate), Marshal.GetDelegateForFunctionPointer<GetCuttingElementPriorityDelegate>(vTable.getCuttingElementPriorityFunctionPtr) },
      { typeof(IsDistributeInAxisDirectionUseMaxDistanceDelegate), Marshal.GetDelegateForFunctionPointer<IsDistributeInAxisDirectionUseMaxDistanceDelegate>(vTable.isDistributeInAxisDirectionUseMaxDistanceFunctionPtr) },
      { typeof(IsDistributePerpendicularToAxisDirectionUseMaxDistanceDelegate), Marshal.GetDelegateForFunctionPointer<IsDistributePerpendicularToAxisDirectionUseMaxDistanceDelegate>(vTable.isDistributePerpendicularToAxisDirectionUseMaxDistanceFunctionPtr) },
      { typeof(IsDistributeInAxisDirectionUseNumberDelegate), Marshal.GetDelegateForFunctionPointer<IsDistributeInAxisDirectionUseNumberDelegate>(vTable.isDistributeInAxisDirectionUseNumberFunctionPtr) },
      { typeof(IsDistributePerpendicularToAxisDirectionUseNumberDelegate), Marshal.GetDelegateForFunctionPointer<IsDistributePerpendicularToAxisDirectionUseNumberDelegate>(vTable.isDistributePerpendicularToAxisDirectionUseNumberFunctionPtr) },
      { typeof(SetDistributeInAxisDirectionUseMaxDistanceDelegate), Marshal.GetDelegateForFunctionPointer<SetDistributeInAxisDirectionUseMaxDistanceDelegate>(vTable.setDistributeInAxisDirectionUseMaxDistanceFunctionPtr) },
      { typeof(SetDistributePerpendicularToAxisDirectionUseMaxDistanceDelegate), Marshal.GetDelegateForFunctionPointer<SetDistributePerpendicularToAxisDirectionUseMaxDistanceDelegate>(vTable.setDistributePerpendicularToAxisDirectionUseMaxDistanceFunctionPtr) },
      { typeof(SetDistributeInAxisDirectionUseNumberDelegate), Marshal.GetDelegateForFunctionPointer<SetDistributeInAxisDirectionUseNumberDelegate>(vTable.setDistributeInAxisDirectionUseNumberFunctionPtr) },
      { typeof(SetDistributePerpendicularToAxisDirectionUseNumberDelegate), Marshal.GetDelegateForFunctionPointer<SetDistributePerpendicularToAxisDirectionUseNumberDelegate>(vTable.setDistributePerpendicularToAxisDirectionUseNumberFunctionPtr) },
      { typeof(GetDistributeInAxisDirectionNumberDelegate), Marshal.GetDelegateForFunctionPointer<GetDistributeInAxisDirectionNumberDelegate>(vTable.getDistributeInAxisDirectionNumberFunctionPtr) },
      { typeof(GetDistributePerpendicularToAxisDirectionNumberDelegate), Marshal.GetDelegateForFunctionPointer<GetDistributePerpendicularToAxisDirectionNumberDelegate>(vTable.getDistributePerpendicularToAxisDirectionNumberFunctionPtr) },
      { typeof(IsMainElementDelegate), Marshal.GetDelegateForFunctionPointer<IsMainElementDelegate>(vTable.isMainElementFunctionPtr) },
      { typeof(IsStretchAccordingThicknessAxisDelegate), Marshal.GetDelegateForFunctionPointer<IsStretchAccordingThicknessAxisDelegate>(vTable.isStretchAccordingThicknessAxisFunctionPtr) },
      { typeof(IsStretchAccordingLengthAxisDelegate), Marshal.GetDelegateForFunctionPointer<IsStretchAccordingLengthAxisDelegate>(vTable.isStretchAccordingLengthAxisFunctionPtr) },
      { typeof(IsMoveAccordingThicknessAxisDelegate), Marshal.GetDelegateForFunctionPointer<IsMoveAccordingThicknessAxisDelegate>(vTable.isMoveAccordingThicknessAxisFunctionPtr) },
      { typeof(IsMoveAccordingLengthAxisDelegate), Marshal.GetDelegateForFunctionPointer<IsMoveAccordingLengthAxisDelegate>(vTable.isMoveAccordingLengthAxisFunctionPtr) },
      { typeof(IsUniqueLayerNameDelegate), Marshal.GetDelegateForFunctionPointer<IsUniqueLayerNameDelegate>(vTable.isUniqueLayerNameFunctionPtr) },
      { typeof(IsKeepInCenterOfLayerCurrentWallDelegate), Marshal.GetDelegateForFunctionPointer<IsKeepInCenterOfLayerCurrentWallDelegate>(vTable.isKeepInCenterOfLayerCurrentWallFunctionPtr) },
      { typeof(IsKeepInCenterOfLayerNeighbourWallDelegate), Marshal.GetDelegateForFunctionPointer<IsKeepInCenterOfLayerNeighbourWallDelegate>(vTable.isKeepInCenterOfLayerNeighbourWallFunctionPtr) },
      { typeof(IsKeepInCenterOfRoughVolumeDelegate), Marshal.GetDelegateForFunctionPointer<IsKeepInCenterOfRoughVolumeDelegate>(vTable.isKeepInCenterOfRoughVolumeFunctionPtr) },
      { typeof(IsElementFromDetailDelegate), Marshal.GetDelegateForFunctionPointer<IsElementFromDetailDelegate>(vTable.isElementFromDetailFunctionPtr) },
      { typeof(SetMainElementDelegate), Marshal.GetDelegateForFunctionPointer<SetMainElementDelegate>(vTable.setMainElementFunctionPtr) },
      { typeof(SetStretchAccordingThicknessAxisDelegate), Marshal.GetDelegateForFunctionPointer<SetStretchAccordingThicknessAxisDelegate>(vTable.setStretchAccordingThicknessAxisFunctionPtr) },
      { typeof(SetStretchAccordingLengthAxisDelegate), Marshal.GetDelegateForFunctionPointer<SetStretchAccordingLengthAxisDelegate>(vTable.setStretchAccordingLengthAxisFunctionPtr) },
      { typeof(SetMoveAccordingThicknessAxisDelegate), Marshal.GetDelegateForFunctionPointer<SetMoveAccordingThicknessAxisDelegate>(vTable.setMoveAccordingThicknessAxisFunctionPtr) },
      { typeof(SetMoveAccordingLengthAxisDelegate), Marshal.GetDelegateForFunctionPointer<SetMoveAccordingLengthAxisDelegate>(vTable.setMoveAccordingLengthAxisFunctionPtr) },
      { typeof(SetUniqueLayerNameDelegate), Marshal.GetDelegateForFunctionPointer<SetUniqueLayerNameDelegate>(vTable.setUniqueLayerNameFunctionPtr) },
      { typeof(SetKeepInCenterOfLayerCurrentWallDelegate), Marshal.GetDelegateForFunctionPointer<SetKeepInCenterOfLayerCurrentWallDelegate>(vTable.setKeepInCenterOfLayerCurrentWallFunctionPtr) },
      { typeof(SetKeepInCenterOfLayerNeighbourWallDelegate), Marshal.GetDelegateForFunctionPointer<SetKeepInCenterOfLayerNeighbourWallDelegate>(vTable.setKeepInCenterOfLayerNeighbourWallFunctionPtr) },
      { typeof(SetKeepInCenterOfRoughVolumeDelegate), Marshal.GetDelegateForFunctionPointer<SetKeepInCenterOfRoughVolumeDelegate>(vTable.setKeepInCenterOfRoughVolumeFunctionPtr) },
      { typeof(SetElementFromDetailDelegate), Marshal.GetDelegateForFunctionPointer<SetElementFromDetailDelegate>(vTable.setElementFromDetailFunctionPtr) },
      { typeof(GetUniqueLayerNameDelegate), Marshal.GetDelegateForFunctionPointer<GetUniqueLayerNameDelegate>(vTable.getUniqueLayerNameFunctionPtr) },
      { typeof(GetKeepInCenterOfLayerCurrentWallDelegate), Marshal.GetDelegateForFunctionPointer<GetKeepInCenterOfLayerCurrentWallDelegate>(vTable.getKeepInCenterOfLayerCurrentWallFunctionPtr) },
      { typeof(GetKeepInCenterOfLayerNeighbourWallDelegate), Marshal.GetDelegateForFunctionPointer<GetKeepInCenterOfLayerNeighbourWallDelegate>(vTable.getKeepInCenterOfLayerNeighbourWallFunctionPtr) },
      { typeof(SetStretchInOpeningWidthDelegate), Marshal.GetDelegateForFunctionPointer<SetStretchInOpeningWidthDelegate>(vTable.setStretchInOpeningWidthFunctionPtr) },
      { typeof(IsStretchInOpeningWidthDelegate), Marshal.GetDelegateForFunctionPointer<IsStretchInOpeningWidthDelegate>(vTable.isStretchInOpeningWidthFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public void Destroy() => GetDelegate<DestroyDelegate>().Invoke(NativePtr);
  public bool IsStretchWithTopOfWall() => GetDelegate<IsStretchWithTopOfWallDelegate>().Invoke(NativePtr);
  public bool IsMoveWithTopOfWall() => GetDelegate<IsMoveWithTopOfWallDelegate>().Invoke(NativePtr);
  public bool IsDistributeInAxisDirection() => GetDelegate<IsDistributeInAxisDirectionDelegate>().Invoke(NativePtr);
  public bool IsDistributePerpendicularToAxisDirection() => GetDelegate<IsDistributePerpendicularToAxisDirectionDelegate>().Invoke(NativePtr);
  public bool IsStopDistributionInAxisDirection() => GetDelegate<IsStopDistributionInAxisDirectionDelegate>().Invoke(NativePtr);
  public bool IsStopDistributionPerpendicularToAxisDirection() => GetDelegate<IsStopDistributionPerpendicularToAxisDirectionDelegate>().Invoke(NativePtr);
  public bool IsBottomPlate() => GetDelegate<IsBottomPlateDelegate>().Invoke(NativePtr);
  public bool IsTopPlate() => GetDelegate<IsTopPlateDelegate>().Invoke(NativePtr);
  public bool IsOpeningSill() => GetDelegate<IsOpeningSillDelegate>().Invoke(NativePtr);
  public bool IsOpeningLintel() => GetDelegate<IsOpeningLintelDelegate>().Invoke(NativePtr);
  public bool IsCuttingElement() => GetDelegate<IsCuttingElementDelegate>().Invoke(NativePtr);
  public bool IsNotCutWithCuttingElement() => GetDelegate<IsNotCutWithCuttingElementDelegate>().Invoke(NativePtr);
  public bool IsAuxiliary() => GetDelegate<IsAuxiliaryDelegate>().Invoke(NativePtr);
  public bool IsNotPlacedAtEndOfWall() => GetDelegate<IsNotPlacedAtEndOfWallDelegate>().Invoke(NativePtr);
  public bool IsNotPlacedAtStartOfWall() => GetDelegate<IsNotPlacedAtStartOfWallDelegate>().Invoke(NativePtr);
  public bool IsStretchWithOpeningLintel() => GetDelegate<IsStretchWithOpeningLintelDelegate>().Invoke(NativePtr);
  public bool IsStretchWithOpeningSill() => GetDelegate<IsStretchWithOpeningSillDelegate>().Invoke(NativePtr);
  public bool IsSolderInAxisDirection() => GetDelegate<IsSolderInAxisDirectionDelegate>().Invoke(NativePtr);
  public bool IsNoCollisionControl() => GetDelegate<IsNoCollisionControlDelegate>().Invoke(NativePtr);
  public bool IsNoInsideControl() => GetDelegate<IsNoInsideControlDelegate>().Invoke(NativePtr);
  public bool IsUseForDetailCoordinateSystem() => GetDelegate<IsUseForDetailCoordinateSystemDelegate>().Invoke(NativePtr);
  public void SetStretchWithTopOfWall(bool aActive) => GetDelegate<SetStretchWithTopOfWallDelegate>().Invoke(NativePtr, aActive);
  public void SetMoveWithTopOfWall(bool aActive) => GetDelegate<SetMoveWithTopOfWallDelegate>().Invoke(NativePtr, aActive);
  public void SetDistributeInAxisDirection(bool aActive, double aDistance) => GetDelegate<SetDistributeInAxisDirectionDelegate>().Invoke(NativePtr, aActive, aDistance);
  public void SetDistributePerpendicularToAxisDirection(bool aActive, double aDistance) => GetDelegate<SetDistributePerpendicularToAxisDirectionDelegate>().Invoke(NativePtr, aActive, aDistance);
  public void SetStopDistributionInAxisDirection(bool aActive) => GetDelegate<SetStopDistributionInAxisDirectionDelegate>().Invoke(NativePtr, aActive);
  public void SetStopDistributionPerpendicularToAxisDirection(bool aActive) => GetDelegate<SetStopDistributionPerpendicularToAxisDirectionDelegate>().Invoke(NativePtr, aActive);
  public void SetBottomPlate(bool aActive) => GetDelegate<SetBottomPlateDelegate>().Invoke(NativePtr, aActive);
  public void SetTopPlate(bool aActive) => GetDelegate<SetTopPlateDelegate>().Invoke(NativePtr, aActive);
  public void SetOpeningSill(bool aActive) => GetDelegate<SetOpeningSillDelegate>().Invoke(NativePtr, aActive);
  public void SetOpeningLintel(bool aActive) => GetDelegate<SetOpeningLintelDelegate>().Invoke(NativePtr, aActive);
  public void SetCuttingElement(bool aActive, uint aPriority) => GetDelegate<SetCuttingElementDelegate>().Invoke(NativePtr, aActive, aPriority);
  public void SetNotCutWithCuttingElement(bool aActive) => GetDelegate<SetNotCutWithCuttingElementDelegate>().Invoke(NativePtr, aActive);
  public void SetAuxiliary(bool aActive) => GetDelegate<SetAuxiliaryDelegate>().Invoke(NativePtr, aActive);
  public void SetNotPlacedAtEndOfWall(bool aActive) => GetDelegate<SetNotPlacedAtEndOfWallDelegate>().Invoke(NativePtr, aActive);
  public void SetNotPlacedAtStartOfWall(bool aActive) => GetDelegate<SetNotPlacedAtStartOfWallDelegate>().Invoke(NativePtr, aActive);
  public void SetStretchWithOpeningLintel(bool aActive) => GetDelegate<SetStretchWithOpeningLintelDelegate>().Invoke(NativePtr, aActive);
  public void SetStretchWithOpeningSill(bool aActive) => GetDelegate<SetStretchWithOpeningSillDelegate>().Invoke(NativePtr, aActive);
  public void SetSolderInAxisDirection(bool aActive) => GetDelegate<SetSolderInAxisDirectionDelegate>().Invoke(NativePtr, aActive);
  public void SetNoCollisionControl(bool aActive) => GetDelegate<SetNoCollisionControlDelegate>().Invoke(NativePtr, aActive);
  public void SetNoInsideControl(bool aActive) => GetDelegate<SetNoInsideControlDelegate>().Invoke(NativePtr, aActive);
  public void SetUseForDetailCoordinateSystem(bool aActive) => GetDelegate<SetUseForDetailCoordinateSystemDelegate>().Invoke(NativePtr, aActive);
  public double GetDistributeInAxisDirectionDistance() => GetDelegate<GetDistributeInAxisDirectionDistanceDelegate>().Invoke(NativePtr);
  public double GetDistributePerpendicularToAxisDirectionDistance() => GetDelegate<GetDistributePerpendicularToAxisDirectionDistanceDelegate>().Invoke(NativePtr);
  public uint GetCuttingElementPriority() => GetDelegate<GetCuttingElementPriorityDelegate>().Invoke(NativePtr);
  public bool IsDistributeInAxisDirectionUseMaxDistance() => GetDelegate<IsDistributeInAxisDirectionUseMaxDistanceDelegate>().Invoke(NativePtr);
  public bool IsDistributePerpendicularToAxisDirectionUseMaxDistance() => GetDelegate<IsDistributePerpendicularToAxisDirectionUseMaxDistanceDelegate>().Invoke(NativePtr);
  public bool IsDistributeInAxisDirectionUseNumber() => GetDelegate<IsDistributeInAxisDirectionUseNumberDelegate>().Invoke(NativePtr);
  public bool IsDistributePerpendicularToAxisDirectionUseNumber() => GetDelegate<IsDistributePerpendicularToAxisDirectionUseNumberDelegate>().Invoke(NativePtr);
  public void SetDistributeInAxisDirectionUseMaxDistance(bool aActive) => GetDelegate<SetDistributeInAxisDirectionUseMaxDistanceDelegate>().Invoke(NativePtr, aActive);
  public void SetDistributePerpendicularToAxisDirectionUseMaxDistance(bool aActive) => GetDelegate<SetDistributePerpendicularToAxisDirectionUseMaxDistanceDelegate>().Invoke(NativePtr, aActive);
  public void SetDistributeInAxisDirectionUseNumber(bool aActive, uint aNumber) => GetDelegate<SetDistributeInAxisDirectionUseNumberDelegate>().Invoke(NativePtr, aActive, aNumber);
  public void SetDistributePerpendicularToAxisDirectionUseNumber(bool aActive, uint aNumber) => GetDelegate<SetDistributePerpendicularToAxisDirectionUseNumberDelegate>().Invoke(NativePtr, aActive, aNumber);
  public uint GetDistributeInAxisDirectionNumber() => GetDelegate<GetDistributeInAxisDirectionNumberDelegate>().Invoke(NativePtr);
  public uint GetDistributePerpendicularToAxisDirectionNumber() => GetDelegate<GetDistributePerpendicularToAxisDirectionNumberDelegate>().Invoke(NativePtr);
  public bool IsMainElement() => GetDelegate<IsMainElementDelegate>().Invoke(NativePtr);
  public bool IsStretchAccordingThicknessAxis() => GetDelegate<IsStretchAccordingThicknessAxisDelegate>().Invoke(NativePtr);
  public bool IsStretchAccordingLengthAxis() => GetDelegate<IsStretchAccordingLengthAxisDelegate>().Invoke(NativePtr);
  public bool IsMoveAccordingThicknessAxis() => GetDelegate<IsMoveAccordingThicknessAxisDelegate>().Invoke(NativePtr);
  public bool IsMoveAccordingLengthAxis() => GetDelegate<IsMoveAccordingLengthAxisDelegate>().Invoke(NativePtr);
  public bool IsUniqueLayerName() => GetDelegate<IsUniqueLayerNameDelegate>().Invoke(NativePtr);
  public bool IsKeepInCenterOfLayerCurrentWall() => GetDelegate<IsKeepInCenterOfLayerCurrentWallDelegate>().Invoke(NativePtr);
  public bool IsKeepInCenterOfLayerNeighbourWall() => GetDelegate<IsKeepInCenterOfLayerNeighbourWallDelegate>().Invoke(NativePtr);
  public bool IsKeepInCenterOfRoughVolume() => GetDelegate<IsKeepInCenterOfRoughVolumeDelegate>().Invoke(NativePtr);
  public bool IsElementFromDetail() => GetDelegate<IsElementFromDetailDelegate>().Invoke(NativePtr);
  public void SetMainElement(bool aActive) => GetDelegate<SetMainElementDelegate>().Invoke(NativePtr, aActive);
  public void SetStretchAccordingThicknessAxis(bool aActive) => GetDelegate<SetStretchAccordingThicknessAxisDelegate>().Invoke(NativePtr, aActive);
  public void SetStretchAccordingLengthAxis(bool aActive) => GetDelegate<SetStretchAccordingLengthAxisDelegate>().Invoke(NativePtr, aActive);
  public void SetMoveAccordingThicknessAxis(bool aActive) => GetDelegate<SetMoveAccordingThicknessAxisDelegate>().Invoke(NativePtr, aActive);
  public void SetMoveAccordingLengthAxis(bool aActive) => GetDelegate<SetMoveAccordingLengthAxisDelegate>().Invoke(NativePtr, aActive);
  public void SetUniqueLayerName(bool aActive, string aLayerName) => GetDelegate<SetUniqueLayerNameDelegate>().Invoke(NativePtr, aActive, aLayerName);
  public void SetKeepInCenterOfLayerCurrentWall(bool aActive, string aLayerName) => GetDelegate<SetKeepInCenterOfLayerCurrentWallDelegate>().Invoke(NativePtr, aActive, aLayerName);
  public void SetKeepInCenterOfLayerNeighbourWall(bool aActive, string aLayerName) => GetDelegate<SetKeepInCenterOfLayerNeighbourWallDelegate>().Invoke(NativePtr, aActive, aLayerName);
  public void SetKeepInCenterOfRoughVolume(bool aActive) => GetDelegate<SetKeepInCenterOfRoughVolumeDelegate>().Invoke(NativePtr, aActive);
  public void SetElementFromDetail(bool aActive) => GetDelegate<SetElementFromDetailDelegate>().Invoke(NativePtr, aActive);
  public string GetUniqueLayerName() => GetDelegate<GetUniqueLayerNameDelegate>().Invoke(NativePtr);
  public string GetKeepInCenterOfLayerCurrentWall() => GetDelegate<GetKeepInCenterOfLayerCurrentWallDelegate>().Invoke(NativePtr);
  public string GetKeepInCenterOfLayerNeighbourWall() => GetDelegate<GetKeepInCenterOfLayerNeighbourWallDelegate>().Invoke(NativePtr);
  public void SetStretchInOpeningWidth(bool aActive) => GetDelegate<SetStretchInOpeningWidthDelegate>().Invoke(NativePtr, aActive);
  public bool IsStretchInOpeningWidth() => GetDelegate<IsStretchInOpeningWidthDelegate>().Invoke(NativePtr);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class ElementModulePropertiesInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr destroyFunctionPtr;
    internal IntPtr isStretchWithTopOfWallFunctionPtr;
    internal IntPtr isMoveWithTopOfWallFunctionPtr;
    internal IntPtr isDistributeInAxisDirectionFunctionPtr;
    internal IntPtr isDistributePerpendicularToAxisDirectionFunctionPtr;
    internal IntPtr isStopDistributionInAxisDirectionFunctionPtr;
    internal IntPtr isStopDistributionPerpendicularToAxisDirectionFunctionPtr;
    internal IntPtr isBottomPlateFunctionPtr;
    internal IntPtr isTopPlateFunctionPtr;
    internal IntPtr isOpeningSillFunctionPtr;
    internal IntPtr isOpeningLintelFunctionPtr;
    internal IntPtr isCuttingElementFunctionPtr;
    internal IntPtr isNotCutWithCuttingElementFunctionPtr;
    internal IntPtr isAuxiliaryFunctionPtr;
    internal IntPtr isNotPlacedAtEndOfWallFunctionPtr;
    internal IntPtr isNotPlacedAtStartOfWallFunctionPtr;
    internal IntPtr isStretchWithOpeningLintelFunctionPtr;
    internal IntPtr isStretchWithOpeningSillFunctionPtr;
    internal IntPtr isSolderInAxisDirectionFunctionPtr;
    internal IntPtr isNoCollisionControlFunctionPtr;
    internal IntPtr isNoInsideControlFunctionPtr;
    internal IntPtr isUseForDetailCoordinateSystemFunctionPtr;
    internal IntPtr setStretchWithTopOfWallFunctionPtr;
    internal IntPtr setMoveWithTopOfWallFunctionPtr;
    internal IntPtr setDistributeInAxisDirectionFunctionPtr;
    internal IntPtr setDistributePerpendicularToAxisDirectionFunctionPtr;
    internal IntPtr setStopDistributionInAxisDirectionFunctionPtr;
    internal IntPtr setStopDistributionPerpendicularToAxisDirectionFunctionPtr;
    internal IntPtr setBottomPlateFunctionPtr;
    internal IntPtr setTopPlateFunctionPtr;
    internal IntPtr setOpeningSillFunctionPtr;
    internal IntPtr setOpeningLintelFunctionPtr;
    internal IntPtr setCuttingElementFunctionPtr;
    internal IntPtr setNotCutWithCuttingElementFunctionPtr;
    internal IntPtr setAuxiliaryFunctionPtr;
    internal IntPtr setNotPlacedAtEndOfWallFunctionPtr;
    internal IntPtr setNotPlacedAtStartOfWallFunctionPtr;
    internal IntPtr setStretchWithOpeningLintelFunctionPtr;
    internal IntPtr setStretchWithOpeningSillFunctionPtr;
    internal IntPtr setSolderInAxisDirectionFunctionPtr;
    internal IntPtr setNoCollisionControlFunctionPtr;
    internal IntPtr setNoInsideControlFunctionPtr;
    internal IntPtr setUseForDetailCoordinateSystemFunctionPtr;
    internal IntPtr getDistributeInAxisDirectionDistanceFunctionPtr;
    internal IntPtr getDistributePerpendicularToAxisDirectionDistanceFunctionPtr;
    internal IntPtr getCuttingElementPriorityFunctionPtr;
    internal IntPtr isDistributeInAxisDirectionUseMaxDistanceFunctionPtr;
    internal IntPtr isDistributePerpendicularToAxisDirectionUseMaxDistanceFunctionPtr;
    internal IntPtr isDistributeInAxisDirectionUseNumberFunctionPtr;
    internal IntPtr isDistributePerpendicularToAxisDirectionUseNumberFunctionPtr;
    internal IntPtr setDistributeInAxisDirectionUseMaxDistanceFunctionPtr;
    internal IntPtr setDistributePerpendicularToAxisDirectionUseMaxDistanceFunctionPtr;
    internal IntPtr setDistributeInAxisDirectionUseNumberFunctionPtr;
    internal IntPtr setDistributePerpendicularToAxisDirectionUseNumberFunctionPtr;
    internal IntPtr getDistributeInAxisDirectionNumberFunctionPtr;
    internal IntPtr getDistributePerpendicularToAxisDirectionNumberFunctionPtr;
    internal IntPtr isMainElementFunctionPtr;
    internal IntPtr isStretchAccordingThicknessAxisFunctionPtr;
    internal IntPtr isStretchAccordingLengthAxisFunctionPtr;
    internal IntPtr isMoveAccordingThicknessAxisFunctionPtr;
    internal IntPtr isMoveAccordingLengthAxisFunctionPtr;
    internal IntPtr isUniqueLayerNameFunctionPtr;
    internal IntPtr isKeepInCenterOfLayerCurrentWallFunctionPtr;
    internal IntPtr isKeepInCenterOfLayerNeighbourWallFunctionPtr;
    internal IntPtr isKeepInCenterOfRoughVolumeFunctionPtr;
    internal IntPtr isElementFromDetailFunctionPtr;
    internal IntPtr setMainElementFunctionPtr;
    internal IntPtr setStretchAccordingThicknessAxisFunctionPtr;
    internal IntPtr setStretchAccordingLengthAxisFunctionPtr;
    internal IntPtr setMoveAccordingThicknessAxisFunctionPtr;
    internal IntPtr setMoveAccordingLengthAxisFunctionPtr;
    internal IntPtr setUniqueLayerNameFunctionPtr;
    internal IntPtr setKeepInCenterOfLayerCurrentWallFunctionPtr;
    internal IntPtr setKeepInCenterOfLayerNeighbourWallFunctionPtr;
    internal IntPtr setKeepInCenterOfRoughVolumeFunctionPtr;
    internal IntPtr setElementFromDetailFunctionPtr;
    internal IntPtr getUniqueLayerNameFunctionPtr;
    internal IntPtr getKeepInCenterOfLayerCurrentWallFunctionPtr;
    internal IntPtr getKeepInCenterOfLayerNeighbourWallFunctionPtr;
    internal IntPtr setStretchInOpeningWidthFunctionPtr;
    internal IntPtr isStretchInOpeningWidthFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DestroyDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsStretchWithTopOfWallDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsMoveWithTopOfWallDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsDistributeInAxisDirectionDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsDistributePerpendicularToAxisDirectionDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsStopDistributionInAxisDirectionDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsStopDistributionPerpendicularToAxisDirectionDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsBottomPlateDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsTopPlateDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsOpeningSillDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsOpeningLintelDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsCuttingElementDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsNotCutWithCuttingElementDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsAuxiliaryDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsNotPlacedAtEndOfWallDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsNotPlacedAtStartOfWallDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsStretchWithOpeningLintelDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsStretchWithOpeningSillDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsSolderInAxisDirectionDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsNoCollisionControlDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsNoInsideControlDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsUseForDetailCoordinateSystemDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetStretchWithTopOfWallDelegate(IntPtr thisPtr, bool aActive);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetMoveWithTopOfWallDelegate(IntPtr thisPtr, bool aActive);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetDistributeInAxisDirectionDelegate(IntPtr thisPtr, bool aActive, double aDistance);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetDistributePerpendicularToAxisDirectionDelegate(IntPtr thisPtr, bool aActive, double aDistance);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetStopDistributionInAxisDirectionDelegate(IntPtr thisPtr, bool aActive);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetStopDistributionPerpendicularToAxisDirectionDelegate(IntPtr thisPtr, bool aActive);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetBottomPlateDelegate(IntPtr thisPtr, bool aActive);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetTopPlateDelegate(IntPtr thisPtr, bool aActive);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetOpeningSillDelegate(IntPtr thisPtr, bool aActive);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetOpeningLintelDelegate(IntPtr thisPtr, bool aActive);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCuttingElementDelegate(IntPtr thisPtr, bool aActive, uint aPriority);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetNotCutWithCuttingElementDelegate(IntPtr thisPtr, bool aActive);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetAuxiliaryDelegate(IntPtr thisPtr, bool aActive);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetNotPlacedAtEndOfWallDelegate(IntPtr thisPtr, bool aActive);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetNotPlacedAtStartOfWallDelegate(IntPtr thisPtr, bool aActive);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetStretchWithOpeningLintelDelegate(IntPtr thisPtr, bool aActive);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetStretchWithOpeningSillDelegate(IntPtr thisPtr, bool aActive);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetSolderInAxisDirectionDelegate(IntPtr thisPtr, bool aActive);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetNoCollisionControlDelegate(IntPtr thisPtr, bool aActive);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetNoInsideControlDelegate(IntPtr thisPtr, bool aActive);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetUseForDetailCoordinateSystemDelegate(IntPtr thisPtr, bool aActive);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetDistributeInAxisDirectionDistanceDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetDistributePerpendicularToAxisDirectionDistanceDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate uint GetCuttingElementPriorityDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsDistributeInAxisDirectionUseMaxDistanceDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsDistributePerpendicularToAxisDirectionUseMaxDistanceDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsDistributeInAxisDirectionUseNumberDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsDistributePerpendicularToAxisDirectionUseNumberDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetDistributeInAxisDirectionUseMaxDistanceDelegate(IntPtr thisPtr, bool aActive);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetDistributePerpendicularToAxisDirectionUseMaxDistanceDelegate(IntPtr thisPtr, bool aActive);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetDistributeInAxisDirectionUseNumberDelegate(IntPtr thisPtr, bool aActive, uint aNumber);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetDistributePerpendicularToAxisDirectionUseNumberDelegate(IntPtr thisPtr, bool aActive, uint aNumber);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate uint GetDistributeInAxisDirectionNumberDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate uint GetDistributePerpendicularToAxisDirectionNumberDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsMainElementDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsStretchAccordingThicknessAxisDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsStretchAccordingLengthAxisDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsMoveAccordingThicknessAxisDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsMoveAccordingLengthAxisDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsUniqueLayerNameDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsKeepInCenterOfLayerCurrentWallDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsKeepInCenterOfLayerNeighbourWallDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsKeepInCenterOfRoughVolumeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsElementFromDetailDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetMainElementDelegate(IntPtr thisPtr, bool aActive);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetStretchAccordingThicknessAxisDelegate(IntPtr thisPtr, bool aActive);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetStretchAccordingLengthAxisDelegate(IntPtr thisPtr, bool aActive);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetMoveAccordingThicknessAxisDelegate(IntPtr thisPtr, bool aActive);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetMoveAccordingLengthAxisDelegate(IntPtr thisPtr, bool aActive);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetUniqueLayerNameDelegate(IntPtr thisPtr, bool aActive, [MarshalAs(UnmanagedType.LPWStr)] string aLayerName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetKeepInCenterOfLayerCurrentWallDelegate(IntPtr thisPtr, bool aActive, [MarshalAs(UnmanagedType.LPWStr)] string aLayerName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetKeepInCenterOfLayerNeighbourWallDelegate(IntPtr thisPtr, bool aActive, [MarshalAs(UnmanagedType.LPWStr)] string aLayerName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetKeepInCenterOfRoughVolumeDelegate(IntPtr thisPtr, bool aActive);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetElementFromDetailDelegate(IntPtr thisPtr, bool aActive);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate string GetUniqueLayerNameDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate string GetKeepInCenterOfLayerCurrentWallDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate string GetKeepInCenterOfLayerNeighbourWallDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetStretchInOpeningWidthDelegate(IntPtr thisPtr, bool aActive);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsStretchInOpeningWidthDelegate(IntPtr thisPtr);
}
