// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Interop.Wrappers.Factories;
using Cadwork.Api.Interop.Wrappers.Helpers;

namespace Cadwork.Api.Extensions;

internal static class DisplayAttributeExtensions
{
  internal static IntPtr ToNativeDisplayAttribute(this DisplayAttribute data, ControllerFactoryWrapper factory)
  {
    var wrapper = new DisplayAttributeWrapper(factory.CreateEmptyDisplayAttribute());

    switch (data)
    {
      case DisplayAttribute.None:
        wrapper.SetNone();
        break;
      case DisplayAttribute.Name:
        wrapper.SetName();
        break;
      case DisplayAttribute.Group:
        wrapper.SetGroup();
        break;
      case DisplayAttribute.Subgroup:
        wrapper.SetSubgroup();
        break;
      case DisplayAttribute.Comment:
        wrapper.SetComment();
        break;
      case DisplayAttribute.Sku:
        wrapper.SetEdvCode();
        break;
      case DisplayAttribute.Material:
        wrapper.SetMaterial();
        break;
      case DisplayAttribute.MaterialGroup:
        wrapper.SetMaterialGroup();
        break;
      case DisplayAttribute.User1:
        wrapper.SetUser1();
        break;
      case DisplayAttribute.User2:
        wrapper.SetUser2();
        break;
      case DisplayAttribute.User3:
        wrapper.SetUser3();
        break;
      case DisplayAttribute.User4:
        wrapper.SetUser4();
        break;
      case DisplayAttribute.User5:
        wrapper.SetUser5();
        break;
      case DisplayAttribute.User6:
        wrapper.SetUser6();
        break;
      case DisplayAttribute.User7:
        wrapper.SetUser7();
        break;
      case DisplayAttribute.User8:
        wrapper.SetUser8();
        break;
      case DisplayAttribute.User9:
        wrapper.SetUser9();
        break;
      case DisplayAttribute.User10:
        wrapper.SetUser10();
        break;
      case DisplayAttribute.ProductionNumber:
        wrapper.SetProductionNumber();
        break;
      case DisplayAttribute.ItemNumber:
        wrapper.SetTimberNumber();
        break;
      case DisplayAttribute.AssemblyNumber:
        wrapper.SetAssemblyNumber();
        break;
      case DisplayAttribute.IfcBuilding:
        wrapper.SetIfcBuilding();
        break;
      case DisplayAttribute.IfcStorey:
        wrapper.SetIfcStorey();
        break;
      default:
        throw new ArgumentOutOfRangeException(nameof(data), data, null);
    }

    return wrapper.NativePtr;
  }
}
