// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Helpers;

public class LayerSettingsWrapper
{
  public readonly IntPtr NativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public LayerSettingsWrapper(IntPtr nativePtr)
  {
    NativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<LayerSettingsInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(DestroyDelegate), Marshal.GetDelegateForFunctionPointer<DestroyDelegate>(vTable!.destroyFunctionPtr) },
      { typeof(GetLayerDelegate), Marshal.GetDelegateForFunctionPointer<GetLayerDelegate>(vTable.getLayerFunctionPtr) },
      { typeof(SetLayerDelegate), Marshal.GetDelegateForFunctionPointer<SetLayerDelegate>(vTable.setLayerFunctionPtr) },
      { typeof(IsWithoutOutputDelegate), Marshal.GetDelegateForFunctionPointer<IsWithoutOutputDelegate>(vTable.isWithoutOutputFunctionPtr) },
      { typeof(SetWithoutOutputDelegate), Marshal.GetDelegateForFunctionPointer<SetWithoutOutputDelegate>(vTable.setWithoutOutputFunctionPtr) },
      { typeof(IsWithDimensionsOutputDelegate), Marshal.GetDelegateForFunctionPointer<IsWithDimensionsOutputDelegate>(vTable.isWithDimensionsOutputFunctionPtr) },
      { typeof(SetWithDimensionsOutputDelegate), Marshal.GetDelegateForFunctionPointer<SetWithDimensionsOutputDelegate>(vTable.setWithDimensionsOutputFunctionPtr) },
      { typeof(IsWithoutDimensionsOutputDelegate), Marshal.GetDelegateForFunctionPointer<IsWithoutDimensionsOutputDelegate>(vTable.isWithoutDimensionsOutputFunctionPtr) },
      { typeof(SetWithoutDimensionsOutputDelegate), Marshal.GetDelegateForFunctionPointer<SetWithoutDimensionsOutputDelegate>(vTable.setWithoutDimensionsOutputFunctionPtr) },
      { typeof(IsWithAttributesOutputDelegate), Marshal.GetDelegateForFunctionPointer<IsWithAttributesOutputDelegate>(vTable.isWithAttributesOutputFunctionPtr) },
      { typeof(SetWithAttributesOutputDelegate), Marshal.GetDelegateForFunctionPointer<SetWithAttributesOutputDelegate>(vTable.setWithAttributesOutputFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public void Destroy() => GetDelegate<DestroyDelegate>().Invoke(NativePtr);
  public int GetLayer() => GetDelegate<GetLayerDelegate>().Invoke(NativePtr);
  public void SetLayer(int aLayerNumber) => GetDelegate<SetLayerDelegate>().Invoke(NativePtr, aLayerNumber);
  public bool IsWithoutOutput() => GetDelegate<IsWithoutOutputDelegate>().Invoke(NativePtr);
  public void SetWithoutOutput() => GetDelegate<SetWithoutOutputDelegate>().Invoke(NativePtr);
  public bool IsWithDimensionsOutput() => GetDelegate<IsWithDimensionsOutputDelegate>().Invoke(NativePtr);
  public void SetWithDimensionsOutput() => GetDelegate<SetWithDimensionsOutputDelegate>().Invoke(NativePtr);
  public bool IsWithoutDimensionsOutput() => GetDelegate<IsWithoutDimensionsOutputDelegate>().Invoke(NativePtr);
  public void SetWithoutDimensionsOutput() => GetDelegate<SetWithoutDimensionsOutputDelegate>().Invoke(NativePtr);
  public bool IsWithAttributesOutput() => GetDelegate<IsWithAttributesOutputDelegate>().Invoke(NativePtr);
  public void SetWithAttributesOutput() => GetDelegate<SetWithAttributesOutputDelegate>().Invoke(NativePtr);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class LayerSettingsInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr destroyFunctionPtr;
    internal IntPtr getLayerFunctionPtr;
    internal IntPtr setLayerFunctionPtr;
    internal IntPtr isWithoutOutputFunctionPtr;
    internal IntPtr setWithoutOutputFunctionPtr;
    internal IntPtr isWithDimensionsOutputFunctionPtr;
    internal IntPtr setWithDimensionsOutputFunctionPtr;
    internal IntPtr isWithoutDimensionsOutputFunctionPtr;
    internal IntPtr setWithoutDimensionsOutputFunctionPtr;
    internal IntPtr isWithAttributesOutputFunctionPtr;
    internal IntPtr setWithAttributesOutputFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DestroyDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate int GetLayerDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetLayerDelegate(IntPtr thisPtr, int aLayerNumber);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsWithoutOutputDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetWithoutOutputDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsWithDimensionsOutputDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetWithDimensionsOutputDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsWithoutDimensionsOutputDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetWithoutDimensionsOutputDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsWithAttributesOutputDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetWithAttributesOutputDelegate(IntPtr thisPtr);
}
