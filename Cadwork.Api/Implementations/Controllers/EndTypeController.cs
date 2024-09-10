// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Extensions;
using Cadwork.Api.Implementations.Helpers;
using Cadwork.Api.Interfaces.Controllers;
using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Interop.Wrappers.Controllers;
using Cadwork.Api.Interop.Wrappers.Factories;

namespace Cadwork.Api.Implementations.Controllers;

using ElementId = ulong;
using EndTypeId = ulong;

internal class EndTypeController(ControllerFactoryWrapper factoryWrapper) : IEndTypeController
{
  private readonly ControllerFactoryWrapper _controllerFactoryWrapper = factoryWrapper;
  private readonly EndTypeControllerWrapper _controllerWrapper = new(factoryWrapper.GetEndTypeController());

  public EndTypeId CreateEndType(string name, EndTypeId endTypeId, string folderName)
  {
    return _controllerWrapper.CreateNewEndType(name, (uint)endTypeId, folderName);
  }

  public EndTypeId GetEndTypeId(string name)
  {
    return _controllerWrapper.GetEndTypeId(name);
  }

  public EndTypeId GetEndTypeIdAtEnd(ElementId elementId)
  {
    return _controllerWrapper.GetEndTypeIdEnd(elementId);
  }

  public EndTypeId GetEndTypeIdAtStart(ElementId elementId)
  {
    return _controllerWrapper.GetEndTypeIdStart(elementId);
  }

  public EndTypeId GetEndTypeIdOnFacet(ElementId elementId, uint facetIndex)
  {
    return _controllerWrapper.GetEndTypeIdFac(elementId, facetIndex);
  }

  public EndTypeId StartEndTypeDialog()
  {
    return _controllerWrapper.StartEndTypeDialog();
  }

  public ICollection<ulong> GetExistingDovetailDadoIds()
  {
    return _controllerWrapper.GetExistingDovetailDadoIds().ToManagedEndTypeIdList();
  }

  public ICollection<ulong> GetExistingDovetailIds()
  {
    return _controllerWrapper.GetExistingDovetailIds().ToManagedEndTypeIdList();
  }

  public ICollection<ulong> GetExistingJapaneseTenonIds()
  {
    return _controllerWrapper.GetExistingJapaneseTenonIds().ToManagedEndTypeIdList();
  }

  public ICollection<ulong> GetExistingLengtheningIds()
  {
    return _controllerWrapper.GetExistingLengtheningIds().ToManagedEndTypeIdList();
  }

  public ICollection<ulong> GetExistingTenonIds()
  {
    return _controllerWrapper.GetExistingTenonIds().ToManagedEndTypeIdList();
  }

  public IError GetLastError()
  {
    const int errorCode = 0;
    var errorMessage = _controllerWrapper.GetLastError(errorCode);
    return new Error { Code = errorCode, Message = errorMessage.ToManagedString() };
  }

  public string GetEndTypeName(ElementId elementId)
  {
    return _controllerWrapper.GetEndTypeName(elementId).ToManagedString();
  }

  public string GetEndTypeNameAtEnd(ElementId elementId)
  {
    return _controllerWrapper.GetEndTypeNameEnd(elementId).ToManagedString();
  }

  public string GetEndTypeNameAtStart(ElementId elementId)
  {
    return _controllerWrapper.GetEndTypeNameStart(elementId).ToManagedString();
  }

  public string GetEndTypeNameOnFacet(ElementId elementId, uint facetIndex)
  {
    return _controllerWrapper.GetEndTypeNameFac(elementId, facetIndex).ToManagedString();
  }

  public void ClearErrors()
  {
    _controllerWrapper.ClearErrors();
  }

  public void SetEndTypeIdAtEnd(ElementId elementId, EndTypeId endTypeId)
  {
    _controllerWrapper.SetEndTypeIdEnd(elementId, endTypeId);
  }

  public void SetEndTypeIdAtStart(ElementId elementId, EndTypeId endTypeId)
  {
    _controllerWrapper.SetEndTypeIdStart(elementId, endTypeId);
  }

  public void SetEndTypeIdOnFacet(ElementId elementId, EndTypeId endTypeId, uint facetIndex)
  {
    _controllerWrapper.SetEndTypeIdFac(elementId, endTypeId, facetIndex);
  }

  public void SetEndTypeNameAtEnd(ElementId elementId, string name)
  {
    _controllerWrapper.SetEndTypeNameEnd(elementId, name);
  }

  public void SetEndTypeNameAtStart(ElementId elementId, string name)
  {
    _controllerWrapper.SetEndTypeNameStart(elementId, name);
  }

  public void SetEndTypeNameOnFacet(ElementId elementId, string name, uint facetIndex)
  {
    _controllerWrapper.SetEndTypeNameFac(elementId, name, facetIndex);
  }
};
