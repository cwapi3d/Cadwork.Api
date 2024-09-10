// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;
using Cadwork.Api.Interop.Wrappers.Structs;

namespace Cadwork.Api.Interop.Wrappers.Helpers;

public class CoordinateSystemDataWrapper
{
  public readonly IntPtr NativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public CoordinateSystemDataWrapper(IntPtr nativePtr)
  {
    NativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<CoordinateSystemDataInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(GetP1Delegate), Marshal.GetDelegateForFunctionPointer<GetP1Delegate>(vTable!.getP1FunctionPtr) },
      { typeof(GetP2Delegate), Marshal.GetDelegateForFunctionPointer<GetP2Delegate>(vTable.getP2FunctionPtr) },
      { typeof(GetP3Delegate), Marshal.GetDelegateForFunctionPointer<GetP3Delegate>(vTable.getP3FunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public CVector3 GetP1() => GetDelegate<GetP1Delegate>().Invoke(NativePtr);
  public CVector3 GetP2() => GetDelegate<GetP2Delegate>().Invoke(NativePtr);
  public CVector3 GetP3() => GetDelegate<GetP3Delegate>().Invoke(NativePtr);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class CoordinateSystemDataInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr getP1FunctionPtr;
    internal IntPtr getP2FunctionPtr;
    internal IntPtr getP3FunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate CVector3 GetP1Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate CVector3 GetP2Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate CVector3 GetP3Delegate(IntPtr thisPtr);
}
