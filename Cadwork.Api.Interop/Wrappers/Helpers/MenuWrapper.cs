// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Helpers;

public class MenuWrapper
{
  public readonly IntPtr NativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public MenuWrapper(IntPtr nativePtr)
  {
    NativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<MenuInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(DestroyDelegate), Marshal.GetDelegateForFunctionPointer<DestroyDelegate>(vTable!.destroyFunctionPtr) },
      { typeof(AddButtonMenuItemDelegate), Marshal.GetDelegateForFunctionPointer<AddButtonMenuItemDelegate>(vTable.addButtonMenuItemFunctionPtr) },
      { typeof(AddBlankMenuItemDelegate), Marshal.GetDelegateForFunctionPointer<AddBlankMenuItemDelegate>(vTable.addBlankMenuItemFunctionPtr) },
      { typeof(GetMenuItemsDelegate), Marshal.GetDelegateForFunctionPointer<GetMenuItemsDelegate>(vTable.getMenuItemsFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public void Destroy() => GetDelegate<DestroyDelegate>().Invoke(NativePtr);
  public int AddButtonMenuItem(string aLabel) => GetDelegate<AddButtonMenuItemDelegate>().Invoke(NativePtr, aLabel);
  public void AddBlankMenuItem() => GetDelegate<AddBlankMenuItemDelegate>().Invoke(NativePtr);
  public IntPtr GetMenuItems() => GetDelegate<GetMenuItemsDelegate>().Invoke(NativePtr);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class MenuInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr destroyFunctionPtr;
    internal IntPtr addButtonMenuItemFunctionPtr;
    internal IntPtr addBlankMenuItemFunctionPtr;
    internal IntPtr getMenuItemsFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DestroyDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate int AddButtonMenuItemDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aLabel);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void AddBlankMenuItemDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetMenuItemsDelegate(IntPtr thisPtr);
}
