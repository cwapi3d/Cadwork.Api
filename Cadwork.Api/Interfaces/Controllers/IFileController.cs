// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Structs;

namespace Cadwork.Api.Interfaces.Controllers;

using ElementId = ulong;

/// <summary>
///
/// </summary>
public interface IFileController
{
  /// <summary>
  ///
  /// </summary>
  /// <param name="fileName"></param>
  /// <param name="insertionPosition"></param>
  /// <returns></returns>
  ElementId ImportElementLight(string fileName, Vec3 insertionPosition);

  /// <summary>
  ///
  /// </summary>
  /// <param name="fileName"></param>
  /// <returns></returns>
  ICollection<ElementId> Import3dcFile(string fileName);

  /// <summary>
  ///
  /// </summary>
  /// <param name="fileName"></param>
  /// <returns></returns>
  ICollection<ElementId> Import3dcFileWithGlide(string fileName);

  /// <summary>
  ///
  /// </summary>
  /// <param name="fileName"></param>
  /// <param name="import3dcOptions"></param>
  /// <returns></returns>
  ICollection<ElementId> Import3dcFileWithOptions(string fileName, ImportOptions importOptions);

  /// <summary>
  ///
  /// </summary>
  /// <param name="fileName"></param>
  /// <param name="insertionPosition"></param>
  /// <returns></returns>
  ICollection<ElementId> ImportBxfFile(string fileName, Vec3 insertionPosition);

  /// <summary>
  ///
  /// </summary>
  /// <param name="fileName"></param>
  /// <param name="withoutDialog"></param>
  /// <returns></returns>
  ICollection<ElementId> ImportRhinoFile(string fileName, bool withoutDialog);

  /// <summary>
  ///
  /// </summary>
  /// <param name="fileName"></param>
  /// <param name="scalingFactor"></param>
  /// <param name="useBinary"></param>
  /// <returns></returns>
  ICollection<ElementId> ImportSatFile(string fileName, double scalingFactor, bool useBinary);

  /// <summary>
  ///
  /// </summary>
  /// <param name="fileName"></param>
  /// <param name="scalingFactor"></param>
  /// <param name="useBinary"></param>
  /// <returns></returns>
  ICollection<ElementId> ImportSatFileSilently(string fileName, double scalingFactor, bool useBinary);

  /// <summary>
  ///
  /// </summary>
  /// <param name="fileName"></param>
  /// <param name="scalingFactor"></param>
  /// <returns></returns>
  ICollection<ElementId> ImportStepFile(string fileName, double scalingFactor);

  /// <summary>
  ///
  /// </summary>
  /// <param name="fileName"></param>
  /// <param name="scalingFactor"></param>
  /// <param name="hideMessages"></param>
  /// <returns></returns>
  ICollection<ElementId> ImportStepFileWithMessageOption(string fileName, double scalingFactor, bool hideMessages);

  /// <summary>
  ///
  /// </summary>
  /// <param name="fileName"></param>
  /// <param name="insertionPosition"></param>
  /// <returns></returns>
  ICollection<ElementId> ImportVariantFile(string fileName, Vec3 insertionPosition);

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  IError GetLastError();

  /// <summary>
  ///
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="fileName"></param>
  /// <returns></returns>
  bool Export3dFile(ICollection<ElementId> elementIds, string fileName);

  /// <summary>
  ///
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="fileName"></param>
  /// <returns></returns>
  bool ExportWebGl(ICollection<ElementId> elementIds, string fileName);

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  string GetBlumExportPath();

  /// <summary>
  ///
  /// </summary>
  void ClearErrors();

  /// <summary>
  ///
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="fileName"></param>
  void Export3dcFile(ICollection<ElementId> elementIds, string fileName);

  /// <summary>
  ///
  /// </summary>
  /// <param name="fileName"></param>
  void ExportBtlFileForNesting(string fileName);

  /// <summary>
  ///
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="fileName"></param>
  /// <param name="format"></param>
  void ExportFbxFile(ICollection<ElementId> elementIds, string fileName, FbxFormat format);

  /// <summary>
  ///
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="fileName"></param>
  void ExportGlbFile(ICollection<ElementId> elementIds, string fileName);

  /// <summary>
  ///
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="fileName"></param>
  void ExportObjFile(ICollection<ElementId> elementIds, string fileName);

  /// <summary>
  ///
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="fileName"></param>
  /// <param name="version"></param>
  /// <param name="useDefaultAssignments"></param>
  /// <param name="writeStandardAttributes"></param>
  void ExportRhinoFile(ICollection<ElementId> elementIds, string fileName, int version, bool useDefaultAssignments, bool writeStandardAttributes);

  /// <summary>
  ///
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="fileName"></param>
  /// <param name="version"></param>
  /// <param name="useDefaultAssignments"></param>
  /// <param name="writeStandardAttributes"></param>
  /// <param name="rhinoOptions"></param>
  void ExportRhinoFileWithOptions(ICollection<ElementId> elementIds, string fileName, int version, bool useDefaultAssignments, bool writeStandardAttributes, RhinoOptions rhinoOptions);

  /// <summary>
  ///
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="fileName"></param>
  /// <param name="scalingFactor"></param>
  /// <param name="useBinary"></param>
  /// <param name="version"></param>
  void ExportSatFile(ICollection<ElementId> elementIds, string fileName, double scalingFactor, bool useBinary, int version);

  /// <summary>
  ///
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="fileName"></param>
  /// <param name="scalingFactor"></param>
  /// <param name="useBinary"></param>
  /// <param name="version"></param>
  void ExportSatFileCutDrillingAxes(ICollection<ElementId> elementIds, string fileName, double scalingFactor, bool useBinary, int version);

  /// <summary>
  ///
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="fileName"></param>
  /// <param name="scalingFactor"></param>
  /// <param name="version"></param>
  /// <param name="useTextMode"></param>
  void ExportStepFile(ICollection<ElementId> elementIds, string fileName, double scalingFactor, int version, bool useTextMode);

  /// <summary>
  ///
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="fileName"></param>
  /// <param name="scalingFactor"></param>
  /// <param name="version"></param>
  /// <param name="useTextMode"></param>
  /// <param name="useImperialUnits"></param>
  void ExportStepFileExtrudeDrillingAxes(ICollection<ElementId> elementIds, string fileName, double scalingFactor, int version, bool useTextMode, bool useImperialUnits);

  /// <summary>
  ///
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="fileName"></param>
  void ExportStlFile(ICollection<ElementId> elementIds, string fileName);

  /// <summary>
  ///
  /// </summary>
  /// <param name="fileName"></param>
  void Import3dzFile(string fileName);

  /// <summary>
  ///
  /// </summary>
  /// <param name="fileName"></param>
  void ImportBtlFile(string fileName);

  /// <summary>
  ///
  /// </summary>
  /// <param name="fileName"></param>
  void ImportBtlFileForNesting(string fileName);

  /// <summary>
  ///
  /// </summary>
  /// <param name="fileName"></param>
  void LoadWebGlPresetFile(string fileName);

  /// <summary>
  ///
  /// </summary>
  /// <param name="path"></param>
  void SetBlumExportPath(string path);

  /// <summary>
  ///
  /// </summary>
  /// <param name="level"></param>
  /// <param name="displayAttribute"></param>
  void SetWebGlHierarchy(uint level, DisplayAttribute displayAttribute);
};
