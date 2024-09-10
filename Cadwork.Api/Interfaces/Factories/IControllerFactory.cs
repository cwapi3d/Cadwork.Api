// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Interfaces.Controllers;
using Cadwork.Api.Interfaces.Helpers;

namespace Cadwork.Api.Interfaces.Factories;

/// <summary>
/// 
/// </summary>
public interface IControllerFactory
{
  /// <summary>
  /// 
  /// </summary>
  public IAttributeController AttributeController { get; }

  /// <summary>
  /// 
  /// </summary>
  public IBimController BimController { get; }

  /// <summary>
  /// 
  /// </summary>
  public IConnectorAxisController ConnectorAxisController { get; }

  /// <summary>
  /// 
  /// </summary>
  public IDimensionController DimensionController { get; }

  /// <summary>
  /// 
  /// </summary>
  public IElementController ElementController { get; }

  /// <summary>
  /// 
  /// </summary>
  public IEndTypeController EndTypeController { get; }

  /// <summary>
  /// 
  /// </summary>
  public IFileController FileController { get; }

  /// <summary>
  /// 
  /// </summary>
  public IGeometryController GeometryController { get; }

  /// <summary>
  /// 
  /// </summary>
  public IGridController GridController { get; }

  /// <summary>
  /// 
  /// </summary>
  public IListController ListController { get; }

  /// <summary>
  /// 
  /// </summary>
  public IMachineController MachineController { get; }

  /// <summary>
  /// 
  /// </summary>
  public IMaterialController MaterialController { get; }

  /// <summary>
  /// 
  /// </summary>
  public IMenuController MenuController { get; }

  /// <summary>
  /// 
  /// </summary>
  public IMultiLayerWallController MultiLayerWallController { get; }

  /// <summary>
  /// 
  /// </summary>
  public IRoofController RoofController { get; }

  /// <summary>
  /// 
  /// </summary>
  public ISceneController SceneController { get; }

  /// <summary>
  /// 
  /// </summary>
  public IShopDrawingController ShopDrawingController { get; }

  /// <summary>
  /// 
  /// </summary>
  public IUtilityController UtilityController { get; }

  /// <summary>
  /// 
  /// </summary>
  public IVisualizationController VisualizationController { get; }

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  public ICameraData CreateCameraData();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  public IElementModuleProperties CreateElementModuleProperties();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  public IIfcOptions CreateIfcOptions();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  public ILayerSettings CreateLayerSettings();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  public ITextObjectOptions CreateTextObjectOptions();
};
