// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Helpers;

public class AttributeDisplaySettingsWrapper
{
  public readonly IntPtr NativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public AttributeDisplaySettingsWrapper(IntPtr nativePtr)
  {
    NativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<AttributeDisplaySettingsInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(DestroyDelegate), Marshal.GetDelegateForFunctionPointer<DestroyDelegate>(vTable!.destroyFunctionPtr) },
      { typeof(GetTextPositionPercentageDelegate), Marshal.GetDelegateForFunctionPointer<GetTextPositionPercentageDelegate>(vTable.getTextPositionPercentageFunctionPtr) },
      { typeof(SetTextPositionPercentageDelegate), Marshal.GetDelegateForFunctionPointer<SetTextPositionPercentageDelegate>(vTable.setTextPositionPercentageFunctionPtr) },
      { typeof(GetTextPositionAbsoluteDelegate), Marshal.GetDelegateForFunctionPointer<GetTextPositionAbsoluteDelegate>(vTable.getTextPositionAbsoluteFunctionPtr) },
      { typeof(SetTextPositionAbsoluteDelegate), Marshal.GetDelegateForFunctionPointer<SetTextPositionAbsoluteDelegate>(vTable.setTextPositionAbsoluteFunctionPtr) },
      { typeof(IsTextPositionTypePercentageDelegate), Marshal.GetDelegateForFunctionPointer<IsTextPositionTypePercentageDelegate>(vTable.isTextPositionTypePercentageFunctionPtr) },
      { typeof(SetTextPositionTypePercentageDelegate), Marshal.GetDelegateForFunctionPointer<SetTextPositionTypePercentageDelegate>(vTable.setTextPositionTypePercentageFunctionPtr) },
      { typeof(IsTextPositionTypeAbsoluteDelegate), Marshal.GetDelegateForFunctionPointer<IsTextPositionTypeAbsoluteDelegate>(vTable.isTextPositionTypeAbsoluteFunctionPtr) },
      { typeof(SetTextPositionTypeAbsoluteDelegate), Marshal.GetDelegateForFunctionPointer<SetTextPositionTypeAbsoluteDelegate>(vTable.setTextPositionTypeAbsoluteFunctionPtr) }
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public void Destroy() => GetDelegate<DestroyDelegate>().Invoke(NativePtr);
  public uint GetTextPositionPercentage() => GetDelegate<GetTextPositionPercentageDelegate>().Invoke(NativePtr);
  public void SetTextPositionPercentage(uint aPercentage) => GetDelegate<SetTextPositionPercentageDelegate>().Invoke(NativePtr, aPercentage);
  public uint GetTextPositionAbsolute() => GetDelegate<GetTextPositionAbsoluteDelegate>().Invoke(NativePtr);
  public void SetTextPositionAbsolute(uint aAbsolute) => GetDelegate<SetTextPositionAbsoluteDelegate>().Invoke(NativePtr, aAbsolute);
  public bool IsTextPositionTypePercentage() => GetDelegate<IsTextPositionTypePercentageDelegate>().Invoke(NativePtr);
  public void SetTextPositionTypePercentage(bool aPercentageType) => GetDelegate<SetTextPositionTypePercentageDelegate>().Invoke(NativePtr, aPercentageType);
  public bool IsTextPositionTypeAbsolute() => GetDelegate<IsTextPositionTypeAbsoluteDelegate>().Invoke(NativePtr);
  public void SetTextPositionTypeAbsolute(bool aAbsoluteType) => GetDelegate<SetTextPositionTypeAbsoluteDelegate>().Invoke(NativePtr, aAbsoluteType);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class AttributeDisplaySettingsInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr destroyFunctionPtr;
    internal IntPtr getTextPositionPercentageFunctionPtr;
    internal IntPtr setTextPositionPercentageFunctionPtr;
    internal IntPtr getTextPositionAbsoluteFunctionPtr;
    internal IntPtr setTextPositionAbsoluteFunctionPtr;
    internal IntPtr isTextPositionTypePercentageFunctionPtr;
    internal IntPtr setTextPositionTypePercentageFunctionPtr;
    internal IntPtr isTextPositionTypeAbsoluteFunctionPtr;
    internal IntPtr setTextPositionTypeAbsoluteFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DestroyDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate uint GetTextPositionPercentageDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetTextPositionPercentageDelegate(IntPtr thisPtr, uint aPercentage);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate uint GetTextPositionAbsoluteDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetTextPositionAbsoluteDelegate(IntPtr thisPtr, uint aAbsolute);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsTextPositionTypePercentageDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetTextPositionTypePercentageDelegate(IntPtr thisPtr, bool aPercentageType);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsTextPositionTypeAbsoluteDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetTextPositionTypeAbsoluteDelegate(IntPtr thisPtr, bool aAbsoluteType);
}
