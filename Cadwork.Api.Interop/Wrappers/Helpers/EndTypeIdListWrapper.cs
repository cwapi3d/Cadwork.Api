// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Helpers;

public class EndTypeIdListWrapper
{
  public readonly IntPtr NativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public EndTypeIdListWrapper(IntPtr nativePtr)
  {
    NativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<EndTypeIdListInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(DestroyDelegate), Marshal.GetDelegateForFunctionPointer<DestroyDelegate>(vTable!.destroyFunctionPtr) },
      { typeof(CountDelegate), Marshal.GetDelegateForFunctionPointer<CountDelegate>(vTable.countFunctionPtr) },
      { typeof(AtDelegate), Marshal.GetDelegateForFunctionPointer<AtDelegate>(vTable.atFunctionPtr) },
      { typeof(AppendDelegate), Marshal.GetDelegateForFunctionPointer<AppendDelegate>(vTable.appendFunctionPtr) },
      { typeof(AppendListDelegate), Marshal.GetDelegateForFunctionPointer<AppendListDelegate>(vTable.appendListFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public void Destroy() => GetDelegate<DestroyDelegate>().Invoke(NativePtr);
  public uint Count() => GetDelegate<CountDelegate>().Invoke(NativePtr);
  public ulong At(uint aIndex) => GetDelegate<AtDelegate>().Invoke(NativePtr, aIndex);
  public void Append(ulong aEndTypeId) => GetDelegate<AppendDelegate>().Invoke(NativePtr, aEndTypeId);
  public void AppendList(IntPtr aEndTypeIDs) => GetDelegate<AppendListDelegate>().Invoke(NativePtr, aEndTypeIDs);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class EndTypeIdListInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr destroyFunctionPtr;
    internal IntPtr countFunctionPtr;
    internal IntPtr atFunctionPtr;
    internal IntPtr appendFunctionPtr;
    internal IntPtr appendListFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DestroyDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate uint CountDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong AtDelegate(IntPtr thisPtr, uint aIndex);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void AppendDelegate(IntPtr thisPtr, ulong aEndTypeId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void AppendListDelegate(IntPtr thisPtr, IntPtr aEndTypeIDs);
}
