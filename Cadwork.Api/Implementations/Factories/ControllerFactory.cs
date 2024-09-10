// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Implementations.Controllers;
using Cadwork.Api.Implementations.Helpers;
using Cadwork.Api.Interfaces.Controllers;
using Cadwork.Api.Interfaces.Factories;
using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Interop.Wrappers.Factories;

namespace Cadwork.Api.Implementations.Factories;

public sealed class ControllerFactory : IControllerFactory
{
  public static IControllerFactory GetControllerFactory(IntPtr factory)
  {
    return new ControllerFactory(factory);
  }

  public IAttributeController AttributeController { get; }
  public IBimController BimController { get; }
  public IConnectorAxisController ConnectorAxisController { get; }
  public IDimensionController DimensionController { get; }
  public IElementController ElementController { get; }
  public IEndTypeController EndTypeController { get; }
  public IFileController FileController { get; }
  public IGeometryController GeometryController { get; }
  public IGridController GridController { get; }
  public IListController ListController { get; }
  public IMachineController MachineController { get; }
  public IMaterialController MaterialController { get; }
  public IMenuController MenuController { get; }
  public IMultiLayerWallController MultiLayerWallController { get; }
  public IRoofController RoofController { get; }
  public ISceneController SceneController { get; }
  public IShopDrawingController ShopDrawingController { get; }
  public IUtilityController UtilityController { get; }
  public IVisualizationController VisualizationController { get; }

  internal ControllerFactory(IntPtr factory)
  {
    var controllerFactoryWrapper = new ControllerFactoryWrapper(factory);

    AttributeController = new AttributeController(controllerFactoryWrapper);
    BimController = new BimController(controllerFactoryWrapper);
    ConnectorAxisController = new ConnectorAxisController(controllerFactoryWrapper);
    DimensionController = new DimensionController(controllerFactoryWrapper);
    ElementController = new ElementController(controllerFactoryWrapper);
    EndTypeController = new EndTypeController(controllerFactoryWrapper);
    FileController = new FileController(controllerFactoryWrapper);
    GeometryController = new GeometryController(controllerFactoryWrapper);
    GridController = new GridController(controllerFactoryWrapper);
    ListController = new ListController(controllerFactoryWrapper);
    MachineController = new MachineController(controllerFactoryWrapper);
    MaterialController = new MaterialController(controllerFactoryWrapper);
    MenuController = new MenuController(controllerFactoryWrapper);
    MultiLayerWallController = new MultiLayerWallController(controllerFactoryWrapper);
    RoofController = new RoofController(controllerFactoryWrapper);
    SceneController = new SceneController(controllerFactoryWrapper);
    ShopDrawingController = new ShopDrawingController(controllerFactoryWrapper);
    UtilityController = new UtilityController(controllerFactoryWrapper);
    VisualizationController = new VisualizationController(controllerFactoryWrapper);
  }

  public ICameraData CreateCameraData()
  {
    return new CameraData();
  }

  public IElementModuleProperties CreateElementModuleProperties()
  {
    return new ElementModuleProperties();
  }

  public IIfcOptions CreateIfcOptions()
  {
    return new IfcOptions();
  }

  public ILayerSettings CreateLayerSettings()
  {
    return new LayerSettings();
  }

  public ITextObjectOptions CreateTextObjectOptions()
  {
    return new TextObjectOptions();
  }
};
