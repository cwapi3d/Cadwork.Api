// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Extensions;
using Cadwork.Api.Implementations.Helpers;
using Cadwork.Api.Interfaces.Controllers;
using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Interop.Wrappers.Controllers;
using Cadwork.Api.Interop.Wrappers.Factories;

namespace Cadwork.Api.Implementations.Controllers;

using MaterialId = ulong;

internal class MaterialController(ControllerFactoryWrapper factoryWrapper) : IMaterialController
{
  private readonly ControllerFactoryWrapper _controllerFactoryWrapper = factoryWrapper;
  private readonly MaterialControllerWrapper _controllerWrapper = new(factoryWrapper.GetMaterialController());

  public ICollection<ulong> GetAllMaterials()
  {
    return _controllerWrapper.GetAllMaterials().ToManagedMaterialIdList();
  }

  public ICollection<string> GetAllMaterialGroups()
  {
    return _controllerWrapper.GetAllMaterialGroups().ToManagedStringList();
  }

  public IError GetLastError()
  {
    const int errorCode = 0;
    var errorMessage = _controllerWrapper.GetLastError(errorCode);
    return new Error { Code = errorCode, Message = errorMessage.ToManagedString() };
  }

  public MaterialId CreateMaterial(string name)
  {
    return _controllerWrapper.CreateMaterial(name);
  }

  public MaterialId GetMaterialColorAssignmentForAuxiliaryElements(uint colorNumber)
  {
    return _controllerWrapper.GetMaterialColorAssignmentForAuxiliaryElements(colorNumber);
  }

  public MaterialId GetMaterialColorAssignmentForBeams(uint colorNumber)
  {
    return _controllerWrapper.GetMaterialColorAssignmentForBeams(colorNumber);
  }

  public MaterialId GetMaterialColorAssignmentForDrillingAxes(uint colorNumber)
  {
    return _controllerWrapper.GetMaterialColorAssignmentForDrillings(colorNumber);
  }

  public MaterialId GetMaterialColorAssignmentForMepAxes(uint colorNumber)
  {
    return _controllerWrapper.GetMaterialColorAssignmentForMepAxes(colorNumber);
  }

  public MaterialId GetMaterialColorAssignmentForNodes(uint colorNumber)
  {
    return _controllerWrapper.GetMaterialColorAssignmentForNodes(colorNumber);
  }

  public MaterialId GetMaterialColorAssignmentForPanels(uint colorNumber)
  {
    return _controllerWrapper.GetMaterialColorAssignmentForPanels(colorNumber);
  }

  public MaterialId GetMaterialColorAssignmentForStandardAxes(uint colorNumber)
  {
    return _controllerWrapper.GetMaterialColorAssignmentForStandardAxes(colorNumber);
  }

  public MaterialId GetMaterialColorAssignmentForSurfaces(uint colorNumber)
  {
    return _controllerWrapper.GetMaterialColorAssignmentForSurfaces(colorNumber);
  }

  public MaterialId GetMaterialId(string name)
  {
    return _controllerWrapper.GetMaterialId(name);
  }

  public MaterialPriceType GetPriceType(MaterialId materialId)
  {
    return _controllerWrapper.GetPriceType(materialId).ToManagedMaterialPriceType();
  }

  public MaterialWeightType GetWeightType(MaterialId materialId)
  {
    return _controllerWrapper.GetWeightType(materialId).ToManagedMaterialWeightType();
  }

  public bool GetTextureLengthAlignment(MaterialId materialId)
  {
    return _controllerWrapper.GetTextureLengthAlignment(materialId);
  }

  public double GetBurnOffRate(MaterialId materialId)
  {
    return _controllerWrapper.GetBurnOffRate(materialId);
  }

  public double GetHeatCapacity(MaterialId materialId)
  {
    return _controllerWrapper.GetHeatCapacity(materialId);
  }

  public double GetModulusElasticity1(MaterialId materialId)
  {
    return _controllerWrapper.GetModulusElasticity1(materialId);
  }

  public double GetModulusElasticity2(MaterialId materialId)
  {
    return _controllerWrapper.GetModulusElasticity2(materialId);
  }

  public double GetModulusElasticity3(MaterialId materialId)
  {
    return _controllerWrapper.GetModulusElasticity3(materialId);
  }

  public double GetPrice(MaterialId materialId)
  {
    return _controllerWrapper.GetPrice(materialId);
  }

  public double GetShearModulus1(MaterialId materialId)
  {
    return _controllerWrapper.GetShearModulus1(materialId);
  }

  public double GetShearModulus2(MaterialId materialId)
  {
    return _controllerWrapper.GetShearModulus2(materialId);
  }

  public double GetTextureRotationAngle(MaterialId materialId)
  {
    return _controllerWrapper.GetTextureRotationAngle(materialId);
  }

  public double GetTextureZoomX(MaterialId materialId)
  {
    return _controllerWrapper.GetTextureZoomX(materialId);
  }

  public double GetTextureZoomY(MaterialId materialId)
  {
    return _controllerWrapper.GetTextureZoomY(materialId);
  }

  public double GetThermalConductivity(MaterialId materialId)
  {
    return _controllerWrapper.GetThermalConductivity(materialId);
  }

  public double GetUMax(MaterialId materialId)
  {
    return _controllerWrapper.GetUMax(materialId);
  }

  public double GetUMin(MaterialId materialId)
  {
    return _controllerWrapper.GetUMin(materialId);
  }

  public double GetWeight(MaterialId materialId)
  {
    return _controllerWrapper.GetWeight(materialId);
  }

  public int GetTextureColor(MaterialId materialId)
  {
    return _controllerWrapper.GetTextureColor(materialId);
  }

  public int GetTextureTransparency(MaterialId materialId)
  {
    return _controllerWrapper.GetTextureTransparency(materialId);
  }

  public string GetCode(MaterialId materialId)
  {
    return _controllerWrapper.GetCode(materialId).ToManagedString();
  }

  public string GetComposition(MaterialId materialId)
  {
    return _controllerWrapper.GetComposition(materialId).ToManagedString();
  }

  public string GetDropFormingClass(MaterialId materialId)
  {
    return _controllerWrapper.GetDropFormingClass(materialId).ToManagedString();
  }

  public string GetFireResistanceClass(MaterialId materialId)
  {
    return _controllerWrapper.GetFireResistanceClass(materialId).ToManagedString();
  }

  public string GetGrade(MaterialId materialId)
  {
    return _controllerWrapper.GetGrade(materialId).ToManagedString();
  }

  public string GetGroup(MaterialId materialId)
  {
    return _controllerWrapper.GetGroup(materialId).ToManagedString();
  }

  public string GetName(MaterialId materialId)
  {
    return _controllerWrapper.GetName(materialId).ToManagedString();
  }

  public string GetParentGroup(string group)
  {
    return _controllerWrapper.GetParentGroup(group).ToManagedString();
  }

  public string GetQuality(MaterialId materialId)
  {
    return _controllerWrapper.GetQuality(materialId).ToManagedString();
  }

  public string GetShortName(MaterialId materialId)
  {
    return _controllerWrapper.GetShortName(materialId).ToManagedString();
  }

  public string GetSmokeClass(MaterialId materialId)
  {
    return _controllerWrapper.GetSmokeClass(materialId).ToManagedString();
  }

  public void ClearErrors()
  {
    _controllerWrapper.ClearErrors();
  }

  public void SetBurnOffRate(MaterialId materialId, double burnOffRate)
  {
    _controllerWrapper.SetBurnOffRate(materialId, burnOffRate);
  }

  public void SetCode(MaterialId materialId, string code)
  {
    _controllerWrapper.SetCode(materialId, code);
  }

  public void SetComposition(MaterialId materialId, string composition)
  {
    _controllerWrapper.SetComposition(materialId, composition);
  }

  public void SetDropFormingClass(MaterialId materialId, string dropFormingClass)
  {
    _controllerWrapper.SetDropFormingClass(materialId, dropFormingClass);
  }

  public void SetFireResistanceClass(MaterialId materialId, string fireResistanceClass)
  {
    _controllerWrapper.SetFireResistanceClass(materialId, fireResistanceClass);
  }

  public void SetGrade(MaterialId materialId, string grade)
  {
    _controllerWrapper.SetGrade(materialId, grade);
  }

  public void SetGroup(MaterialId materialId, string group)
  {
    _controllerWrapper.SetGroup(materialId, group);
  }

  public void SetHeatCapacity(MaterialId materialId, double heatCapacity)
  {
    _controllerWrapper.SetHeatCapacity(materialId, heatCapacity);
  }

  public void SetMaterialColorAssignmentForAuxiliaryElements(uint colorNumber, MaterialId materialId)
  {
    _controllerWrapper.SetMaterialColorAssignmentForAuxiliaryElements(colorNumber, materialId);
  }

  public void SetMaterialColorAssignmentForBeams(uint colorNumber, MaterialId materialId)
  {
    _controllerWrapper.SetMaterialColorAssignmentForBeams(colorNumber, materialId);
  }

  public void SetMaterialColorAssignmentForDrillingAxes(uint colorNumber, MaterialId materialId)
  {
    _controllerWrapper.SetMaterialColorAssignmentForDrillings(colorNumber, materialId);
  }

  public void SetMaterialColorAssignmentForMepAxes(uint colorNumber, MaterialId materialId)
  {
    _controllerWrapper.SetMaterialColorAssignmentForMepAxes(colorNumber, materialId);
  }

  public void SetMaterialColorAssignmentForNodes(uint colorNumber, MaterialId materialId)
  {
    _controllerWrapper.SetMaterialColorAssignmentForNodes(colorNumber, materialId);
  }

  public void SetMaterialColorAssignmentForPanels(uint colorNumber, MaterialId materialId)
  {
    _controllerWrapper.SetMaterialColorAssignmentForPanels(colorNumber, materialId);
  }

  public void SetMaterialColorAssignmentForStandardAxes(uint colorNumber, MaterialId materialId)
  {
    _controllerWrapper.SetMaterialColorAssignmentForStandardAxes(colorNumber, materialId);
  }

  public void SetMaterialColorAssignmentForSurfaces(uint colorNumber, MaterialId materialId)
  {
    _controllerWrapper.SetMaterialColorAssignmentForSurfaces(colorNumber, materialId);
  }

  public void SetModulusElasticity1(MaterialId materialId, double modulus)
  {
    _controllerWrapper.SetModulusElasticity1(materialId, modulus);
  }

  public void SetModulusElasticity2(MaterialId materialId, double modulus)
  {
    _controllerWrapper.SetModulusElasticity2(materialId, modulus);
  }

  public void SetModulusElasticity3(MaterialId materialId, double modulus)
  {
    _controllerWrapper.SetModulusElasticity3(materialId, modulus);
  }

  public void SetName(MaterialId materialId, string name)
  {
    _controllerWrapper.SetName(materialId, name);
  }

  public void SetPrice(MaterialId materialId, double price)
  {
    _controllerWrapper.SetPrice(materialId, price);
  }

  public void SetPriceType(MaterialId materialId, MaterialPriceType priceType)
  {
    _controllerWrapper.SetPriceType(materialId, priceType.ToNativeMaterialPriceType());
  }

  public void SetQuality(MaterialId materialId, string quality)
  {
    _controllerWrapper.SetQuality(materialId, quality);
  }

  public void SetShearModulus1(MaterialId materialId, double modulus)
  {
    _controllerWrapper.SetShearModulus1(materialId, modulus);
  }

  public void SetShearModulus2(MaterialId materialId, double modulus)
  {
    _controllerWrapper.SetShearModulus2(materialId, modulus);
  }

  public void SetSmokeClass(MaterialId materialId, string smokeClass)
  {
    _controllerWrapper.SetSmokeClass(materialId, smokeClass);
  }

  public void SetTextureColor(MaterialId materialId, int colorNumber)
  {
    _controllerWrapper.SetTextureColor(materialId, colorNumber);
  }

  public void SetTextureLengthAlignment(MaterialId materialId, bool flag)
  {
    _controllerWrapper.SetTextureLengthAlignment(materialId, flag);
  }

  public void SetTextureRotationAngle(MaterialId materialId, double angle)
  {
    _controllerWrapper.SetTextureRotationAngle(materialId, angle);
  }

  public void SetTextureTransparency(MaterialId materialId, int transparency)
  {
    _controllerWrapper.SetTextureTransparency(materialId, transparency);
  }

  public void SetTextureZoomX(MaterialId materialId, double value)
  {
    _controllerWrapper.SetTextureZoomX(materialId, value);
  }

  public void SetTextureZoomY(MaterialId materialId, double value)
  {
    _controllerWrapper.SetTextureZoomY(materialId, value);
  }

  public void SetThermalConductivity(MaterialId materialId, double thermalConductivity)
  {
    _controllerWrapper.SetThermalConductivity(materialId, thermalConductivity);
  }

  public void SetUMax(MaterialId materialId, double uMax)
  {
    _controllerWrapper.SetUMax(materialId, uMax);
  }

  public void SetUMin(MaterialId materialId, double uMin)
  {
    _controllerWrapper.SetUMin(materialId, uMin);
  }

  public void SetWeight(MaterialId materialId, double weight)
  {
    _controllerWrapper.SetWeight(materialId, weight);
  }

  public void SetWeightType(MaterialId materialId, MaterialWeightType weightType)
  {
    _controllerWrapper.SetWeightType(materialId, weightType.ToNativeMaterialWeightType());
  }
};
