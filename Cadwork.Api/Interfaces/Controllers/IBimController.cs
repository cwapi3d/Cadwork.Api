// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Interfaces.Helpers;

namespace Cadwork.Api.Interfaces.Controllers;

using ElementId = ulong;

/// <summary>
///
/// </summary>
public interface IBimController
{
  /// <summary>
  ///
  /// </summary>
  /// <param name="guid"></param>
  /// <returns></returns>
  ElementId GetElementIdFromIfcBase64Guid(string guid);

  /// <summary>
  ///
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  Guid GetIfcGuid(ElementId elementId);

  /// <summary>
  ///
  /// </summary>
  /// <param name="elementIds"></param>
  /// <returns></returns>
  ICollection<ElementId> ConvertExchangeObjects(ICollection<ElementId> elementIds);

  /// <summary>
  ///
  /// </summary>
  /// <param name="fileName"></param>
  /// <returns></returns>
  ICollection<ElementId> ImportIfcReturnExchangeObjects(string fileName);

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  ICollection<string> GetAllBuildings();

  /// <summary>
  ///
  /// </summary>
  /// <param name="building"></param>
  /// <returns></returns>
  ICollection<string> GetAllStoreys(string building);

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  IError GetLastError();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  IIfcOptions GetIfcOptions();

  /// <summary>
  ///
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  IfcElementType GetIfcElementType(ElementId elementId);

  /// <summary>
  ///
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  IfcPredefinedType GetIfcPredefinedType(ElementId elementId);

  /// <summary>
  ///
  /// </summary>
  /// <param name="fileName"></param>
  /// <returns></returns>
  bool ExportBcf(string fileName);

  /// <summary>
  ///
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="fileName"></param>
  /// <returns></returns>
  bool ExportIfc(ICollection<ElementId> elementIds, string fileName);

  /// <summary>
  ///
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="fileName"></param>
  /// <returns></returns>
  bool ExportIfc2x3Silently(ICollection<ElementId> elementIds, string fileName);

  /// <summary>
  ///
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="fileName"></param>
  /// <param name="options"></param>
  /// <returns></returns>
  bool ExportIfc2x3SilentlyWithOptions(ICollection<ElementId> elementIds, string fileName, IIfcOptions options);

  /// <summary>
  ///
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="fileName"></param>
  /// <returns></returns>
  bool ExportIfc4Silently(ICollection<ElementId> elementIds, string fileName);

  /// <summary>
  ///
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="fileName"></param>
  /// <param name="options"></param>
  /// <returns></returns>
  bool ExportIfc4SilentlyWithOptions(ICollection<ElementId> elementIds, string fileName, IIfcOptions options);

  /// <summary>
  ///
  /// </summary>
  /// <param name="fileName"></param>
  /// <returns></returns>
  bool ImportBcf(string fileName);

  /// <summary>
  ///
  /// </summary>
  /// <param name="fileName"></param>
  /// <returns></returns>
  bool ImportIfcAsGraphicalObject(string fileName);

  /// <summary>
  ///
  /// </summary>
  /// <param name="building"></param>
  /// <param name="storey"></param>
  /// <returns></returns>
  double GetStoreyHeight(string building, string storey);

  /// <summary>
  ///
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  string GetBuilding(ElementId elementId);

  /// <summary>
  ///
  /// </summary>
  /// <param name="type"></param>
  /// <returns></returns>
  string GetIfcElementTypeDisplayString(IfcElementType type);

  /// <summary>
  ///
  /// </summary>
  /// <param name="type"></param>
  /// <returns></returns>
  string GetIfcElementTypeString(IfcElementType type);

  /// <summary>
  ///
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  string GetIfcBase64Guid(ElementId elementId);

  /// <summary>
  ///
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  string GetStorey(ElementId elementId);

  /// <summary>
  ///
  /// </summary>
  void ClearErrors();

  /// <summary>
  ///
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="building"></param>
  /// <param name="storey"></param>
  void SetBuildingAndStorey(ICollection<ElementId> elementIds, string building, string storey);

  /// <summary>
  ///
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="type"></param>
  void SetIfcElementType(ICollection<ElementId> elementIds, IfcElementType type);

  /// <summary>
  ///
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="predefinedType"></param>
  void SetIfcPredefinedType(ICollection<ElementId> elementIds, IfcPredefinedType predefinedType);

  /// <summary>
  ///
  /// </summary>
  /// <param name="building"></param>
  /// <param name="storey"></param>
  /// <param name="height"></param>
  void SetStoreyHeight(string building, string storey, double height);

  /// <summary>
  ///
  /// </summary>
  /// <param name="elementIds"></param>
  void UpdateBimManagerStructureBuildingStorey(ICollection<ElementId> elementIds);

  /// <summary>
  ///
  /// </summary>
  /// <param name="elementIds"></param>
  void UpdateBimManagerStructureCreatedElements(ICollection<ElementId> elementIds);
}
