// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;
using Cadwork.Api.Interop.Wrappers.Structs;

namespace Cadwork.Api.Interop.Wrappers.Controllers;

public class ElementControllerWrapper
{
  private readonly IntPtr _nativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public ElementControllerWrapper(IntPtr nativePtr)
  {
    _nativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<ElementControllerInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(GetLastErrorDelegate), Marshal.GetDelegateForFunctionPointer<GetLastErrorDelegate>(vTable!.getLastErrorFunctionPtr) },
      { typeof(GetAllIdentifiableElementIDsDelegate), Marshal.GetDelegateForFunctionPointer<GetAllIdentifiableElementIDsDelegate>(vTable.getAllIdentifiableElementIDsFunctionPtr) },
      { typeof(GetVisibleIdentifiableElementIDsDelegate), Marshal.GetDelegateForFunctionPointer<GetVisibleIdentifiableElementIDsDelegate>(vTable.getVisibleIdentifiableElementIDsFunctionPtr) },
      { typeof(GetInvisibleIdentifiableElementIDsDelegate), Marshal.GetDelegateForFunctionPointer<GetInvisibleIdentifiableElementIDsDelegate>(vTable.getInvisibleIdentifiableElementIDsFunctionPtr) },
      { typeof(GetActiveIdentifiableElementIDsDelegate), Marshal.GetDelegateForFunctionPointer<GetActiveIdentifiableElementIDsDelegate>(vTable.getActiveIdentifiableElementIDsFunctionPtr) },
      { typeof(GetInactiveAllIdentifiableElementIDsDelegate), Marshal.GetDelegateForFunctionPointer<GetInactiveAllIdentifiableElementIDsDelegate>(vTable.getInactiveAllIdentifiableElementIDsFunctionPtr) },
      { typeof(GetInactiveVisibleIdentifiableElementIDsDelegate), Marshal.GetDelegateForFunctionPointer<GetInactiveVisibleIdentifiableElementIDsDelegate>(vTable.getInactiveVisibleIdentifiableElementIDsFunctionPtr) },
      { typeof(DeleteElementsDelegate), Marshal.GetDelegateForFunctionPointer<DeleteElementsDelegate>(vTable.deleteElementsFunctionPtr) },
      { typeof(JoinElementsDelegate), Marshal.GetDelegateForFunctionPointer<JoinElementsDelegate>(vTable.joinElementsFunctionPtr) },
      { typeof(JoinTopLevelElementsDelegate), Marshal.GetDelegateForFunctionPointer<JoinTopLevelElementsDelegate>(vTable.joinTopLevelElementsFunctionPtr) },
      { typeof(CreateRectangularBeamPointsDelegate), Marshal.GetDelegateForFunctionPointer<CreateRectangularBeamPointsDelegate>(vTable.createRectangularBeamPointsFunctionPtr) },
      { typeof(CreateCircularBeamPointsDelegate), Marshal.GetDelegateForFunctionPointer<CreateCircularBeamPointsDelegate>(vTable.createCircularBeamPointsFunctionPtr) },
      { typeof(CreateSquareBeamPointsDelegate), Marshal.GetDelegateForFunctionPointer<CreateSquareBeamPointsDelegate>(vTable.createSquareBeamPointsFunctionPtr) },
      { typeof(CreateRectangularBeamVectorsDelegate), Marshal.GetDelegateForFunctionPointer<CreateRectangularBeamVectorsDelegate>(vTable.createRectangularBeamVectorsFunctionPtr) },
      { typeof(CreateCircularBeamVectorsDelegate), Marshal.GetDelegateForFunctionPointer<CreateCircularBeamVectorsDelegate>(vTable.createCircularBeamVectorsFunctionPtr) },
      { typeof(CreateSquareBeamVectorsDelegate), Marshal.GetDelegateForFunctionPointer<CreateSquareBeamVectorsDelegate>(vTable.createSquareBeamVectorsFunctionPtr) },
      { typeof(CreateRectangularPanelPointsDelegate), Marshal.GetDelegateForFunctionPointer<CreateRectangularPanelPointsDelegate>(vTable.createRectangularPanelPointsFunctionPtr) },
      { typeof(CreateRectangularPanelVectorsDelegate), Marshal.GetDelegateForFunctionPointer<CreateRectangularPanelVectorsDelegate>(vTable.createRectangularPanelVectorsFunctionPtr) },
      { typeof(CreateDrillingPointsDelegate), Marshal.GetDelegateForFunctionPointer<CreateDrillingPointsDelegate>(vTable.createDrillingPointsFunctionPtr) },
      { typeof(CreateDrillingVectorsDelegate), Marshal.GetDelegateForFunctionPointer<CreateDrillingVectorsDelegate>(vTable.createDrillingVectorsFunctionPtr) },
      { typeof(CreateLinePointsDelegate), Marshal.GetDelegateForFunctionPointer<CreateLinePointsDelegate>(vTable.createLinePointsFunctionPtr) },
      { typeof(CreateLineVectorsDelegate), Marshal.GetDelegateForFunctionPointer<CreateLineVectorsDelegate>(vTable.createLineVectorsFunctionPtr) },
      { typeof(CreateNodeDelegate), Marshal.GetDelegateForFunctionPointer<CreateNodeDelegate>(vTable.createNodeFunctionPtr) },
      { typeof(SolderElementsDelegate), Marshal.GetDelegateForFunctionPointer<SolderElementsDelegate>(vTable.solderElementsFunctionPtr) },
      { typeof(ConvertBeamToPanelDelegate), Marshal.GetDelegateForFunctionPointer<ConvertBeamToPanelDelegate>(vTable.convertBeamToPanelFunctionPtr) },
      { typeof(ConvertPanelToBeamDelegate), Marshal.GetDelegateForFunctionPointer<ConvertPanelToBeamDelegate>(vTable.convertPanelToBeamFunctionPtr) },
      { typeof(DeleteAllElementEndTypesDelegate), Marshal.GetDelegateForFunctionPointer<DeleteAllElementEndTypesDelegate>(vTable.deleteAllElementEndTypesFunctionPtr) },
      { typeof(DeleteAllElementProcessesDelegate), Marshal.GetDelegateForFunctionPointer<DeleteAllElementProcessesDelegate>(vTable.deleteAllElementProcessesFunctionPtr) },
      { typeof(MoveElementDelegate), Marshal.GetDelegateForFunctionPointer<MoveElementDelegate>(vTable.moveElementFunctionPtr) },
      { typeof(CreatePolygonBeamDelegate), Marshal.GetDelegateForFunctionPointer<CreatePolygonBeamDelegate>(vTable.createPolygonBeamFunctionPtr) },
      { typeof(CreateTextObjectDelegate), Marshal.GetDelegateForFunctionPointer<CreateTextObjectDelegate>(vTable.createTextObjectFunctionPtr) },
      { typeof(CopyElementsDelegate), Marshal.GetDelegateForFunctionPointer<CopyElementsDelegate>(vTable.copyElementsFunctionPtr) },
      { typeof(RotateElementsDelegate), Marshal.GetDelegateForFunctionPointer<RotateElementsDelegate>(vTable.rotateElementsFunctionPtr) },
      { typeof(SubtractElementsDelegate), Marshal.GetDelegateForFunctionPointer<SubtractElementsDelegate>(vTable.subtractElementsFunctionPtr) },
      { typeof(CheckElementIdDelegate), Marshal.GetDelegateForFunctionPointer<CheckElementIdDelegate>(vTable.checkElementIdFunctionPtr) },
      { typeof(FilterElementsDelegate), Marshal.GetDelegateForFunctionPointer<FilterElementsDelegate>(vTable.filterElementsFunctionPtr) },
      { typeof(MapElementsDelegate), Marshal.GetDelegateForFunctionPointer<MapElementsDelegate>(vTable.mapElementsFunctionPtr) },
      { typeof(StartElementModuleCalculationDelegate), Marshal.GetDelegateForFunctionPointer<StartElementModuleCalculationDelegate>(vTable.startElementModuleCalculationFunctionPtr) },
      { typeof(SetElementDetailPathDelegate), Marshal.GetDelegateForFunctionPointer<SetElementDetailPathDelegate>(vTable.setElementDetailPathFunctionPtr) },
      { typeof(GetElementDetailPathDelegate), Marshal.GetDelegateForFunctionPointer<GetElementDetailPathDelegate>(vTable.getElementDetailPathFunctionPtr) },
      { typeof(GetElementCadworkGuidDelegate), Marshal.GetDelegateForFunctionPointer<GetElementCadworkGuidDelegate>(vTable.getElementCadworkGuidFunctionPtr) },
      { typeof(GetElementFromCadworkGuidDelegate), Marshal.GetDelegateForFunctionPointer<GetElementFromCadworkGuidDelegate>(vTable.getElementFromCadworkGuidFunctionPtr) },
      { typeof(AddElementsToUndoDelegate), Marshal.GetDelegateForFunctionPointer<AddElementsToUndoDelegate>(vTable.addElementsToUndoFunctionPtr) },
      { typeof(MakeUndoDelegate), Marshal.GetDelegateForFunctionPointer<MakeUndoDelegate>(vTable.makeUndoFunctionPtr) },
      { typeof(MakeRedoDelegate), Marshal.GetDelegateForFunctionPointer<MakeRedoDelegate>(vTable.makeRedoFunctionPtr) },
      { typeof(SplitElementsDelegate), Marshal.GetDelegateForFunctionPointer<SplitElementsDelegate>(vTable.splitElementsFunctionPtr) },
      { typeof(SetLineToMarkingLineDelegate), Marshal.GetDelegateForFunctionPointer<SetLineToMarkingLineDelegate>(vTable.setLineToMarkingLineFunctionPtr) },
      { typeof(SetLineToNormalLineDelegate), Marshal.GetDelegateForFunctionPointer<SetLineToNormalLineDelegate>(vTable.setLineToNormalLineFunctionPtr) },
      { typeof(CreateAutoExportSolidFromStandardDelegate), Marshal.GetDelegateForFunctionPointer<CreateAutoExportSolidFromStandardDelegate>(vTable.createAutoExportSolidFromStandardFunctionPtr) },
      { typeof(SetElementModulePropertiesForElementsDelegate), Marshal.GetDelegateForFunctionPointer<SetElementModulePropertiesForElementsDelegate>(vTable.setElementModulePropertiesForElementsFunctionPtr) },
      { typeof(GetElementModulePropertiesForElementDelegate), Marshal.GetDelegateForFunctionPointer<GetElementModulePropertiesForElementDelegate>(vTable.getElementModulePropertiesForElementFunctionPtr) },
      { typeof(GetElementTypeDescriptionDelegate), Marshal.GetDelegateForFunctionPointer<GetElementTypeDescriptionDelegate>(vTable.getElementTypeDescriptionFunctionPtr) },
      { typeof(CreateTextObjectWithFontDelegate), Marshal.GetDelegateForFunctionPointer<CreateTextObjectWithFontDelegate>(vTable.createTextObjectWithFontFunctionPtr) },
      { typeof(GetOpeningVariantIDsDelegate), Marshal.GetDelegateForFunctionPointer<GetOpeningVariantIDsDelegate>(vTable.getOpeningVariantIDsFunctionPtr) },
      { typeof(GetParentContainerIdDelegate), Marshal.GetDelegateForFunctionPointer<GetParentContainerIdDelegate>(vTable.getParentContainerIdFunctionPtr) },
      { typeof(GetExportSolidContentElementsDelegate), Marshal.GetDelegateForFunctionPointer<GetExportSolidContentElementsDelegate>(vTable.getExportSolidContentElementsFunctionPtr) },
      { typeof(GetContainerContentElementsDelegate), Marshal.GetDelegateForFunctionPointer<GetContainerContentElementsDelegate>(vTable.getContainerContentElementsFunctionPtr) },
      { typeof(ApplyTransformationCoordinateDelegate), Marshal.GetDelegateForFunctionPointer<ApplyTransformationCoordinateDelegate>(vTable.applyTransformationCoordinateFunctionPtr) },
      { typeof(DeleteElementsWithUndoDelegate), Marshal.GetDelegateForFunctionPointer<DeleteElementsWithUndoDelegate>(vTable.deleteElementsWithUndoFunctionPtr) },
      { typeof(AddCreatedElementsToUndoDelegate), Marshal.GetDelegateForFunctionPointer<AddCreatedElementsToUndoDelegate>(vTable.addCreatedElementsToUndoFunctionPtr) },
      { typeof(AddModifiedElementsToUndoDelegate), Marshal.GetDelegateForFunctionPointer<AddModifiedElementsToUndoDelegate>(vTable.addModifiedElementsToUndoFunctionPtr) },
      { typeof(RecreateElementsDelegate), Marshal.GetDelegateForFunctionPointer<RecreateElementsDelegate>(vTable.recreateElementsFunctionPtr) },
      { typeof(CheckIfElementsAreInCollisionDelegate), Marshal.GetDelegateForFunctionPointer<CheckIfElementsAreInCollisionDelegate>(vTable.checkIfElementsAreInCollisionFunctionPtr) },
      { typeof(CheckIfElementsAreInContactDelegate), Marshal.GetDelegateForFunctionPointer<CheckIfElementsAreInContactDelegate>(vTable.checkIfElementsAreInContactFunctionPtr) },
      { typeof(CreateMultiWallDelegate), Marshal.GetDelegateForFunctionPointer<CreateMultiWallDelegate>(vTable.createMultiWallFunctionPtr) },
      { typeof(GetUserElementIDsDelegate), Marshal.GetDelegateForFunctionPointer<GetUserElementIDsDelegate>(vTable.getUserElementIDsFunctionPtr) },
      { typeof(GetElementContactVerticesDelegate), Marshal.GetDelegateForFunctionPointer<GetElementContactVerticesDelegate>(vTable.getElementContactVerticesFunctionPtr) },
      { typeof(GetNestingParentIdDelegate), Marshal.GetDelegateForFunctionPointer<GetNestingParentIdDelegate>(vTable.getNestingParentIdFunctionPtr) },
      { typeof(GetUserElementIDsWithExistingDelegate), Marshal.GetDelegateForFunctionPointer<GetUserElementIDsWithExistingDelegate>(vTable.getUserElementIDsWithExistingFunctionPtr) },
      { typeof(ClearErrorsDelegate), Marshal.GetDelegateForFunctionPointer<ClearErrorsDelegate>(vTable.clearErrorsFunctionPtr) },
      { typeof(GlideElementsDelegate), Marshal.GetDelegateForFunctionPointer<GlideElementsDelegate>(vTable.glideElementsFunctionPtr) },
      { typeof(GetElementContactFacetsDelegate), Marshal.GetDelegateForFunctionPointer<GetElementContactFacetsDelegate>(vTable.getElementContactFacetsFunctionPtr) },
      { typeof(GetElementRawInterfaceVerticesDelegate), Marshal.GetDelegateForFunctionPointer<GetElementRawInterfaceVerticesDelegate>(vTable.getElementRawInterfaceVerticesFunctionPtr) },
      { typeof(CutElementsWithMiterDelegate), Marshal.GetDelegateForFunctionPointer<CutElementsWithMiterDelegate>(vTable.cutElementsWithMiterFunctionPtr) },
      { typeof(CutElementWithPlaneDelegate), Marshal.GetDelegateForFunctionPointer<CutElementWithPlaneDelegate>(vTable.cutElementWithPlaneFunctionPtr) },
      { typeof(CreateCircularMepDelegate), Marshal.GetDelegateForFunctionPointer<CreateCircularMepDelegate>(vTable.createCircularMEPFunctionPtr) },
      { typeof(CreateRectangularMepDelegate), Marshal.GetDelegateForFunctionPointer<CreateRectangularMepDelegate>(vTable.createRectangularMEPFunctionPtr) },
      { typeof(SliceElementWithPlaneDelegate), Marshal.GetDelegateForFunctionPointer<SliceElementWithPlaneDelegate>(vTable.sliceElementWithPlaneFunctionPtr) },
      { typeof(CreateAutoContainerFromStandardDelegate), Marshal.GetDelegateForFunctionPointer<CreateAutoContainerFromStandardDelegate>(vTable.createAutoContainerFromStandardFunctionPtr) },
      { typeof(CreateAutoExportSolidFromStandardWithReferenceDelegate), Marshal.GetDelegateForFunctionPointer<CreateAutoExportSolidFromStandardWithReferenceDelegate>(vTable.createAutoExportSolidFromStandardWithReferenceFunctionPtr) },
      { typeof(CreateAutoContainerFromStandardWithReferenceDelegate), Marshal.GetDelegateForFunctionPointer<CreateAutoContainerFromStandardWithReferenceDelegate>(vTable.createAutoContainerFromStandardWithReferenceFunctionPtr) },
      { typeof(SliceElementWithPlaneAndGetNewElementsDelegate), Marshal.GetDelegateForFunctionPointer<SliceElementWithPlaneAndGetNewElementsDelegate>(vTable.sliceElementWithPlaneAndGetNewElementsFunctionPtr) },
      { typeof(CreateSurfaceDelegate), Marshal.GetDelegateForFunctionPointer<CreateSurfaceDelegate>(vTable.createSurfaceFunctionPtr) },
      { typeof(ConvertCircularBeamToDrillingDelegate), Marshal.GetDelegateForFunctionPointer<ConvertCircularBeamToDrillingDelegate>(vTable.convertCircularBeamToDrillingFunctionPtr) },
      { typeof(GetStandardExportSolidListDelegate), Marshal.GetDelegateForFunctionPointer<GetStandardExportSolidListDelegate>(vTable.getStandardExportSolidListFunctionPtr) },
      { typeof(GetStandardContainerListDelegate), Marshal.GetDelegateForFunctionPointer<GetStandardContainerListDelegate>(vTable.getStandardContainerListFunctionPtr) },
      { typeof(StretchStartFaceDelegate), Marshal.GetDelegateForFunctionPointer<StretchStartFaceDelegate>(vTable.stretchStartFaceFunctionPtr) },
      { typeof(StretchEndFaceDelegate), Marshal.GetDelegateForFunctionPointer<StretchEndFaceDelegate>(vTable.stretchEndFaceFunctionPtr) },
      { typeof(GetVariantSiblingElementIDsDelegate), Marshal.GetDelegateForFunctionPointer<GetVariantSiblingElementIDsDelegate>(vTable.getVariantSiblingElementIDsFunctionPtr) },
      { typeof(SetExportSolidContentsDelegate), Marshal.GetDelegateForFunctionPointer<SetExportSolidContentsDelegate>(vTable.setExportSolidContentsFunctionPtr) },
      { typeof(SetContainerContentsDelegate), Marshal.GetDelegateForFunctionPointer<SetContainerContentsDelegate>(vTable.setContainerContentsFunctionPtr) },
      { typeof(SetParentOpeningVariantsOpeningAngleDelegate), Marshal.GetDelegateForFunctionPointer<SetParentOpeningVariantsOpeningAngleDelegate>(vTable.setParentOpeningVariantsOpeningAngleFunctionPtr) },
      { typeof(CreateCircularAxisPointsDelegate), Marshal.GetDelegateForFunctionPointer<CreateCircularAxisPointsDelegate>(vTable.createCircularAxisPointsFunctionPtr) },
      { typeof(CreateCircularAxisVectorDelegate), Marshal.GetDelegateForFunctionPointer<CreateCircularAxisVectorDelegate>(vTable.createCircularAxisVectorFunctionPtr) },
      { typeof(ConvertElementsToAuxiliaryElementsDelegate), Marshal.GetDelegateForFunctionPointer<ConvertElementsToAuxiliaryElementsDelegate>(vTable.convertElementsToAuxiliaryElementsFunctionPtr) },
      { typeof(GetElementsInContactDelegate), Marshal.GetDelegateForFunctionPointer<GetElementsInContactDelegate>(vTable.getElementsInContactFunctionPtr) },
      { typeof(GetFacetsWithLassoDelegate), Marshal.GetDelegateForFunctionPointer<GetFacetsWithLassoDelegate>(vTable.getFacetsWithLassoFunctionPtr) },
      { typeof(CutElementsWithOverMeasureDelegate), Marshal.GetDelegateForFunctionPointer<CutElementsWithOverMeasureDelegate>(vTable.cutElementsWithOverMeasureFunctionPtr) },
      { typeof(GetEdgeSelectionDelegate), Marshal.GetDelegateForFunctionPointer<GetEdgeSelectionDelegate>(vTable.getEdgeSelectionFunctionPtr) },
      { typeof(CreatePolygonPanelDelegate), Marshal.GetDelegateForFunctionPointer<CreatePolygonPanelDelegate>(vTable.createPolygonPanelFunctionPtr) },
      { typeof(MirrorMoveElementsDelegate), Marshal.GetDelegateForFunctionPointer<MirrorMoveElementsDelegate>(vTable.mirrorMoveElementsFunctionPtr) },
      { typeof(MirrorCopyElementsDelegate), Marshal.GetDelegateForFunctionPointer<MirrorCopyElementsDelegate>(vTable.mirrorCopyElementsFunctionPtr) },
      { typeof(ResetElementCadworkGuidDelegate), Marshal.GetDelegateForFunctionPointer<ResetElementCadworkGuidDelegate>(vTable.resetElementCadworkGuidFunctionPtr) },
      { typeof(GetStandardBeamListDelegate), Marshal.GetDelegateForFunctionPointer<GetStandardBeamListDelegate>(vTable.getStandardBeamListFunctionPtr) },
      { typeof(GetStandardPanelListDelegate), Marshal.GetDelegateForFunctionPointer<GetStandardPanelListDelegate>(vTable.getStandardPanelListFunctionPtr) },
      { typeof(CreateStandardBeamPointsDelegate), Marshal.GetDelegateForFunctionPointer<CreateStandardBeamPointsDelegate>(vTable.createStandardBeamPointsFunctionPtr) },
      { typeof(CreateStandardBeamVectorsDelegate), Marshal.GetDelegateForFunctionPointer<CreateStandardBeamVectorsDelegate>(vTable.createStandardBeamVectorsFunctionPtr) },
      { typeof(CreateStandardPanelPointsDelegate), Marshal.GetDelegateForFunctionPointer<CreateStandardPanelPointsDelegate>(vTable.createStandardPanelPointsFunctionPtr) },
      { typeof(CreateStandardPanelVectorsDelegate), Marshal.GetDelegateForFunctionPointer<CreateStandardPanelVectorsDelegate>(vTable.createStandardPanelVectorsFunctionPtr) },
      { typeof(CreateStandardSteelPointsDelegate), Marshal.GetDelegateForFunctionPointer<CreateStandardSteelPointsDelegate>(vTable.createStandardSteelPointsFunctionPtr) },
      { typeof(CreateStandardSteelVectorsDelegate), Marshal.GetDelegateForFunctionPointer<CreateStandardSteelVectorsDelegate>(vTable.createStandardSteelVectorsFunctionPtr) },
      { typeof(MoveElementWithUndoDelegate), Marshal.GetDelegateForFunctionPointer<MoveElementWithUndoDelegate>(vTable.moveElementWithUndoFunctionPtr) },
      { typeof(CreateLinearOptimizationDelegate), Marshal.GetDelegateForFunctionPointer<CreateLinearOptimizationDelegate>(vTable.createLinearOptimizationFunctionPtr) },
      { typeof(CheckElementDuplicatesDelegate), Marshal.GetDelegateForFunctionPointer<CheckElementDuplicatesDelegate>(vTable.checkElementDuplicatesFunctionPtr) },
      { typeof(CreateNormalAxisPointsDelegate), Marshal.GetDelegateForFunctionPointer<CreateNormalAxisPointsDelegate>(vTable.createNormalAxisPointsFunctionPtr) },
      { typeof(CreateNormalAxisVectorsDelegate), Marshal.GetDelegateForFunctionPointer<CreateNormalAxisVectorsDelegate>(vTable.createNormalAxisVectorsFunctionPtr) },
      { typeof(ConvertBoltToStandardConnectorDelegate), Marshal.GetDelegateForFunctionPointer<ConvertBoltToStandardConnectorDelegate>(vTable.convertBoltToStandardConnectorFunctionPtr) },
      { typeof(GetReferenceElementDelegate), Marshal.GetDelegateForFunctionPointer<GetReferenceElementDelegate>(vTable.getReferenceElementFunctionPtr) },
      { typeof(ExtrudeSurfaceToAuxiliaryVectorDelegate), Marshal.GetDelegateForFunctionPointer<ExtrudeSurfaceToAuxiliaryVectorDelegate>(vTable.extrudeSurfaceToAuxiliaryVectorFunctionPtr) },
      { typeof(ExtrudeSurfaceToPanelVectorDelegate), Marshal.GetDelegateForFunctionPointer<ExtrudeSurfaceToPanelVectorDelegate>(vTable.extrudeSurfaceToPanelVectorFunctionPtr) },
      { typeof(ExtrudeSurfaceToBeamVectorDelegate), Marshal.GetDelegateForFunctionPointer<ExtrudeSurfaceToBeamVectorDelegate>(vTable.extrudeSurfaceToBeamVectorFunctionPtr) },
      { typeof(CheckIfPointIsInElementDelegate), Marshal.GetDelegateForFunctionPointer<CheckIfPointIsInElementDelegate>(vTable.checkIfPointIsInElementFunctionPtr) },
      { typeof(CheckIfPointIsOnElementDelegate), Marshal.GetDelegateForFunctionPointer<CheckIfPointIsOnElementDelegate>(vTable.checkIfPointIsOnElementFunctionPtr) },
      { typeof(ConvertContainerToContainerBlockDelegate), Marshal.GetDelegateForFunctionPointer<ConvertContainerToContainerBlockDelegate>(vTable.convertContainerToContainerBlockFunctionPtr) },
      { typeof(CreateBoundingBoxLocalDelegate), Marshal.GetDelegateForFunctionPointer<CreateBoundingBoxLocalDelegate>(vTable.createBoundingBoxLocalFunctionPtr) },
      { typeof(CreateBoundingBoxGlobalDelegate), Marshal.GetDelegateForFunctionPointer<CreateBoundingBoxGlobalDelegate>(vTable.createBoundingBoxGlobalFunctionPtr) },
      { typeof(CutLogCornerJointDelegate), Marshal.GetDelegateForFunctionPointer<CutLogCornerJointDelegate>(vTable.cutLogCornerJointFunctionPtr) },
      { typeof(ConvertAuxiliaryToPanelDelegate), Marshal.GetDelegateForFunctionPointer<ConvertAuxiliaryToPanelDelegate>(vTable.convertAuxiliaryToPanelFunctionPtr) },
      { typeof(ConvertAuxiliaryToBeamDelegate), Marshal.GetDelegateForFunctionPointer<ConvertAuxiliaryToBeamDelegate>(vTable.convertAuxiliaryToBeamFunctionPtr) },
      { typeof(AutoSetRoughVolumeSituationDelegate), Marshal.GetDelegateForFunctionPointer<AutoSetRoughVolumeSituationDelegate>(vTable.autoSetRoughVolumeSituationFunctionPtr) },
      { typeof(RoughVolumeSituationManualDelegate), Marshal.GetDelegateForFunctionPointer<RoughVolumeSituationManualDelegate>(vTable.roughVolumeSituationManualFunctionPtr) },
      { typeof(AutoSetPartsSituationDelegate), Marshal.GetDelegateForFunctionPointer<AutoSetPartsSituationDelegate>(vTable.autoSetPartsSituationFunctionPtr) },
      { typeof(PartsSituationManualDelegate), Marshal.GetDelegateForFunctionPointer<PartsSituationManualDelegate>(vTable.partsSituationManualFunctionPtr) },
      { typeof(ActivateRvWithoutSituationDelegate), Marshal.GetDelegateForFunctionPointer<ActivateRvWithoutSituationDelegate>(vTable.activateRvWithoutSituationFunctionPtr) },
      { typeof(ActivatePartsWithoutSituationDelegate), Marshal.GetDelegateForFunctionPointer<ActivatePartsWithoutSituationDelegate>(vTable.activatePartsWithoutSituationFunctionPtr) },
      { typeof(AddElementToDetailDelegate), Marshal.GetDelegateForFunctionPointer<AddElementToDetailDelegate>(vTable.addElementToDetailFunctionPtr) },
      { typeof(GetBoundingBoxVerticesLocalDelegate), Marshal.GetDelegateForFunctionPointer<GetBoundingBoxVerticesLocalDelegate>(vTable.getBoundingBoxVerticesLocalFunctionPtr) },
      { typeof(GetBoundingBoxVerticesGlobalDelegate), Marshal.GetDelegateForFunctionPointer<GetBoundingBoxVerticesGlobalDelegate>(vTable.getBoundingBoxVerticesGlobalFunctionPtr) },
      { typeof(GetAllNestingRawPartsDelegate), Marshal.GetDelegateForFunctionPointer<GetAllNestingRawPartsDelegate>(vTable.getAllNestingRawPartsFunctionPtr) },
      { typeof(SubtractElementsWithUndoDelegate), Marshal.GetDelegateForFunctionPointer<SubtractElementsWithUndoDelegate>(vTable.subtractElementsWithUndoFunctionPtr) },
      { typeof(StartElementModuleCalculationSilentlyDelegate), Marshal.GetDelegateForFunctionPointer<StartElementModuleCalculationSilentlyDelegate>(vTable.startElementModuleCalculationSilentlyFunctionPtr) },
      { typeof(GetJoinedElementsDelegate), Marshal.GetDelegateForFunctionPointer<GetJoinedElementsDelegate>(vTable.getJoinedElementsFunctionPtr) },
      { typeof(ReplacePhysicalDrillingsWithDrillingAxesDelegate), Marshal.GetDelegateForFunctionPointer<ReplacePhysicalDrillingsWithDrillingAxesDelegate>(vTable.replacePhysicalDrillingsWithDrillingAxesFunctionPtr) },
      { typeof(CutElementWithProcessingGroupDelegate), Marshal.GetDelegateForFunctionPointer<CutElementWithProcessingGroupDelegate>(vTable.cutElementWithProcessingGroupFunctionPtr) },
      { typeof(CreateTextObjectWithOptionsDelegate), Marshal.GetDelegateForFunctionPointer<CreateTextObjectWithOptionsDelegate>(vTable.createTextObjectWithOptionsFunctionPtr) },
      { typeof(CreateStandardElementFromGuidPointsDelegate), Marshal.GetDelegateForFunctionPointer<CreateStandardElementFromGuidPointsDelegate>(vTable.createStandardElementFromGuidPointsFunctionPtr) },
      { typeof(CreateStandardElementFromGuidVectorsDelegate), Marshal.GetDelegateForFunctionPointer<CreateStandardElementFromGuidVectorsDelegate>(vTable.createStandardElementFromGuidVectorsFunctionPtr) },
      { typeof(FilletEdgeDelegate), Marshal.GetDelegateForFunctionPointer<FilletEdgeDelegate>(vTable.filletEdgeFunctionPtr) },
      { typeof(ChamferEdgeDelegate), Marshal.GetDelegateForFunctionPointer<ChamferEdgeDelegate>(vTable.chamferEdgeFunctionPtr) },
      { typeof(ConvertDrillingToCircularBeamDelegate), Marshal.GetDelegateForFunctionPointer<ConvertDrillingToCircularBeamDelegate>(vTable.convertDrillingToCircularBeamFunctionPtr) },
      { typeof(ConvertLinesToSurfacesDelegate), Marshal.GetDelegateForFunctionPointer<ConvertLinesToSurfacesDelegate>(vTable.convertLinesToSurfacesFunctionPtr) },
      { typeof(ConvertSurfacesToVolumeDelegate), Marshal.GetDelegateForFunctionPointer<ConvertSurfacesToVolumeDelegate>(vTable.convertSurfacesToVolumeFunctionPtr) },
      { typeof(CutCornerLapDelegate), Marshal.GetDelegateForFunctionPointer<CutCornerLapDelegate>(vTable.cutCornerLapFunctionPtr) },
      { typeof(CutTLapDelegate), Marshal.GetDelegateForFunctionPointer<CutTLapDelegate>(vTable.cutTLapFunctionPtr) },
      { typeof(CutCrossLapDelegate), Marshal.GetDelegateForFunctionPointer<CutCrossLapDelegate>(vTable.cutCrossLapFunctionPtr) },
      { typeof(DeleteProcessesKeepCuttingBodiesDelegate), Marshal.GetDelegateForFunctionPointer<DeleteProcessesKeepCuttingBodiesDelegate>(vTable.deleteProcessesKeepCuttingBodiesFunctionPtr) },
      { typeof(CutDoubleTenonDelegate), Marshal.GetDelegateForFunctionPointer<CutDoubleTenonDelegate>(vTable.cutDoubleTenonFunctionPtr) },
      { typeof(GetCoordinateSystemDataNestingChildDelegate), Marshal.GetDelegateForFunctionPointer<GetCoordinateSystemDataNestingChildDelegate>(vTable.getCoordinateSystemDataNestingChildFunctionPtr) },
      { typeof(CutHalfLapDelegate), Marshal.GetDelegateForFunctionPointer<CutHalfLapDelegate>(vTable.cutHalfLapFunctionPtr) },
      { typeof(CutSimpleScarfDelegate), Marshal.GetDelegateForFunctionPointer<CutSimpleScarfDelegate>(vTable.cutSimpleScarfFunctionPtr) },
      { typeof(CutDiagonalCutDelegate), Marshal.GetDelegateForFunctionPointer<CutDiagonalCutDelegate>(vTable.cutDiagonalCutFunctionPtr) },
      { typeof(ConvertSurfacesToRoofSurfacesDelegate), Marshal.GetDelegateForFunctionPointer<ConvertSurfacesToRoofSurfacesDelegate>(vTable.convertSurfacesToRoofSurfacesFunctionPtr) },
      { typeof(StartStandardElementDialogDelegate), Marshal.GetDelegateForFunctionPointer<StartStandardElementDialogDelegate>(vTable.startStandardElementDialogFunctionPtr) },
      { typeof(RemoveStandardConnectorAxisDelegate), Marshal.GetDelegateForFunctionPointer<RemoveStandardConnectorAxisDelegate>(vTable.removeStandardConnectorAxisFunctionPtr) },
      { typeof(RemoveStandardBeamDelegate), Marshal.GetDelegateForFunctionPointer<RemoveStandardBeamDelegate>(vTable.removeStandardBeamFunctionPtr) },
      { typeof(RemoveStandardPanelDelegate), Marshal.GetDelegateForFunctionPointer<RemoveStandardPanelDelegate>(vTable.removeStandardPanelFunctionPtr) },
      { typeof(RemoveStandardContainerDelegate), Marshal.GetDelegateForFunctionPointer<RemoveStandardContainerDelegate>(vTable.removeStandardContainerFunctionPtr) },
      { typeof(RemoveStandardExportSolidDelegate), Marshal.GetDelegateForFunctionPointer<RemoveStandardExportSolidDelegate>(vTable.removeStandardExportSolidFunctionPtr) },
      { typeof(GetUserElementIDsWithCountDelegate), Marshal.GetDelegateForFunctionPointer<GetUserElementIDsWithCountDelegate>(vTable.getUserElementIDsWithCountFunctionPtr) },
      { typeof(CutScarfStraightDelegate), Marshal.GetDelegateForFunctionPointer<CutScarfStraightDelegate>(vTable.cutScarfStraightFunctionPtr) },
      { typeof(CutScarfDiagonalDelegate), Marshal.GetDelegateForFunctionPointer<CutScarfDiagonalDelegate>(vTable.cutScarfDiagonalFunctionPtr) },
      { typeof(CutScarfWithWedgeDelegate), Marshal.GetDelegateForFunctionPointer<CutScarfWithWedgeDelegate>(vTable.cutScarfWithWedgeFunctionPtr) },
      { typeof(CutBeamEndProfileDelegate), Marshal.GetDelegateForFunctionPointer<CutBeamEndProfileDelegate>(vTable.cutBeamEndProfileFunctionPtr) },
      { typeof(CreateTruncatedConeBeamPointsDelegate), Marshal.GetDelegateForFunctionPointer<CreateTruncatedConeBeamPointsDelegate>(vTable.createTruncatedConeBeamPointsFunctionPtr) },
      { typeof(CreateTruncatedConeBeamVectorsDelegate), Marshal.GetDelegateForFunctionPointer<CreateTruncatedConeBeamVectorsDelegate>(vTable.createTruncatedConeBeamVectorsFunctionPtr) },
      { typeof(CreateSplineLineDelegate), Marshal.GetDelegateForFunctionPointer<CreateSplineLineDelegate>(vTable.createSplineLineFunctionPtr) },
      { typeof(UnJoinElementsDelegate), Marshal.GetDelegateForFunctionPointer<UnJoinElementsDelegate>(vTable.unJoinElementsFunctionPtr) },
      { typeof(UnJoinTopLevelElementsDelegate), Marshal.GetDelegateForFunctionPointer<UnJoinTopLevelElementsDelegate>(vTable.unJoinTopLevelElementsFunctionPtr) },
      { typeof(SetElementGroupSingleSelectModeDelegate), Marshal.GetDelegateForFunctionPointer<SetElementGroupSingleSelectModeDelegate>(vTable.setElementGroupSingleSelectModeFunctionPtr) },
      { typeof(SetElementGroupMultiSelectModeDelegate), Marshal.GetDelegateForFunctionPointer<SetElementGroupMultiSelectModeDelegate>(vTable.setElementGroupMultiSelectModeFunctionPtr) },
      { typeof(GetElementsInCollisionDelegate), Marshal.GetDelegateForFunctionPointer<GetElementsInCollisionDelegate>(vTable.getElementsInCollisionFunctionPtr) },
    };
  }

  public enum StandardElementType
  {
    Beam = 0,
    Panel,
    Vba,
    ExportSolid,
    Container,
    Metal
  };

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public IntPtr GetLastError(IntPtr aErrorCode) => GetDelegate<GetLastErrorDelegate>().Invoke(_nativePtr, aErrorCode);
  public IntPtr GetAllIdentifiableElementIDs() => GetDelegate<GetAllIdentifiableElementIDsDelegate>().Invoke(_nativePtr);
  public IntPtr GetVisibleIdentifiableElementIDs() => GetDelegate<GetVisibleIdentifiableElementIDsDelegate>().Invoke(_nativePtr);
  public IntPtr GetInvisibleIdentifiableElementIDs() => GetDelegate<GetInvisibleIdentifiableElementIDsDelegate>().Invoke(_nativePtr);
  public IntPtr GetActiveIdentifiableElementIDs() => GetDelegate<GetActiveIdentifiableElementIDsDelegate>().Invoke(_nativePtr);
  public IntPtr GetInactiveAllIdentifiableElementIDs() => GetDelegate<GetInactiveAllIdentifiableElementIDsDelegate>().Invoke(_nativePtr);
  public IntPtr GetInactiveVisibleIdentifiableElementIDs() => GetDelegate<GetInactiveVisibleIdentifiableElementIDsDelegate>().Invoke(_nativePtr);
  public void DeleteElements(IntPtr aElementIdList) => GetDelegate<DeleteElementsDelegate>().Invoke(_nativePtr, aElementIdList);
  public void JoinElements(IntPtr aElementIdList) => GetDelegate<JoinElementsDelegate>().Invoke(_nativePtr, aElementIdList);
  public void JoinTopLevelElements(IntPtr aElementIdList) => GetDelegate<JoinTopLevelElementsDelegate>().Invoke(_nativePtr, aElementIdList);
  public ulong CreateRectangularBeamPoints(double aWidth, double aHeight, CVector3 aP1, CVector3 aP2, CVector3 aP3) => GetDelegate<CreateRectangularBeamPointsDelegate>().Invoke(_nativePtr, aWidth, aHeight, aP1, aP2, aP3);
  public ulong CreateCircularBeamPoints(double aDiameter, CVector3 aP1, CVector3 aP2, CVector3 aP3) => GetDelegate<CreateCircularBeamPointsDelegate>().Invoke(_nativePtr, aDiameter, aP1, aP2, aP3);
  public ulong CreateSquareBeamPoints(double aWidth, CVector3 aP1, CVector3 aP2, CVector3 aP3) => GetDelegate<CreateSquareBeamPointsDelegate>().Invoke(_nativePtr, aWidth, aP1, aP2, aP3);
  public ulong CreateRectangularBeamVectors(double aWidth, double aHeight, double aLength, CVector3 aP1, CVector3 aXl, CVector3 aZl) => GetDelegate<CreateRectangularBeamVectorsDelegate>().Invoke(_nativePtr, aWidth, aHeight, aLength, aP1, aXl, aZl);
  public ulong CreateCircularBeamVectors(double aDiameter, double aLength, CVector3 aP1, CVector3 aXl, CVector3 aZl) => GetDelegate<CreateCircularBeamVectorsDelegate>().Invoke(_nativePtr, aDiameter, aLength, aP1, aXl, aZl);
  public ulong CreateSquareBeamVectors(double aWidth, double aLength, CVector3 aP1, CVector3 aXl, CVector3 aZl) => GetDelegate<CreateSquareBeamVectorsDelegate>().Invoke(_nativePtr, aWidth, aLength, aP1, aXl, aZl);
  public ulong CreateRectangularPanelPoints(double aWidth, double aThickness, CVector3 aP1, CVector3 aP2, CVector3 aP3) => GetDelegate<CreateRectangularPanelPointsDelegate>().Invoke(_nativePtr, aWidth, aThickness, aP1, aP2, aP3);
  public ulong CreateRectangularPanelVectors(double aWidth, double aThickness, double aLength, CVector3 aP1, CVector3 aXl, CVector3 aZl) => GetDelegate<CreateRectangularPanelVectorsDelegate>().Invoke(_nativePtr, aWidth, aThickness, aLength, aP1, aXl, aZl);
  public ulong CreateDrillingPoints(double aDiameter, CVector3 aP1, CVector3 aP2) => GetDelegate<CreateDrillingPointsDelegate>().Invoke(_nativePtr, aDiameter, aP1, aP2);
  public ulong CreateDrillingVectors(double aDiameter, double aLength, CVector3 aP1, CVector3 aXl) => GetDelegate<CreateDrillingVectorsDelegate>().Invoke(_nativePtr, aDiameter, aLength, aP1, aXl);
  public ulong CreateLinePoints(CVector3 aP1, CVector3 aP2) => GetDelegate<CreateLinePointsDelegate>().Invoke(_nativePtr, aP1, aP2);
  public ulong CreateLineVectors(double aLength, CVector3 aP1, CVector3 aXl) => GetDelegate<CreateLineVectorsDelegate>().Invoke(_nativePtr, aLength, aP1, aXl);
  public ulong CreateNode(CVector3 aP1) => GetDelegate<CreateNodeDelegate>().Invoke(_nativePtr, aP1);
  public IntPtr SolderElements(IntPtr aElementIdList) => GetDelegate<SolderElementsDelegate>().Invoke(_nativePtr, aElementIdList);
  public void ConvertBeamToPanel(IntPtr aElementIdList) => GetDelegate<ConvertBeamToPanelDelegate>().Invoke(_nativePtr, aElementIdList);
  public void ConvertPanelToBeam(IntPtr aElementIdList) => GetDelegate<ConvertPanelToBeamDelegate>().Invoke(_nativePtr, aElementIdList);
  public void DeleteAllElementEndTypes(IntPtr aElementIdList) => GetDelegate<DeleteAllElementEndTypesDelegate>().Invoke(_nativePtr, aElementIdList);
  public void DeleteAllElementProcesses(IntPtr aElementIdList) => GetDelegate<DeleteAllElementProcessesDelegate>().Invoke(_nativePtr, aElementIdList);
  public void MoveElement(IntPtr aElementIdList, CVector3 aVector) => GetDelegate<MoveElementDelegate>().Invoke(_nativePtr, aElementIdList, aVector);
  public ulong CreatePolygonBeam(IntPtr aPolygonVertices, double aThickness, CVector3 aXl, CVector3 aZl) => GetDelegate<CreatePolygonBeamDelegate>().Invoke(_nativePtr, aPolygonVertices, aThickness, aXl, aZl);
  public ulong CreateTextObject(string aText, CVector3 aPosition, CVector3 aXl, CVector3 aZl, double aSize) => GetDelegate<CreateTextObjectDelegate>().Invoke(_nativePtr, aText, aPosition, aXl, aZl, aSize);
  public IntPtr CopyElements(IntPtr aElementIdList, CVector3 aCopyVector) => GetDelegate<CopyElementsDelegate>().Invoke(_nativePtr, aElementIdList, aCopyVector);
  public void RotateElements(IntPtr aElementIdList, CVector3 aOrigin, CVector3 aRotationAxis, double aRotationAngle) => GetDelegate<RotateElementsDelegate>().Invoke(_nativePtr, aElementIdList, aOrigin, aRotationAxis, aRotationAngle);
  public IntPtr SubtractElements(IntPtr aHardElements, IntPtr aSoftElements) => GetDelegate<SubtractElementsDelegate>().Invoke(_nativePtr, aHardElements, aSoftElements);
  public bool CheckElementId(ulong aId) => GetDelegate<CheckElementIdDelegate>().Invoke(_nativePtr, aId);
  public IntPtr FilterElements(IntPtr aElements, IntPtr aFilter) => GetDelegate<FilterElementsDelegate>().Invoke(_nativePtr, aElements, aFilter);
  public IntPtr MapElements(IntPtr aElements, IntPtr aMapQuery) => GetDelegate<MapElementsDelegate>().Invoke(_nativePtr, aElements, aMapQuery);
  public void StartElementModuleCalculation(IntPtr aCovers) => GetDelegate<StartElementModuleCalculationDelegate>().Invoke(_nativePtr, aCovers);
  public void SetElementDetailPath(string aPath) => GetDelegate<SetElementDetailPathDelegate>().Invoke(_nativePtr, aPath);
  public IntPtr GetElementDetailPath() => GetDelegate<GetElementDetailPathDelegate>().Invoke(_nativePtr);
  public IntPtr GetElementCadworkGuid(ulong aId) => GetDelegate<GetElementCadworkGuidDelegate>().Invoke(_nativePtr, aId);
  public ulong GetElementFromCadworkGuid(string aCadworkGuid) => GetDelegate<GetElementFromCadworkGuidDelegate>().Invoke(_nativePtr, aCadworkGuid);
  public void AddElementsToUndo(IntPtr aElements, int aCmd) => GetDelegate<AddElementsToUndoDelegate>().Invoke(_nativePtr, aElements, aCmd);
  public void MakeUndo() => GetDelegate<MakeUndoDelegate>().Invoke(_nativePtr);
  public void MakeRedo() => GetDelegate<MakeRedoDelegate>().Invoke(_nativePtr);
  public void SplitElements(IntPtr aElements) => GetDelegate<SplitElementsDelegate>().Invoke(_nativePtr, aElements);
  public void SetLineToMarkingLine(IntPtr aElements) => GetDelegate<SetLineToMarkingLineDelegate>().Invoke(_nativePtr, aElements);
  public void SetLineToNormalLine(IntPtr aElements) => GetDelegate<SetLineToNormalLineDelegate>().Invoke(_nativePtr, aElements);
  public ulong CreateAutoExportSolidFromStandard(IntPtr aElements, string aOutputName, string aStandardElementName) => GetDelegate<CreateAutoExportSolidFromStandardDelegate>().Invoke(_nativePtr, aElements, aOutputName, aStandardElementName);
  public void SetElementModulePropertiesForElements(IntPtr aElements, IntPtr aProperties) => GetDelegate<SetElementModulePropertiesForElementsDelegate>().Invoke(_nativePtr, aElements, aProperties);
  public IntPtr GetElementModulePropertiesForElement(ulong aId) => GetDelegate<GetElementModulePropertiesForElementDelegate>().Invoke(_nativePtr, aId);
  public IntPtr GetElementTypeDescription(ulong aId) => GetDelegate<GetElementTypeDescriptionDelegate>().Invoke(_nativePtr, aId);
  public ulong CreateTextObjectWithFont(string aText, CVector3 aPosition, CVector3 aXl, CVector3 aZl, double aSize, string aFontName) => GetDelegate<CreateTextObjectWithFontDelegate>().Invoke(_nativePtr, aText, aPosition, aXl, aZl, aSize, aFontName);
  public IntPtr GetOpeningVariantIDs(IntPtr aElements, int aOpeningType) => GetDelegate<GetOpeningVariantIDsDelegate>().Invoke(_nativePtr, aElements, aOpeningType);
  public ulong GetParentContainerId(ulong aId) => GetDelegate<GetParentContainerIdDelegate>().Invoke(_nativePtr, aId);
  public IntPtr GetExportSolidContentElements(ulong aId) => GetDelegate<GetExportSolidContentElementsDelegate>().Invoke(_nativePtr, aId);
  public IntPtr GetContainerContentElements(ulong aId) => GetDelegate<GetContainerContentElementsDelegate>().Invoke(_nativePtr, aId);
  public void ApplyTransformationCoordinate(IntPtr aElements, CVector3 aOldPoint, CVector3 aOldXl, CVector3 aOldYl, CVector3 aNewPoint, CVector3 aNewXl, CVector3 aNewYl) => GetDelegate<ApplyTransformationCoordinateDelegate>().Invoke(_nativePtr, aElements, aOldPoint, aOldXl, aOldYl, aNewPoint, aNewXl, aNewYl);
  public void DeleteElementsWithUndo(IntPtr aElements) => GetDelegate<DeleteElementsWithUndoDelegate>().Invoke(_nativePtr, aElements);
  public void AddCreatedElementsToUndo(IntPtr aElements) => GetDelegate<AddCreatedElementsToUndoDelegate>().Invoke(_nativePtr, aElements);
  public void AddModifiedElementsToUndo(IntPtr aElements) => GetDelegate<AddModifiedElementsToUndoDelegate>().Invoke(_nativePtr, aElements);
  public void RecreateElements(IntPtr aElements) => GetDelegate<RecreateElementsDelegate>().Invoke(_nativePtr, aElements);
  public bool CheckIfElementsAreInCollision(ulong aFirstElementId, ulong aSecondElementId) => GetDelegate<CheckIfElementsAreInCollisionDelegate>().Invoke(_nativePtr, aFirstElementId, aSecondElementId);
  public bool CheckIfElementsAreInContact(ulong aFirstElementId, ulong aSecondElementId) => GetDelegate<CheckIfElementsAreInContactDelegate>().Invoke(_nativePtr, aFirstElementId, aSecondElementId);
  public void CreateMultiWall(IntPtr aElements) => GetDelegate<CreateMultiWallDelegate>().Invoke(_nativePtr, aElements);
  public IntPtr GetUserElementIDs() => GetDelegate<GetUserElementIDsDelegate>().Invoke(_nativePtr);
  public IntPtr GetElementContactVertices(ulong aFirstId, ulong aSecondId) => GetDelegate<GetElementContactVerticesDelegate>().Invoke(_nativePtr, aFirstId, aSecondId);
  public ulong GetNestingParentId(ulong aId) => GetDelegate<GetNestingParentIdDelegate>().Invoke(_nativePtr, aId);
  public IntPtr GetUserElementIDsWithExisting(IntPtr aElements) => GetDelegate<GetUserElementIDsWithExistingDelegate>().Invoke(_nativePtr, aElements);
  public void ClearErrors() => GetDelegate<ClearErrorsDelegate>().Invoke(_nativePtr);
  public void GlideElements(IntPtr aElementIDs, CVector3 aGlidePoint) => GetDelegate<GlideElementsDelegate>().Invoke(_nativePtr, aElementIDs, aGlidePoint);
  public IntPtr GetElementContactFacets(ulong aFirstId, ulong aSecondId) => GetDelegate<GetElementContactFacetsDelegate>().Invoke(_nativePtr, aFirstId, aSecondId);
  public IntPtr GetElementRawInterfaceVertices(ulong aFirstId, ulong aSecondId) => GetDelegate<GetElementRawInterfaceVerticesDelegate>().Invoke(_nativePtr, aFirstId, aSecondId);
  public bool CutElementsWithMiter(ulong aFirstId, ulong aSecondId) => GetDelegate<CutElementsWithMiterDelegate>().Invoke(_nativePtr, aFirstId, aSecondId);
  public bool CutElementWithPlane(ulong aId, CVector3 aCutPlaneNormalVector, double aDistanceFromGlobalOrigin) => GetDelegate<CutElementWithPlaneDelegate>().Invoke(_nativePtr, aId, aCutPlaneNormalVector, aDistanceFromGlobalOrigin);
  public ulong CreateCircularMep(double aDiameter, IntPtr aPoints) => GetDelegate<CreateCircularMepDelegate>().Invoke(_nativePtr, aDiameter, aPoints);
  public ulong CreateRectangularMep(double aWidth, double aDepth, IntPtr aPoints) => GetDelegate<CreateRectangularMepDelegate>().Invoke(_nativePtr, aWidth, aDepth, aPoints);
  public bool SliceElementWithPlane(ulong aId, CVector3 aCutPlaneNormalVector, double aDistanceFromGlobalOrigin) => GetDelegate<SliceElementWithPlaneDelegate>().Invoke(_nativePtr, aId, aCutPlaneNormalVector, aDistanceFromGlobalOrigin);
  public ulong CreateAutoContainerFromStandard(IntPtr aElements, string aOutputName, string aStandardElementName) => GetDelegate<CreateAutoContainerFromStandardDelegate>().Invoke(_nativePtr, aElements, aOutputName, aStandardElementName);
  public ulong CreateAutoExportSolidFromStandardWithReference(IntPtr aElements, string aOutputName, string aStandardElementName, ulong aReferenceId) => GetDelegate<CreateAutoExportSolidFromStandardWithReferenceDelegate>().Invoke(_nativePtr, aElements, aOutputName, aStandardElementName, aReferenceId);
  public ulong CreateAutoContainerFromStandardWithReference(IntPtr aElements, string aOutputName, string aStandardElementName, ulong aReferenceId) => GetDelegate<CreateAutoContainerFromStandardWithReferenceDelegate>().Invoke(_nativePtr, aElements, aOutputName, aStandardElementName, aReferenceId);
  public IntPtr SliceElementWithPlaneAndGetNewElements(ulong aId, CVector3 aCutPlaneNormalVector, double aDistanceFromGlobalOrigin) => GetDelegate<SliceElementWithPlaneAndGetNewElementsDelegate>().Invoke(_nativePtr, aId, aCutPlaneNormalVector, aDistanceFromGlobalOrigin);
  public ulong CreateSurface(IntPtr aSurfaceVertices) => GetDelegate<CreateSurfaceDelegate>().Invoke(_nativePtr, aSurfaceVertices);
  public void ConvertCircularBeamToDrilling(IntPtr aElements) => GetDelegate<ConvertCircularBeamToDrillingDelegate>().Invoke(_nativePtr, aElements);
  public IntPtr GetStandardExportSolidList() => GetDelegate<GetStandardExportSolidListDelegate>().Invoke(_nativePtr);
  public IntPtr GetStandardContainerList() => GetDelegate<GetStandardContainerListDelegate>().Invoke(_nativePtr);
  public void StretchStartFace(IntPtr aElements, CVector3 aStretchVector) => GetDelegate<StretchStartFaceDelegate>().Invoke(_nativePtr, aElements, aStretchVector);
  public void StretchEndFace(IntPtr aElements, CVector3 aStretchVector) => GetDelegate<StretchEndFaceDelegate>().Invoke(_nativePtr, aElements, aStretchVector);
  public IntPtr GetVariantSiblingElementIDs(ulong aElementId) => GetDelegate<GetVariantSiblingElementIDsDelegate>().Invoke(_nativePtr, aElementId);
  public void SetExportSolidContents(ulong aExportSolidId, IntPtr aElementIDs) => GetDelegate<SetExportSolidContentsDelegate>().Invoke(_nativePtr, aExportSolidId, aElementIDs);
  public void SetContainerContents(ulong aContainerId, IntPtr aElementIDs) => GetDelegate<SetContainerContentsDelegate>().Invoke(_nativePtr, aContainerId, aElementIDs);
  public void SetParentOpeningVariantsOpeningAngle(IntPtr aElementIDs, double aAngle) => GetDelegate<SetParentOpeningVariantsOpeningAngleDelegate>().Invoke(_nativePtr, aElementIDs, aAngle);
  public ulong CreateCircularAxisPoints(double aDiameter, CVector3 aP1, CVector3 aP2) => GetDelegate<CreateCircularAxisPointsDelegate>().Invoke(_nativePtr, aDiameter, aP1, aP2);
  public ulong CreateCircularAxisVector(double aDiameter, double aLength, CVector3 aP1, CVector3 aXl) => GetDelegate<CreateCircularAxisVectorDelegate>().Invoke(_nativePtr, aDiameter, aLength, aP1, aXl);
  public void ConvertElementsToAuxiliaryElements(IntPtr aElements) => GetDelegate<ConvertElementsToAuxiliaryElementsDelegate>().Invoke(_nativePtr, aElements);
  public IntPtr GetElementsInContact(ulong aElement) => GetDelegate<GetElementsInContactDelegate>().Invoke(_nativePtr, aElement);
  public IntPtr GetFacetsWithLasso(IntPtr aElements) => GetDelegate<GetFacetsWithLassoDelegate>().Invoke(_nativePtr, aElements);
  public void CutElementsWithOverMeasure(IntPtr aHardElements, IntPtr aSoftElements) => GetDelegate<CutElementsWithOverMeasureDelegate>().Invoke(_nativePtr, aHardElements, aSoftElements);
  public IntPtr GetEdgeSelection(IntPtr aElements) => GetDelegate<GetEdgeSelectionDelegate>().Invoke(_nativePtr, aElements);
  public ulong CreatePolygonPanel(IntPtr aPolygonVertices, double aThickness, CVector3 aXl, CVector3 aZl) => GetDelegate<CreatePolygonPanelDelegate>().Invoke(_nativePtr, aPolygonVertices, aThickness, aXl, aZl);
  public void MirrorMoveElements(IntPtr aElements, CVector3 aPlane, double aPlaneDistance) => GetDelegate<MirrorMoveElementsDelegate>().Invoke(_nativePtr, aElements, aPlane, aPlaneDistance);
  public IntPtr MirrorCopyElements(IntPtr aElements, CVector3 aPlane, double aPlaneDistance) => GetDelegate<MirrorCopyElementsDelegate>().Invoke(_nativePtr, aElements, aPlane, aPlaneDistance);
  public void ResetElementCadworkGuid(ulong aId) => GetDelegate<ResetElementCadworkGuidDelegate>().Invoke(_nativePtr, aId);
  public IntPtr GetStandardBeamList() => GetDelegate<GetStandardBeamListDelegate>().Invoke(_nativePtr);
  public IntPtr GetStandardPanelList() => GetDelegate<GetStandardPanelListDelegate>().Invoke(_nativePtr);
  public ulong CreateStandardBeamPoints(string aStandardElementName, CVector3 aP1, CVector3 aP2, CVector3 aP3) => GetDelegate<CreateStandardBeamPointsDelegate>().Invoke(_nativePtr, aStandardElementName, aP1, aP2, aP3);
  public ulong CreateStandardBeamVectors(string aStandardElementName, double aLength, CVector3 aP1, CVector3 aXl, CVector3 aZl) => GetDelegate<CreateStandardBeamVectorsDelegate>().Invoke(_nativePtr, aStandardElementName, aLength, aP1, aXl, aZl);
  public ulong CreateStandardPanelPoints(string aStandardElementName, CVector3 aP1, CVector3 aP2, CVector3 aP3) => GetDelegate<CreateStandardPanelPointsDelegate>().Invoke(_nativePtr, aStandardElementName, aP1, aP2, aP3);
  public ulong CreateStandardPanelVectors(string aStandardElementName, double aLength, CVector3 aP1, CVector3 aXl, CVector3 aZl) => GetDelegate<CreateStandardPanelVectorsDelegate>().Invoke(_nativePtr, aStandardElementName, aLength, aP1, aXl, aZl);
  public ulong CreateStandardSteelPoints(string aStandardElementName, CVector3 aP1, CVector3 aP2, CVector3 aP3) => GetDelegate<CreateStandardSteelPointsDelegate>().Invoke(_nativePtr, aStandardElementName, aP1, aP2, aP3);
  public ulong CreateStandardSteelVectors(string aStandardElementName, double aLength, CVector3 aP1, CVector3 aXl, CVector3 aZl) => GetDelegate<CreateStandardSteelVectorsDelegate>().Invoke(_nativePtr, aStandardElementName, aLength, aP1, aXl, aZl);
  public void MoveElementWithUndo(IntPtr aElementIdList, CVector3 aVector) => GetDelegate<MoveElementWithUndoDelegate>().Invoke(_nativePtr, aElementIdList, aVector);
  public ulong CreateLinearOptimization(IntPtr aElements, uint aOptimizationNumber, double aTotalLength, double aStartCut, double aEndCut, double aSawKerf, bool aIsProductionList) => GetDelegate<CreateLinearOptimizationDelegate>().Invoke(_nativePtr, aElements, aOptimizationNumber, aTotalLength, aStartCut, aEndCut, aSawKerf, aIsProductionList);
  public IntPtr CheckElementDuplicates(IntPtr aElements) => GetDelegate<CheckElementDuplicatesDelegate>().Invoke(_nativePtr, aElements);
  public ulong CreateNormalAxisPoints(CVector3 aP1, CVector3 aP2) => GetDelegate<CreateNormalAxisPointsDelegate>().Invoke(_nativePtr, aP1, aP2);
  public ulong CreateNormalAxisVectors(double aLength, CVector3 aP1, CVector3 aXl) => GetDelegate<CreateNormalAxisVectorsDelegate>().Invoke(_nativePtr, aLength, aP1, aXl);
  public void ConvertBoltToStandardConnector(IntPtr aElements, string aStandardElementName) => GetDelegate<ConvertBoltToStandardConnectorDelegate>().Invoke(_nativePtr, aElements, aStandardElementName);
  public ulong GetReferenceElement(ulong aElement) => GetDelegate<GetReferenceElementDelegate>().Invoke(_nativePtr, aElement);
  public ulong ExtrudeSurfaceToAuxiliaryVector(ulong aSurface, CVector3 aVector) => GetDelegate<ExtrudeSurfaceToAuxiliaryVectorDelegate>().Invoke(_nativePtr, aSurface, aVector);
  public ulong ExtrudeSurfaceToPanelVector(ulong aSurface, CVector3 aVector) => GetDelegate<ExtrudeSurfaceToPanelVectorDelegate>().Invoke(_nativePtr, aSurface, aVector);
  public ulong ExtrudeSurfaceToBeamVector(ulong aSurface, CVector3 aVector) => GetDelegate<ExtrudeSurfaceToBeamVectorDelegate>().Invoke(_nativePtr, aSurface, aVector);
  public bool CheckIfPointIsInElement(CVector3 aPoint, ulong aElementId) => GetDelegate<CheckIfPointIsInElementDelegate>().Invoke(_nativePtr, aPoint, aElementId);
  public void ConvertContainerToContainerBlock(IntPtr aElements) => GetDelegate<ConvertContainerToContainerBlockDelegate>().Invoke(_nativePtr, aElements);
  public ulong CreateBoundingBoxLocal(ulong aReferenceElement, IntPtr aElements) => GetDelegate<CreateBoundingBoxLocalDelegate>().Invoke(_nativePtr, aReferenceElement, aElements);
  public ulong CreateBoundingBoxGlobal(IntPtr aElements) => GetDelegate<CreateBoundingBoxGlobalDelegate>().Invoke(_nativePtr, aElements);
  public void CutLogCornerJoint(string aSettingsName, IntPtr aElements) => GetDelegate<CutLogCornerJointDelegate>().Invoke(_nativePtr, aSettingsName, aElements);
  public void ConvertAuxiliaryToPanel(IntPtr aElements) => GetDelegate<ConvertAuxiliaryToPanelDelegate>().Invoke(_nativePtr, aElements);
  public void ConvertAuxiliaryToBeam(IntPtr aElements) => GetDelegate<ConvertAuxiliaryToBeamDelegate>().Invoke(_nativePtr, aElements);
  public void AutoSetRoughVolumeSituation(IntPtr aElements) => GetDelegate<AutoSetRoughVolumeSituationDelegate>().Invoke(_nativePtr, aElements);
  public void RoughVolumeSituationManual(ulong aCover, IntPtr aAddPartner, IntPtr aRemovePartner) => GetDelegate<RoughVolumeSituationManualDelegate>().Invoke(_nativePtr, aCover, aAddPartner, aRemovePartner);
  public void AutoSetPartsSituation(IntPtr aElements) => GetDelegate<AutoSetPartsSituationDelegate>().Invoke(_nativePtr, aElements);
  public void PartsSituationManual(ulong aCover, IntPtr aAddChildren, IntPtr aRemoveChildren) => GetDelegate<PartsSituationManualDelegate>().Invoke(_nativePtr, aCover, aAddChildren, aRemoveChildren);
  public IntPtr ActivateRvWithoutSituation() => GetDelegate<ActivateRvWithoutSituationDelegate>().Invoke(_nativePtr);
  public IntPtr ActivatePartsWithoutSituation() => GetDelegate<ActivatePartsWithoutSituationDelegate>().Invoke(_nativePtr);
  public void AddElementToDetail(IntPtr aElements, int aDetail) => GetDelegate<AddElementToDetailDelegate>().Invoke(_nativePtr, aElements, aDetail);
  public IntPtr GetBoundingBoxVerticesLocal(ulong aReferenceElement, IntPtr aElements) => GetDelegate<GetBoundingBoxVerticesLocalDelegate>().Invoke(_nativePtr, aReferenceElement, aElements);
  public IntPtr GetBoundingBoxVerticesGlobal(IntPtr aElements) => GetDelegate<GetBoundingBoxVerticesGlobalDelegate>().Invoke(_nativePtr, aElements);
  public IntPtr GetAllNestingRawParts() => GetDelegate<GetAllNestingRawPartsDelegate>().Invoke(_nativePtr);
  public IntPtr SubtractElementsWithUndo(IntPtr aHardElements, IntPtr aSoftElements, bool aWithUndo) => GetDelegate<SubtractElementsWithUndoDelegate>().Invoke(_nativePtr, aHardElements, aSoftElements, aWithUndo);
  public void StartElementModuleCalculationSilently(IntPtr aCovers) => GetDelegate<StartElementModuleCalculationSilentlyDelegate>().Invoke(_nativePtr, aCovers);
  public IntPtr GetJoinedElements(ulong aElementId) => GetDelegate<GetJoinedElementsDelegate>().Invoke(_nativePtr, aElementId);
  public IntPtr ReplacePhysicalDrillingsWithDrillingAxes(IntPtr aElements, double aMinimumDiameter, double aMaximumDiameter) => GetDelegate<ReplacePhysicalDrillingsWithDrillingAxesDelegate>().Invoke(_nativePtr, aElements, aMinimumDiameter, aMaximumDiameter);
  public void CutElementWithProcessingGroup(ulong aSoftElement, ulong aProcessing) => GetDelegate<CutElementWithProcessingGroupDelegate>().Invoke(_nativePtr, aSoftElement, aProcessing);
  public ulong CreateTextObjectWithOptions(CVector3 aPosition, CVector3 aXl, CVector3 aZl, IntPtr aTextOptions) => GetDelegate<CreateTextObjectWithOptionsDelegate>().Invoke(_nativePtr, aPosition, aXl, aZl, aTextOptions);
  public ulong CreateStandardElementFromGuidPoints(string aGuid, CVector3 aP1, CVector3 aP2, CVector3 aP3) => GetDelegate<CreateStandardElementFromGuidPointsDelegate>().Invoke(_nativePtr, aGuid, aP1, aP2, aP3);
  public ulong CreateStandardElementFromGuidVectors(string aGuid, double aLength, CVector3 aP1, CVector3 aXl, CVector3 aZl) => GetDelegate<CreateStandardElementFromGuidVectorsDelegate>().Invoke(_nativePtr, aGuid, aLength, aP1, aXl, aZl);
  public void FilletEdge(ulong aElementId, CVector3 aEdgeStart, CVector3 aEdgeEnd, double aRadius) => GetDelegate<FilletEdgeDelegate>().Invoke(_nativePtr, aElementId, aEdgeStart, aEdgeEnd, aRadius);
  public void ChamferEdge(ulong aElementId, CVector3 aEdgeStart, CVector3 aEdgeEnd, double aLength) => GetDelegate<ChamferEdgeDelegate>().Invoke(_nativePtr, aElementId, aEdgeStart, aEdgeEnd, aLength);
  public void ConvertDrillingToCircularBeam(IntPtr aElements) => GetDelegate<ConvertDrillingToCircularBeamDelegate>().Invoke(_nativePtr, aElements);
  public IntPtr ConvertLinesToSurfaces(IntPtr aElements) => GetDelegate<ConvertLinesToSurfacesDelegate>().Invoke(_nativePtr, aElements);
  public ulong ConvertSurfacesToVolume(IntPtr aElements) => GetDelegate<ConvertSurfacesToVolumeDelegate>().Invoke(_nativePtr, aElements);
  public void CutCornerLap(IntPtr aElements, double aDepth, double aClearanceBase, double aClearanceSide, double aBackCut, ulong aDrillingCount, double aDrillingDiameter, double aDrillingTolerance) => GetDelegate<CutCornerLapDelegate>().Invoke(_nativePtr, aElements, aDepth, aClearanceBase, aClearanceSide, aBackCut, aDrillingCount, aDrillingDiameter, aDrillingTolerance);
  public void CutTLap(IntPtr aElements, double aDepth, double aClearanceBase, double aClearanceSide, double aBackCut, ulong aDrillingCount, double aDrillingDiameter, double aDrillingTolerance) => GetDelegate<CutTLapDelegate>().Invoke(_nativePtr, aElements, aDepth, aClearanceBase, aClearanceSide, aBackCut, aDrillingCount, aDrillingDiameter, aDrillingTolerance);
  public void CutCrossLap(IntPtr aElements, double aDepth, double aClearanceBase, double aClearanceSide, ulong aDrillingCount, double aDrillingDiameter, double aDrillingTolerance) => GetDelegate<CutCrossLapDelegate>().Invoke(_nativePtr, aElements, aDepth, aClearanceBase, aClearanceSide, aDrillingCount, aDrillingDiameter, aDrillingTolerance);
  public IntPtr DeleteProcessesKeepCuttingBodies(IntPtr aElements, bool aKeepCuttingElementsOnly) => GetDelegate<DeleteProcessesKeepCuttingBodiesDelegate>().Invoke(_nativePtr, aElements, aKeepCuttingElementsOnly);
  public void CutDoubleTenon(IntPtr aElements, double aDepth1, double aDepth2, double aClearance, double aBackCut, ulong aDrillingCount, double aDrillingDiameter, double aDrillingTolerance) => GetDelegate<CutDoubleTenonDelegate>().Invoke(_nativePtr, aElements, aDepth1, aDepth2, aClearance, aBackCut, aDrillingCount, aDrillingDiameter, aDrillingTolerance);
  public IntPtr GetCoordinateSystemDataNestingChild(ulong aNestingParentId, ulong aNestingChildId) => GetDelegate<GetCoordinateSystemDataNestingChildDelegate>().Invoke(_nativePtr, aNestingParentId, aNestingChildId);
  public void CutHalfLap(IntPtr aElements, double aLength, double aClearanceLength, double aClearanceDepth, ulong aDrillingCount, double aDrillingDiameter, double aDrillingTolerance) => GetDelegate<CutHalfLapDelegate>().Invoke(_nativePtr, aElements, aLength, aClearanceLength, aClearanceDepth, aDrillingCount, aDrillingDiameter, aDrillingTolerance);
  public void CutSimpleScarf(IntPtr aElements, double aLength, double aDepth, double aClearanceLength, double aClearanceDepth, ulong aDrillingCount, double aDrillingDiameter, double aDrillingTolerance) => GetDelegate<CutSimpleScarfDelegate>().Invoke(_nativePtr, aElements, aLength, aDepth, aClearanceLength, aClearanceDepth, aDrillingCount, aDrillingDiameter, aDrillingTolerance);
  public void CutDiagonalCut(IntPtr aElements, double aLength, double aClearanceLength, ulong aDrillingCount, double aDrillingDiameter, double aDrillingTolerance) => GetDelegate<CutDiagonalCutDelegate>().Invoke(_nativePtr, aElements, aLength, aClearanceLength, aDrillingCount, aDrillingDiameter, aDrillingTolerance);
  public void ConvertSurfacesToRoofSurfaces(IntPtr aElements, string aRoofName) => GetDelegate<ConvertSurfacesToRoofSurfacesDelegate>().Invoke(_nativePtr, aElements, aRoofName);
  public IntPtr StartStandardElementDialog(StandardElementType aStandardElementType) => GetDelegate<StartStandardElementDialogDelegate>().Invoke(_nativePtr, aStandardElementType);
  public void RemoveStandardConnectorAxis(string aGuid) => GetDelegate<RemoveStandardConnectorAxisDelegate>().Invoke(_nativePtr, aGuid);
  public void RemoveStandardBeam(string aGuid) => GetDelegate<RemoveStandardBeamDelegate>().Invoke(_nativePtr, aGuid);
  public void RemoveStandardPanel(string aGuid) => GetDelegate<RemoveStandardPanelDelegate>().Invoke(_nativePtr, aGuid);
  public void RemoveStandardContainer(string aGuid) => GetDelegate<RemoveStandardContainerDelegate>().Invoke(_nativePtr, aGuid);
  public void RemoveStandardExportSolid(string aGuid) => GetDelegate<RemoveStandardExportSolidDelegate>().Invoke(_nativePtr, aGuid);
  public IntPtr GetUserElementIDsWithCount(ulong aCount) => GetDelegate<GetUserElementIDsWithCountDelegate>().Invoke(_nativePtr, aCount);
  public void CutScarfStraight(IntPtr aElements, double aLength, double aDepth, double aClearanceLength, double aClearanceDepth, double aClearanceHook, ulong aDrillingCount, double aDrillingDiameter, double aDrillingTolerance) => GetDelegate<CutScarfStraightDelegate>().Invoke(_nativePtr, aElements, aLength, aDepth, aClearanceLength, aClearanceDepth, aClearanceHook, aDrillingCount, aDrillingDiameter, aDrillingTolerance);
  public void CutScarfDiagonal(IntPtr aElements, double aLength, double aDepth, double aClearanceLength, double aClearanceDepth, ulong aDrillingCount, double aDrillingDiameter, double aDrillingTolerance) => GetDelegate<CutScarfDiagonalDelegate>().Invoke(_nativePtr, aElements, aLength, aDepth, aClearanceLength, aClearanceDepth, aDrillingCount, aDrillingDiameter, aDrillingTolerance);
  public void CutScarfWithWedge(IntPtr aElements, double aLength, double aDepth, double aClearanceLength, double aClearanceDepth, double aWedgeWidth, ulong aDrillingCount, double aDrillingDiameter, double aDrillingTolerance) => GetDelegate<CutScarfWithWedgeDelegate>().Invoke(_nativePtr, aElements, aLength, aDepth, aClearanceLength, aClearanceDepth, aWedgeWidth, aDrillingCount, aDrillingDiameter, aDrillingTolerance);
  public void CutBeamEndProfile(IntPtr aElements, string aProfileName, bool aOnStartFace, bool aOnEndFace) => GetDelegate<CutBeamEndProfileDelegate>().Invoke(_nativePtr, aElements, aProfileName, aOnStartFace, aOnEndFace);
  public ulong CreateTruncatedConeBeamPoints(double aStartDiameter, double aEndDiameter, CVector3 aP1, CVector3 aP2, CVector3 aP3) => GetDelegate<CreateTruncatedConeBeamPointsDelegate>().Invoke(_nativePtr, aStartDiameter, aEndDiameter, aP1, aP2, aP3);
  public ulong CreateTruncatedConeBeamVectors(double aStartDiameter, double aEndDiameter, double aLength, CVector3 aP1, CVector3 aXl, CVector3 aZl) => GetDelegate<CreateTruncatedConeBeamVectorsDelegate>().Invoke(_nativePtr, aStartDiameter, aEndDiameter, aLength, aP1, aXl, aZl);
  public ulong CreateSplineLine(IntPtr aSplinePoints) => GetDelegate<CreateSplineLineDelegate>().Invoke(_nativePtr, aSplinePoints);
  public bool UnJoinElements(IntPtr aElementIdList) => GetDelegate<UnJoinElementsDelegate>().Invoke(_nativePtr, aElementIdList);
  public bool UnJoinTopLevelElements(IntPtr aElementIdList) => GetDelegate<UnJoinTopLevelElementsDelegate>().Invoke(_nativePtr, aElementIdList);
  public void SetElementGroupSingleSelectMode() => GetDelegate<SetElementGroupSingleSelectModeDelegate>().Invoke(_nativePtr);
  public void SetElementGroupMultiSelectMode() => GetDelegate<SetElementGroupMultiSelectModeDelegate>().Invoke(_nativePtr);
  public IntPtr GetElementsInCollision(ulong aElement) => GetDelegate<GetElementsInCollisionDelegate>().Invoke(_nativePtr, aElement);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class ElementControllerInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr getLastErrorFunctionPtr;
    internal IntPtr getAllIdentifiableElementIDsFunctionPtr;
    internal IntPtr getVisibleIdentifiableElementIDsFunctionPtr;
    internal IntPtr getInvisibleIdentifiableElementIDsFunctionPtr;
    internal IntPtr getActiveIdentifiableElementIDsFunctionPtr;
    internal IntPtr getInactiveAllIdentifiableElementIDsFunctionPtr;
    internal IntPtr getInactiveVisibleIdentifiableElementIDsFunctionPtr;
    internal IntPtr deleteElementsFunctionPtr;
    internal IntPtr joinElementsFunctionPtr;
    internal IntPtr joinTopLevelElementsFunctionPtr;
    internal IntPtr createRectangularBeamPointsFunctionPtr;
    internal IntPtr createCircularBeamPointsFunctionPtr;
    internal IntPtr createSquareBeamPointsFunctionPtr;
    internal IntPtr createRectangularBeamVectorsFunctionPtr;
    internal IntPtr createCircularBeamVectorsFunctionPtr;
    internal IntPtr createSquareBeamVectorsFunctionPtr;
    internal IntPtr createRectangularPanelPointsFunctionPtr;
    internal IntPtr createRectangularPanelVectorsFunctionPtr;
    internal IntPtr createDrillingPointsFunctionPtr;
    internal IntPtr createDrillingVectorsFunctionPtr;
    internal IntPtr createLinePointsFunctionPtr;
    internal IntPtr createLineVectorsFunctionPtr;
    internal IntPtr createNodeFunctionPtr;
    internal IntPtr solderElementsFunctionPtr;
    internal IntPtr convertBeamToPanelFunctionPtr;
    internal IntPtr convertPanelToBeamFunctionPtr;
    internal IntPtr deleteAllElementEndTypesFunctionPtr;
    internal IntPtr deleteAllElementProcessesFunctionPtr;
    internal IntPtr moveElementFunctionPtr;
    internal IntPtr createPolygonBeamFunctionPtr;
    internal IntPtr createTextObjectFunctionPtr;
    internal IntPtr copyElementsFunctionPtr;
    internal IntPtr rotateElementsFunctionPtr;
    internal IntPtr subtractElementsFunctionPtr;
    internal IntPtr checkElementIdFunctionPtr;
    internal IntPtr filterElementsFunctionPtr;
    internal IntPtr mapElementsFunctionPtr;
    internal IntPtr startElementModuleCalculationFunctionPtr;
    internal IntPtr setElementDetailPathFunctionPtr;
    internal IntPtr getElementDetailPathFunctionPtr;
    internal IntPtr getElementCadworkGuidFunctionPtr;
    internal IntPtr getElementFromCadworkGuidFunctionPtr;
    internal IntPtr addElementsToUndoFunctionPtr;
    internal IntPtr makeUndoFunctionPtr;
    internal IntPtr makeRedoFunctionPtr;
    internal IntPtr splitElementsFunctionPtr;
    internal IntPtr setLineToMarkingLineFunctionPtr;
    internal IntPtr setLineToNormalLineFunctionPtr;
    internal IntPtr createAutoExportSolidFromStandardFunctionPtr;
    internal IntPtr setElementModulePropertiesForElementsFunctionPtr;
    internal IntPtr getElementModulePropertiesForElementFunctionPtr;
    internal IntPtr getElementTypeDescriptionFunctionPtr;
    internal IntPtr createTextObjectWithFontFunctionPtr;
    internal IntPtr getOpeningVariantIDsFunctionPtr;
    internal IntPtr getParentContainerIdFunctionPtr;
    internal IntPtr getExportSolidContentElementsFunctionPtr;
    internal IntPtr getContainerContentElementsFunctionPtr;
    internal IntPtr applyTransformationCoordinateFunctionPtr;
    internal IntPtr deleteElementsWithUndoFunctionPtr;
    internal IntPtr addCreatedElementsToUndoFunctionPtr;
    internal IntPtr addModifiedElementsToUndoFunctionPtr;
    internal IntPtr recreateElementsFunctionPtr;
    internal IntPtr checkIfElementsAreInCollisionFunctionPtr;
    internal IntPtr checkIfElementsAreInContactFunctionPtr;
    internal IntPtr createMultiWallFunctionPtr;
    internal IntPtr getUserElementIDsFunctionPtr;
    internal IntPtr getElementContactVerticesFunctionPtr;
    internal IntPtr getNestingParentIdFunctionPtr;
    internal IntPtr getUserElementIDsWithExistingFunctionPtr;
    internal IntPtr clearErrorsFunctionPtr;
    internal IntPtr glideElementsFunctionPtr;
    internal IntPtr getElementContactFacetsFunctionPtr;
    internal IntPtr getElementRawInterfaceVerticesFunctionPtr;
    internal IntPtr cutElementsWithMiterFunctionPtr;
    internal IntPtr cutElementWithPlaneFunctionPtr;
    internal IntPtr createCircularMEPFunctionPtr;
    internal IntPtr createRectangularMEPFunctionPtr;
    internal IntPtr sliceElementWithPlaneFunctionPtr;
    internal IntPtr createAutoContainerFromStandardFunctionPtr;
    internal IntPtr createAutoExportSolidFromStandardWithReferenceFunctionPtr;
    internal IntPtr createAutoContainerFromStandardWithReferenceFunctionPtr;
    internal IntPtr sliceElementWithPlaneAndGetNewElementsFunctionPtr;
    internal IntPtr createSurfaceFunctionPtr;
    internal IntPtr convertCircularBeamToDrillingFunctionPtr;
    internal IntPtr getStandardExportSolidListFunctionPtr;
    internal IntPtr getStandardContainerListFunctionPtr;
    internal IntPtr stretchStartFaceFunctionPtr;
    internal IntPtr stretchEndFaceFunctionPtr;
    internal IntPtr getVariantSiblingElementIDsFunctionPtr;
    internal IntPtr setExportSolidContentsFunctionPtr;
    internal IntPtr setContainerContentsFunctionPtr;
    internal IntPtr setParentOpeningVariantsOpeningAngleFunctionPtr;
    internal IntPtr createCircularAxisPointsFunctionPtr;
    internal IntPtr createCircularAxisVectorFunctionPtr;
    internal IntPtr convertElementsToAuxiliaryElementsFunctionPtr;
    internal IntPtr getElementsInContactFunctionPtr;
    internal IntPtr getFacetsWithLassoFunctionPtr;
    internal IntPtr cutElementsWithOverMeasureFunctionPtr;
    internal IntPtr getEdgeSelectionFunctionPtr;
    internal IntPtr createPolygonPanelFunctionPtr;
    internal IntPtr mirrorMoveElementsFunctionPtr;
    internal IntPtr mirrorCopyElementsFunctionPtr;
    internal IntPtr resetElementCadworkGuidFunctionPtr;
    internal IntPtr getStandardBeamListFunctionPtr;
    internal IntPtr getStandardPanelListFunctionPtr;
    internal IntPtr createStandardBeamPointsFunctionPtr;
    internal IntPtr createStandardBeamVectorsFunctionPtr;
    internal IntPtr createStandardPanelPointsFunctionPtr;
    internal IntPtr createStandardPanelVectorsFunctionPtr;
    internal IntPtr createStandardSteelPointsFunctionPtr;
    internal IntPtr createStandardSteelVectorsFunctionPtr;
    internal IntPtr moveElementWithUndoFunctionPtr;
    internal IntPtr createLinearOptimizationFunctionPtr;
    internal IntPtr checkElementDuplicatesFunctionPtr;
    internal IntPtr createNormalAxisPointsFunctionPtr;
    internal IntPtr createNormalAxisVectorsFunctionPtr;
    internal IntPtr convertBoltToStandardConnectorFunctionPtr;
    internal IntPtr getReferenceElementFunctionPtr;
    internal IntPtr extrudeSurfaceToAuxiliaryVectorFunctionPtr;
    internal IntPtr extrudeSurfaceToPanelVectorFunctionPtr;
    internal IntPtr extrudeSurfaceToBeamVectorFunctionPtr;
    internal IntPtr checkIfPointIsInElementFunctionPtr;
    internal IntPtr checkIfPointIsOnElementFunctionPtr;
    internal IntPtr convertContainerToContainerBlockFunctionPtr;
    internal IntPtr createBoundingBoxLocalFunctionPtr;
    internal IntPtr createBoundingBoxGlobalFunctionPtr;
    internal IntPtr cutLogCornerJointFunctionPtr;
    internal IntPtr convertAuxiliaryToPanelFunctionPtr;
    internal IntPtr convertAuxiliaryToBeamFunctionPtr;
    internal IntPtr autoSetRoughVolumeSituationFunctionPtr;
    internal IntPtr roughVolumeSituationManualFunctionPtr;
    internal IntPtr autoSetPartsSituationFunctionPtr;
    internal IntPtr partsSituationManualFunctionPtr;
    internal IntPtr activateRvWithoutSituationFunctionPtr;
    internal IntPtr activatePartsWithoutSituationFunctionPtr;
    internal IntPtr addElementToDetailFunctionPtr;
    internal IntPtr getBoundingBoxVerticesLocalFunctionPtr;
    internal IntPtr getBoundingBoxVerticesGlobalFunctionPtr;
    internal IntPtr getAllNestingRawPartsFunctionPtr;
    internal IntPtr subtractElementsWithUndoFunctionPtr;
    internal IntPtr startElementModuleCalculationSilentlyFunctionPtr;
    internal IntPtr getJoinedElementsFunctionPtr;
    internal IntPtr replacePhysicalDrillingsWithDrillingAxesFunctionPtr;
    internal IntPtr cutElementWithProcessingGroupFunctionPtr;
    internal IntPtr createTextObjectWithOptionsFunctionPtr;
    internal IntPtr createStandardElementFromGuidPointsFunctionPtr;
    internal IntPtr createStandardElementFromGuidVectorsFunctionPtr;
    internal IntPtr filletEdgeFunctionPtr;
    internal IntPtr chamferEdgeFunctionPtr;
    internal IntPtr convertDrillingToCircularBeamFunctionPtr;
    internal IntPtr convertLinesToSurfacesFunctionPtr;
    internal IntPtr convertSurfacesToVolumeFunctionPtr;
    internal IntPtr cutCornerLapFunctionPtr;
    internal IntPtr cutTLapFunctionPtr;
    internal IntPtr cutCrossLapFunctionPtr;
    internal IntPtr deleteProcessesKeepCuttingBodiesFunctionPtr;
    internal IntPtr cutDoubleTenonFunctionPtr;
    internal IntPtr getCoordinateSystemDataNestingChildFunctionPtr;
    internal IntPtr cutHalfLapFunctionPtr;
    internal IntPtr cutSimpleScarfFunctionPtr;
    internal IntPtr cutDiagonalCutFunctionPtr;
    internal IntPtr convertSurfacesToRoofSurfacesFunctionPtr;
    internal IntPtr startStandardElementDialogFunctionPtr;
    internal IntPtr removeStandardConnectorAxisFunctionPtr;
    internal IntPtr removeStandardBeamFunctionPtr;
    internal IntPtr removeStandardPanelFunctionPtr;
    internal IntPtr removeStandardContainerFunctionPtr;
    internal IntPtr removeStandardExportSolidFunctionPtr;
    internal IntPtr getUserElementIDsWithCountFunctionPtr;
    internal IntPtr cutScarfStraightFunctionPtr;
    internal IntPtr cutScarfDiagonalFunctionPtr;
    internal IntPtr cutScarfWithWedgeFunctionPtr;
    internal IntPtr cutBeamEndProfileFunctionPtr;
    internal IntPtr createTruncatedConeBeamPointsFunctionPtr;
    internal IntPtr createTruncatedConeBeamVectorsFunctionPtr;
    internal IntPtr createSplineLineFunctionPtr;
    internal IntPtr unJoinElementsFunctionPtr;
    internal IntPtr unJoinTopLevelElementsFunctionPtr;
    internal IntPtr setElementGroupSingleSelectModeFunctionPtr;
    internal IntPtr setElementGroupMultiSelectModeFunctionPtr;
    internal IntPtr getElementsInCollisionFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetLastErrorDelegate(IntPtr thisPtr, IntPtr aErrorCode);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAllIdentifiableElementIDsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetVisibleIdentifiableElementIDsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetInvisibleIdentifiableElementIDsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetActiveIdentifiableElementIDsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetInactiveAllIdentifiableElementIDsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetInactiveVisibleIdentifiableElementIDsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DeleteElementsDelegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void JoinElementsDelegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void JoinTopLevelElementsDelegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateRectangularBeamPointsDelegate(IntPtr thisPtr, double aWidth, double aHeight, CVector3 aP1, CVector3 aP2, CVector3 aP3);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateCircularBeamPointsDelegate(IntPtr thisPtr, double aDiameter, CVector3 aP1, CVector3 aP2, CVector3 aP3);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateSquareBeamPointsDelegate(IntPtr thisPtr, double aWidth, CVector3 aP1, CVector3 aP2, CVector3 aP3);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateRectangularBeamVectorsDelegate(IntPtr thisPtr, double aWidth, double aHeight, double aLength, CVector3 aP1, CVector3 aXl, CVector3 aZl);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateCircularBeamVectorsDelegate(IntPtr thisPtr, double aDiameter, double aLength, CVector3 aP1, CVector3 aXl, CVector3 aZl);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateSquareBeamVectorsDelegate(IntPtr thisPtr, double aWidth, double aLength, CVector3 aP1, CVector3 aXl, CVector3 aZl);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateRectangularPanelPointsDelegate(IntPtr thisPtr, double aWidth, double aThickness, CVector3 aP1, CVector3 aP2, CVector3 aP3);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateRectangularPanelVectorsDelegate(IntPtr thisPtr, double aWidth, double aThickness, double aLength, CVector3 aP1, CVector3 aXl, CVector3 aZl);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateDrillingPointsDelegate(IntPtr thisPtr, double aDiameter, CVector3 aP1, CVector3 aP2);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateDrillingVectorsDelegate(IntPtr thisPtr, double aDiameter, double aLength, CVector3 aP1, CVector3 aXl);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateLinePointsDelegate(IntPtr thisPtr, CVector3 aP1, CVector3 aP2);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateLineVectorsDelegate(IntPtr thisPtr, double aLength, CVector3 aP1, CVector3 aXl);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateNodeDelegate(IntPtr thisPtr, CVector3 aP1);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr SolderElementsDelegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ConvertBeamToPanelDelegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ConvertPanelToBeamDelegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DeleteAllElementEndTypesDelegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DeleteAllElementProcessesDelegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void MoveElementDelegate(IntPtr thisPtr, IntPtr aElementIdList, CVector3 aVector);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreatePolygonBeamDelegate(IntPtr thisPtr, IntPtr aPolygonVertices, double aThickness, CVector3 aXl, CVector3 aZl);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateTextObjectDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aText, CVector3 aPosition, CVector3 aXl, CVector3 aZl, double aSize);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CopyElementsDelegate(IntPtr thisPtr, IntPtr aElementIdList, CVector3 aCopyVector);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void RotateElementsDelegate(IntPtr thisPtr, IntPtr aElementIdList, CVector3 aOrigin, CVector3 aRotationAxis, double aRotationAngle);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr SubtractElementsDelegate(IntPtr thisPtr, IntPtr aHardElements, IntPtr aSoftElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool CheckElementIdDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr FilterElementsDelegate(IntPtr thisPtr, IntPtr aElements, IntPtr aFilter);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr MapElementsDelegate(IntPtr thisPtr, IntPtr aElements, IntPtr aMapQuery);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void StartElementModuleCalculationDelegate(IntPtr thisPtr, IntPtr aCovers);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetElementDetailPathDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aPath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetElementDetailPathDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetElementCadworkGuidDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong GetElementFromCadworkGuidDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aCadworkGuid);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void AddElementsToUndoDelegate(IntPtr thisPtr, IntPtr aElements, int aCmd);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void MakeUndoDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void MakeRedoDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SplitElementsDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetLineToMarkingLineDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetLineToNormalLineDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateAutoExportSolidFromStandardDelegate(IntPtr thisPtr, IntPtr aElements, [MarshalAs(UnmanagedType.LPWStr)] string aOutputName, [MarshalAs(UnmanagedType.LPWStr)] string aStandardElementName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetElementModulePropertiesForElementsDelegate(IntPtr thisPtr, IntPtr aElements, IntPtr aProperties);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetElementModulePropertiesForElementDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetElementTypeDescriptionDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateTextObjectWithFontDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aText, CVector3 aPosition, CVector3 aXl, CVector3 aZl, double aSize, [MarshalAs(UnmanagedType.LPWStr)] string aFontName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetOpeningVariantIDsDelegate(IntPtr thisPtr, IntPtr aElements, int aOpeningType);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong GetParentContainerIdDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetExportSolidContentElementsDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetContainerContentElementsDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ApplyTransformationCoordinateDelegate(IntPtr thisPtr, IntPtr aElements, CVector3 aOldPoint, CVector3 aOldXl, CVector3 aOldYl, CVector3 aNewPoint, CVector3 aNewXl, CVector3 aNewYl);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DeleteElementsWithUndoDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void AddCreatedElementsToUndoDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void AddModifiedElementsToUndoDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void RecreateElementsDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool CheckIfElementsAreInCollisionDelegate(IntPtr thisPtr, ulong aFirstElementId, ulong aSecondElementId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool CheckIfElementsAreInContactDelegate(IntPtr thisPtr, ulong aFirstElementId, ulong aSecondElementId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void CreateMultiWallDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetUserElementIDsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetElementContactVerticesDelegate(IntPtr thisPtr, ulong aFirstId, ulong aSecondId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong GetNestingParentIdDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetUserElementIDsWithExistingDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ClearErrorsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void GlideElementsDelegate(IntPtr thisPtr, IntPtr aElementIDs, CVector3 aGlidePoint);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetElementContactFacetsDelegate(IntPtr thisPtr, ulong aFirstId, ulong aSecondId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetElementRawInterfaceVerticesDelegate(IntPtr thisPtr, ulong aFirstId, ulong aSecondId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool CutElementsWithMiterDelegate(IntPtr thisPtr, ulong aFirstId, ulong aSecondId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool CutElementWithPlaneDelegate(IntPtr thisPtr, ulong aId, CVector3 aCutPlaneNormalVector, double aDistanceFromGlobalOrigin);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateCircularMepDelegate(IntPtr thisPtr, double aDiameter, IntPtr aPoints);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateRectangularMepDelegate(IntPtr thisPtr, double aWidth, double aDepth, IntPtr aPoints);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool SliceElementWithPlaneDelegate(IntPtr thisPtr, ulong aId, CVector3 aCutPlaneNormalVector, double aDistanceFromGlobalOrigin);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateAutoContainerFromStandardDelegate(IntPtr thisPtr, IntPtr aElements, [MarshalAs(UnmanagedType.LPWStr)] string aOutputName, [MarshalAs(UnmanagedType.LPWStr)] string aStandardElementName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateAutoExportSolidFromStandardWithReferenceDelegate(IntPtr thisPtr, IntPtr aElements, [MarshalAs(UnmanagedType.LPWStr)] string aOutputName, [MarshalAs(UnmanagedType.LPWStr)] string aStandardElementName, ulong aReferenceId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateAutoContainerFromStandardWithReferenceDelegate(IntPtr thisPtr, IntPtr aElements, [MarshalAs(UnmanagedType.LPWStr)] string aOutputName, [MarshalAs(UnmanagedType.LPWStr)] string aStandardElementName, ulong aReferenceId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr SliceElementWithPlaneAndGetNewElementsDelegate(IntPtr thisPtr, ulong aId, CVector3 aCutPlaneNormalVector, double aDistanceFromGlobalOrigin);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateSurfaceDelegate(IntPtr thisPtr, IntPtr aSurfaceVertices);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ConvertCircularBeamToDrillingDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetStandardExportSolidListDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetStandardContainerListDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void StretchStartFaceDelegate(IntPtr thisPtr, IntPtr aElements, CVector3 aStretchVector);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void StretchEndFaceDelegate(IntPtr thisPtr, IntPtr aElements, CVector3 aStretchVector);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetVariantSiblingElementIDsDelegate(IntPtr thisPtr, ulong aElementId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetExportSolidContentsDelegate(IntPtr thisPtr, ulong aExportSolidId, IntPtr aElementIDs);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetContainerContentsDelegate(IntPtr thisPtr, ulong aContainerId, IntPtr aElementIDs);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetParentOpeningVariantsOpeningAngleDelegate(IntPtr thisPtr, IntPtr aElementIDs, double aAngle);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateCircularAxisPointsDelegate(IntPtr thisPtr, double aDiameter, CVector3 aP1, CVector3 aP2);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateCircularAxisVectorDelegate(IntPtr thisPtr, double aDiameter, double aLength, CVector3 aP1, CVector3 aXl);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ConvertElementsToAuxiliaryElementsDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetElementsInContactDelegate(IntPtr thisPtr, ulong aElement);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetFacetsWithLassoDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void CutElementsWithOverMeasureDelegate(IntPtr thisPtr, IntPtr aHardElements, IntPtr aSoftElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetEdgeSelectionDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreatePolygonPanelDelegate(IntPtr thisPtr, IntPtr aPolygonVertices, double aThickness, CVector3 aXl, CVector3 aZl);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void MirrorMoveElementsDelegate(IntPtr thisPtr, IntPtr aElements, CVector3 aPlane, double aPlaneDistance);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr MirrorCopyElementsDelegate(IntPtr thisPtr, IntPtr aElements, CVector3 aPlane, double aPlaneDistance);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ResetElementCadworkGuidDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetStandardBeamListDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetStandardPanelListDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateStandardBeamPointsDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aStandardElementName, CVector3 aP1, CVector3 aP2, CVector3 aP3);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateStandardBeamVectorsDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aStandardElementName, double aLength, CVector3 aP1, CVector3 aXl, CVector3 aZl);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateStandardPanelPointsDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aStandardElementName, CVector3 aP1, CVector3 aP2, CVector3 aP3);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateStandardPanelVectorsDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aStandardElementName, double aLength, CVector3 aP1, CVector3 aXl, CVector3 aZl);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateStandardSteelPointsDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aStandardElementName, CVector3 aP1, CVector3 aP2, CVector3 aP3);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateStandardSteelVectorsDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aStandardElementName, double aLength, CVector3 aP1, CVector3 aXl, CVector3 aZl);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void MoveElementWithUndoDelegate(IntPtr thisPtr, IntPtr aElementIdList, CVector3 aVector);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateLinearOptimizationDelegate(IntPtr thisPtr, IntPtr aElements, uint aOptimizationNumber, double aTotalLength, double aStartCut, double aEndCut, double aSawKerf, bool aIsProductionList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CheckElementDuplicatesDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateNormalAxisPointsDelegate(IntPtr thisPtr, CVector3 aP1, CVector3 aP2);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateNormalAxisVectorsDelegate(IntPtr thisPtr, double aLength, CVector3 aP1, CVector3 aXl);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ConvertBoltToStandardConnectorDelegate(IntPtr thisPtr, IntPtr aElements, [MarshalAs(UnmanagedType.LPWStr)] string aStandardElementName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong GetReferenceElementDelegate(IntPtr thisPtr, ulong aElement);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong ExtrudeSurfaceToAuxiliaryVectorDelegate(IntPtr thisPtr, ulong aSurface, CVector3 aVector);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong ExtrudeSurfaceToPanelVectorDelegate(IntPtr thisPtr, ulong aSurface, CVector3 aVector);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong ExtrudeSurfaceToBeamVectorDelegate(IntPtr thisPtr, ulong aSurface, CVector3 aVector);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool CheckIfPointIsInElementDelegate(IntPtr thisPtr, CVector3 aPoint, ulong aElementId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool CheckIfPointIsOnElementDelegate(IntPtr thisPtr, CVector3 aPoint, ulong aElementId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ConvertContainerToContainerBlockDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateBoundingBoxLocalDelegate(IntPtr thisPtr, ulong aReferenceElement, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateBoundingBoxGlobalDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void CutLogCornerJointDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aSettingsName, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ConvertAuxiliaryToPanelDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ConvertAuxiliaryToBeamDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void AutoSetRoughVolumeSituationDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void RoughVolumeSituationManualDelegate(IntPtr thisPtr, ulong aCover, IntPtr aAddPartner, IntPtr aRemovePartner);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void AutoSetPartsSituationDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void PartsSituationManualDelegate(IntPtr thisPtr, ulong aCover, IntPtr aAddChildren, IntPtr aRemoveChildren);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr ActivateRvWithoutSituationDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr ActivatePartsWithoutSituationDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void AddElementToDetailDelegate(IntPtr thisPtr, IntPtr aElements, int aDetail);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetBoundingBoxVerticesLocalDelegate(IntPtr thisPtr, ulong aReferenceElement, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetBoundingBoxVerticesGlobalDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAllNestingRawPartsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr SubtractElementsWithUndoDelegate(IntPtr thisPtr, IntPtr aHardElements, IntPtr aSoftElements, bool aWithUndo);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void StartElementModuleCalculationSilentlyDelegate(IntPtr thisPtr, IntPtr aCovers);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetJoinedElementsDelegate(IntPtr thisPtr, ulong aElementId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr ReplacePhysicalDrillingsWithDrillingAxesDelegate(IntPtr thisPtr, IntPtr aElements, double aMinimumDiameter, double aMaximumDiameter);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void CutElementWithProcessingGroupDelegate(IntPtr thisPtr, ulong aSoftElement, ulong aProcessing);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateTextObjectWithOptionsDelegate(IntPtr thisPtr, CVector3 aPosition, CVector3 aXl, CVector3 aZl, IntPtr aTextOptions);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateStandardElementFromGuidPointsDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aGuid, CVector3 aP1, CVector3 aP2, CVector3 aP3);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateStandardElementFromGuidVectorsDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aGuid, double aLength, CVector3 aP1, CVector3 aXl, CVector3 aZl);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void FilletEdgeDelegate(IntPtr thisPtr, ulong aElementId, CVector3 aEdgeStart, CVector3 aEdgeEnd, double aRadius);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ChamferEdgeDelegate(IntPtr thisPtr, ulong aElementId, CVector3 aEdgeStart, CVector3 aEdgeEnd, double aLength);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ConvertDrillingToCircularBeamDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr ConvertLinesToSurfacesDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong ConvertSurfacesToVolumeDelegate(IntPtr thisPtr, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void CutCornerLapDelegate(IntPtr thisPtr, IntPtr aElements, double aDepth, double aClearanceBase, double aClearanceSide, double aBackCut, ulong aDrillingCount, double aDrillingDiameter, double aDrillingTolerance);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void CutTLapDelegate(IntPtr thisPtr, IntPtr aElements, double aDepth, double aClearanceBase, double aClearanceSide, double aBackCut, ulong aDrillingCount, double aDrillingDiameter, double aDrillingTolerance);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void CutCrossLapDelegate(IntPtr thisPtr, IntPtr aElements, double aDepth, double aClearanceBase, double aClearanceSide, ulong aDrillingCount, double aDrillingDiameter, double aDrillingTolerance);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr DeleteProcessesKeepCuttingBodiesDelegate(IntPtr thisPtr, IntPtr aElements, bool aKeepCuttingElementsOnly);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void CutDoubleTenonDelegate(IntPtr thisPtr, IntPtr aElements, double aDepth1, double aDepth2, double aClearance, double aBackCut, ulong aDrillingCount, double aDrillingDiameter, double aDrillingTolerance);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetCoordinateSystemDataNestingChildDelegate(IntPtr thisPtr, ulong aNestingParentId, ulong aNestingChildId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void CutHalfLapDelegate(IntPtr thisPtr, IntPtr aElements, double aLength, double aClearanceLength, double aClearanceDepth, ulong aDrillingCount, double aDrillingDiameter, double aDrillingTolerance);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void CutSimpleScarfDelegate(IntPtr thisPtr, IntPtr aElements, double aLength, double aDepth, double aClearanceLength, double aClearanceDepth, ulong aDrillingCount, double aDrillingDiameter, double aDrillingTolerance);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void CutDiagonalCutDelegate(IntPtr thisPtr, IntPtr aElements, double aLength, double aClearanceLength, ulong aDrillingCount, double aDrillingDiameter, double aDrillingTolerance);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ConvertSurfacesToRoofSurfacesDelegate(IntPtr thisPtr, IntPtr aElements, [MarshalAs(UnmanagedType.LPWStr)] string aRoofName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr StartStandardElementDialogDelegate(IntPtr thisPtr, StandardElementType aStandardElementType);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void RemoveStandardConnectorAxisDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aGuid);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void RemoveStandardBeamDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aGuid);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void RemoveStandardPanelDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aGuid);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void RemoveStandardContainerDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aGuid);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void RemoveStandardExportSolidDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aGuid);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetUserElementIDsWithCountDelegate(IntPtr thisPtr, ulong aCount);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void CutScarfStraightDelegate(IntPtr thisPtr, IntPtr aElements, double aLength, double aDepth, double aClearanceLength, double aClearanceDepth, double aClearanceHook, ulong aDrillingCount, double aDrillingDiameter, double aDrillingTolerance);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void CutScarfDiagonalDelegate(IntPtr thisPtr, IntPtr aElements, double aLength, double aDepth, double aClearanceLength, double aClearanceDepth, ulong aDrillingCount, double aDrillingDiameter, double aDrillingTolerance);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void CutScarfWithWedgeDelegate(IntPtr thisPtr, IntPtr aElements, double aLength, double aDepth, double aClearanceLength, double aClearanceDepth, double aWedgeWidth, ulong aDrillingCount, double aDrillingDiameter, double aDrillingTolerance);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void CutBeamEndProfileDelegate(IntPtr thisPtr, IntPtr aElements, [MarshalAs(UnmanagedType.LPWStr)] string aProfileName, bool aOnStartFace, bool aOnEndFace);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateTruncatedConeBeamPointsDelegate(IntPtr thisPtr, double aStartDiameter, double aEndDiameter, CVector3 aP1, CVector3 aP2, CVector3 aP3);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateTruncatedConeBeamVectorsDelegate(IntPtr thisPtr, double aStartDiameter, double aEndDiameter, double aLength, CVector3 aP1, CVector3 aXl, CVector3 aZl);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateSplineLineDelegate(IntPtr thisPtr, IntPtr aSplinePoints);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool UnJoinElementsDelegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool UnJoinTopLevelElementsDelegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetElementGroupSingleSelectModeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetElementGroupMultiSelectModeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetElementsInCollisionDelegate(IntPtr thisPtr, ulong aElement);
}
