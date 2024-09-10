// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Extensions;
using Cadwork.Api.Implementations.Helpers;
using Cadwork.Api.Interfaces.Controllers;
using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Interop.Wrappers.Controllers;
using Cadwork.Api.Interop.Wrappers.Factories;
using Cadwork.Api.Structs;

namespace Cadwork.Api.Implementations.Controllers;

using ElementId = ulong;
using MaterialId = ulong;

internal class VisualizationController(ControllerFactoryWrapper factoryWrapper) : IVisualizationController
{
  private readonly VisualizationControllerWrapper _controllerWrapper = new(factoryWrapper.GetVisualizationController());

  public ColorRgb GetOpenGlColor(ElementId elementId)
  {
    return _controllerWrapper.GetOpenGlColor(elementId).ToManagedColor();
  }

  public ColorRgb GetRgbFromCadworkColorId(uint colorId)
  {
    return _controllerWrapper.GetRgbFromCadworkColorId((ushort)colorId).ToManagedColor();
  }

  public ICameraData GetCameraData()
  {
    return _controllerWrapper.GetCameraData().ToManagedCameraData();
  }

  public IError GetLastError()
  {
    const int errorCode = 0;
    var errorMessage = _controllerWrapper.GetLastError(errorCode);
    return new Error { Code = errorCode, Message = errorMessage.ToManagedString() };
  }

  public MaterialId GetMaterial(ElementId elementId)
  {
    return _controllerWrapper.GetMaterial(elementId);
  }

  public bool IsActive(ElementId elementId)
  {
    return _controllerWrapper.IsActive(elementId);
  }

  public bool IsCadworkWindowInDarkMode()
  {
    return _controllerWrapper.IsCadworkWindowInDarkMode();
  }

  public bool IsCadworkWindowInLightMode()
  {
    return _controllerWrapper.IsCadworkWindowInLightMode();
  }

  public bool IsImmutable(ElementId elementId)
  {
    return _controllerWrapper.IsImmutable(elementId);
  }

  public bool IsPlane2d()
  {
    return _controllerWrapper.IsPlane2d();
  }

  public bool IsSelectable(ElementId elementId)
  {
    return _controllerWrapper.IsSelectable(elementId);
  }

  public bool IsTextureRotated(ElementId elementId)
  {
    return _controllerWrapper.IsTextureRotated(elementId);
  }

  public bool IsVisible(ElementId elementId)
  {
    return _controllerWrapper.IsVisible(elementId);
  }

  public uint GetColor(ElementId elementId)
  {
    return _controllerWrapper.GetColor(elementId);
  }

  public void ClearErrors()
  {
    _controllerWrapper.ClearErrors();
  }

  public void EnterPlane(Vec3 planeNormal, Vec3 planeOrigin)
  {
    _controllerWrapper.EnterWorkingPlane(planeNormal.ToNativeVector(), planeOrigin.ToNativeVector());
  }

  public void HideAllElements()
  {
    _controllerWrapper.HideAllElements();
  }

  public void LoadMarkingSettings(string fileName)
  {
    _controllerWrapper.LoadMarkingSettings(fileName);
  }

  public void Refresh()
  {
    _controllerWrapper.Refresh();
  }

  public void SetActive(ICollection<ulong> elementIds)
  {
    _controllerWrapper.SetActive(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void SetCamera(Vec3 position, Vec3 target)
  {
    _controllerWrapper.SetCamera(position.ToNativeVector(), target.ToNativeVector());
  }

  public void SetCameraData(ICameraData cameraData)
  {
    _controllerWrapper.SetCameraData((cameraData as CameraData)!.ToNativeCameraData(factoryWrapper));
  }

  public void SetColor(ICollection<ulong> elementIds, uint colorId)
  {
    _controllerWrapper.SetColor(elementIds.ToNativeElementIdList(factoryWrapper), colorId);
  }

  public void SetColorWithoutMaterial(ICollection<ulong> elementIds, uint colorId)
  {
    _controllerWrapper.SetColorWithoutMaterial(elementIds.ToNativeElementIdList(factoryWrapper), colorId);
  }

  public void SetImmutable(ICollection<ulong> elementIds)
  {
    _controllerWrapper.SetImmutable(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void SetInactive(ICollection<ulong> elementIds)
  {
    _controllerWrapper.SetInactive(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void SetInvisible(ICollection<ulong> elementIds)
  {
    _controllerWrapper.SetInvisible(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void SetMaterial(ICollection<ulong> elementIds, MaterialId materialId)
  {
    _controllerWrapper.SetMaterial(elementIds.ToNativeElementIdList(factoryWrapper), materialId);
  }

  public void SetMutable(ICollection<ulong> elementIds)
  {
    _controllerWrapper.SetMutable(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void SetOpenGlColor(ICollection<ulong> elementIds, ColorRgb colorRgb)
  {
    _controllerWrapper.SetOpenGlColor(elementIds.ToNativeElementIdList(factoryWrapper), colorRgb.ToNativeColor());
  }

  public void SetSelectable(ICollection<ulong> elementIds)
  {
    _controllerWrapper.SetSelectable(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void SetTextureRotated(ICollection<ulong> elementIds, bool flag)
  {
    _controllerWrapper.SetTextureRotated(elementIds.ToNativeElementIdList(factoryWrapper), flag);
  }

  public void SetUnselectable(ICollection<ulong> elementIds)
  {
    _controllerWrapper.SetUnselectable(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void SetVisible(ICollection<ulong> elementIds)
  {
    _controllerWrapper.SetVisible(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void ShowAllElements()
  {
    _controllerWrapper.ShowAllElements();
  }

  public void ShowPerspectiveCentral()
  {
    _controllerWrapper.ShowPerspectiveCentral();
  }

  public void ShowReferenceSideBeam(bool flag)
  {
    _controllerWrapper.ShowReferenceSideBeam(flag);
  }

  public void ShowReferenceSidePanel(bool flag)
  {
    _controllerWrapper.ShowReferenceSidePanel(flag);
  }

  public void ShowReferenceSideWall(bool flag)
  {
    _controllerWrapper.ShowReferenceSideWall(flag);
  }

  public void ShowViewAxo()
  {
    _controllerWrapper.ShowViewAxo();
  }

  public void ShowViewDashedHiddenLines()
  {
    _controllerWrapper.ShowViewDashedHiddenLines();
  }

  public void ShowViewHiddenLines()
  {
    _controllerWrapper.ShowViewHiddenLines();
  }

  public void ShowViewNegativeX()
  {
    _controllerWrapper.ShowViewNegativeX();
  }

  public void ShowViewNegativeY()
  {
    _controllerWrapper.ShowViewNegativeY();
  }

  public void ShowViewNegativeZ()
  {
    _controllerWrapper.ShowViewNegativeZ();
  }

  public void ShowViewPositiveX()
  {
    _controllerWrapper.ShowViewPositiveX();
  }

  public void ShowViewPositiveY()
  {
    _controllerWrapper.ShowViewPositiveY();
  }

  public void ShowViewPositiveZ()
  {
    _controllerWrapper.ShowViewPositiveZ();
  }

  public void ShowViewShaded1()
  {
    _controllerWrapper.ShowViewShaded1();
  }

  public void ShowViewShaded2()
  {
    _controllerWrapper.ShowViewShaded2();
  }

  public void ShowViewStandardAxo()
  {
    _controllerWrapper.ShowViewStandardAxo();
  }

  public void ShowViewWireframe()
  {
    _controllerWrapper.ShowViewWireframe();
  }

  public void ZoomActiveElements()
  {
    _controllerWrapper.ZoomActiveElements();
  }

  public void ZoomAllElements()
  {
    _controllerWrapper.ZoomAllElements();
  }
};
