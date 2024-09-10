// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Interop.Wrappers.Factories;
using Cadwork.Api.Interop.Wrappers.Helpers;

namespace Cadwork.Api.Extensions;

internal static class RhinoOptionsExtensions
{
  internal static IntPtr ToNativeRhinoOptions(this RhinoOptions data, ControllerFactoryWrapper factory)
  {
    var wrapper = new RhinoOptionsWrapper(factory.CreateRhinoOptions());

    wrapper.SetMaterializeEndTypes(data.HasFlag(RhinoOptions.MaterializeEndTypes));
    wrapper.SetCutEndTypesCounterparts(data.HasFlag(RhinoOptions.CutEndTypesCounterparts));
    wrapper.SetCutDrillings(data.HasFlag(RhinoOptions.CutDrillingAxes));
    wrapper.SetCutMep(data.HasFlag(RhinoOptions.CutMepElements));
    wrapper.SetCutOpenings(data.HasFlag(RhinoOptions.CutOpenings));

    return wrapper.NativePtr;
  }
}
