// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Implementations.Helpers;
using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Interop.Wrappers.Factories;
using Cadwork.Api.Interop.Wrappers.Helpers;

namespace Cadwork.Api.Extensions;

internal static class CameraDataExtensions
{
  internal static IntPtr ToNativeCameraData(this ICameraData data, ControllerFactoryWrapper factory)
  {
    var wrapper = new CameraDataWrapper(factory.CreateCameraData());

    wrapper.SetPosition(data.Position.ToNativeVector());
    wrapper.SetTarget(data.Target.ToNativeVector());
    wrapper.SetUpVector(data.Up.ToNativeVector());

    switch (data.Projection)
    {
      case ProjectionType.Perspective:
        wrapper.SetProjectionType(CameraDataWrapper.ProjectionType.Perspective);
        break;
      case ProjectionType.Orthographic:
        wrapper.SetProjectionType(CameraDataWrapper.ProjectionType.Orthographic);
        break;
      default:
        throw new ArgumentOutOfRangeException();
    }

    wrapper.SetFieldWidth(data.FieldWidth);
    wrapper.SetFieldHeight(data.FieldHeight);
    wrapper.SetFieldOfView(data.FieldOfView);

    return wrapper.NativePtr;
  }

  internal static ICameraData ToManagedCameraData(this IntPtr data)
  {
    var wrapper = new CameraDataWrapper(data);

    var cameraData = new CameraData();

    cameraData.Position = wrapper.GetPosition().ToManagedVector();
    cameraData.Target = wrapper.GetTarget().ToManagedVector();
    cameraData.Up = wrapper.GetUpVector().ToManagedVector();

    if (wrapper.GetProjectionType() == CameraDataWrapper.ProjectionType.Perspective)
    {
      cameraData.Projection = ProjectionType.Perspective;
    }

    if (wrapper.GetProjectionType() == CameraDataWrapper.ProjectionType.Orthographic)
    {
      cameraData.Projection = ProjectionType.Orthographic;
    }

    cameraData.FieldWidth = wrapper.GetFieldWidth();
    cameraData.FieldHeight = wrapper.GetFieldHeight();
    cameraData.FieldOfView = (float)wrapper.GetFieldOfView();

    return cameraData;
  }
}
