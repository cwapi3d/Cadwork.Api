// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Helpers;

public class ImportOptionsWrapper
{
  public readonly IntPtr NativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public ImportOptionsWrapper(IntPtr nativePtr)
  {
    NativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<ImportOptionsInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(DestroyDelegate), Marshal.GetDelegateForFunctionPointer<DestroyDelegate>(vTable!.destroyFunctionPtr) },
      { typeof(SetImportSaved2dPlanesDelegate), Marshal.GetDelegateForFunctionPointer<SetImportSaved2dPlanesDelegate>(vTable.setImportSaved2dPlanesFunctionPtr) },
      { typeof(GetImportSaved2dPlanesDelegate), Marshal.GetDelegateForFunctionPointer<GetImportSaved2dPlanesDelegate>(vTable.getImportSaved2dPlanesFunctionPtr) },
      { typeof(SetImportSavedScenesDelegate), Marshal.GetDelegateForFunctionPointer<SetImportSavedScenesDelegate>(vTable.setImportSavedScenesFunctionPtr) },
      { typeof(GetImportSavedScenesDelegate), Marshal.GetDelegateForFunctionPointer<GetImportSavedScenesDelegate>(vTable.getImportSavedScenesFunctionPtr) },
      { typeof(SetImportExportSolidsDelegate), Marshal.GetDelegateForFunctionPointer<SetImportExportSolidsDelegate>(vTable.setImportExportSolidsFunctionPtr) },
      { typeof(GetImportExportSolidsDelegate), Marshal.GetDelegateForFunctionPointer<GetImportExportSolidsDelegate>(vTable.getImportExportSolidsFunctionPtr) },
      { typeof(SetResetPositionNumbersDelegate), Marshal.GetDelegateForFunctionPointer<SetResetPositionNumbersDelegate>(vTable.setResetPositionNumbersFunctionPtr) },
      { typeof(GetResetPositionNumbersDelegate), Marshal.GetDelegateForFunctionPointer<GetResetPositionNumbersDelegate>(vTable.getResetPositionNumbersFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public void Destroy() => GetDelegate<DestroyDelegate>().Invoke(NativePtr);
  public void SetImportSaved2dPlanes(bool aValue) => GetDelegate<SetImportSaved2dPlanesDelegate>().Invoke(NativePtr, aValue);
  public bool GetImportSaved2dPlanes() => GetDelegate<GetImportSaved2dPlanesDelegate>().Invoke(NativePtr);
  public void SetImportSavedScenes(bool aValue) => GetDelegate<SetImportSavedScenesDelegate>().Invoke(NativePtr, aValue);
  public bool GetImportSavedScenes() => GetDelegate<GetImportSavedScenesDelegate>().Invoke(NativePtr);
  public void SetImportExportSolids(bool aValue) => GetDelegate<SetImportExportSolidsDelegate>().Invoke(NativePtr, aValue);
  public bool GetImportExportSolids() => GetDelegate<GetImportExportSolidsDelegate>().Invoke(NativePtr);
  public void SetResetPositionNumbers(bool aValue) => GetDelegate<SetResetPositionNumbersDelegate>().Invoke(NativePtr, aValue);
  public bool GetResetPositionNumbers() => GetDelegate<GetResetPositionNumbersDelegate>().Invoke(NativePtr);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class ImportOptionsInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr destroyFunctionPtr;
    internal IntPtr setImportSaved2dPlanesFunctionPtr;
    internal IntPtr getImportSaved2dPlanesFunctionPtr;
    internal IntPtr setImportSavedScenesFunctionPtr;
    internal IntPtr getImportSavedScenesFunctionPtr;
    internal IntPtr setImportExportSolidsFunctionPtr;
    internal IntPtr getImportExportSolidsFunctionPtr;
    internal IntPtr setResetPositionNumbersFunctionPtr;
    internal IntPtr getResetPositionNumbersFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DestroyDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetImportSaved2dPlanesDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetImportSaved2dPlanesDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetImportSavedScenesDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetImportSavedScenesDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetImportExportSolidsDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetImportExportSolidsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetResetPositionNumbersDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetResetPositionNumbersDelegate(IntPtr thisPtr);
}
