// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Controllers;

public class RoofControllerWrapper
{
  private readonly IntPtr _nativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public RoofControllerWrapper(IntPtr nativePtr)
  {
    _nativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<RoofControllerInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(GetProfileLengthDelegate), Marshal.GetDelegateForFunctionPointer<GetProfileLengthDelegate>(vTable!.getProfileLengthFunctionPtr) },
      { typeof(GetEdgeLengthDelegate), Marshal.GetDelegateForFunctionPointer<GetEdgeLengthDelegate>(vTable.getEdgeLengthFunctionPtr) },
      { typeof(GetAllCaddyElementIDsDelegate), Marshal.GetDelegateForFunctionPointer<GetAllCaddyElementIDsDelegate>(vTable.getAllCaddyElementIDsFunctionPtr) },
      { typeof(GetLastErrorDelegate), Marshal.GetDelegateForFunctionPointer<GetLastErrorDelegate>(vTable.getLastErrorFunctionPtr) },
      { typeof(ClearErrorsDelegate), Marshal.GetDelegateForFunctionPointer<ClearErrorsDelegate>(vTable.clearErrorsFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public double GetProfileLength(ulong aId) => GetDelegate<GetProfileLengthDelegate>().Invoke(_nativePtr, aId);
  public double GetEdgeLength(ulong aId, string aEdgeType) => GetDelegate<GetEdgeLengthDelegate>().Invoke(_nativePtr, aId, aEdgeType);
  public IntPtr GetAllCaddyElementIDs() => GetDelegate<GetAllCaddyElementIDsDelegate>().Invoke(_nativePtr);
  public IntPtr GetLastError(IntPtr aErrorCode) => GetDelegate<GetLastErrorDelegate>().Invoke(_nativePtr, aErrorCode);
  public void ClearErrors() => GetDelegate<ClearErrorsDelegate>().Invoke(_nativePtr);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class RoofControllerInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr getProfileLengthFunctionPtr;
    internal IntPtr getEdgeLengthFunctionPtr;
    internal IntPtr getAllCaddyElementIDsFunctionPtr;
    internal IntPtr getLastErrorFunctionPtr;
    internal IntPtr clearErrorsFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetProfileLengthDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetEdgeLengthDelegate(IntPtr thisPtr, ulong aId, [MarshalAs(UnmanagedType.LPWStr)] string aEdgeType);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAllCaddyElementIDsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetLastErrorDelegate(IntPtr thisPtr, IntPtr aErrorCode);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ClearErrorsDelegate(IntPtr thisPtr);
}
