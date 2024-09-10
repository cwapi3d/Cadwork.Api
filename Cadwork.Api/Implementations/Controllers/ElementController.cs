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

internal class ElementController(ControllerFactoryWrapper factoryWrapper) : IElementController
{
  private readonly ElementControllerWrapper _controllerWrapper = new(factoryWrapper.GetElementController());

  public CoordinateSystemData GetCoordinateSystemDataNestingChild(ElementId nestingParentElementId, ElementId nestingChildElementId)
  {
    return _controllerWrapper.GetCoordinateSystemDataNestingChild(nestingParentElementId, nestingChildElementId).ToManagedCoordinateSystemData();
  }

  public ElementId ConvertSurfacesToVolume(ICollection<ulong> elementIds)
  {
    return _controllerWrapper.ConvertSurfacesToVolume(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public ElementId CreateAutoContainerFromStandard(ICollection<ulong> elementIds, string outputName, string standardElementName)
  {
    return _controllerWrapper.CreateAutoContainerFromStandard(elementIds.ToNativeElementIdList(factoryWrapper), outputName, standardElementName);
  }

  public ElementId CreateAutoContainerFromStandardWithReference(ICollection<ulong> elementIds, string outputName, string standardElementName, ElementId referenceElementId)
  {
    return _controllerWrapper.CreateAutoContainerFromStandardWithReference(elementIds.ToNativeElementIdList(factoryWrapper), outputName, standardElementName, referenceElementId);
  }

  public ElementId CreateAutoExportSolidFromStandard(ICollection<ulong> elementIds, string outputName, string standardElementName)
  {
    return _controllerWrapper.CreateAutoExportSolidFromStandard(elementIds.ToNativeElementIdList(factoryWrapper), outputName, standardElementName);
  }

  public ElementId CreateAutoExportSolidFromStandardWithReference(ICollection<ulong> elementIds, string outputName, string standardElementName, ElementId referenceElementId)
  {
    return _controllerWrapper.CreateAutoExportSolidFromStandardWithReference(elementIds.ToNativeElementIdList(factoryWrapper), outputName, standardElementName, referenceElementId);
  }

  public ElementId CreateBoundingBoxGlobal(ICollection<ulong> elementIds)
  {
    return _controllerWrapper.CreateBoundingBoxGlobal(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public ElementId CreateBoundingBoxLocal(ElementId referenceElementId, ICollection<ulong> elementIds)
  {
    return _controllerWrapper.CreateBoundingBoxLocal(referenceElementId, elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public ElementId CreateCircularAxisPoints(double diameter, Vec3 p1, Vec3 p2)
  {
    return _controllerWrapper.CreateCircularAxisPoints(diameter, p1.ToNativeVector(), p2.ToNativeVector());
  }

  public ElementId CreateCircularAxisVector(double diameter, double length, Vec3 p1, Vec3 xl)
  {
    return _controllerWrapper.CreateCircularAxisVector(diameter, length, p1.ToNativeVector(), xl.ToNativeVector());
  }

  public ElementId CreateCircularBeamPoints(double diameter, Vec3 p1, Vec3 p2, Vec3 p3)
  {
    return _controllerWrapper.CreateCircularBeamPoints(diameter, p1.ToNativeVector(), p2.ToNativeVector(), p3.ToNativeVector());
  }

  public ElementId CreateCircularBeamVectors(double diameter, double length, Vec3 p1, Vec3 xl, Vec3 zl)
  {
    return _controllerWrapper.CreateCircularBeamVectors(diameter, length, p1.ToNativeVector(), xl.ToNativeVector(), zl.ToNativeVector());
  }

  public ElementId CreateCircularMep(double diameter, ICollection<Vec3> points)
  {
    return _controllerWrapper.CreateCircularMep(diameter, points.ToNativeVectorList(factoryWrapper));
  }

  public ElementId CreateDrillingPoints(double diameter, Vec3 p1, Vec3 p2)
  {
    return _controllerWrapper.CreateDrillingPoints(diameter, p1.ToNativeVector(), p2.ToNativeVector());
  }

  public ElementId CreateDrillingVectors(double diameter, double length, Vec3 p1, Vec3 xl)
  {
    return _controllerWrapper.CreateDrillingVectors(diameter, length, p1.ToNativeVector(), xl.ToNativeVector());
  }

  public ElementId CreateLinePoints(Vec3 p1, Vec3 p2)
  {
    return _controllerWrapper.CreateLinePoints(p1.ToNativeVector(), p2.ToNativeVector());
  }

  public ElementId CreateLineVectors(double length, Vec3 p1, Vec3 xl)
  {
    return _controllerWrapper.CreateLineVectors(length, p1.ToNativeVector(), xl.ToNativeVector());
  }

  public ElementId CreateLinearOptimization(ICollection<ulong> elementIds, uint optimizationNumber, double totalLength, double startCut, double endCut, double sawKerf, bool isProductionList)
  {
    return _controllerWrapper.CreateLinearOptimization(elementIds.ToNativeElementIdList(factoryWrapper), optimizationNumber, totalLength, startCut, endCut, sawKerf, isProductionList);
  }

  public ElementId CreateNode(Vec3 p1)
  {
    return _controllerWrapper.CreateNode(p1.ToNativeVector());
  }

  public ElementId CreateNormalAxisPoints(Vec3 p1, Vec3 p2)
  {
    return _controllerWrapper.CreateNormalAxisPoints(p1.ToNativeVector(), p2.ToNativeVector());
  }

  public ElementId CreateNormalAxisVectors(double length, Vec3 p1, Vec3 xl)
  {
    return _controllerWrapper.CreateNormalAxisVectors(length, p1.ToNativeVector(), xl.ToNativeVector());
  }

  public ElementId CreatePolygonBeam(ICollection<Vec3> vertices, double thickness, Vec3 xl, Vec3 zl)
  {
    return _controllerWrapper.CreatePolygonBeam(vertices.ToNativeVectorList(factoryWrapper), thickness, xl.ToNativeVector(), zl.ToNativeVector());
  }

  public ElementId CreatePolygonPanel(ICollection<Vec3> vertices, double thickness, Vec3 xl, Vec3 zl)
  {
    return _controllerWrapper.CreatePolygonPanel(vertices.ToNativeVectorList(factoryWrapper), thickness, xl.ToNativeVector(), zl.ToNativeVector());
  }

  public ElementId CreateRectangularBeamPoints(double width, double height, Vec3 p1, Vec3 p2, Vec3 p3)
  {
    return _controllerWrapper.CreateRectangularBeamPoints(width, height, p1.ToNativeVector(), p2.ToNativeVector(), p3.ToNativeVector());
  }

  public ElementId CreateRectangularBeamVectors(double width, double height, double length, Vec3 p1, Vec3 xl, Vec3 zl)
  {
    return _controllerWrapper.CreateRectangularBeamVectors(width, height, length, p1.ToNativeVector(), xl.ToNativeVector(), zl.ToNativeVector());
  }

  public ElementId CreateRectangularMep(double width, double depth, ICollection<Vec3> points)
  {
    return _controllerWrapper.CreateRectangularMep(width, depth, points.ToNativeVectorList(factoryWrapper));
  }

  public ElementId CreateRectangularPanelPoints(double width, double thickness, Vec3 p1, Vec3 p2, Vec3 p3)
  {
    return _controllerWrapper.CreateRectangularPanelPoints(width, thickness, p1.ToNativeVector(), p2.ToNativeVector(), p3.ToNativeVector());
  }

  public ElementId CreateRectangularPanelVectors(double width, double thickness, double length, Vec3 p1, Vec3 xl, Vec3 zl)
  {
    return _controllerWrapper.CreateRectangularPanelVectors(width, thickness, length, p1.ToNativeVector(), xl.ToNativeVector(), zl.ToNativeVector());
  }

  public ElementId CreateSplineLine(ICollection<Vec3> splinePoints)
  {
    return _controllerWrapper.CreateSplineLine(splinePoints.ToNativeVectorList(factoryWrapper));
  }

  public ElementId CreateSquareBeamPoints(double width, Vec3 p1, Vec3 p2, Vec3 p3)
  {
    return _controllerWrapper.CreateSquareBeamPoints(width, p1.ToNativeVector(), p2.ToNativeVector(), p3.ToNativeVector());
  }

  public ElementId CreateSquareBeamVectors(double width, double length, Vec3 p1, Vec3 xl, Vec3 zl) // TODO: Maybe separate vec and pos types
  {
    return _controllerWrapper.CreateSquareBeamVectors(width, length, p1.ToNativeVector(), xl.ToNativeVector(), zl.ToNativeVector());
  }

  public ElementId CreateStandardBeamPoints(string standardElementName, Vec3 p1, Vec3 p2, Vec3 p3)
  {
    return _controllerWrapper.CreateStandardBeamPoints(standardElementName, p1.ToNativeVector(), p2.ToNativeVector(), p3.ToNativeVector());
  }

  public ElementId CreateStandardBeamVectors(string standardElementName, double length, Vec3 p1, Vec3 xl, Vec3 zl)
  {
    return _controllerWrapper.CreateStandardBeamVectors(standardElementName, length, p1.ToNativeVector(), xl.ToNativeVector(), zl.ToNativeVector());
  }

  public ElementId CreateStandardElementFromGuidPoints(Guid guid, Vec3 p1, Vec3 p2, Vec3 p3)
  {
    return _controllerWrapper.CreateStandardElementFromGuidPoints(guid.ToString(), p1.ToNativeVector(), p2.ToNativeVector(), p3.ToNativeVector());
  }

  public ElementId CreateStandardElementFromGuidVectors(Guid guid, double length, Vec3 p1, Vec3 xl, Vec3 zl)
  {
    return _controllerWrapper.CreateStandardElementFromGuidVectors(guid.ToString(), length, p1.ToNativeVector(), xl.ToNativeVector(), zl.ToNativeVector());
  }

  public ElementId CreateStandardPanelPoints(string standardElementName, Vec3 p1, Vec3 p2, Vec3 p3)
  {
    return _controllerWrapper.CreateStandardPanelPoints(standardElementName, p1.ToNativeVector(), p2.ToNativeVector(), p3.ToNativeVector());
  }

  public ElementId CreateStandardPanelVectors(string standardElementName, double length, Vec3 p1, Vec3 xl, Vec3 zl)
  {
    return _controllerWrapper.CreateStandardPanelVectors(standardElementName, length, p1.ToNativeVector(), xl.ToNativeVector(), zl.ToNativeVector());
  }

  public ElementId CreateStandardSteelPoints(string standardElementName, Vec3 p1, Vec3 p2, Vec3 p3)
  {
    return _controllerWrapper.CreateStandardSteelPoints(standardElementName, p1.ToNativeVector(), p2.ToNativeVector(), p3.ToNativeVector());
  }

  public ElementId CreateStandardSteelVectors(string standardElementName, double length, Vec3 p1, Vec3 xl, Vec3 zl)
  {
    return _controllerWrapper.CreateStandardSteelVectors(standardElementName, length, p1.ToNativeVector(), xl.ToNativeVector(), zl.ToNativeVector());
  }

  public ElementId CreateSurface(ICollection<Vec3> vertices)
  {
    return _controllerWrapper.CreateSurface(vertices.ToNativeVectorList(factoryWrapper));
  }

  public ElementId CreateTextObject(string text, Vec3 p1, Vec3 xl, Vec3 zl, double size)
  {
    return _controllerWrapper.CreateTextObject(text, p1.ToNativeVector(), xl.ToNativeVector(), zl.ToNativeVector(), size);
  }

  public ElementId CreateTextObjectWithFont(string text, Vec3 p1, Vec3 xl, Vec3 zl, double size, string fontName)
  {
    return _controllerWrapper.CreateTextObjectWithFont(text, p1.ToNativeVector(), xl.ToNativeVector(), zl.ToNativeVector(), size, fontName);
  }

  public ElementId CreateTextObjectWithOptions(Vec3 p1, Vec3 xl, Vec3 zl, ITextObjectOptions textObjectOptions)
  {
    return _controllerWrapper.CreateTextObjectWithOptions(p1.ToNativeVector(), xl.ToNativeVector(), zl.ToNativeVector(), textObjectOptions.ToNativeTextObjectOptions(factoryWrapper));
  }

  public ElementId CreateTruncatedConeBeamPoints(double startDiameter, double endDiameter, Vec3 p1, Vec3 p2, Vec3 p3)
  {
    return _controllerWrapper.CreateTruncatedConeBeamPoints(startDiameter, endDiameter, p1.ToNativeVector(), p2.ToNativeVector(), p3.ToNativeVector());
  }

  public ElementId CreateTruncatedConeBeamVectors(double startDiameter, double endDiameter, double length, Vec3 p1, Vec3 xl, Vec3 zl)
  {
    return _controllerWrapper.CreateTruncatedConeBeamVectors(startDiameter, endDiameter, length, p1.ToNativeVector(), xl.ToNativeVector(), zl.ToNativeVector());
  }

  public ElementId ExtrudeSurfaceToAuxiliaryVector(ElementId elementId, Vec3 vector)
  {
    return _controllerWrapper.ExtrudeSurfaceToAuxiliaryVector(elementId, vector.ToNativeVector());
  }

  public ElementId ExtrudeSurfaceToBeamVector(ElementId elementId, Vec3 vector)
  {
    return _controllerWrapper.ExtrudeSurfaceToBeamVector(elementId, vector.ToNativeVector());
  }

  public ElementId ExtrudeSurfaceToPanelVector(ElementId elementId, Vec3 vector)
  {
    return _controllerWrapper.ExtrudeSurfaceToPanelVector(elementId, vector.ToNativeVector());
  }

  public ElementId GetElementFromCadworkGuid(Guid guid)
  {
    return _controllerWrapper.GetElementFromCadworkGuid(guid.ToString());
  }

  public ElementId GetNestingParentId(ElementId elementId)
  {
    return _controllerWrapper.GetNestingParentId(elementId);
  }

  public ElementId GetParentContainerId(ElementId elementId)
  {
    return _controllerWrapper.GetParentContainerId(elementId);
  }

  public ElementId GetReferenceElement(ElementId elementId)
  {
    return _controllerWrapper.GetReferenceElement(elementId);
  }

  public Guid GetElementCadworkGuid(ElementId elementId)
  {
    return _controllerWrapper.GetElementCadworkGuid(elementId).ToManagedGuid();
  }

  public ICollection<ulong> ActivateEnvelopesWithoutSituation() // TODO: Rename envelopes to RV
  {
    return _controllerWrapper.ActivateRvWithoutSituation().ToManagedElementIdList();
  }

  public ICollection<ulong> ActivatePartsWithoutSituation()
  {
    return _controllerWrapper.ActivatePartsWithoutSituation().ToManagedElementIdList();
  }

  public ICollection<ulong> CheckElementDuplicates(ICollection<ulong> elementIds)
  {
    return _controllerWrapper.CheckElementDuplicates(elementIds.ToNativeElementIdList(factoryWrapper)).ToManagedElementIdList();
  }

  public ICollection<ulong> ConvertLinesToSurfaces(ICollection<ulong> elementIds)
  {
    return _controllerWrapper.ConvertLinesToSurfaces(elementIds.ToNativeElementIdList(factoryWrapper)).ToManagedElementIdList();
  }

  public ICollection<ulong> CopyElements(ICollection<ulong> elementIds, Vec3 copyVector)
  {
    return _controllerWrapper.CopyElements(elementIds.ToNativeElementIdList(factoryWrapper), copyVector.ToNativeVector()).ToManagedElementIdList();
  }

  public ICollection<ulong> DeleteProcessesKeepCuttingBodies(ICollection<ulong> elementIds, bool keepCuttingElementsOnly)
  {
    return _controllerWrapper.DeleteProcessesKeepCuttingBodies(elementIds.ToNativeElementIdList(factoryWrapper), keepCuttingElementsOnly).ToManagedElementIdList();
  }

  public ICollection<ulong> GetActiveElementIds()
  {
    return _controllerWrapper.GetActiveIdentifiableElementIDs().ToManagedElementIdList();
  }

  public ICollection<ulong> GetAllElementIds()
  {
    return _controllerWrapper.GetAllIdentifiableElementIDs().ToManagedElementIdList();
  }

  public ICollection<ulong> GetAllNestingRawParts()
  {
    return _controllerWrapper.GetAllNestingRawParts().ToManagedElementIdList();
  }

  public ICollection<ulong> GetContainerContentElements(ElementId elementId)
  {
    return _controllerWrapper.GetContainerContentElements(elementId).ToManagedElementIdList();
  }

  public ICollection<ulong> GetElementsInContact(ElementId elementId)
  {
    return _controllerWrapper.GetElementsInContact(elementId).ToManagedElementIdList();
  }

  public ICollection<ulong> GetExportSolidContentElements(ElementId elementId)
  {
    return _controllerWrapper.GetExportSolidContentElements(elementId).ToManagedElementIdList();
  }

  public ICollection<ulong> GetInactiveElementIds()
  {
    return _controllerWrapper.GetInactiveAllIdentifiableElementIDs().ToManagedElementIdList();
  }

  public ICollection<ulong> GetInactiveVisibleElementIds()
  {
    return _controllerWrapper.GetInactiveVisibleIdentifiableElementIDs().ToManagedElementIdList();
  }

  public ICollection<ulong> GetHiddenElementIds()
  {
    return _controllerWrapper.GetInvisibleIdentifiableElementIDs().ToManagedElementIdList();
  }

  public ICollection<ulong> GetJoinedElements(ElementId elementId)
  {
    return _controllerWrapper.GetJoinedElements(elementId).ToManagedElementIdList();
  }

  public ICollection<ulong> GetOpeningVariantIds(ICollection<ulong> elementIds, int openingType) // TODO: Remove magic
  {
    return _controllerWrapper.GetOpeningVariantIDs(elementIds.ToNativeElementIdList(factoryWrapper), openingType).ToManagedElementIdList();
  }

  public ICollection<ulong> GetUserElementIds()
  {
    return _controllerWrapper.GetUserElementIDs().ToManagedElementIdList();
  }

  public ICollection<ulong> GetUserElementIdsWithCount(ulong count)
  {
    return _controllerWrapper.GetUserElementIDsWithCount(count).ToManagedElementIdList();
  }

  public ICollection<ulong> GetUserElementIdsWithExisting(ICollection<ulong> elementIds)
  {
    return _controllerWrapper.GetUserElementIDsWithExisting(elementIds.ToNativeElementIdList(factoryWrapper)).ToManagedElementIdList();
  }

  public ICollection<ulong> GetVariantSiblingElementIds(ElementId elementId)
  {
    return _controllerWrapper.GetVariantSiblingElementIDs(elementId).ToManagedElementIdList();
  }

  public ICollection<ulong> GetVisibleElementIds()
  {
    return _controllerWrapper.GetVisibleIdentifiableElementIDs().ToManagedElementIdList();
  }

  public ICollection<ulong> MirrorCopyElements(ICollection<ulong> elementIds, Vec3 plane, double planeDistance)
  {
    return _controllerWrapper.MirrorCopyElements(elementIds.ToNativeElementIdList(factoryWrapper), plane.ToNativeVector(), planeDistance).ToManagedElementIdList();
  }

  public ICollection<ulong> ReplacePhysicalHolesWithDrillingAxes(ICollection<ulong> elementIds, double minimumDiameter, double maximumDiameter)
  {
    return _controllerWrapper.ReplacePhysicalDrillingsWithDrillingAxes(elementIds.ToNativeElementIdList(factoryWrapper), minimumDiameter, maximumDiameter).ToManagedElementIdList();
  }

  public ICollection<ulong> SliceElementWithPlaneAndGetNewElements(ElementId elementId, Vec3 cutPlaneNormalVector, double distanceFromGlobalOrigin)
  {
    return _controllerWrapper.SliceElementWithPlaneAndGetNewElements(elementId, cutPlaneNormalVector.ToNativeVector(), distanceFromGlobalOrigin).ToManagedElementIdList();
  }

  public ICollection<ulong> SolderElements(ICollection<ulong> elementIds)
  {
    return _controllerWrapper.SolderElements(elementIds.ToNativeElementIdList(factoryWrapper)).ToManagedElementIdList();
  }

  public ICollection<ulong> SubtractElements(ICollection<ulong> hardElementIds, ICollection<ulong> softElementIds)
  {
    return _controllerWrapper.SubtractElements(hardElementIds.ToNativeElementIdList(factoryWrapper), softElementIds.ToNativeElementIdList(factoryWrapper)).ToManagedElementIdList();
  }

  public ICollection<ulong> SubtractElementsWithUndo(ICollection<ulong> hardElementIds, ICollection<ulong> softElementIds, bool withUndo)
  {
    return _controllerWrapper.SubtractElementsWithUndo(hardElementIds.ToNativeElementIdList(factoryWrapper), softElementIds.ToNativeElementIdList(factoryWrapper), withUndo).ToManagedElementIdList();
  }

  public ICollection<IEdge> GetEdgeSelection(ICollection<ulong> elementIds)
  {
    return _controllerWrapper.GetEdgeSelection(elementIds.ToNativeElementIdList(factoryWrapper)).ToManagedEdgeList();
  }

  public ICollection<IFacet> GetElementContactFacets(ElementId firstElementId, ElementId secondElementId)
  {
    return _controllerWrapper.GetElementContactFacets(firstElementId, secondElementId).ToManagedFacetList();
  }

  public ICollection<IFacet> GetFacetsWithLasso(ICollection<ulong> elementIds)
  {
    return _controllerWrapper.GetFacetsWithLasso(elementIds.ToNativeElementIdList(factoryWrapper)).ToManagedFacetList();
  }

  public ICollection<Vec3> GetBoundingBoxVerticesGlobal(ICollection<ulong> elementIds)
  {
    return _controllerWrapper.GetBoundingBoxVerticesGlobal(elementIds.ToNativeElementIdList(factoryWrapper)).ToManagedVectorList();
  }

  public ICollection<Vec3> GetBoundingBoxVerticesLocal(ElementId referenceElementId, ICollection<ulong> elementIds)
  {
    return _controllerWrapper.GetBoundingBoxVerticesLocal(referenceElementId, elementIds.ToNativeElementIdList(factoryWrapper)).ToManagedVectorList();
  }

  public ICollection<Vec3> GetElementContactVertices(ElementId firstElementId, ElementId secondElementId)
  {
    return _controllerWrapper.GetElementContactVertices(firstElementId, secondElementId).ToManagedVectorList();
  }

  public ICollection<Vec3> GetElementRawInterfaceVertices(ElementId firstElementId, ElementId secondElementId)
  {
    return _controllerWrapper.GetElementRawInterfaceVertices(firstElementId, secondElementId).ToManagedVectorList();
  }

  public ICollection<string> GetStandardBeamList()
  {
    return _controllerWrapper.GetStandardBeamList().ToManagedStringList();
  }

  public ICollection<string> GetStandardContainerList()
  {
    return _controllerWrapper.GetStandardContainerList().ToManagedStringList();
  }

  public ICollection<string> GetStandardExportSolidList()
  {
    return _controllerWrapper.GetStandardExportSolidList().ToManagedStringList();
  }

  public ICollection<string> GetStandardPanelList()
  {
    return _controllerWrapper.GetStandardPanelList().ToManagedStringList();
  }

  public IElementModuleProperties GetElementModulePropertiesForElement(ElementId elementId)
  {
    return _controllerWrapper.GetElementModulePropertiesForElement(elementId).ToManagedElementModule();
  }

  public IError GetLastError()
  {
    const int errorCode = 0;
    var errorMessage = _controllerWrapper.GetLastError(errorCode);
    return new Error { Code = errorCode, Message = errorMessage.ToManagedString() };
  }

  public bool CheckElementId(ElementId elementId)
  {
    return _controllerWrapper.CheckElementId(elementId);
  }

  public bool CheckIfElementsAreInCollision(ElementId firstElementId, ElementId secondElementId)
  {
    return _controllerWrapper.CheckIfElementsAreInCollision(firstElementId, secondElementId);
  }

  public bool CheckIfElementsAreInContact(ElementId firstElementId, ElementId secondElementId)
  {
    return _controllerWrapper.CheckIfElementsAreInContact(firstElementId, secondElementId);
  }

  public bool CheckIfPointIsInElement(Vec3 point, ElementId elementId)
  {
    return _controllerWrapper.CheckIfPointIsInElement(point.ToNativeVector(), elementId);
  }

  public bool CheckIfPointIsOnElement(Vec3 point, ElementId elementId)
  {
    return _controllerWrapper.CheckIfPointIsInElement(point.ToNativeVector(), elementId);
  }

  public bool CutElementWithPlane(ElementId elementId, Vec3 cutPlaneNormalVector, double distanceFromGlobalOrigin)
  {
    return _controllerWrapper.CutElementWithPlane(elementId, cutPlaneNormalVector.ToNativeVector(), distanceFromGlobalOrigin);
  }

  public bool CutElementsWithMiter(ElementId firstElementId, ElementId secondElementId)
  {
    return _controllerWrapper.CutElementsWithMiter(firstElementId, secondElementId);
  }

  public bool SliceElementWithPlane(ElementId elementId, Vec3 cutPlaneNormalVector, double distanceFromGlobalOrigin)
  {
    return _controllerWrapper.SliceElementWithPlane(elementId, cutPlaneNormalVector.ToNativeVector(), distanceFromGlobalOrigin);
  }

  public bool UnJoinElements(ICollection<ulong> elementIds)
  {
    return _controllerWrapper.UnJoinElements(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public bool UnJoinTopLevelElements(ICollection<ulong> elementIds)
  {
    return _controllerWrapper.UnJoinTopLevelElements(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public string GetElementDetailPath()
  {
    return _controllerWrapper.GetElementDetailPath().ToManagedString();
  }

  public string GetElementTypeDescription(ElementId elementId)
  {
    return _controllerWrapper.GetElementTypeDescription(elementId).ToManagedString();
  }

  public string StartStandardElementDialog(StandardElementType standardElementType)
  {
    return _controllerWrapper.StartStandardElementDialog(standardElementType.ToNativeStandardElementType()).ToManagedString();
  }

  public void AddCreatedElementsToUndo(ICollection<ulong> elementIds)
  {
    _controllerWrapper.AddCreatedElementsToUndo(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void AddElementsToDetail(ICollection<ulong> elementIds, ElementModuleDetailType detail)
  {
    _controllerWrapper.AddElementToDetail(elementIds.ToNativeElementIdList(factoryWrapper), detail.ToNativeElementModuleDetailsType());
  }

  public void AddElementsToUndo(ICollection<ulong> elementIds, UndoMessage message)
  {
    _controllerWrapper.AddElementsToUndo(elementIds.ToNativeElementIdList(factoryWrapper), message.ToNativeUndoMessage());
  }

  public void AddModifiedElementsToUndo(ICollection<ulong> elementIds)
  {
    _controllerWrapper.AddModifiedElementsToUndo(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void ApplyTransformationCoordinate(ICollection<ulong> elementIds, Vec3 oldPoint, Vec3 oldXl, Vec3 oldYl, Vec3 newPoint, Vec3 newXl, Vec3 newYl)
  {
    _controllerWrapper.ApplyTransformationCoordinate(elementIds.ToNativeElementIdList(factoryWrapper), oldPoint.ToNativeVector(), oldXl.ToNativeVector(), oldYl.ToNativeVector(), newPoint.ToNativeVector(), newXl.ToNativeVector(), newYl.ToNativeVector());
  }

  public void AutoSetPartsSituation(ICollection<ulong> elementIds)
  {
    _controllerWrapper.AutoSetPartsSituation(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void AutoSetRoughVolumeSituation(ICollection<ulong> elementIds)
  {
    _controllerWrapper.AutoSetRoughVolumeSituation(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void ChamferEdge(ElementId elementId, Vec3 startEdge, Vec3 endEdge, double length)
  {
    _controllerWrapper.ChamferEdge(elementId, startEdge.ToNativeVector(), endEdge.ToNativeVector(), length);
  }

  public void ClearErrors()
  {
    _controllerWrapper.ClearErrors();
  }

  public void ConvertAuxiliaryToBeam(ICollection<ulong> elementIds)
  {
    _controllerWrapper.ConvertAuxiliaryToBeam(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void ConvertAuxiliaryToPanel(ICollection<ulong> elementIds)
  {
    _controllerWrapper.ConvertAuxiliaryToPanel(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void ConvertBeamToPanel(ICollection<ulong> elementIds)
  {
    _controllerWrapper.ConvertBeamToPanel(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void ConvertBoltToStandardConnector(ICollection<ulong> elementIds, string standardElementName)
  {
    _controllerWrapper.ConvertBoltToStandardConnector(elementIds.ToNativeElementIdList(factoryWrapper), standardElementName);
  }

  public void ConvertCircularBeamToDrilling(ICollection<ulong> elementIds)
  {
    _controllerWrapper.ConvertCircularBeamToDrilling(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void ConvertContainerToContainerBlock(ICollection<ulong> elementIds)
  {
    _controllerWrapper.ConvertContainerToContainerBlock(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void ConvertDrillingToCircularBeam(ICollection<ulong> elementIds)
  {
    _controllerWrapper.ConvertDrillingToCircularBeam(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void ConvertElementsToAuxiliaryElements(ICollection<ulong> elementIds)
  {
    _controllerWrapper.ConvertElementsToAuxiliaryElements(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void ConvertPanelToBeam(ICollection<ulong> elementIds)
  {
    _controllerWrapper.ConvertPanelToBeam(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void ConvertSurfacesToRoofSurfaces(ICollection<ulong> elementIds, string roofName)
  {
    _controllerWrapper.ConvertSurfacesToRoofSurfaces(elementIds.ToNativeElementIdList(factoryWrapper), roofName);
  }

  public void CreateMultiWall(ICollection<ulong> elementIds)
  {
    _controllerWrapper.CreateMultiWall(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void CutBeamEndProfile(ICollection<ulong> elementIds, string profileName, bool onStartFace, bool onEndFace)
  {
    _controllerWrapper.CutBeamEndProfile(elementIds.ToNativeElementIdList(factoryWrapper), profileName, onStartFace, onEndFace);
  }

  public void CutCornerLap(ICollection<ulong> elementIds, double depth, double clearanceBase, double clearanceSide, double backCut, ulong drillingCount, double drillingDiameter, double drillingTolerance)
  {
    _controllerWrapper.CutCornerLap(elementIds.ToNativeElementIdList(factoryWrapper), depth, clearanceBase, clearanceSide, backCut, drillingCount, drillingDiameter, drillingTolerance);
  }

  public void CutCrossLap(ICollection<ulong> elementIds, double depth, double clearanceBase, double clearanceSide, ulong drillingCount, double drillingDiameter, double drillingTolerance)
  {
    _controllerWrapper.CutCrossLap(elementIds.ToNativeElementIdList(factoryWrapper), depth, clearanceBase, clearanceSide, drillingCount, drillingDiameter, drillingTolerance);
  }

  public void CutDiagonalCut(ICollection<ulong> elementIds, double length, double clearanceLength, ulong drillingCount, double drillingDiameter, double drillingTolerance)
  {
    _controllerWrapper.CutDiagonalCut(elementIds.ToNativeElementIdList(factoryWrapper), length, clearanceLength, drillingCount, drillingDiameter, drillingTolerance);
  }

  public void CutDoubleTenon(ICollection<ulong> elementIds, double firstDepth, double secondDepth, double clearance, double backCut, ulong drillingCount, double drillingDiameter, double drillingTolerance)
  {
    _controllerWrapper.CutDoubleTenon(elementIds.ToNativeElementIdList(factoryWrapper), firstDepth, secondDepth, clearance, backCut, drillingCount, drillingDiameter, drillingTolerance);
  }

  public void CutElementWithProcessingGroup(ElementId softElementId, ElementId processingGroupElementId)
  {
    _controllerWrapper.CutElementWithProcessingGroup(softElementId, processingGroupElementId);
  }

  public void CutElementsWithOverMeasure(ICollection<ulong> hardElementIds, ICollection<ulong> softElementIds)
  {
    _controllerWrapper.CutElementsWithOverMeasure(hardElementIds.ToNativeElementIdList(factoryWrapper), softElementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void CutHalfLap(ICollection<ulong> elementIds, double length, double clearanceLength, double clearanceDepth, ulong drillingCount, double drillingDiameter, double drillingTolerance)
  {
    _controllerWrapper.CutHalfLap(elementIds.ToNativeElementIdList(factoryWrapper), length, clearanceLength, clearanceDepth, drillingCount, drillingDiameter, drillingTolerance);
  }

  public void CutLogCornerJoint(string settingsName, ICollection<ulong> elementIds)
  {
    _controllerWrapper.CutLogCornerJoint(settingsName, elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void CutScarfDiagonal(ICollection<ulong> elementIds, double length, double depth, double clearanceLength, double clearanceDepth, ulong drillingCount, double drillingDiameter, double drillingTolerance)
  {
    _controllerWrapper.CutScarfDiagonal(elementIds.ToNativeElementIdList(factoryWrapper), length, depth, clearanceLength, clearanceDepth, drillingCount, drillingDiameter, drillingTolerance);
  }

  public void CutScarfStraight(ICollection<ulong> elementIds, double length, double depth, double clearanceLength, double clearanceDepth, double clearanceHook, ulong drillingCount, double drillingDiameter, double drillingTolerance)
  {
    _controllerWrapper.CutScarfStraight(elementIds.ToNativeElementIdList(factoryWrapper), length, depth, clearanceLength, clearanceDepth, clearanceHook, drillingCount, drillingDiameter, drillingTolerance);
  }

  public void CutScarfWithWedge(ICollection<ulong> elementIds, double length, double depth, double clearanceLength, double clearanceDepth, double wedgeWidth, ulong drillingCount, double drillingDiameter, double drillingTolerance)
  {
    _controllerWrapper.CutScarfWithWedge(elementIds.ToNativeElementIdList(factoryWrapper), length, depth, clearanceLength, clearanceDepth, wedgeWidth, drillingCount, drillingDiameter, drillingTolerance);
  }

  public void CutSimpleScarf(ICollection<ulong> elementIds, double length, double depth, double clearanceLength, double clearanceDepth, ulong drillingCount, double drillingDiameter, double drillingTolerance)
  {
    _controllerWrapper.CutSimpleScarf(elementIds.ToNativeElementIdList(factoryWrapper), length, depth, clearanceLength, clearanceDepth, drillingCount, drillingDiameter, drillingTolerance);
  }

  public void CutTLap(ICollection<ulong> elementIds, double depth, double clearanceBase, double clearanceSide, double backCut, ulong drillingCount, double drillingDiameter, double drillingTolerance)
  {
    _controllerWrapper.CutTLap(elementIds.ToNativeElementIdList(factoryWrapper), depth, clearanceBase, clearanceSide, backCut, drillingCount, drillingDiameter, drillingTolerance);
  }

  public void DeleteAllElementEndTypes(ICollection<ulong> elementIds)
  {
    _controllerWrapper.DeleteAllElementEndTypes(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void DeleteAllElementProcesses(ICollection<ulong> elementIds)
  {
    _controllerWrapper.DeleteAllElementProcesses(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void DeleteElements(ICollection<ulong> elementIds)
  {
    _controllerWrapper.DeleteElements(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void DeleteElementsWithUndo(ICollection<ulong> elementIds)
  {
    _controllerWrapper.DeleteElementsWithUndo(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void FilletEdge(ElementId elementId, Vec3 startEdge, Vec3 endEdge, double radius)
  {
    _controllerWrapper.FilletEdge(elementId, startEdge.ToNativeVector(), endEdge.ToNativeVector(), radius);
  }

  public void GlideElements(ICollection<ulong> elementIds, Vec3 glidePoint)
  {
    _controllerWrapper.GlideElements(elementIds.ToNativeElementIdList(factoryWrapper), glidePoint.ToNativeVector());
  }

  public void JoinElements(ICollection<ulong> elementIds)
  {
    _controllerWrapper.JoinElements(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void JoinTopLevelElements(ICollection<ulong> elementIds)
  {
    _controllerWrapper.JoinTopLevelElements(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void MakeRedo()
  {
    _controllerWrapper.MakeRedo();
  }

  public void MakeUndo()
  {
    _controllerWrapper.MakeUndo();
  }

  public void MirrorMoveElements(ICollection<ulong> elementIds, Vec3 plane, double planeDistance)
  {
    _controllerWrapper.MirrorMoveElements(elementIds.ToNativeElementIdList(factoryWrapper), plane.ToNativeVector(), planeDistance);
  }

  public void MoveElement(ICollection<ulong> elementIds, Vec3 vector)
  {
    _controllerWrapper.MoveElement(elementIds.ToNativeElementIdList(factoryWrapper), vector.ToNativeVector());
  }

  public void MoveElementWithUndo(ICollection<ulong> elementIds, Vec3 vector)
  {
    _controllerWrapper.MoveElementWithUndo(elementIds.ToNativeElementIdList(factoryWrapper), vector.ToNativeVector());
  }

  public void PartsSituationManual(ElementId envelopeElementId, ICollection<ulong> addedChildrenElementIds, ICollection<ulong> removedChildrenElementIds)
  {
    _controllerWrapper.PartsSituationManual(envelopeElementId, addedChildrenElementIds.ToNativeElementIdList(factoryWrapper), removedChildrenElementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void RecreateElements(ICollection<ulong> elementIds)
  {
    _controllerWrapper.RecreateElements(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void RemoveStandardBeam(Guid guid)
  {
    _controllerWrapper.RemoveStandardBeam(guid.ToString());
  }

  public void RemoveStandardConnectorAxis(Guid guid)
  {
    _controllerWrapper.RemoveStandardConnectorAxis(guid.ToString());
  }

  public void RemoveStandardContainer(Guid guid)
  {
    _controllerWrapper.RemoveStandardContainer(guid.ToString());
  }

  public void RemoveStandardExportSolid(Guid guid)
  {
    _controllerWrapper.RemoveStandardExportSolid(guid.ToString());
  }

  public void RemoveStandardPanel(Guid guid)
  {
    _controllerWrapper.RemoveStandardPanel(guid.ToString());
  }

  public void ResetElementCadworkGuid(ElementId elementId)
  {
    _controllerWrapper.ResetElementCadworkGuid(elementId);
  }

  public void RotateElements(ICollection<ulong> elementIds, Vec3 origin, Vec3 rotationAxis, double rotationAngle)
  {
    _controllerWrapper.RotateElements(elementIds.ToNativeElementIdList(factoryWrapper), origin.ToNativeVector(), rotationAxis.ToNativeVector(), rotationAngle);
  }

  public void RoughVolumeSituationManual(ElementId envelopeElementId, ICollection<ulong> addedPartnerElementIds, ICollection<ulong> removedPartnerElementIds)
  {
    _controllerWrapper.RoughVolumeSituationManual(envelopeElementId, addedPartnerElementIds.ToNativeElementIdList(factoryWrapper), removedPartnerElementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void SetContainerContents(ElementId containerElementId, ICollection<ulong> elementIds)
  {
    _controllerWrapper.SetContainerContents(containerElementId, elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void SetElementDetailPath(string path)
  {
    _controllerWrapper.SetElementDetailPath(path);
  }

  public void SetElementGroupMultiSelectMode()
  {
    _controllerWrapper.SetElementGroupMultiSelectMode();
  }

  public void SetElementGroupSingleSelectMode()
  {
    _controllerWrapper.SetElementGroupSingleSelectMode();
  }

  public void SetElementModulePropertiesForElements(ICollection<ulong> elementIds, IElementModuleProperties properties)
  {
    _controllerWrapper.SetElementModulePropertiesForElements(elementIds.ToNativeElementIdList(factoryWrapper), properties.ToNativeElementModule(factoryWrapper));
  }

  public void SetExportSolidContents(ElementId exportSolidElementId, ICollection<ulong> elementIds)
  {
    _controllerWrapper.SetExportSolidContents(exportSolidElementId, elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void SetLineToMarkingLine(ICollection<ulong> elementIds)
  {
    _controllerWrapper.SetLineToMarkingLine(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void SetLineToNormalLine(ICollection<ulong> elementIds)
  {
    _controllerWrapper.SetLineToNormalLine(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void SetParentOpeningVariantsOpeningAngle(ICollection<ulong> elementIds, double angle)
  {
    _controllerWrapper.SetParentOpeningVariantsOpeningAngle(elementIds.ToNativeElementIdList(factoryWrapper), angle);
  }

  public void SplitElements(ICollection<ulong> elementIds)
  {
    _controllerWrapper.SplitElements(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void StartElementModuleCalculation(ICollection<ulong> envelopeElementIds)
  {
    _controllerWrapper.StartElementModuleCalculation(envelopeElementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void StartElementModuleCalculationSilently(ICollection<ulong> envelopeElementIds)
  {
    _controllerWrapper.StartElementModuleCalculationSilently(envelopeElementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void StretchEndFace(ICollection<ulong> elementIds, Vec3 stretchVector)
  {
    _controllerWrapper.StretchEndFace(elementIds.ToNativeElementIdList(factoryWrapper), stretchVector.ToNativeVector());
  }

  public void StretchStartFace(ICollection<ulong> elementIds, Vec3 stretchVector)
  {
    _controllerWrapper.StretchStartFace(elementIds.ToNativeElementIdList(factoryWrapper), stretchVector.ToNativeVector());
  }
};
