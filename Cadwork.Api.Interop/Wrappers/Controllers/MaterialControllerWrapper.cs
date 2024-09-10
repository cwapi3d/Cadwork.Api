// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Controllers;

public class MaterialControllerWrapper
{
  private readonly IntPtr _nativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public MaterialControllerWrapper(IntPtr nativePtr)
  {
    _nativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<MaterialControllerInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(GetLastErrorDelegate), Marshal.GetDelegateForFunctionPointer<GetLastErrorDelegate>(vTable!.getLastErrorFunctionPtr) },
      { typeof(CreateMaterialDelegate), Marshal.GetDelegateForFunctionPointer<CreateMaterialDelegate>(vTable.createMaterialFunctionPtr) },
      { typeof(GetNameDelegate), Marshal.GetDelegateForFunctionPointer<GetNameDelegate>(vTable.getNameFunctionPtr) },
      { typeof(SetNameDelegate), Marshal.GetDelegateForFunctionPointer<SetNameDelegate>(vTable.setNameFunctionPtr) },
      { typeof(GetGroupDelegate), Marshal.GetDelegateForFunctionPointer<GetGroupDelegate>(vTable.getGroupFunctionPtr) },
      { typeof(SetGroupDelegate), Marshal.GetDelegateForFunctionPointer<SetGroupDelegate>(vTable.setGroupFunctionPtr) },
      { typeof(GetCodeDelegate), Marshal.GetDelegateForFunctionPointer<GetCodeDelegate>(vTable.getCodeFunctionPtr) },
      { typeof(SetCodeDelegate), Marshal.GetDelegateForFunctionPointer<SetCodeDelegate>(vTable.setCodeFunctionPtr) },
      { typeof(GetModulusElasticity1Delegate), Marshal.GetDelegateForFunctionPointer<GetModulusElasticity1Delegate>(vTable.getModulusElasticity1FunctionPtr) },
      { typeof(SetModulusElasticity1Delegate), Marshal.GetDelegateForFunctionPointer<SetModulusElasticity1Delegate>(vTable.setModulusElasticity1FunctionPtr) },
      { typeof(GetModulusElasticity2Delegate), Marshal.GetDelegateForFunctionPointer<GetModulusElasticity2Delegate>(vTable.getModulusElasticity2FunctionPtr) },
      { typeof(SetModulusElasticity2Delegate), Marshal.GetDelegateForFunctionPointer<SetModulusElasticity2Delegate>(vTable.setModulusElasticity2FunctionPtr) },
      { typeof(GetModulusElasticity3Delegate), Marshal.GetDelegateForFunctionPointer<GetModulusElasticity3Delegate>(vTable.getModulusElasticity3FunctionPtr) },
      { typeof(SetModulusElasticity3Delegate), Marshal.GetDelegateForFunctionPointer<SetModulusElasticity3Delegate>(vTable.setModulusElasticity3FunctionPtr) },
      { typeof(GetShearModulus1Delegate), Marshal.GetDelegateForFunctionPointer<GetShearModulus1Delegate>(vTable.getShearModulus1FunctionPtr) },
      { typeof(SetShearModulus1Delegate), Marshal.GetDelegateForFunctionPointer<SetShearModulus1Delegate>(vTable.setShearModulus1FunctionPtr) },
      { typeof(GetShearModulus2Delegate), Marshal.GetDelegateForFunctionPointer<GetShearModulus2Delegate>(vTable.getShearModulus2FunctionPtr) },
      { typeof(SetShearModulus2Delegate), Marshal.GetDelegateForFunctionPointer<SetShearModulus2Delegate>(vTable.setShearModulus2FunctionPtr) },
      { typeof(GetPriceDelegate), Marshal.GetDelegateForFunctionPointer<GetPriceDelegate>(vTable.getPriceFunctionPtr) },
      { typeof(SetPriceDelegate), Marshal.GetDelegateForFunctionPointer<SetPriceDelegate>(vTable.setPriceFunctionPtr) },
      { typeof(GetPriceTypeDelegate), Marshal.GetDelegateForFunctionPointer<GetPriceTypeDelegate>(vTable.getPriceTypeFunctionPtr) },
      { typeof(SetPriceTypeDelegate), Marshal.GetDelegateForFunctionPointer<SetPriceTypeDelegate>(vTable.setPriceTypeFunctionPtr) },
      { typeof(GetThermalConductivityDelegate), Marshal.GetDelegateForFunctionPointer<GetThermalConductivityDelegate>(vTable.getThermalConductivityFunctionPtr) },
      { typeof(SetThermalConductivityDelegate), Marshal.GetDelegateForFunctionPointer<SetThermalConductivityDelegate>(vTable.setThermalConductivityFunctionPtr) },
      { typeof(GetHeatCapacityDelegate), Marshal.GetDelegateForFunctionPointer<GetHeatCapacityDelegate>(vTable.getHeatCapacityFunctionPtr) },
      { typeof(SetHeatCapacityDelegate), Marshal.GetDelegateForFunctionPointer<SetHeatCapacityDelegate>(vTable.setHeatCapacityFunctionPtr) },
      { typeof(GetUMinDelegate), Marshal.GetDelegateForFunctionPointer<GetUMinDelegate>(vTable.getUMinFunctionPtr) },
      { typeof(SetUMinDelegate), Marshal.GetDelegateForFunctionPointer<SetUMinDelegate>(vTable.setUMinFunctionPtr) },
      { typeof(GetUMaxDelegate), Marshal.GetDelegateForFunctionPointer<GetUMaxDelegate>(vTable.getUMaxFunctionPtr) },
      { typeof(SetUMaxDelegate), Marshal.GetDelegateForFunctionPointer<SetUMaxDelegate>(vTable.setUMaxFunctionPtr) },
      { typeof(GetFireResistanceClassDelegate), Marshal.GetDelegateForFunctionPointer<GetFireResistanceClassDelegate>(vTable.getFireResistanceClassFunctionPtr) },
      { typeof(SetFireResistanceClassDelegate), Marshal.GetDelegateForFunctionPointer<SetFireResistanceClassDelegate>(vTable.setFireResistanceClassFunctionPtr) },
      { typeof(GetSmokeClassDelegate), Marshal.GetDelegateForFunctionPointer<GetSmokeClassDelegate>(vTable.getSmokeClassFunctionPtr) },
      { typeof(SetSmokeClassDelegate), Marshal.GetDelegateForFunctionPointer<SetSmokeClassDelegate>(vTable.setSmokeClassFunctionPtr) },
      { typeof(GetDropFormingClassDelegate), Marshal.GetDelegateForFunctionPointer<GetDropFormingClassDelegate>(vTable.getDropFormingClassFunctionPtr) },
      { typeof(SetDropFormingClassDelegate), Marshal.GetDelegateForFunctionPointer<SetDropFormingClassDelegate>(vTable.setDropFormingClassFunctionPtr) },
      { typeof(GetBurnOffRateDelegate), Marshal.GetDelegateForFunctionPointer<GetBurnOffRateDelegate>(vTable.getBurnOffRateFunctionPtr) },
      { typeof(SetBurnOffRateDelegate), Marshal.GetDelegateForFunctionPointer<SetBurnOffRateDelegate>(vTable.setBurnOffRateFunctionPtr) },
      { typeof(GetWeightDelegate), Marshal.GetDelegateForFunctionPointer<GetWeightDelegate>(vTable.getWeightFunctionPtr) },
      { typeof(SetWeightDelegate), Marshal.GetDelegateForFunctionPointer<SetWeightDelegate>(vTable.setWeightFunctionPtr) },
      { typeof(GetWeightTypeDelegate), Marshal.GetDelegateForFunctionPointer<GetWeightTypeDelegate>(vTable.getWeightTypeFunctionPtr) },
      { typeof(SetWeightTypeDelegate), Marshal.GetDelegateForFunctionPointer<SetWeightTypeDelegate>(vTable.setWeightTypeFunctionPtr) },
      { typeof(GetMaterialIdDelegate), Marshal.GetDelegateForFunctionPointer<GetMaterialIdDelegate>(vTable.getMaterialIDFunctionPtr) },
      { typeof(GetAllMaterialsDelegate), Marshal.GetDelegateForFunctionPointer<GetAllMaterialsDelegate>(vTable.getAllMaterialsFunctionPtr) },
      { typeof(ClearErrorsDelegate), Marshal.GetDelegateForFunctionPointer<ClearErrorsDelegate>(vTable.clearErrorsFunctionPtr) },
      { typeof(GetGradeDelegate), Marshal.GetDelegateForFunctionPointer<GetGradeDelegate>(vTable.getGradeFunctionPtr) },
      { typeof(SetGradeDelegate), Marshal.GetDelegateForFunctionPointer<SetGradeDelegate>(vTable.setGradeFunctionPtr) },
      { typeof(GetQualityDelegate), Marshal.GetDelegateForFunctionPointer<GetQualityDelegate>(vTable.getQualityFunctionPtr) },
      { typeof(SetQualityDelegate), Marshal.GetDelegateForFunctionPointer<SetQualityDelegate>(vTable.setQualityFunctionPtr) },
      { typeof(GetCompositionDelegate), Marshal.GetDelegateForFunctionPointer<GetCompositionDelegate>(vTable.getCompositionFunctionPtr) },
      { typeof(SetCompositionDelegate), Marshal.GetDelegateForFunctionPointer<SetCompositionDelegate>(vTable.setCompositionFunctionPtr) },
      { typeof(GetShortNameDelegate), Marshal.GetDelegateForFunctionPointer<GetShortNameDelegate>(vTable.getShortNameFunctionPtr) },
      { typeof(GetAllMaterialGroupsDelegate), Marshal.GetDelegateForFunctionPointer<GetAllMaterialGroupsDelegate>(vTable.getAllMaterialGroupsFunctionPtr) },
      { typeof(GetParentGroupDelegate), Marshal.GetDelegateForFunctionPointer<GetParentGroupDelegate>(vTable.getParentGroupFunctionPtr) },
      { typeof(GetMaterialColorAssignmentForNodesDelegate), Marshal.GetDelegateForFunctionPointer<GetMaterialColorAssignmentForNodesDelegate>(vTable.getMaterialColorAssignmentForNodesFunctionPtr) },
      { typeof(SetMaterialColorAssignmentForNodesDelegate), Marshal.GetDelegateForFunctionPointer<SetMaterialColorAssignmentForNodesDelegate>(vTable.setMaterialColorAssignmentForNodesFunctionPtr) },
      { typeof(GetMaterialColorAssignmentForStandardAxesDelegate), Marshal.GetDelegateForFunctionPointer<GetMaterialColorAssignmentForStandardAxesDelegate>(vTable.getMaterialColorAssignmentForStandardAxesFunctionPtr) },
      { typeof(SetMaterialColorAssignmentForStandardAxesDelegate), Marshal.GetDelegateForFunctionPointer<SetMaterialColorAssignmentForStandardAxesDelegate>(vTable.setMaterialColorAssignmentForStandardAxesFunctionPtr) },
      { typeof(GetMaterialColorAssignmentForDrillingsDelegate), Marshal.GetDelegateForFunctionPointer<GetMaterialColorAssignmentForDrillingsDelegate>(vTable.getMaterialColorAssignmentForDrillingsFunctionPtr) },
      { typeof(SetMaterialColorAssignmentForDrillingsDelegate), Marshal.GetDelegateForFunctionPointer<SetMaterialColorAssignmentForDrillingsDelegate>(vTable.setMaterialColorAssignmentForDrillingsFunctionPtr) },
      { typeof(GetMaterialColorAssignmentForMepAxesDelegate), Marshal.GetDelegateForFunctionPointer<GetMaterialColorAssignmentForMepAxesDelegate>(vTable.getMaterialColorAssignmentForMEPAxesFunctionPtr) },
      { typeof(SetMaterialColorAssignmentForMepAxesDelegate), Marshal.GetDelegateForFunctionPointer<SetMaterialColorAssignmentForMepAxesDelegate>(vTable.setMaterialColorAssignmentForMEPAxesFunctionPtr) },
      { typeof(GetMaterialColorAssignmentForBeamsDelegate), Marshal.GetDelegateForFunctionPointer<GetMaterialColorAssignmentForBeamsDelegate>(vTable.getMaterialColorAssignmentForBeamsFunctionPtr) },
      { typeof(SetMaterialColorAssignmentForBeamsDelegate), Marshal.GetDelegateForFunctionPointer<SetMaterialColorAssignmentForBeamsDelegate>(vTable.setMaterialColorAssignmentForBeamsFunctionPtr) },
      { typeof(GetMaterialColorAssignmentForPanelsDelegate), Marshal.GetDelegateForFunctionPointer<GetMaterialColorAssignmentForPanelsDelegate>(vTable.getMaterialColorAssignmentForPanelsFunctionPtr) },
      { typeof(SetMaterialColorAssignmentForPanelsDelegate), Marshal.GetDelegateForFunctionPointer<SetMaterialColorAssignmentForPanelsDelegate>(vTable.setMaterialColorAssignmentForPanelsFunctionPtr) },
      { typeof(GetMaterialColorAssignmentForAuxiliaryElementsDelegate), Marshal.GetDelegateForFunctionPointer<GetMaterialColorAssignmentForAuxiliaryElementsDelegate>(vTable.getMaterialColorAssignmentForAuxiliaryElementsFunctionPtr) },
      { typeof(SetMaterialColorAssignmentForAuxiliaryElementsDelegate), Marshal.GetDelegateForFunctionPointer<SetMaterialColorAssignmentForAuxiliaryElementsDelegate>(vTable.setMaterialColorAssignmentForAuxiliaryElementsFunctionPtr) },
      { typeof(GetMaterialColorAssignmentForSurfacesDelegate), Marshal.GetDelegateForFunctionPointer<GetMaterialColorAssignmentForSurfacesDelegate>(vTable.getMaterialColorAssignmentForSurfacesFunctionPtr) },
      { typeof(SetMaterialColorAssignmentForSurfacesDelegate), Marshal.GetDelegateForFunctionPointer<SetMaterialColorAssignmentForSurfacesDelegate>(vTable.setMaterialColorAssignmentForSurfacesFunctionPtr) },
      { typeof(GetTextureColorDelegate), Marshal.GetDelegateForFunctionPointer<GetTextureColorDelegate>(vTable.getTextureColorFunctionPtr) },
      { typeof(SetTextureColorDelegate), Marshal.GetDelegateForFunctionPointer<SetTextureColorDelegate>(vTable.setTextureColorFunctionPtr) },
      { typeof(GetTextureTransparencyDelegate), Marshal.GetDelegateForFunctionPointer<GetTextureTransparencyDelegate>(vTable.getTextureTransparencyFunctionPtr) },
      { typeof(SetTextureTransparencyDelegate), Marshal.GetDelegateForFunctionPointer<SetTextureTransparencyDelegate>(vTable.setTextureTransparencyFunctionPtr) },
      { typeof(GetTextureRotationAngleDelegate), Marshal.GetDelegateForFunctionPointer<GetTextureRotationAngleDelegate>(vTable.getTextureRotationAngleFunctionPtr) },
      { typeof(SetTextureRotationAngleDelegate), Marshal.GetDelegateForFunctionPointer<SetTextureRotationAngleDelegate>(vTable.setTextureRotationAngleFunctionPtr) },
      { typeof(GetTextureLengthAlignmentDelegate), Marshal.GetDelegateForFunctionPointer<GetTextureLengthAlignmentDelegate>(vTable.getTextureLengthAlignmentFunctionPtr) },
      { typeof(SetTextureLengthAlignmentDelegate), Marshal.GetDelegateForFunctionPointer<SetTextureLengthAlignmentDelegate>(vTable.setTextureLengthAlignmentFunctionPtr) },
      { typeof(GetTextureZoomXDelegate), Marshal.GetDelegateForFunctionPointer<GetTextureZoomXDelegate>(vTable.getTextureZoomXFunctionPtr) },
      { typeof(SetTextureZoomXDelegate), Marshal.GetDelegateForFunctionPointer<SetTextureZoomXDelegate>(vTable.setTextureZoomXFunctionPtr) },
      { typeof(GetTextureZoomYDelegate), Marshal.GetDelegateForFunctionPointer<GetTextureZoomYDelegate>(vTable.getTextureZoomYFunctionPtr) },
      { typeof(SetTextureZoomYDelegate), Marshal.GetDelegateForFunctionPointer<SetTextureZoomYDelegate>(vTable.setTextureZoomYFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public IntPtr GetLastError(IntPtr aErrorCode) => GetDelegate<GetLastErrorDelegate>().Invoke(_nativePtr, aErrorCode);
  public ulong CreateMaterial(string aName) => GetDelegate<CreateMaterialDelegate>().Invoke(_nativePtr, aName);
  public IntPtr GetName(ulong aMaterialId) => GetDelegate<GetNameDelegate>().Invoke(_nativePtr, aMaterialId);
  public void SetName(ulong aMaterialId, string aName) => GetDelegate<SetNameDelegate>().Invoke(_nativePtr, aMaterialId, aName);
  public IntPtr GetGroup(ulong aMaterialId) => GetDelegate<GetGroupDelegate>().Invoke(_nativePtr, aMaterialId);
  public void SetGroup(ulong aMaterialId, string aGroup) => GetDelegate<SetGroupDelegate>().Invoke(_nativePtr, aMaterialId, aGroup);
  public IntPtr GetCode(ulong aMaterialId) => GetDelegate<GetCodeDelegate>().Invoke(_nativePtr, aMaterialId);
  public void SetCode(ulong aMaterialId, string aCode) => GetDelegate<SetCodeDelegate>().Invoke(_nativePtr, aMaterialId, aCode);
  public double GetModulusElasticity1(ulong aMaterialId) => GetDelegate<GetModulusElasticity1Delegate>().Invoke(_nativePtr, aMaterialId);
  public void SetModulusElasticity1(ulong aMaterialId, double aModulusElasticity1) => GetDelegate<SetModulusElasticity1Delegate>().Invoke(_nativePtr, aMaterialId, aModulusElasticity1);
  public double GetModulusElasticity2(ulong aMaterialId) => GetDelegate<GetModulusElasticity2Delegate>().Invoke(_nativePtr, aMaterialId);
  public void SetModulusElasticity2(ulong aMaterialId, double aModulusElasticity2) => GetDelegate<SetModulusElasticity2Delegate>().Invoke(_nativePtr, aMaterialId, aModulusElasticity2);
  public double GetModulusElasticity3(ulong aMaterialId) => GetDelegate<GetModulusElasticity3Delegate>().Invoke(_nativePtr, aMaterialId);
  public void SetModulusElasticity3(ulong aMaterialId, double aModulusElasticity3) => GetDelegate<SetModulusElasticity3Delegate>().Invoke(_nativePtr, aMaterialId, aModulusElasticity3);
  public double GetShearModulus1(ulong aMaterialId) => GetDelegate<GetShearModulus1Delegate>().Invoke(_nativePtr, aMaterialId);
  public void SetShearModulus1(ulong aMaterialId, double aShearModulus1) => GetDelegate<SetShearModulus1Delegate>().Invoke(_nativePtr, aMaterialId, aShearModulus1);
  public double GetShearModulus2(ulong aMaterialId) => GetDelegate<GetShearModulus2Delegate>().Invoke(_nativePtr, aMaterialId);
  public void SetShearModulus2(ulong aMaterialId, double aShearModulus2) => GetDelegate<SetShearModulus2Delegate>().Invoke(_nativePtr, aMaterialId, aShearModulus2);
  public double GetPrice(ulong aMaterialId) => GetDelegate<GetPriceDelegate>().Invoke(_nativePtr, aMaterialId);
  public void SetPrice(ulong aMaterialId, double aPrice) => GetDelegate<SetPriceDelegate>().Invoke(_nativePtr, aMaterialId, aPrice);
  public IntPtr GetPriceType(ulong aMaterialId) => GetDelegate<GetPriceTypeDelegate>().Invoke(_nativePtr, aMaterialId);
  public void SetPriceType(ulong aMaterialId, string aPriceType) => GetDelegate<SetPriceTypeDelegate>().Invoke(_nativePtr, aMaterialId, aPriceType);
  public double GetThermalConductivity(ulong aMaterialId) => GetDelegate<GetThermalConductivityDelegate>().Invoke(_nativePtr, aMaterialId);
  public void SetThermalConductivity(ulong aMaterialId, double aThermalConductivity) => GetDelegate<SetThermalConductivityDelegate>().Invoke(_nativePtr, aMaterialId, aThermalConductivity);
  public double GetHeatCapacity(ulong aMaterialId) => GetDelegate<GetHeatCapacityDelegate>().Invoke(_nativePtr, aMaterialId);
  public void SetHeatCapacity(ulong aMaterialId, double aHeatCapacity) => GetDelegate<SetHeatCapacityDelegate>().Invoke(_nativePtr, aMaterialId, aHeatCapacity);
  public double GetUMin(ulong aMaterialId) => GetDelegate<GetUMinDelegate>().Invoke(_nativePtr, aMaterialId);
  public void SetUMin(ulong aMaterialId, double aUMin) => GetDelegate<SetUMinDelegate>().Invoke(_nativePtr, aMaterialId, aUMin);
  public double GetUMax(ulong aMaterialId) => GetDelegate<GetUMaxDelegate>().Invoke(_nativePtr, aMaterialId);
  public void SetUMax(ulong aMaterialId, double aUMax) => GetDelegate<SetUMaxDelegate>().Invoke(_nativePtr, aMaterialId, aUMax);
  public IntPtr GetFireResistanceClass(ulong aMaterialId) => GetDelegate<GetFireResistanceClassDelegate>().Invoke(_nativePtr, aMaterialId);
  public void SetFireResistanceClass(ulong aMaterialId, string aFireResistanceClass) => GetDelegate<SetFireResistanceClassDelegate>().Invoke(_nativePtr, aMaterialId, aFireResistanceClass);
  public IntPtr GetSmokeClass(ulong aMaterialId) => GetDelegate<GetSmokeClassDelegate>().Invoke(_nativePtr, aMaterialId);
  public void SetSmokeClass(ulong aMaterialId, string aSmokeClass) => GetDelegate<SetSmokeClassDelegate>().Invoke(_nativePtr, aMaterialId, aSmokeClass);
  public IntPtr GetDropFormingClass(ulong aMaterialId) => GetDelegate<GetDropFormingClassDelegate>().Invoke(_nativePtr, aMaterialId);
  public void SetDropFormingClass(ulong aMaterialId, string aDropFormingClass) => GetDelegate<SetDropFormingClassDelegate>().Invoke(_nativePtr, aMaterialId, aDropFormingClass);
  public double GetBurnOffRate(ulong aMaterialId) => GetDelegate<GetBurnOffRateDelegate>().Invoke(_nativePtr, aMaterialId);
  public void SetBurnOffRate(ulong aMaterialId, double aBurnOffRate) => GetDelegate<SetBurnOffRateDelegate>().Invoke(_nativePtr, aMaterialId, aBurnOffRate);
  public double GetWeight(ulong aMaterialId) => GetDelegate<GetWeightDelegate>().Invoke(_nativePtr, aMaterialId);
  public void SetWeight(ulong aMaterialId, double aWeight) => GetDelegate<SetWeightDelegate>().Invoke(_nativePtr, aMaterialId, aWeight);
  public IntPtr GetWeightType(ulong aMaterialId) => GetDelegate<GetWeightTypeDelegate>().Invoke(_nativePtr, aMaterialId);
  public void SetWeightType(ulong aMaterialId, string aWeightType) => GetDelegate<SetWeightTypeDelegate>().Invoke(_nativePtr, aMaterialId, aWeightType);
  public ulong GetMaterialId(string aMaterialName) => GetDelegate<GetMaterialIdDelegate>().Invoke(_nativePtr, aMaterialName);
  public IntPtr GetAllMaterials() => GetDelegate<GetAllMaterialsDelegate>().Invoke(_nativePtr);
  public void ClearErrors() => GetDelegate<ClearErrorsDelegate>().Invoke(_nativePtr);
  public IntPtr GetGrade(ulong aMaterialId) => GetDelegate<GetGradeDelegate>().Invoke(_nativePtr, aMaterialId);
  public void SetGrade(ulong aMaterialId, string aGrade) => GetDelegate<SetGradeDelegate>().Invoke(_nativePtr, aMaterialId, aGrade);
  public IntPtr GetQuality(ulong aMaterialId) => GetDelegate<GetQualityDelegate>().Invoke(_nativePtr, aMaterialId);
  public void SetQuality(ulong aMaterialId, string aQuality) => GetDelegate<SetQualityDelegate>().Invoke(_nativePtr, aMaterialId, aQuality);
  public IntPtr GetComposition(ulong aMaterialId) => GetDelegate<GetCompositionDelegate>().Invoke(_nativePtr, aMaterialId);
  public void SetComposition(ulong aMaterialId, string aComposition) => GetDelegate<SetCompositionDelegate>().Invoke(_nativePtr, aMaterialId, aComposition);
  public IntPtr GetShortName(ulong aMaterialId) => GetDelegate<GetShortNameDelegate>().Invoke(_nativePtr, aMaterialId);
  public IntPtr GetAllMaterialGroups() => GetDelegate<GetAllMaterialGroupsDelegate>().Invoke(_nativePtr);
  public IntPtr GetParentGroup(string aGroup) => GetDelegate<GetParentGroupDelegate>().Invoke(_nativePtr, aGroup);
  public ulong GetMaterialColorAssignmentForNodes(uint aColorNumber) => GetDelegate<GetMaterialColorAssignmentForNodesDelegate>().Invoke(_nativePtr, aColorNumber);
  public void SetMaterialColorAssignmentForNodes(uint aColorNumber, ulong aMaterial) => GetDelegate<SetMaterialColorAssignmentForNodesDelegate>().Invoke(_nativePtr, aColorNumber, aMaterial);
  public ulong GetMaterialColorAssignmentForStandardAxes(uint aColorNumber) => GetDelegate<GetMaterialColorAssignmentForStandardAxesDelegate>().Invoke(_nativePtr, aColorNumber);
  public void SetMaterialColorAssignmentForStandardAxes(uint aColorNumber, ulong aMaterial) => GetDelegate<SetMaterialColorAssignmentForStandardAxesDelegate>().Invoke(_nativePtr, aColorNumber, aMaterial);
  public ulong GetMaterialColorAssignmentForDrillings(uint aColorNumber) => GetDelegate<GetMaterialColorAssignmentForDrillingsDelegate>().Invoke(_nativePtr, aColorNumber);
  public void SetMaterialColorAssignmentForDrillings(uint aColorNumber, ulong aMaterial) => GetDelegate<SetMaterialColorAssignmentForDrillingsDelegate>().Invoke(_nativePtr, aColorNumber, aMaterial);
  public ulong GetMaterialColorAssignmentForMepAxes(uint aColorNumber) => GetDelegate<GetMaterialColorAssignmentForMepAxesDelegate>().Invoke(_nativePtr, aColorNumber);
  public void SetMaterialColorAssignmentForMepAxes(uint aColorNumber, ulong aMaterial) => GetDelegate<SetMaterialColorAssignmentForMepAxesDelegate>().Invoke(_nativePtr, aColorNumber, aMaterial);
  public ulong GetMaterialColorAssignmentForBeams(uint aColorNumber) => GetDelegate<GetMaterialColorAssignmentForBeamsDelegate>().Invoke(_nativePtr, aColorNumber);
  public void SetMaterialColorAssignmentForBeams(uint aColorNumber, ulong aMaterial) => GetDelegate<SetMaterialColorAssignmentForBeamsDelegate>().Invoke(_nativePtr, aColorNumber, aMaterial);
  public ulong GetMaterialColorAssignmentForPanels(uint aColorNumber) => GetDelegate<GetMaterialColorAssignmentForPanelsDelegate>().Invoke(_nativePtr, aColorNumber);
  public void SetMaterialColorAssignmentForPanels(uint aColorNumber, ulong aMaterial) => GetDelegate<SetMaterialColorAssignmentForPanelsDelegate>().Invoke(_nativePtr, aColorNumber, aMaterial);
  public ulong GetMaterialColorAssignmentForAuxiliaryElements(uint aColorNumber) => GetDelegate<GetMaterialColorAssignmentForAuxiliaryElementsDelegate>().Invoke(_nativePtr, aColorNumber);
  public void SetMaterialColorAssignmentForAuxiliaryElements(uint aColorNumber, ulong aMaterial) => GetDelegate<SetMaterialColorAssignmentForAuxiliaryElementsDelegate>().Invoke(_nativePtr, aColorNumber, aMaterial);
  public ulong GetMaterialColorAssignmentForSurfaces(uint aColorNumber) => GetDelegate<GetMaterialColorAssignmentForSurfacesDelegate>().Invoke(_nativePtr, aColorNumber);
  public void SetMaterialColorAssignmentForSurfaces(uint aColorNumber, ulong aMaterial) => GetDelegate<SetMaterialColorAssignmentForSurfacesDelegate>().Invoke(_nativePtr, aColorNumber, aMaterial);
  public int GetTextureColor(ulong aMaterialId) => GetDelegate<GetTextureColorDelegate>().Invoke(_nativePtr, aMaterialId);
  public void SetTextureColor(ulong aMaterialId, int aColor) => GetDelegate<SetTextureColorDelegate>().Invoke(_nativePtr, aMaterialId, aColor);
  public int GetTextureTransparency(ulong aMaterialId) => GetDelegate<GetTextureTransparencyDelegate>().Invoke(_nativePtr, aMaterialId);
  public void SetTextureTransparency(ulong aMaterialId, int aTransparency) => GetDelegate<SetTextureTransparencyDelegate>().Invoke(_nativePtr, aMaterialId, aTransparency);
  public double GetTextureRotationAngle(ulong aMaterialId) => GetDelegate<GetTextureRotationAngleDelegate>().Invoke(_nativePtr, aMaterialId);
  public void SetTextureRotationAngle(ulong aMaterialId, double aAngle) => GetDelegate<SetTextureRotationAngleDelegate>().Invoke(_nativePtr, aMaterialId, aAngle);
  public bool GetTextureLengthAlignment(ulong aMaterialId) => GetDelegate<GetTextureLengthAlignmentDelegate>().Invoke(_nativePtr, aMaterialId);
  public void SetTextureLengthAlignment(ulong aMaterialId, bool aLengthAlignment) => GetDelegate<SetTextureLengthAlignmentDelegate>().Invoke(_nativePtr, aMaterialId, aLengthAlignment);
  public double GetTextureZoomX(ulong aMaterialId) => GetDelegate<GetTextureZoomXDelegate>().Invoke(_nativePtr, aMaterialId);
  public void SetTextureZoomX(ulong aMaterialId, double aValue) => GetDelegate<SetTextureZoomXDelegate>().Invoke(_nativePtr, aMaterialId, aValue);
  public double GetTextureZoomY(ulong aMaterialId) => GetDelegate<GetTextureZoomYDelegate>().Invoke(_nativePtr, aMaterialId);
  public void SetTextureZoomY(ulong aMaterialId, double aValue) => GetDelegate<SetTextureZoomYDelegate>().Invoke(_nativePtr, aMaterialId, aValue);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class MaterialControllerInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr getLastErrorFunctionPtr;
    internal IntPtr createMaterialFunctionPtr;
    internal IntPtr getNameFunctionPtr;
    internal IntPtr setNameFunctionPtr;
    internal IntPtr getGroupFunctionPtr;
    internal IntPtr setGroupFunctionPtr;
    internal IntPtr getCodeFunctionPtr;
    internal IntPtr setCodeFunctionPtr;
    internal IntPtr getModulusElasticity1FunctionPtr;
    internal IntPtr setModulusElasticity1FunctionPtr;
    internal IntPtr getModulusElasticity2FunctionPtr;
    internal IntPtr setModulusElasticity2FunctionPtr;
    internal IntPtr getModulusElasticity3FunctionPtr;
    internal IntPtr setModulusElasticity3FunctionPtr;
    internal IntPtr getShearModulus1FunctionPtr;
    internal IntPtr setShearModulus1FunctionPtr;
    internal IntPtr getShearModulus2FunctionPtr;
    internal IntPtr setShearModulus2FunctionPtr;
    internal IntPtr getPriceFunctionPtr;
    internal IntPtr setPriceFunctionPtr;
    internal IntPtr getPriceTypeFunctionPtr;
    internal IntPtr setPriceTypeFunctionPtr;
    internal IntPtr getThermalConductivityFunctionPtr;
    internal IntPtr setThermalConductivityFunctionPtr;
    internal IntPtr getHeatCapacityFunctionPtr;
    internal IntPtr setHeatCapacityFunctionPtr;
    internal IntPtr getUMinFunctionPtr;
    internal IntPtr setUMinFunctionPtr;
    internal IntPtr getUMaxFunctionPtr;
    internal IntPtr setUMaxFunctionPtr;
    internal IntPtr getFireResistanceClassFunctionPtr;
    internal IntPtr setFireResistanceClassFunctionPtr;
    internal IntPtr getSmokeClassFunctionPtr;
    internal IntPtr setSmokeClassFunctionPtr;
    internal IntPtr getDropFormingClassFunctionPtr;
    internal IntPtr setDropFormingClassFunctionPtr;
    internal IntPtr getBurnOffRateFunctionPtr;
    internal IntPtr setBurnOffRateFunctionPtr;
    internal IntPtr getWeightFunctionPtr;
    internal IntPtr setWeightFunctionPtr;
    internal IntPtr getWeightTypeFunctionPtr;
    internal IntPtr setWeightTypeFunctionPtr;
    internal IntPtr getMaterialIDFunctionPtr;
    internal IntPtr getAllMaterialsFunctionPtr;
    internal IntPtr clearErrorsFunctionPtr;
    internal IntPtr getGradeFunctionPtr;
    internal IntPtr setGradeFunctionPtr;
    internal IntPtr getQualityFunctionPtr;
    internal IntPtr setQualityFunctionPtr;
    internal IntPtr getCompositionFunctionPtr;
    internal IntPtr setCompositionFunctionPtr;
    internal IntPtr getShortNameFunctionPtr;
    internal IntPtr getAllMaterialGroupsFunctionPtr;
    internal IntPtr getParentGroupFunctionPtr;
    internal IntPtr getMaterialColorAssignmentForNodesFunctionPtr;
    internal IntPtr setMaterialColorAssignmentForNodesFunctionPtr;
    internal IntPtr getMaterialColorAssignmentForStandardAxesFunctionPtr;
    internal IntPtr setMaterialColorAssignmentForStandardAxesFunctionPtr;
    internal IntPtr getMaterialColorAssignmentForDrillingsFunctionPtr;
    internal IntPtr setMaterialColorAssignmentForDrillingsFunctionPtr;
    internal IntPtr getMaterialColorAssignmentForMEPAxesFunctionPtr;
    internal IntPtr setMaterialColorAssignmentForMEPAxesFunctionPtr;
    internal IntPtr getMaterialColorAssignmentForBeamsFunctionPtr;
    internal IntPtr setMaterialColorAssignmentForBeamsFunctionPtr;
    internal IntPtr getMaterialColorAssignmentForPanelsFunctionPtr;
    internal IntPtr setMaterialColorAssignmentForPanelsFunctionPtr;
    internal IntPtr getMaterialColorAssignmentForAuxiliaryElementsFunctionPtr;
    internal IntPtr setMaterialColorAssignmentForAuxiliaryElementsFunctionPtr;
    internal IntPtr getMaterialColorAssignmentForSurfacesFunctionPtr;
    internal IntPtr setMaterialColorAssignmentForSurfacesFunctionPtr;
    internal IntPtr getTextureColorFunctionPtr;
    internal IntPtr setTextureColorFunctionPtr;
    internal IntPtr getTextureTransparencyFunctionPtr;
    internal IntPtr setTextureTransparencyFunctionPtr;
    internal IntPtr getTextureRotationAngleFunctionPtr;
    internal IntPtr setTextureRotationAngleFunctionPtr;
    internal IntPtr getTextureLengthAlignmentFunctionPtr;
    internal IntPtr setTextureLengthAlignmentFunctionPtr;
    internal IntPtr getTextureZoomXFunctionPtr;
    internal IntPtr setTextureZoomXFunctionPtr;
    internal IntPtr getTextureZoomYFunctionPtr;
    internal IntPtr setTextureZoomYFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetLastErrorDelegate(IntPtr thisPtr, IntPtr aErrorCode);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateMaterialDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetNameDelegate(IntPtr thisPtr, ulong aMaterialId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetNameDelegate(IntPtr thisPtr, ulong aMaterialId, [MarshalAs(UnmanagedType.LPWStr)] string aName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetGroupDelegate(IntPtr thisPtr, ulong aMaterialId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetGroupDelegate(IntPtr thisPtr, ulong aMaterialId, [MarshalAs(UnmanagedType.LPWStr)] string aGroup);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetCodeDelegate(IntPtr thisPtr, ulong aMaterialId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCodeDelegate(IntPtr thisPtr, ulong aMaterialId, [MarshalAs(UnmanagedType.LPWStr)] string aCode);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetModulusElasticity1Delegate(IntPtr thisPtr, ulong aMaterialId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetModulusElasticity1Delegate(IntPtr thisPtr, ulong aMaterialId, double aModulusElasticity1);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetModulusElasticity2Delegate(IntPtr thisPtr, ulong aMaterialId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetModulusElasticity2Delegate(IntPtr thisPtr, ulong aMaterialId, double aModulusElasticity2);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetModulusElasticity3Delegate(IntPtr thisPtr, ulong aMaterialId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetModulusElasticity3Delegate(IntPtr thisPtr, ulong aMaterialId, double aModulusElasticity3);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetShearModulus1Delegate(IntPtr thisPtr, ulong aMaterialId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetShearModulus1Delegate(IntPtr thisPtr, ulong aMaterialId, double aShearModulus1);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetShearModulus2Delegate(IntPtr thisPtr, ulong aMaterialId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetShearModulus2Delegate(IntPtr thisPtr, ulong aMaterialId, double aShearModulus2);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetPriceDelegate(IntPtr thisPtr, ulong aMaterialId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetPriceDelegate(IntPtr thisPtr, ulong aMaterialId, double aPrice);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetPriceTypeDelegate(IntPtr thisPtr, ulong aMaterialId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetPriceTypeDelegate(IntPtr thisPtr, ulong aMaterialId, [MarshalAs(UnmanagedType.LPWStr)] string aPriceType);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetThermalConductivityDelegate(IntPtr thisPtr, ulong aMaterialId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetThermalConductivityDelegate(IntPtr thisPtr, ulong aMaterialId, double aThermalConductivity);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetHeatCapacityDelegate(IntPtr thisPtr, ulong aMaterialId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetHeatCapacityDelegate(IntPtr thisPtr, ulong aMaterialId, double aHeatCapacity);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetUMinDelegate(IntPtr thisPtr, ulong aMaterialId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetUMinDelegate(IntPtr thisPtr, ulong aMaterialId, double aUMin);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetUMaxDelegate(IntPtr thisPtr, ulong aMaterialId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetUMaxDelegate(IntPtr thisPtr, ulong aMaterialId, double aUMax);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetFireResistanceClassDelegate(IntPtr thisPtr, ulong aMaterialId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetFireResistanceClassDelegate(IntPtr thisPtr, ulong aMaterialId, [MarshalAs(UnmanagedType.LPWStr)] string aFireResistanceClass);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetSmokeClassDelegate(IntPtr thisPtr, ulong aMaterialId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetSmokeClassDelegate(IntPtr thisPtr, ulong aMaterialId, [MarshalAs(UnmanagedType.LPWStr)] string aSmokeClass);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetDropFormingClassDelegate(IntPtr thisPtr, ulong aMaterialId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetDropFormingClassDelegate(IntPtr thisPtr, ulong aMaterialId, [MarshalAs(UnmanagedType.LPWStr)] string aDropFormingClass);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetBurnOffRateDelegate(IntPtr thisPtr, ulong aMaterialId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetBurnOffRateDelegate(IntPtr thisPtr, ulong aMaterialId, double aBurnOffRate);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetWeightDelegate(IntPtr thisPtr, ulong aMaterialId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetWeightDelegate(IntPtr thisPtr, ulong aMaterialId, double aWeight);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetWeightTypeDelegate(IntPtr thisPtr, ulong aMaterialId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetWeightTypeDelegate(IntPtr thisPtr, ulong aMaterialId, [MarshalAs(UnmanagedType.LPWStr)] string aWeightType);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong GetMaterialIdDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aMaterialName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAllMaterialsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ClearErrorsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetGradeDelegate(IntPtr thisPtr, ulong aMaterialId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetGradeDelegate(IntPtr thisPtr, ulong aMaterialId, [MarshalAs(UnmanagedType.LPWStr)] string aGrade);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetQualityDelegate(IntPtr thisPtr, ulong aMaterialId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetQualityDelegate(IntPtr thisPtr, ulong aMaterialId, [MarshalAs(UnmanagedType.LPWStr)] string aQuality);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetCompositionDelegate(IntPtr thisPtr, ulong aMaterialId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCompositionDelegate(IntPtr thisPtr, ulong aMaterialId, [MarshalAs(UnmanagedType.LPWStr)] string aComposition);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetShortNameDelegate(IntPtr thisPtr, ulong aMaterialId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAllMaterialGroupsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetParentGroupDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aGroup);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong GetMaterialColorAssignmentForNodesDelegate(IntPtr thisPtr, uint aColorNumber);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetMaterialColorAssignmentForNodesDelegate(IntPtr thisPtr, uint aColorNumber, ulong aMaterial);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong GetMaterialColorAssignmentForStandardAxesDelegate(IntPtr thisPtr, uint aColorNumber);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetMaterialColorAssignmentForStandardAxesDelegate(IntPtr thisPtr, uint aColorNumber, ulong aMaterial);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong GetMaterialColorAssignmentForDrillingsDelegate(IntPtr thisPtr, uint aColorNumber);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetMaterialColorAssignmentForDrillingsDelegate(IntPtr thisPtr, uint aColorNumber, ulong aMaterial);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong GetMaterialColorAssignmentForMepAxesDelegate(IntPtr thisPtr, uint aColorNumber);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetMaterialColorAssignmentForMepAxesDelegate(IntPtr thisPtr, uint aColorNumber, ulong aMaterial);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong GetMaterialColorAssignmentForBeamsDelegate(IntPtr thisPtr, uint aColorNumber);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetMaterialColorAssignmentForBeamsDelegate(IntPtr thisPtr, uint aColorNumber, ulong aMaterial);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong GetMaterialColorAssignmentForPanelsDelegate(IntPtr thisPtr, uint aColorNumber);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetMaterialColorAssignmentForPanelsDelegate(IntPtr thisPtr, uint aColorNumber, ulong aMaterial);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong GetMaterialColorAssignmentForAuxiliaryElementsDelegate(IntPtr thisPtr, uint aColorNumber);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetMaterialColorAssignmentForAuxiliaryElementsDelegate(IntPtr thisPtr, uint aColorNumber, ulong aMaterial);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong GetMaterialColorAssignmentForSurfacesDelegate(IntPtr thisPtr, uint aColorNumber);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetMaterialColorAssignmentForSurfacesDelegate(IntPtr thisPtr, uint aColorNumber, ulong aMaterial);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate int GetTextureColorDelegate(IntPtr thisPtr, ulong aMaterialId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetTextureColorDelegate(IntPtr thisPtr, ulong aMaterialId, int aColor);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate int GetTextureTransparencyDelegate(IntPtr thisPtr, ulong aMaterialId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetTextureTransparencyDelegate(IntPtr thisPtr, ulong aMaterialId, int aTransparency);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetTextureRotationAngleDelegate(IntPtr thisPtr, ulong aMaterialId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetTextureRotationAngleDelegate(IntPtr thisPtr, ulong aMaterialId, double aAngle);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetTextureLengthAlignmentDelegate(IntPtr thisPtr, ulong aMaterialId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetTextureLengthAlignmentDelegate(IntPtr thisPtr, ulong aMaterialId, bool aLengthAlignment);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetTextureZoomXDelegate(IntPtr thisPtr, ulong aMaterialId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetTextureZoomXDelegate(IntPtr thisPtr, ulong aMaterialId, double aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetTextureZoomYDelegate(IntPtr thisPtr, ulong aMaterialId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetTextureZoomYDelegate(IntPtr thisPtr, ulong aMaterialId, double aValue);
}
