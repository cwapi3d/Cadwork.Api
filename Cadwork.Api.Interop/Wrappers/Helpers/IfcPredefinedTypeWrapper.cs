// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Helpers;

public class IfcPredefinedTypeWrapper
{
  public readonly IntPtr NativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public IfcPredefinedTypeWrapper(IntPtr nativePtr)
  {
    NativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<IfcPredefinedTypeInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(DestroyDelegate), Marshal.GetDelegateForFunctionPointer<DestroyDelegate>(vTable!.destroyFunctionPtr) },
      { typeof(IsNoneDelegate), Marshal.GetDelegateForFunctionPointer<IsNoneDelegate>(vTable.isNoneFunctionPtr) },
      { typeof(IsCeilingDelegate), Marshal.GetDelegateForFunctionPointer<IsCeilingDelegate>(vTable.isCeilingFunctionPtr) },
      { typeof(IsCladdingDelegate), Marshal.GetDelegateForFunctionPointer<IsCladdingDelegate>(vTable.isCladdingFunctionPtr) },
      { typeof(IsFlooringDelegate), Marshal.GetDelegateForFunctionPointer<IsFlooringDelegate>(vTable.isFlooringFunctionPtr) },
      { typeof(IsInsulationDelegate), Marshal.GetDelegateForFunctionPointer<IsInsulationDelegate>(vTable.isInsulationFunctionPtr) },
      { typeof(IsMembraneDelegate), Marshal.GetDelegateForFunctionPointer<IsMembraneDelegate>(vTable.isMembraneFunctionPtr) },
      { typeof(IsRoofingDelegate), Marshal.GetDelegateForFunctionPointer<IsRoofingDelegate>(vTable.isRoofingFunctionPtr) },
      { typeof(IsSleevingDelegate), Marshal.GetDelegateForFunctionPointer<IsSleevingDelegate>(vTable.isSleevingFunctionPtr) },
      { typeof(IsWrappingDelegate), Marshal.GetDelegateForFunctionPointer<IsWrappingDelegate>(vTable.isWrappingFunctionPtr) },
      { typeof(IsFootingBeamDelegate), Marshal.GetDelegateForFunctionPointer<IsFootingBeamDelegate>(vTable.isFootingBeamFunctionPtr) },
      { typeof(IsPadFootingDelegate), Marshal.GetDelegateForFunctionPointer<IsPadFootingDelegate>(vTable.isPadFootingFunctionPtr) },
      { typeof(IsPileCapDelegate), Marshal.GetDelegateForFunctionPointer<IsPileCapDelegate>(vTable.isPileCapFunctionPtr) },
      { typeof(IsStripFootingDelegate), Marshal.GetDelegateForFunctionPointer<IsStripFootingDelegate>(vTable.isStripFootingFunctionPtr) },
      { typeof(IsCohesionDelegate), Marshal.GetDelegateForFunctionPointer<IsCohesionDelegate>(vTable.isCohesionFunctionPtr) },
      { typeof(IsFrictionDelegate), Marshal.GetDelegateForFunctionPointer<IsFrictionDelegate>(vTable.isFrictionFunctionPtr) },
      { typeof(IsSupportDelegate), Marshal.GetDelegateForFunctionPointer<IsSupportDelegate>(vTable.isSupportFunctionPtr) },
      { typeof(IsBalustradeDelegate), Marshal.GetDelegateForFunctionPointer<IsBalustradeDelegate>(vTable.isBalustradeFunctionPtr) },
      { typeof(IsGuardrailDelegate), Marshal.GetDelegateForFunctionPointer<IsGuardrailDelegate>(vTable.isGuardrailFunctionPtr) },
      { typeof(IsHandrailDelegate), Marshal.GetDelegateForFunctionPointer<IsHandrailDelegate>(vTable.isHandrailFunctionPtr) },
      { typeof(IsBaseslabDelegate), Marshal.GetDelegateForFunctionPointer<IsBaseslabDelegate>(vTable.isBaseslabFunctionPtr) },
      { typeof(IsFloorDelegate), Marshal.GetDelegateForFunctionPointer<IsFloorDelegate>(vTable.isFloorFunctionPtr) },
      { typeof(IsLandingDelegate), Marshal.GetDelegateForFunctionPointer<IsLandingDelegate>(vTable.isLandingFunctionPtr) },
      { typeof(IsRoofDelegate), Marshal.GetDelegateForFunctionPointer<IsRoofDelegate>(vTable.isRoofFunctionPtr) },
      { typeof(IsBeamDelegate), Marshal.GetDelegateForFunctionPointer<IsBeamDelegate>(vTable.isBeamFunctionPtr) },
      { typeof(IsHollowcoreDelegate), Marshal.GetDelegateForFunctionPointer<IsHollowcoreDelegate>(vTable.isHollowcoreFunctionPtr) },
      { typeof(IsJoistDelegate), Marshal.GetDelegateForFunctionPointer<IsJoistDelegate>(vTable.isJoistFunctionPtr) },
      { typeof(IsLintelDelegate), Marshal.GetDelegateForFunctionPointer<IsLintelDelegate>(vTable.isLintelFunctionPtr) },
      { typeof(IsSpandrelDelegate), Marshal.GetDelegateForFunctionPointer<IsSpandrelDelegate>(vTable.isSpandrelFunctionPtr) },
      { typeof(IsTbeamDelegate), Marshal.GetDelegateForFunctionPointer<IsTbeamDelegate>(vTable.isTbeamFunctionPtr) },
      { typeof(IsComplexDelegate), Marshal.GetDelegateForFunctionPointer<IsComplexDelegate>(vTable.isComplexFunctionPtr) },
      { typeof(IsElementDelegate), Marshal.GetDelegateForFunctionPointer<IsElementDelegate>(vTable.isElementFunctionPtr) },
      { typeof(IsPartialDelegate), Marshal.GetDelegateForFunctionPointer<IsPartialDelegate>(vTable.isPartialFunctionPtr) },
      { typeof(IsProvisionForSpaceDelegate), Marshal.GetDelegateForFunctionPointer<IsProvisionForSpaceDelegate>(vTable.isProvisionForSpaceFunctionPtr) },
      { typeof(IsProvisionForVoidDelegate), Marshal.GetDelegateForFunctionPointer<IsProvisionForVoidDelegate>(vTable.isProvisionForVoidFunctionPtr) },
      { typeof(IsColumnDelegate), Marshal.GetDelegateForFunctionPointer<IsColumnDelegate>(vTable.isColumnFunctionPtr) },
      { typeof(IsPilasterDelegate), Marshal.GetDelegateForFunctionPointer<IsPilasterDelegate>(vTable.isPilasterFunctionPtr) },
      { typeof(IsMoldingDelegate), Marshal.GetDelegateForFunctionPointer<IsMoldingDelegate>(vTable.isMoldingFunctionPtr) },
      { typeof(IsSkirtingboardDelegate), Marshal.GetDelegateForFunctionPointer<IsSkirtingboardDelegate>(vTable.isSkirtingboardFunctionPtr) },
      { typeof(IsDoorDelegate), Marshal.GetDelegateForFunctionPointer<IsDoorDelegate>(vTable.isDoorFunctionPtr) },
      { typeof(IsGateDelegate), Marshal.GetDelegateForFunctionPointer<IsGateDelegate>(vTable.isGateFunctionPtr) },
      { typeof(IsTrapDoorDelegate), Marshal.GetDelegateForFunctionPointer<IsTrapDoorDelegate>(vTable.isTrapDoorFunctionPtr) },
      { typeof(IsCaissonFoundationDelegate), Marshal.GetDelegateForFunctionPointer<IsCaissonFoundationDelegate>(vTable.isCaissonFoundationFunctionPtr) },
      { typeof(IsBraceDelegate), Marshal.GetDelegateForFunctionPointer<IsBraceDelegate>(vTable.isBraceFunctionPtr) },
      { typeof(IsChordDelegate), Marshal.GetDelegateForFunctionPointer<IsChordDelegate>(vTable.isChordFunctionPtr) },
      { typeof(IsCollarDelegate), Marshal.GetDelegateForFunctionPointer<IsCollarDelegate>(vTable.isCollarFunctionPtr) },
      { typeof(IsMemberDelegate), Marshal.GetDelegateForFunctionPointer<IsMemberDelegate>(vTable.isMemberFunctionPtr) },
      { typeof(IsMullionDelegate), Marshal.GetDelegateForFunctionPointer<IsMullionDelegate>(vTable.isMullionFunctionPtr) },
      { typeof(IsPlateDelegate), Marshal.GetDelegateForFunctionPointer<IsPlateDelegate>(vTable.isPlateFunctionPtr) },
      { typeof(IsPostDelegate), Marshal.GetDelegateForFunctionPointer<IsPostDelegate>(vTable.isPostFunctionPtr) },
      { typeof(IsPurlinDelegate), Marshal.GetDelegateForFunctionPointer<IsPurlinDelegate>(vTable.isPurlinFunctionPtr) },
      { typeof(IsRafterDelegate), Marshal.GetDelegateForFunctionPointer<IsRafterDelegate>(vTable.isRafterFunctionPtr) },
      { typeof(IsStringerDelegate), Marshal.GetDelegateForFunctionPointer<IsStringerDelegate>(vTable.isStringerFunctionPtr) },
      { typeof(IsStrutDelegate), Marshal.GetDelegateForFunctionPointer<IsStrutDelegate>(vTable.isStrutFunctionPtr) },
      { typeof(IsStudDelegate), Marshal.GetDelegateForFunctionPointer<IsStudDelegate>(vTable.isStudFunctionPtr) },
      { typeof(IsBoredDelegate), Marshal.GetDelegateForFunctionPointer<IsBoredDelegate>(vTable.isBoredFunctionPtr) },
      { typeof(IsDrivenDelegate), Marshal.GetDelegateForFunctionPointer<IsDrivenDelegate>(vTable.isDrivenFunctionPtr) },
      { typeof(IsJetgroutingDelegate), Marshal.GetDelegateForFunctionPointer<IsJetgroutingDelegate>(vTable.isJetgroutingFunctionPtr) },
      { typeof(IsCurtainPanelDelegate), Marshal.GetDelegateForFunctionPointer<IsCurtainPanelDelegate>(vTable.isCurtainPanelFunctionPtr) },
      { typeof(IsSheetDelegate), Marshal.GetDelegateForFunctionPointer<IsSheetDelegate>(vTable.isSheetFunctionPtr) },
      { typeof(IsHalfTurnRampDelegate), Marshal.GetDelegateForFunctionPointer<IsHalfTurnRampDelegate>(vTable.isHalfTurnRampFunctionPtr) },
      { typeof(IsQuarterTurnRampDelegate), Marshal.GetDelegateForFunctionPointer<IsQuarterTurnRampDelegate>(vTable.isQuarterTurnRampFunctionPtr) },
      { typeof(IsSpiralRampDelegate), Marshal.GetDelegateForFunctionPointer<IsSpiralRampDelegate>(vTable.isSpiralRampFunctionPtr) },
      { typeof(IsStraightRunRampDelegate), Marshal.GetDelegateForFunctionPointer<IsStraightRunRampDelegate>(vTable.isStraightRunRampFunctionPtr) },
      { typeof(IsTwoQuarterTurnRampDelegate), Marshal.GetDelegateForFunctionPointer<IsTwoQuarterTurnRampDelegate>(vTable.isTwoQuarterTurnRampFunctionPtr) },
      { typeof(IsTwoStraightRunRampDelegate), Marshal.GetDelegateForFunctionPointer<IsTwoStraightRunRampDelegate>(vTable.isTwoStraightRunRampFunctionPtr) },
      { typeof(IsBarrelRoofDelegate), Marshal.GetDelegateForFunctionPointer<IsBarrelRoofDelegate>(vTable.isBarrelRoofFunctionPtr) },
      { typeof(IsButterflyRoofDelegate), Marshal.GetDelegateForFunctionPointer<IsButterflyRoofDelegate>(vTable.isButterflyRoofFunctionPtr) },
      { typeof(IsDomeRoofDelegate), Marshal.GetDelegateForFunctionPointer<IsDomeRoofDelegate>(vTable.isDomeRoofFunctionPtr) },
      { typeof(IsFlatRoofDelegate), Marshal.GetDelegateForFunctionPointer<IsFlatRoofDelegate>(vTable.isFlatRoofFunctionPtr) },
      { typeof(IsFreeformDelegate), Marshal.GetDelegateForFunctionPointer<IsFreeformDelegate>(vTable.isFreeformFunctionPtr) },
      { typeof(IsGableRoofDelegate), Marshal.GetDelegateForFunctionPointer<IsGableRoofDelegate>(vTable.isGableRoofFunctionPtr) },
      { typeof(IsGambrelRoofDelegate), Marshal.GetDelegateForFunctionPointer<IsGambrelRoofDelegate>(vTable.isGambrelRoofFunctionPtr) },
      { typeof(IsHippedGableRoofDelegate), Marshal.GetDelegateForFunctionPointer<IsHippedGableRoofDelegate>(vTable.isHippedGableRoofFunctionPtr) },
      { typeof(IsHipRoofDelegate), Marshal.GetDelegateForFunctionPointer<IsHipRoofDelegate>(vTable.isHipRoofFunctionPtr) },
      { typeof(IsMansardRoofDelegate), Marshal.GetDelegateForFunctionPointer<IsMansardRoofDelegate>(vTable.isMansardRoofFunctionPtr) },
      { typeof(IsPavilionRoofDelegate), Marshal.GetDelegateForFunctionPointer<IsPavilionRoofDelegate>(vTable.isPavilionRoofFunctionPtr) },
      { typeof(IsRainbowRoofDelegate), Marshal.GetDelegateForFunctionPointer<IsRainbowRoofDelegate>(vTable.isRainbowRoofFunctionPtr) },
      { typeof(IsShedRoofDelegate), Marshal.GetDelegateForFunctionPointer<IsShedRoofDelegate>(vTable.isShedRoofFunctionPtr) },
      { typeof(IsCurvedRunStairDelegate), Marshal.GetDelegateForFunctionPointer<IsCurvedRunStairDelegate>(vTable.isCurvedRunStairFunctionPtr) },
      { typeof(IsDoubleReturnStairDelegate), Marshal.GetDelegateForFunctionPointer<IsDoubleReturnStairDelegate>(vTable.isDoubleReturnStairFunctionPtr) },
      { typeof(IsHalfTurnStairDelegate), Marshal.GetDelegateForFunctionPointer<IsHalfTurnStairDelegate>(vTable.isHalfTurnStairFunctionPtr) },
      { typeof(IsHalfWindingStairDelegate), Marshal.GetDelegateForFunctionPointer<IsHalfWindingStairDelegate>(vTable.isHalfWindingStairFunctionPtr) },
      { typeof(IsQuarterTurnStairDelegate), Marshal.GetDelegateForFunctionPointer<IsQuarterTurnStairDelegate>(vTable.isQuarterTurnStairFunctionPtr) },
      { typeof(IsQuarterWindingStairDelegate), Marshal.GetDelegateForFunctionPointer<IsQuarterWindingStairDelegate>(vTable.isQuarterWindingStairFunctionPtr) },
      { typeof(IsSpiralStairDelegate), Marshal.GetDelegateForFunctionPointer<IsSpiralStairDelegate>(vTable.isSpiralStairFunctionPtr) },
      { typeof(IsStraightRunStairDelegate), Marshal.GetDelegateForFunctionPointer<IsStraightRunStairDelegate>(vTable.isStraightRunStairFunctionPtr) },
      { typeof(IsThreeQuarterTurnStairDelegate), Marshal.GetDelegateForFunctionPointer<IsThreeQuarterTurnStairDelegate>(vTable.isThreeQuarterTurnStairFunctionPtr) },
      { typeof(IsThreeQuarterWindingStairDelegate), Marshal.GetDelegateForFunctionPointer<IsThreeQuarterWindingStairDelegate>(vTable.isThreeQuarterWindingStairFunctionPtr) },
      { typeof(IsTwoCurvedRunStairDelegate), Marshal.GetDelegateForFunctionPointer<IsTwoCurvedRunStairDelegate>(vTable.isTwoCurvedRunStairFunctionPtr) },
      { typeof(IsTwoQuarterTurnStairDelegate), Marshal.GetDelegateForFunctionPointer<IsTwoQuarterTurnStairDelegate>(vTable.isTwoQuarterTurnStairFunctionPtr) },
      { typeof(IsTwoQuarterWindingStairDelegate), Marshal.GetDelegateForFunctionPointer<IsTwoQuarterWindingStairDelegate>(vTable.isTwoQuarterWindingStairFunctionPtr) },
      { typeof(IsTwoStraightRunStairDelegate), Marshal.GetDelegateForFunctionPointer<IsTwoStraightRunStairDelegate>(vTable.isTwoStraightRunStairFunctionPtr) },
      { typeof(IsCurvedDelegate), Marshal.GetDelegateForFunctionPointer<IsCurvedDelegate>(vTable.isCurvedFunctionPtr) },
      { typeof(IsSpiralDelegate), Marshal.GetDelegateForFunctionPointer<IsSpiralDelegate>(vTable.isSpiralFunctionPtr) },
      { typeof(IsStraightDelegate), Marshal.GetDelegateForFunctionPointer<IsStraightDelegate>(vTable.isStraightFunctionPtr) },
      { typeof(IsWinderDelegate), Marshal.GetDelegateForFunctionPointer<IsWinderDelegate>(vTable.isWinderFunctionPtr) },
      { typeof(IsElementedWallDelegate), Marshal.GetDelegateForFunctionPointer<IsElementedWallDelegate>(vTable.isElementedWallFunctionPtr) },
      { typeof(IsMovableDelegate), Marshal.GetDelegateForFunctionPointer<IsMovableDelegate>(vTable.isMovableFunctionPtr) },
      { typeof(IsParapetDelegate), Marshal.GetDelegateForFunctionPointer<IsParapetDelegate>(vTable.isParapetFunctionPtr) },
      { typeof(IsPartitioningDelegate), Marshal.GetDelegateForFunctionPointer<IsPartitioningDelegate>(vTable.isPartitioningFunctionPtr) },
      { typeof(IsPlumbingWallDelegate), Marshal.GetDelegateForFunctionPointer<IsPlumbingWallDelegate>(vTable.isPlumbingWallFunctionPtr) },
      { typeof(IsPolygonalDelegate), Marshal.GetDelegateForFunctionPointer<IsPolygonalDelegate>(vTable.isPolygonalFunctionPtr) },
      { typeof(IsShearDelegate), Marshal.GetDelegateForFunctionPointer<IsShearDelegate>(vTable.isShearFunctionPtr) },
      { typeof(IsSolidWallDelegate), Marshal.GetDelegateForFunctionPointer<IsSolidWallDelegate>(vTable.isSolidWallFunctionPtr) },
      { typeof(IsStandardDelegate), Marshal.GetDelegateForFunctionPointer<IsStandardDelegate>(vTable.isStandardFunctionPtr) },
      { typeof(IsLightdomeDelegate), Marshal.GetDelegateForFunctionPointer<IsLightdomeDelegate>(vTable.isLightdomeFunctionPtr) },
      { typeof(IsSkylightDelegate), Marshal.GetDelegateForFunctionPointer<IsSkylightDelegate>(vTable.isSkylightFunctionPtr) },
      { typeof(IsWindowDelegate), Marshal.GetDelegateForFunctionPointer<IsWindowDelegate>(vTable.isWindowFunctionPtr) },
      { typeof(IsOpeningDelegate), Marshal.GetDelegateForFunctionPointer<IsOpeningDelegate>(vTable.isOpeningFunctionPtr) },
      { typeof(IsRecessDelegate), Marshal.GetDelegateForFunctionPointer<IsRecessDelegate>(vTable.isRecessFunctionPtr) },
      { typeof(IsAnchorboltDelegate), Marshal.GetDelegateForFunctionPointer<IsAnchorboltDelegate>(vTable.isAnchorboltFunctionPtr) },
      { typeof(IsBoltDelegate), Marshal.GetDelegateForFunctionPointer<IsBoltDelegate>(vTable.isBoltFunctionPtr) },
      { typeof(IsDowelDelegate), Marshal.GetDelegateForFunctionPointer<IsDowelDelegate>(vTable.isDowelFunctionPtr) },
      { typeof(IsNailDelegate), Marshal.GetDelegateForFunctionPointer<IsNailDelegate>(vTable.isNailFunctionPtr) },
      { typeof(IsNailPlateDelegate), Marshal.GetDelegateForFunctionPointer<IsNailPlateDelegate>(vTable.isNailPlateFunctionPtr) },
      { typeof(IsRivetDelegate), Marshal.GetDelegateForFunctionPointer<IsRivetDelegate>(vTable.isRivetFunctionPtr) },
      { typeof(IsScrewDelegate), Marshal.GetDelegateForFunctionPointer<IsScrewDelegate>(vTable.isScrewFunctionPtr) },
      { typeof(IsShearConnectorDelegate), Marshal.GetDelegateForFunctionPointer<IsShearConnectorDelegate>(vTable.isShearConnectorFunctionPtr) },
      { typeof(IsStapleDelegate), Marshal.GetDelegateForFunctionPointer<IsStapleDelegate>(vTable.isStapleFunctionPtr) },
      { typeof(IsStudShearConnectorDelegate), Marshal.GetDelegateForFunctionPointer<IsStudShearConnectorDelegate>(vTable.isStudShearConnectorFunctionPtr) },
      { typeof(IsGlueDelegate), Marshal.GetDelegateForFunctionPointer<IsGlueDelegate>(vTable.isGlueFunctionPtr) },
      { typeof(IsMortarDelegate), Marshal.GetDelegateForFunctionPointer<IsMortarDelegate>(vTable.isMortarFunctionPtr) },
      { typeof(IsWeldDelegate), Marshal.GetDelegateForFunctionPointer<IsWeldDelegate>(vTable.isWeldFunctionPtr) },
      { typeof(IsExternalDelegate), Marshal.GetDelegateForFunctionPointer<IsExternalDelegate>(vTable.isExternalFunctionPtr) },
      { typeof(IsGfaDelegate), Marshal.GetDelegateForFunctionPointer<IsGfaDelegate>(vTable.isGfaFunctionPtr) },
      { typeof(IsInternalDelegate), Marshal.GetDelegateForFunctionPointer<IsInternalDelegate>(vTable.isInternalFunctionPtr) },
      { typeof(IsParkingDelegate), Marshal.GetDelegateForFunctionPointer<IsParkingDelegate>(vTable.isParkingFunctionPtr) },
      { typeof(IsSpaceDelegate), Marshal.GetDelegateForFunctionPointer<IsSpaceDelegate>(vTable.isSpaceFunctionPtr) },
      { typeof(IsAccessoryAssemblyDelegate), Marshal.GetDelegateForFunctionPointer<IsAccessoryAssemblyDelegate>(vTable.isAccessoryAssemblyFunctionPtr) },
      { typeof(IsArchDelegate), Marshal.GetDelegateForFunctionPointer<IsArchDelegate>(vTable.isArchFunctionPtr) },
      { typeof(IsBeamGridDelegate), Marshal.GetDelegateForFunctionPointer<IsBeamGridDelegate>(vTable.isBeamGridFunctionPtr) },
      { typeof(IsBracedFrameDelegate), Marshal.GetDelegateForFunctionPointer<IsBracedFrameDelegate>(vTable.isBracedFrameFunctionPtr) },
      { typeof(IsGirderDelegate), Marshal.GetDelegateForFunctionPointer<IsGirderDelegate>(vTable.isGirderFunctionPtr) },
      { typeof(IsReinforcementUnitDelegate), Marshal.GetDelegateForFunctionPointer<IsReinforcementUnitDelegate>(vTable.isReinforcementUnitFunctionPtr) },
      { typeof(IsRigidFrameDelegate), Marshal.GetDelegateForFunctionPointer<IsRigidFrameDelegate>(vTable.isRigidFrameFunctionPtr) },
      { typeof(IsSlabFieldDelegate), Marshal.GetDelegateForFunctionPointer<IsSlabFieldDelegate>(vTable.isSlabFieldFunctionPtr) },
      { typeof(IsTrussDelegate), Marshal.GetDelegateForFunctionPointer<IsTrussDelegate>(vTable.isTrussFunctionPtr) },
      { typeof(IsCableLadderSegmentDelegate), Marshal.GetDelegateForFunctionPointer<IsCableLadderSegmentDelegate>(vTable.isCableLadderSegmentFunctionPtr) },
      { typeof(IsCableTraySegmentDelegate), Marshal.GetDelegateForFunctionPointer<IsCableTraySegmentDelegate>(vTable.isCableTraySegmentFunctionPtr) },
      { typeof(IsCableTrunkingSegmentDelegate), Marshal.GetDelegateForFunctionPointer<IsCableTrunkingSegmentDelegate>(vTable.isCableTrunkingSegmentFunctionPtr) },
      { typeof(IsConduitSegmentDelegate), Marshal.GetDelegateForFunctionPointer<IsConduitSegmentDelegate>(vTable.isConduitSegmentFunctionPtr) },
      { typeof(IsBusbarSegmentDelegate), Marshal.GetDelegateForFunctionPointer<IsBusbarSegmentDelegate>(vTable.isBusbarSegmentFunctionPtr) },
      { typeof(IsCableSegmentDelegate), Marshal.GetDelegateForFunctionPointer<IsCableSegmentDelegate>(vTable.isCableSegmentFunctionPtr) },
      { typeof(IsConductorSegmentDelegate), Marshal.GetDelegateForFunctionPointer<IsConductorSegmentDelegate>(vTable.isConductorSegmentFunctionPtr) },
      { typeof(IsCoreSegmentDelegate), Marshal.GetDelegateForFunctionPointer<IsCoreSegmentDelegate>(vTable.isCoreSegmentFunctionPtr) },
      { typeof(IsFlexibleSegmentDelegate), Marshal.GetDelegateForFunctionPointer<IsFlexibleSegmentDelegate>(vTable.isFlexibleSegmentFunctionPtr) },
      { typeof(IsRigidSegmentDelegate), Marshal.GetDelegateForFunctionPointer<IsRigidSegmentDelegate>(vTable.isRigidSegmentFunctionPtr) },
      { typeof(IsCulvertDelegate), Marshal.GetDelegateForFunctionPointer<IsCulvertDelegate>(vTable.isCulvertFunctionPtr) },
      { typeof(IsGutterDelegate), Marshal.GetDelegateForFunctionPointer<IsGutterDelegate>(vTable.isGutterFunctionPtr) },
      { typeof(IsSpoolDelegate), Marshal.GetDelegateForFunctionPointer<IsSpoolDelegate>(vTable.isSpoolFunctionPtr) },
      { typeof(IsAudioVisualOutletDelegate), Marshal.GetDelegateForFunctionPointer<IsAudioVisualOutletDelegate>(vTable.isAudioVisualOutletFunctionPtr) },
      { typeof(IsCommunicationsOutletDelegate), Marshal.GetDelegateForFunctionPointer<IsCommunicationsOutletDelegate>(vTable.isCommunicationsOutletFunctionPtr) },
      { typeof(IsPowerOutletDelegate), Marshal.GetDelegateForFunctionPointer<IsPowerOutletDelegate>(vTable.isPowerOutletFunctionPtr) },
      { typeof(IsDataOutletDelegate), Marshal.GetDelegateForFunctionPointer<IsDataOutletDelegate>(vTable.isDataOutletFunctionPtr) },
      { typeof(IsTelephoneOutletDelegate), Marshal.GetDelegateForFunctionPointer<IsTelephoneOutletDelegate>(vTable.isTelephoneOutletFunctionPtr) },
      { typeof(IsAnchoringDelegate), Marshal.GetDelegateForFunctionPointer<IsAnchoringDelegate>(vTable.isAnchoringFunctionPtr) },
      { typeof(IsEdgeDelegate), Marshal.GetDelegateForFunctionPointer<IsEdgeDelegate>(vTable.isEdgeFunctionPtr) },
      { typeof(IsLigatureDelegate), Marshal.GetDelegateForFunctionPointer<IsLigatureDelegate>(vTable.isLigatureFunctionPtr) },
      { typeof(IsMainDelegate), Marshal.GetDelegateForFunctionPointer<IsMainDelegate>(vTable.isMainFunctionPtr) },
      { typeof(IsPunchingDelegate), Marshal.GetDelegateForFunctionPointer<IsPunchingDelegate>(vTable.isPunchingFunctionPtr) },
      { typeof(IsRingDelegate), Marshal.GetDelegateForFunctionPointer<IsRingDelegate>(vTable.isRingFunctionPtr) },
      { typeof(SetNoneDelegate), Marshal.GetDelegateForFunctionPointer<SetNoneDelegate>(vTable.setNoneFunctionPtr) },
      { typeof(SetCeilingDelegate), Marshal.GetDelegateForFunctionPointer<SetCeilingDelegate>(vTable.setCeilingFunctionPtr) },
      { typeof(SetCladdingDelegate), Marshal.GetDelegateForFunctionPointer<SetCladdingDelegate>(vTable.setCladdingFunctionPtr) },
      { typeof(SetFlooringDelegate), Marshal.GetDelegateForFunctionPointer<SetFlooringDelegate>(vTable.setFlooringFunctionPtr) },
      { typeof(SetInsulationDelegate), Marshal.GetDelegateForFunctionPointer<SetInsulationDelegate>(vTable.setInsulationFunctionPtr) },
      { typeof(SetMembraneDelegate), Marshal.GetDelegateForFunctionPointer<SetMembraneDelegate>(vTable.setMembraneFunctionPtr) },
      { typeof(SetRoofingDelegate), Marshal.GetDelegateForFunctionPointer<SetRoofingDelegate>(vTable.setRoofingFunctionPtr) },
      { typeof(SetSleevingDelegate), Marshal.GetDelegateForFunctionPointer<SetSleevingDelegate>(vTable.setSleevingFunctionPtr) },
      { typeof(SetWrappingDelegate), Marshal.GetDelegateForFunctionPointer<SetWrappingDelegate>(vTable.setWrappingFunctionPtr) },
      { typeof(SetFootingBeamDelegate), Marshal.GetDelegateForFunctionPointer<SetFootingBeamDelegate>(vTable.setFootingBeamFunctionPtr) },
      { typeof(SetPadFootingDelegate), Marshal.GetDelegateForFunctionPointer<SetPadFootingDelegate>(vTable.setPadFootingFunctionPtr) },
      { typeof(SetPileCapDelegate), Marshal.GetDelegateForFunctionPointer<SetPileCapDelegate>(vTable.setPileCapFunctionPtr) },
      { typeof(SetStripFootingDelegate), Marshal.GetDelegateForFunctionPointer<SetStripFootingDelegate>(vTable.setStripFootingFunctionPtr) },
      { typeof(SetCohesionDelegate), Marshal.GetDelegateForFunctionPointer<SetCohesionDelegate>(vTable.setCohesionFunctionPtr) },
      { typeof(SetFrictionDelegate), Marshal.GetDelegateForFunctionPointer<SetFrictionDelegate>(vTable.setFrictionFunctionPtr) },
      { typeof(SetSupportDelegate), Marshal.GetDelegateForFunctionPointer<SetSupportDelegate>(vTable.setSupportFunctionPtr) },
      { typeof(SetBalustradeDelegate), Marshal.GetDelegateForFunctionPointer<SetBalustradeDelegate>(vTable.setBalustradeFunctionPtr) },
      { typeof(SetGuardrailDelegate), Marshal.GetDelegateForFunctionPointer<SetGuardrailDelegate>(vTable.setGuardrailFunctionPtr) },
      { typeof(SetHandrailDelegate), Marshal.GetDelegateForFunctionPointer<SetHandrailDelegate>(vTable.setHandrailFunctionPtr) },
      { typeof(SetBaseslabDelegate), Marshal.GetDelegateForFunctionPointer<SetBaseslabDelegate>(vTable.setBaseslabFunctionPtr) },
      { typeof(SetFloorDelegate), Marshal.GetDelegateForFunctionPointer<SetFloorDelegate>(vTable.setFloorFunctionPtr) },
      { typeof(SetLandingDelegate), Marshal.GetDelegateForFunctionPointer<SetLandingDelegate>(vTable.setLandingFunctionPtr) },
      { typeof(SetRoofDelegate), Marshal.GetDelegateForFunctionPointer<SetRoofDelegate>(vTable.setRoofFunctionPtr) },
      { typeof(SetBeamDelegate), Marshal.GetDelegateForFunctionPointer<SetBeamDelegate>(vTable.setBeamFunctionPtr) },
      { typeof(SetHollowcoreDelegate), Marshal.GetDelegateForFunctionPointer<SetHollowcoreDelegate>(vTable.setHollowcoreFunctionPtr) },
      { typeof(SetJoistDelegate), Marshal.GetDelegateForFunctionPointer<SetJoistDelegate>(vTable.setJoistFunctionPtr) },
      { typeof(SetLintelDelegate), Marshal.GetDelegateForFunctionPointer<SetLintelDelegate>(vTable.setLintelFunctionPtr) },
      { typeof(SetSpandrelDelegate), Marshal.GetDelegateForFunctionPointer<SetSpandrelDelegate>(vTable.setSpandrelFunctionPtr) },
      { typeof(SetTbeamDelegate), Marshal.GetDelegateForFunctionPointer<SetTbeamDelegate>(vTable.setTbeamFunctionPtr) },
      { typeof(SetComplexDelegate), Marshal.GetDelegateForFunctionPointer<SetComplexDelegate>(vTable.setComplexFunctionPtr) },
      { typeof(SetElementDelegate), Marshal.GetDelegateForFunctionPointer<SetElementDelegate>(vTable.setElementFunctionPtr) },
      { typeof(SetPartialDelegate), Marshal.GetDelegateForFunctionPointer<SetPartialDelegate>(vTable.setPartialFunctionPtr) },
      { typeof(SetProvisionForSpaceDelegate), Marshal.GetDelegateForFunctionPointer<SetProvisionForSpaceDelegate>(vTable.setProvisionForSpaceFunctionPtr) },
      { typeof(SetProvisionFOrVoidDelegate), Marshal.GetDelegateForFunctionPointer<SetProvisionFOrVoidDelegate>(vTable.setProvisionFOrVoidFunctionPtr) },
      { typeof(SetColumnDelegate), Marshal.GetDelegateForFunctionPointer<SetColumnDelegate>(vTable.setColumnFunctionPtr) },
      { typeof(SetPilasterDelegate), Marshal.GetDelegateForFunctionPointer<SetPilasterDelegate>(vTable.setPilasterFunctionPtr) },
      { typeof(SetMoldingDelegate), Marshal.GetDelegateForFunctionPointer<SetMoldingDelegate>(vTable.setMoldingFunctionPtr) },
      { typeof(SetSkirtingboardDelegate), Marshal.GetDelegateForFunctionPointer<SetSkirtingboardDelegate>(vTable.setSkirtingboardFunctionPtr) },
      { typeof(SetDoorDelegate), Marshal.GetDelegateForFunctionPointer<SetDoorDelegate>(vTable.setDoorFunctionPtr) },
      { typeof(SetGateDelegate), Marshal.GetDelegateForFunctionPointer<SetGateDelegate>(vTable.setGateFunctionPtr) },
      { typeof(SetTrapDoorDelegate), Marshal.GetDelegateForFunctionPointer<SetTrapDoorDelegate>(vTable.setTrapDoorFunctionPtr) },
      { typeof(SetCaissonFoundationDelegate), Marshal.GetDelegateForFunctionPointer<SetCaissonFoundationDelegate>(vTable.setCaissonFoundationFunctionPtr) },
      { typeof(SetBraceDelegate), Marshal.GetDelegateForFunctionPointer<SetBraceDelegate>(vTable.setBraceFunctionPtr) },
      { typeof(SetChordDelegate), Marshal.GetDelegateForFunctionPointer<SetChordDelegate>(vTable.setChordFunctionPtr) },
      { typeof(SetCollarDelegate), Marshal.GetDelegateForFunctionPointer<SetCollarDelegate>(vTable.setCollarFunctionPtr) },
      { typeof(SetMemberDelegate), Marshal.GetDelegateForFunctionPointer<SetMemberDelegate>(vTable.setMemberFunctionPtr) },
      { typeof(SetMullionDelegate), Marshal.GetDelegateForFunctionPointer<SetMullionDelegate>(vTable.setMullionFunctionPtr) },
      { typeof(SetPlateDelegate), Marshal.GetDelegateForFunctionPointer<SetPlateDelegate>(vTable.setPlateFunctionPtr) },
      { typeof(SetPostDelegate), Marshal.GetDelegateForFunctionPointer<SetPostDelegate>(vTable.setPostFunctionPtr) },
      { typeof(SetPurlinDelegate), Marshal.GetDelegateForFunctionPointer<SetPurlinDelegate>(vTable.setPurlinFunctionPtr) },
      { typeof(SetRafterDelegate), Marshal.GetDelegateForFunctionPointer<SetRafterDelegate>(vTable.setRafterFunctionPtr) },
      { typeof(SetStringerDelegate), Marshal.GetDelegateForFunctionPointer<SetStringerDelegate>(vTable.setStringerFunctionPtr) },
      { typeof(SetStrutDelegate), Marshal.GetDelegateForFunctionPointer<SetStrutDelegate>(vTable.setStrutFunctionPtr) },
      { typeof(SetStudDelegate), Marshal.GetDelegateForFunctionPointer<SetStudDelegate>(vTable.setStudFunctionPtr) },
      { typeof(SetBoredDelegate), Marshal.GetDelegateForFunctionPointer<SetBoredDelegate>(vTable.setBoredFunctionPtr) },
      { typeof(SetDrivenDelegate), Marshal.GetDelegateForFunctionPointer<SetDrivenDelegate>(vTable.setDrivenFunctionPtr) },
      { typeof(SetJetgroutingDelegate), Marshal.GetDelegateForFunctionPointer<SetJetgroutingDelegate>(vTable.setJetgroutingFunctionPtr) },
      { typeof(SetCurtainFanelDelegate), Marshal.GetDelegateForFunctionPointer<SetCurtainFanelDelegate>(vTable.setCurtainFanelFunctionPtr) },
      { typeof(SetSheetDelegate), Marshal.GetDelegateForFunctionPointer<SetSheetDelegate>(vTable.setSheetFunctionPtr) },
      { typeof(SetHalfTurnRampDelegate), Marshal.GetDelegateForFunctionPointer<SetHalfTurnRampDelegate>(vTable.setHalfTurnRampFunctionPtr) },
      { typeof(SetQuarterTurnRampDelegate), Marshal.GetDelegateForFunctionPointer<SetQuarterTurnRampDelegate>(vTable.setQuarterTurnRampFunctionPtr) },
      { typeof(SetSpiralRampDelegate), Marshal.GetDelegateForFunctionPointer<SetSpiralRampDelegate>(vTable.setSpiralRampFunctionPtr) },
      { typeof(SetStraightRunRampDelegate), Marshal.GetDelegateForFunctionPointer<SetStraightRunRampDelegate>(vTable.setStraightRunRampFunctionPtr) },
      { typeof(SetTwoQuarterTurnRampDelegate), Marshal.GetDelegateForFunctionPointer<SetTwoQuarterTurnRampDelegate>(vTable.setTwoQuarterTurnRampFunctionPtr) },
      { typeof(SetTwoStraightRunRampDelegate), Marshal.GetDelegateForFunctionPointer<SetTwoStraightRunRampDelegate>(vTable.setTwoStraightRunRampFunctionPtr) },
      { typeof(SetBarrelRoofDelegate), Marshal.GetDelegateForFunctionPointer<SetBarrelRoofDelegate>(vTable.setBarrelRoofFunctionPtr) },
      { typeof(SetButterflyRoofDelegate), Marshal.GetDelegateForFunctionPointer<SetButterflyRoofDelegate>(vTable.setButterflyRoofFunctionPtr) },
      { typeof(SetDomeRoofDelegate), Marshal.GetDelegateForFunctionPointer<SetDomeRoofDelegate>(vTable.setDomeRoofFunctionPtr) },
      { typeof(SetFlatRoofDelegate), Marshal.GetDelegateForFunctionPointer<SetFlatRoofDelegate>(vTable.setFlatRoofFunctionPtr) },
      { typeof(SetFreeformDelegate), Marshal.GetDelegateForFunctionPointer<SetFreeformDelegate>(vTable.setFreeformFunctionPtr) },
      { typeof(SetGableRoofDelegate), Marshal.GetDelegateForFunctionPointer<SetGableRoofDelegate>(vTable.setGableRoofFunctionPtr) },
      { typeof(SetGambrelRoofDelegate), Marshal.GetDelegateForFunctionPointer<SetGambrelRoofDelegate>(vTable.setGambrelRoofFunctionPtr) },
      { typeof(SetHippedGableRoofDelegate), Marshal.GetDelegateForFunctionPointer<SetHippedGableRoofDelegate>(vTable.setHippedGableRoofFunctionPtr) },
      { typeof(SetHipRoofDelegate), Marshal.GetDelegateForFunctionPointer<SetHipRoofDelegate>(vTable.setHipRoofFunctionPtr) },
      { typeof(SetMansardRoofDelegate), Marshal.GetDelegateForFunctionPointer<SetMansardRoofDelegate>(vTable.setMansardRoofFunctionPtr) },
      { typeof(SetPavilionRoofDelegate), Marshal.GetDelegateForFunctionPointer<SetPavilionRoofDelegate>(vTable.setPavilionRoofFunctionPtr) },
      { typeof(SetRainbowRoofDelegate), Marshal.GetDelegateForFunctionPointer<SetRainbowRoofDelegate>(vTable.setRainbowRoofFunctionPtr) },
      { typeof(SetShedRoofDelegate), Marshal.GetDelegateForFunctionPointer<SetShedRoofDelegate>(vTable.setShedRoofFunctionPtr) },
      { typeof(SetCurvedRunStairDelegate), Marshal.GetDelegateForFunctionPointer<SetCurvedRunStairDelegate>(vTable.setCurvedRunStairFunctionPtr) },
      { typeof(SetDoubleReturnStairDelegate), Marshal.GetDelegateForFunctionPointer<SetDoubleReturnStairDelegate>(vTable.setDoubleReturnStairFunctionPtr) },
      { typeof(SetHalfTurnStairDelegate), Marshal.GetDelegateForFunctionPointer<SetHalfTurnStairDelegate>(vTable.setHalfTurnStairFunctionPtr) },
      { typeof(SetHalfWindingStairDelegate), Marshal.GetDelegateForFunctionPointer<SetHalfWindingStairDelegate>(vTable.setHalfWindingStairFunctionPtr) },
      { typeof(SetQuarterTurnStairDelegate), Marshal.GetDelegateForFunctionPointer<SetQuarterTurnStairDelegate>(vTable.setQuarterTurnStairFunctionPtr) },
      { typeof(SetQuarterWindingStairDelegate), Marshal.GetDelegateForFunctionPointer<SetQuarterWindingStairDelegate>(vTable.setQuarterWindingStairFunctionPtr) },
      { typeof(SetSpiralStairDelegate), Marshal.GetDelegateForFunctionPointer<SetSpiralStairDelegate>(vTable.setSpiralStairFunctionPtr) },
      { typeof(SetStraightRunStairDelegate), Marshal.GetDelegateForFunctionPointer<SetStraightRunStairDelegate>(vTable.setStraightRunStairFunctionPtr) },
      { typeof(SetThreeQuarterturnstairDelegate), Marshal.GetDelegateForFunctionPointer<SetThreeQuarterturnstairDelegate>(vTable.setThreeQuarterturnstairFunctionPtr) },
      { typeof(SetThreeQuarterwindingstairDelegate), Marshal.GetDelegateForFunctionPointer<SetThreeQuarterwindingstairDelegate>(vTable.setThreeQuarterwindingstairFunctionPtr) },
      { typeof(SetTwoCurvedRunStairDelegate), Marshal.GetDelegateForFunctionPointer<SetTwoCurvedRunStairDelegate>(vTable.setTwoCurvedRunStairFunctionPtr) },
      { typeof(SetTwoQuarterTurnStairDelegate), Marshal.GetDelegateForFunctionPointer<SetTwoQuarterTurnStairDelegate>(vTable.setTwoQuarterTurnStairFunctionPtr) },
      { typeof(SetTwoQuarterWindingStairDelegate), Marshal.GetDelegateForFunctionPointer<SetTwoQuarterWindingStairDelegate>(vTable.setTwoQuarterWindingStairFunctionPtr) },
      { typeof(SetTwoStraightRunStairDelegate), Marshal.GetDelegateForFunctionPointer<SetTwoStraightRunStairDelegate>(vTable.setTwoStraightRunStairFunctionPtr) },
      { typeof(SetCurvedDelegate), Marshal.GetDelegateForFunctionPointer<SetCurvedDelegate>(vTable.setCurvedFunctionPtr) },
      { typeof(SetSpiralDelegate), Marshal.GetDelegateForFunctionPointer<SetSpiralDelegate>(vTable.setSpiralFunctionPtr) },
      { typeof(SetStraightDelegate), Marshal.GetDelegateForFunctionPointer<SetStraightDelegate>(vTable.setStraightFunctionPtr) },
      { typeof(SetWinderDelegate), Marshal.GetDelegateForFunctionPointer<SetWinderDelegate>(vTable.setWinderFunctionPtr) },
      { typeof(SetElementedWallDelegate), Marshal.GetDelegateForFunctionPointer<SetElementedWallDelegate>(vTable.setElementedWallFunctionPtr) },
      { typeof(SetMovableDelegate), Marshal.GetDelegateForFunctionPointer<SetMovableDelegate>(vTable.setMovableFunctionPtr) },
      { typeof(SetParapetDelegate), Marshal.GetDelegateForFunctionPointer<SetParapetDelegate>(vTable.setParapetFunctionPtr) },
      { typeof(SetPartitioningDelegate), Marshal.GetDelegateForFunctionPointer<SetPartitioningDelegate>(vTable.setPartitioningFunctionPtr) },
      { typeof(SetPlumbingWallDelegate), Marshal.GetDelegateForFunctionPointer<SetPlumbingWallDelegate>(vTable.setPlumbingWallFunctionPtr) },
      { typeof(SetPolygonalDelegate), Marshal.GetDelegateForFunctionPointer<SetPolygonalDelegate>(vTable.setPolygonalFunctionPtr) },
      { typeof(SetShearDelegate), Marshal.GetDelegateForFunctionPointer<SetShearDelegate>(vTable.setShearFunctionPtr) },
      { typeof(SetSolidWallDelegate), Marshal.GetDelegateForFunctionPointer<SetSolidWallDelegate>(vTable.setSolidWallFunctionPtr) },
      { typeof(SetStandardDelegate), Marshal.GetDelegateForFunctionPointer<SetStandardDelegate>(vTable.setStandardFunctionPtr) },
      { typeof(SetLightdomeDelegate), Marshal.GetDelegateForFunctionPointer<SetLightdomeDelegate>(vTable.setLightdomeFunctionPtr) },
      { typeof(SetSkylightDelegate), Marshal.GetDelegateForFunctionPointer<SetSkylightDelegate>(vTable.setSkylightFunctionPtr) },
      { typeof(SetWindowDelegate), Marshal.GetDelegateForFunctionPointer<SetWindowDelegate>(vTable.setWindowFunctionPtr) },
      { typeof(SetOpeningDelegate), Marshal.GetDelegateForFunctionPointer<SetOpeningDelegate>(vTable.setOpeningFunctionPtr) },
      { typeof(SetRecessDelegate), Marshal.GetDelegateForFunctionPointer<SetRecessDelegate>(vTable.setRecessFunctionPtr) },
      { typeof(SetAnchorboltDelegate), Marshal.GetDelegateForFunctionPointer<SetAnchorboltDelegate>(vTable.setAnchorboltFunctionPtr) },
      { typeof(SetBoltDelegate), Marshal.GetDelegateForFunctionPointer<SetBoltDelegate>(vTable.setBoltFunctionPtr) },
      { typeof(SetDowelDelegate), Marshal.GetDelegateForFunctionPointer<SetDowelDelegate>(vTable.setDowelFunctionPtr) },
      { typeof(SetNailDelegate), Marshal.GetDelegateForFunctionPointer<SetNailDelegate>(vTable.setNailFunctionPtr) },
      { typeof(SetNailplateDelegate), Marshal.GetDelegateForFunctionPointer<SetNailplateDelegate>(vTable.setNailplateFunctionPtr) },
      { typeof(SetRivetDelegate), Marshal.GetDelegateForFunctionPointer<SetRivetDelegate>(vTable.setRivetFunctionPtr) },
      { typeof(SetScrewDelegate), Marshal.GetDelegateForFunctionPointer<SetScrewDelegate>(vTable.setScrewFunctionPtr) },
      { typeof(SetShearconnectorDelegate), Marshal.GetDelegateForFunctionPointer<SetShearconnectorDelegate>(vTable.setShearconnectorFunctionPtr) },
      { typeof(SetStapleDelegate), Marshal.GetDelegateForFunctionPointer<SetStapleDelegate>(vTable.setStapleFunctionPtr) },
      { typeof(SetStudshearconnectorDelegate), Marshal.GetDelegateForFunctionPointer<SetStudshearconnectorDelegate>(vTable.setStudshearconnectorFunctionPtr) },
      { typeof(SetGlueDelegate), Marshal.GetDelegateForFunctionPointer<SetGlueDelegate>(vTable.setGlueFunctionPtr) },
      { typeof(SetMortarDelegate), Marshal.GetDelegateForFunctionPointer<SetMortarDelegate>(vTable.setMortarFunctionPtr) },
      { typeof(SetWeldDelegate), Marshal.GetDelegateForFunctionPointer<SetWeldDelegate>(vTable.setWeldFunctionPtr) },
      { typeof(SetExternalDelegate), Marshal.GetDelegateForFunctionPointer<SetExternalDelegate>(vTable.setExternalFunctionPtr) },
      { typeof(SetGfaDelegate), Marshal.GetDelegateForFunctionPointer<SetGfaDelegate>(vTable.setGfaFunctionPtr) },
      { typeof(SetInternalDelegate), Marshal.GetDelegateForFunctionPointer<SetInternalDelegate>(vTable.setInternalFunctionPtr) },
      { typeof(SetParkingDelegate), Marshal.GetDelegateForFunctionPointer<SetParkingDelegate>(vTable.setParkingFunctionPtr) },
      { typeof(SetSpaceDelegate), Marshal.GetDelegateForFunctionPointer<SetSpaceDelegate>(vTable.setSpaceFunctionPtr) },
      { typeof(SetAccessoryAssemblyDelegate), Marshal.GetDelegateForFunctionPointer<SetAccessoryAssemblyDelegate>(vTable.setAccessoryAssemblyFunctionPtr) },
      { typeof(SetArchDelegate), Marshal.GetDelegateForFunctionPointer<SetArchDelegate>(vTable.setArchFunctionPtr) },
      { typeof(SetBeamGridDelegate), Marshal.GetDelegateForFunctionPointer<SetBeamGridDelegate>(vTable.setBeamGridFunctionPtr) },
      { typeof(SetBracedFrameDelegate), Marshal.GetDelegateForFunctionPointer<SetBracedFrameDelegate>(vTable.setBracedFrameFunctionPtr) },
      { typeof(SetGirderDelegate), Marshal.GetDelegateForFunctionPointer<SetGirderDelegate>(vTable.setGirderFunctionPtr) },
      { typeof(SetReinforcementUnitDelegate), Marshal.GetDelegateForFunctionPointer<SetReinforcementUnitDelegate>(vTable.setReinforcementUnitFunctionPtr) },
      { typeof(SetRigidFrameDelegate), Marshal.GetDelegateForFunctionPointer<SetRigidFrameDelegate>(vTable.setRigidFrameFunctionPtr) },
      { typeof(SetSlabFieldDelegate), Marshal.GetDelegateForFunctionPointer<SetSlabFieldDelegate>(vTable.setSlabFieldFunctionPtr) },
      { typeof(SetTrussDelegate), Marshal.GetDelegateForFunctionPointer<SetTrussDelegate>(vTable.setTrussFunctionPtr) },
      { typeof(SetCableLadderSegmentDelegate), Marshal.GetDelegateForFunctionPointer<SetCableLadderSegmentDelegate>(vTable.setCableLadderSegmentFunctionPtr) },
      { typeof(SetCableTraySegmentDelegate), Marshal.GetDelegateForFunctionPointer<SetCableTraySegmentDelegate>(vTable.setCableTraySegmentFunctionPtr) },
      { typeof(SetCableTrunkingSegmentDelegate), Marshal.GetDelegateForFunctionPointer<SetCableTrunkingSegmentDelegate>(vTable.setCableTrunkingSegmentFunctionPtr) },
      { typeof(SetConduitSegmentDelegate), Marshal.GetDelegateForFunctionPointer<SetConduitSegmentDelegate>(vTable.setConduitSegmentFunctionPtr) },
      { typeof(SetBusbarSegmentDelegate), Marshal.GetDelegateForFunctionPointer<SetBusbarSegmentDelegate>(vTable.setBusbarSegmentFunctionPtr) },
      { typeof(SetCableSegmentDelegate), Marshal.GetDelegateForFunctionPointer<SetCableSegmentDelegate>(vTable.setCableSegmentFunctionPtr) },
      { typeof(SetConductorSegmentDelegate), Marshal.GetDelegateForFunctionPointer<SetConductorSegmentDelegate>(vTable.setConductorSegmentFunctionPtr) },
      { typeof(SetCoreSegmentDelegate), Marshal.GetDelegateForFunctionPointer<SetCoreSegmentDelegate>(vTable.setCoreSegmentFunctionPtr) },
      { typeof(SetFlexibleSegmentDelegate), Marshal.GetDelegateForFunctionPointer<SetFlexibleSegmentDelegate>(vTable.setFlexibleSegmentFunctionPtr) },
      { typeof(SetRigidSegmentDelegate), Marshal.GetDelegateForFunctionPointer<SetRigidSegmentDelegate>(vTable.setRigidSegmentFunctionPtr) },
      { typeof(SetCulvertDelegate), Marshal.GetDelegateForFunctionPointer<SetCulvertDelegate>(vTable.setCulvertFunctionPtr) },
      { typeof(SetGutterDelegate), Marshal.GetDelegateForFunctionPointer<SetGutterDelegate>(vTable.setGutterFunctionPtr) },
      { typeof(SetSpoolDelegate), Marshal.GetDelegateForFunctionPointer<SetSpoolDelegate>(vTable.setSpoolFunctionPtr) },
      { typeof(SetAudioVisualOutletDelegate), Marshal.GetDelegateForFunctionPointer<SetAudioVisualOutletDelegate>(vTable.setAudioVisualOutletFunctionPtr) },
      { typeof(SetCommunicationsOutletDelegate), Marshal.GetDelegateForFunctionPointer<SetCommunicationsOutletDelegate>(vTable.setCommunicationsOutletFunctionPtr) },
      { typeof(SetPowerOutletDelegate), Marshal.GetDelegateForFunctionPointer<SetPowerOutletDelegate>(vTable.setPowerOutletFunctionPtr) },
      { typeof(SetDataOutletDelegate), Marshal.GetDelegateForFunctionPointer<SetDataOutletDelegate>(vTable.setDataOutletFunctionPtr) },
      { typeof(SetTelephoneOutletDelegate), Marshal.GetDelegateForFunctionPointer<SetTelephoneOutletDelegate>(vTable.setTelephoneOutletFunctionPtr) },
      { typeof(SetAnchoringDelegate), Marshal.GetDelegateForFunctionPointer<SetAnchoringDelegate>(vTable.setAnchoringFunctionPtr) },
      { typeof(SetEdgeDelegate), Marshal.GetDelegateForFunctionPointer<SetEdgeDelegate>(vTable.setEdgeFunctionPtr) },
      { typeof(SetLigatureDelegate), Marshal.GetDelegateForFunctionPointer<SetLigatureDelegate>(vTable.setLigatureFunctionPtr) },
      { typeof(SetMainDelegate), Marshal.GetDelegateForFunctionPointer<SetMainDelegate>(vTable.setMainFunctionPtr) },
      { typeof(SetPunchingDelegate), Marshal.GetDelegateForFunctionPointer<SetPunchingDelegate>(vTable.setPunchingFunctionPtr) },
      { typeof(SetRingDelegate), Marshal.GetDelegateForFunctionPointer<SetRingDelegate>(vTable.setRingFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public void Destroy() => GetDelegate<DestroyDelegate>().Invoke(NativePtr);
  public bool IsNone() => GetDelegate<IsNoneDelegate>().Invoke(NativePtr);
  public bool IsCeiling() => GetDelegate<IsCeilingDelegate>().Invoke(NativePtr);
  public bool IsCladding() => GetDelegate<IsCladdingDelegate>().Invoke(NativePtr);
  public bool IsFlooring() => GetDelegate<IsFlooringDelegate>().Invoke(NativePtr);
  public bool IsInsulation() => GetDelegate<IsInsulationDelegate>().Invoke(NativePtr);
  public bool IsMembrane() => GetDelegate<IsMembraneDelegate>().Invoke(NativePtr);
  public bool IsRoofing() => GetDelegate<IsRoofingDelegate>().Invoke(NativePtr);
  public bool IsSleeving() => GetDelegate<IsSleevingDelegate>().Invoke(NativePtr);
  public bool IsWrapping() => GetDelegate<IsWrappingDelegate>().Invoke(NativePtr);
  public bool IsFootingBeam() => GetDelegate<IsFootingBeamDelegate>().Invoke(NativePtr);
  public bool IsPadFooting() => GetDelegate<IsPadFootingDelegate>().Invoke(NativePtr);
  public bool IsPileCap() => GetDelegate<IsPileCapDelegate>().Invoke(NativePtr);
  public bool IsStripFooting() => GetDelegate<IsStripFootingDelegate>().Invoke(NativePtr);
  public bool IsCohesion() => GetDelegate<IsCohesionDelegate>().Invoke(NativePtr);
  public bool IsFriction() => GetDelegate<IsFrictionDelegate>().Invoke(NativePtr);
  public bool IsSupport() => GetDelegate<IsSupportDelegate>().Invoke(NativePtr);
  public bool IsBalustrade() => GetDelegate<IsBalustradeDelegate>().Invoke(NativePtr);
  public bool IsGuardrail() => GetDelegate<IsGuardrailDelegate>().Invoke(NativePtr);
  public bool IsHandrail() => GetDelegate<IsHandrailDelegate>().Invoke(NativePtr);
  public bool IsBaseslab() => GetDelegate<IsBaseslabDelegate>().Invoke(NativePtr);
  public bool IsFloor() => GetDelegate<IsFloorDelegate>().Invoke(NativePtr);
  public bool IsLanding() => GetDelegate<IsLandingDelegate>().Invoke(NativePtr);
  public bool IsRoof() => GetDelegate<IsRoofDelegate>().Invoke(NativePtr);
  public bool IsBeam() => GetDelegate<IsBeamDelegate>().Invoke(NativePtr);
  public bool IsHollowcore() => GetDelegate<IsHollowcoreDelegate>().Invoke(NativePtr);
  public bool IsJoist() => GetDelegate<IsJoistDelegate>().Invoke(NativePtr);
  public bool IsLintel() => GetDelegate<IsLintelDelegate>().Invoke(NativePtr);
  public bool IsSpandrel() => GetDelegate<IsSpandrelDelegate>().Invoke(NativePtr);
  public bool IsTbeam() => GetDelegate<IsTbeamDelegate>().Invoke(NativePtr);
  public bool IsComplex() => GetDelegate<IsComplexDelegate>().Invoke(NativePtr);
  public bool IsElement() => GetDelegate<IsElementDelegate>().Invoke(NativePtr);
  public bool IsPartial() => GetDelegate<IsPartialDelegate>().Invoke(NativePtr);
  public bool IsProvisionForSpace() => GetDelegate<IsProvisionForSpaceDelegate>().Invoke(NativePtr);
  public bool IsProvisionForVoid() => GetDelegate<IsProvisionForVoidDelegate>().Invoke(NativePtr);
  public bool IsColumn() => GetDelegate<IsColumnDelegate>().Invoke(NativePtr);
  public bool IsPilaster() => GetDelegate<IsPilasterDelegate>().Invoke(NativePtr);
  public bool IsMolding() => GetDelegate<IsMoldingDelegate>().Invoke(NativePtr);
  public bool IsSkirtingboard() => GetDelegate<IsSkirtingboardDelegate>().Invoke(NativePtr);
  public bool IsDoor() => GetDelegate<IsDoorDelegate>().Invoke(NativePtr);
  public bool IsGate() => GetDelegate<IsGateDelegate>().Invoke(NativePtr);
  public bool IsTrapDoor() => GetDelegate<IsTrapDoorDelegate>().Invoke(NativePtr);
  public bool IsCaissonFoundation() => GetDelegate<IsCaissonFoundationDelegate>().Invoke(NativePtr);
  public bool IsBrace() => GetDelegate<IsBraceDelegate>().Invoke(NativePtr);
  public bool IsChord() => GetDelegate<IsChordDelegate>().Invoke(NativePtr);
  public bool IsCollar() => GetDelegate<IsCollarDelegate>().Invoke(NativePtr);
  public bool IsMember() => GetDelegate<IsMemberDelegate>().Invoke(NativePtr);
  public bool IsMullion() => GetDelegate<IsMullionDelegate>().Invoke(NativePtr);
  public bool IsPlate() => GetDelegate<IsPlateDelegate>().Invoke(NativePtr);
  public bool IsPost() => GetDelegate<IsPostDelegate>().Invoke(NativePtr);
  public bool IsPurlin() => GetDelegate<IsPurlinDelegate>().Invoke(NativePtr);
  public bool IsRafter() => GetDelegate<IsRafterDelegate>().Invoke(NativePtr);
  public bool IsStringer() => GetDelegate<IsStringerDelegate>().Invoke(NativePtr);
  public bool IsStrut() => GetDelegate<IsStrutDelegate>().Invoke(NativePtr);
  public bool IsStud() => GetDelegate<IsStudDelegate>().Invoke(NativePtr);
  public bool IsBored() => GetDelegate<IsBoredDelegate>().Invoke(NativePtr);
  public bool IsDriven() => GetDelegate<IsDrivenDelegate>().Invoke(NativePtr);
  public bool IsJetgrouting() => GetDelegate<IsJetgroutingDelegate>().Invoke(NativePtr);
  public bool IsCurtainPanel() => GetDelegate<IsCurtainPanelDelegate>().Invoke(NativePtr);
  public bool IsSheet() => GetDelegate<IsSheetDelegate>().Invoke(NativePtr);
  public bool IsHalfTurnRamp() => GetDelegate<IsHalfTurnRampDelegate>().Invoke(NativePtr);
  public bool IsQuarterTurnRamp() => GetDelegate<IsQuarterTurnRampDelegate>().Invoke(NativePtr);
  public bool IsSpiralRamp() => GetDelegate<IsSpiralRampDelegate>().Invoke(NativePtr);
  public bool IsStraightRunRamp() => GetDelegate<IsStraightRunRampDelegate>().Invoke(NativePtr);
  public bool IsTwoQuarterTurnRamp() => GetDelegate<IsTwoQuarterTurnRampDelegate>().Invoke(NativePtr);
  public bool IsTwoStraightRunRamp() => GetDelegate<IsTwoStraightRunRampDelegate>().Invoke(NativePtr);
  public bool IsBarrelRoof() => GetDelegate<IsBarrelRoofDelegate>().Invoke(NativePtr);
  public bool IsButterflyRoof() => GetDelegate<IsButterflyRoofDelegate>().Invoke(NativePtr);
  public bool IsDomeRoof() => GetDelegate<IsDomeRoofDelegate>().Invoke(NativePtr);
  public bool IsFlatRoof() => GetDelegate<IsFlatRoofDelegate>().Invoke(NativePtr);
  public bool IsFreeform() => GetDelegate<IsFreeformDelegate>().Invoke(NativePtr);
  public bool IsGableRoof() => GetDelegate<IsGableRoofDelegate>().Invoke(NativePtr);
  public bool IsGambrelRoof() => GetDelegate<IsGambrelRoofDelegate>().Invoke(NativePtr);
  public bool IsHippedGableRoof() => GetDelegate<IsHippedGableRoofDelegate>().Invoke(NativePtr);
  public bool IsHipRoof() => GetDelegate<IsHipRoofDelegate>().Invoke(NativePtr);
  public bool IsMansardRoof() => GetDelegate<IsMansardRoofDelegate>().Invoke(NativePtr);
  public bool IsPavilionRoof() => GetDelegate<IsPavilionRoofDelegate>().Invoke(NativePtr);
  public bool IsRainbowRoof() => GetDelegate<IsRainbowRoofDelegate>().Invoke(NativePtr);
  public bool IsShedRoof() => GetDelegate<IsShedRoofDelegate>().Invoke(NativePtr);
  public bool IsCurvedRunStair() => GetDelegate<IsCurvedRunStairDelegate>().Invoke(NativePtr);
  public bool IsDoubleReturnStair() => GetDelegate<IsDoubleReturnStairDelegate>().Invoke(NativePtr);
  public bool IsHalfTurnStair() => GetDelegate<IsHalfTurnStairDelegate>().Invoke(NativePtr);
  public bool IsHalfWindingStair() => GetDelegate<IsHalfWindingStairDelegate>().Invoke(NativePtr);
  public bool IsQuarterTurnStair() => GetDelegate<IsQuarterTurnStairDelegate>().Invoke(NativePtr);
  public bool IsQuarterWindingStair() => GetDelegate<IsQuarterWindingStairDelegate>().Invoke(NativePtr);
  public bool IsSpiralStair() => GetDelegate<IsSpiralStairDelegate>().Invoke(NativePtr);
  public bool IsStraightRunStair() => GetDelegate<IsStraightRunStairDelegate>().Invoke(NativePtr);
  public bool IsThreeQuarterTurnStair() => GetDelegate<IsThreeQuarterTurnStairDelegate>().Invoke(NativePtr);
  public bool IsThreeQuarterWindingStair() => GetDelegate<IsThreeQuarterWindingStairDelegate>().Invoke(NativePtr);
  public bool IsTwoCurvedRunStair() => GetDelegate<IsTwoCurvedRunStairDelegate>().Invoke(NativePtr);
  public bool IsTwoQuarterTurnStair() => GetDelegate<IsTwoQuarterTurnStairDelegate>().Invoke(NativePtr);
  public bool IsTwoQuarterWindingStair() => GetDelegate<IsTwoQuarterWindingStairDelegate>().Invoke(NativePtr);
  public bool IsTwoStraightRunStair() => GetDelegate<IsTwoStraightRunStairDelegate>().Invoke(NativePtr);
  public bool IsCurved() => GetDelegate<IsCurvedDelegate>().Invoke(NativePtr);
  public bool IsSpiral() => GetDelegate<IsSpiralDelegate>().Invoke(NativePtr);
  public bool IsStraight() => GetDelegate<IsStraightDelegate>().Invoke(NativePtr);
  public bool IsWinder() => GetDelegate<IsWinderDelegate>().Invoke(NativePtr);
  public bool IsElementedWall() => GetDelegate<IsElementedWallDelegate>().Invoke(NativePtr);
  public bool IsMovable() => GetDelegate<IsMovableDelegate>().Invoke(NativePtr);
  public bool IsParapet() => GetDelegate<IsParapetDelegate>().Invoke(NativePtr);
  public bool IsPartitioning() => GetDelegate<IsPartitioningDelegate>().Invoke(NativePtr);
  public bool IsPlumbingWall() => GetDelegate<IsPlumbingWallDelegate>().Invoke(NativePtr);
  public bool IsPolygonal() => GetDelegate<IsPolygonalDelegate>().Invoke(NativePtr);
  public bool IsShear() => GetDelegate<IsShearDelegate>().Invoke(NativePtr);
  public bool IsSolidWall() => GetDelegate<IsSolidWallDelegate>().Invoke(NativePtr);
  public bool IsStandard() => GetDelegate<IsStandardDelegate>().Invoke(NativePtr);
  public bool IsLightdome() => GetDelegate<IsLightdomeDelegate>().Invoke(NativePtr);
  public bool IsSkylight() => GetDelegate<IsSkylightDelegate>().Invoke(NativePtr);
  public bool IsWindow() => GetDelegate<IsWindowDelegate>().Invoke(NativePtr);
  public bool IsOpening() => GetDelegate<IsOpeningDelegate>().Invoke(NativePtr);
  public bool IsRecess() => GetDelegate<IsRecessDelegate>().Invoke(NativePtr);
  public bool IsAnchorbolt() => GetDelegate<IsAnchorboltDelegate>().Invoke(NativePtr);
  public bool IsBolt() => GetDelegate<IsBoltDelegate>().Invoke(NativePtr);
  public bool IsDowel() => GetDelegate<IsDowelDelegate>().Invoke(NativePtr);
  public bool IsNail() => GetDelegate<IsNailDelegate>().Invoke(NativePtr);
  public bool IsNailPlate() => GetDelegate<IsNailPlateDelegate>().Invoke(NativePtr);
  public bool IsRivet() => GetDelegate<IsRivetDelegate>().Invoke(NativePtr);
  public bool IsScrew() => GetDelegate<IsScrewDelegate>().Invoke(NativePtr);
  public bool IsShearConnector() => GetDelegate<IsShearConnectorDelegate>().Invoke(NativePtr);
  public bool IsStaple() => GetDelegate<IsStapleDelegate>().Invoke(NativePtr);
  public bool IsStudShearConnector() => GetDelegate<IsStudShearConnectorDelegate>().Invoke(NativePtr);
  public bool IsGlue() => GetDelegate<IsGlueDelegate>().Invoke(NativePtr);
  public bool IsMortar() => GetDelegate<IsMortarDelegate>().Invoke(NativePtr);
  public bool IsWeld() => GetDelegate<IsWeldDelegate>().Invoke(NativePtr);
  public bool IsExternal() => GetDelegate<IsExternalDelegate>().Invoke(NativePtr);
  public bool IsGfa() => GetDelegate<IsGfaDelegate>().Invoke(NativePtr);
  public bool IsInternal() => GetDelegate<IsInternalDelegate>().Invoke(NativePtr);
  public bool IsParking() => GetDelegate<IsParkingDelegate>().Invoke(NativePtr);
  public bool IsSpace() => GetDelegate<IsSpaceDelegate>().Invoke(NativePtr);
  public bool IsAccessoryAssembly() => GetDelegate<IsAccessoryAssemblyDelegate>().Invoke(NativePtr);
  public bool IsArch() => GetDelegate<IsArchDelegate>().Invoke(NativePtr);
  public bool IsBeamGrid() => GetDelegate<IsBeamGridDelegate>().Invoke(NativePtr);
  public bool IsBracedFrame() => GetDelegate<IsBracedFrameDelegate>().Invoke(NativePtr);
  public bool IsGirder() => GetDelegate<IsGirderDelegate>().Invoke(NativePtr);
  public bool IsReinforcementUnit() => GetDelegate<IsReinforcementUnitDelegate>().Invoke(NativePtr);
  public bool IsRigidFrame() => GetDelegate<IsRigidFrameDelegate>().Invoke(NativePtr);
  public bool IsSlabField() => GetDelegate<IsSlabFieldDelegate>().Invoke(NativePtr);
  public bool IsTruss() => GetDelegate<IsTrussDelegate>().Invoke(NativePtr);
  public bool IsCableLadderSegment() => GetDelegate<IsCableLadderSegmentDelegate>().Invoke(NativePtr);
  public bool IsCableTraySegment() => GetDelegate<IsCableTraySegmentDelegate>().Invoke(NativePtr);
  public bool IsCableTrunkingSegment() => GetDelegate<IsCableTrunkingSegmentDelegate>().Invoke(NativePtr);
  public bool IsConduitSegment() => GetDelegate<IsConduitSegmentDelegate>().Invoke(NativePtr);
  public bool IsBusbarSegment() => GetDelegate<IsBusbarSegmentDelegate>().Invoke(NativePtr);
  public bool IsCableSegment() => GetDelegate<IsCableSegmentDelegate>().Invoke(NativePtr);
  public bool IsConductorSegment() => GetDelegate<IsCableSegmentDelegate>().Invoke(NativePtr);
  public bool IsCoreSegment() => GetDelegate<IsCableSegmentDelegate>().Invoke(NativePtr);
  public bool IsFlexibleSegment() => GetDelegate<IsCableSegmentDelegate>().Invoke(NativePtr);
  public bool IsRigidSegment() => GetDelegate<IsCableSegmentDelegate>().Invoke(NativePtr);
  public bool IsCulvert() => GetDelegate<IsCableSegmentDelegate>().Invoke(NativePtr);
  public bool IsGutter() => GetDelegate<IsCableSegmentDelegate>().Invoke(NativePtr);
  public bool IsSpool() => GetDelegate<IsCableSegmentDelegate>().Invoke(NativePtr);
  public bool IsAudioVisualOutlet() => GetDelegate<IsCableSegmentDelegate>().Invoke(NativePtr);
  public bool IsCommunicationsOutlet() => GetDelegate<IsCableSegmentDelegate>().Invoke(NativePtr);
  public bool IsPowerOutlet() => GetDelegate<IsCableSegmentDelegate>().Invoke(NativePtr);
  public bool IsDataOutlet() => GetDelegate<IsCableSegmentDelegate>().Invoke(NativePtr);
  public bool IsTelephoneOutlet() => GetDelegate<IsCableSegmentDelegate>().Invoke(NativePtr);
  public bool IsAnchoring() => GetDelegate<IsCableSegmentDelegate>().Invoke(NativePtr);
  public bool IsEdge() => GetDelegate<IsCableSegmentDelegate>().Invoke(NativePtr);
  public bool IsLigature() => GetDelegate<IsCableSegmentDelegate>().Invoke(NativePtr);
  public bool IsMain() => GetDelegate<IsCableSegmentDelegate>().Invoke(NativePtr);
  public bool IsPunching() => GetDelegate<IsCableSegmentDelegate>().Invoke(NativePtr);
  public bool IsRing() => GetDelegate<IsCableSegmentDelegate>().Invoke(NativePtr);
  public void SetNone() => GetDelegate<SetNoneDelegate>().Invoke(NativePtr);
  public void SetCeiling() => GetDelegate<SetCeilingDelegate>().Invoke(NativePtr);
  public void SetCladding() => GetDelegate<SetCladdingDelegate>().Invoke(NativePtr);
  public void SetFlooring() => GetDelegate<SetFlooringDelegate>().Invoke(NativePtr);
  public void SetInsulation() => GetDelegate<SetInsulationDelegate>().Invoke(NativePtr);
  public void SetMembrane() => GetDelegate<SetMembraneDelegate>().Invoke(NativePtr);
  public void SetRoofing() => GetDelegate<SetRoofingDelegate>().Invoke(NativePtr);
  public void SetSleeving() => GetDelegate<SetSleevingDelegate>().Invoke(NativePtr);
  public void SetWrapping() => GetDelegate<SetWrappingDelegate>().Invoke(NativePtr);
  public void SetFootingBeam() => GetDelegate<SetFootingBeamDelegate>().Invoke(NativePtr);
  public void SetPadFooting() => GetDelegate<SetPadFootingDelegate>().Invoke(NativePtr);
  public void SetPileCap() => GetDelegate<SetPileCapDelegate>().Invoke(NativePtr);
  public void SetStripFooting() => GetDelegate<SetStripFootingDelegate>().Invoke(NativePtr);
  public void SetCohesion() => GetDelegate<SetCohesionDelegate>().Invoke(NativePtr);
  public void SetFriction() => GetDelegate<SetFrictionDelegate>().Invoke(NativePtr);
  public void SetSupport() => GetDelegate<SetSupportDelegate>().Invoke(NativePtr);
  public void SetBalustrade() => GetDelegate<SetBalustradeDelegate>().Invoke(NativePtr);
  public void SetGuardrail() => GetDelegate<SetGuardrailDelegate>().Invoke(NativePtr);
  public void SetHandrail() => GetDelegate<SetHandrailDelegate>().Invoke(NativePtr);
  public void SetBaseslab() => GetDelegate<SetBaseslabDelegate>().Invoke(NativePtr);
  public void SetFloor() => GetDelegate<SetFloorDelegate>().Invoke(NativePtr);
  public void SetLanding() => GetDelegate<SetLandingDelegate>().Invoke(NativePtr);
  public void SetRoof() => GetDelegate<SetRoofDelegate>().Invoke(NativePtr);
  public void SetBeam() => GetDelegate<SetBeamDelegate>().Invoke(NativePtr);
  public void SetHollowcore() => GetDelegate<SetHollowcoreDelegate>().Invoke(NativePtr);
  public void SetJoist() => GetDelegate<SetJoistDelegate>().Invoke(NativePtr);
  public void SetLintel() => GetDelegate<SetLintelDelegate>().Invoke(NativePtr);
  public void SetSpandrel() => GetDelegate<SetSpandrelDelegate>().Invoke(NativePtr);
  public void SetTbeam() => GetDelegate<SetTbeamDelegate>().Invoke(NativePtr);
  public void SetComplex() => GetDelegate<SetComplexDelegate>().Invoke(NativePtr);
  public void SetElement() => GetDelegate<SetElementDelegate>().Invoke(NativePtr);
  public void SetPartial() => GetDelegate<SetPartialDelegate>().Invoke(NativePtr);
  public void SetProvisionForSpace() => GetDelegate<SetProvisionForSpaceDelegate>().Invoke(NativePtr);
  public void SetProvisionFOrVoid() => GetDelegate<SetProvisionFOrVoidDelegate>().Invoke(NativePtr);
  public void SetColumn() => GetDelegate<SetColumnDelegate>().Invoke(NativePtr);
  public void SetPilaster() => GetDelegate<SetPilasterDelegate>().Invoke(NativePtr);
  public void SetMolding() => GetDelegate<SetMoldingDelegate>().Invoke(NativePtr);
  public void SetSkirtingboard() => GetDelegate<SetSkirtingboardDelegate>().Invoke(NativePtr);
  public void SetDoor() => GetDelegate<SetDoorDelegate>().Invoke(NativePtr);
  public void SetGate() => GetDelegate<SetGateDelegate>().Invoke(NativePtr);
  public void SetTrapDoor() => GetDelegate<SetTrapDoorDelegate>().Invoke(NativePtr);
  public void SetCaissonFoundation() => GetDelegate<SetCaissonFoundationDelegate>().Invoke(NativePtr);
  public void SetBrace() => GetDelegate<SetBraceDelegate>().Invoke(NativePtr);
  public void SetChord() => GetDelegate<SetChordDelegate>().Invoke(NativePtr);
  public void SetCollar() => GetDelegate<SetCollarDelegate>().Invoke(NativePtr);
  public void SetMember() => GetDelegate<SetMemberDelegate>().Invoke(NativePtr);
  public void SetMullion() => GetDelegate<SetMullionDelegate>().Invoke(NativePtr);
  public void SetPlate() => GetDelegate<SetPlateDelegate>().Invoke(NativePtr);
  public void SetPost() => GetDelegate<SetPostDelegate>().Invoke(NativePtr);
  public void SetPurlin() => GetDelegate<SetPurlinDelegate>().Invoke(NativePtr);
  public void SetRafter() => GetDelegate<SetRafterDelegate>().Invoke(NativePtr);
  public void SetStringer() => GetDelegate<SetStringerDelegate>().Invoke(NativePtr);
  public void SetStrut() => GetDelegate<SetStrutDelegate>().Invoke(NativePtr);
  public void SetStud() => GetDelegate<SetStudDelegate>().Invoke(NativePtr);
  public void SetBored() => GetDelegate<SetBoredDelegate>().Invoke(NativePtr);
  public void SetDriven() => GetDelegate<SetDrivenDelegate>().Invoke(NativePtr);
  public void SetJetgrouting() => GetDelegate<SetJetgroutingDelegate>().Invoke(NativePtr);
  public void SetCurtainFanel() => GetDelegate<SetCurtainFanelDelegate>().Invoke(NativePtr);
  public void SetSheet() => GetDelegate<SetSheetDelegate>().Invoke(NativePtr);
  public void SetHalfTurnRamp() => GetDelegate<SetHalfTurnRampDelegate>().Invoke(NativePtr);
  public void SetQuarterTurnRamp() => GetDelegate<SetQuarterTurnRampDelegate>().Invoke(NativePtr);
  public void SetSpiralRamp() => GetDelegate<SetSpiralRampDelegate>().Invoke(NativePtr);
  public void SetStraightRunRamp() => GetDelegate<SetStraightRunRampDelegate>().Invoke(NativePtr);
  public void SetTwoQuarterTurnRamp() => GetDelegate<SetTwoQuarterTurnRampDelegate>().Invoke(NativePtr);
  public void SetTwoStraightRunRamp() => GetDelegate<SetTwoStraightRunRampDelegate>().Invoke(NativePtr);
  public void SetBarrelRoof() => GetDelegate<SetBarrelRoofDelegate>().Invoke(NativePtr);
  public void SetButterflyRoof() => GetDelegate<SetButterflyRoofDelegate>().Invoke(NativePtr);
  public void SetDomeRoof() => GetDelegate<SetDomeRoofDelegate>().Invoke(NativePtr);
  public void SetFlatRoof() => GetDelegate<SetFlatRoofDelegate>().Invoke(NativePtr);
  public void SetFreeform() => GetDelegate<SetFreeformDelegate>().Invoke(NativePtr);
  public void SetGableRoof() => GetDelegate<SetGableRoofDelegate>().Invoke(NativePtr);
  public void SetGambrelRoof() => GetDelegate<SetGambrelRoofDelegate>().Invoke(NativePtr);
  public void SetHippedGableRoof() => GetDelegate<SetHippedGableRoofDelegate>().Invoke(NativePtr);
  public void SetHipRoof() => GetDelegate<SetHipRoofDelegate>().Invoke(NativePtr);
  public void SetMansardRoof() => GetDelegate<SetMansardRoofDelegate>().Invoke(NativePtr);
  public void SetPavilionRoof() => GetDelegate<SetPavilionRoofDelegate>().Invoke(NativePtr);
  public void SetRainbowRoof() => GetDelegate<SetRainbowRoofDelegate>().Invoke(NativePtr);
  public void SetShedRoof() => GetDelegate<SetShedRoofDelegate>().Invoke(NativePtr);
  public void SetCurvedRunStair() => GetDelegate<SetCurvedRunStairDelegate>().Invoke(NativePtr);
  public void SetDoubleReturnStair() => GetDelegate<SetDoubleReturnStairDelegate>().Invoke(NativePtr);
  public void SetHalfTurnStair() => GetDelegate<SetHalfTurnStairDelegate>().Invoke(NativePtr);
  public void SetHalfWindingStair() => GetDelegate<SetHalfWindingStairDelegate>().Invoke(NativePtr);
  public void SetQuarterTurnStair() => GetDelegate<SetQuarterTurnStairDelegate>().Invoke(NativePtr);
  public void SetQuarterWindingStair() => GetDelegate<SetQuarterWindingStairDelegate>().Invoke(NativePtr);
  public void SetSpiralStair() => GetDelegate<SetSpiralStairDelegate>().Invoke(NativePtr);
  public void SetStraightRunStair() => GetDelegate<SetStraightRunStairDelegate>().Invoke(NativePtr);
  public void SetThreeQuarterturnstair() => GetDelegate<SetThreeQuarterturnstairDelegate>().Invoke(NativePtr);
  public void SetThreeQuarterwindingstair() => GetDelegate<SetThreeQuarterwindingstairDelegate>().Invoke(NativePtr);
  public void SetTwoCurvedRunStair() => GetDelegate<SetTwoCurvedRunStairDelegate>().Invoke(NativePtr);
  public void SetTwoQuarterTurnStair() => GetDelegate<SetTwoQuarterTurnStairDelegate>().Invoke(NativePtr);
  public void SetTwoQuarterWindingStair() => GetDelegate<SetTwoQuarterWindingStairDelegate>().Invoke(NativePtr);
  public void SetTwoStraightRunStair() => GetDelegate<SetTwoStraightRunStairDelegate>().Invoke(NativePtr);
  public void SetCurved() => GetDelegate<SetCurvedDelegate>().Invoke(NativePtr);
  public void SetSpiral() => GetDelegate<SetSpiralDelegate>().Invoke(NativePtr);
  public void SetStraight() => GetDelegate<SetStraightDelegate>().Invoke(NativePtr);
  public void SetWinder() => GetDelegate<SetWinderDelegate>().Invoke(NativePtr);
  public void SetElementedWall() => GetDelegate<SetElementedWallDelegate>().Invoke(NativePtr);
  public void SetMovable() => GetDelegate<SetMovableDelegate>().Invoke(NativePtr);
  public void SetParapet() => GetDelegate<SetParapetDelegate>().Invoke(NativePtr);
  public void SetPartitioning() => GetDelegate<SetPartitioningDelegate>().Invoke(NativePtr);
  public void SetPlumbingWall() => GetDelegate<SetPlumbingWallDelegate>().Invoke(NativePtr);
  public void SetPolygonal() => GetDelegate<SetPolygonalDelegate>().Invoke(NativePtr);
  public void SetShear() => GetDelegate<SetShearDelegate>().Invoke(NativePtr);
  public void SetSolidWall() => GetDelegate<SetSolidWallDelegate>().Invoke(NativePtr);
  public void SetStandard() => GetDelegate<SetStandardDelegate>().Invoke(NativePtr);
  public void SetLightdome() => GetDelegate<SetLightdomeDelegate>().Invoke(NativePtr);
  public void SetSkylight() => GetDelegate<SetSkylightDelegate>().Invoke(NativePtr);
  public void SetWindow() => GetDelegate<SetWindowDelegate>().Invoke(NativePtr);
  public void SetOpening() => GetDelegate<SetOpeningDelegate>().Invoke(NativePtr);
  public void SetRecess() => GetDelegate<SetRecessDelegate>().Invoke(NativePtr);
  public void SetAnchorbolt() => GetDelegate<SetAnchorboltDelegate>().Invoke(NativePtr);
  public void SetBolt() => GetDelegate<SetBoltDelegate>().Invoke(NativePtr);
  public void SetDowel() => GetDelegate<SetDowelDelegate>().Invoke(NativePtr);
  public void SetNail() => GetDelegate<SetNailDelegate>().Invoke(NativePtr);
  public void SetNailplate() => GetDelegate<SetNailplateDelegate>().Invoke(NativePtr);
  public void SetRivet() => GetDelegate<SetRivetDelegate>().Invoke(NativePtr);
  public void SetScrew() => GetDelegate<SetScrewDelegate>().Invoke(NativePtr);
  public void SetShearconnector() => GetDelegate<SetShearconnectorDelegate>().Invoke(NativePtr);
  public void SetStaple() => GetDelegate<SetStapleDelegate>().Invoke(NativePtr);
  public void SetStudshearconnector() => GetDelegate<SetStudshearconnectorDelegate>().Invoke(NativePtr);
  public void SetGlue() => GetDelegate<SetGlueDelegate>().Invoke(NativePtr);
  public void SetMortar() => GetDelegate<SetMortarDelegate>().Invoke(NativePtr);
  public void SetWeld() => GetDelegate<SetWeldDelegate>().Invoke(NativePtr);
  public void SetExternal() => GetDelegate<SetExternalDelegate>().Invoke(NativePtr);
  public void SetGfa() => GetDelegate<SetGfaDelegate>().Invoke(NativePtr);
  public void SetInternal() => GetDelegate<SetInternalDelegate>().Invoke(NativePtr);
  public void SetParking() => GetDelegate<SetParkingDelegate>().Invoke(NativePtr);
  public void SetSpace() => GetDelegate<SetSpaceDelegate>().Invoke(NativePtr);
  public void SetAccessoryAssembly() => GetDelegate<SetAccessoryAssemblyDelegate>().Invoke(NativePtr);
  public void SetArch() => GetDelegate<SetArchDelegate>().Invoke(NativePtr);
  public void SetBeamGrid() => GetDelegate<SetBeamGridDelegate>().Invoke(NativePtr);
  public void SetBracedFrame() => GetDelegate<SetBracedFrameDelegate>().Invoke(NativePtr);
  public void SetGirder() => GetDelegate<SetGirderDelegate>().Invoke(NativePtr);
  public void SetReinforcementUnit() => GetDelegate<SetReinforcementUnitDelegate>().Invoke(NativePtr);
  public void SetRigidFrame() => GetDelegate<SetRigidFrameDelegate>().Invoke(NativePtr);
  public void SetSlabField() => GetDelegate<SetSlabFieldDelegate>().Invoke(NativePtr);
  public void SetTruss() => GetDelegate<SetTrussDelegate>().Invoke(NativePtr);
  public void SetCableLadderSegment() => GetDelegate<SetCableLadderSegmentDelegate>().Invoke(NativePtr);
  public void SetCableTraySegment() => GetDelegate<SetCableTraySegmentDelegate>().Invoke(NativePtr);
  public void SetCableTrunkingSegment() => GetDelegate<SetCableTrunkingSegmentDelegate>().Invoke(NativePtr);
  public void SetConduitSegment() => GetDelegate<SetConduitSegmentDelegate>().Invoke(NativePtr);
  public void SetBusbarSegment() => GetDelegate<SetBusbarSegmentDelegate>().Invoke(NativePtr);
  public void SetCableSegment() => GetDelegate<SetCableSegmentDelegate>().Invoke(NativePtr);
  public void SetConductorSegment() => GetDelegate<SetConductorSegmentDelegate>().Invoke(NativePtr);
  public void SetCoreSegment() => GetDelegate<SetCoreSegmentDelegate>().Invoke(NativePtr);
  public void SetFlexibleSegment() => GetDelegate<SetFlexibleSegmentDelegate>().Invoke(NativePtr);
  public void SetRigidSegment() => GetDelegate<SetRigidSegmentDelegate>().Invoke(NativePtr);
  public void SetCulvert() => GetDelegate<SetCulvertDelegate>().Invoke(NativePtr);
  public void SetGutter() => GetDelegate<SetGutterDelegate>().Invoke(NativePtr);
  public void SetSpool() => GetDelegate<SetSpoolDelegate>().Invoke(NativePtr);
  public void SetAudioVisualOutlet() => GetDelegate<SetAudioVisualOutletDelegate>().Invoke(NativePtr);
  public void SetCommunicationsOutlet() => GetDelegate<SetCommunicationsOutletDelegate>().Invoke(NativePtr);
  public void SetPowerOutlet() => GetDelegate<SetPowerOutletDelegate>().Invoke(NativePtr);
  public void SetDataOutlet() => GetDelegate<SetDataOutletDelegate>().Invoke(NativePtr);
  public void SetTelephoneOutlet() => GetDelegate<SetTelephoneOutletDelegate>().Invoke(NativePtr);
  public void SetAnchoring() => GetDelegate<SetAnchoringDelegate>().Invoke(NativePtr);
  public void SetEdge() => GetDelegate<SetEdgeDelegate>().Invoke(NativePtr);
  public void SetLigature() => GetDelegate<SetLigatureDelegate>().Invoke(NativePtr);
  public void SetMain() => GetDelegate<SetMainDelegate>().Invoke(NativePtr);
  public void SetPunching() => GetDelegate<SetPunchingDelegate>().Invoke(NativePtr);
  public void SetRing() => GetDelegate<SetRingDelegate>().Invoke(NativePtr);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class IfcPredefinedTypeInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr destroyFunctionPtr;
    internal IntPtr isNoneFunctionPtr;
    internal IntPtr isCeilingFunctionPtr;
    internal IntPtr isCladdingFunctionPtr;
    internal IntPtr isFlooringFunctionPtr;
    internal IntPtr isInsulationFunctionPtr;
    internal IntPtr isMembraneFunctionPtr;
    internal IntPtr isRoofingFunctionPtr;
    internal IntPtr isSleevingFunctionPtr;
    internal IntPtr isWrappingFunctionPtr;
    internal IntPtr isFootingBeamFunctionPtr;
    internal IntPtr isPadFootingFunctionPtr;
    internal IntPtr isPileCapFunctionPtr;
    internal IntPtr isStripFootingFunctionPtr;
    internal IntPtr isCohesionFunctionPtr;
    internal IntPtr isFrictionFunctionPtr;
    internal IntPtr isSupportFunctionPtr;
    internal IntPtr isBalustradeFunctionPtr;
    internal IntPtr isGuardrailFunctionPtr;
    internal IntPtr isHandrailFunctionPtr;
    internal IntPtr isBaseslabFunctionPtr;
    internal IntPtr isFloorFunctionPtr;
    internal IntPtr isLandingFunctionPtr;
    internal IntPtr isRoofFunctionPtr;
    internal IntPtr isBeamFunctionPtr;
    internal IntPtr isHollowcoreFunctionPtr;
    internal IntPtr isJoistFunctionPtr;
    internal IntPtr isLintelFunctionPtr;
    internal IntPtr isSpandrelFunctionPtr;
    internal IntPtr isTbeamFunctionPtr;
    internal IntPtr isComplexFunctionPtr;
    internal IntPtr isElementFunctionPtr;
    internal IntPtr isPartialFunctionPtr;
    internal IntPtr isProvisionForSpaceFunctionPtr;
    internal IntPtr isProvisionForVoidFunctionPtr;
    internal IntPtr isColumnFunctionPtr;
    internal IntPtr isPilasterFunctionPtr;
    internal IntPtr isMoldingFunctionPtr;
    internal IntPtr isSkirtingboardFunctionPtr;
    internal IntPtr isDoorFunctionPtr;
    internal IntPtr isGateFunctionPtr;
    internal IntPtr isTrapDoorFunctionPtr;
    internal IntPtr isCaissonFoundationFunctionPtr;
    internal IntPtr isBraceFunctionPtr;
    internal IntPtr isChordFunctionPtr;
    internal IntPtr isCollarFunctionPtr;
    internal IntPtr isMemberFunctionPtr;
    internal IntPtr isMullionFunctionPtr;
    internal IntPtr isPlateFunctionPtr;
    internal IntPtr isPostFunctionPtr;
    internal IntPtr isPurlinFunctionPtr;
    internal IntPtr isRafterFunctionPtr;
    internal IntPtr isStringerFunctionPtr;
    internal IntPtr isStrutFunctionPtr;
    internal IntPtr isStudFunctionPtr;
    internal IntPtr isBoredFunctionPtr;
    internal IntPtr isDrivenFunctionPtr;
    internal IntPtr isJetgroutingFunctionPtr;
    internal IntPtr isCurtainPanelFunctionPtr;
    internal IntPtr isSheetFunctionPtr;
    internal IntPtr isHalfTurnRampFunctionPtr;
    internal IntPtr isQuarterTurnRampFunctionPtr;
    internal IntPtr isSpiralRampFunctionPtr;
    internal IntPtr isStraightRunRampFunctionPtr;
    internal IntPtr isTwoQuarterTurnRampFunctionPtr;
    internal IntPtr isTwoStraightRunRampFunctionPtr;
    internal IntPtr isBarrelRoofFunctionPtr;
    internal IntPtr isButterflyRoofFunctionPtr;
    internal IntPtr isDomeRoofFunctionPtr;
    internal IntPtr isFlatRoofFunctionPtr;
    internal IntPtr isFreeformFunctionPtr;
    internal IntPtr isGableRoofFunctionPtr;
    internal IntPtr isGambrelRoofFunctionPtr;
    internal IntPtr isHippedGableRoofFunctionPtr;
    internal IntPtr isHipRoofFunctionPtr;
    internal IntPtr isMansardRoofFunctionPtr;
    internal IntPtr isPavilionRoofFunctionPtr;
    internal IntPtr isRainbowRoofFunctionPtr;
    internal IntPtr isShedRoofFunctionPtr;
    internal IntPtr isCurvedRunStairFunctionPtr;
    internal IntPtr isDoubleReturnStairFunctionPtr;
    internal IntPtr isHalfTurnStairFunctionPtr;
    internal IntPtr isHalfWindingStairFunctionPtr;
    internal IntPtr isQuarterTurnStairFunctionPtr;
    internal IntPtr isQuarterWindingStairFunctionPtr;
    internal IntPtr isSpiralStairFunctionPtr;
    internal IntPtr isStraightRunStairFunctionPtr;
    internal IntPtr isThreeQuarterTurnStairFunctionPtr;
    internal IntPtr isThreeQuarterWindingStairFunctionPtr;
    internal IntPtr isTwoCurvedRunStairFunctionPtr;
    internal IntPtr isTwoQuarterTurnStairFunctionPtr;
    internal IntPtr isTwoQuarterWindingStairFunctionPtr;
    internal IntPtr isTwoStraightRunStairFunctionPtr;
    internal IntPtr isCurvedFunctionPtr;
    internal IntPtr isSpiralFunctionPtr;
    internal IntPtr isStraightFunctionPtr;
    internal IntPtr isWinderFunctionPtr;
    internal IntPtr isElementedWallFunctionPtr;
    internal IntPtr isMovableFunctionPtr;
    internal IntPtr isParapetFunctionPtr;
    internal IntPtr isPartitioningFunctionPtr;
    internal IntPtr isPlumbingWallFunctionPtr;
    internal IntPtr isPolygonalFunctionPtr;
    internal IntPtr isShearFunctionPtr;
    internal IntPtr isSolidWallFunctionPtr;
    internal IntPtr isStandardFunctionPtr;
    internal IntPtr isLightdomeFunctionPtr;
    internal IntPtr isSkylightFunctionPtr;
    internal IntPtr isWindowFunctionPtr;
    internal IntPtr isOpeningFunctionPtr;
    internal IntPtr isRecessFunctionPtr;
    internal IntPtr isAnchorboltFunctionPtr;
    internal IntPtr isBoltFunctionPtr;
    internal IntPtr isDowelFunctionPtr;
    internal IntPtr isNailFunctionPtr;
    internal IntPtr isNailPlateFunctionPtr;
    internal IntPtr isRivetFunctionPtr;
    internal IntPtr isScrewFunctionPtr;
    internal IntPtr isShearConnectorFunctionPtr;
    internal IntPtr isStapleFunctionPtr;
    internal IntPtr isStudShearConnectorFunctionPtr;
    internal IntPtr isGlueFunctionPtr;
    internal IntPtr isMortarFunctionPtr;
    internal IntPtr isWeldFunctionPtr;
    internal IntPtr isExternalFunctionPtr;
    internal IntPtr isGfaFunctionPtr;
    internal IntPtr isInternalFunctionPtr;
    internal IntPtr isParkingFunctionPtr;
    internal IntPtr isSpaceFunctionPtr;
    internal IntPtr isAccessoryAssemblyFunctionPtr;
    internal IntPtr isArchFunctionPtr;
    internal IntPtr isBeamGridFunctionPtr;
    internal IntPtr isBracedFrameFunctionPtr;
    internal IntPtr isGirderFunctionPtr;
    internal IntPtr isReinforcementUnitFunctionPtr;
    internal IntPtr isRigidFrameFunctionPtr;
    internal IntPtr isSlabFieldFunctionPtr;
    internal IntPtr isTrussFunctionPtr;
    internal IntPtr isCableLadderSegmentFunctionPtr;
    internal IntPtr isCableTraySegmentFunctionPtr;
    internal IntPtr isCableTrunkingSegmentFunctionPtr;
    internal IntPtr isConduitSegmentFunctionPtr;
    internal IntPtr isBusbarSegmentFunctionPtr;
    internal IntPtr isCableSegmentFunctionPtr;
    internal IntPtr isConductorSegmentFunctionPtr;
    internal IntPtr isCoreSegmentFunctionPtr;
    internal IntPtr isFlexibleSegmentFunctionPtr;
    internal IntPtr isRigidSegmentFunctionPtr;
    internal IntPtr isCulvertFunctionPtr;
    internal IntPtr isGutterFunctionPtr;
    internal IntPtr isSpoolFunctionPtr;
    internal IntPtr isAudioVisualOutletFunctionPtr;
    internal IntPtr isCommunicationsOutletFunctionPtr;
    internal IntPtr isPowerOutletFunctionPtr;
    internal IntPtr isDataOutletFunctionPtr;
    internal IntPtr isTelephoneOutletFunctionPtr;
    internal IntPtr isAnchoringFunctionPtr;
    internal IntPtr isEdgeFunctionPtr;
    internal IntPtr isLigatureFunctionPtr;
    internal IntPtr isMainFunctionPtr;
    internal IntPtr isPunchingFunctionPtr;
    internal IntPtr isRingFunctionPtr;
    internal IntPtr setNoneFunctionPtr;
    internal IntPtr setCeilingFunctionPtr;
    internal IntPtr setCladdingFunctionPtr;
    internal IntPtr setFlooringFunctionPtr;
    internal IntPtr setInsulationFunctionPtr;
    internal IntPtr setMembraneFunctionPtr;
    internal IntPtr setRoofingFunctionPtr;
    internal IntPtr setSleevingFunctionPtr;
    internal IntPtr setWrappingFunctionPtr;
    internal IntPtr setFootingBeamFunctionPtr;
    internal IntPtr setPadFootingFunctionPtr;
    internal IntPtr setPileCapFunctionPtr;
    internal IntPtr setStripFootingFunctionPtr;
    internal IntPtr setCohesionFunctionPtr;
    internal IntPtr setFrictionFunctionPtr;
    internal IntPtr setSupportFunctionPtr;
    internal IntPtr setBalustradeFunctionPtr;
    internal IntPtr setGuardrailFunctionPtr;
    internal IntPtr setHandrailFunctionPtr;
    internal IntPtr setBaseslabFunctionPtr;
    internal IntPtr setFloorFunctionPtr;
    internal IntPtr setLandingFunctionPtr;
    internal IntPtr setRoofFunctionPtr;
    internal IntPtr setBeamFunctionPtr;
    internal IntPtr setHollowcoreFunctionPtr;
    internal IntPtr setJoistFunctionPtr;
    internal IntPtr setLintelFunctionPtr;
    internal IntPtr setSpandrelFunctionPtr;
    internal IntPtr setTbeamFunctionPtr;
    internal IntPtr setComplexFunctionPtr;
    internal IntPtr setElementFunctionPtr;
    internal IntPtr setPartialFunctionPtr;
    internal IntPtr setProvisionForSpaceFunctionPtr;
    internal IntPtr setProvisionFOrVoidFunctionPtr;
    internal IntPtr setColumnFunctionPtr;
    internal IntPtr setPilasterFunctionPtr;
    internal IntPtr setMoldingFunctionPtr;
    internal IntPtr setSkirtingboardFunctionPtr;
    internal IntPtr setDoorFunctionPtr;
    internal IntPtr setGateFunctionPtr;
    internal IntPtr setTrapDoorFunctionPtr;
    internal IntPtr setCaissonFoundationFunctionPtr;
    internal IntPtr setBraceFunctionPtr;
    internal IntPtr setChordFunctionPtr;
    internal IntPtr setCollarFunctionPtr;
    internal IntPtr setMemberFunctionPtr;
    internal IntPtr setMullionFunctionPtr;
    internal IntPtr setPlateFunctionPtr;
    internal IntPtr setPostFunctionPtr;
    internal IntPtr setPurlinFunctionPtr;
    internal IntPtr setRafterFunctionPtr;
    internal IntPtr setStringerFunctionPtr;
    internal IntPtr setStrutFunctionPtr;
    internal IntPtr setStudFunctionPtr;
    internal IntPtr setBoredFunctionPtr;
    internal IntPtr setDrivenFunctionPtr;
    internal IntPtr setJetgroutingFunctionPtr;
    internal IntPtr setCurtainFanelFunctionPtr;
    internal IntPtr setSheetFunctionPtr;
    internal IntPtr setHalfTurnRampFunctionPtr;
    internal IntPtr setQuarterTurnRampFunctionPtr;
    internal IntPtr setSpiralRampFunctionPtr;
    internal IntPtr setStraightRunRampFunctionPtr;
    internal IntPtr setTwoQuarterTurnRampFunctionPtr;
    internal IntPtr setTwoStraightRunRampFunctionPtr;
    internal IntPtr setBarrelRoofFunctionPtr;
    internal IntPtr setButterflyRoofFunctionPtr;
    internal IntPtr setDomeRoofFunctionPtr;
    internal IntPtr setFlatRoofFunctionPtr;
    internal IntPtr setFreeformFunctionPtr;
    internal IntPtr setGableRoofFunctionPtr;
    internal IntPtr setGambrelRoofFunctionPtr;
    internal IntPtr setHippedGableRoofFunctionPtr;
    internal IntPtr setHipRoofFunctionPtr;
    internal IntPtr setMansardRoofFunctionPtr;
    internal IntPtr setPavilionRoofFunctionPtr;
    internal IntPtr setRainbowRoofFunctionPtr;
    internal IntPtr setShedRoofFunctionPtr;
    internal IntPtr setCurvedRunStairFunctionPtr;
    internal IntPtr setDoubleReturnStairFunctionPtr;
    internal IntPtr setHalfTurnStairFunctionPtr;
    internal IntPtr setHalfWindingStairFunctionPtr;
    internal IntPtr setQuarterTurnStairFunctionPtr;
    internal IntPtr setQuarterWindingStairFunctionPtr;
    internal IntPtr setSpiralStairFunctionPtr;
    internal IntPtr setStraightRunStairFunctionPtr;
    internal IntPtr setThreeQuarterturnstairFunctionPtr;
    internal IntPtr setThreeQuarterwindingstairFunctionPtr;
    internal IntPtr setTwoCurvedRunStairFunctionPtr;
    internal IntPtr setTwoQuarterTurnStairFunctionPtr;
    internal IntPtr setTwoQuarterWindingStairFunctionPtr;
    internal IntPtr setTwoStraightRunStairFunctionPtr;
    internal IntPtr setCurvedFunctionPtr;
    internal IntPtr setSpiralFunctionPtr;
    internal IntPtr setStraightFunctionPtr;
    internal IntPtr setWinderFunctionPtr;
    internal IntPtr setElementedWallFunctionPtr;
    internal IntPtr setMovableFunctionPtr;
    internal IntPtr setParapetFunctionPtr;
    internal IntPtr setPartitioningFunctionPtr;
    internal IntPtr setPlumbingWallFunctionPtr;
    internal IntPtr setPolygonalFunctionPtr;
    internal IntPtr setShearFunctionPtr;
    internal IntPtr setSolidWallFunctionPtr;
    internal IntPtr setStandardFunctionPtr;
    internal IntPtr setLightdomeFunctionPtr;
    internal IntPtr setSkylightFunctionPtr;
    internal IntPtr setWindowFunctionPtr;
    internal IntPtr setOpeningFunctionPtr;
    internal IntPtr setRecessFunctionPtr;
    internal IntPtr setAnchorboltFunctionPtr;
    internal IntPtr setBoltFunctionPtr;
    internal IntPtr setDowelFunctionPtr;
    internal IntPtr setNailFunctionPtr;
    internal IntPtr setNailplateFunctionPtr;
    internal IntPtr setRivetFunctionPtr;
    internal IntPtr setScrewFunctionPtr;
    internal IntPtr setShearconnectorFunctionPtr;
    internal IntPtr setStapleFunctionPtr;
    internal IntPtr setStudshearconnectorFunctionPtr;
    internal IntPtr setGlueFunctionPtr;
    internal IntPtr setMortarFunctionPtr;
    internal IntPtr setWeldFunctionPtr;
    internal IntPtr setExternalFunctionPtr;
    internal IntPtr setGfaFunctionPtr;
    internal IntPtr setInternalFunctionPtr;
    internal IntPtr setParkingFunctionPtr;
    internal IntPtr setSpaceFunctionPtr;
    internal IntPtr setAccessoryAssemblyFunctionPtr;
    internal IntPtr setArchFunctionPtr;
    internal IntPtr setBeamGridFunctionPtr;
    internal IntPtr setBracedFrameFunctionPtr;
    internal IntPtr setGirderFunctionPtr;
    internal IntPtr setReinforcementUnitFunctionPtr;
    internal IntPtr setRigidFrameFunctionPtr;
    internal IntPtr setSlabFieldFunctionPtr;
    internal IntPtr setTrussFunctionPtr;
    internal IntPtr setCableLadderSegmentFunctionPtr;
    internal IntPtr setCableTraySegmentFunctionPtr;
    internal IntPtr setCableTrunkingSegmentFunctionPtr;
    internal IntPtr setConduitSegmentFunctionPtr;
    internal IntPtr setBusbarSegmentFunctionPtr;
    internal IntPtr setCableSegmentFunctionPtr;
    internal IntPtr setConductorSegmentFunctionPtr;
    internal IntPtr setCoreSegmentFunctionPtr;
    internal IntPtr setFlexibleSegmentFunctionPtr;
    internal IntPtr setRigidSegmentFunctionPtr;
    internal IntPtr setCulvertFunctionPtr;
    internal IntPtr setGutterFunctionPtr;
    internal IntPtr setSpoolFunctionPtr;
    internal IntPtr setAudioVisualOutletFunctionPtr;
    internal IntPtr setCommunicationsOutletFunctionPtr;
    internal IntPtr setPowerOutletFunctionPtr;
    internal IntPtr setDataOutletFunctionPtr;
    internal IntPtr setTelephoneOutletFunctionPtr;
    internal IntPtr setAnchoringFunctionPtr;
    internal IntPtr setEdgeFunctionPtr;
    internal IntPtr setLigatureFunctionPtr;
    internal IntPtr setMainFunctionPtr;
    internal IntPtr setPunchingFunctionPtr;
    internal IntPtr setRingFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DestroyDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsNoneDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsCeilingDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsCladdingDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsFlooringDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsInsulationDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsMembraneDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsRoofingDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsSleevingDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsWrappingDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsFootingBeamDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsPadFootingDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsPileCapDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsStripFootingDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsCohesionDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsFrictionDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsSupportDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsBalustradeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsGuardrailDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsHandrailDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsBaseslabDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsFloorDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsLandingDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsRoofDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsBeamDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsHollowcoreDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsJoistDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsLintelDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsSpandrelDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsTbeamDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsComplexDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsElementDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsPartialDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsProvisionForSpaceDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsProvisionForVoidDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsColumnDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsPilasterDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsMoldingDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsSkirtingboardDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsDoorDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsGateDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsTrapDoorDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsCaissonFoundationDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsBraceDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsChordDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsCollarDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsMemberDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsMullionDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsPlateDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsPostDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsPurlinDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsRafterDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsStringerDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsStrutDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsStudDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsBoredDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsDrivenDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsJetgroutingDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsCurtainPanelDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsSheetDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsHalfTurnRampDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsQuarterTurnRampDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsSpiralRampDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsStraightRunRampDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsTwoQuarterTurnRampDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsTwoStraightRunRampDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsBarrelRoofDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsButterflyRoofDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsDomeRoofDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsFlatRoofDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsFreeformDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsGableRoofDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsGambrelRoofDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsHippedGableRoofDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsHipRoofDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsMansardRoofDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsPavilionRoofDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsRainbowRoofDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsShedRoofDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsCurvedRunStairDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsDoubleReturnStairDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsHalfTurnStairDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsHalfWindingStairDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsQuarterTurnStairDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsQuarterWindingStairDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsSpiralStairDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsStraightRunStairDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsThreeQuarterTurnStairDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsThreeQuarterWindingStairDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsTwoCurvedRunStairDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsTwoQuarterTurnStairDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsTwoQuarterWindingStairDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsTwoStraightRunStairDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsCurvedDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsSpiralDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsStraightDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsWinderDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsElementedWallDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsMovableDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsParapetDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsPartitioningDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsPlumbingWallDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsPolygonalDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsShearDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsSolidWallDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsStandardDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsLightdomeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsSkylightDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsWindowDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsOpeningDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsRecessDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsAnchorboltDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsBoltDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsDowelDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsNailDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsNailPlateDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsRivetDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsScrewDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsShearConnectorDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsStapleDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsStudShearConnectorDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsGlueDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsMortarDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsWeldDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsExternalDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsGfaDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsInternalDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsParkingDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsSpaceDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsAccessoryAssemblyDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsArchDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsBeamGridDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsBracedFrameDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsGirderDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsReinforcementUnitDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsRigidFrameDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsSlabFieldDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsTrussDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsCableLadderSegmentDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsCableTraySegmentDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsCableTrunkingSegmentDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsConduitSegmentDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsBusbarSegmentDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsCableSegmentDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsConductorSegmentDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsCoreSegmentDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsFlexibleSegmentDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsRigidSegmentDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsCulvertDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsGutterDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsSpoolDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsAudioVisualOutletDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsCommunicationsOutletDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsPowerOutletDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsDataOutletDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsTelephoneOutletDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsAnchoringDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsEdgeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsLigatureDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsMainDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsPunchingDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsRingDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetNoneDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCeilingDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCladdingDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetFlooringDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetInsulationDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetMembraneDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetRoofingDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetSleevingDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetWrappingDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetFootingBeamDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetPadFootingDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetPileCapDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetStripFootingDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCohesionDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetFrictionDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetSupportDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetBalustradeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetGuardrailDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetHandrailDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetBaseslabDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetFloorDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetLandingDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetRoofDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetBeamDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetHollowcoreDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetJoistDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetLintelDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetSpandrelDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetTbeamDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetComplexDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetElementDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetPartialDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetProvisionForSpaceDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetProvisionFOrVoidDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetColumnDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetPilasterDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetMoldingDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetSkirtingboardDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetDoorDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetGateDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetTrapDoorDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCaissonFoundationDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetBraceDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetChordDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCollarDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetMemberDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetMullionDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetPlateDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetPostDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetPurlinDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetRafterDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetStringerDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetStrutDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetStudDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetBoredDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetDrivenDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetJetgroutingDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCurtainFanelDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetSheetDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetHalfTurnRampDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetQuarterTurnRampDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetSpiralRampDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetStraightRunRampDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetTwoQuarterTurnRampDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetTwoStraightRunRampDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetBarrelRoofDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetButterflyRoofDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetDomeRoofDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetFlatRoofDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetFreeformDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetGableRoofDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetGambrelRoofDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetHippedGableRoofDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetHipRoofDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetMansardRoofDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetPavilionRoofDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetRainbowRoofDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetShedRoofDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCurvedRunStairDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetDoubleReturnStairDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetHalfTurnStairDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetHalfWindingStairDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetQuarterTurnStairDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetQuarterWindingStairDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetSpiralStairDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetStraightRunStairDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetThreeQuarterturnstairDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetThreeQuarterwindingstairDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetTwoCurvedRunStairDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetTwoQuarterTurnStairDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetTwoQuarterWindingStairDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetTwoStraightRunStairDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCurvedDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetSpiralDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetStraightDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetWinderDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetElementedWallDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetMovableDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetParapetDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetPartitioningDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetPlumbingWallDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetPolygonalDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetShearDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetSolidWallDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetStandardDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetLightdomeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetSkylightDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetWindowDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetOpeningDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetRecessDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetAnchorboltDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetBoltDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetDowelDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetNailDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetNailplateDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetRivetDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetScrewDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetShearconnectorDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetStapleDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetStudshearconnectorDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetGlueDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetMortarDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetWeldDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetExternalDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetGfaDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetInternalDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetParkingDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetSpaceDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetAccessoryAssemblyDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetArchDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetBeamGridDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetBracedFrameDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetGirderDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetReinforcementUnitDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetRigidFrameDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetSlabFieldDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetTrussDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCableLadderSegmentDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCableTraySegmentDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCableTrunkingSegmentDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetConduitSegmentDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetBusbarSegmentDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCableSegmentDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetConductorSegmentDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCoreSegmentDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetFlexibleSegmentDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetRigidSegmentDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCulvertDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetGutterDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetSpoolDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetAudioVisualOutletDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCommunicationsOutletDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetPowerOutletDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetDataOutletDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetTelephoneOutletDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetAnchoringDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetEdgeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetLigatureDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetMainDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetPunchingDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetRingDelegate(IntPtr thisPtr);
}
