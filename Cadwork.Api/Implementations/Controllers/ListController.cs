// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Extensions;
using Cadwork.Api.Implementations.Helpers;
using Cadwork.Api.Interfaces.Controllers;
using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Interop.Wrappers.Controllers;
using Cadwork.Api.Interop.Wrappers.Factories;

namespace Cadwork.Api.Implementations.Controllers;

internal class ListController(ControllerFactoryWrapper factoryWrapper) : IListController
{
  private readonly ListControllerWrapper _controllerWrapper = new(factoryWrapper.GetListController());

  public ICollection<ulong> CheckItemListPositionNumber()
  {
    return _controllerWrapper.CheckPositionNumbersPartList().ToManagedElementIdList();
  }

  public ICollection<ulong> CheckProductionListPositionNumbers()
  {
    return _controllerWrapper.CheckPositionNumbersProductionList().ToManagedElementIdList();
  }

  public IError GetLastError()
  {
    const int errorCode = 0;
    var errorMessage = _controllerWrapper.GetLastError(errorCode);
    return new Error { Code = errorCode, Message = errorMessage.ToManagedString() };
  }

  public void ClearErrors()
  {
    _controllerWrapper.ClearErrors();
  }

  public void ExportItemList(ICollection<ulong> elementIds, string fileName)
  {
    _controllerWrapper.ExportPartList(elementIds.ToNativeElementIdList(factoryWrapper), fileName);
  }

  public void ExportItemListWithSettings(ICollection<ulong> elementIds, string fileName, string settings)
  {
    _controllerWrapper.ExportPartListWithSettings(elementIds.ToNativeElementIdList(factoryWrapper), fileName, settings);
  }

  public void ExportProductionList(ICollection<ulong> elementIds, string fileName)
  {
    _controllerWrapper.ExportProductionList(elementIds.ToNativeElementIdList(factoryWrapper), fileName);
  }

  public void ExportProductionListWithSettings(ICollection<ulong> elementIds, string fileName, string settings)
  {
    _controllerWrapper.ExportProductionListWithSettings(elementIds.ToNativeElementIdList(factoryWrapper), fileName, settings);
  }

  public void ExportRoughVolumeList(ICollection<ulong> elementIds, string fileName)
  {
    _controllerWrapper.ExportCoverList(elementIds.ToNativeElementIdList(factoryWrapper), fileName);
  }

  public void ExportRoughVolumeListWithSettings(ICollection<ulong> elementIds, string fileName, string settings)
  {
    _controllerWrapper.ExportCoverListWithSettings(elementIds.ToNativeElementIdList(factoryWrapper), fileName, settings);
  }

  public void LoadItemListCalculationSettings(string settings)
  {
    _controllerWrapper.LoadListCalculationSettingsPartList(settings);
  }

  public void LoadProductionListCalculationSettings(string settings)
  {
    _controllerWrapper.LoadListCalculationSettingsProductionList(settings);
  }

  public void RegenerateItemListNumbers(ICollection<ulong> elementIds)
  {
    _controllerWrapper.GenerateNewNumbersPartList(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void RegenerateItemListNumbersSilently(ICollection<ulong> elementIds, uint startNumber, bool keepExistingNumbers, bool withContainers)
  {
    _controllerWrapper.GenerateNewNumbersPartListSilently(elementIds.ToNativeElementIdList(factoryWrapper), startNumber, keepExistingNumbers, withContainers);
  }

  public void RegenerateProductionListNumbers(ICollection<ulong> elementIds)
  {
    _controllerWrapper.GenerateNewNumbersProductionList(elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void RegenerateProductionListNumbersSilently(ICollection<ulong> elementIds, uint startNumber, bool keepExistingNumbers, bool withContainers)
  {
    _controllerWrapper.GenerateNewNumbersProductionListSilently(elementIds.ToNativeElementIdList(factoryWrapper), startNumber, keepExistingNumbers, withContainers);
  }
};
