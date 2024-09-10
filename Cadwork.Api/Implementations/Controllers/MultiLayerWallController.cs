// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Extensions;
using Cadwork.Api.Interfaces.Controllers;
using Cadwork.Api.Interop.Wrappers.Controllers;
using Cadwork.Api.Interop.Wrappers.Factories;

namespace Cadwork.Api.Implementations.Controllers;

using ElementId = ulong;
using LayerIndex = ulong;
using MaterialId = ulong;
using MultiLayerSetId = ulong;

internal class MultiLayerWallController(ControllerFactoryWrapper factoryWrapper) : IMultiLayerWallController
{
  private readonly ControllerFactoryWrapper _controllerFactoryWrapper = factoryWrapper;
  private readonly MultiLayerWallControllerWrapper _controllerWrapper = new(factoryWrapper.GetMultiLayerWallController());

  public ICollection<ulong> GetMultiLayerWalls()
  {
    return _controllerWrapper.GetMultiLayerWalls();
  }

  public MaterialId GetLayerMaterial(MultiLayerSetId multiLayerSetId, LayerIndex layerIndex)
  {
    return _controllerWrapper.GetLayerMaterial(multiLayerSetId, layerIndex);
  }

  public MaterialId GetWallMaterial(MultiLayerSetId multiLayerSetId)
  {
    return _controllerWrapper.GetCoverMaterial(multiLayerSetId);
  }

  public MultiLayerSetId CreateMultiLayerWall(string setName)
  {
    return _controllerWrapper.CreateMultiLayerWall(setName);
  }

  public MultiLayerSetId GetElementMultiLayerSet(ElementId elementId)
  {
    return _controllerWrapper.GetElementMultiLayerSet(elementId);
  }

  public MultiLayerType GetLayerType(MultiLayerSetId multiLayerSetId, LayerIndex layerIndex)
  {
    return _controllerWrapper.GetLayerType(multiLayerSetId, layerIndex).ToManagedMultiLayerType();
  }

  public double GetLayerThickness(MultiLayerSetId multiLayerSetId, LayerIndex layerIndex)
  {
    return _controllerWrapper.GetLayerThickness(multiLayerSetId, layerIndex);
  }

  public double GetWallThickness(MultiLayerSetId multiLayerSetId)
  {
    return _controllerWrapper.GetCoverThickness(multiLayerSetId);
  }

  public string GetLayerName(MultiLayerSetId multiLayerSetId, LayerIndex layerIndex)
  {
    return _controllerWrapper.GetLayerName(multiLayerSetId, layerIndex).ToManagedString();
  }

  public string GetMultiLayerSetName(MultiLayerSetId multiLayerSetId)
  {
    return _controllerWrapper.GetMultiLayerSetName(multiLayerSetId).ToManagedString();
  }

  public string GetWallName(MultiLayerSetId multiLayerSetId)
  {
    return _controllerWrapper.GetCoverName(multiLayerSetId).ToManagedString();
  }

  public uint GetWallColor(MultiLayerSetId multiLayerSetId)
  {
    return _controllerWrapper.GetCoverColor(multiLayerSetId);
  }

  public ulong GetLayerCount(MultiLayerSetId multiLayerSetId)
  {
    return _controllerWrapper.GetLayerCount(multiLayerSetId);
  }

  public void AddLayer(MultiLayerSetId multiLayerSetId, MultiLayerType type, string name, MaterialId materialId, double thickness)
  {
    _controllerWrapper.AddLayer(multiLayerSetId, type.ToNativeMultiLayerType(), name, materialId, thickness);
  }

  public void SetElementMultiLayerSet(ElementId elementId, MultiLayerSetId multiLayerSetId)
  {
    _controllerWrapper.SetElementMultiLayerSet(elementId, multiLayerSetId);
  }

  public void SetLayerMaterial(MultiLayerSetId multiLayerSetId, LayerIndex layerIndex, MaterialId materialId)
  {
    _controllerWrapper.SetLayerMaterial(multiLayerSetId, layerIndex, materialId);
  }

  public void SetLayerName(MultiLayerSetId multiLayerSetId, LayerIndex layerIndex, string name)
  {
    _controllerWrapper.SetLayerName(multiLayerSetId, layerIndex, name);
  }

  public void SetLayerThickness(MultiLayerSetId multiLayerSetId, LayerIndex layerIndex, double thickness)
  {
    _controllerWrapper.SetLayerThickness(multiLayerSetId, layerIndex, thickness);
  }

  public void SetLayerType(MultiLayerSetId multiLayerSetId, LayerIndex layerIndex, MultiLayerType type)
  {
    _controllerWrapper.SetLayerType(multiLayerSetId, layerIndex, type.ToNativeMultiLayerType());
  }

  public void SetMultiLayerSetName(MultiLayerSetId multiLayerSetId, string setName)
  {
    _controllerWrapper.SetMultiLayerSetName(multiLayerSetId, setName);
  }

  public void SetWallColor(MultiLayerSetId multiLayerSetId, uint colorId)
  {
    _controllerWrapper.SetCoverColor(multiLayerSetId, colorId);
  }

  public void SetWallMaterial(MultiLayerSetId multiLayerSetId, MaterialId materialId)
  {
    _controllerWrapper.SetCoverMaterial(multiLayerSetId, materialId);
  }

  public void SetWallName(MultiLayerSetId multiLayerSetId, string coverName)
  {
    _controllerWrapper.SetCoverName(multiLayerSetId, coverName);
  }

  public void SetWallThickness(MultiLayerSetId multiLayerSetId, double thickness)
  {
    _controllerWrapper.SetCoverThickness(multiLayerSetId, thickness);
  }
};
