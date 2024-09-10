// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Controllers;

public class MenuControllerWrapper
{
  private readonly IntPtr _nativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public MenuControllerWrapper(IntPtr nativePtr)
  {
    _nativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<MenuControllerInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(GetLastErrorDelegate), Marshal.GetDelegateForFunctionPointer<GetLastErrorDelegate>(vTable!.getLastErrorFunctionPtr) },
      { typeof(CreateMenuDelegate), Marshal.GetDelegateForFunctionPointer<CreateMenuDelegate>(vTable.createMenuFunctionPtr) },
      { typeof(GetSelectedMenuItemDelegate), Marshal.GetDelegateForFunctionPointer<GetSelectedMenuItemDelegate>(vTable.getSelectedMenuItemFunctionPtr) },
      { typeof(CleanupAllMenusDelegate), Marshal.GetDelegateForFunctionPointer<CleanupAllMenusDelegate>(vTable.cleanupAllMenusFunctionPtr) },
      { typeof(DisplayMenuDelegate), Marshal.GetDelegateForFunctionPointer<DisplayMenuDelegate>(vTable.displayMenuFunctionPtr) },
      { typeof(ClearErrorsDelegate), Marshal.GetDelegateForFunctionPointer<ClearErrorsDelegate>(vTable.clearErrorsFunctionPtr) },
      { typeof(DisplaySimpleMenuDelegate), Marshal.GetDelegateForFunctionPointer<DisplaySimpleMenuDelegate>(vTable.displaySimpleMenuFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public IntPtr GetLastError(IntPtr aErrorCode) => GetDelegate<GetLastErrorDelegate>().Invoke(_nativePtr, aErrorCode);
  public IntPtr CreateMenu() => GetDelegate<CreateMenuDelegate>().Invoke(_nativePtr);
  public int GetSelectedMenuItem() => GetDelegate<GetSelectedMenuItemDelegate>().Invoke(_nativePtr);
  public void CleanupAllMenus() => GetDelegate<CleanupAllMenusDelegate>().Invoke(_nativePtr);
  public void DisplayMenu(IntPtr aMenu) => GetDelegate<DisplayMenuDelegate>().Invoke(_nativePtr, aMenu);
  public void ClearErrors() => GetDelegate<ClearErrorsDelegate>().Invoke(_nativePtr);
  public IntPtr DisplaySimpleMenu(IntPtr aMenuItems) => GetDelegate<DisplaySimpleMenuDelegate>().Invoke(_nativePtr, aMenuItems);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class MenuControllerInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr getLastErrorFunctionPtr;
    internal IntPtr createMenuFunctionPtr;
    internal IntPtr getSelectedMenuItemFunctionPtr;
    internal IntPtr cleanupAllMenusFunctionPtr;
    internal IntPtr displayMenuFunctionPtr;
    internal IntPtr clearErrorsFunctionPtr;
    internal IntPtr displaySimpleMenuFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetLastErrorDelegate(IntPtr thisPtr, IntPtr aErrorCode);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CreateMenuDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate int GetSelectedMenuItemDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void CleanupAllMenusDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DisplayMenuDelegate(IntPtr thisPtr, IntPtr aMenu);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ClearErrorsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr DisplaySimpleMenuDelegate(IntPtr thisPtr, IntPtr aMenuItems);
}
