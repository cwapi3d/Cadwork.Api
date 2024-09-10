// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Interop.Wrappers.Factories;
using Cadwork.Api.Interop.Wrappers.Helpers;

namespace Cadwork.Api.Extensions;

internal static class ProcessTypeExtensions
{
  internal static IntPtr ToNativeProcessType(this ProcessType data, ControllerFactoryWrapper factory)
  {
    var wrapper = new ProcessTypeWrapper(factory.CreateEmptyProcessType());

    switch (data)
    {
      case ProcessType.None:
        wrapper.SetNone();
        break;
      case ProcessType.Purlin:
        wrapper.SetPurlin();
        break;
      case ProcessType.Stud:
        wrapper.SetStud();
        break;
      case ProcessType.Rafter:
        wrapper.SetRafter();
        break;
      case ProcessType.JackRafter:
        wrapper.SetJackRafter();
        break;
      case ProcessType.HipValley:
        wrapper.SetHipValley();
        break;
      case ProcessType.Log:
        wrapper.SetLog();
        break;
      case ProcessType.Truss:
        wrapper.SetTruss();
        break;
      case ProcessType.Tread:
        wrapper.SetTread();
        break;
      case ProcessType.User1:
        wrapper.SetUser1();
        break;
      case ProcessType.User2:
        wrapper.SetUser2();
        break;
      case ProcessType.User3:
        wrapper.SetUser3();
        break;
      case ProcessType.User4:
        wrapper.SetUser4();
        break;
      case ProcessType.User5:
        wrapper.SetUser5();
        break;
      case ProcessType.Panel1:
        wrapper.SetPanel1();
        break;
      case ProcessType.Panel2:
        wrapper.SetPanel2();
        break;
      case ProcessType.Panel3:
        wrapper.SetPanel3();
        break;
      case ProcessType.Panel4:
        wrapper.SetPanel4();
        break;
      case ProcessType.Panel5:
        wrapper.SetPanel5();
        break;
      case ProcessType.RoughVolumeFramedWall:
        wrapper.SetRoughVolumeFramedWall();
        break;
      case ProcessType.RoughVolumeSolidWoodWall:
        wrapper.SetRoughVolumeSolidWoodWall();
        break;
      case ProcessType.RoughVolumeLogHome:
        wrapper.SetRoughVolumeLogHome();
        break;
      default:
        throw new ArgumentOutOfRangeException(nameof(data), data, null);
    }

    return wrapper.NativePtr;
  }

  internal static ProcessType ToManagedProcessType(this IntPtr data)
  {
    var wrapper = new ProcessTypeWrapper(data);

    if (wrapper.IsNone())
    {
      return ProcessType.None;
    }

    if (wrapper.IsPurlin())
    {
      return ProcessType.Purlin;
    }

    if (wrapper.IsStud())
    {
      return ProcessType.Stud;
    }

    if (wrapper.IsRafter())
    {
      return ProcessType.Rafter;
    }

    if (wrapper.IsJackRafter())
    {
      return ProcessType.JackRafter;
    }

    if (wrapper.IsHipValley())
    {
      return ProcessType.HipValley;
    }

    if (wrapper.IsLog())
    {
      return ProcessType.Log;
    }

    if (wrapper.IsTruss())
    {
      return ProcessType.Truss;
    }

    if (wrapper.IsTread())
    {
      return ProcessType.Tread;
    }

    if (wrapper.IsUser1())
    {
      return ProcessType.User1;
    }

    if (wrapper.IsUser2())
    {
      return ProcessType.User2;
    }

    if (wrapper.IsUser3())
    {
      return ProcessType.User3;
    }

    if (wrapper.IsUser4())
    {
      return ProcessType.User4;
    }

    if (wrapper.IsUser5())
    {
      return ProcessType.User5;
    }

    if (wrapper.IsPanel1())
    {
      return ProcessType.Panel1;
    }

    if (wrapper.IsPanel2())
    {
      return ProcessType.Panel2;
    }

    if (wrapper.IsPanel3())
    {
      return ProcessType.Panel3;
    }

    if (wrapper.IsPanel4())
    {
      return ProcessType.Panel4;
    }

    if (wrapper.IsPanel5())
    {
      return ProcessType.Panel5;
    }

    if (wrapper.IsRoughVolumeFramedWall())
    {
      return ProcessType.RoughVolumeFramedWall;
    }

    if (wrapper.IsRoughVolumeSolidWoodWall())
    {
      return ProcessType.RoughVolumeSolidWoodWall;
    }

    if (wrapper.IsRoughVolumeLogHome())
    {
      return ProcessType.RoughVolumeLogHome;
    }

    return ProcessType.None;
  }
}
