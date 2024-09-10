// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Structs;

namespace Cadwork.Api.Interfaces.Controllers;

using ElementId = ulong;

/// <summary>
/// 
/// </summary>
public interface IShopDrawingController
{
  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  IError GetLastError();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="position"></param>
  void AddWallSectionHorizontal(ElementId elementId, Vec3 position);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="position"></param>
  void AddWallSectionVertical(ElementId elementId, Vec3 position);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="exportSolidElementIds"></param>
  /// <param name="elementIds"></param>
  void AssignToExportSolid(ICollection<ElementId> exportSolidElementIds, ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  void ClearErrors();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="aFilePath"></param>
  /// <param name="withLayout"></param>
  void Export2dHiddenLinesWith2dc(string aFilePath, bool withLayout);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="clipboardNumber"></param>
  /// <param name="withLayout"></param>
  void Export2dHiddenLinesWithClipboard(uint clipboardNumber, bool withLayout);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="aFilePath"></param>
  /// <param name="withLayout"></param>
  void Export2dWireframeWith2dc(string aFilePath, bool withLayout);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="clipboardNumber"></param>
  /// <param name="withLayout"></param>
  void Export2dWireframeWithClipboard(uint clipboardNumber, bool withLayout);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="clipboardNumber"></param>
  /// <param name="elementIds"></param>
  void ExportContainerWithClipboard(uint clipboardNumber, ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="clipboardNumber"></param>
  /// <param name="elementIds"></param>
  void ExportExportSolidWithClipboard(uint clipboardNumber, ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="clipboardNumber"></param>
  /// <param name="elementIds"></param>
  void ExportPieceByPieceWithClipboard(uint clipboardNumber, ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="clipboardNumber"></param>
  /// <param name="elementIds"></param>
  void ExportWallWithClipboard(uint clipboardNumber, ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="clipboardNumber"></param>
  /// <param name="elementIds"></param>
  /// <param name="settingsFileName"></param>
  void ExportWallWithClipboardAndSettings(uint clipboardNumber, ICollection<ElementId> elementIds, string settingsFileName);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="fileName"></param>
  void LoadExportContainerSettings(string fileName);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="fileName"></param>
  void LoadExportPieceByPieceSettings(string fileName);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="fileName"></param>
  void LoadExportSolidSettings(string fileName);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="fileName"></param>
  void LoadExportWallSettings(string fileName);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="fileName"></param>
  void SaveExportPieceByPieceSettings(string fileName);
};
