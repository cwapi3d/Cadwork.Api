// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Structs;

namespace Cadwork.Api.Interfaces.Controllers;

using ElementId = ulong;

/// <summary>
/// 
/// </summary>
public interface IMachineController
{
  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="version"></param>
  /// <returns></returns>
  ICollection<ElementId> GetElementBtlProcesses(ElementId elementId, BtlVersion version);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="type"></param>
  /// <returns></returns>
  ICollection<ElementId> GetElementHundeggerProcesses(ElementId elementId, HundeggerType type);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="referenceElementId"></param>
  /// <param name="elementId"></param>
  /// <returns></returns>
  ICollection<Vec3> GetProcessPoints(ElementId referenceElementId, ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="referenceElementId"></param>
  /// <param name="elementId"></param>
  /// <returns></returns>
  ICollection<string> GetProcessingBtlParameterSet(ElementId referenceElementId, ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  IError GetLastError();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="referenceElementId"></param>
  /// <param name="elementId"></param>
  /// <returns></returns>
  string GetProcessCode(ElementId referenceElementId, ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="referenceElementId"></param>
  /// <param name="elementId"></param>
  /// <returns></returns>
  string GetProcessName(ElementId referenceElementId, ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="version"></param>
  void CalculateBtlMachineData(ICollection<ElementId> elementIds, BtlVersion version);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementIds"></param>
  /// <param name="type"></param>
  void CalculateHundeggerMachineData(ICollection<ElementId> elementIds, HundeggerType type);

  /// <summary>
  /// 
  /// </summary>
  void ClearErrors();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="version"></param>
  /// <param name="fileName"></param>
  void ExportBtl(BtlVersion version, string fileName);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="version"></param>
  /// <param name="fileName"></param>
  /// <param name="settingsFileNAme"></param>
  void ExportBtlWithSettings(BtlVersion version, string fileName, string settingsFileNAme);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="type"></param>
  void ExportHundegger(HundeggerType type);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="type"></param>
  /// <param name="fileName"></param>
  void ExportHundeggerWithFilePath(HundeggerType type, string fileName);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="type"></param>
  /// <param name="fileName"></param>
  /// <param name="settingsFileName"></param>
  void ExportHundeggerWithFilePathAndSettings(HundeggerType type, string fileName, string settingsFileName);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="type"></param>
  /// <param name="fileName"></param>
  /// <param name="settingsFileName"></param>
  void ExportHundeggerWithFilePathAndSettingsSilent(HundeggerType type, string fileName, string settingsFileName);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="type"></param>
  /// <param name="fileName"></param>
  void ExportHundeggerWithFilePathSilent(HundeggerType type, string fileName);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="version"></param>
  void ExportWeinmannMfb(WeinmannMfbVersion version);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="type"></param>
  /// <param name="fileName"></param>
  void LoadHundeggerCalculationSet(HundeggerType type, string fileName);
};
