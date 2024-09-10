// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;
using Cadwork.Api.Interop.Wrappers.Structs;

namespace Cadwork.Api.Interop.Wrappers.Controllers;

public class VisualizationControllerWrapper
{
  private readonly IntPtr _nativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public VisualizationControllerWrapper(IntPtr nativePtr)
  {
    _nativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<VisualizationControllerInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(GetLastErrorDelegate), Marshal.GetDelegateForFunctionPointer<GetLastErrorDelegate>(vTable!.getLastErrorFunctionPtr) },
      { typeof(GetColorDelegate), Marshal.GetDelegateForFunctionPointer<GetColorDelegate>(vTable.getColorFunctionPtr) },
      { typeof(SetColorDelegate), Marshal.GetDelegateForFunctionPointer<SetColorDelegate>(vTable.setColorFunctionPtr) },
      { typeof(GetOpenGlColorDelegate), Marshal.GetDelegateForFunctionPointer<GetOpenGlColorDelegate>(vTable.getOpenGLColorFunctionPtr) },
      { typeof(SetOpenGlColorDelegate), Marshal.GetDelegateForFunctionPointer<SetOpenGlColorDelegate>(vTable.setOpenGLColorFunctionPtr) },
      { typeof(IsActiveDelegate), Marshal.GetDelegateForFunctionPointer<IsActiveDelegate>(vTable.isActiveFunctionPtr) },
      { typeof(SetActiveDelegate), Marshal.GetDelegateForFunctionPointer<SetActiveDelegate>(vTable.setActiveFunctionPtr) },
      { typeof(SetInactiveDelegate), Marshal.GetDelegateForFunctionPointer<SetInactiveDelegate>(vTable.setInactiveFunctionPtr) },
      { typeof(IsVisibleDelegate), Marshal.GetDelegateForFunctionPointer<IsVisibleDelegate>(vTable.isVisibleFunctionPtr) },
      { typeof(SetVisibleDelegate), Marshal.GetDelegateForFunctionPointer<SetVisibleDelegate>(vTable.setVisibleFunctionPtr) },
      { typeof(SetInvisibleDelegate), Marshal.GetDelegateForFunctionPointer<SetInvisibleDelegate>(vTable.setInvisibleFunctionPtr) },
      { typeof(IsImmutableDelegate), Marshal.GetDelegateForFunctionPointer<IsImmutableDelegate>(vTable.isImmutableFunctionPtr) },
      { typeof(SetImmutableDelegate), Marshal.GetDelegateForFunctionPointer<SetImmutableDelegate>(vTable.setImmutableFunctionPtr) },
      { typeof(SetMutableDelegate), Marshal.GetDelegateForFunctionPointer<SetMutableDelegate>(vTable.setMutableFunctionPtr) },
      { typeof(ShowAllElementsDelegate), Marshal.GetDelegateForFunctionPointer<ShowAllElementsDelegate>(vTable.showAllElementsFunctionPtr) },
      { typeof(HideAllElementsDelegate), Marshal.GetDelegateForFunctionPointer<HideAllElementsDelegate>(vTable.hideAllElementsFunctionPtr) },
      { typeof(ZoomAllElementsDelegate), Marshal.GetDelegateForFunctionPointer<ZoomAllElementsDelegate>(vTable.zoomAllElementsFunctionPtr) },
      { typeof(ZoomActiveElementsDelegate), Marshal.GetDelegateForFunctionPointer<ZoomActiveElementsDelegate>(vTable.zoomActiveElementsFunctionPtr) },
      { typeof(RefreshDelegate), Marshal.GetDelegateForFunctionPointer<RefreshDelegate>(vTable.refreshFunctionPtr) },
      { typeof(SetMaterialDelegate), Marshal.GetDelegateForFunctionPointer<SetMaterialDelegate>(vTable.setMaterialFunctionPtr) },
      { typeof(GetMaterialDelegate), Marshal.GetDelegateForFunctionPointer<GetMaterialDelegate>(vTable.getMaterialFunctionPtr) },
      { typeof(SaveVisibilityStateDelegate), Marshal.GetDelegateForFunctionPointer<SaveVisibilityStateDelegate>(vTable.saveVisibilityStateFunctionPtr) },
      { typeof(RestoreVisibilityStateDelegate), Marshal.GetDelegateForFunctionPointer<RestoreVisibilityStateDelegate>(vTable.restoreVisibilityStateFunctionPtr) },
      { typeof(SaveActivationStateDelegate), Marshal.GetDelegateForFunctionPointer<SaveActivationStateDelegate>(vTable.saveActivationStateFunctionPtr) },
      { typeof(RestoreActivationStateDelegate), Marshal.GetDelegateForFunctionPointer<RestoreActivationStateDelegate>(vTable.restoreActivationStateFunctionPtr) },
      { typeof(ShowViewPositiveXDelegate), Marshal.GetDelegateForFunctionPointer<ShowViewPositiveXDelegate>(vTable.showViewPositiveXFunctionPtr) },
      { typeof(ShowViewNegativeXDelegate), Marshal.GetDelegateForFunctionPointer<ShowViewNegativeXDelegate>(vTable.showViewNegativeXFunctionPtr) },
      { typeof(ShowViewPositiveYDelegate), Marshal.GetDelegateForFunctionPointer<ShowViewPositiveYDelegate>(vTable.showViewPositiveYFunctionPtr) },
      { typeof(ShowViewNegativeYDelegate), Marshal.GetDelegateForFunctionPointer<ShowViewNegativeYDelegate>(vTable.showViewNegativeYFunctionPtr) },
      { typeof(ShowViewPositiveZDelegate), Marshal.GetDelegateForFunctionPointer<ShowViewPositiveZDelegate>(vTable.showViewPositiveZFunctionPtr) },
      { typeof(ShowViewNegativeZDelegate), Marshal.GetDelegateForFunctionPointer<ShowViewNegativeZDelegate>(vTable.showViewNegativeZFunctionPtr) },
      { typeof(ShowViewStandardAxoDelegate), Marshal.GetDelegateForFunctionPointer<ShowViewStandardAxoDelegate>(vTable.showViewStandardAxoFunctionPtr) },
      { typeof(ShowViewWireframeDelegate), Marshal.GetDelegateForFunctionPointer<ShowViewWireframeDelegate>(vTable.showViewWireframeFunctionPtr) },
      { typeof(ShowViewHiddenLinesDelegate), Marshal.GetDelegateForFunctionPointer<ShowViewHiddenLinesDelegate>(vTable.showViewHiddenLinesFunctionPtr) },
      { typeof(ShowViewDashedHiddenLinesDelegate), Marshal.GetDelegateForFunctionPointer<ShowViewDashedHiddenLinesDelegate>(vTable.showViewDashedHiddenLinesFunctionPtr) },
      { typeof(ShowViewShaded2Delegate), Marshal.GetDelegateForFunctionPointer<ShowViewShaded2Delegate>(vTable.showViewShaded2FunctionPtr) },
      { typeof(ShowViewShaded1Delegate), Marshal.GetDelegateForFunctionPointer<ShowViewShaded1Delegate>(vTable.showViewShaded1FunctionPtr) },
      { typeof(IsSelectableDelegate), Marshal.GetDelegateForFunctionPointer<IsSelectableDelegate>(vTable.isSelectableFunctionPtr) },
      { typeof(SetUnselectableDelegate), Marshal.GetDelegateForFunctionPointer<SetUnselectableDelegate>(vTable.setUnselectableFunctionPtr) },
      { typeof(SetSelectableDelegate), Marshal.GetDelegateForFunctionPointer<SetSelectableDelegate>(vTable.setSelectableFunctionPtr) },
      { typeof(ClearErrorsDelegate), Marshal.GetDelegateForFunctionPointer<ClearErrorsDelegate>(vTable.clearErrorsFunctionPtr) },
      { typeof(LoadMarkingSettingsDelegate), Marshal.GetDelegateForFunctionPointer<LoadMarkingSettingsDelegate>(vTable.loadMarkingSettingsFunctionPtr) },
      { typeof(IsPlane2dDelegate), Marshal.GetDelegateForFunctionPointer<IsPlane2dDelegate>(vTable.isPlane2dFunctionPtr) },
      { typeof(SetCameraDelegate), Marshal.GetDelegateForFunctionPointer<SetCameraDelegate>(vTable.setCameraFunctionPtr) },
      { typeof(ShowViewAxoDelegate), Marshal.GetDelegateForFunctionPointer<ShowViewAxoDelegate>(vTable.showViewAxoFunctionPtr) },
      { typeof(ShowPerspectiveCentralDelegate), Marshal.GetDelegateForFunctionPointer<ShowPerspectiveCentralDelegate>(vTable.showPerspectiveCentralFunctionPtr) },
      { typeof(ShowReferenceSideBeamDelegate), Marshal.GetDelegateForFunctionPointer<ShowReferenceSideBeamDelegate>(vTable.showReferenceSideBeamFunctionPtr) },
      { typeof(ShowReferenceSidePanelDelegate), Marshal.GetDelegateForFunctionPointer<ShowReferenceSidePanelDelegate>(vTable.showReferenceSidePanelFunctionPtr) },
      { typeof(ShowReferenceSideWallDelegate), Marshal.GetDelegateForFunctionPointer<ShowReferenceSideWallDelegate>(vTable.showReferenceSideWallFunctionPtr) },
      { typeof(GetRgbFromCadworkColorIdDelegate), Marshal.GetDelegateForFunctionPointer<GetRgbFromCadworkColorIdDelegate>(vTable.getRGBFromCadworkColorIDFunctionPtr) },
      { typeof(SetColorWithoutMaterialDelegate), Marshal.GetDelegateForFunctionPointer<SetColorWithoutMaterialDelegate>(vTable.setColorWithoutMaterialFunctionPtr) },
      { typeof(IsTextureRotatedDelegate), Marshal.GetDelegateForFunctionPointer<IsTextureRotatedDelegate>(vTable.isTextureRotatedFunctionPtr) },
      { typeof(SetTextureRotatedDelegate), Marshal.GetDelegateForFunctionPointer<SetTextureRotatedDelegate>(vTable.setTextureRotatedFunctionPtr) },
      { typeof(GetCameraDataDelegate), Marshal.GetDelegateForFunctionPointer<GetCameraDataDelegate>(vTable.getCameraDataFunctionPtr) },
      { typeof(SetCameraDataDelegate), Marshal.GetDelegateForFunctionPointer<SetCameraDataDelegate>(vTable.setCameraDataFunctionPtr) },
      { typeof(IsCadworkWindowInLightModeDelegate), Marshal.GetDelegateForFunctionPointer<IsCadworkWindowInLightModeDelegate>(vTable.isCadworkWindowInLightModeFunctionPtr) },
      { typeof(IsCadworkWindowInDarkModeDelegate), Marshal.GetDelegateForFunctionPointer<IsCadworkWindowInDarkModeDelegate>(vTable.isCadworkWindowInDarkModeFunctionPtr) },
      { typeof(EnterWorkingPlaneDelegate), Marshal.GetDelegateForFunctionPointer<EnterWorkingPlaneDelegate>(vTable.enterWorkingPlaneFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public IntPtr GetLastError(IntPtr aErrorCode) => GetDelegate<GetLastErrorDelegate>().Invoke(_nativePtr, aErrorCode);
  public uint GetColor(ulong aId) => GetDelegate<GetColorDelegate>().Invoke(_nativePtr, aId);
  public void SetColor(IntPtr aElementIdList, uint aColorId) => GetDelegate<SetColorDelegate>().Invoke(_nativePtr, aElementIdList, aColorId);
  public CColorRgb GetOpenGlColor(ulong aId) => GetDelegate<GetOpenGlColorDelegate>().Invoke(_nativePtr, aId);
  public void SetOpenGlColor(IntPtr aElementIdList, CColorRgb aColor) => GetDelegate<SetOpenGlColorDelegate>().Invoke(_nativePtr, aElementIdList, aColor);
  public bool IsActive(ulong aId) => GetDelegate<IsActiveDelegate>().Invoke(_nativePtr, aId);
  public void SetActive(IntPtr aElementIdList) => GetDelegate<SetActiveDelegate>().Invoke(_nativePtr, aElementIdList);
  public void SetInactive(IntPtr aElementIdList) => GetDelegate<SetInactiveDelegate>().Invoke(_nativePtr, aElementIdList);
  public bool IsVisible(ulong aId) => GetDelegate<IsVisibleDelegate>().Invoke(_nativePtr, aId);
  public void SetVisible(IntPtr aElementIdList) => GetDelegate<SetVisibleDelegate>().Invoke(_nativePtr, aElementIdList);
  public void SetInvisible(IntPtr aElementIdList) => GetDelegate<SetInvisibleDelegate>().Invoke(_nativePtr, aElementIdList);
  public bool IsImmutable(ulong aId) => GetDelegate<IsImmutableDelegate>().Invoke(_nativePtr, aId);
  public void SetImmutable(IntPtr aElementIdList) => GetDelegate<SetImmutableDelegate>().Invoke(_nativePtr, aElementIdList);
  public void SetMutable(IntPtr aElementIdList) => GetDelegate<SetMutableDelegate>().Invoke(_nativePtr, aElementIdList);
  public void ShowAllElements() => GetDelegate<ShowAllElementsDelegate>().Invoke(_nativePtr);
  public void HideAllElements() => GetDelegate<HideAllElementsDelegate>().Invoke(_nativePtr);
  public void ZoomAllElements() => GetDelegate<ZoomAllElementsDelegate>().Invoke(_nativePtr);
  public void ZoomActiveElements() => GetDelegate<ZoomActiveElementsDelegate>().Invoke(_nativePtr);
  public void Refresh() => GetDelegate<RefreshDelegate>().Invoke(_nativePtr);
  public void SetMaterial(IntPtr aElementIdList, ulong aId) => GetDelegate<SetMaterialDelegate>().Invoke(_nativePtr, aElementIdList, aId);
  public ulong GetMaterial(ulong aElementId) => GetDelegate<GetMaterialDelegate>().Invoke(_nativePtr, aElementId);
  public IntPtr SaveVisibilityState() => GetDelegate<SaveVisibilityStateDelegate>().Invoke(_nativePtr);
  public void RestoreVisibilityState(IntPtr aState) => GetDelegate<RestoreVisibilityStateDelegate>().Invoke(_nativePtr, aState);
  public IntPtr SaveActivationState() => GetDelegate<SaveActivationStateDelegate>().Invoke(_nativePtr);
  public void RestoreActivationState(IntPtr aState) => GetDelegate<RestoreActivationStateDelegate>().Invoke(_nativePtr, aState);
  public void ShowViewPositiveX() => GetDelegate<ShowViewPositiveXDelegate>().Invoke(_nativePtr);
  public void ShowViewNegativeX() => GetDelegate<ShowViewNegativeXDelegate>().Invoke(_nativePtr);
  public void ShowViewPositiveY() => GetDelegate<ShowViewPositiveYDelegate>().Invoke(_nativePtr);
  public void ShowViewNegativeY() => GetDelegate<ShowViewNegativeYDelegate>().Invoke(_nativePtr);
  public void ShowViewPositiveZ() => GetDelegate<ShowViewPositiveZDelegate>().Invoke(_nativePtr);
  public void ShowViewNegativeZ() => GetDelegate<ShowViewNegativeZDelegate>().Invoke(_nativePtr);
  public void ShowViewStandardAxo() => GetDelegate<ShowViewStandardAxoDelegate>().Invoke(_nativePtr);
  public void ShowViewWireframe() => GetDelegate<ShowViewWireframeDelegate>().Invoke(_nativePtr);
  public void ShowViewHiddenLines() => GetDelegate<ShowViewHiddenLinesDelegate>().Invoke(_nativePtr);
  public void ShowViewDashedHiddenLines() => GetDelegate<ShowViewDashedHiddenLinesDelegate>().Invoke(_nativePtr);
  public void ShowViewShaded2() => GetDelegate<ShowViewShaded2Delegate>().Invoke(_nativePtr);
  public void ShowViewShaded1() => GetDelegate<ShowViewShaded1Delegate>().Invoke(_nativePtr);
  public bool IsSelectable(ulong aId) => GetDelegate<IsSelectableDelegate>().Invoke(_nativePtr, aId);
  public void SetUnselectable(IntPtr aElementIdList) => GetDelegate<SetUnselectableDelegate>().Invoke(_nativePtr, aElementIdList);
  public void SetSelectable(IntPtr aElementIdList) => GetDelegate<SetSelectableDelegate>().Invoke(_nativePtr, aElementIdList);
  public void ClearErrors() => GetDelegate<ClearErrorsDelegate>().Invoke(_nativePtr);
  public void LoadMarkingSettings(string aSettingsFilePath) => GetDelegate<LoadMarkingSettingsDelegate>().Invoke(_nativePtr, aSettingsFilePath);
  public bool IsPlane2d() => GetDelegate<IsPlane2dDelegate>().Invoke(_nativePtr);
  public void SetCamera(CVector3 aPosition, CVector3 aTarget) => GetDelegate<SetCameraDelegate>().Invoke(_nativePtr, aPosition, aTarget);
  public void ShowViewAxo() => GetDelegate<ShowViewAxoDelegate>().Invoke(_nativePtr);
  public void ShowPerspectiveCentral() => GetDelegate<ShowPerspectiveCentralDelegate>().Invoke(_nativePtr);
  public void ShowReferenceSideBeam(bool aShow) => GetDelegate<ShowReferenceSideBeamDelegate>().Invoke(_nativePtr, aShow);
  public void ShowReferenceSidePanel(bool aShow) => GetDelegate<ShowReferenceSidePanelDelegate>().Invoke(_nativePtr, aShow);
  public void ShowReferenceSideWall(bool aShow) => GetDelegate<ShowReferenceSideWallDelegate>().Invoke(_nativePtr, aShow);
  public CColorRgb GetRgbFromCadworkColorId(ushort aColorId) => GetDelegate<GetRgbFromCadworkColorIdDelegate>().Invoke(_nativePtr, aColorId);
  public void SetColorWithoutMaterial(IntPtr aElementIdList, uint aColorId) => GetDelegate<SetColorWithoutMaterialDelegate>().Invoke(_nativePtr, aElementIdList, aColorId);
  public bool IsTextureRotated(ulong aId) => GetDelegate<IsTextureRotatedDelegate>().Invoke(_nativePtr, aId);
  public void SetTextureRotated(IntPtr aElementIdList, bool aFlag) => GetDelegate<SetTextureRotatedDelegate>().Invoke(_nativePtr, aElementIdList, aFlag);
  public IntPtr GetCameraData() => GetDelegate<GetCameraDataDelegate>().Invoke(_nativePtr);
  public void SetCameraData(IntPtr aCameraData) => GetDelegate<SetCameraDataDelegate>().Invoke(_nativePtr, aCameraData);
  public bool IsCadworkWindowInLightMode() => GetDelegate<IsCadworkWindowInLightModeDelegate>().Invoke(_nativePtr);
  public bool IsCadworkWindowInDarkMode() => GetDelegate<IsCadworkWindowInDarkModeDelegate>().Invoke(_nativePtr);
  public void EnterWorkingPlane(CVector3 aPlaneNormal, CVector3 aPlaneOrigin) => GetDelegate<EnterWorkingPlaneDelegate>().Invoke(_nativePtr, aPlaneNormal, aPlaneOrigin);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class VisualizationControllerInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr getLastErrorFunctionPtr;
    internal IntPtr getColorFunctionPtr;
    internal IntPtr setColorFunctionPtr;
    internal IntPtr getOpenGLColorFunctionPtr;
    internal IntPtr setOpenGLColorFunctionPtr;
    internal IntPtr isActiveFunctionPtr;
    internal IntPtr setActiveFunctionPtr;
    internal IntPtr setInactiveFunctionPtr;
    internal IntPtr isVisibleFunctionPtr;
    internal IntPtr setVisibleFunctionPtr;
    internal IntPtr setInvisibleFunctionPtr;
    internal IntPtr isImmutableFunctionPtr;
    internal IntPtr setImmutableFunctionPtr;
    internal IntPtr setMutableFunctionPtr;
    internal IntPtr showAllElementsFunctionPtr;
    internal IntPtr hideAllElementsFunctionPtr;
    internal IntPtr zoomAllElementsFunctionPtr;
    internal IntPtr zoomActiveElementsFunctionPtr;
    internal IntPtr refreshFunctionPtr;
    internal IntPtr setMaterialFunctionPtr;
    internal IntPtr getMaterialFunctionPtr;
    internal IntPtr saveVisibilityStateFunctionPtr;
    internal IntPtr restoreVisibilityStateFunctionPtr;
    internal IntPtr saveActivationStateFunctionPtr;
    internal IntPtr restoreActivationStateFunctionPtr;
    internal IntPtr showViewPositiveXFunctionPtr;
    internal IntPtr showViewNegativeXFunctionPtr;
    internal IntPtr showViewPositiveYFunctionPtr;
    internal IntPtr showViewNegativeYFunctionPtr;
    internal IntPtr showViewPositiveZFunctionPtr;
    internal IntPtr showViewNegativeZFunctionPtr;
    internal IntPtr showViewStandardAxoFunctionPtr;
    internal IntPtr showViewWireframeFunctionPtr;
    internal IntPtr showViewHiddenLinesFunctionPtr;
    internal IntPtr showViewDashedHiddenLinesFunctionPtr;
    internal IntPtr showViewShaded2FunctionPtr;
    internal IntPtr showViewShaded1FunctionPtr;
    internal IntPtr isSelectableFunctionPtr;
    internal IntPtr setUnselectableFunctionPtr;
    internal IntPtr setSelectableFunctionPtr;
    internal IntPtr clearErrorsFunctionPtr;
    internal IntPtr loadMarkingSettingsFunctionPtr;
    internal IntPtr isPlane2dFunctionPtr;
    internal IntPtr setCameraFunctionPtr;
    internal IntPtr showViewAxoFunctionPtr;
    internal IntPtr showPerspectiveCentralFunctionPtr;
    internal IntPtr showReferenceSideBeamFunctionPtr;
    internal IntPtr showReferenceSidePanelFunctionPtr;
    internal IntPtr showReferenceSideWallFunctionPtr;
    internal IntPtr getRGBFromCadworkColorIDFunctionPtr;
    internal IntPtr setColorWithoutMaterialFunctionPtr;
    internal IntPtr isTextureRotatedFunctionPtr;
    internal IntPtr setTextureRotatedFunctionPtr;
    internal IntPtr getCameraDataFunctionPtr;
    internal IntPtr setCameraDataFunctionPtr;
    internal IntPtr isCadworkWindowInLightModeFunctionPtr;
    internal IntPtr isCadworkWindowInDarkModeFunctionPtr;
    internal IntPtr enterWorkingPlaneFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetLastErrorDelegate(IntPtr thisPtr, IntPtr aErrorCode);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate uint GetColorDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetColorDelegate(IntPtr thisPtr, IntPtr aElementIdList, uint aColorId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate CColorRgb GetOpenGlColorDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetOpenGlColorDelegate(IntPtr thisPtr, IntPtr aElementIdList, CColorRgb aColor);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsActiveDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetActiveDelegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetInactiveDelegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsVisibleDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetVisibleDelegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetInvisibleDelegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsImmutableDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetImmutableDelegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetMutableDelegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ShowAllElementsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void HideAllElementsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ZoomAllElementsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ZoomActiveElementsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void RefreshDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetMaterialDelegate(IntPtr thisPtr, IntPtr aElementIdList, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong GetMaterialDelegate(IntPtr thisPtr, ulong aElementId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr SaveVisibilityStateDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void RestoreVisibilityStateDelegate(IntPtr thisPtr, IntPtr aState);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr SaveActivationStateDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void RestoreActivationStateDelegate(IntPtr thisPtr, IntPtr aState);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ShowViewPositiveXDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ShowViewNegativeXDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ShowViewPositiveYDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ShowViewNegativeYDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ShowViewPositiveZDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ShowViewNegativeZDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ShowViewStandardAxoDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ShowViewWireframeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ShowViewHiddenLinesDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ShowViewDashedHiddenLinesDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ShowViewShaded2Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ShowViewShaded1Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsSelectableDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetUnselectableDelegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetSelectableDelegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ClearErrorsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void LoadMarkingSettingsDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aSettingsFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsPlane2dDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCameraDelegate(IntPtr thisPtr, CVector3 aPosition, CVector3 aTarget);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ShowViewAxoDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ShowPerspectiveCentralDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ShowReferenceSideBeamDelegate(IntPtr thisPtr, bool aShow);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ShowReferenceSidePanelDelegate(IntPtr thisPtr, bool aShow);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ShowReferenceSideWallDelegate(IntPtr thisPtr, bool aShow);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate CColorRgb GetRgbFromCadworkColorIdDelegate(IntPtr thisPtr, ushort aColorId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetColorWithoutMaterialDelegate(IntPtr thisPtr, IntPtr aElementIdList, uint aColorId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsTextureRotatedDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetTextureRotatedDelegate(IntPtr thisPtr, IntPtr aElementIdList, bool aFlag);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetCameraDataDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCameraDataDelegate(IntPtr thisPtr, IntPtr aCameraData);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsCadworkWindowInLightModeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsCadworkWindowInDarkModeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void EnterWorkingPlaneDelegate(IntPtr thisPtr, CVector3 aPlaneNormal, CVector3 aPlaneOrigin);
}
