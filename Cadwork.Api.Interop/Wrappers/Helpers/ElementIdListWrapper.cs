// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Helpers;

public class ElementIdListWrapper
{
  public readonly IntPtr NativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public ElementIdListWrapper(IntPtr nativePtr)
  {
    NativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<ElementIdListInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(DestroyDelegate), Marshal.GetDelegateForFunctionPointer<DestroyDelegate>(vTable!.destroyFunctionPtr) },
      { typeof(CountDelegate), Marshal.GetDelegateForFunctionPointer<CountDelegate>(vTable.countFunctionPtr) },
      { typeof(AtDelegate), Marshal.GetDelegateForFunctionPointer<AtDelegate>(vTable.atFunctionPtr) },
      { typeof(AppendDelegate), Marshal.GetDelegateForFunctionPointer<AppendDelegate>(vTable.appendFunctionPtr) },
      { typeof(AppendListDelegate), Marshal.GetDelegateForFunctionPointer<AppendListDelegate>(vTable.appendListFunctionPtr) },
      { typeof(EmptyDelegate), Marshal.GetDelegateForFunctionPointer<EmptyDelegate>(vTable.emptyFunctionPtr) },
      { typeof(FrontDelegate), Marshal.GetDelegateForFunctionPointer<FrontDelegate>(vTable.frontFunctionPtr) },
      { typeof(BackDelegate), Marshal.GetDelegateForFunctionPointer<BackDelegate>(vTable.backFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public void Destroy() => GetDelegate<DestroyDelegate>().Invoke(NativePtr);
  public uint Count() => GetDelegate<CountDelegate>().Invoke(NativePtr);
  public ulong At(uint aIndex) => GetDelegate<AtDelegate>().Invoke(NativePtr, aIndex);
  public void Append(ulong aElementId) => GetDelegate<AppendDelegate>().Invoke(NativePtr, aElementId);
  public void AppendList(IntPtr aElementIDs) => GetDelegate<AppendListDelegate>().Invoke(NativePtr, aElementIDs);
  public bool Empty() => GetDelegate<EmptyDelegate>().Invoke(NativePtr);
  public IntPtr Front() => GetDelegate<FrontDelegate>().Invoke(NativePtr);
  public IntPtr Back() => GetDelegate<BackDelegate>().Invoke(NativePtr);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class ElementIdListInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr destroyFunctionPtr;
    internal IntPtr countFunctionPtr;
    internal IntPtr atFunctionPtr;
    internal IntPtr appendFunctionPtr;
    internal IntPtr appendListFunctionPtr;
    internal IntPtr emptyFunctionPtr;
    internal IntPtr frontFunctionPtr;
    internal IntPtr backFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DestroyDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate uint CountDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong AtDelegate(IntPtr thisPtr, uint aIndex);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void AppendDelegate(IntPtr thisPtr, ulong aElementId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void AppendListDelegate(IntPtr thisPtr, IntPtr aElementIDs);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool EmptyDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr FrontDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr BackDelegate(IntPtr thisPtr);
}
