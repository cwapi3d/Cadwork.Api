// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Structs;

namespace Cadwork.Api.Interfaces.Controllers;

using ElementId = ulong;

/// <summary>
/// 
/// </summary>
public interface IDimensionController
{
  /// <summary>
  /// 
  /// </summary>
  /// <param name="xl"></param>
  /// <param name="planeNormal"></param>
  /// <param name="distance"></param>
  /// <param name="dimensionPoints"></param>
  /// <returns></returns>
  ElementId CreateDimension(Vec3 xl, Vec3 planeNormal, Vec3 distance, ICollection<Vec3> dimensionPoints);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  ICollection<Vec3> GetDimensionPoints(ElementId elementId);

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
  Vec3 GetDistance(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  Vec3 GetPlaneNormal(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  Vec3 GetPlaneXl(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="segmentIndex"></param>
  /// <returns></returns>
  Vec3 GetSegmentDirection(ElementId elementId, int segmentIndex);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  double GetDefaultAnchorLength(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="segmentIndex"></param>
  /// <returns></returns>
  double GetSegmentDistance(ElementId elementId, int segmentIndex);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  int GetSegmentCount(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="segment"></param>
  void AddSegment(ElementId elementId, Vec3 segment);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="length"></param>
  void SetDefaultAnchorLength(ICollection<ElementId> elementIds, double length);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="distance"></param>
  void SetDistance(ICollection<ElementId> elementIds, Vec3 distance);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="colorId"></param>
  void SetLineColor(ICollection<ElementId> elementIds, uint colorId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="thickness"></param>
  void SetLineThickness(ICollection<ElementId> elementIds, double thickness);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="viewDirection"></param>
  /// <param name="viewDirectionUp"></param>
  void SetOrientation(ICollection<ElementId> elementIds, Vec3 viewDirection, Vec3 viewDirectionUp);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="precision"></param>
  void SetPrecision(ICollection<ElementId> elementIds, uint precision);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="colorId"></param>
  void SetTextColor(ICollection<ElementId> elementIds, uint colorId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="textSize"></param>
  void SetTextSize(ICollection<ElementId> elementIds, double textSize);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="flag"></param>
  void SetTotalDimension(ICollection<ElementId> elementIds, bool flag);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="flag"></param>
  void ShiftDistanceAndTexts(ICollection<ElementId> elementIds, bool flag);
};
