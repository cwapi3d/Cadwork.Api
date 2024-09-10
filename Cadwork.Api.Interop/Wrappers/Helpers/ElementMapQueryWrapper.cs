// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Helpers;

public class ElementMapQueryWrapper
{
  public readonly IntPtr NativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public ElementMapQueryWrapper(IntPtr nativePtr)
  {
    NativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<ElementMapQueryInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(DestroyDelegate), Marshal.GetDelegateForFunctionPointer<DestroyDelegate>(vTable!.destroyFunctionPtr) },
      { typeof(SetByNameDelegate), Marshal.GetDelegateForFunctionPointer<SetByNameDelegate>(vTable.setByNameFunctionPtr) },
      { typeof(SetByGroupDelegate), Marshal.GetDelegateForFunctionPointer<SetByGroupDelegate>(vTable.setByGroupFunctionPtr) },
      { typeof(SetBySubgroupDelegate), Marshal.GetDelegateForFunctionPointer<SetBySubgroupDelegate>(vTable.setBySubgroupFunctionPtr) },
      { typeof(SetByCommentDelegate), Marshal.GetDelegateForFunctionPointer<SetByCommentDelegate>(vTable.setByCommentFunctionPtr) },
      { typeof(SetByUserAttributeDelegate), Marshal.GetDelegateForFunctionPointer<SetByUserAttributeDelegate>(vTable.setByUserAttributeFunctionPtr) },
      { typeof(SetBySkuDelegate), Marshal.GetDelegateForFunctionPointer<SetBySkuDelegate>(vTable.setBySKUFunctionPtr) },
      { typeof(SetByProductionNumberDelegate), Marshal.GetDelegateForFunctionPointer<SetByProductionNumberDelegate>(vTable.setByProductionNumberFunctionPtr) },
      { typeof(SetByPartNumberDelegate), Marshal.GetDelegateForFunctionPointer<SetByPartNumberDelegate>(vTable.setByPartNumberFunctionPtr) },
      { typeof(SetByBuildingDelegate), Marshal.GetDelegateForFunctionPointer<SetByBuildingDelegate>(vTable.setByBuildingFunctionPtr) },
      { typeof(SetByStoreyDelegate), Marshal.GetDelegateForFunctionPointer<SetByStoreyDelegate>(vTable.setByStoreyFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public void Destroy() => GetDelegate<DestroyDelegate>().Invoke(NativePtr);
  public void SetByName() => GetDelegate<SetByNameDelegate>().Invoke(NativePtr);
  public void SetByGroup() => GetDelegate<SetByGroupDelegate>().Invoke(NativePtr);
  public void SetBySubgroup() => GetDelegate<SetBySubgroupDelegate>().Invoke(NativePtr);
  public void SetByComment() => GetDelegate<SetByCommentDelegate>().Invoke(NativePtr);
  public void SetByUserAttribute(uint aNumber) => GetDelegate<SetByUserAttributeDelegate>().Invoke(NativePtr, aNumber);
  public void SetBySku() => GetDelegate<SetBySkuDelegate>().Invoke(NativePtr);
  public void SetByProductionNumber() => GetDelegate<SetByProductionNumberDelegate>().Invoke(NativePtr);
  public void SetByPartNumber() => GetDelegate<SetByPartNumberDelegate>().Invoke(NativePtr);
  public void SetByBuilding() => GetDelegate<SetByBuildingDelegate>().Invoke(NativePtr);
  public void SetByStorey() => GetDelegate<SetByStoreyDelegate>().Invoke(NativePtr);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class ElementMapQueryInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr destroyFunctionPtr;
    internal IntPtr setByNameFunctionPtr;
    internal IntPtr setByGroupFunctionPtr;
    internal IntPtr setBySubgroupFunctionPtr;
    internal IntPtr setByCommentFunctionPtr;
    internal IntPtr setByUserAttributeFunctionPtr;
    internal IntPtr setBySKUFunctionPtr;
    internal IntPtr setByProductionNumberFunctionPtr;
    internal IntPtr setByPartNumberFunctionPtr;
    internal IntPtr setByBuildingFunctionPtr;
    internal IntPtr setByStoreyFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DestroyDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetByNameDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetByGroupDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetBySubgroupDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetByCommentDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetByUserAttributeDelegate(IntPtr thisPtr, uint aNumber);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetBySkuDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetByProductionNumberDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetByPartNumberDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetByBuildingDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetByStoreyDelegate(IntPtr thisPtr);
}
