// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Helpers;

public class ElementIdListMapWrapper
{
  public readonly IntPtr NativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public ElementIdListMapWrapper(IntPtr nativePtr)
  {
    NativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<ElementIdListMapInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(DestroyDelegate), Marshal.GetDelegateForFunctionPointer<DestroyDelegate>(vTable!.destroyFunctionPtr) },
      { typeof(CountDelegate), Marshal.GetDelegateForFunctionPointer<CountDelegate>(vTable.countFunctionPtr) },
      { typeof(ValueAtDelegate), Marshal.GetDelegateForFunctionPointer<ValueAtDelegate>(vTable.valueAtFunctionPtr) },
      { typeof(ItemAtDelegate), Marshal.GetDelegateForFunctionPointer<ItemAtDelegate>(vTable.itemAtFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public void Destroy() => GetDelegate<DestroyDelegate>().Invoke(NativePtr);
  public uint Count() => GetDelegate<CountDelegate>().Invoke(NativePtr);
  public IntPtr ValueAt(uint aIndex) => GetDelegate<ValueAtDelegate>().Invoke(NativePtr, aIndex);
  public IntPtr ItemAt(uint aIndex) => GetDelegate<ItemAtDelegate>().Invoke(NativePtr, aIndex);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class ElementIdListMapInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr destroyFunctionPtr;
    internal IntPtr countFunctionPtr;
    internal IntPtr valueAtFunctionPtr;
    internal IntPtr itemAtFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DestroyDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate uint CountDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr ValueAtDelegate(IntPtr thisPtr, uint aIndex);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr ItemAtDelegate(IntPtr thisPtr, uint aIndex);
}
