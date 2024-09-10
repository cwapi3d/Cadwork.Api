// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Extensions;
using Cadwork.Api.Implementations.Helpers;
using Cadwork.Api.Interfaces.Controllers;
using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Interop.Wrappers.Controllers;
using Cadwork.Api.Interop.Wrappers.Factories;
using Cadwork.Api.Structs;

namespace Cadwork.Api.Implementations.Controllers;

using ElementId = ulong;

internal class ShopDrawingController(ControllerFactoryWrapper factoryWrapper) : IShopDrawingController
{
  private readonly ShopDrawingControllerWrapper _controllerWrapper = new(factoryWrapper.GetShopDrawingController());

  public IError GetLastError()
  {
    const int errorCode = 0;
    var errorMessage = _controllerWrapper.GetLastError(errorCode);
    return new Error { Code = errorCode, Message = errorMessage.ToManagedString() };
  }

  public void AddWallSectionHorizontal(ElementId elementId, Vec3 position)
  {
    _controllerWrapper.AddWallSectionHorizontal(elementId, position.ToNativeVector());
  }

  public void AddWallSectionVertical(ElementId elementId, Vec3 position)
  {
    _controllerWrapper.AddWallSectionVertical(elementId, position.ToNativeVector());
  }

  public void AssignToExportSolid(ICollection<ulong> exportSolidElementIds, ICollection<ulong> elementIds)
  {
    _controllerWrapper.AssignExportSolid(exportSolidElementIds.ToNativeElementIdList(factoryWrapper), elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void ClearErrors()
  {
    _controllerWrapper.ClearErrors();
  }

  public void Export2dHiddenLinesWith2dc(string aFilePath, bool withLayout)
  {
    _controllerWrapper.Export2DHiddenLinesWith2Dc(aFilePath, withLayout);
  }

  public void Export2dHiddenLinesWithClipboard(uint clipboardNumber, bool withLayout)
  {
    _controllerWrapper.Export2DHiddenLinesWithClipboard(clipboardNumber, withLayout);
  }

  public void Export2dWireframeWith2dc(string aFilePath, bool withLayout)
  {
    _controllerWrapper.Export2DWireframeWith2Dc(aFilePath, withLayout);
  }

  public void Export2dWireframeWithClipboard(uint clipboardNumber, bool withLayout)
  {
    _controllerWrapper.Export2DWireframeWithClipboard(clipboardNumber, withLayout);
  }

  public void ExportContainerWithClipboard(uint clipboardNumber, ICollection<ulong> elementIds)
  {
    _controllerWrapper.ExportContainerWithClipboard(clipboardNumber, elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void ExportExportSolidWithClipboard(uint clipboardNumber, ICollection<ulong> elementIds)
  {
    _controllerWrapper.ExportExportSolidWithClipboard(clipboardNumber, elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void ExportPieceByPieceWithClipboard(uint clipboardNumber, ICollection<ulong> elementIds)
  {
    _controllerWrapper.ExportPieceByPieceWithClipboard(clipboardNumber, elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void ExportWallWithClipboard(uint clipboardNumber, ICollection<ulong> elementIds)
  {
    _controllerWrapper.ExportWallWithClipboard(clipboardNumber, elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void ExportWallWithClipboardAndSettings(uint clipboardNumber, ICollection<ulong> elementIds, string settingsFileName)
  {
    _controllerWrapper.ExportWallWithClipboardAndPresetting(clipboardNumber, elementIds.ToNativeElementIdList(factoryWrapper), settingsFileName);
  }

  public void LoadExportContainerSettings(string fileName)
  {
    _controllerWrapper.LoadExportContainerSettings(fileName);
  }

  public void LoadExportPieceByPieceSettings(string fileName)
  {
    _controllerWrapper.LoadExportPieceByPieceSettings(fileName);
  }

  public void LoadExportSolidSettings(string fileName)
  {
    _controllerWrapper.LoadExportSolidSettings(fileName);
  }

  public void LoadExportWallSettings(string fileName)
  {
    _controllerWrapper.LoadExportWallSettings(fileName);
  }

  public void SaveExportPieceByPieceSettings(string fileName)
  {
    _controllerWrapper.SaveExportPieceByPieceSettings(fileName);
  }
};
