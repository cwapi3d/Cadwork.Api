// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;
using Cadwork.Api.Interop.Wrappers.Structs;

namespace Cadwork.Api.Interop.Wrappers.Controllers;

public class GeometryControllerWrapper
{
  private readonly IntPtr _nativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public GeometryControllerWrapper(IntPtr nativePtr)
  {
    _nativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<GeometryControllerInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(GetLastErrorDelegate), Marshal.GetDelegateForFunctionPointer<GetLastErrorDelegate>(vTable!.getLastErrorFunctionPtr) },
      { typeof(GetWidthDelegate), Marshal.GetDelegateForFunctionPointer<GetWidthDelegate>(vTable.getWidthFunctionPtr) },
      { typeof(GetHeightDelegate), Marshal.GetDelegateForFunctionPointer<GetHeightDelegate>(vTable.getHeightFunctionPtr) },
      { typeof(GetLengthDelegate), Marshal.GetDelegateForFunctionPointer<GetLengthDelegate>(vTable.getLengthFunctionPtr) },
      { typeof(GetP1Delegate), Marshal.GetDelegateForFunctionPointer<GetP1Delegate>(vTable.getP1FunctionPtr) },
      { typeof(GetP2Delegate), Marshal.GetDelegateForFunctionPointer<GetP2Delegate>(vTable.getP2FunctionPtr) },
      { typeof(GetP3Delegate), Marshal.GetDelegateForFunctionPointer<GetP3Delegate>(vTable.getP3FunctionPtr) },
      { typeof(GetStartHeightCutAngleDelegate), Marshal.GetDelegateForFunctionPointer<GetStartHeightCutAngleDelegate>(vTable.getStartHeightCutAngleFunctionPtr) },
      { typeof(GetStartWidthCutAngleDelegate), Marshal.GetDelegateForFunctionPointer<GetStartWidthCutAngleDelegate>(vTable.getStartWidthCutAngleFunctionPtr) },
      { typeof(GetEndHeightCutAngleDelegate), Marshal.GetDelegateForFunctionPointer<GetEndHeightCutAngleDelegate>(vTable.getEndHeightCutAngleFunctionPtr) },
      { typeof(GetEndWidthCutAngleDelegate), Marshal.GetDelegateForFunctionPointer<GetEndWidthCutAngleDelegate>(vTable.getEndWidthCutAngleFunctionPtr) },
      { typeof(RotateHeightAxis90Delegate), Marshal.GetDelegateForFunctionPointer<RotateHeightAxis90Delegate>(vTable.rotateHeightAxis90FunctionPtr) },
      { typeof(RotateHeightAxis180Delegate), Marshal.GetDelegateForFunctionPointer<RotateHeightAxis180Delegate>(vTable.rotateHeightAxis180FunctionPtr) },
      { typeof(GetOverWidthDelegate), Marshal.GetDelegateForFunctionPointer<GetOverWidthDelegate>(vTable.getOverWidthFunctionPtr) },
      { typeof(SetOverWidthDelegate), Marshal.GetDelegateForFunctionPointer<SetOverWidthDelegate>(vTable.setOverWidthFunctionPtr) },
      { typeof(GetOverHeightDelegate), Marshal.GetDelegateForFunctionPointer<GetOverHeightDelegate>(vTable.getOverHeightFunctionPtr) },
      { typeof(SetOverHeightDelegate), Marshal.GetDelegateForFunctionPointer<SetOverHeightDelegate>(vTable.setOverHeightFunctionPtr) },
      { typeof(GetOverLengthDelegate), Marshal.GetDelegateForFunctionPointer<GetOverLengthDelegate>(vTable.getOverLengthFunctionPtr) },
      { typeof(SetOverLengthDelegate), Marshal.GetDelegateForFunctionPointer<SetOverLengthDelegate>(vTable.setOverLengthFunctionPtr) },
      { typeof(GetRoundingWidthDelegate), Marshal.GetDelegateForFunctionPointer<GetRoundingWidthDelegate>(vTable.getRoundingWidthFunctionPtr) },
      { typeof(SetRoundingWidthDelegate), Marshal.GetDelegateForFunctionPointer<SetRoundingWidthDelegate>(vTable.setRoundingWidthFunctionPtr) },
      { typeof(GetRoundingHeightDelegate), Marshal.GetDelegateForFunctionPointer<GetRoundingHeightDelegate>(vTable.getRoundingHeightFunctionPtr) },
      { typeof(SetRoundingHeightDelegate), Marshal.GetDelegateForFunctionPointer<SetRoundingHeightDelegate>(vTable.setRoundingHeightFunctionPtr) },
      { typeof(GetRoundingLengthDelegate), Marshal.GetDelegateForFunctionPointer<GetRoundingLengthDelegate>(vTable.getRoundingLengthFunctionPtr) },
      { typeof(SetRoundingLengthDelegate), Marshal.GetDelegateForFunctionPointer<SetRoundingLengthDelegate>(vTable.setRoundingLengthFunctionPtr) },
      { typeof(GetCrossCorrectionNegativeWidthDelegate), Marshal.GetDelegateForFunctionPointer<GetCrossCorrectionNegativeWidthDelegate>(vTable.getCrossCorrectionNegativeWidthFunctionPtr) },
      { typeof(SetCrossCorrectionNegativeWidthDelegate), Marshal.GetDelegateForFunctionPointer<SetCrossCorrectionNegativeWidthDelegate>(vTable.setCrossCorrectionNegativeWidthFunctionPtr) },
      { typeof(GetCrossCorrectionPositiveWidthDelegate), Marshal.GetDelegateForFunctionPointer<GetCrossCorrectionPositiveWidthDelegate>(vTable.getCrossCorrectionPositiveWidthFunctionPtr) },
      { typeof(SetCrossCorrectionPositiveWidthDelegate), Marshal.GetDelegateForFunctionPointer<SetCrossCorrectionPositiveWidthDelegate>(vTable.setCrossCorrectionPositiveWidthFunctionPtr) },
      { typeof(GetCrossCorrectionNegativeHeightDelegate), Marshal.GetDelegateForFunctionPointer<GetCrossCorrectionNegativeHeightDelegate>(vTable.getCrossCorrectionNegativeHeightFunctionPtr) },
      { typeof(SetCrossCorrectionNegativeHeightDelegate), Marshal.GetDelegateForFunctionPointer<SetCrossCorrectionNegativeHeightDelegate>(vTable.setCrossCorrectionNegativeHeightFunctionPtr) },
      { typeof(GetCrossCorrectionPositiveHeightDelegate), Marshal.GetDelegateForFunctionPointer<GetCrossCorrectionPositiveHeightDelegate>(vTable.getCrossCorrectionPositiveHeightFunctionPtr) },
      { typeof(SetCrossCorrectionPositiveHeightDelegate), Marshal.GetDelegateForFunctionPointer<SetCrossCorrectionPositiveHeightDelegate>(vTable.setCrossCorrectionPositiveHeightFunctionPtr) },
      { typeof(GetCrossCorrectionNegativeLengthDelegate), Marshal.GetDelegateForFunctionPointer<GetCrossCorrectionNegativeLengthDelegate>(vTable.getCrossCorrectionNegativeLengthFunctionPtr) },
      { typeof(SetCrossCorrectionNegativeLengthDelegate), Marshal.GetDelegateForFunctionPointer<SetCrossCorrectionNegativeLengthDelegate>(vTable.setCrossCorrectionNegativeLengthFunctionPtr) },
      { typeof(GetCrossCorrectionPositiveLengthDelegate), Marshal.GetDelegateForFunctionPointer<GetCrossCorrectionPositiveLengthDelegate>(vTable.getCrossCorrectionPositiveLengthFunctionPtr) },
      { typeof(SetCrossCorrectionPositiveLengthDelegate), Marshal.GetDelegateForFunctionPointer<SetCrossCorrectionPositiveLengthDelegate>(vTable.setCrossCorrectionPositiveLengthFunctionPtr) },
      { typeof(GetWeightDelegate), Marshal.GetDelegateForFunctionPointer<GetWeightDelegate>(vTable.getWeightFunctionPtr) },
      { typeof(GetListWeightDelegate), Marshal.GetDelegateForFunctionPointer<GetListWeightDelegate>(vTable.getListWeightFunctionPtr) },
      { typeof(GetVolumeDelegate), Marshal.GetDelegateForFunctionPointer<GetVolumeDelegate>(vTable.getVolumeFunctionPtr) },
      { typeof(GetListVolumeDelegate), Marshal.GetDelegateForFunctionPointer<GetListVolumeDelegate>(vTable.getListVolumeFunctionPtr) },
      { typeof(GetXlDelegate), Marshal.GetDelegateForFunctionPointer<GetXlDelegate>(vTable.getXLFunctionPtr) },
      { typeof(GetYlDelegate), Marshal.GetDelegateForFunctionPointer<GetYlDelegate>(vTable.getYLFunctionPtr) },
      { typeof(GetZlDelegate), Marshal.GetDelegateForFunctionPointer<GetZlDelegate>(vTable.getZLFunctionPtr) },
      { typeof(GetCenterOfGravityDelegate), Marshal.GetDelegateForFunctionPointer<GetCenterOfGravityDelegate>(vTable.getCenterOfGravityFunctionPtr) },
      { typeof(GetReferenceSideDelegate), Marshal.GetDelegateForFunctionPointer<GetReferenceSideDelegate>(vTable.getReferenceSideFunctionPtr) },
      { typeof(GetElementVerticesDelegate), Marshal.GetDelegateForFunctionPointer<GetElementVerticesDelegate>(vTable.getElementVerticesFunctionPtr) },
      { typeof(ApplyGlobalScaleDelegate), Marshal.GetDelegateForFunctionPointer<ApplyGlobalScaleDelegate>(vTable.applyGlobalScaleFunctionPtr) },
      { typeof(AutoRegenerateAxesDelegate), Marshal.GetDelegateForFunctionPointer<AutoRegenerateAxesDelegate>(vTable.autoRegenerateAxesFunctionPtr) },
      { typeof(RotateLengthAxis90Delegate), Marshal.GetDelegateForFunctionPointer<RotateLengthAxis90Delegate>(vTable.rotateLengthAxis90FunctionPtr) },
      { typeof(RotateLengthAxis180Delegate), Marshal.GetDelegateForFunctionPointer<RotateLengthAxis180Delegate>(vTable.rotateLengthAxis180FunctionPtr) },
      { typeof(InvertModelDelegate), Marshal.GetDelegateForFunctionPointer<InvertModelDelegate>(vTable.invertModelFunctionPtr) },
      { typeof(GetElementFacetsDelegate), Marshal.GetDelegateForFunctionPointer<GetElementFacetsDelegate>(vTable.getElementFacetsFunctionPtr) },
      { typeof(GetListWidthDelegate), Marshal.GetDelegateForFunctionPointer<GetListWidthDelegate>(vTable.getListWidthFunctionPtr) },
      { typeof(GetListHeightDelegate), Marshal.GetDelegateForFunctionPointer<GetListHeightDelegate>(vTable.getListHeightFunctionPtr) },
      { typeof(GetListLengthDelegate), Marshal.GetDelegateForFunctionPointer<GetListLengthDelegate>(vTable.getListLengthFunctionPtr) },
      { typeof(SetWidthRealDelegate), Marshal.GetDelegateForFunctionPointer<SetWidthRealDelegate>(vTable.setWidthRealFunctionPtr) },
      { typeof(SetHeightRealDelegate), Marshal.GetDelegateForFunctionPointer<SetHeightRealDelegate>(vTable.setHeightRealFunctionPtr) },
      { typeof(SetLengthRealDelegate), Marshal.GetDelegateForFunctionPointer<SetLengthRealDelegate>(vTable.setLengthRealFunctionPtr) },
      { typeof(RotateHeightAxis2PointsDelegate), Marshal.GetDelegateForFunctionPointer<RotateHeightAxis2PointsDelegate>(vTable.rotateHeightAxis2PointsFunctionPtr) },
      { typeof(GetMinimumDistanceBetweenElementsDelegate), Marshal.GetDelegateForFunctionPointer<GetMinimumDistanceBetweenElementsDelegate>(vTable.getMinimumDistanceBetweenElementsFunctionPtr) },
      { typeof(GetTotalAreaOfAllFacesDelegate), Marshal.GetDelegateForFunctionPointer<GetTotalAreaOfAllFacesDelegate>(vTable.getTotalAreaOfAllFacesFunctionPtr) },
      { typeof(GetAreaOfFrontFaceDelegate), Marshal.GetDelegateForFunctionPointer<GetAreaOfFrontFaceDelegate>(vTable.getAreaOfFrontFaceFunctionPtr) },
      { typeof(GetDoorSurfaceDelegate), Marshal.GetDelegateForFunctionPointer<GetDoorSurfaceDelegate>(vTable.getDoorSurfaceFunctionPtr) },
      { typeof(GetWindowSurfaceDelegate), Marshal.GetDelegateForFunctionPointer<GetWindowSurfaceDelegate>(vTable.getWindowSurfaceFunctionPtr) },
      { typeof(CreateDivisionZoneDelegate), Marshal.GetDelegateForFunctionPointer<CreateDivisionZoneDelegate>(vTable.createDivisionZoneFunctionPtr) },
      { typeof(DeleteDivisionZoneDelegate), Marshal.GetDelegateForFunctionPointer<DeleteDivisionZoneDelegate>(vTable.deleteDivisionZoneFunctionPtr) },
      { typeof(GetDivisionZonePointsDelegate), Marshal.GetDelegateForFunctionPointer<GetDivisionZonePointsDelegate>(vTable.getDivisionZonePointsFunctionPtr) },
      { typeof(GetLocalXDelegate), Marshal.GetDelegateForFunctionPointer<GetLocalXDelegate>(vTable.getLocalXFunctionPtr) },
      { typeof(GetLocalZDelegate), Marshal.GetDelegateForFunctionPointer<GetLocalZDelegate>(vTable.getLocalZFunctionPtr) },
      { typeof(GetLocalYDelegate), Marshal.GetDelegateForFunctionPointer<GetLocalYDelegate>(vTable.getLocalYFunctionPtr) },
      { typeof(ClearErrorsDelegate), Marshal.GetDelegateForFunctionPointer<ClearErrorsDelegate>(vTable.clearErrorsFunctionPtr) },
      { typeof(SetDrillingToleranceDelegate), Marshal.GetDelegateForFunctionPointer<SetDrillingToleranceDelegate>(vTable.setDrillingToleranceFunctionPtr) },
      { typeof(GetDrillingToleranceDelegate), Marshal.GetDelegateForFunctionPointer<GetDrillingToleranceDelegate>(vTable.getDrillingToleranceFunctionPtr) },
      { typeof(GetElementReferenceFaceVerticesDelegate), Marshal.GetDelegateForFunctionPointer<GetElementReferenceFaceVerticesDelegate>(vTable.getElementReferenceFaceVerticesFunctionPtr) },
      { typeof(GetElementReferenceFaceAreaDelegate), Marshal.GetDelegateForFunctionPointer<GetElementReferenceFaceAreaDelegate>(vTable.getElementReferenceFaceAreaFunctionPtr) },
      { typeof(AutoRegenerateAxesSilentlyDelegate), Marshal.GetDelegateForFunctionPointer<AutoRegenerateAxesSilentlyDelegate>(vTable.autoRegenerateAxesSilentlyFunctionPtr) },
      { typeof(RotateLengthAxis2PointsDelegate), Marshal.GetDelegateForFunctionPointer<RotateLengthAxis2PointsDelegate>(vTable.rotateLengthAxis2PointsFunctionPtr) },
      { typeof(GetCenterOfGravityForListDelegate), Marshal.GetDelegateForFunctionPointer<GetCenterOfGravityForListDelegate>(vTable.getCenterOfGravityForListFunctionPtr) },
      { typeof(GetCenterOfGravityForListConsideringMaterialsDelegate), Marshal.GetDelegateForFunctionPointer<GetCenterOfGravityForListConsideringMaterialsDelegate>(vTable.getCenterOfGravityForListConsideringMaterialsFunctionPtr) },
      { typeof(GetElementFacetCountDelegate), Marshal.GetDelegateForFunctionPointer<GetElementFacetCountDelegate>(vTable.getElementFacetCountFunctionPtr) },
      { typeof(GetWeightRealDelegate), Marshal.GetDelegateForFunctionPointer<GetWeightRealDelegate>(vTable.getWeightRealFunctionPtr) },
      { typeof(GetActualPhysicalVolumeDelegate), Marshal.GetDelegateForFunctionPointer<GetActualPhysicalVolumeDelegate>(vTable.getActualPhysicalVolumeFunctionPtr) },
      { typeof(AreFacetsCoplanarDelegate), Marshal.GetDelegateForFunctionPointer<AreFacetsCoplanarDelegate>(vTable.areFacetsCoplanarFunctionPtr) },
      { typeof(GetRoundMachineRoughPartNegativeWidthDelegate), Marshal.GetDelegateForFunctionPointer<GetRoundMachineRoughPartNegativeWidthDelegate>(vTable.getRoundMachineRoughPartNegativeWidthFunctionPtr) },
      { typeof(SetRoundMachineRoughPartNegativeWidthDelegate), Marshal.GetDelegateForFunctionPointer<SetRoundMachineRoughPartNegativeWidthDelegate>(vTable.setRoundMachineRoughPartNegativeWidthFunctionPtr) },
      { typeof(GetRoundMachineRoughPartPositiveWidthDelegate), Marshal.GetDelegateForFunctionPointer<GetRoundMachineRoughPartPositiveWidthDelegate>(vTable.getRoundMachineRoughPartPositiveWidthFunctionPtr) },
      { typeof(SetRoundMachineRoughPartPositiveWidthDelegate), Marshal.GetDelegateForFunctionPointer<SetRoundMachineRoughPartPositiveWidthDelegate>(vTable.setRoundMachineRoughPartPositiveWidthFunctionPtr) },
      { typeof(GetRoundMachineRoughPartNegativeHeightDelegate), Marshal.GetDelegateForFunctionPointer<GetRoundMachineRoughPartNegativeHeightDelegate>(vTable.getRoundMachineRoughPartNegativeHeightFunctionPtr) },
      { typeof(SetRoundMachineRoughPartNegativeHeightDelegate), Marshal.GetDelegateForFunctionPointer<SetRoundMachineRoughPartNegativeHeightDelegate>(vTable.setRoundMachineRoughPartNegativeHeightFunctionPtr) },
      { typeof(GetRoundMachineRoughPartPositiveHeightDelegate), Marshal.GetDelegateForFunctionPointer<GetRoundMachineRoughPartPositiveHeightDelegate>(vTable.getRoundMachineRoughPartPositiveHeightFunctionPtr) },
      { typeof(SetRoundMachineRoughPartPositiveHeightDelegate), Marshal.GetDelegateForFunctionPointer<SetRoundMachineRoughPartPositiveHeightDelegate>(vTable.setRoundMachineRoughPartPositiveHeightFunctionPtr) },
      { typeof(GetRoundMachineRoughPartNegativeLengthDelegate), Marshal.GetDelegateForFunctionPointer<GetRoundMachineRoughPartNegativeLengthDelegate>(vTable.getRoundMachineRoughPartNegativeLengthFunctionPtr) },
      { typeof(SetRoundMachineRoughPartNegativeLengthDelegate), Marshal.GetDelegateForFunctionPointer<SetRoundMachineRoughPartNegativeLengthDelegate>(vTable.setRoundMachineRoughPartNegativeLengthFunctionPtr) },
      { typeof(GetRoundMachineRoughPartPositiveLengthDelegate), Marshal.GetDelegateForFunctionPointer<GetRoundMachineRoughPartPositiveLengthDelegate>(vTable.getRoundMachineRoughPartPositiveLengthFunctionPtr) },
      { typeof(SetRoundMachineRoughPartPositiveLengthDelegate), Marshal.GetDelegateForFunctionPointer<SetRoundMachineRoughPartPositiveLengthDelegate>(vTable.setRoundMachineRoughPartPositiveLengthFunctionPtr) },
      { typeof(GetStandardElementWidthFromGuidDelegate), Marshal.GetDelegateForFunctionPointer<GetStandardElementWidthFromGuidDelegate>(vTable.getStandardElementWidthFromGuidFunctionPtr) },
      { typeof(GetStandardElementHeightFromGuidDelegate), Marshal.GetDelegateForFunctionPointer<GetStandardElementHeightFromGuidDelegate>(vTable.getStandardElementHeightFromGuidFunctionPtr) },
      { typeof(GetStandardElementLengthFromGuidDelegate), Marshal.GetDelegateForFunctionPointer<GetStandardElementLengthFromGuidDelegate>(vTable.getStandardElementLengthFromGuidFunctionPtr) },
      { typeof(GetStandardElementWidthFromNameDelegate), Marshal.GetDelegateForFunctionPointer<GetStandardElementWidthFromNameDelegate>(vTable.getStandardElementWidthFromNameFunctionPtr) },
      { typeof(GetStandardElementHeightFromNameDelegate), Marshal.GetDelegateForFunctionPointer<GetStandardElementHeightFromNameDelegate>(vTable.getStandardElementHeightFromNameFunctionPtr) },
      { typeof(GetStandardElementLengthFromNameDelegate), Marshal.GetDelegateForFunctionPointer<GetStandardElementLengthFromNameDelegate>(vTable.getStandardElementLengthFromNameFunctionPtr) },
    };
  }

  public enum DivisionZoneDirection
  {
    Positive = 1,
    Negative = -1,
    None = 0
  };

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public IntPtr GetLastError(IntPtr aErrorCode) => GetDelegate<GetLastErrorDelegate>().Invoke(_nativePtr, aErrorCode);
  public double GetWidth(ulong aId) => GetDelegate<GetWidthDelegate>().Invoke(_nativePtr, aId);
  public double GetHeight(ulong aId) => GetDelegate<GetHeightDelegate>().Invoke(_nativePtr, aId);
  public double GetLength(ulong aId) => GetDelegate<GetLengthDelegate>().Invoke(_nativePtr, aId);
  public CVector3 GetP1(ulong aId) => GetDelegate<GetP1Delegate>().Invoke(_nativePtr, aId);
  public CVector3 GetP2(ulong aId) => GetDelegate<GetP2Delegate>().Invoke(_nativePtr, aId);
  public CVector3 GetP3(ulong aId) => GetDelegate<GetP3Delegate>().Invoke(_nativePtr, aId);
  public double GetStartHeightCutAngle(ulong aId) => GetDelegate<GetStartHeightCutAngleDelegate>().Invoke(_nativePtr, aId);
  public double GetStartWidthCutAngle(ulong aId) => GetDelegate<GetStartWidthCutAngleDelegate>().Invoke(_nativePtr, aId);
  public double GetEndHeightCutAngle(ulong aId) => GetDelegate<GetEndHeightCutAngleDelegate>().Invoke(_nativePtr, aId);
  public double GetEndWidthCutAngle(ulong aId) => GetDelegate<GetEndWidthCutAngleDelegate>().Invoke(_nativePtr, aId);
  public void RotateHeightAxis90(IntPtr aElementIdList) => GetDelegate<RotateHeightAxis90Delegate>().Invoke(_nativePtr, aElementIdList);
  public void RotateHeightAxis180(IntPtr aElementIdList) => GetDelegate<RotateHeightAxis180Delegate>().Invoke(_nativePtr, aElementIdList);
  public double GetOverWidth(ulong aId) => GetDelegate<GetOverWidthDelegate>().Invoke(_nativePtr, aId);
  public void SetOverWidth(IntPtr aElementIdList, double aValue) => GetDelegate<SetOverWidthDelegate>().Invoke(_nativePtr, aElementIdList, aValue);
  public double GetOverHeight(ulong aId) => GetDelegate<GetOverHeightDelegate>().Invoke(_nativePtr, aId);
  public void SetOverHeight(IntPtr aElementIdList, double aValue) => GetDelegate<SetOverHeightDelegate>().Invoke(_nativePtr, aElementIdList, aValue);
  public double GetOverLength(ulong aId) => GetDelegate<GetOverLengthDelegate>().Invoke(_nativePtr, aId);
  public void SetOverLength(IntPtr aElementIdList, double aValue) => GetDelegate<SetOverLengthDelegate>().Invoke(_nativePtr, aElementIdList, aValue);
  public double GetRoundingWidth(ulong aId) => GetDelegate<GetRoundingWidthDelegate>().Invoke(_nativePtr, aId);
  public void SetRoundingWidth(IntPtr aElementIdList, double aValue) => GetDelegate<SetRoundingWidthDelegate>().Invoke(_nativePtr, aElementIdList, aValue);
  public double GetRoundingHeight(ulong aId) => GetDelegate<GetRoundingHeightDelegate>().Invoke(_nativePtr, aId);
  public void SetRoundingHeight(IntPtr aElementIdList, double aValue) => GetDelegate<SetRoundingHeightDelegate>().Invoke(_nativePtr, aElementIdList, aValue);
  public double GetRoundingLength(ulong aId) => GetDelegate<GetRoundingLengthDelegate>().Invoke(_nativePtr, aId);
  public void SetRoundingLength(IntPtr aElementIdList, double aValue) => GetDelegate<SetRoundingLengthDelegate>().Invoke(_nativePtr, aElementIdList, aValue);
  public double GetCrossCorrectionNegativeWidth(ulong aId) => GetDelegate<GetCrossCorrectionNegativeWidthDelegate>().Invoke(_nativePtr, aId);
  public void SetCrossCorrectionNegativeWidth(IntPtr aElementIdList, double aValue) => GetDelegate<SetCrossCorrectionNegativeWidthDelegate>().Invoke(_nativePtr, aElementIdList, aValue);
  public double GetCrossCorrectionPositiveWidth(ulong aId) => GetDelegate<GetCrossCorrectionPositiveWidthDelegate>().Invoke(_nativePtr, aId);
  public void SetCrossCorrectionPositiveWidth(IntPtr aElementIdList, double aValue) => GetDelegate<SetCrossCorrectionPositiveWidthDelegate>().Invoke(_nativePtr, aElementIdList, aValue);
  public double GetCrossCorrectionNegativeHeight(ulong aId) => GetDelegate<GetCrossCorrectionNegativeHeightDelegate>().Invoke(_nativePtr, aId);
  public void SetCrossCorrectionNegativeHeight(IntPtr aElementIdList, double aValue) => GetDelegate<SetCrossCorrectionNegativeHeightDelegate>().Invoke(_nativePtr, aElementIdList, aValue);
  public double GetCrossCorrectionPositiveHeight(ulong aId) => GetDelegate<GetCrossCorrectionPositiveHeightDelegate>().Invoke(_nativePtr, aId);
  public void SetCrossCorrectionPositiveHeight(IntPtr aElementIdList, double aValue) => GetDelegate<SetCrossCorrectionPositiveHeightDelegate>().Invoke(_nativePtr, aElementIdList, aValue);
  public double GetCrossCorrectionNegativeLength(ulong aId) => GetDelegate<GetCrossCorrectionNegativeLengthDelegate>().Invoke(_nativePtr, aId);
  public void SetCrossCorrectionNegativeLength(IntPtr aElementIdList, double aValue) => GetDelegate<SetCrossCorrectionNegativeLengthDelegate>().Invoke(_nativePtr, aElementIdList, aValue);
  public double GetCrossCorrectionPositiveLength(ulong aId) => GetDelegate<GetCrossCorrectionPositiveLengthDelegate>().Invoke(_nativePtr, aId);
  public void SetCrossCorrectionPositiveLength(IntPtr aElementIdList, double aValue) => GetDelegate<SetCrossCorrectionPositiveLengthDelegate>().Invoke(_nativePtr, aElementIdList, aValue);
  public double GetWeight(ulong aId) => GetDelegate<GetWeightDelegate>().Invoke(_nativePtr, aId);
  public double GetListWeight(ulong aId) => GetDelegate<GetListWeightDelegate>().Invoke(_nativePtr, aId);
  public double GetVolume(ulong aId) => GetDelegate<GetVolumeDelegate>().Invoke(_nativePtr, aId);
  public double GetListVolume(ulong aId) => GetDelegate<GetListVolumeDelegate>().Invoke(_nativePtr, aId);
  public CVector3 GetXl(ulong aId) => GetDelegate<GetXlDelegate>().Invoke(_nativePtr, aId);
  public CVector3 GetYl(ulong aId) => GetDelegate<GetYlDelegate>().Invoke(_nativePtr, aId);
  public CVector3 GetZl(ulong aId) => GetDelegate<GetZlDelegate>().Invoke(_nativePtr, aId);
  public CVector3 GetCenterOfGravity(ulong aId) => GetDelegate<GetCenterOfGravityDelegate>().Invoke(_nativePtr, aId);
  public uint GetReferenceSide(ulong aId) => GetDelegate<GetReferenceSideDelegate>().Invoke(_nativePtr, aId);
  public IntPtr GetElementVertices(ulong aId) => GetDelegate<GetElementVerticesDelegate>().Invoke(_nativePtr, aId);
  public void ApplyGlobalScale(IntPtr aElementIdList, double aScale, CVector3 aOrigin) => GetDelegate<ApplyGlobalScaleDelegate>().Invoke(_nativePtr, aElementIdList, aScale, aOrigin);
  public void AutoRegenerateAxes(IntPtr aElementIdList) => GetDelegate<AutoRegenerateAxesDelegate>().Invoke(_nativePtr, aElementIdList);
  public void RotateLengthAxis90(IntPtr aElementIdList) => GetDelegate<RotateLengthAxis90Delegate>().Invoke(_nativePtr, aElementIdList);
  public void RotateLengthAxis180(IntPtr aElementIdList) => GetDelegate<RotateLengthAxis180Delegate>().Invoke(_nativePtr, aElementIdList);
  public void InvertModel(IntPtr aElementIdList) => GetDelegate<InvertModelDelegate>().Invoke(_nativePtr, aElementIdList);
  public IntPtr GetElementFacets(ulong aId) => GetDelegate<GetElementFacetsDelegate>().Invoke(_nativePtr, aId);
  public double GetListWidth(ulong aId) => GetDelegate<GetListWidthDelegate>().Invoke(_nativePtr, aId);
  public double GetListHeight(ulong aId) => GetDelegate<GetListHeightDelegate>().Invoke(_nativePtr, aId);
  public double GetListLength(ulong aId) => GetDelegate<GetListLengthDelegate>().Invoke(_nativePtr, aId);
  public void SetWidthReal(IntPtr aElements, double aWidth) => GetDelegate<SetWidthRealDelegate>().Invoke(_nativePtr, aElements, aWidth);
  public void SetHeightReal(IntPtr aElements, double aHeight) => GetDelegate<SetHeightRealDelegate>().Invoke(_nativePtr, aElements, aHeight);
  public void SetLengthReal(IntPtr aElements, double aLength) => GetDelegate<SetLengthRealDelegate>().Invoke(_nativePtr, aElements, aLength);
  public void RotateHeightAxis2Points(IntPtr aElements, CVector3 aPoint1, CVector3 aPoint2) => GetDelegate<RotateHeightAxis2PointsDelegate>().Invoke(_nativePtr, aElements, aPoint1, aPoint2);
  public double GetMinimumDistanceBetweenElements(ulong aFirstId, ulong aSecondId) => GetDelegate<GetMinimumDistanceBetweenElementsDelegate>().Invoke(_nativePtr, aFirstId, aSecondId);
  public double GetTotalAreaOfAllFaces(ulong aElement) => GetDelegate<GetTotalAreaOfAllFacesDelegate>().Invoke(_nativePtr, aElement);
  public double GetAreaOfFrontFace(ulong aElement) => GetDelegate<GetAreaOfFrontFaceDelegate>().Invoke(_nativePtr, aElement);
  public double GetDoorSurface(IntPtr aElements) => GetDelegate<GetDoorSurfaceDelegate>().Invoke(_nativePtr, aElements);
  public double GetWindowSurface(IntPtr aElements) => GetDelegate<GetWindowSurfaceDelegate>().Invoke(_nativePtr, aElements);
  public void CreateDivisionZone(ulong aElement, CVector3 aPoint, DivisionZoneDirection aDirection) => GetDelegate<CreateDivisionZoneDelegate>().Invoke(_nativePtr, aElement, aPoint, aDirection);
  public void DeleteDivisionZone(ulong aElement) => GetDelegate<DeleteDivisionZoneDelegate>().Invoke(_nativePtr, aElement);
  public IntPtr GetDivisionZonePoints(ulong aElement) => GetDelegate<GetDivisionZonePointsDelegate>().Invoke(_nativePtr, aElement);
  public CVector3 GetLocalX() => GetDelegate<GetLocalXDelegate>().Invoke(_nativePtr);
  public CVector3 GetLocalZ() => GetDelegate<GetLocalZDelegate>().Invoke(_nativePtr);
  public CVector3 GetLocalY() => GetDelegate<GetLocalYDelegate>().Invoke(_nativePtr);
  public void ClearErrors() => GetDelegate<ClearErrorsDelegate>().Invoke(_nativePtr);
  public void SetDrillingTolerance(IntPtr aElements, double aTolerance) => GetDelegate<SetDrillingToleranceDelegate>().Invoke(_nativePtr, aElements, aTolerance);
  public double GetDrillingTolerance(ulong aElement) => GetDelegate<GetDrillingToleranceDelegate>().Invoke(_nativePtr, aElement);
  public IntPtr GetElementReferenceFaceVertices(ulong aElementId) => GetDelegate<GetElementReferenceFaceVerticesDelegate>().Invoke(_nativePtr, aElementId);
  public double GetElementReferenceFaceArea(ulong aElementId) => GetDelegate<GetElementReferenceFaceAreaDelegate>().Invoke(_nativePtr, aElementId);
  public void AutoRegenerateAxesSilently(IntPtr aElementIdList) => GetDelegate<AutoRegenerateAxesSilentlyDelegate>().Invoke(_nativePtr, aElementIdList);
  public void RotateLengthAxis2Points(IntPtr aElements, CVector3 aPoint1, CVector3 aPoint2) => GetDelegate<RotateLengthAxis2PointsDelegate>().Invoke(_nativePtr, aElements, aPoint1, aPoint2);
  public CVector3 GetCenterOfGravityForList(IntPtr aElements) => GetDelegate<GetCenterOfGravityForListDelegate>().Invoke(_nativePtr, aElements);
  public CVector3 GetCenterOfGravityForListConsideringMaterials(IntPtr aElements) => GetDelegate<GetCenterOfGravityForListConsideringMaterialsDelegate>().Invoke(_nativePtr, aElements);
  public uint GetElementFacetCount(ulong aId) => GetDelegate<GetElementFacetCountDelegate>().Invoke(_nativePtr, aId);
  public double GetWeightReal(ulong aId) => GetDelegate<GetWeightRealDelegate>().Invoke(_nativePtr, aId);
  public double GetActualPhysicalVolume(ulong aId) => GetDelegate<GetActualPhysicalVolumeDelegate>().Invoke(_nativePtr, aId);
  public bool AreFacetsCoplanar(IntPtr aFirstFacet, IntPtr aSecondFacet) => GetDelegate<AreFacetsCoplanarDelegate>().Invoke(_nativePtr, aFirstFacet, aSecondFacet);
  public bool GetRoundMachineRoughPartNegativeWidth(ulong aId) => GetDelegate<GetRoundMachineRoughPartNegativeWidthDelegate>().Invoke(_nativePtr, aId);
  public void SetRoundMachineRoughPartNegativeWidth(IntPtr aElements, bool aValue) => GetDelegate<SetRoundMachineRoughPartNegativeWidthDelegate>().Invoke(_nativePtr, aElements, aValue);
  public bool GetRoundMachineRoughPartPositiveWidth(ulong aId) => GetDelegate<GetRoundMachineRoughPartPositiveWidthDelegate>().Invoke(_nativePtr, aId);
  public void SetRoundMachineRoughPartPositiveWidth(IntPtr aElements, bool aValue) => GetDelegate<SetRoundMachineRoughPartPositiveWidthDelegate>().Invoke(_nativePtr, aElements, aValue);
  public bool GetRoundMachineRoughPartNegativeHeight(ulong aId) => GetDelegate<GetRoundMachineRoughPartNegativeHeightDelegate>().Invoke(_nativePtr, aId);
  public void SetRoundMachineRoughPartNegativeHeight(IntPtr aElements, bool aValue) => GetDelegate<SetRoundMachineRoughPartNegativeHeightDelegate>().Invoke(_nativePtr, aElements, aValue);
  public bool GetRoundMachineRoughPartPositiveHeight(ulong aId) => GetDelegate<GetRoundMachineRoughPartPositiveHeightDelegate>().Invoke(_nativePtr, aId);
  public void SetRoundMachineRoughPartPositiveHeight(IntPtr aElements, bool aValue) => GetDelegate<SetRoundMachineRoughPartPositiveHeightDelegate>().Invoke(_nativePtr, aElements, aValue);
  public bool GetRoundMachineRoughPartNegativeLength(ulong aId) => GetDelegate<GetRoundMachineRoughPartNegativeLengthDelegate>().Invoke(_nativePtr, aId);
  public void SetRoundMachineRoughPartNegativeLength(IntPtr aElements, bool aValue) => GetDelegate<SetRoundMachineRoughPartNegativeLengthDelegate>().Invoke(_nativePtr, aElements, aValue);
  public bool GetRoundMachineRoughPartPositiveLength(ulong aId) => GetDelegate<GetRoundMachineRoughPartPositiveLengthDelegate>().Invoke(_nativePtr, aId);
  public void SetRoundMachineRoughPartPositiveLength(IntPtr aElements, bool aValue) => GetDelegate<SetRoundMachineRoughPartPositiveLengthDelegate>().Invoke(_nativePtr, aElements, aValue);
  public double GetStandardElementWidthFromGuid(string aStandardElementGuid) => GetDelegate<GetStandardElementWidthFromGuidDelegate>().Invoke(_nativePtr, aStandardElementGuid);
  public double GetStandardElementHeightFromGuid(string aStandardElementGuid) => GetDelegate<GetStandardElementHeightFromGuidDelegate>().Invoke(_nativePtr, aStandardElementGuid);
  public double GetStandardElementLengthFromGuid(string aStandardElementGuid) => GetDelegate<GetStandardElementLengthFromGuidDelegate>().Invoke(_nativePtr, aStandardElementGuid);
  public double GetStandardElementWidthFromName(string aStandardElementName) => GetDelegate<GetStandardElementWidthFromNameDelegate>().Invoke(_nativePtr, aStandardElementName);
  public double GetStandardElementHeightFromName(string aStandardElementName) => GetDelegate<GetStandardElementHeightFromNameDelegate>().Invoke(_nativePtr, aStandardElementName);
  public double GetStandardElementLengthFromName(string aStandardElementName) => GetDelegate<GetStandardElementLengthFromNameDelegate>().Invoke(_nativePtr, aStandardElementName);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class GeometryControllerInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr getLastErrorFunctionPtr;
    internal IntPtr getWidthFunctionPtr;
    internal IntPtr getHeightFunctionPtr;
    internal IntPtr getLengthFunctionPtr;
    internal IntPtr getP1FunctionPtr;
    internal IntPtr getP2FunctionPtr;
    internal IntPtr getP3FunctionPtr;
    internal IntPtr getStartHeightCutAngleFunctionPtr;
    internal IntPtr getStartWidthCutAngleFunctionPtr;
    internal IntPtr getEndHeightCutAngleFunctionPtr;
    internal IntPtr getEndWidthCutAngleFunctionPtr;
    internal IntPtr rotateHeightAxis90FunctionPtr;
    internal IntPtr rotateHeightAxis180FunctionPtr;
    internal IntPtr getOverWidthFunctionPtr;
    internal IntPtr setOverWidthFunctionPtr;
    internal IntPtr getOverHeightFunctionPtr;
    internal IntPtr setOverHeightFunctionPtr;
    internal IntPtr getOverLengthFunctionPtr;
    internal IntPtr setOverLengthFunctionPtr;
    internal IntPtr getRoundingWidthFunctionPtr;
    internal IntPtr setRoundingWidthFunctionPtr;
    internal IntPtr getRoundingHeightFunctionPtr;
    internal IntPtr setRoundingHeightFunctionPtr;
    internal IntPtr getRoundingLengthFunctionPtr;
    internal IntPtr setRoundingLengthFunctionPtr;
    internal IntPtr getCrossCorrectionNegativeWidthFunctionPtr;
    internal IntPtr setCrossCorrectionNegativeWidthFunctionPtr;
    internal IntPtr getCrossCorrectionPositiveWidthFunctionPtr;
    internal IntPtr setCrossCorrectionPositiveWidthFunctionPtr;
    internal IntPtr getCrossCorrectionNegativeHeightFunctionPtr;
    internal IntPtr setCrossCorrectionNegativeHeightFunctionPtr;
    internal IntPtr getCrossCorrectionPositiveHeightFunctionPtr;
    internal IntPtr setCrossCorrectionPositiveHeightFunctionPtr;
    internal IntPtr getCrossCorrectionNegativeLengthFunctionPtr;
    internal IntPtr setCrossCorrectionNegativeLengthFunctionPtr;
    internal IntPtr getCrossCorrectionPositiveLengthFunctionPtr;
    internal IntPtr setCrossCorrectionPositiveLengthFunctionPtr;
    internal IntPtr getWeightFunctionPtr;
    internal IntPtr getListWeightFunctionPtr;
    internal IntPtr getVolumeFunctionPtr;
    internal IntPtr getListVolumeFunctionPtr;
    internal IntPtr getXLFunctionPtr;
    internal IntPtr getYLFunctionPtr;
    internal IntPtr getZLFunctionPtr;
    internal IntPtr getCenterOfGravityFunctionPtr;
    internal IntPtr getReferenceSideFunctionPtr;
    internal IntPtr getElementVerticesFunctionPtr;
    internal IntPtr applyGlobalScaleFunctionPtr;
    internal IntPtr autoRegenerateAxesFunctionPtr;
    internal IntPtr rotateLengthAxis90FunctionPtr;
    internal IntPtr rotateLengthAxis180FunctionPtr;
    internal IntPtr invertModelFunctionPtr;
    internal IntPtr getElementFacetsFunctionPtr;
    internal IntPtr getListWidthFunctionPtr;
    internal IntPtr getListHeightFunctionPtr;
    internal IntPtr getListLengthFunctionPtr;
    internal IntPtr setWidthRealFunctionPtr;
    internal IntPtr setHeightRealFunctionPtr;
    internal IntPtr setLengthRealFunctionPtr;
    internal IntPtr rotateHeightAxis2PointsFunctionPtr;
    internal IntPtr getMinimumDistanceBetweenElementsFunctionPtr;
    internal IntPtr getTotalAreaOfAllFacesFunctionPtr;
    internal IntPtr getAreaOfFrontFaceFunctionPtr;
    internal IntPtr getDoorSurfaceFunctionPtr;
    internal IntPtr getWindowSurfaceFunctionPtr;
    internal IntPtr createDivisionZoneFunctionPtr;
    internal IntPtr deleteDivisionZoneFunctionPtr;
    internal IntPtr getDivisionZonePointsFunctionPtr;
    internal IntPtr getLocalXFunctionPtr;
    internal IntPtr getLocalZFunctionPtr;
    internal IntPtr getLocalYFunctionPtr;
    internal IntPtr clearErrorsFunctionPtr;
    internal IntPtr setDrillingToleranceFunctionPtr;
    internal IntPtr getDrillingToleranceFunctionPtr;
    internal IntPtr getElementReferenceFaceVerticesFunctionPtr;
    internal IntPtr getElementReferenceFaceAreaFunctionPtr;
    internal IntPtr autoRegenerateAxesSilentlyFunctionPtr;
    internal IntPtr rotateLengthAxis2PointsFunctionPtr;
    internal IntPtr getCenterOfGravityForListFunctionPtr;
    internal IntPtr getCenterOfGravityForListConsideringMaterialsFunctionPtr;
    internal IntPtr getElementFacetCountFunctionPtr;
    internal IntPtr getWeightRealFunctionPtr;
    internal IntPtr getActualPhysicalVolumeFunctionPtr;
    internal IntPtr areFacetsCoplanarFunctionPtr;
    internal IntPtr getRoundMachineRoughPartNegativeWidthFunctionPtr;
    internal IntPtr setRoundMachineRoughPartNegativeWidthFunctionPtr;
    internal IntPtr getRoundMachineRoughPartPositiveWidthFunctionPtr;
    internal IntPtr setRoundMachineRoughPartPositiveWidthFunctionPtr;
    internal IntPtr getRoundMachineRoughPartNegativeHeightFunctionPtr;
    internal IntPtr setRoundMachineRoughPartNegativeHeightFunctionPtr;
    internal IntPtr getRoundMachineRoughPartPositiveHeightFunctionPtr;
    internal IntPtr setRoundMachineRoughPartPositiveHeightFunctionPtr;
    internal IntPtr getRoundMachineRoughPartNegativeLengthFunctionPtr;
    internal IntPtr setRoundMachineRoughPartNegativeLengthFunctionPtr;
    internal IntPtr getRoundMachineRoughPartPositiveLengthFunctionPtr;
    internal IntPtr setRoundMachineRoughPartPositiveLengthFunctionPtr;
    internal IntPtr getStandardElementWidthFromGuidFunctionPtr;
    internal IntPtr getStandardElementHeightFromGuidFunctionPtr;
    internal IntPtr getStandardElementLengthFromGuidFunctionPtr;
    internal IntPtr getStandardElementWidthFromNameFunctionPtr;
    internal IntPtr getStandardElementHeightFromNameFunctionPtr;
    internal IntPtr getStandardElementLengthFromNameFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetLastErrorDelegate(IntPtr thisPtr, IntPtr aErrorCode);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetWidthDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetHeightDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetLengthDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate CVector3 GetP1Delegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate CVector3 GetP2Delegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate CVector3 GetP3Delegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetStartHeightCutAngleDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetStartWidthCutAngleDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetEndHeightCutAngleDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetEndWidthCutAngleDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void RotateHeightAxis90Delegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void RotateHeightAxis180Delegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetOverWidthDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetOverWidthDelegate(IntPtr thisPtr, IntPtr aElementIdList, double aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetOverHeightDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetOverHeightDelegate(IntPtr thisPtr, IntPtr aElementIdList, double aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetOverLengthDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetOverLengthDelegate(IntPtr thisPtr, IntPtr aElementIdList, double aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetRoundingWidthDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetRoundingWidthDelegate(IntPtr thisPtr, IntPtr aElementIdList, double aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetRoundingHeightDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetRoundingHeightDelegate(IntPtr thisPtr, IntPtr aElementIdList, double aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetRoundingLengthDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetRoundingLengthDelegate(IntPtr thisPtr, IntPtr aElementIdList, double aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetCrossCorrectionNegativeWidthDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCrossCorrectionNegativeWidthDelegate(IntPtr thisPtr, IntPtr aElementIdList, double aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetCrossCorrectionPositiveWidthDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCrossCorrectionPositiveWidthDelegate(IntPtr thisPtr, IntPtr aElementIdList, double aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetCrossCorrectionNegativeHeightDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCrossCorrectionNegativeHeightDelegate(IntPtr thisPtr, IntPtr aElementIdList, double aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetCrossCorrectionPositiveHeightDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCrossCorrectionPositiveHeightDelegate(IntPtr thisPtr, IntPtr aElementIdList, double aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetCrossCorrectionNegativeLengthDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCrossCorrectionNegativeLengthDelegate(IntPtr thisPtr, IntPtr aElementIdList, double aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetCrossCorrectionPositiveLengthDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCrossCorrectionPositiveLengthDelegate(IntPtr thisPtr, IntPtr aElementIdList, double aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetWeightDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetListWeightDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetVolumeDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetListVolumeDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate CVector3 GetXlDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate CVector3 GetYlDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate CVector3 GetZlDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate CVector3 GetCenterOfGravityDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate uint GetReferenceSideDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetElementVerticesDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ApplyGlobalScaleDelegate(IntPtr thisPtr, IntPtr aElementIdList, double aScale, CVector3 aOrigin);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void AutoRegenerateAxesDelegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void RotateLengthAxis90Delegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void RotateLengthAxis180Delegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void InvertModelDelegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetElementFacetsDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetListWidthDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetListHeightDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetListLengthDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetWidthRealDelegate(IntPtr thisPtr, IntPtr aElements, double aWidth);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetHeightRealDelegate(IntPtr thisPtr, IntPtr aElements, double aHeight);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetLengthRealDelegate(IntPtr thisPtr, IntPtr aElements, double aLength);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void RotateHeightAxis2PointsDelegate(IntPtr thisPtr, IntPtr aElements, CVector3 aPoint1, CVector3 aPoint2);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetMinimumDistanceBetweenElementsDelegate(IntPtr thisPtr, ulong aFirstId, ulong aSecondId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetTotalAreaOfAllFacesDelegate(IntPtr thisPtr, ulong aElement);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetAreaOfFrontFaceDelegate(IntPtr thisPtr, ulong aElement);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetDoorSurfaceDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetWindowSurfaceDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void CreateDivisionZoneDelegate(IntPtr thisPtr, ulong aElement, CVector3 aPoint, DivisionZoneDirection aDirection);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DeleteDivisionZoneDelegate(IntPtr thisPtr, ulong aElement);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetDivisionZonePointsDelegate(IntPtr thisPtr, ulong aElement);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate CVector3 GetLocalXDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate CVector3 GetLocalZDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate CVector3 GetLocalYDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ClearErrorsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetDrillingToleranceDelegate(IntPtr thisPtr, IntPtr aElements, double aTolerance);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetDrillingToleranceDelegate(IntPtr thisPtr, ulong aElement);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetElementReferenceFaceVerticesDelegate(IntPtr thisPtr, ulong aElementId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetElementReferenceFaceAreaDelegate(IntPtr thisPtr, ulong aElementId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void AutoRegenerateAxesSilentlyDelegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void RotateLengthAxis2PointsDelegate(IntPtr thisPtr, IntPtr aElements, CVector3 aPoint1, CVector3 aPoint2);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate CVector3 GetCenterOfGravityForListDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate CVector3 GetCenterOfGravityForListConsideringMaterialsDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate uint GetElementFacetCountDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetWeightRealDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetActualPhysicalVolumeDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool AreFacetsCoplanarDelegate(IntPtr thisPtr, IntPtr aFirstFacet, IntPtr aSecondFacet);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetRoundMachineRoughPartNegativeWidthDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetRoundMachineRoughPartNegativeWidthDelegate(IntPtr thisPtr, IntPtr aElements, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetRoundMachineRoughPartPositiveWidthDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetRoundMachineRoughPartPositiveWidthDelegate(IntPtr thisPtr, IntPtr aElements, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetRoundMachineRoughPartNegativeHeightDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetRoundMachineRoughPartNegativeHeightDelegate(IntPtr thisPtr, IntPtr aElements, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetRoundMachineRoughPartPositiveHeightDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetRoundMachineRoughPartPositiveHeightDelegate(IntPtr thisPtr, IntPtr aElements, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetRoundMachineRoughPartNegativeLengthDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetRoundMachineRoughPartNegativeLengthDelegate(IntPtr thisPtr, IntPtr aElements, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetRoundMachineRoughPartPositiveLengthDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetRoundMachineRoughPartPositiveLengthDelegate(IntPtr thisPtr, IntPtr aElements, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetStandardElementWidthFromGuidDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aStandardElementGuid);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetStandardElementHeightFromGuidDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aStandardElementGuid);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetStandardElementLengthFromGuidDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aStandardElementGuid);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetStandardElementWidthFromNameDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aStandardElementName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetStandardElementHeightFromNameDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aStandardElementName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetStandardElementLengthFromNameDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aStandardElementName);
}
