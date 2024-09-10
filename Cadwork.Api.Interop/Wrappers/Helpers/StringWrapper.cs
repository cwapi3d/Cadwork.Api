// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Helpers;

public class StringWrapper
{
  public readonly IntPtr NativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public StringWrapper(IntPtr nativePtr)
  {
    NativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<StringInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(DestroyDelegate), Marshal.GetDelegateForFunctionPointer<DestroyDelegate>(vTable!.destroyFunctionPtr) },
      { typeof(LengthDelegate), Marshal.GetDelegateForFunctionPointer<LengthDelegate>(vTable.lengthFunctionPtr) },
      { typeof(DataDelegate), Marshal.GetDelegateForFunctionPointer<DataDelegate>(vTable.dataFunctionPtr) },
      { typeof(NarrowDataDelegate), Marshal.GetDelegateForFunctionPointer<NarrowDataDelegate>(vTable.narrowDataFunctionPtr) },
      { typeof(CopyToBufferDelegate), Marshal.GetDelegateForFunctionPointer<CopyToBufferDelegate>(vTable.copyToBufferFunctionPtr) },
      { typeof(CopyToNarrowBufferDelegate), Marshal.GetDelegateForFunctionPointer<CopyToNarrowBufferDelegate>(vTable.copyToNarrowBufferFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public void Destroy() => GetDelegate<DestroyDelegate>().Invoke(NativePtr);
  public uint Length() => GetDelegate<LengthDelegate>().Invoke(NativePtr);
  public string Data() => GetDelegate<DataDelegate>().Invoke(NativePtr);
  public string NarrowData() => GetDelegate<NarrowDataDelegate>().Invoke(NativePtr);
  public void CopyToBuffer(string aBuffer, uint aSize) => GetDelegate<CopyToBufferDelegate>().Invoke(NativePtr, aBuffer, aSize);
  public void CopyToNarrowBuffer(string aBuffer, uint aSize) => GetDelegate<CopyToNarrowBufferDelegate>().Invoke(NativePtr, aBuffer, aSize);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class StringInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr destroyFunctionPtr;
    internal IntPtr lengthFunctionPtr;
    internal IntPtr dataFunctionPtr;
    internal IntPtr narrowDataFunctionPtr;
    internal IntPtr copyToBufferFunctionPtr;
    internal IntPtr copyToNarrowBufferFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DestroyDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate uint LengthDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate string DataDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate string NarrowDataDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void CopyToBufferDelegate(IntPtr thisPtr, string aBuffer, uint aSize);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void CopyToNarrowBufferDelegate(IntPtr thisPtr, string aBuffer, uint aSize);
}
