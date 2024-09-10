// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Extensions;
using Cadwork.Api.Implementations.Helpers;
using Cadwork.Api.Interfaces.Controllers;
using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Interop.Wrappers.Controllers;
using Cadwork.Api.Interop.Wrappers.Factories;
using Cadwork.Api.Structs;

namespace Cadwork.Api.Implementations.Controllers;

using ElementId = ulong;
using ReferenceSide = uint;

internal class GeometryController(ControllerFactoryWrapper factoryWrapper) : IGeometryController
{
  private readonly GeometryControllerWrapper _controllerWrapper = new(factoryWrapper.GetGeometryController());

  public ICollection<IFacet> GetElementFacets(ElementId elementId)
  {
    return _controllerWrapper.GetElementFacets(elementId).ToManagedFacetList();
  }

  public ICollection<Vec3> GetDivisionZonePoints(ElementId elementId)
  {
    return _controllerWrapper.GetDivisionZonePoints(elementId).ToManagedVectorList();
  }

  public ICollection<Vec3> GetElementReferenceFaceVertices(ElementId elementId)
  {
    return _controllerWrapper.GetElementReferenceFaceVertices(elementId).ToManagedVectorList();
  }

  public ICollection<Vec3> GetElementVertices(ElementId elementId)
  {
    return _controllerWrapper.GetElementVertices(elementId).ToManagedVectorList();
  }

  public IError GetLastError()
  {
    const int errorCode = 0;
    var errorMessage = _controllerWrapper.GetLastError(errorCode);
    return new Error { Code = errorCode, Message = errorMessage.ToManagedString() };
  }

  public ReferenceSide GetReferenceSide(ElementId elementId)
  {
    return _controllerWrapper.GetReferenceSide(elementId);
  }

  public Vec3 GetCenterOfGravity(ElementId elementId)
  {
    return _controllerWrapper.GetCenterOfGravity(elementId).ToManagedVector();
  }

  public Vec3 GetCenterOfGravityForList(ICollection<ulong> elementIds)
  {
    return _controllerWrapper.GetCenterOfGravityForList(elementIds.ToNativeElementIdList(factoryWrapper)).ToManagedVector();
  }

  public Vec3 GetCenterOfGravityForListConsideringMaterials(ICollection<ulong> elementIds)
  {
    return _controllerWrapper.GetCenterOfGravityForListConsideringMaterials(elementIds.ToNativeElementIdList(factoryWrapper)).ToManagedVector();
  }

  public Vec3 GetLocalX()
  {
    return _controllerWrapper.GetLocalX().ToManagedVector();
  }

  public Vec3 GetLocalY()
  {
    return _controllerWrapper.GetLocalY().ToManagedVector();
  }

  public Vec3 GetLocalZ()
  {
    return _controllerWrapper.GetLocalZ().ToManagedVector();
  }

  public Vec3 GetP1(ElementId elementId)
  {
    return _controllerWrapper.GetP1(elementId).ToManagedVector();
  }

  public Vec3 GetP2(ElementId elementId)
  {
    return _controllerWrapper.GetP2(elementId).ToManagedVector();
  }

  public Vec3 GetP3(ElementId elementId)
  {
    return _controllerWrapper.GetP3(elementId).ToManagedVector();
  }

  public Vec3 GetXl(ElementId elementId)
  {
    return _controllerWrapper.GetXl(elementId).ToManagedVector();
  }

  public Vec3 GetYl(ElementId elementId)
  {
    return _controllerWrapper.GetYl(elementId).ToManagedVector();
  }

  public Vec3 GetZl(ElementId elementId)
  {
    return _controllerWrapper.GetZl(elementId).ToManagedVector();
  }

  public bool AreFacetsCoplanar(ICollection<Vec3> firstFacet, ICollection<Vec3> secondFacet)
  {
    return _controllerWrapper.AreFacetsCoplanar(firstFacet.ToNativeVectorList(factoryWrapper), secondFacet.ToNativeVectorList(factoryWrapper));
  }

  public bool GetRoundMachineRoughPartNegativeHeight(ElementId elementId)
  {
    return _controllerWrapper.GetRoundMachineRoughPartNegativeHeight(elementId);
  }

  public bool GetRoundMachineRoughPartNegativeLength(ElementId elementId)
  {
    return _controllerWrapper.GetRoundMachineRoughPartNegativeLength(elementId);
  }

  public bool GetRoundMachineRoughPartNegativeWidth(ElementId elementId)
  {
    return _controllerWrapper.GetRoundMachineRoughPartNegativeWidth(elementId);
  }

  public bool GetRoundMachineRoughPartPositiveHeight(ElementId elementId)
  {
    return _controllerWrapper.GetRoundMachineRoughPartPositiveHeight(elementId);
  }

  public bool GetRoundMachineRoughPartPositiveLength(ElementId elementId)
  {
    return _controllerWrapper.GetRoundMachineRoughPartPositiveLength(elementId);
  }

  public bool GetRoundMachineRoughPartPositiveWidth(ElementId elementId)
  {
    return _controllerWrapper.GetRoundMachineRoughPartPositiveWidth(elementId);
  }

  public double GetActualPhysicalVolume(ElementId elementId)
  {
    return _controllerWrapper.GetActualPhysicalVolume(elementId);
  }

  public double GetAreaOfFrontFace(ElementId elementId)
  {
    return _controllerWrapper.GetAreaOfFrontFace(elementId);
  }

  public double GetCrossCorrectionNegativeHeight(ElementId elementId)
  {
    return _controllerWrapper.GetCrossCorrectionNegativeHeight(elementId);
  }

  public double GetCrossCorrectionNegativeLength(ElementId elementId)
  {
    return _controllerWrapper.GetCrossCorrectionNegativeLength(elementId);
  }

  public double GetCrossCorrectionNegativeWidth(ElementId elementId)
  {
    return _controllerWrapper.GetCrossCorrectionNegativeWidth(elementId);
  }

  public double GetCrossCorrectionPositiveHeight(ElementId elementId)
  {
    return _controllerWrapper.GetCrossCorrectionPositiveHeight(elementId);
  }

  public double GetCrossCorrectionPositiveLength(ElementId elementId)
  {
    return _controllerWrapper.GetCrossCorrectionPositiveLength(elementId);
  }

  public double GetCrossCorrectionPositiveWidth(ElementId elementId)
  {
    return _controllerWrapper.GetCrossCorrectionPositiveWidth(elementId);
  }

  public double GetDoorSurface(ICollection<ulong> elementIds)
  {
    return _controllerWrapper.GetDoorSurface(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public double GetDrillingTolerance(ElementId elementId)
  {
    return _controllerWrapper.GetDrillingTolerance(elementId);
  }

  public double GetElementReferenceFaceArea(ElementId elementId)
  {
    return _controllerWrapper.GetElementReferenceFaceArea(elementId);
  }

  public double GetEndHeightCutAngle(ElementId elementId)
  {
    return _controllerWrapper.GetEndHeightCutAngle(elementId);
  }

  public double GetEndWidthCutAngle(ElementId elementId)
  {
    return _controllerWrapper.GetEndWidthCutAngle(elementId);
  }

  public double GetHeight(ElementId elementId)
  {
    return _controllerWrapper.GetHeight(elementId);
  }

  public double GetLength(ElementId elementId)
  {
    return _controllerWrapper.GetLength(elementId);
  }

  public double GetListHeight(ElementId elementId)
  {
    return _controllerWrapper.GetListHeight(elementId);
  }

  public double GetListLength(ElementId elementId)
  {
    return _controllerWrapper.GetListLength(elementId);
  }

  public double GetListVolume(ElementId elementId)
  {
    return _controllerWrapper.GetListVolume(elementId);
  }

  public double GetListWeight(ElementId elementId)
  {
    return _controllerWrapper.GetListWeight(elementId);
  }

  public double GetListWidth(ElementId elementId)
  {
    return _controllerWrapper.GetListWidth(elementId);
  }

  public double GetMinimumDistanceBetweenElements(ElementId firstElementId, ElementId secondElementId)
  {
    return _controllerWrapper.GetMinimumDistanceBetweenElements(firstElementId, secondElementId);
  }

  public double GetOverHeight(ElementId elementId)
  {
    return _controllerWrapper.GetOverHeight(elementId);
  }

  public double GetOverLength(ElementId elementId)
  {
    return _controllerWrapper.GetOverLength(elementId);
  }

  public double GetOverWidth(ElementId elementId)
  {
    return _controllerWrapper.GetOverWidth(elementId);
  }

  public double GetRoundingHeight(ElementId elementId)
  {
    return _controllerWrapper.GetRoundingHeight(elementId);
  }

  public double GetRoundingLength(ElementId elementId)
  {
    return _controllerWrapper.GetRoundingLength(elementId);
  }

  public double GetRoundingWidth(ElementId elementId)
  {
    return _controllerWrapper.GetRoundingWidth(elementId);
  }

  public double GetStandardElementHeightFromGuid(Guid guid)
  {
    return _controllerWrapper.GetStandardElementHeightFromGuid(guid.ToString());
  }

  public double GetStandardElementHeightFromName(string name)
  {
    return _controllerWrapper.GetStandardElementHeightFromName(name);
  }

  public double GetStandardElementLengthFromGuid(Guid guid)
  {
    return _controllerWrapper.GetStandardElementLengthFromGuid(guid.ToString());
  }

  public double GetStandardElementLengthFromName(string name)
  {
    return _controllerWrapper.GetStandardElementLengthFromName(name);
  }

  public double GetStandardElementWidthFromGuid(Guid guid)
  {
    return _controllerWrapper.GetStandardElementWidthFromGuid(guid.ToString());
  }

  public double GetStandardElementWidthFromName(string name)
  {
    return _controllerWrapper.GetStandardElementWidthFromName(name);
  }

  public double GetStartHeightCutAngle(ElementId elementId)
  {
    return _controllerWrapper.GetStartHeightCutAngle(elementId);
  }

  public double GetStartWidthCutAngle(ElementId elementId)
  {
    return _controllerWrapper.GetStartWidthCutAngle(elementId);
  }

  public double GetTotalAreaOfAllFaces(ElementId elementId)
  {
    return _controllerWrapper.GetTotalAreaOfAllFaces(elementId);
  }

  public double GetVolume(ElementId elementId)
  {
    return _controllerWrapper.GetVolume(elementId);
  }

  public double GetWeight(ElementId elementId)
  {
    return _controllerWrapper.GetWeight(elementId);
  }

  public double GetWeightReal(ElementId elementId)
  {
    return _controllerWrapper.GetWeightReal(elementId);
  }

  public double GetWidth(ElementId elementId)
  {
    return _controllerWrapper.GetWidth(elementId);
  }

  public double GetWindowSurface(ICollection<ulong> elementIds)
  {
    return _controllerWrapper.GetWindowSurface(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public uint GetElementFacetCount(ElementId elementId)
  {
    return _controllerWrapper.GetElementFacetCount(elementId);
  }

  public void ApplyGlobalScale(ICollection<ulong> elementIds, double scale, Vec3 origin)
  {
    _controllerWrapper.ApplyGlobalScale(elementIds.ToNativeElementIdList(factoryWrapper), scale, origin.ToNativeVector());
  }

  public void AutoRegenerateAxes(ICollection<ulong> elementIds)
  {
    _controllerWrapper.AutoRegenerateAxes(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void AutoRegenerateAxesSilently(ICollection<ulong> elementIds)
  {
    _controllerWrapper.AutoRegenerateAxesSilently(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void ClearErrors()
  {
    _controllerWrapper.ClearErrors();
  }

  public void CreateDivisionZone(ElementId elementId, Vec3 point, DivisionZoneDirection direction)
  {
    _controllerWrapper.CreateDivisionZone(elementId, point.ToNativeVector(), direction.ToNativeDivisionZoneDirection());
  }

  public void DeleteDivisionZone(ElementId elementId)
  {
    _controllerWrapper.DeleteDivisionZone(elementId);
  }

  public void InvertModel(ICollection<ulong> elementIds)
  {
    _controllerWrapper.InvertModel(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void RotateHeightAxis180(ICollection<ulong> elementIds)
  {
    _controllerWrapper.RotateHeightAxis180(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void RotateHeightAxis2Points(ICollection<ulong> elementIds, Vec3 firstPoint, Vec3 secondPoint)
  {
    _controllerWrapper.RotateHeightAxis2Points(elementIds.ToNativeElementIdList(factoryWrapper), firstPoint.ToNativeVector(), secondPoint.ToNativeVector());
  }

  public void RotateHeightAxis90(ICollection<ulong> elementIds)
  {
    _controllerWrapper.RotateHeightAxis90(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void RotateLengthAxis180(ICollection<ulong> elementIds)
  {
    _controllerWrapper.RotateLengthAxis180(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void RotateLengthAxis2Points(ICollection<ulong> elementIds, Vec3 firstPoint, Vec3 secondPoint)
  {
    _controllerWrapper.RotateLengthAxis2Points(elementIds.ToNativeElementIdList(factoryWrapper), firstPoint.ToNativeVector(), secondPoint.ToNativeVector());
  }

  public void RotateLengthAxis90(ICollection<ulong> elementIds)
  {
    _controllerWrapper.RotateLengthAxis90(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void SetCrossCorrectionNegativeHeight(ICollection<ulong> elementIds, double value)
  {
    _controllerWrapper.SetCrossCorrectionNegativeHeight(elementIds.ToNativeElementIdList(factoryWrapper), value);
  }

  public void SetCrossCorrectionNegativeLength(ICollection<ulong> elementIds, double value)
  {
    _controllerWrapper.SetCrossCorrectionNegativeLength(elementIds.ToNativeElementIdList(factoryWrapper), value);
  }

  public void SetCrossCorrectionNegativeWidth(ICollection<ulong> elementIds, double value)
  {
    _controllerWrapper.SetCrossCorrectionNegativeWidth(elementIds.ToNativeElementIdList(factoryWrapper), value);
  }

  public void SetCrossCorrectionPositiveHeight(ICollection<ulong> elementIds, double value)
  {
    _controllerWrapper.SetCrossCorrectionPositiveHeight(elementIds.ToNativeElementIdList(factoryWrapper), value);
  }

  public void SetCrossCorrectionPositiveLength(ICollection<ulong> elementIds, double value)
  {
    _controllerWrapper.SetCrossCorrectionPositiveLength(elementIds.ToNativeElementIdList(factoryWrapper), value);
  }

  public void SetCrossCorrectionPositiveWidth(ICollection<ulong> elementIds, double value)
  {
    _controllerWrapper.SetCrossCorrectionPositiveWidth(elementIds.ToNativeElementIdList(factoryWrapper), value);
  }

  public void SetDrillingTolerance(ICollection<ulong> elementIds, double tolerance)
  {
    _controllerWrapper.SetDrillingTolerance(elementIds.ToNativeElementIdList(factoryWrapper), tolerance);
  }

  public void SetHeightReal(ICollection<ulong> elementIds, double value)
  {
    _controllerWrapper.SetHeightReal(elementIds.ToNativeElementIdList(factoryWrapper), value);
  }

  public void SetLengthReal(ICollection<ulong> elementIds, double value)
  {
    _controllerWrapper.SetLengthReal(elementIds.ToNativeElementIdList(factoryWrapper), value);
  }

  public void SetOverHeight(ICollection<ulong> elementIds, double value)
  {
    _controllerWrapper.SetOverHeight(elementIds.ToNativeElementIdList(factoryWrapper), value);
  }

  public void SetOverLength(ICollection<ulong> elementIds, double value)
  {
    _controllerWrapper.SetOverLength(elementIds.ToNativeElementIdList(factoryWrapper), value);
  }

  public void SetOverWidth(ICollection<ulong> elementIds, double value)
  {
    _controllerWrapper.SetOverWidth(elementIds.ToNativeElementIdList(factoryWrapper), value);
  }

  public void SetRoundMachineRoughPartNegativeHeight(ICollection<ulong> elementIds, bool value)
  {
    _controllerWrapper.SetRoundMachineRoughPartNegativeHeight(elementIds.ToNativeElementIdList(factoryWrapper), value);
  }

  public void SetRoundMachineRoughPartNegativeLength(ICollection<ulong> elementIds, bool value)
  {
    _controllerWrapper.SetRoundMachineRoughPartNegativeLength(elementIds.ToNativeElementIdList(factoryWrapper), value);
  }

  public void SetRoundMachineRoughPartNegativeWidth(ICollection<ulong> elementIds, bool value)
  {
    _controllerWrapper.SetRoundMachineRoughPartNegativeWidth(elementIds.ToNativeElementIdList(factoryWrapper), value);
  }

  public void SetRoundMachineRoughPartPositiveHeight(ICollection<ulong> elementIds, bool value)
  {
    _controllerWrapper.SetRoundMachineRoughPartPositiveHeight(elementIds.ToNativeElementIdList(factoryWrapper), value);
  }

  public void SetRoundMachineRoughPartPositiveLength(ICollection<ulong> elementIds, bool value)
  {
    _controllerWrapper.SetRoundMachineRoughPartPositiveLength(elementIds.ToNativeElementIdList(factoryWrapper), value);
  }

  public void SetRoundMachineRoughPartPositiveWidth(ICollection<ulong> elementIds, bool value)
  {
    _controllerWrapper.SetRoundMachineRoughPartPositiveWidth(elementIds.ToNativeElementIdList(factoryWrapper), value);
  }

  public void SetRoundingHeight(ICollection<ulong> elementIds, double value)
  {
    _controllerWrapper.SetRoundingHeight(elementIds.ToNativeElementIdList(factoryWrapper), value);
  }

  public void SetRoundingLength(ICollection<ulong> elementIds, double value)
  {
    _controllerWrapper.SetRoundingLength(elementIds.ToNativeElementIdList(factoryWrapper), value);
  }

  public void SetRoundingWidth(ICollection<ulong> elementIds, double value)
  {
    _controllerWrapper.SetRoundingWidth(elementIds.ToNativeElementIdList(factoryWrapper), value);
  }

  public void SetWidthReal(ICollection<ulong> elementIds, double value)
  {
    _controllerWrapper.SetWidthReal(elementIds.ToNativeElementIdList(factoryWrapper), value);
  }
};
