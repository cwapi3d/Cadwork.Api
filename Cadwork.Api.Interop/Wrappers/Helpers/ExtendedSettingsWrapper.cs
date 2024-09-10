// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Helpers;

public class ExtendedSettingsWrapper
{
  public readonly IntPtr NativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public ExtendedSettingsWrapper(IntPtr nativePtr)
  {
    NativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<ExtendedSettingsInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(DestroyDelegate), Marshal.GetDelegateForFunctionPointer<DestroyDelegate>(vTable!.destroyFunctionPtr) },
      { typeof(SetPieceByPieceExportWithDimensionsDelegate), Marshal.GetDelegateForFunctionPointer<SetPieceByPieceExportWithDimensionsDelegate>(vTable.setPieceByPieceExportWithDimensionsFunctionPtr) },
      { typeof(GetPieceByPieceExportWithDimensionsDelegate), Marshal.GetDelegateForFunctionPointer<GetPieceByPieceExportWithDimensionsDelegate>(vTable.getPieceByPieceExportWithDimensionsFunctionPtr) },
      { typeof(SetPieceByPieceExportWithoutDimensionsDelegate), Marshal.GetDelegateForFunctionPointer<SetPieceByPieceExportWithoutDimensionsDelegate>(vTable.setPieceByPieceExportWithoutDimensionsFunctionPtr) },
      { typeof(GetPieceByPieceExportWithoutDimensionsDelegate), Marshal.GetDelegateForFunctionPointer<GetPieceByPieceExportWithoutDimensionsDelegate>(vTable.getPieceByPieceExportWithoutDimensionsFunctionPtr) },
      { typeof(SetWallExportDelegate), Marshal.GetDelegateForFunctionPointer<SetWallExportDelegate>(vTable.setWallExportFunctionPtr) },
      { typeof(GetWallExportDelegate), Marshal.GetDelegateForFunctionPointer<GetWallExportDelegate>(vTable.getWallExportFunctionPtr) },
      { typeof(SetGroupExportDelegate), Marshal.GetDelegateForFunctionPointer<SetGroupExportDelegate>(vTable.setGroupExportFunctionPtr) },
      { typeof(GetGroupExportDelegate), Marshal.GetDelegateForFunctionPointer<GetGroupExportDelegate>(vTable.getGroupExportFunctionPtr) },
      { typeof(SetChiefElementDelegate), Marshal.GetDelegateForFunctionPointer<SetChiefElementDelegate>(vTable.setChiefElementFunctionPtr) },
      { typeof(GetChiefElementDelegate), Marshal.GetDelegateForFunctionPointer<GetChiefElementDelegate>(vTable.getChiefElementFunctionPtr) },
      { typeof(SetMfbExportDelegate), Marshal.GetDelegateForFunctionPointer<SetMfbExportDelegate>(vTable.setMFBExportFunctionPtr) },
      { typeof(GetMfbExportDelegate), Marshal.GetDelegateForFunctionPointer<GetMfbExportDelegate>(vTable.getMFBExportFunctionPtr) },
      { typeof(SetLogHomeExportDelegate), Marshal.GetDelegateForFunctionPointer<SetLogHomeExportDelegate>(vTable.setLogHomeExportFunctionPtr) },
      { typeof(GetLogHomeExportDelegate), Marshal.GetDelegateForFunctionPointer<GetLogHomeExportDelegate>(vTable.getLogHomeExportFunctionPtr) },
      { typeof(SetBtlWallExportDelegate), Marshal.GetDelegateForFunctionPointer<SetBtlWallExportDelegate>(vTable.setBTLWallExportFunctionPtr) },
      { typeof(GetBtlWallExportDelegate), Marshal.GetDelegateForFunctionPointer<GetBtlWallExportDelegate>(vTable.getBTLWallExportFunctionPtr) },
      { typeof(SetLogMacroExportDelegate), Marshal.GetDelegateForFunctionPointer<SetLogMacroExportDelegate>(vTable.setLogMacroExportFunctionPtr) },
      { typeof(GetLogMacroExportDelegate), Marshal.GetDelegateForFunctionPointer<GetLogMacroExportDelegate>(vTable.getLogMacroExportFunctionPtr) },
      { typeof(SetOutlineDelegate), Marshal.GetDelegateForFunctionPointer<SetOutlineDelegate>(vTable.setOutlineFunctionPtr) },
      { typeof(GetOutlineDelegate), Marshal.GetDelegateForFunctionPointer<GetOutlineDelegate>(vTable.getOutlineFunctionPtr) },
      { typeof(SetIgnoreForConnectorAxisDelegate), Marshal.GetDelegateForFunctionPointer<SetIgnoreForConnectorAxisDelegate>(vTable.setIgnoreForConnectorAxisFunctionPtr) },
      { typeof(GetIgnoreForConnectorAxisDelegate), Marshal.GetDelegateForFunctionPointer<GetIgnoreForConnectorAxisDelegate>(vTable.getIgnoreForConnectorAxisFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public void Destroy() => GetDelegate<DestroyDelegate>().Invoke(NativePtr);
  public void SetPieceByPieceExportWithDimensions(bool aValue) => GetDelegate<SetPieceByPieceExportWithDimensionsDelegate>().Invoke(NativePtr, aValue);
  public bool GetPieceByPieceExportWithDimensions() => GetDelegate<GetPieceByPieceExportWithDimensionsDelegate>().Invoke(NativePtr);
  public void SetPieceByPieceExportWithoutDimensions(bool aValue) => GetDelegate<SetPieceByPieceExportWithoutDimensionsDelegate>().Invoke(NativePtr, aValue);
  public bool GetPieceByPieceExportWithoutDimensions() => GetDelegate<GetPieceByPieceExportWithoutDimensionsDelegate>().Invoke(NativePtr);
  public void SetWallExport(bool aValue) => GetDelegate<SetWallExportDelegate>().Invoke(NativePtr, aValue);
  public bool GetWallExport() => GetDelegate<GetWallExportDelegate>().Invoke(NativePtr);
  public void SetGroupExport(bool aValue) => GetDelegate<SetGroupExportDelegate>().Invoke(NativePtr, aValue);
  public bool GetGroupExport() => GetDelegate<GetGroupExportDelegate>().Invoke(NativePtr);
  public void SetChiefElement(bool aValue) => GetDelegate<SetChiefElementDelegate>().Invoke(NativePtr, aValue);
  public bool GetChiefElement() => GetDelegate<GetChiefElementDelegate>().Invoke(NativePtr);
  public void SetMfbExport(bool aValue) => GetDelegate<SetMfbExportDelegate>().Invoke(NativePtr, aValue);
  public bool GetMfbExport() => GetDelegate<GetMfbExportDelegate>().Invoke(NativePtr);
  public void SetLogHomeExport(bool aValue) => GetDelegate<SetLogHomeExportDelegate>().Invoke(NativePtr, aValue);
  public bool GetLogHomeExport() => GetDelegate<GetLogHomeExportDelegate>().Invoke(NativePtr);
  public void SetBtlWallExport(bool aValue) => GetDelegate<SetBtlWallExportDelegate>().Invoke(NativePtr, aValue);
  public bool GetBtlWallExport() => GetDelegate<GetBtlWallExportDelegate>().Invoke(NativePtr);
  public void SetLogMacroExport(bool aValue) => GetDelegate<SetLogMacroExportDelegate>().Invoke(NativePtr, aValue);
  public bool GetLogMacroExport() => GetDelegate<GetLogMacroExportDelegate>().Invoke(NativePtr);
  public void SetOutline(bool aValue) => GetDelegate<SetOutlineDelegate>().Invoke(NativePtr, aValue);
  public bool GetOutline() => GetDelegate<GetOutlineDelegate>().Invoke(NativePtr);
  public void SetIgnoreForConnectorAxis(bool aValue) => GetDelegate<SetIgnoreForConnectorAxisDelegate>().Invoke(NativePtr, aValue);
  public bool GetIgnoreForConnectorAxis() => GetDelegate<GetIgnoreForConnectorAxisDelegate>().Invoke(NativePtr);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class ExtendedSettingsInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr destroyFunctionPtr;
    internal IntPtr setPieceByPieceExportWithDimensionsFunctionPtr;
    internal IntPtr getPieceByPieceExportWithDimensionsFunctionPtr;
    internal IntPtr setPieceByPieceExportWithoutDimensionsFunctionPtr;
    internal IntPtr getPieceByPieceExportWithoutDimensionsFunctionPtr;
    internal IntPtr setWallExportFunctionPtr;
    internal IntPtr getWallExportFunctionPtr;
    internal IntPtr setGroupExportFunctionPtr;
    internal IntPtr getGroupExportFunctionPtr;
    internal IntPtr setChiefElementFunctionPtr;
    internal IntPtr getChiefElementFunctionPtr;
    internal IntPtr setMFBExportFunctionPtr;
    internal IntPtr getMFBExportFunctionPtr;
    internal IntPtr setLogHomeExportFunctionPtr;
    internal IntPtr getLogHomeExportFunctionPtr;
    internal IntPtr setBTLWallExportFunctionPtr;
    internal IntPtr getBTLWallExportFunctionPtr;
    internal IntPtr setLogMacroExportFunctionPtr;
    internal IntPtr getLogMacroExportFunctionPtr;
    internal IntPtr setOutlineFunctionPtr;
    internal IntPtr getOutlineFunctionPtr;
    internal IntPtr setIgnoreForConnectorAxisFunctionPtr;
    internal IntPtr getIgnoreForConnectorAxisFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DestroyDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetPieceByPieceExportWithDimensionsDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetPieceByPieceExportWithDimensionsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetPieceByPieceExportWithoutDimensionsDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetPieceByPieceExportWithoutDimensionsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetWallExportDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetWallExportDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetGroupExportDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetGroupExportDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetChiefElementDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetChiefElementDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetMfbExportDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetMfbExportDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetLogHomeExportDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetLogHomeExportDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetBtlWallExportDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetBtlWallExportDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetLogMacroExportDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetLogMacroExportDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetOutlineDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetOutlineDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIgnoreForConnectorAxisDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetIgnoreForConnectorAxisDelegate(IntPtr thisPtr);
}
