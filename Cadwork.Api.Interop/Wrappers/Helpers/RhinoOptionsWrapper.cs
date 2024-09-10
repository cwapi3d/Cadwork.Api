// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Helpers;

public class RhinoOptionsWrapper
{
  public readonly IntPtr NativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public RhinoOptionsWrapper(IntPtr nativePtr)
  {
    NativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<RhinoOptionsInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(DestroyDelegate), Marshal.GetDelegateForFunctionPointer<DestroyDelegate>(vTable!.destroyFunctionPtr) },
      { typeof(SetMaterializeEndTypesDelegate), Marshal.GetDelegateForFunctionPointer<SetMaterializeEndTypesDelegate>(vTable.setMaterializeEndTypesFunctionPtr) },
      { typeof(GetMaterializeEndTypesDelegate), Marshal.GetDelegateForFunctionPointer<GetMaterializeEndTypesDelegate>(vTable.getMaterializeEndTypesFunctionPtr) },
      { typeof(SetCutEndTypesCounterpartsDelegate), Marshal.GetDelegateForFunctionPointer<SetCutEndTypesCounterpartsDelegate>(vTable.setCutEndTypesCounterpartsFunctionPtr) },
      { typeof(GetCutEndTypesCounterpartsDelegate), Marshal.GetDelegateForFunctionPointer<GetCutEndTypesCounterpartsDelegate>(vTable.getCutEndTypesCounterpartsFunctionPtr) },
      { typeof(SetCutDrillingsDelegate), Marshal.GetDelegateForFunctionPointer<SetCutDrillingsDelegate>(vTable.setCutDrillingsFunctionPtr) },
      { typeof(GetCutDrillingsDelegate), Marshal.GetDelegateForFunctionPointer<GetCutDrillingsDelegate>(vTable.getCutDrillingsFunctionPtr) },
      { typeof(SetCutMepDelegate), Marshal.GetDelegateForFunctionPointer<SetCutMepDelegate>(vTable.setCutMEPFunctionPtr) },
      { typeof(GetCutMepDelegate), Marshal.GetDelegateForFunctionPointer<GetCutMepDelegate>(vTable.getCutMEPFunctionPtr) },
      { typeof(SetCutOpeningsDelegate), Marshal.GetDelegateForFunctionPointer<SetCutOpeningsDelegate>(vTable.setCutOpeningsFunctionPtr) },
      { typeof(GetCutOpeningsDelegate), Marshal.GetDelegateForFunctionPointer<GetCutOpeningsDelegate>(vTable.getCutOpeningsFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public void Destroy() => GetDelegate<DestroyDelegate>().Invoke(NativePtr);
  public void SetMaterializeEndTypes(bool aFlag) => GetDelegate<SetMaterializeEndTypesDelegate>().Invoke(NativePtr, aFlag);
  public bool GetMaterializeEndTypes() => GetDelegate<GetMaterializeEndTypesDelegate>().Invoke(NativePtr);
  public void SetCutEndTypesCounterparts(bool aFlag) => GetDelegate<SetCutEndTypesCounterpartsDelegate>().Invoke(NativePtr, aFlag);
  public bool GetCutEndTypesCounterparts() => GetDelegate<GetCutEndTypesCounterpartsDelegate>().Invoke(NativePtr);
  public void SetCutDrillings(bool aFlag) => GetDelegate<SetCutDrillingsDelegate>().Invoke(NativePtr, aFlag);
  public bool GetCutDrillings() => GetDelegate<GetCutDrillingsDelegate>().Invoke(NativePtr);
  public void SetCutMep(bool aFlag) => GetDelegate<SetCutMepDelegate>().Invoke(NativePtr, aFlag);
  public bool GetCutMep() => GetDelegate<GetCutMepDelegate>().Invoke(NativePtr);
  public void SetCutOpenings(bool aFlag) => GetDelegate<SetCutOpeningsDelegate>().Invoke(NativePtr, aFlag);
  public bool GetCutOpenings() => GetDelegate<GetCutOpeningsDelegate>().Invoke(NativePtr);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class RhinoOptionsInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr destroyFunctionPtr;
    internal IntPtr setMaterializeEndTypesFunctionPtr;
    internal IntPtr getMaterializeEndTypesFunctionPtr;
    internal IntPtr setCutEndTypesCounterpartsFunctionPtr;
    internal IntPtr getCutEndTypesCounterpartsFunctionPtr;
    internal IntPtr setCutDrillingsFunctionPtr;
    internal IntPtr getCutDrillingsFunctionPtr;
    internal IntPtr setCutMEPFunctionPtr;
    internal IntPtr getCutMEPFunctionPtr;
    internal IntPtr setCutOpeningsFunctionPtr;
    internal IntPtr getCutOpeningsFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DestroyDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetMaterializeEndTypesDelegate(IntPtr thisPtr, bool aFlag);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetMaterializeEndTypesDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCutEndTypesCounterpartsDelegate(IntPtr thisPtr, bool aFlag);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetCutEndTypesCounterpartsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCutDrillingsDelegate(IntPtr thisPtr, bool aFlag);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetCutDrillingsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCutMepDelegate(IntPtr thisPtr, bool aFlag);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetCutMepDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCutOpeningsDelegate(IntPtr thisPtr, bool aFlag);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetCutOpeningsDelegate(IntPtr thisPtr);
}
