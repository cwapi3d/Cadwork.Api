// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Implementations.Helpers;
using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Interop.Wrappers.Controllers;
using Cadwork.Api.Interop.Wrappers.Helpers;

namespace Cadwork.Api.Extensions;

internal static class MenuExtensions
{
  internal static IntPtr ToNativeMenu(this IMenu data, MenuControllerWrapper controller)
  {
    var wrapper = new MenuWrapper(controller.CreateMenu());
    // TODO: Implement
    return wrapper.NativePtr;
  }

  internal static IMenu ToManagedMenu(this IntPtr data)
  {
    var wrapper = new MenuWrapper(data);
    var menuItems = wrapper.GetMenuItems().ToManagedStringList();

    var menu = new Menu();

    foreach (var menuItem in menuItems)
    {
      if (string.IsNullOrEmpty(menuItem))
      {
        menu.AddBlank();
      }
      else
      {
        menu.AddButton(menuItem);
      }
    }

    return menu;
  }
}
