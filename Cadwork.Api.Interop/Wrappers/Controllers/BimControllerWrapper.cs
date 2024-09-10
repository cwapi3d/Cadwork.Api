// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Controllers;

public class BimControllerWrapper
{
  private readonly IntPtr _nativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public BimControllerWrapper(IntPtr nativePtr)
  {
    _nativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<BimControllerInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(GetLastErrorDelegate), Marshal.GetDelegateForFunctionPointer<GetLastErrorDelegate>(vTable!.getLastErrorFunctionPtr) },
      { typeof(GetIfcGuidDelegate), Marshal.GetDelegateForFunctionPointer<GetIfcGuidDelegate>(vTable.getIfcGuidFunctionPtr) },
      { typeof(SetBuildingAndStoreyDelegate), Marshal.GetDelegateForFunctionPointer<SetBuildingAndStoreyDelegate>(vTable.setBuildingAndStoreyFunctionPtr) },
      { typeof(GetBuildingDelegate), Marshal.GetDelegateForFunctionPointer<GetBuildingDelegate>(vTable.getBuildingFunctionPtr) },
      { typeof(GetStoreyDelegate), Marshal.GetDelegateForFunctionPointer<GetStoreyDelegate>(vTable.getStoreyFunctionPtr) },
      { typeof(ClearErrorsDelegate), Marshal.GetDelegateForFunctionPointer<ClearErrorsDelegate>(vTable.clearErrorsFunctionPtr) },
      { typeof(GetIfc2X3ElementTypeDelegate), Marshal.GetDelegateForFunctionPointer<GetIfc2X3ElementTypeDelegate>(vTable.getIfc2x3ElementTypeFunctionPtr) },
      { typeof(SetIfc2X3ElementTypeDelegate), Marshal.GetDelegateForFunctionPointer<SetIfc2X3ElementTypeDelegate>(vTable.setIfc2x3ElementTypeFunctionPtr) },
      { typeof(ImportIfcAsGraphicalObjectDelegate), Marshal.GetDelegateForFunctionPointer<ImportIfcAsGraphicalObjectDelegate>(vTable.importIfcAsGraphicalObjectFunctionPtr) },
      { typeof(ImportBcfDelegate), Marshal.GetDelegateForFunctionPointer<ImportBcfDelegate>(vTable.importBcfFunctionPtr) },
      { typeof(ExportBcfDelegate), Marshal.GetDelegateForFunctionPointer<ExportBcfDelegate>(vTable.exportBcfFunctionPtr) },
      { typeof(ExportIfcDelegate), Marshal.GetDelegateForFunctionPointer<ExportIfcDelegate>(vTable.exportIfcFunctionPtr) },
      { typeof(ImportIfcReturnExchangeObjectsDelegate), Marshal.GetDelegateForFunctionPointer<ImportIfcReturnExchangeObjectsDelegate>(vTable.importIfcReturnExchangeObjectsFunctionPtr) },
      { typeof(ConvertExchangeObjectsDelegate), Marshal.GetDelegateForFunctionPointer<ConvertExchangeObjectsDelegate>(vTable.convertExchangeObjectsFunctionPtr) },
      { typeof(GetStoreyHeightDelegate), Marshal.GetDelegateForFunctionPointer<GetStoreyHeightDelegate>(vTable.getStoreyHeightFunctionPtr) },
      { typeof(SetStoreyHeightDelegate), Marshal.GetDelegateForFunctionPointer<SetStoreyHeightDelegate>(vTable.setStoreyHeightFunctionPtr) },
      { typeof(GetIfc2X3ElementTypeStringDelegate), Marshal.GetDelegateForFunctionPointer<GetIfc2X3ElementTypeStringDelegate>(vTable.getIfc2x3ElementTypeStringFunctionPtr) },
      { typeof(GetIfc2X3ElementTypeDisplayStringDelegate), Marshal.GetDelegateForFunctionPointer<GetIfc2X3ElementTypeDisplayStringDelegate>(vTable.getIfc2x3ElementTypeDisplayStringFunctionPtr) },
      { typeof(GetAllBuildingsDelegate), Marshal.GetDelegateForFunctionPointer<GetAllBuildingsDelegate>(vTable.getAllBuildingsFunctionPtr) },
      { typeof(GetAllStoreysDelegate), Marshal.GetDelegateForFunctionPointer<GetAllStoreysDelegate>(vTable.getAllStoreysFunctionPtr) },
      { typeof(ExportIfc2X3SilentlyDelegate), Marshal.GetDelegateForFunctionPointer<ExportIfc2X3SilentlyDelegate>(vTable.exportIfc2x3SilentlyFunctionPtr) },
      { typeof(ExportIfc4SilentlyDelegate), Marshal.GetDelegateForFunctionPointer<ExportIfc4SilentlyDelegate>(vTable.exportIfc4SilentlyFunctionPtr) },
      { typeof(ExportIfc4SilentlyWithOptionsDelegate), Marshal.GetDelegateForFunctionPointer<ExportIfc4SilentlyWithOptionsDelegate>(vTable.exportIfc4SilentlyWithOptionsFunctionPtr) },
      { typeof(ExportIfc2X3SilentlyWithOptionsDelegate), Marshal.GetDelegateForFunctionPointer<ExportIfc2X3SilentlyWithOptionsDelegate>(vTable.exportIfc2x3SilentlyWithOptionsFunctionPtr) },
      { typeof(GetElementIdFromIfcBase64GuidDelegate), Marshal.GetDelegateForFunctionPointer<GetElementIdFromIfcBase64GuidDelegate>(vTable.getElementIdFromIfcBase64GuidFunctionPtr) },
      { typeof(GetIfcBase64GuidDelegate), Marshal.GetDelegateForFunctionPointer<GetIfcBase64GuidDelegate>(vTable.getIfcBase64GuidFunctionPtr) },
      { typeof(UpdateBmtStructureCreatedElementsDelegate), Marshal.GetDelegateForFunctionPointer<UpdateBmtStructureCreatedElementsDelegate>(vTable.updateBmtStructureCreatedElementsFunctionPtr) },
      { typeof(UpdateBmtStructureBuildingStoreyDelegate), Marshal.GetDelegateForFunctionPointer<UpdateBmtStructureBuildingStoreyDelegate>(vTable.updateBmtStructureBuildingStoreyFunctionPtr) },
      { typeof(GetIfcOptionsDelegate), Marshal.GetDelegateForFunctionPointer<GetIfcOptionsDelegate>(vTable.getIfcOptionsFunctionPtr) },
      { typeof(GetIfcPredefinedTypeDelegate), Marshal.GetDelegateForFunctionPointer<GetIfcPredefinedTypeDelegate>(vTable.getIfcPredefinedTypeFunctionPtr) },
      { typeof(SetIfcPredefinedTypeDelegate), Marshal.GetDelegateForFunctionPointer<SetIfcPredefinedTypeDelegate>(vTable.setIfcPredefinedTypeFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public IntPtr GetLastError(IntPtr aErrorCode) => GetDelegate<GetLastErrorDelegate>().Invoke(_nativePtr, aErrorCode);
  public IntPtr GetIfcGuid(ulong aId) => GetDelegate<GetIfcGuidDelegate>().Invoke(_nativePtr, aId);
  public void SetBuildingAndStorey(IntPtr aElementIdList, string aBuilding, string aStorey) => GetDelegate<SetBuildingAndStoreyDelegate>().Invoke(_nativePtr, aElementIdList, aBuilding, aStorey);
  public IntPtr GetBuilding(ulong aElement) => GetDelegate<GetBuildingDelegate>().Invoke(_nativePtr, aElement);
  public IntPtr GetStorey(ulong aElement) => GetDelegate<GetStoreyDelegate>().Invoke(_nativePtr, aElement);
  public void ClearErrors() => GetDelegate<ClearErrorsDelegate>().Invoke(_nativePtr);
  public IntPtr GetIfc2X3ElementType(ulong aElementId) => GetDelegate<GetIfc2X3ElementTypeDelegate>().Invoke(_nativePtr, aElementId);
  public void SetIfc2X3ElementType(IntPtr aElementIDs, IntPtr aElementType) => GetDelegate<SetIfc2X3ElementTypeDelegate>().Invoke(_nativePtr, aElementIDs, aElementType);
  public bool ImportIfcAsGraphicalObject(string aFilePath) => GetDelegate<ImportIfcAsGraphicalObjectDelegate>().Invoke(_nativePtr, aFilePath);
  public bool ImportBcf(string aFilePath) => GetDelegate<ImportBcfDelegate>().Invoke(_nativePtr, aFilePath);
  public bool ExportBcf(string aFilePath) => GetDelegate<ExportBcfDelegate>().Invoke(_nativePtr, aFilePath);
  public bool ExportIfc(IntPtr aElementIDs, string aFilePath) => GetDelegate<ExportIfcDelegate>().Invoke(_nativePtr, aElementIDs, aFilePath);
  public IntPtr ImportIfcReturnExchangeObjects(string aFilePath) => GetDelegate<ImportIfcReturnExchangeObjectsDelegate>().Invoke(_nativePtr, aFilePath);
  public IntPtr ConvertExchangeObjects(IntPtr aExchangeObjects) => GetDelegate<ConvertExchangeObjectsDelegate>().Invoke(_nativePtr, aExchangeObjects);
  public double GetStoreyHeight(string aBuilding, string aStorey) => GetDelegate<GetStoreyHeightDelegate>().Invoke(_nativePtr, aBuilding, aStorey);
  public void SetStoreyHeight(string aBuilding, string aStorey, double aHeight) => GetDelegate<SetStoreyHeightDelegate>().Invoke(_nativePtr, aBuilding, aStorey, aHeight);
  public IntPtr GetIfc2X3ElementTypeString(IntPtr aElementType) => GetDelegate<GetIfc2X3ElementTypeStringDelegate>().Invoke(_nativePtr, aElementType);
  public IntPtr GetIfc2X3ElementTypeDisplayString(IntPtr aElementType) => GetDelegate<GetIfc2X3ElementTypeDisplayStringDelegate>().Invoke(_nativePtr, aElementType);
  public IntPtr GetAllBuildings() => GetDelegate<GetAllBuildingsDelegate>().Invoke(_nativePtr);
  public IntPtr GetAllStoreys(string aBuilding) => GetDelegate<GetAllStoreysDelegate>().Invoke(_nativePtr, aBuilding);
  public bool ExportIfc2X3Silently(IntPtr aElementIDs, string aFilePath) => GetDelegate<ExportIfc2X3SilentlyDelegate>().Invoke(_nativePtr, aElementIDs, aFilePath);
  public bool ExportIfc4Silently(IntPtr aElementIDs, string aFilePath) => GetDelegate<ExportIfc4SilentlyDelegate>().Invoke(_nativePtr, aElementIDs, aFilePath);
  public bool ExportIfc4SilentlyWithOptions(IntPtr aElementIDs, string aFilePath, IntPtr aOptions) => GetDelegate<ExportIfc4SilentlyWithOptionsDelegate>().Invoke(_nativePtr, aElementIDs, aFilePath, aOptions);
  public bool ExportIfc2X3SilentlyWithOptions(IntPtr aElementIDs, string aFilePath, IntPtr aOptions) => GetDelegate<ExportIfc2X3SilentlyWithOptionsDelegate>().Invoke(_nativePtr, aElementIDs, aFilePath, aOptions);
  public ulong GetElementIdFromIfcBase64Guid(string aGuid) => GetDelegate<GetElementIdFromIfcBase64GuidDelegate>().Invoke(_nativePtr, aGuid);
  public IntPtr GetIfcBase64Guid(ulong aElementId) => GetDelegate<GetIfcBase64GuidDelegate>().Invoke(_nativePtr, aElementId);
  public void UpdateBmtStructureCreatedElements(IntPtr aElementIDs) => GetDelegate<UpdateBmtStructureCreatedElementsDelegate>().Invoke(_nativePtr, aElementIDs);
  public void UpdateBmtStructureBuildingStorey(IntPtr aElementIDs) => GetDelegate<UpdateBmtStructureBuildingStoreyDelegate>().Invoke(_nativePtr, aElementIDs);
  public IntPtr GetIfcOptions() => GetDelegate<GetIfcOptionsDelegate>().Invoke(_nativePtr);
  public IntPtr GetIfcPredefinedType(ulong aElementId) => GetDelegate<GetIfcPredefinedTypeDelegate>().Invoke(_nativePtr, aElementId);
  public void SetIfcPredefinedType(IntPtr aElementIDs, IntPtr aPredefinedType) => GetDelegate<SetIfcPredefinedTypeDelegate>().Invoke(_nativePtr, aElementIDs, aPredefinedType);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class BimControllerInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr getLastErrorFunctionPtr;
    internal IntPtr getIfcGuidFunctionPtr;
    internal IntPtr setBuildingAndStoreyFunctionPtr;
    internal IntPtr getBuildingFunctionPtr;
    internal IntPtr getStoreyFunctionPtr;
    internal IntPtr clearErrorsFunctionPtr;
    internal IntPtr getIfc2x3ElementTypeFunctionPtr;
    internal IntPtr setIfc2x3ElementTypeFunctionPtr;
    internal IntPtr importIfcAsGraphicalObjectFunctionPtr;
    internal IntPtr importBcfFunctionPtr;
    internal IntPtr exportBcfFunctionPtr;
    internal IntPtr exportIfcFunctionPtr;
    internal IntPtr importIfcReturnExchangeObjectsFunctionPtr;
    internal IntPtr convertExchangeObjectsFunctionPtr;
    internal IntPtr getStoreyHeightFunctionPtr;
    internal IntPtr setStoreyHeightFunctionPtr;
    internal IntPtr getIfc2x3ElementTypeStringFunctionPtr;
    internal IntPtr getIfc2x3ElementTypeDisplayStringFunctionPtr;
    internal IntPtr getAllBuildingsFunctionPtr;
    internal IntPtr getAllStoreysFunctionPtr;
    internal IntPtr exportIfc2x3SilentlyFunctionPtr;
    internal IntPtr exportIfc4SilentlyFunctionPtr;
    internal IntPtr exportIfc4SilentlyWithOptionsFunctionPtr;
    internal IntPtr exportIfc2x3SilentlyWithOptionsFunctionPtr;
    internal IntPtr getElementIdFromIfcBase64GuidFunctionPtr;
    internal IntPtr getIfcBase64GuidFunctionPtr;
    internal IntPtr updateBmtStructureCreatedElementsFunctionPtr;
    internal IntPtr updateBmtStructureBuildingStoreyFunctionPtr;
    internal IntPtr getIfcOptionsFunctionPtr;
    internal IntPtr getIfcPredefinedTypeFunctionPtr;
    internal IntPtr setIfcPredefinedTypeFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetLastErrorDelegate(IntPtr thisPtr, IntPtr aErrorCode);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetIfcGuidDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetBuildingAndStoreyDelegate(IntPtr thisPtr, IntPtr aElementIdList, [MarshalAs(UnmanagedType.LPWStr)] string aBuilding, [MarshalAs(UnmanagedType.LPWStr)] string aStorey);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetBuildingDelegate(IntPtr thisPtr, ulong aElement);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetStoreyDelegate(IntPtr thisPtr, ulong aElement);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ClearErrorsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetIfc2X3ElementTypeDelegate(IntPtr thisPtr, ulong aElementId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIfc2X3ElementTypeDelegate(IntPtr thisPtr, IntPtr aElementIDs, IntPtr aElementType);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool ImportIfcAsGraphicalObjectDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool ImportBcfDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool ExportBcfDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool ExportIfcDelegate(IntPtr thisPtr, IntPtr aElementIDs, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr ImportIfcReturnExchangeObjectsDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr ConvertExchangeObjectsDelegate(IntPtr thisPtr, IntPtr aExchangeObjects);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetStoreyHeightDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aBuilding, [MarshalAs(UnmanagedType.LPWStr)] string aStorey);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetStoreyHeightDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aBuilding, [MarshalAs(UnmanagedType.LPWStr)] string aStorey, double aHeight);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetIfc2X3ElementTypeStringDelegate(IntPtr thisPtr, IntPtr aElementType);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetIfc2X3ElementTypeDisplayStringDelegate(IntPtr thisPtr, IntPtr aElementType);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAllBuildingsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAllStoreysDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aBuilding);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool ExportIfc2X3SilentlyDelegate(IntPtr thisPtr, IntPtr aElementIDs, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool ExportIfc4SilentlyDelegate(IntPtr thisPtr, IntPtr aElementIDs, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool ExportIfc4SilentlyWithOptionsDelegate(IntPtr thisPtr, IntPtr aElementIDs, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath, IntPtr aOptions);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool ExportIfc2X3SilentlyWithOptionsDelegate(IntPtr thisPtr, IntPtr aElementIDs, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath, IntPtr aOptions);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong GetElementIdFromIfcBase64GuidDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aGuid);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetIfcBase64GuidDelegate(IntPtr thisPtr, ulong aElementId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void UpdateBmtStructureCreatedElementsDelegate(IntPtr thisPtr, IntPtr aElementIDs);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void UpdateBmtStructureBuildingStoreyDelegate(IntPtr thisPtr, IntPtr aElementIDs);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetIfcOptionsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetIfcPredefinedTypeDelegate(IntPtr thisPtr, ulong aElementId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIfcPredefinedTypeDelegate(IntPtr thisPtr, IntPtr aElementIDs, IntPtr aPredefinedType);
}
