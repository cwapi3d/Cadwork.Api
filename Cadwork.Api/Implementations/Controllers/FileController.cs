// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Extensions;
using Cadwork.Api.Implementations.Helpers;
using Cadwork.Api.Interfaces.Controllers;
using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Interop.Wrappers.Controllers;
using Cadwork.Api.Interop.Wrappers.Factories;
using Cadwork.Api.Structs;

namespace Cadwork.Api.Implementations.Controllers;

using ElementId = ulong;

internal class FileController(ControllerFactoryWrapper factoryWrapper) : IFileController
{
  private readonly FileControllerWrapper _controllerWrapper = new(factoryWrapper.GetFileController());

  public ElementId ImportElementLight(string fileName, Vec3 insertionPosition)
  {
    return _controllerWrapper.ImportElementLight(fileName, insertionPosition.ToNativeVector());
  }

  public ICollection<ulong> Import3dcFile(string fileName)
  {
    return _controllerWrapper.Import3dcFile(fileName).ToManagedElementIdList();
  }

  public ICollection<ulong> Import3dcFileWithGlide(string fileName)
  {
    return _controllerWrapper.Import3dcFileWithGlide(fileName).ToManagedElementIdList();
  }

  public ICollection<ulong> Import3dcFileWithOptions(string fileName, ImportOptions importOptions)
  {
    return _controllerWrapper.Import3dcFileWithOptions(fileName, importOptions.ToNativeImportOptions(factoryWrapper)).ToManagedElementIdList();
  }

  public ICollection<ulong> ImportBxfFile(string fileName, Vec3 insertionPosition)
  {
    return _controllerWrapper.ImportBxfFile(fileName, insertionPosition.ToNativeVector()).ToManagedElementIdList();
  }

  public ICollection<ulong> ImportRhinoFile(string fileName, bool withoutDialog)
  {
    return _controllerWrapper.ImportRhinoFile(fileName, withoutDialog).ToManagedElementIdList();
  }

  public ICollection<ulong> ImportSatFile(string fileName, double scalingFactor, bool useBinary)
  {
    return _controllerWrapper.ImportSatFile(fileName, scalingFactor, useBinary).ToManagedElementIdList();
  }

  public ICollection<ulong> ImportSatFileSilently(string fileName, double scalingFactor, bool useBinary)
  {
    return _controllerWrapper.ImportSatFileSilently(fileName, scalingFactor, useBinary).ToManagedElementIdList();
  }

  public ICollection<ulong> ImportStepFile(string fileName, double scalingFactor)
  {
    return _controllerWrapper.ImportStepFile(fileName, scalingFactor).ToManagedElementIdList();
  }

  public ICollection<ulong> ImportStepFileWithMessageOption(string fileName, double scalingFactor, bool hideMessages)
  {
    return _controllerWrapper.ImportStepFileWithMessageOption(fileName, scalingFactor, hideMessages).ToManagedElementIdList();
  }

  public ICollection<ulong> ImportVariantFile(string fileName, Vec3 insertionPosition)
  {
    return _controllerWrapper.ImportVariantFile(fileName, insertionPosition.ToNativeVector()).ToManagedElementIdList();
  }

  public IError GetLastError()
  {
    const int errorCode = 0;
    var errorMessage = _controllerWrapper.GetLastError(errorCode);
    return new Error { Code = errorCode, Message = errorMessage.ToManagedString() };
  }

  public bool Export3dFile(ICollection<ulong> elementIds, string fileName)
  {
    return _controllerWrapper.Export3dFile(elementIds.ToNativeElementIdList(factoryWrapper), fileName);
  }

  public bool ExportWebGl(ICollection<ulong> elementIds, string fileName)
  {
    return _controllerWrapper.ExportWebGl(elementIds.ToNativeElementIdList(factoryWrapper), fileName);
  }

  public string GetBlumExportPath()
  {
    return _controllerWrapper.GetBlumExportPath().ToManagedString();
  }

  public void ClearErrors()
  {
    _controllerWrapper.ClearErrors();
  }

  public void Export3dcFile(ICollection<ulong> elementIds, string fileName)
  {
    _controllerWrapper.Export3DcFile(elementIds.ToNativeElementIdList(factoryWrapper), fileName);
  }

  public void ExportBtlFileForNesting(string fileName)
  {
    _controllerWrapper.ExportBtlFileForNesting(fileName);
  }

  public void ExportFbxFile(ICollection<ulong> elementIds, string fileName, FbxFormat format)
  {
    _controllerWrapper.ExportFbxFile(elementIds.ToNativeElementIdList(factoryWrapper), fileName, format.ToNativeFbxFormat());
  }

  public void ExportGlbFile(ICollection<ulong> elementIds, string fileName)
  {
    _controllerWrapper.ExportGlbFile(elementIds.ToNativeElementIdList(factoryWrapper), fileName);
  }

  public void ExportObjFile(ICollection<ulong> elementIds, string fileName)
  {
    _controllerWrapper.ExportObjFile(elementIds.ToNativeElementIdList(factoryWrapper), fileName);
  }

  public void ExportRhinoFile(ICollection<ulong> elementIds, string fileName, int version, bool useDefaultAssignments, bool writeStandardAttributes)
  {
    _controllerWrapper.ExportRhinoFile(elementIds.ToNativeElementIdList(factoryWrapper), fileName, version, useDefaultAssignments, writeStandardAttributes);
  }

  public void ExportRhinoFileWithOptions(ICollection<ulong> elementIds, string fileName, int version, bool useDefaultAssignments, bool writeStandardAttributes, RhinoOptions rhinoOptions)
  {
    _controllerWrapper.ExportRhinoFileWithOptions(elementIds.ToNativeElementIdList(factoryWrapper), fileName, version, useDefaultAssignments, writeStandardAttributes, rhinoOptions.ToNativeRhinoOptions(factoryWrapper));
  }

  public void ExportSatFile(ICollection<ulong> elementIds, string fileName, double scalingFactor, bool useBinary, int version)
  {
    _controllerWrapper.ExportSatFile(elementIds.ToNativeElementIdList(factoryWrapper), fileName, scalingFactor, useBinary, version);
  }

  public void ExportSatFileCutDrillingAxes(ICollection<ulong> elementIds, string fileName, double scalingFactor, bool useBinary, int version)
  {
    _controllerWrapper.ExportSatFileCutDrillings(elementIds.ToNativeElementIdList(factoryWrapper), fileName, scalingFactor, useBinary, version);
  }

  public void ExportStepFile(ICollection<ulong> elementIds, string fileName, double scalingFactor, int version, bool useTextMode)
  {
    _controllerWrapper.ExportStepFile(elementIds.ToNativeElementIdList(factoryWrapper), fileName, scalingFactor, version, useTextMode);
  }

  public void ExportStepFileExtrudeDrillingAxes(ICollection<ulong> elementIds, string fileName, double scalingFactor, int version, bool useTextMode, bool useImperialUnits)
  {
    _controllerWrapper.ExportStepFileExtrudeDrillings(elementIds.ToNativeElementIdList(factoryWrapper), fileName, scalingFactor, version, useTextMode, useImperialUnits);
  }

  public void ExportStlFile(ICollection<ulong> elementIds, string fileName)
  {
    _controllerWrapper.ExportStlFile(elementIds.ToNativeElementIdList(factoryWrapper), fileName);
  }

  public void Import3dzFile(string fileName)
  {
    _controllerWrapper.Import3DzFile(fileName);
  }

  public void ImportBtlFile(string fileName)
  {
    _controllerWrapper.ImportBtlFile(fileName);
  }

  public void ImportBtlFileForNesting(string fileName)
  {
    _controllerWrapper.ImportBtlFileForNesting(fileName);
  }

  public void LoadWebGlPresetFile(string fileName)
  {
    _controllerWrapper.LoadWebGlPresetFile(fileName);
  }

  public void SetBlumExportPath(string path)
  {
    _controllerWrapper.SetBlumExportPath(path);
  }

  public void SetWebGlHierarchy(uint level, DisplayAttribute displayAttribute)
  {
    _controllerWrapper.SetWebGlHierarchy(level, displayAttribute.ToNativeDisplayAttribute(factoryWrapper));
  }
};
