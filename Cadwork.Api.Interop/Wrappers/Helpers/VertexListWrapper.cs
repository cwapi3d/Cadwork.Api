// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;
using Cadwork.Api.Interop.Wrappers.Structs;

namespace Cadwork.Api.Interop.Wrappers.Helpers;

public class VertexListWrapper
{
  public readonly IntPtr NativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public VertexListWrapper(IntPtr nativePtr)
  {
    NativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<VertexListInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(DestroyDelegate), Marshal.GetDelegateForFunctionPointer<DestroyDelegate>(vTable!.destroyFunctionPtr) },
      { typeof(CountDelegate), Marshal.GetDelegateForFunctionPointer<CountDelegate>(vTable.countFunctionPtr) },
      { typeof(AtDelegate), Marshal.GetDelegateForFunctionPointer<AtDelegate>(vTable.atFunctionPtr) },
      { typeof(AppendDelegate), Marshal.GetDelegateForFunctionPointer<AppendDelegate>(vTable.appendFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public void Destroy() => GetDelegate<DestroyDelegate>().Invoke(NativePtr);
  public uint Count() => GetDelegate<CountDelegate>().Invoke(NativePtr);
  public CVector3 At(uint aIndex) => GetDelegate<AtDelegate>().Invoke(NativePtr, aIndex);
  public void Append(CVector3 aVector) => GetDelegate<AppendDelegate>().Invoke(NativePtr, aVector);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class VertexListInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr destroyFunctionPtr;
    internal IntPtr countFunctionPtr;
    internal IntPtr atFunctionPtr;
    internal IntPtr appendFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DestroyDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate uint CountDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate CVector3 AtDelegate(IntPtr thisPtr, uint aIndex);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void AppendDelegate(IntPtr thisPtr, CVector3 aVector);
}
