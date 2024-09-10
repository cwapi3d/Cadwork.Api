// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Controllers;

public class ListControllerWrapper
{
  private readonly IntPtr _nativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public ListControllerWrapper(IntPtr nativePtr)
  {
    _nativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<ListControllerInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(GetLastErrorDelegate), Marshal.GetDelegateForFunctionPointer<GetLastErrorDelegate>(vTable!.getLastErrorFunctionPtr) },
      { typeof(ExportProductionListDelegate), Marshal.GetDelegateForFunctionPointer<ExportProductionListDelegate>(vTable.exportProductionListFunctionPtr) },
      { typeof(ExportPartListDelegate), Marshal.GetDelegateForFunctionPointer<ExportPartListDelegate>(vTable.exportPartListFunctionPtr) },
      { typeof(CheckPositionNumbersProductionListDelegate), Marshal.GetDelegateForFunctionPointer<CheckPositionNumbersProductionListDelegate>(vTable.checkPositionNumbersProductionListFunctionPtr) },
      { typeof(CheckPositionNumbersPartListDelegate), Marshal.GetDelegateForFunctionPointer<CheckPositionNumbersPartListDelegate>(vTable.checkPositionNumbersPartListFunctionPtr) },
      { typeof(ClearErrorsDelegate), Marshal.GetDelegateForFunctionPointer<ClearErrorsDelegate>(vTable.clearErrorsFunctionPtr) },
      { typeof(ExportProductionListWithSettingsDelegate), Marshal.GetDelegateForFunctionPointer<ExportProductionListWithSettingsDelegate>(vTable.exportProductionListWithSettingsFunctionPtr) },
      { typeof(ExportPartListWithSettingsDelegate), Marshal.GetDelegateForFunctionPointer<ExportPartListWithSettingsDelegate>(vTable.exportPartListWithSettingsFunctionPtr) },
      { typeof(GenerateNewNumbersProductionListDelegate), Marshal.GetDelegateForFunctionPointer<GenerateNewNumbersProductionListDelegate>(vTable.generateNewNumbersProductionListFunctionPtr) },
      { typeof(GenerateNewNumbersPartListDelegate), Marshal.GetDelegateForFunctionPointer<GenerateNewNumbersPartListDelegate>(vTable.generateNewNumbersPartListFunctionPtr) },
      { typeof(LoadListCalculationSettingsProductionListDelegate), Marshal.GetDelegateForFunctionPointer<LoadListCalculationSettingsProductionListDelegate>(vTable.loadListCalculationSettingsProductionListFunctionPtr) },
      { typeof(LoadListCalculationSettingsPartListDelegate), Marshal.GetDelegateForFunctionPointer<LoadListCalculationSettingsPartListDelegate>(vTable.loadListCalculationSettingsPartListFunctionPtr) },
      { typeof(GenerateNewNumbersProductionListSilentlyDelegate), Marshal.GetDelegateForFunctionPointer<GenerateNewNumbersProductionListSilentlyDelegate>(vTable.generateNewNumbersProductionListSilentlyFunctionPtr) },
      { typeof(GenerateNewNumbersPartListSilentlyDelegate), Marshal.GetDelegateForFunctionPointer<GenerateNewNumbersPartListSilentlyDelegate>(vTable.generateNewNumbersPartListSilentlyFunctionPtr) },
      { typeof(ExportCoverListDelegate), Marshal.GetDelegateForFunctionPointer<ExportCoverListDelegate>(vTable.exportCoverListFunctionPtr) },
      { typeof(ExportCoverListWithSettingsDelegate), Marshal.GetDelegateForFunctionPointer<ExportCoverListWithSettingsDelegate>(vTable.exportCoverListWithSettingsFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public IntPtr GetLastError(IntPtr aErrorCode) => GetDelegate<GetLastErrorDelegate>().Invoke(_nativePtr, aErrorCode);
  public void ExportProductionList(IntPtr aElementIdList, string aFilePath) => GetDelegate<ExportProductionListDelegate>().Invoke(_nativePtr, aElementIdList, aFilePath);
  public void ExportPartList(IntPtr aElementIdList, string aFilePath) => GetDelegate<ExportPartListDelegate>().Invoke(_nativePtr, aElementIdList, aFilePath);
  public IntPtr CheckPositionNumbersProductionList() => GetDelegate<CheckPositionNumbersProductionListDelegate>().Invoke(_nativePtr);
  public IntPtr CheckPositionNumbersPartList() => GetDelegate<CheckPositionNumbersPartListDelegate>().Invoke(_nativePtr);
  public void ClearErrors() => GetDelegate<ClearErrorsDelegate>().Invoke(_nativePtr);
  public void ExportProductionListWithSettings(IntPtr aElementIdList, string aFilePath, string aSettingsFilePath) => GetDelegate<ExportProductionListWithSettingsDelegate>().Invoke(_nativePtr, aElementIdList, aFilePath, aSettingsFilePath);
  public void ExportPartListWithSettings(IntPtr aElementIdList, string aFilePath, string aSettingsFilePath) => GetDelegate<ExportPartListWithSettingsDelegate>().Invoke(_nativePtr, aElementIdList, aFilePath, aSettingsFilePath);
  public void GenerateNewNumbersProductionList(IntPtr aElementIdList) => GetDelegate<GenerateNewNumbersProductionListDelegate>().Invoke(_nativePtr, aElementIdList);
  public void GenerateNewNumbersPartList(IntPtr aElementIdList) => GetDelegate<GenerateNewNumbersPartListDelegate>().Invoke(_nativePtr, aElementIdList);
  public void LoadListCalculationSettingsProductionList(string aSettingsFilePath) => GetDelegate<LoadListCalculationSettingsProductionListDelegate>().Invoke(_nativePtr, aSettingsFilePath);
  public void LoadListCalculationSettingsPartList(string aSettingsFilePath) => GetDelegate<LoadListCalculationSettingsPartListDelegate>().Invoke(_nativePtr, aSettingsFilePath);
  public void GenerateNewNumbersProductionListSilently(IntPtr aElements, uint aStartingNumber, bool aKeepExistingNumbers, bool aWithContainers) => GetDelegate<GenerateNewNumbersProductionListSilentlyDelegate>().Invoke(_nativePtr, aElements, aStartingNumber, aKeepExistingNumbers, aWithContainers);
  public void GenerateNewNumbersPartListSilently(IntPtr aElements, uint aStartingNumber, bool aKeepExistingNumbers, bool aWithContainers) => GetDelegate<GenerateNewNumbersPartListSilentlyDelegate>().Invoke(_nativePtr, aElements, aStartingNumber, aKeepExistingNumbers, aWithContainers);
  public void ExportCoverList(IntPtr aElementIdList, string aFilePath) => GetDelegate<ExportCoverListDelegate>().Invoke(_nativePtr, aElementIdList, aFilePath);
  public void ExportCoverListWithSettings(IntPtr aElementIdList, string aFilePath, string aSettingsFilePath) => GetDelegate<ExportCoverListWithSettingsDelegate>().Invoke(_nativePtr, aElementIdList, aFilePath, aSettingsFilePath);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class ListControllerInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr getLastErrorFunctionPtr;
    internal IntPtr exportProductionListFunctionPtr;
    internal IntPtr exportPartListFunctionPtr;
    internal IntPtr checkPositionNumbersProductionListFunctionPtr;
    internal IntPtr checkPositionNumbersPartListFunctionPtr;
    internal IntPtr clearErrorsFunctionPtr;
    internal IntPtr exportProductionListWithSettingsFunctionPtr;
    internal IntPtr exportPartListWithSettingsFunctionPtr;
    internal IntPtr generateNewNumbersProductionListFunctionPtr;
    internal IntPtr generateNewNumbersPartListFunctionPtr;
    internal IntPtr loadListCalculationSettingsProductionListFunctionPtr;
    internal IntPtr loadListCalculationSettingsPartListFunctionPtr;
    internal IntPtr generateNewNumbersProductionListSilentlyFunctionPtr;
    internal IntPtr generateNewNumbersPartListSilentlyFunctionPtr;
    internal IntPtr exportCoverListFunctionPtr;
    internal IntPtr exportCoverListWithSettingsFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetLastErrorDelegate(IntPtr thisPtr, IntPtr aErrorCode);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ExportProductionListDelegate(IntPtr thisPtr, IntPtr aElementIdList, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ExportPartListDelegate(IntPtr thisPtr, IntPtr aElementIdList, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CheckPositionNumbersProductionListDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CheckPositionNumbersPartListDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ClearErrorsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ExportProductionListWithSettingsDelegate(IntPtr thisPtr, IntPtr aElementIdList, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath, [MarshalAs(UnmanagedType.LPWStr)] string aSettingsFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ExportPartListWithSettingsDelegate(IntPtr thisPtr, IntPtr aElementIdList, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath, [MarshalAs(UnmanagedType.LPWStr)] string aSettingsFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void GenerateNewNumbersProductionListDelegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void GenerateNewNumbersPartListDelegate(IntPtr thisPtr, IntPtr aElementIdList);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void LoadListCalculationSettingsProductionListDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aSettingsFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void LoadListCalculationSettingsPartListDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aSettingsFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void GenerateNewNumbersProductionListSilentlyDelegate(IntPtr thisPtr, IntPtr aElements, uint aStartingNumber, bool aKeepExistingNumbers, bool aWithContainers);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void GenerateNewNumbersPartListSilentlyDelegate(IntPtr thisPtr, IntPtr aElements, uint aStartingNumber, bool aKeepExistingNumbers, bool aWithContainers);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ExportCoverListDelegate(IntPtr thisPtr, IntPtr aElementIdList, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ExportCoverListWithSettingsDelegate(IntPtr thisPtr, IntPtr aElementIdList, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath, [MarshalAs(UnmanagedType.LPWStr)] string aSettingsFilePath);
}
