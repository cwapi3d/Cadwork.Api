// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;

namespace Cadwork.Api.Interfaces.Controllers;

using ElementId = ulong;
using LayerIndex = ulong;
using MaterialId = ulong;
using MultiLayerSetId = ulong;

/// <summary>
/// 
/// </summary>
public interface IMultiLayerWallController
{
  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  ICollection<MultiLayerSetId> GetMultiLayerWalls();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="multiLayerSetId"></param>
  /// <param name="layerIndex"></param>
  /// <returns></returns>
  MaterialId GetLayerMaterial(MultiLayerSetId multiLayerSetId, LayerIndex layerIndex);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="multiLayerSetId"></param>
  /// <returns></returns>
  MaterialId GetWallMaterial(MultiLayerSetId multiLayerSetId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="setName"></param>
  /// <returns></returns>
  MultiLayerSetId CreateMultiLayerWall(string setName);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  MultiLayerSetId GetElementMultiLayerSet(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="multiLayerSetId"></param>
  /// <param name="layerIndex"></param>
  /// <returns></returns>
  MultiLayerType GetLayerType(MultiLayerSetId multiLayerSetId, LayerIndex layerIndex);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="multiLayerSetId"></param>
  /// <param name="layerIndex"></param>
  /// <returns></returns>
  double GetLayerThickness(MultiLayerSetId multiLayerSetId, LayerIndex layerIndex);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="multiLayerSetId"></param>
  /// <returns></returns>
  double GetWallThickness(MultiLayerSetId multiLayerSetId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="multiLayerSetId"></param>
  /// <param name="layerIndex"></param>
  /// <returns></returns>
  string GetLayerName(MultiLayerSetId multiLayerSetId, LayerIndex layerIndex);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="multiLayerSetId"></param>
  /// <returns></returns>
  string GetMultiLayerSetName(MultiLayerSetId multiLayerSetId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="multiLayerSetId"></param>
  /// <returns></returns>
  string GetWallName(MultiLayerSetId multiLayerSetId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="multiLayerSetId"></param>
  /// <returns></returns>
  uint GetWallColor(MultiLayerSetId multiLayerSetId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="multiLayerSetId"></param>
  /// <returns></returns>
  ulong GetLayerCount(MultiLayerSetId multiLayerSetId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="multiLayerSetId"></param>
  /// <param name="type"></param>
  /// <param name="name"></param>
  /// <param name="materialId"></param>
  /// <param name="thickness"></param>
  void AddLayer(MultiLayerSetId multiLayerSetId, MultiLayerType type, string name, MaterialId materialId, double thickness);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="multiLayerSetId"></param>
  void SetElementMultiLayerSet(ElementId elementId, MultiLayerSetId multiLayerSetId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="multiLayerSetId"></param>
  /// <param name="layerIndex"></param>
  /// <param name="materialId"></param>
  void SetLayerMaterial(MultiLayerSetId multiLayerSetId, LayerIndex layerIndex, MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="multiLayerSetId"></param>
  /// <param name="layerIndex"></param>
  /// <param name="name"></param>
  void SetLayerName(MultiLayerSetId multiLayerSetId, LayerIndex layerIndex, string name);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="multiLayerSetId"></param>
  /// <param name="layerIndex"></param>
  /// <param name="thickness"></param>
  void SetLayerThickness(MultiLayerSetId multiLayerSetId, LayerIndex layerIndex, double thickness);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="multiLayerSetId"></param>
  /// <param name="layerIndex"></param>
  /// <param name="type"></param>
  void SetLayerType(MultiLayerSetId multiLayerSetId, LayerIndex layerIndex, MultiLayerType type);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="multiLayerSetId"></param>
  /// <param name="setName"></param>
  void SetMultiLayerSetName(MultiLayerSetId multiLayerSetId, string setName);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="multiLayerSetId"></param>
  /// <param name="colorId"></param>
  void SetWallColor(MultiLayerSetId multiLayerSetId, uint colorId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="multiLayerSetId"></param>
  /// <param name="materialId"></param>
  void SetWallMaterial(MultiLayerSetId multiLayerSetId, MaterialId materialId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="multiLayerSetId"></param>
  /// <param name="coverName"></param>
  void SetWallName(MultiLayerSetId multiLayerSetId, string coverName);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="multiLayerSetId"></param>
  /// <param name="thickness"></param>
  void SetWallThickness(MultiLayerSetId multiLayerSetId, double thickness);
};
