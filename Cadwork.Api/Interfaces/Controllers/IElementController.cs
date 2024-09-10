// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Structs;

namespace Cadwork.Api.Interfaces.Controllers;

using ElementId = ulong;

/// <summary>
/// 
/// </summary>
public interface IElementController
{
  /// <summary>
  /// 
  /// </summary>
  /// <param name="nestingParentElementId"></param>
  /// <param name="nestingChildElementId"></param>
  /// <returns></returns>
  CoordinateSystemData GetCoordinateSystemDataNestingChild(ElementId nestingParentElementId, ElementId nestingChildElementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <returns></returns>
  ElementId ConvertSurfacesToVolume(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="outputName"></param>
  /// <param name="standardElementName"></param>
  /// <returns></returns>
  ElementId CreateAutoContainerFromStandard(ICollection<ElementId> elementIds, string outputName, string standardElementName);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="outputName"></param>
  /// <param name="standardElementName"></param>
  /// <param name="referenceElementId"></param>
  /// <returns></returns>
  ElementId CreateAutoContainerFromStandardWithReference(ICollection<ElementId> elementIds, string outputName, string standardElementName, ElementId referenceElementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="outputName"></param>
  /// <param name="standardElementName"></param>
  /// <returns></returns>
  ElementId CreateAutoExportSolidFromStandard(ICollection<ElementId> elementIds, string outputName, string standardElementName);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="outputName"></param>
  /// <param name="standardElementName"></param>
  /// <param name="referenceElementId"></param>
  /// <returns></returns>
  ElementId CreateAutoExportSolidFromStandardWithReference(ICollection<ElementId> elementIds, string outputName, string standardElementName, ElementId referenceElementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <returns></returns>
  ElementId CreateBoundingBoxGlobal(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="referenceElementId"></param>
  /// <param name="elementIds"></param>
  /// <returns></returns>
  ElementId CreateBoundingBoxLocal(ElementId referenceElementId, ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="diameter"></param>
  /// <param name="p1"></param>
  /// <param name="p2"></param>
  /// <returns></returns>
  ElementId CreateCircularAxisPoints(double diameter, Vec3 p1, Vec3 p2);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="diameter"></param>
  /// <param name="length"></param>
  /// <param name="p1"></param>
  /// <param name="xl"></param>
  /// <returns></returns>
  ElementId CreateCircularAxisVector(double diameter, double length, Vec3 p1, Vec3 xl);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="diameter"></param>
  /// <param name="p1"></param>
  /// <param name="p2"></param>
  /// <param name="p3"></param>
  /// <returns></returns>
  ElementId CreateCircularBeamPoints(double diameter, Vec3 p1, Vec3 p2, Vec3 p3);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="diameter"></param>
  /// <param name="length"></param>
  /// <param name="p1"></param>
  /// <param name="xl"></param>
  /// <param name="zl"></param>
  /// <returns></returns>
  ElementId CreateCircularBeamVectors(double diameter, double length, Vec3 p1, Vec3 xl, Vec3 zl);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="diameter"></param>
  /// <param name="points"></param>
  /// <returns></returns>
  ElementId CreateCircularMep(double diameter, ICollection<Vec3> points);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="diameter"></param>
  /// <param name="p1"></param>
  /// <param name="p2"></param>
  /// <returns></returns>
  ElementId CreateDrillingPoints(double diameter, Vec3 p1, Vec3 p2);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="diameter"></param>
  /// <param name="length"></param>
  /// <param name="p1"></param>
  /// <param name="xl"></param>
  /// <returns></returns>
  ElementId CreateDrillingVectors(double diameter, double length, Vec3 p1, Vec3 xl);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="p1"></param>
  /// <param name="p2"></param>
  /// <returns></returns>
  ElementId CreateLinePoints(Vec3 p1, Vec3 p2);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="length"></param>
  /// <param name="p1"></param>
  /// <param name="xl"></param>
  /// <returns></returns>
  ElementId CreateLineVectors(double length, Vec3 p1, Vec3 xl);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="optimizationNumber"></param>
  /// <param name="totalLength"></param>
  /// <param name="startCut"></param>
  /// <param name="endCut"></param>
  /// <param name="sawKerf"></param>
  /// <param name="isProductionList"></param>
  /// <returns></returns>
  ElementId CreateLinearOptimization(ICollection<ElementId> elementIds, uint optimizationNumber, double totalLength, double startCut, double endCut, double sawKerf, bool isProductionList);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="p1"></param>
  /// <returns></returns>
  ElementId CreateNode(Vec3 p1);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="p1"></param>
  /// <param name="p2"></param>
  /// <returns></returns>
  ElementId CreateNormalAxisPoints(Vec3 p1, Vec3 p2);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="length"></param>
  /// <param name="p1"></param>
  /// <param name="xl"></param>
  /// <returns></returns>
  ElementId CreateNormalAxisVectors(double length, Vec3 p1, Vec3 xl);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="vertices"></param>
  /// <param name="thickness"></param>
  /// <param name="xl"></param>
  /// <param name="zl"></param>
  /// <returns></returns>
  ElementId CreatePolygonBeam(ICollection<Vec3> vertices, double thickness, Vec3 xl, Vec3 zl);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="vertices"></param>
  /// <param name="thickness"></param>
  /// <param name="xl"></param>
  /// <param name="zl"></param>
  /// <returns></returns>
  ElementId CreatePolygonPanel(ICollection<Vec3> vertices, double thickness, Vec3 xl, Vec3 zl);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="width"></param>
  /// <param name="height"></param>
  /// <param name="p1"></param>
  /// <param name="p2"></param>
  /// <param name="p3"></param>
  /// <returns></returns>
  ElementId CreateRectangularBeamPoints(double width, double height, Vec3 p1, Vec3 p2, Vec3 p3);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="width"></param>
  /// <param name="height"></param>
  /// <param name="length"></param>
  /// <param name="p1"></param>
  /// <param name="xl"></param>
  /// <param name="zl"></param>
  /// <returns></returns>
  ElementId CreateRectangularBeamVectors(double width, double height, double length, Vec3 p1, Vec3 xl, Vec3 zl);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="width"></param>
  /// <param name="depth"></param>
  /// <param name="points"></param>
  /// <returns></returns>
  ElementId CreateRectangularMep(double width, double depth, ICollection<Vec3> points);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="width"></param>
  /// <param name="thickness"></param>
  /// <param name="p1"></param>
  /// <param name="p2"></param>
  /// <param name="p3"></param>
  /// <returns></returns>
  ElementId CreateRectangularPanelPoints(double width, double thickness, Vec3 p1, Vec3 p2, Vec3 p3);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="width"></param>
  /// <param name="thickness"></param>
  /// <param name="length"></param>
  /// <param name="p1"></param>
  /// <param name="xl"></param>
  /// <param name="zl"></param>
  /// <returns></returns>
  ElementId CreateRectangularPanelVectors(double width, double thickness, double length, Vec3 p1, Vec3 xl, Vec3 zl);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="splinePoints"></param>
  /// <returns></returns>
  ElementId CreateSplineLine(ICollection<Vec3> splinePoints);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="width"></param>
  /// <param name="p1"></param>
  /// <param name="p2"></param>
  /// <param name="p3"></param>
  /// <returns></returns>
  ElementId CreateSquareBeamPoints(double width, Vec3 p1, Vec3 p2, Vec3 p3);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="width"></param>
  /// <param name="length"></param>
  /// <param name="p1"></param>
  /// <param name="xl"></param>
  /// <param name="zl"></param>
  /// <returns></returns>
  ElementId CreateSquareBeamVectors(double width, double length, Vec3 p1, Vec3 xl, Vec3 zl);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="standardElementName"></param>
  /// <param name="p1"></param>
  /// <param name="p2"></param>
  /// <param name="p3"></param>
  /// <returns></returns>
  ElementId CreateStandardBeamPoints(string standardElementName, Vec3 p1, Vec3 p2, Vec3 p3);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="standardElementName"></param>
  /// <param name="length"></param>
  /// <param name="p1"></param>
  /// <param name="xl"></param>
  /// <param name="zl"></param>
  /// <returns></returns>
  ElementId CreateStandardBeamVectors(string standardElementName, double length, Vec3 p1, Vec3 xl, Vec3 zl);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="guid"></param>
  /// <param name="p1"></param>
  /// <param name="p2"></param>
  /// <param name="p3"></param>
  /// <returns></returns>
  ElementId CreateStandardElementFromGuidPoints(Guid guid, Vec3 p1, Vec3 p2, Vec3 p3);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="guid"></param>
  /// <param name="length"></param>
  /// <param name="p1"></param>
  /// <param name="xl"></param>
  /// <param name="zl"></param>
  /// <returns></returns>
  ElementId CreateStandardElementFromGuidVectors(Guid guid, double length, Vec3 p1, Vec3 xl, Vec3 zl);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="standardElementName"></param>
  /// <param name="p1"></param>
  /// <param name="p2"></param>
  /// <param name="p3"></param>
  /// <returns></returns>
  ElementId CreateStandardPanelPoints(string standardElementName, Vec3 p1, Vec3 p2, Vec3 p3);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="standardElementName"></param>
  /// <param name="length"></param>
  /// <param name="p1"></param>
  /// <param name="xl"></param>
  /// <param name="zl"></param>
  /// <returns></returns>
  ElementId CreateStandardPanelVectors(string standardElementName, double length, Vec3 p1, Vec3 xl, Vec3 zl);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="standardElementName"></param>
  /// <param name="p1"></param>
  /// <param name="p2"></param>
  /// <param name="p3"></param>
  /// <returns></returns>
  ElementId CreateStandardSteelPoints(string standardElementName, Vec3 p1, Vec3 p2, Vec3 p3);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="standardElementName"></param>
  /// <param name="length"></param>
  /// <param name="p1"></param>
  /// <param name="xl"></param>
  /// <param name="zl"></param>
  /// <returns></returns>
  ElementId CreateStandardSteelVectors(string standardElementName, double length, Vec3 p1, Vec3 xl, Vec3 zl);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="vertices"></param>
  /// <returns></returns>
  ElementId CreateSurface(ICollection<Vec3> vertices);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="text"></param>
  /// <param name="p1"></param>
  /// <param name="xl"></param>
  /// <param name="zl"></param>
  /// <param name="size"></param>
  /// <returns></returns>
  ElementId CreateTextObject(string text, Vec3 p1, Vec3 xl, Vec3 zl, double size);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="text"></param>
  /// <param name="p1"></param>
  /// <param name="xl"></param>
  /// <param name="zl"></param>
  /// <param name="size"></param>
  /// <param name="fontName"></param>
  /// <returns></returns>
  ElementId CreateTextObjectWithFont(string text, Vec3 p1, Vec3 xl, Vec3 zl, double size, string fontName);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="p1"></param>
  /// <param name="xl"></param>
  /// <param name="zl"></param>
  /// <param name="textObjectOptions"></param>
  /// <returns></returns>
  ElementId CreateTextObjectWithOptions(Vec3 p1, Vec3 xl, Vec3 zl, ITextObjectOptions textObjectOptions);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="startDiameter"></param>
  /// <param name="endDiameter"></param>
  /// <param name="p1"></param>
  /// <param name="p2"></param>
  /// <param name="p3"></param>
  /// <returns></returns>
  ElementId CreateTruncatedConeBeamPoints(double startDiameter, double endDiameter, Vec3 p1, Vec3 p2, Vec3 p3);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="startDiameter"></param>
  /// <param name="endDiameter"></param>
  /// <param name="length"></param>
  /// <param name="p1"></param>
  /// <param name="xl"></param>
  /// <param name="zl"></param>
  /// <returns></returns>
  ElementId CreateTruncatedConeBeamVectors(double startDiameter, double endDiameter, double length, Vec3 p1, Vec3 xl, Vec3 zl);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="vector"></param>
  /// <returns></returns>
  ElementId ExtrudeSurfaceToAuxiliaryVector(ElementId elementId, Vec3 vector);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="vector"></param>
  /// <returns></returns>
  ElementId ExtrudeSurfaceToBeamVector(ElementId elementId, Vec3 vector);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="vector"></param>
  /// <returns></returns>
  ElementId ExtrudeSurfaceToPanelVector(ElementId elementId, Vec3 vector);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="guid"></param>
  /// <returns></returns>
  ElementId GetElementFromCadworkGuid(Guid guid);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  ElementId GetNestingParentId(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  ElementId GetParentContainerId(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  ElementId GetReferenceElement(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  Guid GetElementCadworkGuid(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  ICollection<ElementId> ActivateEnvelopesWithoutSituation();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  ICollection<ElementId> ActivatePartsWithoutSituation();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <returns></returns>
  ICollection<ElementId> CheckElementDuplicates(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <returns></returns>
  ICollection<ElementId> ConvertLinesToSurfaces(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="copyVector"></param>
  /// <returns></returns>
  ICollection<ElementId> CopyElements(ICollection<ElementId> elementIds, Vec3 copyVector);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="keepCuttingElementsOnly"></param>
  /// <returns></returns>
  ICollection<ElementId> DeleteProcessesKeepCuttingBodies(ICollection<ElementId> elementIds, bool keepCuttingElementsOnly);

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  ICollection<ElementId> GetActiveElementIds();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  ICollection<ElementId> GetAllElementIds();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  ICollection<ElementId> GetAllNestingRawParts();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  ICollection<ElementId> GetContainerContentElements(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  ICollection<ElementId> GetElementsInContact(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  ICollection<ElementId> GetExportSolidContentElements(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  ICollection<ElementId> GetInactiveElementIds();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  ICollection<ElementId> GetInactiveVisibleElementIds();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  ICollection<ElementId> GetHiddenElementIds();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  ICollection<ElementId> GetJoinedElements(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="openingType"></param>
  /// <returns></returns>
  ICollection<ElementId> GetOpeningVariantIds(ICollection<ElementId> elementIds, int openingType);

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  ICollection<ElementId> GetUserElementIds();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="count"></param>
  /// <returns></returns>
  ICollection<ElementId> GetUserElementIdsWithCount(ulong count);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <returns></returns>
  ICollection<ElementId> GetUserElementIdsWithExisting(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  ICollection<ElementId> GetVariantSiblingElementIds(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  ICollection<ElementId> GetVisibleElementIds();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="plane"></param>
  /// <param name="planeDistance"></param>
  /// <returns></returns>
  ICollection<ElementId> MirrorCopyElements(ICollection<ElementId> elementIds, Vec3 plane, double planeDistance);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="minimumDiameter"></param>
  /// <param name="maximumDiameter"></param>
  /// <returns></returns>
  ICollection<ElementId> ReplacePhysicalHolesWithDrillingAxes(ICollection<ElementId> elementIds, double minimumDiameter, double maximumDiameter);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="cutPlaneNormalVector"></param>
  /// <param name="distanceFromGlobalOrigin"></param>
  /// <returns></returns>
  ICollection<ElementId> SliceElementWithPlaneAndGetNewElements(ElementId elementId, Vec3 cutPlaneNormalVector, double distanceFromGlobalOrigin);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <returns></returns>
  ICollection<ElementId> SolderElements(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="hardElementIds"></param>
  /// <param name="softElementIds"></param>
  /// <returns></returns>
  ICollection<ElementId> SubtractElements(ICollection<ElementId> hardElementIds, ICollection<ElementId> softElementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="hardElementIds"></param>
  /// <param name="softElementIds"></param>
  /// <param name="withUndo"></param>
  /// <returns></returns>
  ICollection<ElementId> SubtractElementsWithUndo(ICollection<ElementId> hardElementIds, ICollection<ElementId> softElementIds, bool withUndo);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <returns></returns>
  ICollection<IEdge> GetEdgeSelection(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="firstElementId"></param>
  /// <param name="secondElementId"></param>
  /// <returns></returns>
  ICollection<IFacet> GetElementContactFacets(ElementId firstElementId, ElementId secondElementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <returns></returns>
  ICollection<IFacet> GetFacetsWithLasso(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <returns></returns>
  ICollection<Vec3> GetBoundingBoxVerticesGlobal(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="referenceElementId"></param>
  /// <param name="elementIds"></param>
  /// <returns></returns>
  ICollection<Vec3> GetBoundingBoxVerticesLocal(ElementId referenceElementId, ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="firstElementId"></param>
  /// <param name="secondElementId"></param>
  /// <returns></returns>
  ICollection<Vec3> GetElementContactVertices(ElementId firstElementId, ElementId secondElementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="firstElementId"></param>
  /// <param name="secondElementId"></param>
  /// <returns></returns>
  ICollection<Vec3> GetElementRawInterfaceVertices(ElementId firstElementId, ElementId secondElementId);

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  ICollection<string> GetStandardBeamList();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  ICollection<string> GetStandardContainerList();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  ICollection<string> GetStandardExportSolidList();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  ICollection<string> GetStandardPanelList();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  IElementModuleProperties GetElementModulePropertiesForElement(ElementId elementId);

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
  bool CheckElementId(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="firstElementId"></param>
  /// <param name="secondElementId"></param>
  /// <returns></returns>
  bool CheckIfElementsAreInCollision(ElementId firstElementId, ElementId secondElementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="firstElementId"></param>
  /// <param name="secondElementId"></param>
  /// <returns></returns>
  bool CheckIfElementsAreInContact(ElementId firstElementId, ElementId secondElementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="point"></param>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool CheckIfPointIsInElement(Vec3 point, ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="point"></param>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool CheckIfPointIsOnElement(Vec3 point, ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="cutPlaneNormalVector"></param>
  /// <param name="distanceFromGlobalOrigin"></param>
  /// <returns></returns>
  bool CutElementWithPlane(ElementId elementId, Vec3 cutPlaneNormalVector, double distanceFromGlobalOrigin);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="firstElementId"></param>
  /// <param name="secondElementId"></param>
  /// <returns></returns>
  bool CutElementsWithMiter(ElementId firstElementId, ElementId secondElementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="cutPlaneNormalVector"></param>
  /// <param name="distanceFromGlobalOrigin"></param>
  /// <returns></returns>
  bool SliceElementWithPlane(ElementId elementId, Vec3 cutPlaneNormalVector, double distanceFromGlobalOrigin);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <returns></returns>
  bool UnJoinElements(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <returns></returns>
  bool UnJoinTopLevelElements(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  string GetElementDetailPath();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  string GetElementTypeDescription(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="standardElementType"></param>
  /// <returns></returns>
  string StartStandardElementDialog(StandardElementType standardElementType);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void AddCreatedElementsToUndo(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="detail"></param>
  void AddElementsToDetail(ICollection<ElementId> elementIds, ElementModuleDetailType detail);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="message"></param>
  void AddElementsToUndo(ICollection<ElementId> elementIds, UndoMessage message);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void AddModifiedElementsToUndo(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="oldPoint"></param>
  /// <param name="oldXl"></param>
  /// <param name="oldYl"></param>
  /// <param name="newPoint"></param>
  /// <param name="newXl"></param>
  /// <param name="newYl"></param>
  void ApplyTransformationCoordinate(ICollection<ElementId> elementIds, Vec3 oldPoint, Vec3 oldXl, Vec3 oldYl, Vec3 newPoint, Vec3 newXl, Vec3 newYl);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void AutoSetPartsSituation(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void AutoSetRoughVolumeSituation(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="startEdge"></param>
  /// <param name="endEdge"></param>
  /// <param name="length"></param>
  void ChamferEdge(ElementId elementId, Vec3 startEdge, Vec3 endEdge, double length);

  /// <summary>
  /// 
  /// </summary>
  void ClearErrors();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void ConvertAuxiliaryToBeam(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void ConvertAuxiliaryToPanel(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void ConvertBeamToPanel(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="standardElementName"></param>
  void ConvertBoltToStandardConnector(ICollection<ElementId> elementIds, string standardElementName);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void ConvertCircularBeamToDrilling(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void ConvertContainerToContainerBlock(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void ConvertDrillingToCircularBeam(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void ConvertElementsToAuxiliaryElements(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void ConvertPanelToBeam(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="roofName"></param>
  void ConvertSurfacesToRoofSurfaces(ICollection<ElementId> elementIds, string roofName);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void CreateMultiWall(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="profileName"></param>
  /// <param name="onStartFace"></param>
  /// <param name="onEndFace"></param>
  void CutBeamEndProfile(ICollection<ElementId> elementIds, string profileName, bool onStartFace, bool onEndFace);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="depth"></param>
  /// <param name="clearanceBase"></param>
  /// <param name="clearanceSide"></param>
  /// <param name="backCut"></param>
  /// <param name="drillingCount"></param>
  /// <param name="drillingDiameter"></param>
  /// <param name="drillingTolerance"></param>
  void CutCornerLap(ICollection<ElementId> elementIds, double depth, double clearanceBase, double clearanceSide, double backCut, ulong drillingCount, double drillingDiameter, double drillingTolerance);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="depth"></param>
  /// <param name="clearanceBase"></param>
  /// <param name="clearanceSide"></param>
  /// <param name="drillingCount"></param>
  /// <param name="drillingDiameter"></param>
  /// <param name="drillingTolerance"></param>
  void CutCrossLap(ICollection<ElementId> elementIds, double depth, double clearanceBase, double clearanceSide, ulong drillingCount, double drillingDiameter, double drillingTolerance);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="length"></param>
  /// <param name="clearanceLength"></param>
  /// <param name="drillingCount"></param>
  /// <param name="drillingDiameter"></param>
  /// <param name="drillingTolerance"></param>
  void CutDiagonalCut(ICollection<ElementId> elementIds, double length, double clearanceLength, ulong drillingCount, double drillingDiameter, double drillingTolerance);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="firstDepth"></param>
  /// <param name="secondDepth"></param>
  /// <param name="clearance"></param>
  /// <param name="backCut"></param>
  /// <param name="drillingCount"></param>
  /// <param name="drillingDiameter"></param>
  /// <param name="drillingTolerance"></param>
  void CutDoubleTenon(ICollection<ElementId> elementIds, double firstDepth, double secondDepth, double clearance, double backCut, ulong drillingCount, double drillingDiameter, double drillingTolerance);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="softElementId"></param>
  /// <param name="processingGroupElementId"></param>
  void CutElementWithProcessingGroup(ElementId softElementId, ElementId processingGroupElementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="hardElementIds"></param>
  /// <param name="softElementIds"></param>
  void CutElementsWithOverMeasure(ICollection<ElementId> hardElementIds, ICollection<ElementId> softElementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="length"></param>
  /// <param name="clearanceLength"></param>
  /// <param name="clearanceDepth"></param>
  /// <param name="drillingCount"></param>
  /// <param name="drillingDiameter"></param>
  /// <param name="drillingTolerance"></param>
  void CutHalfLap(ICollection<ElementId> elementIds, double length, double clearanceLength, double clearanceDepth, ulong drillingCount, double drillingDiameter, double drillingTolerance);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="settingsName"></param>
  /// <param name="elementIds"></param>
  void CutLogCornerJoint(string settingsName, ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="length"></param>
  /// <param name="depth"></param>
  /// <param name="clearanceLength"></param>
  /// <param name="clearanceDepth"></param>
  /// <param name="drillingCount"></param>
  /// <param name="drillingDiameter"></param>
  /// <param name="drillingTolerance"></param>
  void CutScarfDiagonal(ICollection<ElementId> elementIds, double length, double depth, double clearanceLength, double clearanceDepth, ulong drillingCount, double drillingDiameter, double drillingTolerance);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="length"></param>
  /// <param name="depth"></param>
  /// <param name="clearanceLength"></param>
  /// <param name="clearanceDepth"></param>
  /// <param name="clearanceHook"></param>
  /// <param name="drillingCount"></param>
  /// <param name="drillingDiameter"></param>
  /// <param name="drillingTolerance"></param>
  void CutScarfStraight(ICollection<ElementId> elementIds, double length, double depth, double clearanceLength, double clearanceDepth, double clearanceHook, ulong drillingCount, double drillingDiameter, double drillingTolerance);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="length"></param>
  /// <param name="depth"></param>
  /// <param name="clearanceLength"></param>
  /// <param name="clearanceDepth"></param>
  /// <param name="wedgeWidth"></param>
  /// <param name="drillingCount"></param>
  /// <param name="drillingDiameter"></param>
  /// <param name="drillingTolerance"></param>
  void CutScarfWithWedge(ICollection<ElementId> elementIds, double length, double depth, double clearanceLength, double clearanceDepth, double wedgeWidth, ulong drillingCount, double drillingDiameter, double drillingTolerance);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="length"></param>
  /// <param name="depth"></param>
  /// <param name="clearanceLength"></param>
  /// <param name="clearanceDepth"></param>
  /// <param name="drillingCount"></param>
  /// <param name="drillingDiameter"></param>
  /// <param name="drillingTolerance"></param>
  void CutSimpleScarf(ICollection<ElementId> elementIds, double length, double depth, double clearanceLength, double clearanceDepth, ulong drillingCount, double drillingDiameter, double drillingTolerance);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="depth"></param>
  /// <param name="clearanceBase"></param>
  /// <param name="clearanceSide"></param>
  /// <param name="backCut"></param>
  /// <param name="drillingCount"></param>
  /// <param name="drillingDiameter"></param>
  /// <param name="drillingTolerance"></param>
  void CutTLap(ICollection<ElementId> elementIds, double depth, double clearanceBase, double clearanceSide, double backCut, ulong drillingCount, double drillingDiameter, double drillingTolerance);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void DeleteAllElementEndTypes(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void DeleteAllElementProcesses(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void DeleteElements(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void DeleteElementsWithUndo(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="startEdge"></param>
  /// <param name="endEdge"></param>
  /// <param name="radius"></param>
  void FilletEdge(ElementId elementId, Vec3 startEdge, Vec3 endEdge, double radius);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="glidePoint"></param>
  void GlideElements(ICollection<ElementId> elementIds, Vec3 glidePoint);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void JoinElements(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void JoinTopLevelElements(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  void MakeRedo();

  /// <summary>
  /// 
  /// </summary>
  void MakeUndo();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="plane"></param>
  /// <param name="planeDistance"></param>
  void MirrorMoveElements(ICollection<ElementId> elementIds, Vec3 plane, double planeDistance);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="vector"></param>
  void MoveElement(ICollection<ElementId> elementIds, Vec3 vector);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="vector"></param>
  void MoveElementWithUndo(ICollection<ElementId> elementIds, Vec3 vector);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="envelopeElementId"></param>
  /// <param name="addedChildrenElementIds"></param>
  /// <param name="removedChildrenElementIds"></param>
  void PartsSituationManual(ElementId envelopeElementId, ICollection<ElementId> addedChildrenElementIds, ICollection<ElementId> removedChildrenElementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void RecreateElements(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="guid"></param>
  void RemoveStandardBeam(Guid guid);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="guid"></param>
  void RemoveStandardConnectorAxis(Guid guid);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="guid"></param>
  void RemoveStandardContainer(Guid guid);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="guid"></param>
  void RemoveStandardExportSolid(Guid guid);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="guid"></param>
  void RemoveStandardPanel(Guid guid);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  void ResetElementCadworkGuid(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="origin"></param>
  /// <param name="rotationAxis"></param>
  /// <param name="rotationAngle"></param>
  void RotateElements(ICollection<ElementId> elementIds, Vec3 origin, Vec3 rotationAxis, double rotationAngle);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="envelopeElementId"></param>
  /// <param name="addedPartnerElementIds"></param>
  /// <param name="removedPartnerElementIds"></param>
  void RoughVolumeSituationManual(ElementId envelopeElementId, ICollection<ElementId> addedPartnerElementIds, ICollection<ElementId> removedPartnerElementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="containerElementId"></param>
  /// <param name="elementIds"></param>
  void SetContainerContents(ElementId containerElementId, ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="path"></param>
  void SetElementDetailPath(string path);

  /// <summary>
  /// 
  /// </summary>
  void SetElementGroupMultiSelectMode();

  /// <summary>
  /// 
  /// </summary>
  void SetElementGroupSingleSelectMode();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="properties"></param>
  void SetElementModulePropertiesForElements(ICollection<ElementId> elementIds, IElementModuleProperties properties);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="exportSolidElementId"></param>
  /// <param name="elementIds"></param>
  void SetExportSolidContents(ElementId exportSolidElementId, ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void SetLineToMarkingLine(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void SetLineToNormalLine(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="angle"></param>
  void SetParentOpeningVariantsOpeningAngle(ICollection<ElementId> elementIds, double angle);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void SplitElements(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="envelopeElementIds"></param>
  void StartElementModuleCalculation(ICollection<ElementId> envelopeElementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="envelopeElementIds"></param>
  void StartElementModuleCalculationSilently(ICollection<ElementId> envelopeElementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="stretchVector"></param>
  void StretchEndFace(ICollection<ElementId> elementIds, Vec3 stretchVector);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="stretchVector"></param>
  void StretchStartFace(ICollection<ElementId> elementIds, Vec3 stretchVector);
};
