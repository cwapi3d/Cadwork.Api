// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Extensions;
using Cadwork.Api.Implementations.Helpers;
using Cadwork.Api.Interfaces.Controllers;
using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Interop.Wrappers.Controllers;
using Cadwork.Api.Interop.Wrappers.Factories;
using Cadwork.Api.Structs;

namespace Cadwork.Api.Implementations.Controllers;

using SceneGroupIndex = ulong;

internal class SceneController(ControllerFactoryWrapper factoryWrapper) : ISceneController
{
  private readonly SceneControllerWrapper _controllerWrapper = new(factoryWrapper.GetSceneController());

  public ICollection<ulong> GetSceneElements(string name)
  {
    return _controllerWrapper.GetElementsFromScene(name).ToManagedElementIdList();
  }

  public ICollection<string> GetScenes()
  {
    return _controllerWrapper.GetSceneList().ToManagedStringList();
  }

  public IError GetLastError()
  {
    const int errorCode = 0;
    var errorMessage = _controllerWrapper.GetLastError(errorCode);
    return new Error { Code = errorCode, Message = errorMessage.ToManagedString() };
  }

  public SceneGroupIndex GetGroupIndexByName(string aSceneGroupName)
  {
    return _controllerWrapper.GetGroupIndexByName(aSceneGroupName);
  }

  public bool ActivateScene(string name)
  {
    return _controllerWrapper.ActivateScene(name);
  }

  public bool AddElementsToScene(string name, ICollection<ulong> elementIds)
  {
    return _controllerWrapper.AddElementsToScene(name, elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public bool AddScene(string name)
  {
    return _controllerWrapper.AddScene(name);
  }

  public bool DeleteScene(string name)
  {
    return _controllerWrapper.DeleteScene(name);
  }

  public bool IsScenePresent(string name)
  {
    return _controllerWrapper.IsScenePresent(name);
  }

  public bool RemoveElementsFromScene(string name, ICollection<ulong> elementIds)
  {
    return _controllerWrapper.RemoveElementsFromScene(name, elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public bool RenameScene(string oldName, string newName)
  {
    return _controllerWrapper.RenameScene(oldName, newName);
  }

  public ulong GroupScenes(ICollection<string> sceneNames)
  {
    return _controllerWrapper.GroupScenes(sceneNames.ToNativeStringList(factoryWrapper));
  }

  public ulong GroupScenesWithName(ICollection<string> sceneNames, string groupName)
  {
    return _controllerWrapper.GroupScenesWithName(sceneNames.ToNativeStringList(factoryWrapper), groupName);
  }

  public void ClearErrors()
  {
    _controllerWrapper.ClearErrors();
  }

  public void RenameSceneGroup(string oldName, string newName)
  {
    _controllerWrapper.RenameSceneGroup(oldName, newName);
  }

  public void RenameSceneGroupByIndex(SceneGroupIndex groupIndex, string name)
  {
    _controllerWrapper.RenameSceneGroupByIndex(groupIndex, name);
  }

  public void SetGroupTabColor(string groupName, ColorRgb color, int alpha)
  {
    _controllerWrapper.SetGroupTabColor(groupName, (int)color.ToNativeColor().R, (int)color.ToNativeColor().G, (int)color.ToNativeColor().B, alpha);
  }

  public void UngroupScenes(SceneGroupIndex groupIndex)
  {
    _controllerWrapper.UngroupScenes(groupIndex);
  }
};
