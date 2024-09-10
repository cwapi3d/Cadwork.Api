// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;
using Cadwork.Api.Interop.Wrappers.Structs;

namespace Cadwork.Api.Interop.Wrappers.Controllers;

public class FileControllerWrapper
{
  private readonly IntPtr _nativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public FileControllerWrapper(IntPtr nativePtr)
  {
    _nativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<FileControllerInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(GetLastErrorDelegate), Marshal.GetDelegateForFunctionPointer<GetLastErrorDelegate>(vTable!.getLastErrorFunctionPtr) },
      { typeof(ExportStlFileDelegate), Marshal.GetDelegateForFunctionPointer<ExportStlFileDelegate>(vTable.exportSTLFileFunctionPtr) },
      { typeof(ImportStepFileDelegate), Marshal.GetDelegateForFunctionPointer<ImportStepFileDelegate>(vTable.importStepFileFunctionPtr) },
      { typeof(ImportStepFileWithMessageOptionDelegate), Marshal.GetDelegateForFunctionPointer<ImportStepFileWithMessageOptionDelegate>(vTable.importStepFileWithMessageOptionFunctionPtr) },
      { typeof(ExportWebGlDelegate), Marshal.GetDelegateForFunctionPointer<ExportWebGlDelegate>(vTable.exportWebGlFunctionPtr) },
      { typeof(Export3dFileDelegate), Marshal.GetDelegateForFunctionPointer<Export3dFileDelegate>(vTable.export3dFileFunctionPtr) },
      { typeof(ImportSatFileDelegate), Marshal.GetDelegateForFunctionPointer<ImportSatFileDelegate>(vTable.importSATFileFunctionPtr) },
      { typeof(Import3dcFileDelegate), Marshal.GetDelegateForFunctionPointer<Import3dcFileDelegate>(vTable.import3dcFileFunctionPtr) },
      { typeof(ImportRhinoFileDelegate), Marshal.GetDelegateForFunctionPointer<ImportRhinoFileDelegate>(vTable.importRhinoFileFunctionPtr) },
      { typeof(ExportStepFileDelegate), Marshal.GetDelegateForFunctionPointer<ExportStepFileDelegate>(vTable.exportStepFileFunctionPtr) },
      { typeof(Import3DzFileDelegate), Marshal.GetDelegateForFunctionPointer<Import3DzFileDelegate>(vTable.import3DZFileFunctionPtr) },
      { typeof(ExportObjFileDelegate), Marshal.GetDelegateForFunctionPointer<ExportObjFileDelegate>(vTable.exportOBJFileFunctionPtr) },
      { typeof(ImportSatFileSilentlyDelegate), Marshal.GetDelegateForFunctionPointer<ImportSatFileSilentlyDelegate>(vTable.importSATFileSilentlyFunctionPtr) },
      { typeof(ExportFbxFileDelegate), Marshal.GetDelegateForFunctionPointer<ExportFbxFileDelegate>(vTable.exportFBXFileFunctionPtr) },
      { typeof(ClearErrorsDelegate), Marshal.GetDelegateForFunctionPointer<ClearErrorsDelegate>(vTable.clearErrorsFunctionPtr) },
      { typeof(Import3dcFileWithGlideDelegate), Marshal.GetDelegateForFunctionPointer<Import3dcFileWithGlideDelegate>(vTable.import3dcFileWithGlideFunctionPtr) },
      { typeof(ImportBtlFileDelegate), Marshal.GetDelegateForFunctionPointer<ImportBtlFileDelegate>(vTable.importBTLFileFunctionPtr) },
      { typeof(Export3DcFileDelegate), Marshal.GetDelegateForFunctionPointer<Export3DcFileDelegate>(vTable.export3DCFileFunctionPtr) },
      { typeof(ImportBtlFileForNestingDelegate), Marshal.GetDelegateForFunctionPointer<ImportBtlFileForNestingDelegate>(vTable.importBTLFileForNestingFunctionPtr) },
      { typeof(ExportBtlFileForNestingDelegate), Marshal.GetDelegateForFunctionPointer<ExportBtlFileForNestingDelegate>(vTable.exportBTLFileForNestingFunctionPtr) },
      { typeof(ExportRhinoFileDelegate), Marshal.GetDelegateForFunctionPointer<ExportRhinoFileDelegate>(vTable.exportRhinoFileFunctionPtr) },
      { typeof(ImportBxfFileDelegate), Marshal.GetDelegateForFunctionPointer<ImportBxfFileDelegate>(vTable.importBXFFileFunctionPtr) },
      { typeof(GetBlumExportPathDelegate), Marshal.GetDelegateForFunctionPointer<GetBlumExportPathDelegate>(vTable.getBlumExportPathFunctionPtr) },
      { typeof(SetBlumExportPathDelegate), Marshal.GetDelegateForFunctionPointer<SetBlumExportPathDelegate>(vTable.setBlumExportPathFunctionPtr) },
      { typeof(SetWebGlHierarchyDelegate), Marshal.GetDelegateForFunctionPointer<SetWebGlHierarchyDelegate>(vTable.setWebGLHierarchyFunctionPtr) },
      { typeof(ExportSatFileDelegate), Marshal.GetDelegateForFunctionPointer<ExportSatFileDelegate>(vTable.exportSATFileFunctionPtr) },
      { typeof(ExportGlbFileDelegate), Marshal.GetDelegateForFunctionPointer<ExportGlbFileDelegate>(vTable.exportGLBFileFunctionPtr) },
      { typeof(ImportVariantFileDelegate), Marshal.GetDelegateForFunctionPointer<ImportVariantFileDelegate>(vTable.importVariantFileFunctionPtr) },
      { typeof(ImportElementLightDelegate), Marshal.GetDelegateForFunctionPointer<ImportElementLightDelegate>(vTable.importElementLightFunctionPtr) },
      { typeof(ExportRhinoFileWithOptionsDelegate), Marshal.GetDelegateForFunctionPointer<ExportRhinoFileWithOptionsDelegate>(vTable.exportRhinoFileWithOptionsFunctionPtr) },
      { typeof(Import3dcFileWithOptionsDelegate), Marshal.GetDelegateForFunctionPointer<Import3dcFileWithOptionsDelegate>(vTable.import3dcFileWithOptionsFunctionPtr) },
      { typeof(LoadWebGlPresetFileDelegate), Marshal.GetDelegateForFunctionPointer<LoadWebGlPresetFileDelegate>(vTable.loadWebGlPresetFileFunctionPtr) },
      { typeof(ExportStepFileExtrudeDrillingsDelegate), Marshal.GetDelegateForFunctionPointer<ExportStepFileExtrudeDrillingsDelegate>(vTable.exportStepFileExtrudeDrillingsFunctionPtr) },
      { typeof(ExportSatFileCutDrillingsDelegate), Marshal.GetDelegateForFunctionPointer<ExportSatFileCutDrillingsDelegate>(vTable.exportSATFileCutDrillingsFunctionPtr) },
      { typeof(UploadToBimTeamAndCreateShareLinkDelegate), Marshal.GetDelegateForFunctionPointer<UploadToBimTeamAndCreateShareLinkDelegate>(vTable.uploadToBimTeamAndCreateShareLinkFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public IntPtr GetLastError(IntPtr aErrorCode) => GetDelegate<GetLastErrorDelegate>().Invoke(_nativePtr, aErrorCode);
  public void ExportStlFile(IntPtr aElementIdList, string aFilePath) => GetDelegate<ExportStlFileDelegate>().Invoke(_nativePtr, aElementIdList, aFilePath);
  public IntPtr ImportStepFile(string aFilePath, double aScaleFactor) => GetDelegate<ImportStepFileDelegate>().Invoke(_nativePtr, aFilePath, aScaleFactor);
  public IntPtr ImportStepFileWithMessageOption(string aFilePath, double aScaleFactor, bool aHideMessage) => GetDelegate<ImportStepFileWithMessageOptionDelegate>().Invoke(_nativePtr, aFilePath, aScaleFactor, aHideMessage);
  public bool ExportWebGl(IntPtr aElementIdList, string aFilePath) => GetDelegate<ExportWebGlDelegate>().Invoke(_nativePtr, aElementIdList, aFilePath);
  public bool Export3dFile(IntPtr aElementIdList, string aFilePath) => GetDelegate<Export3dFileDelegate>().Invoke(_nativePtr, aElementIdList, aFilePath);
  public IntPtr ImportSatFile(string aFilePath, double aScaleFactor, bool aBinary) => GetDelegate<ImportSatFileDelegate>().Invoke(_nativePtr, aFilePath, aScaleFactor, aBinary);
  public IntPtr Import3dcFile(string aFilePath) => GetDelegate<Import3dcFileDelegate>().Invoke(_nativePtr, aFilePath);
  public IntPtr ImportRhinoFile(string aFilePath, bool aWithoutDialog) => GetDelegate<ImportRhinoFileDelegate>().Invoke(_nativePtr, aFilePath, aWithoutDialog);
  public void ExportStepFile(IntPtr aElementList, string aFilePath, double aScaleFactor, int aVersion, bool aTextMode) => GetDelegate<ExportStepFileDelegate>().Invoke(_nativePtr, aElementList, aFilePath, aScaleFactor, aVersion, aTextMode);
  public void Import3DzFile(string aFilePath) => GetDelegate<Import3DzFileDelegate>().Invoke(_nativePtr, aFilePath);
  public void ExportObjFile(IntPtr aElements, string aFilePath) => GetDelegate<ExportObjFileDelegate>().Invoke(_nativePtr, aElements, aFilePath);
  public IntPtr ImportSatFileSilently(string aFilePath, double aScaleFactor, bool aBinary) => GetDelegate<ImportSatFileSilentlyDelegate>().Invoke(_nativePtr, aFilePath, aScaleFactor, aBinary);
  public void ExportFbxFile(IntPtr aElements, string aFilePath, uint aFbxFormat) => GetDelegate<ExportFbxFileDelegate>().Invoke(_nativePtr, aElements, aFilePath, aFbxFormat);
  public void ClearErrors() => GetDelegate<ClearErrorsDelegate>().Invoke(_nativePtr);
  public IntPtr Import3dcFileWithGlide(string aFilePath) => GetDelegate<Import3dcFileWithGlideDelegate>().Invoke(_nativePtr, aFilePath);
  public void ImportBtlFile(string aFilePath) => GetDelegate<ImportBtlFileDelegate>().Invoke(_nativePtr, aFilePath);
  public void Export3DcFile(IntPtr aElementIdList, string aFilePath) => GetDelegate<Export3DcFileDelegate>().Invoke(_nativePtr, aElementIdList, aFilePath);
  public void ImportBtlFileForNesting(string aFilePath) => GetDelegate<ImportBtlFileForNestingDelegate>().Invoke(_nativePtr, aFilePath);
  public void ExportBtlFileForNesting(string aFilePath) => GetDelegate<ExportBtlFileForNestingDelegate>().Invoke(_nativePtr, aFilePath);
  public void ExportRhinoFile(IntPtr aElementIdList, string aFilePath, int aVersion, bool aUseDefaultAssignment, bool aWriteStandardAttributes) => GetDelegate<ExportRhinoFileDelegate>().Invoke(_nativePtr, aElementIdList, aFilePath, aVersion, aUseDefaultAssignment, aWriteStandardAttributes);
  public IntPtr ImportBxfFile(string aFilePath, CVector3 aInsertPosition) => GetDelegate<ImportBxfFileDelegate>().Invoke(_nativePtr, aFilePath, aInsertPosition);
  public IntPtr GetBlumExportPath() => GetDelegate<GetBlumExportPathDelegate>().Invoke(_nativePtr);
  public void SetBlumExportPath(string aPath) => GetDelegate<SetBlumExportPathDelegate>().Invoke(_nativePtr, aPath);
  public void SetWebGlHierarchy(uint aStage, IntPtr aAttribute) => GetDelegate<SetWebGlHierarchyDelegate>().Invoke(_nativePtr, aStage, aAttribute);
  public void ExportSatFile(IntPtr aElements, string aFilePath, double aScaleFactor, bool aBinary, int aVersion) => GetDelegate<ExportSatFileDelegate>().Invoke(_nativePtr, aElements, aFilePath, aScaleFactor, aBinary, aVersion);
  public void ExportGlbFile(IntPtr aElements, string aFilePath) => GetDelegate<ExportGlbFileDelegate>().Invoke(_nativePtr, aElements, aFilePath);
  public IntPtr ImportVariantFile(string aFilePath, CVector3 aInsertPosition) => GetDelegate<ImportVariantFileDelegate>().Invoke(_nativePtr, aFilePath, aInsertPosition);
  public ulong ImportElementLight(string aFilePath, CVector3 aInsertPosition) => GetDelegate<ImportElementLightDelegate>().Invoke(_nativePtr, aFilePath, aInsertPosition);
  public void ExportRhinoFileWithOptions(IntPtr aElementIdList, string aFilePath, int aVersion, bool aUseDefaultAssignment, bool aWriteStandardAttributes, IntPtr aRhinoOptions) => GetDelegate<ExportRhinoFileWithOptionsDelegate>().Invoke(_nativePtr, aElementIdList, aFilePath, aVersion, aUseDefaultAssignment, aWriteStandardAttributes, aRhinoOptions);
  public IntPtr Import3dcFileWithOptions(string aFilePath, IntPtr aImport3dcOptions) => GetDelegate<Import3dcFileWithOptionsDelegate>().Invoke(_nativePtr, aFilePath, aImport3dcOptions);
  public void LoadWebGlPresetFile(string aFilePath) => GetDelegate<LoadWebGlPresetFileDelegate>().Invoke(_nativePtr, aFilePath);
  public void ExportStepFileExtrudeDrillings(IntPtr aElements, string aFilePath, double aScaleFactor, int aVersion, bool aTextMode, bool aImperialUnits) => GetDelegate<ExportStepFileExtrudeDrillingsDelegate>().Invoke(_nativePtr, aElements, aFilePath, aScaleFactor, aVersion, aTextMode, aImperialUnits);
  public void ExportSatFileCutDrillings(IntPtr aElements, string aFilePath, double aScaleFactor, bool aBinary, int aVersion) => GetDelegate<ExportSatFileCutDrillingsDelegate>().Invoke(_nativePtr, aElements, aFilePath, aScaleFactor, aBinary, aVersion);
  public CBimTeamUploadResult UploadToBimTeamAndCreateShareLink(IntPtr aElements) => GetDelegate<UploadToBimTeamAndCreateShareLinkDelegate>().Invoke(_nativePtr, aElements);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class FileControllerInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr getLastErrorFunctionPtr;
    internal IntPtr exportSTLFileFunctionPtr;
    internal IntPtr importStepFileFunctionPtr;
    internal IntPtr importStepFileWithMessageOptionFunctionPtr;
    internal IntPtr exportWebGlFunctionPtr;
    internal IntPtr export3dFileFunctionPtr;
    internal IntPtr importSATFileFunctionPtr;
    internal IntPtr import3dcFileFunctionPtr;
    internal IntPtr importRhinoFileFunctionPtr;
    internal IntPtr exportStepFileFunctionPtr;
    internal IntPtr import3DZFileFunctionPtr;
    internal IntPtr exportOBJFileFunctionPtr;
    internal IntPtr importSATFileSilentlyFunctionPtr;
    internal IntPtr exportFBXFileFunctionPtr;
    internal IntPtr clearErrorsFunctionPtr;
    internal IntPtr import3dcFileWithGlideFunctionPtr;
    internal IntPtr importBTLFileFunctionPtr;
    internal IntPtr export3DCFileFunctionPtr;
    internal IntPtr importBTLFileForNestingFunctionPtr;
    internal IntPtr exportBTLFileForNestingFunctionPtr;
    internal IntPtr exportRhinoFileFunctionPtr;
    internal IntPtr importBXFFileFunctionPtr;
    internal IntPtr getBlumExportPathFunctionPtr;
    internal IntPtr setBlumExportPathFunctionPtr;
    internal IntPtr setWebGLHierarchyFunctionPtr;
    internal IntPtr exportSATFileFunctionPtr;
    internal IntPtr exportGLBFileFunctionPtr;
    internal IntPtr importVariantFileFunctionPtr;
    internal IntPtr importElementLightFunctionPtr;
    internal IntPtr exportRhinoFileWithOptionsFunctionPtr;
    internal IntPtr import3dcFileWithOptionsFunctionPtr;
    internal IntPtr loadWebGlPresetFileFunctionPtr;
    internal IntPtr exportStepFileExtrudeDrillingsFunctionPtr;
    internal IntPtr exportSATFileCutDrillingsFunctionPtr;
    internal IntPtr uploadToBimTeamAndCreateShareLinkFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetLastErrorDelegate(IntPtr thisPtr, IntPtr aErrorCode);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ExportStlFileDelegate(IntPtr thisPtr, IntPtr aElementIdList, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr ImportStepFileDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath, double aScaleFactor);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr ImportStepFileWithMessageOptionDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath, double aScaleFactor, bool aHideMessage);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool ExportWebGlDelegate(IntPtr thisPtr, IntPtr aElementIdList, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool Export3dFileDelegate(IntPtr thisPtr, IntPtr aElementIdList, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr ImportSatFileDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath, double aScaleFactor, bool aBinary);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr Import3dcFileDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr ImportRhinoFileDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath, bool aWithoutDialog);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ExportStepFileDelegate(IntPtr thisPtr, IntPtr aElementList, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath, double aScaleFactor, int aVersion, bool aTextMode);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void Import3DzFileDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ExportObjFileDelegate(IntPtr thisPtr, IntPtr aElements, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr ImportSatFileSilentlyDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath, double aScaleFactor, bool aBinary);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ExportFbxFileDelegate(IntPtr thisPtr, IntPtr aElements, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath, uint aFbxFormat);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ClearErrorsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr Import3dcFileWithGlideDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ImportBtlFileDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void Export3DcFileDelegate(IntPtr thisPtr, IntPtr aElementIdList, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ImportBtlFileForNestingDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ExportBtlFileForNestingDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ExportRhinoFileDelegate(IntPtr thisPtr, IntPtr aElementIdList, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath, int aVersion, bool aUseDefaultAssignment, bool aWriteStandardAttributes);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr ImportBxfFileDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath, CVector3 aInsertPosition);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetBlumExportPathDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetBlumExportPathDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aPath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetWebGlHierarchyDelegate(IntPtr thisPtr, uint aStage, IntPtr aAttribute);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ExportSatFileDelegate(IntPtr thisPtr, IntPtr aElements, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath, double aScaleFactor, bool aBinary, int aVersion);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ExportGlbFileDelegate(IntPtr thisPtr, IntPtr aElements, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr ImportVariantFileDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath, CVector3 aInsertPosition);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong ImportElementLightDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath, CVector3 aInsertPosition);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ExportRhinoFileWithOptionsDelegate(IntPtr thisPtr, IntPtr aElementIdList, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath, int aVersion, bool aUseDefaultAssignment, bool aWriteStandardAttributes, IntPtr aRhinoOptions);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr Import3dcFileWithOptionsDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath, IntPtr aImport3dcOptions);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void LoadWebGlPresetFileDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ExportStepFileExtrudeDrillingsDelegate(IntPtr thisPtr, IntPtr aElements, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath, double aScaleFactor, int aVersion, bool aTextMode, bool aImperialUnits);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ExportSatFileCutDrillingsDelegate(IntPtr thisPtr, IntPtr aElements, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath, double aScaleFactor, bool aBinary, int aVersion);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate CBimTeamUploadResult UploadToBimTeamAndCreateShareLinkDelegate(IntPtr thisPtr, IntPtr aElements);
}
