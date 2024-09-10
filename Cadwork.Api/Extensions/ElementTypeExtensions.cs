// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Interop.Wrappers.Factories;
using Cadwork.Api.Interop.Wrappers.Helpers;

namespace Cadwork.Api.Extensions;

internal static class ElementTypeExtensions
{
  internal static IntPtr ToNativeElementType(this ElementType data, ControllerFactoryWrapper factory)
  {
    var wrapper = new ElementTypeWrapper(factory.CreateElementType());

    switch (data)
    {
      case ElementType.None:
        wrapper.SetNone();
        break;
      case ElementType.NormalNode:
        wrapper.SetNormalNode();
        break;
      case ElementType.ConnectorNode:
        wrapper.SetConnectorNode();
        break;
      case ElementType.WireAxis:
        wrapper.SetWireAxis();
        break;
      case ElementType.EaveAxis:
        wrapper.SetEaveAxis();
        break;
      case ElementType.RectangularAxis:
        wrapper.SetRectangularAxis();
        break;
      case ElementType.CircularAxis:
        wrapper.SetCircularAxis();
        break;
      case ElementType.DrillingAxis:
        wrapper.SetDrillingAxis();
        break;
      case ElementType.ConnectorAxis:
        wrapper.SetConnectorAxis();
        break;
      case ElementType.Line:
        wrapper.SetLine();
        break;
      case ElementType.Surface:
        wrapper.SetSurface();
        break;
      case ElementType.Cadwork:
        wrapper.SetCadwork();
        break;
      case ElementType.GlobalCut:
        wrapper.SetGlobalCut();
        break;
      case ElementType.Wall:
        wrapper.SetFramedWall();
        break;
      case ElementType.Opening:
        wrapper.SetOpening();
        break;
      case ElementType.Floor:
        wrapper.SetFramedFloor();
        break;
      case ElementType.Roof:
        wrapper.SetFramedRoof();
        break;
      case ElementType.Container:
        wrapper.SetContainer();
        break;
      case ElementType.ExportSolid:
        wrapper.SetExportSolid();
        break;
      case ElementType.Auxiliary:
        wrapper.SetAuxiliary();
        break;
      case ElementType.NestingParent:
        wrapper.SetNestingParent();
        break;
      case ElementType.RectangularBeam:
        wrapper.SetRectangularBeam();
        break;
      case ElementType.CircularBeam:
        wrapper.SetCircularBeam();
        break;
      case ElementType.SteelShape:
        wrapper.SetSteelShape();
        break;
      case ElementType.Panel:
        wrapper.SetPanel();
        break;
      case ElementType.RotationElement:
        wrapper.SetRotationElement();
        break;
      case ElementType.AdditionalElement:
        wrapper.SetAdditionalElement();
        break;
      case ElementType.Room:
        wrapper.SetRoom();
        break;
      case ElementType.GraphicalObject:
        wrapper.SetGraphicalObject();
        break;
      case ElementType.Dimension:
        wrapper.SetDimension();
        break;
      case ElementType.TextDocument:
        wrapper.SetTextDocument();
        break;
      case ElementType.ExportSolidScene:
        wrapper.SetExportSolidScene();
        break;
      case ElementType.SectionTrace:
        wrapper.SetSectionTrace();
        break;
      case ElementType.RoundMep:
        wrapper.SetCircularMep();
        break;
      case ElementType.RectangularMep:
        wrapper.SetRectangularMep();
        break;
      case ElementType.ProfileMep:
        break;
      case ElementType.RoofSurface:
        break;
      case ElementType.ContainerBlock:
        break;
      case ElementType.RoofTileSurface:
        break;
      case ElementType.ExchangeObject:
        wrapper.SetGraphicalObject();
        break;
      case ElementType.FramedWall:
        wrapper.SetFramedWall();
        break;
      case ElementType.SolidWoodWall:
        wrapper.SetSolidWoodWall();
        break;
      case ElementType.LogWall:
        wrapper.SetLogWall();
        break;
      case ElementType.FramedRoof:
        wrapper.SetFramedRoof();
        break;
      case ElementType.SolidWoodRoof:
        wrapper.SetSolidWoodRoof();
        break;
      case ElementType.FramedFloor:
        wrapper.SetFramedFloor();
        break;
      case ElementType.SolidWoodFloor:
        wrapper.SetSolidWoodFloor();
        break;
      default:
        throw new ArgumentOutOfRangeException(nameof(data), data, null);
    }

    return wrapper.NativePtr;
  }

  internal static ElementType ToManagedElementType(this IntPtr data)
  {
    var wrapper = new ElementTypeWrapper(data);

    if (wrapper.IsNone())
    {
      return ElementType.None;
    }

    if (wrapper.IsNormalNode())
    {
      return ElementType.NormalNode;
    }

    if (wrapper.IsConnectorNode())
    {
      return ElementType.ConnectorNode;
    }

    if (wrapper.IsWireAxis())
    {
      return ElementType.WireAxis;
    }

    if (wrapper.IsEaveAxis())
    {
      return ElementType.EaveAxis;
    }

    if (wrapper.IsRectangularAxis())
    {
      return ElementType.RectangularAxis;
    }

    if (wrapper.IsCircularAxis())
    {
      return ElementType.CircularAxis;
    }

    if (wrapper.IsDrillingAxis())
    {
      return ElementType.DrillingAxis;
    }

    if (wrapper.IsConnectorAxis())
    {
      return ElementType.ConnectorAxis;
    }

    if (wrapper.IsLine())
    {
      return ElementType.Line;
    }

    if (wrapper.IsSurface())
    {
      return ElementType.Surface;
    }

    if (wrapper.IsCadwork())
    {
      return ElementType.Cadwork;
    }

    if (wrapper.IsGlobalCut())
    {
      return ElementType.GlobalCut;
    }

    if (wrapper.IsWall())
    {
      return ElementType.Wall;
    }

    if (wrapper.IsOpening())
    {
      return ElementType.Opening;
    }

    if (wrapper.IsFloor())
    {
      return ElementType.Floor;
    }

    if (wrapper.IsRoof())
    {
      return ElementType.Roof;
    }

    if (wrapper.IsContainer())
    {
      return ElementType.Container;
    }

    if (wrapper.IsExportSolid())
    {
      return ElementType.ExportSolid;
    }

    if (wrapper.IsAuxiliary())
    {
      return ElementType.Auxiliary;
    }

    if (wrapper.IsNestingParent())
    {
      return ElementType.NestingParent;
    }

    if (wrapper.IsRectangularBeam())
    {
      return ElementType.RectangularBeam;
    }

    if (wrapper.IsCircularBeam())
    {
      return ElementType.CircularBeam;
    }

    if (wrapper.IsSteelShape())
    {
      return ElementType.SteelShape;
    }

    if (wrapper.IsPanel())
    {
      return ElementType.Panel;
    }

    if (wrapper.IsRotationElement())
    {
      return ElementType.RotationElement;
    }

    if (wrapper.IsAdditionalElement())
    {
      return ElementType.AdditionalElement;
    }

    if (wrapper.IsRoom())
    {
      return ElementType.Room;
    }

    if (wrapper.IsGraphicalObject())
    {
      return ElementType.GraphicalObject;
    }

    if (wrapper.IsDimension())
    {
      return ElementType.Dimension;
    }

    if (wrapper.IsTextDocument())
    {
      return ElementType.TextDocument;
    }

    if (wrapper.IsExportSolidScene())
    {
      return ElementType.ExportSolidScene;
    }

    if (wrapper.IsSectionTrace())
    {
      return ElementType.SectionTrace;
    }

    if (wrapper.IsFramedWall())
    {
      return ElementType.FramedWall;
    }

    if (wrapper.IsSolidWoodWall())
    {
      return ElementType.SolidWoodWall;
    }

    if (wrapper.IsLogWall())
    {
      return ElementType.LogWall;
    }

    if (wrapper.IsFramedFloor())
    {
      return ElementType.FramedFloor;
    }

    if (wrapper.IsSolidWoodFloor())
    {
      return ElementType.SolidWoodFloor;
    }

    if (wrapper.IsFramedRoof())
    {
      return ElementType.FramedRoof;
    }

    if (wrapper.IsSolidWoodRoof())
    {
      return ElementType.SolidWoodRoof;
    }

    if (wrapper.IsCircularMep())
    {
      return ElementType.RoundMep;
    }

    if (wrapper.IsRectangularMep())
    {
      return ElementType.RectangularMep;
    }

    return ElementType.None;
  }
}
