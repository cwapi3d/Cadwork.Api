// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Structs;

namespace Cadwork.Api.Interfaces.Controllers;

using ElementId = ulong;
using SceneGroupIndex = ulong;

/// <summary>
/// 
/// </summary>
public interface ISceneController
{
  /// <summary>
  /// 
  /// </summary>
  /// <param name="name"></param>
  /// <returns></returns>
  ICollection<ElementId> GetSceneElements(string name);

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  ICollection<string> GetScenes();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  IError GetLastError();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="aSceneGroupName"></param>
  /// <returns></returns>
  SceneGroupIndex GetGroupIndexByName(string aSceneGroupName);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="name"></param>
  /// <returns></returns>
  bool ActivateScene(string name);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="name"></param>
  /// <param name="elementIds"></param>
  /// <returns></returns>
  bool AddElementsToScene(string name, ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="name"></param>
  /// <returns></returns>
  bool AddScene(string name);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="name"></param>
  /// <returns></returns>
  bool DeleteScene(string name);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="name"></param>
  /// <returns></returns>
  bool IsScenePresent(string name);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="name"></param>
  /// <param name="elementIds"></param>
  /// <returns></returns>
  bool RemoveElementsFromScene(string name, ICollection<ElementId> elementIds);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="oldName"></param>
  /// <param name="newName"></param>
  /// <returns></returns>
  bool RenameScene(string oldName, string newName);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="sceneNames"></param>
  /// <returns></returns>
  ulong GroupScenes(ICollection<string> sceneNames);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="sceneNames"></param>
  /// <param name="groupName"></param>
  /// <returns></returns>
  ulong GroupScenesWithName(ICollection<string> sceneNames, string groupName);

  /// <summary>
  /// 
  /// </summary>
  void ClearErrors();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="oldName"></param>
  /// <param name="newName"></param>
  void RenameSceneGroup(string oldName, string newName);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="groupIndex"></param>
  /// <param name="name"></param>
  void RenameSceneGroupByIndex(SceneGroupIndex groupIndex, string name);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="groupName"></param>
  /// <param name="color"></param>
  /// <param name="alpha"></param>
  void SetGroupTabColor(string groupName, ColorRgb color, int alpha);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="groupIndex"></param>
  void UngroupScenes(SceneGroupIndex groupIndex);
};
