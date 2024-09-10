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

internal class DimensionController(ControllerFactoryWrapper factoryWrapper) : IDimensionController
{
  private readonly DimensionControllerWrapper _controllerWrapper = new(factoryWrapper.GetDimensionController());

  public ElementId CreateDimension(Vec3 xl, Vec3 planeNormal, Vec3 distance, ICollection<Vec3> dimensionPoints)
  {
    return _controllerWrapper.CreateDimension(xl.ToNativeVector(), planeNormal.ToNativeVector(), distance.ToNativeVector(), dimensionPoints.ToNativeVectorList(factoryWrapper));
  }

  public ICollection<Vec3> GetDimensionPoints(ElementId elementId)
  {
    return _controllerWrapper.GetDimensionPoints(elementId).ToManagedVectorList();
  }

  public IError GetLastError()
  {
    const int errorCode = 0;
    var errorMessage = _controllerWrapper.GetLastError(errorCode);
    return new Error { Code = errorCode, Message = errorMessage.ToManagedString() };
  }

  public Vec3 GetDistance(ElementId elementId)
  {
    return _controllerWrapper.GetDistance(elementId).ToManagedVector();
  }

  public Vec3 GetPlaneNormal(ElementId elementId)
  {
    return _controllerWrapper.GetPlaneNormal(elementId).ToManagedVector();
  }

  public Vec3 GetPlaneXl(ElementId elementId)
  {
    return _controllerWrapper.GetPlaneXl(elementId).ToManagedVector();
  }

  public Vec3 GetSegmentDirection(ElementId elementId, int segmentIndex)
  {
    return _controllerWrapper.GetSegmentDirection(elementId, segmentIndex).ToManagedVector();
  }

  public double GetDefaultAnchorLength(ElementId elementId)
  {
    return _controllerWrapper.GetDefaultAnchorLength(elementId);
  }

  public double GetSegmentDistance(ElementId elementId, int segmentIndex)
  {
    return _controllerWrapper.GetSegmentDistance(elementId, segmentIndex);
  }

  public int GetSegmentCount(ElementId elementId)
  {
    return _controllerWrapper.GetSegmentCount(elementId);
  }

  public void AddSegment(ElementId elementId, Vec3 segment)
  {
    _controllerWrapper.AddSegment(elementId, segment.ToNativeVector());
  }

  public void SetDefaultAnchorLength(ICollection<ulong> elementIds, double length)
  {
    _controllerWrapper.SetDefaultAnchorLength(elementIds.ToNativeElementIdList(factoryWrapper), length);
  }

  public void SetDistance(ICollection<ulong> elementIds, Vec3 distance)
  {
    _controllerWrapper.SetDistance(elementIds.ToNativeElementIdList(factoryWrapper), distance.ToNativeVector());
  }

  public void SetLineColor(ICollection<ulong> elementIds, uint colorId)
  {
    _controllerWrapper.SetLineColor(elementIds.ToNativeElementIdList(factoryWrapper), colorId);
  }

  public void SetLineThickness(ICollection<ulong> elementIds, double thickness)
  {
    _controllerWrapper.SetLineThickness(elementIds.ToNativeElementIdList(factoryWrapper), thickness);
  }

  public void SetOrientation(ICollection<ulong> elementIds, Vec3 viewDirection, Vec3 viewDirectionUp)
  {
    _controllerWrapper.SetOrientation(elementIds.ToNativeElementIdList(factoryWrapper), viewDirection.ToNativeVector(), viewDirectionUp.ToNativeVector());
  }

  public void SetPrecision(ICollection<ulong> elementIds, uint precision)
  {
    _controllerWrapper.SetPrecision(elementIds.ToNativeElementIdList(factoryWrapper), precision);
  }

  public void SetTextColor(ICollection<ulong> elementIds, uint colorId)
  {
    _controllerWrapper.SetTextColor(elementIds.ToNativeElementIdList(factoryWrapper), colorId);
  }

  public void SetTextSize(ICollection<ulong> elementIds, double textSize)
  {
    _controllerWrapper.SetTextSize(elementIds.ToNativeElementIdList(factoryWrapper), textSize);
  }

  public void SetTotalDimension(ICollection<ulong> elementIds, bool flag)
  {
    _controllerWrapper.SetTotalDimension(elementIds.ToNativeElementIdList(factoryWrapper), flag);
  }

  public void ShiftDistanceAndTexts(ICollection<ulong> elementIds, bool flag)
  {
    _controllerWrapper.ShiftDistanceAndTexts(elementIds.ToNativeElementIdList(factoryWrapper), flag);
  }
};
