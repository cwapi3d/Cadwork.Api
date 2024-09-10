// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Structs;

namespace Cadwork.Api.Interfaces.Controllers;

using ElementId = ulong;
using MaterialId = ulong;

/// <summary>
/// 
/// </summary>
public interface IVisualizationController
{
  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  ColorRgb GetOpenGlColor(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="colorId"></param>
  /// <returns></returns>
  ColorRgb GetRgbFromCadworkColorId(uint colorId);

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  ICameraData GetCameraData();

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
  MaterialId GetMaterial(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsActive(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  bool IsCadworkWindowInDarkMode();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  bool IsCadworkWindowInLightMode();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsImmutable(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  bool IsPlane2d();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsSelectable(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsTextureRotated(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  bool IsVisible(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  uint GetColor(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  void ClearErrors();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="planeNormal"></param>
  /// <param name="planeOrigin"></param>
  void EnterPlane(Vec3 planeNormal, Vec3 planeOrigin);

  /// <summary>
  /// 
  /// </summary>
  void HideAllElements();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="fileName"></param>
  void LoadMarkingSettings(string fileName);

  /// <summary>
  /// 
  /// </summary>
  void Refresh();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void SetActive(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="position"></param>
  /// <param name="target"></param>
  void SetCamera(Vec3 position, Vec3 target);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="cameraData"></param>
  void SetCameraData(ICameraData cameraData);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="colorId"></param>
  void SetColor(ICollection<ElementId> elementIds, uint colorId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="colorId"></param>
  void SetColorWithoutMaterial(ICollection<ElementId> elementIds, uint colorId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void SetImmutable(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void SetInactive(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void SetInvisible(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="materialId"></param>
  void SetMaterial(ICollection<ElementId> elementIds, MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void SetMutable(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="colorRgb"></param>
  void SetOpenGlColor(ICollection<ElementId> elementIds, ColorRgb colorRgb);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void SetSelectable(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="flag"></param>
  void SetTextureRotated(ICollection<ElementId> elementIds, bool flag);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void SetUnselectable(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  void SetVisible(ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  void ShowAllElements();

  /// <summary>
  /// 
  /// </summary>
  void ShowPerspectiveCentral();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="flag"></param>
  void ShowReferenceSideBeam(bool flag);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="flag"></param>
  void ShowReferenceSidePanel(bool flag);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="flag"></param>
  void ShowReferenceSideWall(bool flag);

  /// <summary>
  /// 
  /// </summary>
  void ShowViewAxo();

  /// <summary>
  /// 
  /// </summary>
  void ShowViewDashedHiddenLines();

  /// <summary>
  /// 
  /// </summary>
  void ShowViewHiddenLines();

  /// <summary>
  /// 
  /// </summary>
  void ShowViewNegativeX();

  /// <summary>
  /// 
  /// </summary>
  void ShowViewNegativeY();

  /// <summary>
  /// 
  /// </summary>
  void ShowViewNegativeZ();

  /// <summary>
  /// 
  /// </summary>
  void ShowViewPositiveX();

  /// <summary>
  /// 
  /// </summary>
  void ShowViewPositiveY();

  /// <summary>
  /// 
  /// </summary>
  void ShowViewPositiveZ();

  /// <summary>
  /// 
  /// </summary>
  void ShowViewShaded1();

  /// <summary>
  /// 
  /// </summary>
  void ShowViewShaded2();

  /// <summary>
  /// 
  /// </summary>
  void ShowViewStandardAxo();

  /// <summary>
  /// 
  /// </summary>
  void ShowViewWireframe();

  /// <summary>
  /// 
  /// </summary>
  void ZoomActiveElements();

  /// <summary>
  /// 
  /// </summary>
  void ZoomAllElements();
};
