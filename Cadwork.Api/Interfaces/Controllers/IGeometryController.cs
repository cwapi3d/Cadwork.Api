// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Structs;

namespace Cadwork.Api.Interfaces.Controllers;

using ElementId = ulong;
using ReferenceSide = uint;

/// <summary>
/// 
/// </summary>
public interface IGeometryController
{
  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  ICollection<IFacet> GetElementFacets(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  ICollection<Vec3> GetDivisionZonePoints(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  ICollection<Vec3> GetElementReferenceFaceVertices(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  ICollection<Vec3> GetElementVertices(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  IError GetLastError();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  ReferenceSide GetReferenceSide(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  Vec3 GetCenterOfGravity(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <returns></returns>
  Vec3 GetCenterOfGravityForList(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <returns></returns>
  Vec3 GetCenterOfGravityForListConsideringMaterials(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  Vec3 GetLocalX();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  Vec3 GetLocalY();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  Vec3 GetLocalZ();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  Vec3 GetP1(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  Vec3 GetP2(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  Vec3 GetP3(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  Vec3 GetXl(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  Vec3 GetYl(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  Vec3 GetZl(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="firstFacet"></param>
  /// <param name="secondFacet"></param>
  /// <returns></returns>
  bool AreFacetsCoplanar(ICollection<Vec3> firstFacet, ICollection<Vec3> secondFacet);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool GetRoundMachineRoughPartNegativeHeight(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool GetRoundMachineRoughPartNegativeLength(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool GetRoundMachineRoughPartNegativeWidth(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool GetRoundMachineRoughPartPositiveHeight(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool GetRoundMachineRoughPartPositiveLength(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool GetRoundMachineRoughPartPositiveWidth(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetActualPhysicalVolume(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetAreaOfFrontFace(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetCrossCorrectionNegativeHeight(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetCrossCorrectionNegativeLength(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetCrossCorrectionNegativeWidth(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetCrossCorrectionPositiveHeight(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetCrossCorrectionPositiveLength(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetCrossCorrectionPositiveWidth(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <returns></returns>
  double GetDoorSurface(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetDrillingTolerance(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetElementReferenceFaceArea(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetEndHeightCutAngle(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetEndWidthCutAngle(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetHeight(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetLength(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetListHeight(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetListLength(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetListVolume(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetListWeight(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetListWidth(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="firstElementId"></param>
  /// <param name="secondElementId"></param>
  /// <returns></returns>
  double GetMinimumDistanceBetweenElements(ElementId firstElementId, ElementId secondElementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetOverHeight(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetOverLength(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetOverWidth(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetRoundingHeight(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetRoundingLength(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetRoundingWidth(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="guid"></param>
  /// <returns></returns>
  double GetStandardElementHeightFromGuid(Guid guid);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="name"></param>
  /// <returns></returns>
  double GetStandardElementHeightFromName(string name);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="guid"></param>
  /// <returns></returns>
  double GetStandardElementLengthFromGuid(Guid guid);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="name"></param>
  /// <returns></returns>
  double GetStandardElementLengthFromName(string name);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="guid"></param>
  /// <returns></returns>
  double GetStandardElementWidthFromGuid(Guid guid);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="name"></param>
  /// <returns></returns>
  double GetStandardElementWidthFromName(string name);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetStartHeightCutAngle(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetStartWidthCutAngle(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetTotalAreaOfAllFaces(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetVolume(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetWeight(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetWeightReal(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetWidth(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <returns></returns>
  double GetWindowSurface(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  uint GetElementFacetCount(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="scale"></param>
  /// <param name="origin"></param>
  void ApplyGlobalScale(ICollection<ElementId> elementIds, double scale, Vec3 origin);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void AutoRegenerateAxes(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void AutoRegenerateAxesSilently(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  void ClearErrors();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="point"></param>
  /// <param name="direction"></param>
  void CreateDivisionZone(ElementId elementId, Vec3 point, DivisionZoneDirection direction);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  void DeleteDivisionZone(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void InvertModel(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void RotateHeightAxis180(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="firstPoint"></param>
  /// <param name="secondPoint"></param>
  void RotateHeightAxis2Points(ICollection<ElementId> elementIds, Vec3 firstPoint, Vec3 secondPoint);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void RotateHeightAxis90(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void RotateLengthAxis180(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="firstPoint"></param>
  /// <param name="secondPoint"></param>
  void RotateLengthAxis2Points(ICollection<ElementId> elementIds, Vec3 firstPoint, Vec3 secondPoint);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void RotateLengthAxis90(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="value"></param>
  void SetCrossCorrectionNegativeHeight(ICollection<ElementId> elementIds, double value);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="value"></param>
  void SetCrossCorrectionNegativeLength(ICollection<ElementId> elementIds, double value);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="value"></param>
  void SetCrossCorrectionNegativeWidth(ICollection<ElementId> elementIds, double value);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="value"></param>
  void SetCrossCorrectionPositiveHeight(ICollection<ElementId> elementIds, double value);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="value"></param>
  void SetCrossCorrectionPositiveLength(ICollection<ElementId> elementIds, double value);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="value"></param>
  void SetCrossCorrectionPositiveWidth(ICollection<ElementId> elementIds, double value);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="tolerance"></param>
  void SetDrillingTolerance(ICollection<ElementId> elementIds, double tolerance);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="value"></param>
  void SetHeightReal(ICollection<ElementId> elementIds, double value);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="value"></param>
  void SetLengthReal(ICollection<ElementId> elementIds, double value);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="value"></param>
  void SetOverHeight(ICollection<ElementId> elementIds, double value);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="value"></param>
  void SetOverLength(ICollection<ElementId> elementIds, double value);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="value"></param>
  void SetOverWidth(ICollection<ElementId> elementIds, double value);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="value"></param>
  void SetRoundMachineRoughPartNegativeHeight(ICollection<ElementId> elementIds, bool value);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="value"></param>
  void SetRoundMachineRoughPartNegativeLength(ICollection<ElementId> elementIds, bool value);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="value"></param>
  void SetRoundMachineRoughPartNegativeWidth(ICollection<ElementId> elementIds, bool value);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="value"></param>
  void SetRoundMachineRoughPartPositiveHeight(ICollection<ElementId> elementIds, bool value);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="value"></param>
  void SetRoundMachineRoughPartPositiveLength(ICollection<ElementId> elementIds, bool value);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="value"></param>
  void SetRoundMachineRoughPartPositiveWidth(ICollection<ElementId> elementIds, bool value);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="value"></param>
  void SetRoundingHeight(ICollection<ElementId> elementIds, double value);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="value"></param>
  void SetRoundingLength(ICollection<ElementId> elementIds, double value);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="value"></param>
  void SetRoundingWidth(ICollection<ElementId> elementIds, double value);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="value"></param>
  void SetWidthReal(ICollection<ElementId> elementIds, double value);
};
