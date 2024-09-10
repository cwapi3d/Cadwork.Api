// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;
using Cadwork.Api.Interop.Wrappers.Structs;

namespace Cadwork.Api.Interop.Wrappers.Controllers;

public class ShopDrawingControllerWrapper
{
  private readonly IntPtr _nativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public ShopDrawingControllerWrapper(IntPtr nativePtr)
  {
    _nativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<ShopDrawingControllerInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(GetLastErrorDelegate), Marshal.GetDelegateForFunctionPointer<GetLastErrorDelegate>(vTable!.getLastErrorFunctionPtr) },
      { typeof(Export2DWireframeWithClipboardDelegate), Marshal.GetDelegateForFunctionPointer<Export2DWireframeWithClipboardDelegate>(vTable.export2DWireframeWithClipboardFunctionPtr) },
      { typeof(Export2DHiddenLinesWithClipboardDelegate), Marshal.GetDelegateForFunctionPointer<Export2DHiddenLinesWithClipboardDelegate>(vTable.export2DHiddenLinesWithClipboardFunctionPtr) },
      { typeof(Export2DWireframeWith2DcDelegate), Marshal.GetDelegateForFunctionPointer<Export2DWireframeWith2DcDelegate>(vTable.export2DWireframeWith2DCFunctionPtr) },
      { typeof(Export2DHiddenLinesWith2DcDelegate), Marshal.GetDelegateForFunctionPointer<Export2DHiddenLinesWith2DcDelegate>(vTable.export2DHiddenLinesWith2DCFunctionPtr) },
      { typeof(ExportWallWithClipboardDelegate), Marshal.GetDelegateForFunctionPointer<ExportWallWithClipboardDelegate>(vTable.exportWallWithClipboardFunctionPtr) },
      { typeof(ExportExportSolidWithClipboardDelegate), Marshal.GetDelegateForFunctionPointer<ExportExportSolidWithClipboardDelegate>(vTable.exportExportSolidWithClipboardFunctionPtr) },
      { typeof(ExportPieceByPieceWithClipboardDelegate), Marshal.GetDelegateForFunctionPointer<ExportPieceByPieceWithClipboardDelegate>(vTable.exportPieceByPieceWithClipboardFunctionPtr) },
      { typeof(AssignExportSolidDelegate), Marshal.GetDelegateForFunctionPointer<AssignExportSolidDelegate>(vTable.assignExportSolidFunctionPtr) },
      { typeof(ExportContainerWithClipboardDelegate), Marshal.GetDelegateForFunctionPointer<ExportContainerWithClipboardDelegate>(vTable.exportContainerWithClipboardFunctionPtr) },
      { typeof(AddWallSectionHorizontalDelegate), Marshal.GetDelegateForFunctionPointer<AddWallSectionHorizontalDelegate>(vTable.addWallSectionHorizontalFunctionPtr) },
      { typeof(AddWallSectionVerticalDelegate), Marshal.GetDelegateForFunctionPointer<AddWallSectionVerticalDelegate>(vTable.addWallSectionVerticalFunctionPtr) },
      { typeof(ExportWallWithClipboardAndPresettingDelegate), Marshal.GetDelegateForFunctionPointer<ExportWallWithClipboardAndPresettingDelegate>(vTable.exportWallWithClipboardAndPresettingFunctionPtr) },
      { typeof(LoadExportPieceByPieceSettingsDelegate), Marshal.GetDelegateForFunctionPointer<LoadExportPieceByPieceSettingsDelegate>(vTable.loadExportPieceByPieceSettingsFunctionPtr) },
      { typeof(SaveExportPieceByPieceSettingsDelegate), Marshal.GetDelegateForFunctionPointer<SaveExportPieceByPieceSettingsDelegate>(vTable.saveExportPieceByPieceSettingsFunctionPtr) },
      { typeof(ClearErrorsDelegate), Marshal.GetDelegateForFunctionPointer<ClearErrorsDelegate>(vTable.clearErrorsFunctionPtr) },
      { typeof(LoadExportWallSettingsDelegate), Marshal.GetDelegateForFunctionPointer<LoadExportWallSettingsDelegate>(vTable.loadExportWallSettingsFunctionPtr) },
      { typeof(LoadExportSolidSettingsDelegate), Marshal.GetDelegateForFunctionPointer<LoadExportSolidSettingsDelegate>(vTable.loadExportSolidSettingsFunctionPtr) },
      { typeof(LoadExportContainerSettingsDelegate), Marshal.GetDelegateForFunctionPointer<LoadExportContainerSettingsDelegate>(vTable.loadExportContainerSettingsFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public IntPtr GetLastError(IntPtr aErrorCode) => GetDelegate<GetLastErrorDelegate>().Invoke(_nativePtr, aErrorCode);
  public void Export2DWireframeWithClipboard(uint aClipboardNumber, bool aWithLayout) => GetDelegate<Export2DWireframeWithClipboardDelegate>().Invoke(_nativePtr, aClipboardNumber, aWithLayout);
  public void Export2DHiddenLinesWithClipboard(uint aClipboardNumber, bool aWithLayout) => GetDelegate<Export2DHiddenLinesWithClipboardDelegate>().Invoke(_nativePtr, aClipboardNumber, aWithLayout);
  public void Export2DWireframeWith2Dc(string aFilePath, bool aWithLayout) => GetDelegate<Export2DWireframeWith2DcDelegate>().Invoke(_nativePtr, aFilePath, aWithLayout);
  public void Export2DHiddenLinesWith2Dc(string aFilePath, bool aWithLayout) => GetDelegate<Export2DHiddenLinesWith2DcDelegate>().Invoke(_nativePtr, aFilePath, aWithLayout);
  public void ExportWallWithClipboard(uint aClipboardNumber, IntPtr aElementIdList) => GetDelegate<ExportWallWithClipboardDelegate>().Invoke(_nativePtr, aClipboardNumber, aElementIdList);
  public void ExportExportSolidWithClipboard(uint aClipboardNumber, IntPtr aElementIdList) => GetDelegate<ExportExportSolidWithClipboardDelegate>().Invoke(_nativePtr, aClipboardNumber, aElementIdList);
  public void ExportPieceByPieceWithClipboard(uint aClipboardNumber, IntPtr aElementIdList) => GetDelegate<ExportPieceByPieceWithClipboardDelegate>().Invoke(_nativePtr, aClipboardNumber, aElementIdList);
  public void AssignExportSolid(IntPtr aCeoElement, IntPtr aElementIdList) => GetDelegate<AssignExportSolidDelegate>().Invoke(_nativePtr, aCeoElement, aElementIdList);
  public void ExportContainerWithClipboard(uint aClipboardNumber, IntPtr aElements) => GetDelegate<ExportContainerWithClipboardDelegate>().Invoke(_nativePtr, aClipboardNumber, aElements);
  public void AddWallSectionHorizontal(ulong aElement, CVector3 aPosition) => GetDelegate<AddWallSectionHorizontalDelegate>().Invoke(_nativePtr, aElement, aPosition);
  public void AddWallSectionVertical(ulong aElement, CVector3 aPosition) => GetDelegate<AddWallSectionVerticalDelegate>().Invoke(_nativePtr, aElement, aPosition);
  public void ExportWallWithClipboardAndPresetting(uint aClipboardNumber, IntPtr aElementIdList, string aPresettingFile) => GetDelegate<ExportWallWithClipboardAndPresettingDelegate>().Invoke(_nativePtr, aClipboardNumber, aElementIdList, aPresettingFile);
  public void LoadExportPieceByPieceSettings(string aSettingsFilePath) => GetDelegate<LoadExportPieceByPieceSettingsDelegate>().Invoke(_nativePtr, aSettingsFilePath);
  public void SaveExportPieceByPieceSettings(string aSettingsFilePath) => GetDelegate<SaveExportPieceByPieceSettingsDelegate>().Invoke(_nativePtr, aSettingsFilePath);
  public void ClearErrors() => GetDelegate<ClearErrorsDelegate>().Invoke(_nativePtr);
  public void LoadExportWallSettings(string aSettingsFilePath) => GetDelegate<LoadExportWallSettingsDelegate>().Invoke(_nativePtr, aSettingsFilePath);
  public void LoadExportSolidSettings(string aSettingsFilePath) => GetDelegate<LoadExportSolidSettingsDelegate>().Invoke(_nativePtr, aSettingsFilePath);
  public void LoadExportContainerSettings(string aSettingsFilePath) => GetDelegate<LoadExportContainerSettingsDelegate>().Invoke(_nativePtr, aSettingsFilePath);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class ShopDrawingControllerInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr getLastErrorFunctionPtr;
    internal IntPtr export2DWireframeWithClipboardFunctionPtr;
    internal IntPtr export2DHiddenLinesWithClipboardFunctionPtr;
    internal IntPtr export2DWireframeWith2DCFunctionPtr;
    internal IntPtr export2DHiddenLinesWith2DCFunctionPtr;
    internal IntPtr exportWallWithClipboardFunctionPtr;
    internal IntPtr exportExportSolidWithClipboardFunctionPtr;
    internal IntPtr exportPieceByPieceWithClipboardFunctionPtr;
    internal IntPtr assignExportSolidFunctionPtr;
    internal IntPtr exportContainerWithClipboardFunctionPtr;
    internal IntPtr addWallSectionHorizontalFunctionPtr;
    internal IntPtr addWallSectionVerticalFunctionPtr;
    internal IntPtr exportWallWithClipboardAndPresettingFunctionPtr;
    internal IntPtr loadExportPieceByPieceSettingsFunctionPtr;
    internal IntPtr saveExportPieceByPieceSettingsFunctionPtr;
    internal IntPtr clearErrorsFunctionPtr;
    internal IntPtr loadExportWallSettingsFunctionPtr;
    internal IntPtr loadExportSolidSettingsFunctionPtr;
    internal IntPtr loadExportContainerSettingsFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetLastErrorDelegate(IntPtr thisPtr, IntPtr aErrorCode);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void Export2DWireframeWithClipboardDelegate(IntPtr thisPtr, uint aClipboardNumber, bool aWithLayout);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void Export2DHiddenLinesWithClipboardDelegate(IntPtr thisPtr, uint aClipboardNumber, bool aWithLayout);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void Export2DWireframeWith2DcDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath, bool aWithLayout);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void Export2DHiddenLinesWith2DcDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath, bool aWithLayout);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ExportWallWithClipboardDelegate(IntPtr thisPtr, uint aClipboardNumber, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ExportExportSolidWithClipboardDelegate(IntPtr thisPtr, uint aClipboardNumber, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ExportPieceByPieceWithClipboardDelegate(IntPtr thisPtr, uint aClipboardNumber, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void AssignExportSolidDelegate(IntPtr thisPtr, IntPtr aCeoElement, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ExportContainerWithClipboardDelegate(IntPtr thisPtr, uint aClipboardNumber, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void AddWallSectionHorizontalDelegate(IntPtr thisPtr, ulong aElement, CVector3 aPosition);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void AddWallSectionVerticalDelegate(IntPtr thisPtr, ulong aElement, CVector3 aPosition);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ExportWallWithClipboardAndPresettingDelegate(IntPtr thisPtr, uint aClipboardNumber, IntPtr aElementIdList, [MarshalAs(UnmanagedType.LPWStr)] string aPresettingFile);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void LoadExportPieceByPieceSettingsDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aSettingsFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SaveExportPieceByPieceSettingsDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aSettingsFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ClearErrorsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void LoadExportWallSettingsDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aSettingsFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void LoadExportSolidSettingsDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aSettingsFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void LoadExportContainerSettingsDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aSettingsFilePath);
}
