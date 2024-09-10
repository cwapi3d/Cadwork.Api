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

internal class ConnectorAxisController(ControllerFactoryWrapper factoryWrapper) : IConnectorAxisController
{
  private readonly ConnectorAxisControllerWrapper _controllerWrapper = new(factoryWrapper.GetConnectorAxisController());

  public ElementId CreateBlankConnectorAxis(double diameter, Vec3 startPoint, Vec3 endPoint)
  {
    return _controllerWrapper.CreateBlankConnector(diameter, startPoint.ToNativeVector(), endPoint.ToNativeVector());
  }

  public ElementId CreateStandardConnectorAxis(string name, Vec3 startPoint, Vec3 endPoint)
  {
    return _controllerWrapper.CreateStandardConnector(name, startPoint.ToNativeVector(), endPoint.ToNativeVector());
  }

  public ElementId GetSectionContactElement(ElementId elementId, uint sectionIndex)
  {
    return _controllerWrapper.GetSectionContactElement(elementId, sectionIndex);
  }

  public ICollection<Guid> GetAxisItemsGuids(ElementId elementId)
  {
    return _controllerWrapper.GetAxisItemsGuiDs(elementId).ToManagedGuidList();
  }

  public ICollection<string> GetStandardConnectors()
  {
    return _controllerWrapper.GetStandardConnectorList().ToManagedStringList();
  }

  public IError GetLastError()
  {
    const int errorCode = 0;
    var errorMessage = _controllerWrapper.GetLastError(errorCode);
    return new Error { Code = errorCode, Message = errorMessage.ToManagedString() };
  }

  public bool CheckAxis(ElementId elementId)
  {
    return _controllerWrapper.CheckAxis(elementId);
  }

  public bool GetBoltLengthAutomatic(ElementId elementId)
  {
    return _controllerWrapper.GetBoltLengthAutomatic(elementId);
  }

  public double GetBoltDiameter(ElementId elementId)
  {
    return _controllerWrapper.GetBoltDiameter(elementId);
  }

  public double GetBoltLength(ElementId elementId)
  {
    return _controllerWrapper.GetBoltLength(elementId);
  }

  public double GetBoltOverLength(ElementId elementId)
  {
    return _controllerWrapper.GetBoltOverLength(elementId);
  }

  public double GetSectionDiameter(ElementId elementId, uint sectionIndex)
  {
    return _controllerWrapper.GetSectionDiameter(elementId, sectionIndex);
  }

  public int GetSectionCount(ElementId elementId)
  {
    return _controllerWrapper.GetSectionCount(elementId);
  }

  public string GetAxisItemMaterial(Guid guid)
  {
    return _controllerWrapper.GetAxisItemMaterial(guid.ToNativeGuid()).ToManagedString();
  }

  public string GetAxisItemName(Guid guid)
  {
    return _controllerWrapper.GetAxisItemName(guid.ToNativeGuid()).ToManagedString();
  }

  public string GetAxisItemNorm(Guid guid)
  {
    return _controllerWrapper.GetAxisItemNorm(guid.ToNativeGuid()).ToManagedString();
  }

  public string GetAxisItemOrderNumber(Guid guid)
  {
    return _controllerWrapper.GetAxisItemOrderNumber(guid.ToNativeGuid()).ToManagedString();
  }

  public string GetAxisItemStrengthCategory(Guid guid)
  {
    return _controllerWrapper.GetAxisItemStrengthCategory(guid.ToNativeGuid()).ToManagedString();
  }

  public string GetAxisItemUserField(Guid guid, int userItemIndex)
  {
    return _controllerWrapper.GetAxisItemUserField(guid.ToNativeGuid(), userItemIndex).ToManagedString();
  }

  public Guid GetBoltItemGuid(ElementId elementId)
  {
    return _controllerWrapper.GetBoltItemGuid(elementId).ToManagedGuid();
  }

  public string GetBoltOrderNumber(ElementId elementId)
  {
    return _controllerWrapper.GetBoltOrderNumber(elementId).ToManagedString();
  }

  public Guid GetItemGuidByName(string name, ConnectorAxisItemType type)
  {
    return _controllerWrapper.GetItemGuidByName(name, type.ToNativeConnectorAxisType()).ToManagedGuid();
  }

  public string GetSectionMaterialName(ElementId elementId, uint sectionIndex)
  {
    return _controllerWrapper.GetSectionMaterialName(elementId, sectionIndex).ToManagedString();
  }

  public void ClearErrors()
  {
    _controllerWrapper.ClearErrors();
  }

  public void ImportFromFile(string fileName)
  {
    _controllerWrapper.ImportFromFile(fileName);
  }

  public void SetBoltItem(ElementId elementId, Guid guid)
  {
    _controllerWrapper.SetBoltItem(elementId, guid.ToNativeGuid());
  }

  public void SetBoltLength(ElementId elementId, double length)
  {
    _controllerWrapper.SetBoltLength(elementId, length);
  }

  public void SetBoltLengthAutomatic(ElementId elementId, bool useAutomaticLength)
  {
    _controllerWrapper.SetBoltLengthAutomatic(elementId, useAutomaticLength);
  }

  public void SetBoltOverLength(ElementId elementId, double overLength)
  {
    _controllerWrapper.SetBoltOverLength(elementId, overLength);
  }

  public void SetDiameter(ElementId elementId, double diameter)
  {
    _controllerWrapper.SetDiameter(elementId, diameter);
  }

  public void SetSectionDiameter(ElementId elementId, uint sectionIndex, double diameter)
  {
    _controllerWrapper.SetSectionDiameter(elementId, sectionIndex, diameter);
  }

  public void StartConfigurationDialog()
  {
    _controllerWrapper.StartConfigurationDialog();
  }

  public void UpdateAxisCuttingAbility(ICollection<ulong> elementIds)
  {
    _controllerWrapper.UpdateAxisCuttingAbility(elementIds.ToNativeElementIdList(factoryWrapper));
  }
}
