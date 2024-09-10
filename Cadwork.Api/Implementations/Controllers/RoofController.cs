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

internal class RoofController(ControllerFactoryWrapper factoryWrapper) : IRoofController
{
  private readonly ControllerFactoryWrapper _controllerFactoryWrapper = factoryWrapper;
  private readonly RoofControllerWrapper _controllerWrapper = new(factoryWrapper.GetRoofController());

  public ICollection<ulong> GetAllCaddyElementIds()
  {
    return _controllerWrapper.GetAllCaddyElementIDs().ToManagedElementIdList();
  }

  public IError GetLastError()
  {
    const int errorCode = 0;
    var errorMessage = _controllerWrapper.GetLastError(errorCode);
    return new Error { Code = errorCode, Message = errorMessage.ToManagedString() };
  }

  public double GetEdgeLength(ElementId elementId, RoofEdgeType edgeType)
  {
    return _controllerWrapper.GetEdgeLength(elementId, edgeType.ToNativeRoofEdgeType());
  }

  public double GetProfileLength(ElementId elementId)
  {
    return _controllerWrapper.GetProfileLength(elementId);
  }

  public void ClearErrors()
  {
    _controllerWrapper.ClearErrors();
  }
};
