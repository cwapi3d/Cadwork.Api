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

internal class MachineController(ControllerFactoryWrapper factoryWrapper) : IMachineController
{
  private readonly MachineControllerWrapper _controllerWrapper = new(factoryWrapper.GetMachineController());

  public ICollection<ulong> GetElementBtlProcesses(ElementId elementId, BtlVersion version)
  {
    return _controllerWrapper.GetElementBtlProcesses(elementId, version.ToNativeBtlVersion()).ToManagedElementIdList();
  }

  public ICollection<ulong> GetElementHundeggerProcesses(ElementId elementId, HundeggerType type)
  {
    return _controllerWrapper.GetElementHundeggerProcesses(elementId, type.ToNativeHundeggerType()).ToManagedElementIdList();
  }

  public ICollection<Vec3> GetProcessPoints(ElementId referenceElementId, ElementId elementId)
  {
    return _controllerWrapper.GetProcessingPoints(referenceElementId, elementId).ToManagedVectorList();
  }

  public ICollection<string> GetProcessingBtlParameterSet(ElementId referenceElementId, ElementId elementId)
  {
    return _controllerWrapper.GetProcessingBtlParameterSet(referenceElementId, elementId).ToManagedStringList();
  }

  public IError GetLastError()
  {
    const int errorCode = 0;
    var errorMessage = _controllerWrapper.GetLastError(errorCode);
    return new Error { Code = errorCode, Message = errorMessage.ToManagedString() };
  }

  public string GetProcessCode(ElementId referenceElementId, ElementId elementId)
  {
    return _controllerWrapper.GetProcessingCode(referenceElementId, elementId).ToManagedString();
  }

  public string GetProcessName(ElementId referenceElementId, ElementId elementId)
  {
    return _controllerWrapper.GetProcessingName(referenceElementId, elementId).ToManagedString();
  }

  public void CalculateBtlMachineData(ICollection<ulong> elementIds, BtlVersion version)
  {
    _controllerWrapper.CalculateBtlMachineData(elementIds.ToNativeElementIdList(factoryWrapper), version.ToNativeBtlVersion());
  }

  public void CalculateHundeggerMachineData(ICollection<ulong> elementIds, HundeggerType type)
  {
    _controllerWrapper.CalculateHundeggerMachineData(elementIds.ToNativeElementIdList(factoryWrapper), type.ToNativeHundeggerType());
  }

  public void ClearErrors()
  {
    _controllerWrapper.ClearErrors();
  }

  public void ExportBtl(BtlVersion version, string fileName)
  {
    _controllerWrapper.ExportBtl(version.ToNativeBtlVersion(), fileName);
  }

  public void ExportBtlWithSettings(BtlVersion version, string fileName, string settingsFileNAme)
  {
    _controllerWrapper.ExportBtlWithPresetting(version.ToNativeBtlVersion(), fileName, settingsFileNAme);
  }

  public void ExportHundegger(HundeggerType type)
  {
    _controllerWrapper.ExportHundegger(type.ToNativeHundeggerType());
  }

  public void ExportHundeggerWithFilePath(HundeggerType type, string fileName)
  {
    _controllerWrapper.ExportHundeggerWithFilePath(type.ToNativeHundeggerType(), fileName);
  }

  public void ExportHundeggerWithFilePathAndSettings(HundeggerType type, string fileName, string settingsFileName)
  {
    _controllerWrapper.ExportHundeggerWithFilePathAndPresetting(type.ToNativeHundeggerType(), fileName, settingsFileName);
  }

  public void ExportHundeggerWithFilePathAndSettingsSilent(HundeggerType type, string fileName, string settingsFileName)
  {
    _controllerWrapper.ExportHundeggerWithFilePathAndPresettingSilent(type.ToNativeHundeggerType(), fileName, settingsFileName);
  }

  public void ExportHundeggerWithFilePathSilent(HundeggerType type, string fileName)
  {
    _controllerWrapper.ExportHundeggerWithFilePathSilent(type.ToNativeHundeggerType(), fileName);
  }

  public void ExportWeinmannMfb(WeinmannMfbVersion version)
  {
    _controllerWrapper.ExportWeinmannMfb(version.ToNativeWeinmannMfbVersion());
  }

  public void LoadHundeggerCalculationSet(HundeggerType type, string fileName)
  {
    _controllerWrapper.LoadHundeggerCalculationSet(type.ToNativeHundeggerType(), fileName);
  }
};
