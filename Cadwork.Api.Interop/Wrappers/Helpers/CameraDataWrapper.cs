// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;
using Cadwork.Api.Interop.Wrappers.Structs;

namespace Cadwork.Api.Interop.Wrappers.Helpers;

public class CameraDataWrapper
{
  public readonly IntPtr NativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public CameraDataWrapper(IntPtr nativePtr)
  {
    NativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<CameraDataInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(DestroyDelegate), Marshal.GetDelegateForFunctionPointer<DestroyDelegate>(vTable!.destroyFunctionPtr) },
      { typeof(SetPositionDelegate), Marshal.GetDelegateForFunctionPointer<SetPositionDelegate>(vTable.setPositionFunctionPtr) },
      { typeof(GetPositionDelegate), Marshal.GetDelegateForFunctionPointer<GetPositionDelegate>(vTable.getPositionFunctionPtr) },
      { typeof(SetTargetDelegate), Marshal.GetDelegateForFunctionPointer<SetTargetDelegate>(vTable.setTargetFunctionPtr) },
      { typeof(GetTargetDelegate), Marshal.GetDelegateForFunctionPointer<GetTargetDelegate>(vTable.getTargetFunctionPtr) },
      { typeof(SetUpVectorDelegate), Marshal.GetDelegateForFunctionPointer<SetUpVectorDelegate>(vTable.setUpVectorFunctionPtr) },
      { typeof(GetUpVectorDelegate), Marshal.GetDelegateForFunctionPointer<GetUpVectorDelegate>(vTable.getUpVectorFunctionPtr) },
      { typeof(SetProjectionTypeDelegate), Marshal.GetDelegateForFunctionPointer<SetProjectionTypeDelegate>(vTable.setProjectionTypeFunctionPtr) },
      { typeof(GetProjectionTypeDelegate), Marshal.GetDelegateForFunctionPointer<GetProjectionTypeDelegate>(vTable.getProjectionTypeFunctionPtr) },
      { typeof(SetFieldWidthDelegate), Marshal.GetDelegateForFunctionPointer<SetFieldWidthDelegate>(vTable.setFieldWidthFunctionPtr) },
      { typeof(GetFieldWidthDelegate), Marshal.GetDelegateForFunctionPointer<GetFieldWidthDelegate>(vTable.getFieldWidthFunctionPtr) },
      { typeof(SetFieldHeightDelegate), Marshal.GetDelegateForFunctionPointer<SetFieldHeightDelegate>(vTable.setFieldHeightFunctionPtr) },
      { typeof(GetFieldHeightDelegate), Marshal.GetDelegateForFunctionPointer<GetFieldHeightDelegate>(vTable.getFieldHeightFunctionPtr) },
      { typeof(SetFieldOfViewDelegate), Marshal.GetDelegateForFunctionPointer<SetFieldOfViewDelegate>(vTable.setFieldOfViewFunctionPtr) },
      { typeof(GetFieldOfViewDelegate), Marshal.GetDelegateForFunctionPointer<GetFieldOfViewDelegate>(vTable.getFieldOfViewFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public enum ProjectionType
  {
    Perspective = 0,
    Orthographic = 1
  };

  public void Destroy() => GetDelegate<DestroyDelegate>().Invoke(NativePtr);
  public void SetPosition(CVector3 aPosition) => GetDelegate<SetPositionDelegate>().Invoke(NativePtr, aPosition);
  public CVector3 GetPosition() => GetDelegate<GetPositionDelegate>().Invoke(NativePtr);
  public void SetTarget(CVector3 aTarget) => GetDelegate<SetTargetDelegate>().Invoke(NativePtr, aTarget);
  public CVector3 GetTarget() => GetDelegate<GetTargetDelegate>().Invoke(NativePtr);
  public void SetUpVector(CVector3 aUp) => GetDelegate<SetUpVectorDelegate>().Invoke(NativePtr, aUp);
  public CVector3 GetUpVector() => GetDelegate<GetUpVectorDelegate>().Invoke(NativePtr);
  public void SetProjectionType(ProjectionType aProjectionType) => GetDelegate<SetProjectionTypeDelegate>().Invoke(NativePtr, aProjectionType);
  public ProjectionType GetProjectionType() => GetDelegate<GetProjectionTypeDelegate>().Invoke(NativePtr);
  public void SetFieldWidth(float aFieldWidth) => GetDelegate<SetFieldWidthDelegate>().Invoke(NativePtr, aFieldWidth);
  public float GetFieldWidth() => GetDelegate<GetFieldWidthDelegate>().Invoke(NativePtr);
  public void SetFieldHeight(float aFieldHeight) => GetDelegate<SetFieldHeightDelegate>().Invoke(NativePtr, aFieldHeight);
  public float GetFieldHeight() => GetDelegate<GetFieldHeightDelegate>().Invoke(NativePtr);
  public void SetFieldOfView(double aFieldOfView) => GetDelegate<SetFieldOfViewDelegate>().Invoke(NativePtr, aFieldOfView);
  public double GetFieldOfView() => GetDelegate<GetFieldOfViewDelegate>().Invoke(NativePtr);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class CameraDataInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr destroyFunctionPtr;
    internal IntPtr setPositionFunctionPtr;
    internal IntPtr getPositionFunctionPtr;
    internal IntPtr setTargetFunctionPtr;
    internal IntPtr getTargetFunctionPtr;
    internal IntPtr setUpVectorFunctionPtr;
    internal IntPtr getUpVectorFunctionPtr;
    internal IntPtr setProjectionTypeFunctionPtr;
    internal IntPtr getProjectionTypeFunctionPtr;
    internal IntPtr setFieldWidthFunctionPtr;
    internal IntPtr getFieldWidthFunctionPtr;
    internal IntPtr setFieldHeightFunctionPtr;
    internal IntPtr getFieldHeightFunctionPtr;
    internal IntPtr setFieldOfViewFunctionPtr;
    internal IntPtr getFieldOfViewFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DestroyDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetPositionDelegate(IntPtr thisPtr, CVector3 aPosition);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate CVector3 GetPositionDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetTargetDelegate(IntPtr thisPtr, CVector3 aTarget);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate CVector3 GetTargetDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetUpVectorDelegate(IntPtr thisPtr, CVector3 aUp);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate CVector3 GetUpVectorDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetProjectionTypeDelegate(IntPtr thisPtr, ProjectionType aProjectionType);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ProjectionType GetProjectionTypeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetFieldWidthDelegate(IntPtr thisPtr, float aFieldWidth);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate float GetFieldWidthDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetFieldHeightDelegate(IntPtr thisPtr, float aFieldHeight);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate float GetFieldHeightDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetFieldOfViewDelegate(IntPtr thisPtr, double aFieldOfView);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetFieldOfViewDelegate(IntPtr thisPtr);
}
