// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Controllers;

public class MachineControllerWrapper
{
  private readonly IntPtr _nativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public MachineControllerWrapper(IntPtr nativePtr)
  {
    _nativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<MachineControllerInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(GetLastErrorDelegate), Marshal.GetDelegateForFunctionPointer<GetLastErrorDelegate>(vTable!.getLastErrorFunctionPtr) },
      { typeof(ExportBtlDelegate), Marshal.GetDelegateForFunctionPointer<ExportBtlDelegate>(vTable.exportBTLFunctionPtr) },
      { typeof(ExportWeinmannMfbDelegate), Marshal.GetDelegateForFunctionPointer<ExportWeinmannMfbDelegate>(vTable.exportWeinmannMFBFunctionPtr) },
      { typeof(ExportHundeggerDelegate), Marshal.GetDelegateForFunctionPointer<ExportHundeggerDelegate>(vTable.exportHundeggerFunctionPtr) },
      { typeof(ClearErrorsDelegate), Marshal.GetDelegateForFunctionPointer<ClearErrorsDelegate>(vTable.clearErrorsFunctionPtr) },
      { typeof(ExportHundeggerWithFilePathDelegate), Marshal.GetDelegateForFunctionPointer<ExportHundeggerWithFilePathDelegate>(vTable.exportHundeggerWithFilePathFunctionPtr) },
      { typeof(ExportHundeggerWithFilePathAndPresettingDelegate), Marshal.GetDelegateForFunctionPointer<ExportHundeggerWithFilePathAndPresettingDelegate>(vTable.exportHundeggerWithFilePathAndPresettingFunctionPtr) },
      { typeof(ExportBtlWithPresettingDelegate), Marshal.GetDelegateForFunctionPointer<ExportBtlWithPresettingDelegate>(vTable.exportBTLWithPresettingFunctionPtr) },
      { typeof(CalculateBtlMachineDataDelegate), Marshal.GetDelegateForFunctionPointer<CalculateBtlMachineDataDelegate>(vTable.calculateBTLMachineDataFunctionPtr) },
      { typeof(CalculateHundeggerMachineDataDelegate), Marshal.GetDelegateForFunctionPointer<CalculateHundeggerMachineDataDelegate>(vTable.calculateHundeggerMachineDataFunctionPtr) },
      { typeof(LoadHundeggerCalculationSetDelegate), Marshal.GetDelegateForFunctionPointer<LoadHundeggerCalculationSetDelegate>(vTable.loadHundeggerCalculationSetFunctionPtr) },
      { typeof(GetElementHundeggerProcessesDelegate), Marshal.GetDelegateForFunctionPointer<GetElementHundeggerProcessesDelegate>(vTable.getElementHundeggerProcessesFunctionPtr) },
      { typeof(GetElementBtlProcessesDelegate), Marshal.GetDelegateForFunctionPointer<GetElementBtlProcessesDelegate>(vTable.getElementBTLProcessesFunctionPtr) },
      { typeof(GetProcessingNameDelegate), Marshal.GetDelegateForFunctionPointer<GetProcessingNameDelegate>(vTable.getProcessingNameFunctionPtr) },
      { typeof(GetProcessingCodeDelegate), Marshal.GetDelegateForFunctionPointer<GetProcessingCodeDelegate>(vTable.getProcessingCodeFunctionPtr) },
      { typeof(GetProcessingPointsDelegate), Marshal.GetDelegateForFunctionPointer<GetProcessingPointsDelegate>(vTable.getProcessingPointsFunctionPtr) },
      { typeof(GetProcessingBtlParameterSetDelegate), Marshal.GetDelegateForFunctionPointer<GetProcessingBtlParameterSetDelegate>(vTable.getProcessingBTLParameterSetFunctionPtr) },
      { typeof(ExportHundeggerWithFilePathSilentDelegate), Marshal.GetDelegateForFunctionPointer<ExportHundeggerWithFilePathSilentDelegate>(vTable.exportHundeggerWithFilePathSilentFunctionPtr) },
      { typeof(ExportHundeggerWithFilePathAndPresettingSilentDelegate), Marshal.GetDelegateForFunctionPointer<ExportHundeggerWithFilePathAndPresettingSilentDelegate>(vTable.exportHundeggerWithFilePathAndPresettingSilentFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public IntPtr GetLastError(IntPtr aErrorCode) => GetDelegate<GetLastErrorDelegate>().Invoke(_nativePtr, aErrorCode);
  public void ExportBtl(uint aBtlVersion, string aFilePath) => GetDelegate<ExportBtlDelegate>().Invoke(_nativePtr, aBtlVersion, aFilePath);
  public void ExportWeinmannMfb(uint aMfbVersion) => GetDelegate<ExportWeinmannMfbDelegate>().Invoke(_nativePtr, aMfbVersion);
  public void ExportHundegger(uint aHundeggerType) => GetDelegate<ExportHundeggerDelegate>().Invoke(_nativePtr, aHundeggerType);
  public void ClearErrors() => GetDelegate<ClearErrorsDelegate>().Invoke(_nativePtr);
  public void ExportHundeggerWithFilePath(uint aHundeggerType, string aFilePath) => GetDelegate<ExportHundeggerWithFilePathDelegate>().Invoke(_nativePtr, aHundeggerType, aFilePath);
  public void ExportHundeggerWithFilePathAndPresetting(uint aHundeggerType, string aFilePath, string aPresetting) => GetDelegate<ExportHundeggerWithFilePathAndPresettingDelegate>().Invoke(_nativePtr, aHundeggerType, aFilePath, aPresetting);
  public void ExportBtlWithPresetting(uint aBtlVersion, string aFilePath, string aPresetting) => GetDelegate<ExportBtlWithPresettingDelegate>().Invoke(_nativePtr, aBtlVersion, aFilePath, aPresetting);
  public void CalculateBtlMachineData(IntPtr aElements, uint aBtlVersion) => GetDelegate<CalculateBtlMachineDataDelegate>().Invoke(_nativePtr, aElements, aBtlVersion);
  public void CalculateHundeggerMachineData(IntPtr aElements, uint aHunderggerType) => GetDelegate<CalculateHundeggerMachineDataDelegate>().Invoke(_nativePtr, aElements, aHunderggerType);
  public void LoadHundeggerCalculationSet(uint aHundeggerType, string aFilePath) => GetDelegate<LoadHundeggerCalculationSetDelegate>().Invoke(_nativePtr, aHundeggerType, aFilePath);
  public IntPtr GetElementHundeggerProcesses(ulong aElementId, uint aHundeggerType) => GetDelegate<GetElementHundeggerProcessesDelegate>().Invoke(_nativePtr, aElementId, aHundeggerType);
  public IntPtr GetElementBtlProcesses(ulong aElementId, uint aBtlVersion) => GetDelegate<GetElementBtlProcessesDelegate>().Invoke(_nativePtr, aElementId, aBtlVersion);
  public IntPtr GetProcessingName(ulong aReferenceElementId, ulong aProcessingId) => GetDelegate<GetProcessingNameDelegate>().Invoke(_nativePtr, aReferenceElementId, aProcessingId);
  public IntPtr GetProcessingCode(ulong aReferenceElementId, ulong aProcessingId) => GetDelegate<GetProcessingCodeDelegate>().Invoke(_nativePtr, aReferenceElementId, aProcessingId);
  public IntPtr GetProcessingPoints(ulong aReferenceElementId, ulong aProcessingId) => GetDelegate<GetProcessingPointsDelegate>().Invoke(_nativePtr, aReferenceElementId, aProcessingId);
  public IntPtr GetProcessingBtlParameterSet(ulong aReferenceElementId, ulong aProcessingId) => GetDelegate<GetProcessingBtlParameterSetDelegate>().Invoke(_nativePtr, aReferenceElementId, aProcessingId);
  public void ExportHundeggerWithFilePathSilent(uint aHundeggerType, string aFilePath) => GetDelegate<ExportHundeggerWithFilePathSilentDelegate>().Invoke(_nativePtr, aHundeggerType, aFilePath);
  public void ExportHundeggerWithFilePathAndPresettingSilent(uint aHundeggerType, string aFilePath, string aPresetting) => GetDelegate<ExportHundeggerWithFilePathAndPresettingSilentDelegate>().Invoke(_nativePtr, aHundeggerType, aFilePath, aPresetting);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class MachineControllerInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr getLastErrorFunctionPtr;
    internal IntPtr exportBTLFunctionPtr;
    internal IntPtr exportWeinmannMFBFunctionPtr;
    internal IntPtr exportHundeggerFunctionPtr;
    internal IntPtr clearErrorsFunctionPtr;
    internal IntPtr exportHundeggerWithFilePathFunctionPtr;
    internal IntPtr exportHundeggerWithFilePathAndPresettingFunctionPtr;
    internal IntPtr exportBTLWithPresettingFunctionPtr;
    internal IntPtr calculateBTLMachineDataFunctionPtr;
    internal IntPtr calculateHundeggerMachineDataFunctionPtr;
    internal IntPtr loadHundeggerCalculationSetFunctionPtr;
    internal IntPtr getElementHundeggerProcessesFunctionPtr;
    internal IntPtr getElementBTLProcessesFunctionPtr;
    internal IntPtr getProcessingNameFunctionPtr;
    internal IntPtr getProcessingCodeFunctionPtr;
    internal IntPtr getProcessingPointsFunctionPtr;
    internal IntPtr getProcessingBTLParameterSetFunctionPtr;
    internal IntPtr exportHundeggerWithFilePathSilentFunctionPtr;
    internal IntPtr exportHundeggerWithFilePathAndPresettingSilentFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetLastErrorDelegate(IntPtr thisPtr, IntPtr aErrorCode);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ExportBtlDelegate(IntPtr thisPtr, uint aBtlVersion, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ExportWeinmannMfbDelegate(IntPtr thisPtr, uint aMfbVersion);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ExportHundeggerDelegate(IntPtr thisPtr, uint aHundeggerType);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ClearErrorsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ExportHundeggerWithFilePathDelegate(IntPtr thisPtr, uint aHundeggerType, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ExportHundeggerWithFilePathAndPresettingDelegate(IntPtr thisPtr, uint aHundeggerType, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath, [MarshalAs(UnmanagedType.LPWStr)] string aPresetting);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ExportBtlWithPresettingDelegate(IntPtr thisPtr, uint aBtlVersion, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath, [MarshalAs(UnmanagedType.LPWStr)] string aPresetting);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void CalculateBtlMachineDataDelegate(IntPtr thisPtr, IntPtr aElements, uint aBtlVersion);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void CalculateHundeggerMachineDataDelegate(IntPtr thisPtr, IntPtr aElements, uint aHunderggerType);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void LoadHundeggerCalculationSetDelegate(IntPtr thisPtr, uint aHundeggerType, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetElementHundeggerProcessesDelegate(IntPtr thisPtr, ulong aElementId, uint aHundeggerType);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetElementBtlProcessesDelegate(IntPtr thisPtr, ulong aElementId, uint aBtlVersion);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetProcessingNameDelegate(IntPtr thisPtr, ulong aReferenceElementId, ulong aProcessingId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetProcessingCodeDelegate(IntPtr thisPtr, ulong aReferenceElementId, ulong aProcessingId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetProcessingPointsDelegate(IntPtr thisPtr, ulong aReferenceElementId, ulong aProcessingId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetProcessingBtlParameterSetDelegate(IntPtr thisPtr, ulong aReferenceElementId, ulong aProcessingId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ExportHundeggerWithFilePathSilentDelegate(IntPtr thisPtr, uint aHundeggerType, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ExportHundeggerWithFilePathAndPresettingSilentDelegate(IntPtr thisPtr, uint aHundeggerType, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath, [MarshalAs(UnmanagedType.LPWStr)] string aPresetting);
}
