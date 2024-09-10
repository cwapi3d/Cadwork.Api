// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Helpers;

public class ElementFilterWrapper
{
  public readonly IntPtr NativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public ElementFilterWrapper(IntPtr nativePtr)
  {
    NativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<ElementFilterInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(DestroyDelegate), Marshal.GetDelegateForFunctionPointer<DestroyDelegate>(vTable!.destroyFunctionPtr) },
      { typeof(SetNameDelegate), Marshal.GetDelegateForFunctionPointer<SetNameDelegate>(vTable.setNameFunctionPtr) },
      { typeof(SetGroupDelegate), Marshal.GetDelegateForFunctionPointer<SetGroupDelegate>(vTable.setGroupFunctionPtr) },
      { typeof(SetSubgroupDelegate), Marshal.GetDelegateForFunctionPointer<SetSubgroupDelegate>(vTable.setSubgroupFunctionPtr) },
      { typeof(SetCommentDelegate), Marshal.GetDelegateForFunctionPointer<SetCommentDelegate>(vTable.setCommentFunctionPtr) },
      { typeof(SetUserAttributeDelegate), Marshal.GetDelegateForFunctionPointer<SetUserAttributeDelegate>(vTable.setUserAttributeFunctionPtr) },
      { typeof(SetSkuDelegate), Marshal.GetDelegateForFunctionPointer<SetSkuDelegate>(vTable.setSKUFunctionPtr) },
      { typeof(SetProductionNumberDelegate), Marshal.GetDelegateForFunctionPointer<SetProductionNumberDelegate>(vTable.setProductionNumberFunctionPtr) },
      { typeof(SetPartNumberDelegate), Marshal.GetDelegateForFunctionPointer<SetPartNumberDelegate>(vTable.setPartNumberFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public void Destroy() => GetDelegate<DestroyDelegate>().Invoke(NativePtr);
  public void SetName(string aName) => GetDelegate<SetNameDelegate>().Invoke(NativePtr, aName);
  public void SetGroup(string aGroup) => GetDelegate<SetGroupDelegate>().Invoke(NativePtr, aGroup);
  public void SetSubgroup(string aSubgroup) => GetDelegate<SetSubgroupDelegate>().Invoke(NativePtr, aSubgroup);
  public void SetComment(string aComment) => GetDelegate<SetCommentDelegate>().Invoke(NativePtr, aComment);
  public void SetUserAttribute(uint aNumber, string aUserAttribute) => GetDelegate<SetUserAttributeDelegate>().Invoke(NativePtr, aNumber, aUserAttribute);
  public void SetSku(string aSku) => GetDelegate<SetSkuDelegate>().Invoke(NativePtr, aSku);
  public void SetProductionNumber(uint aProductionNumber) => GetDelegate<SetProductionNumberDelegate>().Invoke(NativePtr, aProductionNumber);
  public void SetPartNumber(uint aPartNumber) => GetDelegate<SetPartNumberDelegate>().Invoke(NativePtr, aPartNumber);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class ElementFilterInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr destroyFunctionPtr;
    internal IntPtr setNameFunctionPtr;
    internal IntPtr setGroupFunctionPtr;
    internal IntPtr setSubgroupFunctionPtr;
    internal IntPtr setCommentFunctionPtr;
    internal IntPtr setUserAttributeFunctionPtr;
    internal IntPtr setSKUFunctionPtr;
    internal IntPtr setProductionNumberFunctionPtr;
    internal IntPtr setPartNumberFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DestroyDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetNameDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetGroupDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aGroup);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetSubgroupDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aSubgroup);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCommentDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aComment);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetUserAttributeDelegate(IntPtr thisPtr, uint aNumber, [MarshalAs(UnmanagedType.LPWStr)] string aUserAttribute);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetSkuDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aSku);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetProductionNumberDelegate(IntPtr thisPtr, uint aProductionNumber);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetPartNumberDelegate(IntPtr thisPtr, uint aPartNumber);
}
