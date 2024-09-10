// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Extensions;
using Cadwork.Api.Implementations.Helpers;
using Cadwork.Api.Interfaces.Controllers;
using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Interop.Wrappers.Controllers;
using Cadwork.Api.Interop.Wrappers.Factories;

namespace Cadwork.Api.Implementations.Controllers;

using ElementId = ulong;

internal class BimController(ControllerFactoryWrapper factoryWrapper) : IBimController
{
  private readonly BimControllerWrapper _controllerWrapper = new(factoryWrapper.GetBimController());

  public ElementId GetElementIdFromIfcBase64Guid(string guid)
  {
    return _controllerWrapper.GetElementIdFromIfcBase64Guid(guid);
  }

  public Guid GetIfcGuid(ElementId elementId)
  {
    return _controllerWrapper.GetIfcGuid(elementId).ToManagedGuid();
  }

  public ICollection<ulong> ConvertExchangeObjects(ICollection<ulong> elementIds)
  {
    return _controllerWrapper.ConvertExchangeObjects(elementIds.ToNativeElementIdList(factoryWrapper)).ToManagedElementIdList();
  }

  public ICollection<ulong> ImportIfcReturnExchangeObjects(string fileName)
  {
    return _controllerWrapper.ImportIfcReturnExchangeObjects(fileName).ToManagedElementIdList();
  }

  public ICollection<string> GetAllBuildings()
  {
    return _controllerWrapper.GetAllBuildings().ToManagedStringList();
  }

  public ICollection<string> GetAllStoreys(string building)
  {
    return _controllerWrapper.GetAllStoreys(building).ToManagedStringList();
  }

  public IError GetLastError()
  {
    const int errorCode = 0;
    var errorMessage = _controllerWrapper.GetLastError(errorCode);
    return new Error { Code = errorCode, Message = errorMessage.ToManagedString() };
  }

  public IIfcOptions GetIfcOptions()
  {
    return _controllerWrapper.GetIfcOptions().ToManagedIfcOptions();
  }

  public IfcElementType GetIfcElementType(ElementId elementId)
  {
    return _controllerWrapper.GetIfc2X3ElementType(elementId).ToManagedIfcElementType();
  }

  public IfcPredefinedType GetIfcPredefinedType(ElementId elementId)
  {
    return _controllerWrapper.GetIfcPredefinedType(elementId).ToManagedIfcPredefinedType();
  }

  public bool ExportBcf(string fileName)
  {
    return _controllerWrapper.ExportBcf(fileName);
  }

  public bool ExportIfc(ICollection<ulong> elementIds, string fileName)
  {
    return _controllerWrapper.ExportIfc(elementIds.ToNativeElementIdList(factoryWrapper), fileName);
  }

  public bool ExportIfc2x3Silently(ICollection<ulong> elementIds, string fileName)
  {
    return _controllerWrapper.ExportIfc2X3Silently(elementIds.ToNativeElementIdList(factoryWrapper), fileName);
  }

  public bool ExportIfc2x3SilentlyWithOptions(ICollection<ulong> elementIds, string fileName, IIfcOptions options)
  {
    return _controllerWrapper.ExportIfc2X3SilentlyWithOptions(elementIds.ToNativeElementIdList(factoryWrapper), fileName, options.ToNativeIfcOptions(factoryWrapper));
  }

  public bool ExportIfc4Silently(ICollection<ulong> elementIds, string fileName)
  {
    return _controllerWrapper.ExportIfc4Silently(elementIds.ToNativeElementIdList(factoryWrapper), fileName);
  }

  public bool ExportIfc4SilentlyWithOptions(ICollection<ulong> elementIds, string fileName, IIfcOptions options)
  {
    return _controllerWrapper.ExportIfc4SilentlyWithOptions(elementIds.ToNativeElementIdList(factoryWrapper), fileName, options.ToNativeIfcOptions(factoryWrapper));
  }

  public bool ImportBcf(string fileName)
  {
    return _controllerWrapper.ImportBcf(fileName);
  }

  public bool ImportIfcAsGraphicalObject(string fileName)
  {
    return _controllerWrapper.ImportIfcAsGraphicalObject(fileName);
  }

  public double GetStoreyHeight(string building, string storey)
  {
    return _controllerWrapper.GetStoreyHeight(building, storey);
  }

  public string GetBuilding(ElementId elementId)
  {
    return _controllerWrapper.GetBuilding(elementId).ToManagedString();
  }

  public string GetIfcElementTypeDisplayString(IfcElementType type)
  {
    return _controllerWrapper.GetIfc2X3ElementTypeDisplayString(type.ToNativeIfcElementType(factoryWrapper)).ToManagedString();
  }

  public string GetIfcElementTypeString(IfcElementType type)
  {
    return _controllerWrapper.GetIfc2X3ElementTypeString(type.ToNativeIfcElementType(factoryWrapper)).ToManagedString();
  }

  public string GetIfcBase64Guid(ElementId elementId)
  {
    return _controllerWrapper.GetIfcBase64Guid(elementId).ToManagedString();
  }

  public string GetStorey(ElementId elementId)
  {
    return _controllerWrapper.GetStorey(elementId).ToManagedString();
  }

  public void ClearErrors()
  {
    _controllerWrapper.ClearErrors();
  }

  public void SetBuildingAndStorey(ICollection<ulong> elementIds, string building, string storey)
  {
    _controllerWrapper.SetBuildingAndStorey(elementIds.ToNativeElementIdList(factoryWrapper), building, storey);
  }

  public void SetIfcElementType(ICollection<ulong> elementIds, IfcElementType type)
  {
    _controllerWrapper.SetIfc2X3ElementType(elementIds.ToNativeElementIdList(factoryWrapper), type.ToNativeIfcElementType(factoryWrapper));
  }

  public void SetIfcPredefinedType(ICollection<ulong> elementIds, IfcPredefinedType predefinedType)
  {
    _controllerWrapper.SetIfcPredefinedType(elementIds.ToNativeElementIdList(factoryWrapper), predefinedType.ToNativeIfcPredefinedType(factoryWrapper));
  }

  public void SetStoreyHeight(string building, string storey, double height)
  {
    _controllerWrapper.SetStoreyHeight(building, storey, height);
  }

  public void UpdateBimManagerStructureBuildingStorey(ICollection<ulong> elementIds)
  {
    _controllerWrapper.UpdateBmtStructureBuildingStorey(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void UpdateBimManagerStructureCreatedElements(ICollection<ulong> elementIds)
  {
    _controllerWrapper.UpdateBmtStructureCreatedElements(elementIds.ToNativeElementIdList(factoryWrapper));
  }
}
