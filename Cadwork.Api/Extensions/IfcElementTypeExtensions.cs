// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Interop.Wrappers.Factories;
using Cadwork.Api.Interop.Wrappers.Helpers;

namespace Cadwork.Api.Extensions;

internal static class IfcElementTypeExtensions
{
  internal static IntPtr ToNativeIfcElementType(this IfcElementType data, ControllerFactoryWrapper factory)
  {
    var wrapper = new IfcElementTypeWrapper(factory.CreateEmptyIfcElementType());

    switch (data)
    {
      case IfcElementType.None:
        wrapper.SetNone();
        break;
      case IfcElementType.IfcBeam:
        wrapper.SetIfcBeam();
        break;
      case IfcElementType.IfcColumn:
        wrapper.SetIfcColumn();
        break;
      case IfcElementType.IfcCurtainWall:
        wrapper.SetIfcCurtainWall();
        break;
      case IfcElementType.IfcDoor:
        wrapper.SetIfcDoor();
        break;
      case IfcElementType.IfcMember:
        wrapper.SetIfcMember();
        break;
      case IfcElementType.IfcPlate:
        wrapper.SetIfcPlate();
        break;
      case IfcElementType.IfcRailing:
        wrapper.SetIfcRailing();
        break;
      case IfcElementType.IfcRamp:
        wrapper.SetIfcRamp();
        break;
      case IfcElementType.IfcRampFlight:
        wrapper.SetIfcRampFlight();
        break;
      case IfcElementType.IfcRoof:
        wrapper.SetIfcRoof();
        break;
      case IfcElementType.IfcSlab:
        wrapper.SetIfcSlab();
        break;
      case IfcElementType.IfcStair:
        wrapper.SetIfcStair();
        break;
      case IfcElementType.IfcStairFlight:
        wrapper.SetIfcStairFlight();
        break;
      case IfcElementType.IfcWall:
        wrapper.SetIfcWall();
        break;
      case IfcElementType.IfcWallStandardCase:
        wrapper.SetIfcWallStandardCase();
        break;
      case IfcElementType.IfcWindow:
        wrapper.SetIfcWindow();
        break;
      case IfcElementType.IfcBuildingElementProxy:
        wrapper.SetIfcBuildingElementProxy();
        break;
      case IfcElementType.IfcChimney:
        wrapper.SetIfcChimney();
        break;
      case IfcElementType.IfcCovering:
        wrapper.SetIfcCovering();
        break;
      case IfcElementType.IfcFooting:
        wrapper.SetIfcFooting();
        break;
      case IfcElementType.IfcFurnishingElement:
        wrapper.SetIfcFurnishingElement();
        break;
      case IfcElementType.IfcOpeningElement:
        wrapper.SetIfcOpeningElement();
        break;
      case IfcElementType.IfcSpace:
        wrapper.SetIfcSpace();
        break;
      case IfcElementType.IfcFlowSegment:
        wrapper.SetIfcFlowSegment();
        break;
      case IfcElementType.IfcBuildingElementPart:
        wrapper.SetIfcBuildingElementPart();
        break;
      case IfcElementType.IfcDiscreteAccessory:
        wrapper.SetIfcDiscreteAccessory();
        break;
      case IfcElementType.IfcFastener:
        wrapper.SetIfcFastener();
        break;
      case IfcElementType.IfcMechanicalFastener:
        wrapper.SetIfcMechanicalFastener();
        break;
      case IfcElementType.IfcElementAssembly:
        wrapper.SetIfcElementAssembly();
        break;
      default:
        throw new ArgumentOutOfRangeException(nameof(data), data, null);
    }

    return wrapper.NativePtr;
  }

  internal static IfcElementType ToManagedIfcElementType(this IntPtr data)
  {
    var wrapper = new IfcElementTypeWrapper(data);

    if (wrapper.IsNone())
    {
      return IfcElementType.None;
    }

    if (wrapper.IsIfcBeam())
    {
      return IfcElementType.IfcBeam;
    }

    if (wrapper.IsIfcColumn())
    {
      return IfcElementType.IfcColumn;
    }

    if (wrapper.IsIfcCurtainWall())
    {
      return IfcElementType.IfcCurtainWall;
    }

    if (wrapper.IsIfcDoor())
    {
      return IfcElementType.IfcDoor;
    }

    if (wrapper.IsIfcMember())
    {
      return IfcElementType.IfcMember;
    }

    if (wrapper.IsIfcPlate())
    {
      return IfcElementType.IfcPlate;
    }

    if (wrapper.IsIfcRailing())
    {
      return IfcElementType.IfcRailing;
    }

    if (wrapper.IsIfcRamp())
    {
      return IfcElementType.IfcRamp;
    }

    if (wrapper.IsIfcRampFlight())
    {
      return IfcElementType.IfcRampFlight;
    }

    if (wrapper.IsIfcRoof())
    {
      return IfcElementType.IfcRoof;
    }

    if (wrapper.IsIfcSlab())
    {
      return IfcElementType.IfcSlab;
    }

    if (wrapper.IsIfcStair())
    {
      return IfcElementType.IfcStair;
    }

    if (wrapper.IsIfcStairFlight())
    {
      return IfcElementType.IfcStairFlight;
    }

    if (wrapper.IsIfcWall())
    {
      return IfcElementType.IfcWall;
    }

    if (wrapper.IsIfcWallStandardCase())
    {
      return IfcElementType.IfcWallStandardCase;
    }

    if (wrapper.IsIfcWindow())
    {
      return IfcElementType.IfcWindow;
    }

    if (wrapper.IsIfcBuildingElementProxy())
    {
      return IfcElementType.IfcBuildingElementProxy;
    }

    if (wrapper.IsIfcChimney())
    {
      return IfcElementType.IfcChimney;
    }

    if (wrapper.IsIfcCovering())
    {
      return IfcElementType.IfcCovering;
    }

    if (wrapper.IsIfcFooting())
    {
      return IfcElementType.IfcFooting;
    }

    if (wrapper.IsIfcFurnishingElement())
    {
      return IfcElementType.IfcFurnishingElement;
    }

    if (wrapper.IsIfcOpeningElement())
    {
      return IfcElementType.IfcOpeningElement;
    }

    if (wrapper.IsIfcSpace())
    {
      return IfcElementType.IfcSpace;
    }

    if (wrapper.IsIfcFlowSegment())
    {
      return IfcElementType.IfcFlowSegment;
    }

    if (wrapper.IsIfcBuildingElementPart())
    {
      return IfcElementType.IfcBuildingElementPart;
    }

    if (wrapper.IsIfcDiscreteAccessory())
    {
      return IfcElementType.IfcDiscreteAccessory;
    }

    if (wrapper.IsIfcFastener())
    {
      return IfcElementType.IfcFastener;
    }

    if (wrapper.IsIfcMechanicalFastener())
    {
      return IfcElementType.IfcMechanicalFastener;
    }

    if (wrapper.IsIfcElementAssembly())
    {
      return IfcElementType.IfcElementAssembly;
    }

    return IfcElementType.None;
  }
}
