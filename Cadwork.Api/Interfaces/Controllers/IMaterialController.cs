// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Interfaces.Helpers;

namespace Cadwork.Api.Interfaces.Controllers;

using MaterialId = ulong;

/// <summary>
/// 
/// </summary>
public interface IMaterialController
{
  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  ICollection<MaterialId> GetAllMaterials();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  ICollection<string> GetAllMaterialGroups();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  IError GetLastError();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="name"></param>
  /// <returns></returns>
  MaterialId CreateMaterial(string name);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="colorNumber"></param>
  /// <returns></returns>
  MaterialId GetMaterialColorAssignmentForAuxiliaryElements(uint colorNumber);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="colorNumber"></param>
  /// <returns></returns>
  MaterialId GetMaterialColorAssignmentForBeams(uint colorNumber);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="colorNumber"></param>
  /// <returns></returns>
  MaterialId GetMaterialColorAssignmentForDrillingAxes(uint colorNumber);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="colorNumber"></param>
  /// <returns></returns>
  MaterialId GetMaterialColorAssignmentForMepAxes(uint colorNumber);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="colorNumber"></param>
  /// <returns></returns>
  MaterialId GetMaterialColorAssignmentForNodes(uint colorNumber);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="colorNumber"></param>
  /// <returns></returns>
  MaterialId GetMaterialColorAssignmentForPanels(uint colorNumber);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="colorNumber"></param>
  /// <returns></returns>
  MaterialId GetMaterialColorAssignmentForStandardAxes(uint colorNumber);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="colorNumber"></param>
  /// <returns></returns>
  MaterialId GetMaterialColorAssignmentForSurfaces(uint colorNumber);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="name"></param>
  /// <returns></returns>
  MaterialId GetMaterialId(string name);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <returns></returns>
  MaterialPriceType GetPriceType(MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <returns></returns>
  MaterialWeightType GetWeightType(MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <returns></returns>
  bool GetTextureLengthAlignment(MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <returns></returns>
  double GetBurnOffRate(MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <returns></returns>
  double GetHeatCapacity(MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <returns></returns>
  double GetModulusElasticity1(MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <returns></returns>
  double GetModulusElasticity2(MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <returns></returns>
  double GetModulusElasticity3(MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <returns></returns>
  double GetPrice(MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <returns></returns>
  double GetShearModulus1(MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <returns></returns>
  double GetShearModulus2(MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <returns></returns>
  double GetTextureRotationAngle(MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <returns></returns>
  double GetTextureZoomX(MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <returns></returns>
  double GetTextureZoomY(MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <returns></returns>
  double GetThermalConductivity(MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <returns></returns>
  double GetUMax(MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <returns></returns>
  double GetUMin(MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <returns></returns>
  double GetWeight(MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <returns></returns>
  int GetTextureColor(MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <returns></returns>
  int GetTextureTransparency(MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <returns></returns>
  string GetCode(MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <returns></returns>
  string GetComposition(MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <returns></returns>
  string GetDropFormingClass(MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <returns></returns>
  string GetFireResistanceClass(MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <returns></returns>
  string GetGrade(MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <returns></returns>
  string GetGroup(MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <returns></returns>
  string GetName(MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="group"></param>
  /// <returns></returns>
  string GetParentGroup(string group);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <returns></returns>
  string GetQuality(MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <returns></returns>
  string GetShortName(MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <returns></returns>
  string GetSmokeClass(MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  void ClearErrors();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <param name="burnOffRate"></param>
  void SetBurnOffRate(MaterialId materialId, double burnOffRate);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <param name="code"></param>
  void SetCode(MaterialId materialId, string code);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <param name="composition"></param>
  void SetComposition(MaterialId materialId, string composition);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <param name="dropFormingClass"></param>
  void SetDropFormingClass(MaterialId materialId, string dropFormingClass);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <param name="fireResistanceClass"></param>
  void SetFireResistanceClass(MaterialId materialId, string fireResistanceClass);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <param name="grade"></param>
  void SetGrade(MaterialId materialId, string grade);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <param name="group"></param>
  void SetGroup(MaterialId materialId, string group);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <param name="heatCapacity"></param>
  void SetHeatCapacity(MaterialId materialId, double heatCapacity);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="colorNumber"></param>
  /// <param name="materialId"></param>
  void SetMaterialColorAssignmentForAuxiliaryElements(uint colorNumber, MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="colorNumber"></param>
  /// <param name="materialId"></param>
  void SetMaterialColorAssignmentForBeams(uint colorNumber, MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="colorNumber"></param>
  /// <param name="materialId"></param>
  void SetMaterialColorAssignmentForDrillingAxes(uint colorNumber, MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="colorNumber"></param>
  /// <param name="materialId"></param>
  void SetMaterialColorAssignmentForMepAxes(uint colorNumber, MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="colorNumber"></param>
  /// <param name="materialId"></param>
  void SetMaterialColorAssignmentForNodes(uint colorNumber, MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="colorNumber"></param>
  /// <param name="materialId"></param>
  void SetMaterialColorAssignmentForPanels(uint colorNumber, MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="colorNumber"></param>
  /// <param name="materialId"></param>
  void SetMaterialColorAssignmentForStandardAxes(uint colorNumber, MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="colorNumber"></param>
  /// <param name="materialId"></param>
  void SetMaterialColorAssignmentForSurfaces(uint colorNumber, MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <param name="modulus"></param>
  void SetModulusElasticity1(MaterialId materialId, double modulus);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <param name="modulus"></param>
  void SetModulusElasticity2(MaterialId materialId, double modulus);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <param name="modulus"></param>
  void SetModulusElasticity3(MaterialId materialId, double modulus);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <param name="name"></param>
  void SetName(MaterialId materialId, string name);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <param name="price"></param>
  void SetPrice(MaterialId materialId, double price);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <param name="priceType"></param>
  void SetPriceType(MaterialId materialId, MaterialPriceType priceType);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <param name="quality"></param>
  void SetQuality(MaterialId materialId, string quality);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <param name="modulus"></param>
  void SetShearModulus1(MaterialId materialId, double modulus);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <param name="modulus"></param>
  void SetShearModulus2(MaterialId materialId, double modulus);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <param name="smokeClass"></param>
  void SetSmokeClass(MaterialId materialId, string smokeClass);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <param name="colorNumber"></param>
  void SetTextureColor(MaterialId materialId, int colorNumber);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <param name="flag"></param>
  void SetTextureLengthAlignment(MaterialId materialId, bool flag);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <param name="angle"></param>
  void SetTextureRotationAngle(MaterialId materialId, double angle);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <param name="transparency"></param>
  void SetTextureTransparency(MaterialId materialId, int transparency);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <param name="value"></param>
  void SetTextureZoomX(MaterialId materialId, double value);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <param name="value"></param>
  void SetTextureZoomY(MaterialId materialId, double value);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <param name="thermalConductivity"></param>
  void SetThermalConductivity(MaterialId materialId, double thermalConductivity);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <param name="uMax"></param>
  void SetUMax(MaterialId materialId, double uMax);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <param name="uMin"></param>
  void SetUMin(MaterialId materialId, double uMin);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <param name="weight"></param>
  void SetWeight(MaterialId materialId, double weight);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="materialId"></param>
  /// <param name="weightType"></param>
  void SetWeightType(MaterialId materialId, MaterialWeightType weightType);
};
