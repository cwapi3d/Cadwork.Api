// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Extensions;
using Cadwork.Api.Implementations.Helpers;
using Cadwork.Api.Interfaces.Controllers;
using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Interop.Wrappers.Controllers;
using Cadwork.Api.Interop.Wrappers.Factories;

namespace Cadwork.Api.Implementations.Controllers;

internal class GridController(ControllerFactoryWrapper factoryWrapper) : IGridController
{
  private readonly ControllerFactoryWrapper _controllerFactoryWrapper = factoryWrapper;
  private readonly GridControllerWrapper _controllerWrapper = new(factoryWrapper.GetGridController());

  public IError GetLastError()
  {
    const int errorCode = 0;
    var errorMessage = _controllerWrapper.GetLastError(errorCode);
    return new Error { Code = errorCode, Message = errorMessage.ToManagedString() };
  }
};
