// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Extensions;
using Cadwork.Api.Implementations.Helpers;
using Cadwork.Api.Interfaces.Controllers;
using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Interop.Wrappers.Controllers;
using Cadwork.Api.Interop.Wrappers.Factories;

namespace Cadwork.Api.Implementations.Controllers;

using MenuIndex = int;

internal class MenuController(ControllerFactoryWrapper factoryWrapper) : IMenuController
{
  private readonly ControllerFactoryWrapper _controllerFactoryWrapper = factoryWrapper;
  private readonly MenuControllerWrapper _controllerWrapper = new(factoryWrapper.GetMenuController());

  public IError GetLastError()
  {
    const int errorCode = 0;
    var errorMessage = _controllerWrapper.GetLastError(errorCode);
    return new Error { Code = errorCode, Message = errorMessage.ToManagedString() };
  }

  public IMenu CreateMenu()
  {
    return _controllerWrapper.CreateMenu().ToManagedMenu();
  }

  public MenuIndex GetSelectedMenuItem()
  {
    return _controllerWrapper.GetSelectedMenuItem();
  }

  public void CleanupAllMenus()
  {
    _controllerWrapper.CleanupAllMenus();
  }

  public void ClearErrors()
  {
    _controllerWrapper.ClearErrors();
  }

  public void DisplayMenu(IMenu menu)
  {
    _controllerWrapper.DisplayMenu(menu.ToNativeMenu(_controllerWrapper));
  }
};
