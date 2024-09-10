// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Helpers;

public class DisplayAttributeWrapper
{
  public readonly IntPtr NativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public DisplayAttributeWrapper(IntPtr nativePtr)
  {
    NativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<DisplayAttributeInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(SetNoneDelegate), Marshal.GetDelegateForFunctionPointer<SetNoneDelegate>(vTable!.setNoneFunctionPtr) },
      { typeof(SetNameDelegate), Marshal.GetDelegateForFunctionPointer<SetNameDelegate>(vTable.setNameFunctionPtr) },
      { typeof(SetGroupDelegate), Marshal.GetDelegateForFunctionPointer<SetGroupDelegate>(vTable.setGroupFunctionPtr) },
      { typeof(SetSubgroupDelegate), Marshal.GetDelegateForFunctionPointer<SetSubgroupDelegate>(vTable.setSubgroupFunctionPtr) },
      { typeof(SetCommentDelegate), Marshal.GetDelegateForFunctionPointer<SetCommentDelegate>(vTable.setCommentFunctionPtr) },
      { typeof(SetEdvCodeDelegate), Marshal.GetDelegateForFunctionPointer<SetEdvCodeDelegate>(vTable.setEdvCodeFunctionPtr) },
      { typeof(SetMaterialDelegate), Marshal.GetDelegateForFunctionPointer<SetMaterialDelegate>(vTable.setMaterialFunctionPtr) },
      { typeof(SetMaterialGroupDelegate), Marshal.GetDelegateForFunctionPointer<SetMaterialGroupDelegate>(vTable.setMaterialGroupFunctionPtr) },
      { typeof(SetUser1Delegate), Marshal.GetDelegateForFunctionPointer<SetUser1Delegate>(vTable.setUser1FunctionPtr) },
      { typeof(SetUser2Delegate), Marshal.GetDelegateForFunctionPointer<SetUser2Delegate>(vTable.setUser2FunctionPtr) },
      { typeof(SetUser3Delegate), Marshal.GetDelegateForFunctionPointer<SetUser3Delegate>(vTable.setUser3FunctionPtr) },
      { typeof(SetUser4Delegate), Marshal.GetDelegateForFunctionPointer<SetUser4Delegate>(vTable.setUser4FunctionPtr) },
      { typeof(SetUser5Delegate), Marshal.GetDelegateForFunctionPointer<SetUser5Delegate>(vTable.setUser5FunctionPtr) },
      { typeof(SetUser6Delegate), Marshal.GetDelegateForFunctionPointer<SetUser6Delegate>(vTable.setUser6FunctionPtr) },
      { typeof(SetUser7Delegate), Marshal.GetDelegateForFunctionPointer<SetUser7Delegate>(vTable.setUser7FunctionPtr) },
      { typeof(SetUser8Delegate), Marshal.GetDelegateForFunctionPointer<SetUser8Delegate>(vTable.setUser8FunctionPtr) },
      { typeof(SetUser9Delegate), Marshal.GetDelegateForFunctionPointer<SetUser9Delegate>(vTable.setUser9FunctionPtr) },
      { typeof(SetUser10Delegate), Marshal.GetDelegateForFunctionPointer<SetUser10Delegate>(vTable.setUser10FunctionPtr) },
      { typeof(SetProductionNumberDelegate), Marshal.GetDelegateForFunctionPointer<SetProductionNumberDelegate>(vTable.setProductionNumberFunctionPtr) },
      { typeof(SetTimberNumberDelegate), Marshal.GetDelegateForFunctionPointer<SetTimberNumberDelegate>(vTable.setTimberNumberFunctionPtr) },
      { typeof(SetAssemblyNumberDelegate), Marshal.GetDelegateForFunctionPointer<SetAssemblyNumberDelegate>(vTable.setAssemblyNumberFunctionPtr) },
      { typeof(SetIfcBuildingDelegate), Marshal.GetDelegateForFunctionPointer<SetIfcBuildingDelegate>(vTable.setIFCBuildingFunctionPtr) },
      { typeof(SetIfcStoreyDelegate), Marshal.GetDelegateForFunctionPointer<SetIfcStoreyDelegate>(vTable.setIFCStoreyFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public void SetNone() => GetDelegate<SetNoneDelegate>().Invoke(NativePtr);
  public void SetName() => GetDelegate<SetNameDelegate>().Invoke(NativePtr);
  public void SetGroup() => GetDelegate<SetGroupDelegate>().Invoke(NativePtr);
  public void SetSubgroup() => GetDelegate<SetSubgroupDelegate>().Invoke(NativePtr);
  public void SetComment() => GetDelegate<SetCommentDelegate>().Invoke(NativePtr);
  public void SetEdvCode() => GetDelegate<SetEdvCodeDelegate>().Invoke(NativePtr);
  public void SetMaterial() => GetDelegate<SetMaterialDelegate>().Invoke(NativePtr);
  public void SetMaterialGroup() => GetDelegate<SetMaterialGroupDelegate>().Invoke(NativePtr);
  public void SetUser1() => GetDelegate<SetUser1Delegate>().Invoke(NativePtr);
  public void SetUser2() => GetDelegate<SetUser2Delegate>().Invoke(NativePtr);
  public void SetUser3() => GetDelegate<SetUser3Delegate>().Invoke(NativePtr);
  public void SetUser4() => GetDelegate<SetUser4Delegate>().Invoke(NativePtr);
  public void SetUser5() => GetDelegate<SetUser5Delegate>().Invoke(NativePtr);
  public void SetUser6() => GetDelegate<SetUser6Delegate>().Invoke(NativePtr);
  public void SetUser7() => GetDelegate<SetUser7Delegate>().Invoke(NativePtr);
  public void SetUser8() => GetDelegate<SetUser8Delegate>().Invoke(NativePtr);
  public void SetUser9() => GetDelegate<SetUser9Delegate>().Invoke(NativePtr);
  public void SetUser10() => GetDelegate<SetUser10Delegate>().Invoke(NativePtr);
  public void SetProductionNumber() => GetDelegate<SetProductionNumberDelegate>().Invoke(NativePtr);
  public void SetTimberNumber() => GetDelegate<SetTimberNumberDelegate>().Invoke(NativePtr);
  public void SetAssemblyNumber() => GetDelegate<SetAssemblyNumberDelegate>().Invoke(NativePtr);
  public void SetIfcBuilding() => GetDelegate<SetIfcBuildingDelegate>().Invoke(NativePtr);
  public void SetIfcStorey() => GetDelegate<SetIfcStoreyDelegate>().Invoke(NativePtr);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class DisplayAttributeInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr setNoneFunctionPtr;
    internal IntPtr setNameFunctionPtr;
    internal IntPtr setGroupFunctionPtr;
    internal IntPtr setSubgroupFunctionPtr;
    internal IntPtr setCommentFunctionPtr;
    internal IntPtr setEdvCodeFunctionPtr;
    internal IntPtr setMaterialFunctionPtr;
    internal IntPtr setMaterialGroupFunctionPtr;
    internal IntPtr setUser1FunctionPtr;
    internal IntPtr setUser2FunctionPtr;
    internal IntPtr setUser3FunctionPtr;
    internal IntPtr setUser4FunctionPtr;
    internal IntPtr setUser5FunctionPtr;
    internal IntPtr setUser6FunctionPtr;
    internal IntPtr setUser7FunctionPtr;
    internal IntPtr setUser8FunctionPtr;
    internal IntPtr setUser9FunctionPtr;
    internal IntPtr setUser10FunctionPtr;
    internal IntPtr setProductionNumberFunctionPtr;
    internal IntPtr setTimberNumberFunctionPtr;
    internal IntPtr setAssemblyNumberFunctionPtr;
    internal IntPtr setIFCBuildingFunctionPtr;
    internal IntPtr setIFCStoreyFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetNoneDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetNameDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetGroupDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetSubgroupDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCommentDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetEdvCodeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetMaterialDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetMaterialGroupDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetUser1Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetUser2Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetUser3Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetUser4Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetUser5Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetUser6Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetUser7Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetUser8Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetUser9Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetUser10Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetProductionNumberDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetTimberNumberDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetAssemblyNumberDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIfcBuildingDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIfcStoreyDelegate(IntPtr thisPtr);
}
