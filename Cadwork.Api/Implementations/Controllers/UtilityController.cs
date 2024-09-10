// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Extensions;
using Cadwork.Api.Implementations.Helpers;
using Cadwork.Api.Interfaces.Controllers;
using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Interop.Wrappers.Controllers;
using Cadwork.Api.Interop.Wrappers.Factories;
using Cadwork.Api.Structs;

namespace Cadwork.Api.Implementations.Controllers;

internal class UtilityController(ControllerFactoryWrapper factoryWrapper) : IUtilityController
{
  private readonly UtilityControllerWrapper _controllerWrapper = new(factoryWrapper.GetUtilityController());

  public ICollection<Vec3> GetUserPoints()
  {
    return _controllerWrapper.GetUserPoints().ToManagedVectorList();
  }

  public ICollection<Vec3> GetUserPointsWithCount(ulong pointCount)
  {
    return _controllerWrapper.GetUserPointsWithCount(pointCount).ToManagedVectorList();
  }

  public ICollection<string> GetProjectDataKeys()
  {
    return _controllerWrapper.GetProjectDataKeys().ToManagedStringList();
  }

  public IError GetLastError()
  {
    const int errorCode = 0;
    var errorMessage = _controllerWrapper.GetLastError(errorCode);
    return new Error { Code = errorCode, Message = errorMessage.ToManagedString() };
  }

  public Vec3 GetGlobalOrigin()
  {
    return _controllerWrapper.GetGlobalOrigin().ToManagedVector();
  }

  public Vec3 GetUserPoint()
  {
    return _controllerWrapper.GetUserPoint().ToManagedVector();
  }

  public WindowGeometry Get3dMainWindowGeometry()
  {
    return _controllerWrapper.Get3dMainWindowGeometry().ToManagedWindowGeometry();
  }

  public bool CheckAutostart(string pluginName)
  {
    return _controllerWrapper.CheckAutostart(pluginName);
  }

  public bool GetUseOfGlobalCoordinates()
  {
    return _controllerWrapper.GetUseOfGlobalCoordinates();
  }

  public bool GetUserBool(string message, bool defaultToYes)
  {
    return _controllerWrapper.GetUserBool(message, defaultToYes);
  }

  public bool IsDirectInfoEnabled()
  {
    return _controllerWrapper.IsDirectInfoEnabled();
  }

  public bool IsNorthArrowVisible()
  {
    return _controllerWrapper.IsNorthArrowVisible();
  }

  public bool RunExternalProgram(string pluginName)
  {
    return _controllerWrapper.RunExternalProgram(pluginName);
  }

  public bool RunExternalProgramFromCustomDirectory(string fileName)
  {
    return _controllerWrapper.RunExternalProgramFromCustomDirectory(fileName);
  }

  public double GetGlobalXOffset()
  {
    return _controllerWrapper.GetGlobalXOffset();
  }

  public double GetGlobalYOffset()
  {
    return _controllerWrapper.GetGlobalYOffset();
  }

  public double GetGlobalZOffset()
  {
    return _controllerWrapper.GetGlobalZOffset();
  }

  public double GetMillimetreFromImperialString(string value)
  {
    return _controllerWrapper.GetMillimetreFromImperialString(value);
  }

  public double GetNorthAngle()
  {
    return _controllerWrapper.GetNorthAngle();
  }

  public double GetProjectElevation()
  {
    return _controllerWrapper.GetProjectElevation();
  }

  public double GetProjectLatitude()
  {
    return _controllerWrapper.GetProjectLatitude();
  }

  public double GetProjectLongitude()
  {
    return _controllerWrapper.GetProjectLongitude();
  }

  public double GetUserDouble(string message)
  {
    return _controllerWrapper.GetUserDouble(message);
  }

  public double GetUserDoubleWithDefaultValue(string message, double defaultValue)
  {
    return _controllerWrapper.GetUserDoubleWithDefaultValue(message, defaultValue);
  }

  public int GetUserInt(string message)
  {
    return _controllerWrapper.GetUserInt(message);
  }

  public int GetUserIntWithDefaultValue(string message, int defaultValue)
  {
    return _controllerWrapper.GetUserIntWithDefaultValue(message, defaultValue);
  }

  public Guid CreateNewGuid()
  {
    return _controllerWrapper.CreateNewGuid().ToManagedGuid();
  }

  public string CreateSnapshot(ImageFormat format, int quality, bool useWhiteBackground)
  {
    return _controllerWrapper.CreateSnapshot(format.ToNativeImageFormat(), quality, useWhiteBackground).ToManagedString();
  }

  public string Get3dAngularDisplayUnits()
  {
    return _controllerWrapper.Get3DAngularDisplayUnits().ToManagedString(); // TODO: Should be enum
  }

  public string Get3dAngularUnits()
  {
    return _controllerWrapper.Get3DAngularUnits().ToManagedString(); // TODO: Should be enum
  }

  public string Get3dBuildDate()
  {
    return _controllerWrapper.Get3DBuildDate().ToManagedString(); // TODO: Maybe DateTime?
  }

  public string Get3dFileName()
  {
    return _controllerWrapper.Get3DFileName().ToManagedString();
  }

  public string Get3dFilePath()
  {
    return _controllerWrapper.Get3DFilePath().ToManagedString();
  }

  public string Get3dLinearDisplayUnits()
  {
    return _controllerWrapper.Get3DLinearDisplayUnits().ToManagedString(); // TODO: Should be enum
  }

  public string Get3dLinearUnits()
  {
    return _controllerWrapper.Get3DLinearUnits().ToManagedString(); // TODO: Should be enum
  }

  public string Get3dUserProfilePath()
  {
    return _controllerWrapper.Get3DUserProfilePath().ToManagedString();
  }

  public string GetClientNumber()
  {
    return _controllerWrapper.GetClientNumber().ToManagedString();
  }

  public string GetImperialStringFromMillimetre(double value)
  {
    return _controllerWrapper.GetImperialStringFromMillimetre(value).ToManagedString();
  }

  public string GetLanguage()
  {
    return _controllerWrapper.GetLanguage().ToManagedString();
  }

  public string GetLicenceFirstPart()
  {
    return _controllerWrapper.GetLicenceFirstPart().ToManagedString();
  }

  public string GetLicenceSecondPart()
  {
    return _controllerWrapper.GetLicenceSecondPart().ToManagedString();
  }

  public string GetNewUserFileFromDialog(string filter)
  {
    return _controllerWrapper.GetNewUserFileFromDialog(filter).ToManagedString();
  }

  public string GetNewUserFileFromDialogInPath(string filter, string path)
  {
    return _controllerWrapper.GetNewUserFileFromDialogInPath(filter, path).ToManagedString();
  }

  public string GetPluginPath()
  {
    return _controllerWrapper.GetPluginPath().ToManagedString();
  }

  public string GetProjectAddress()
  {
    return _controllerWrapper.GetProjectAddress().ToManagedString();
  }

  public string GetProjectArchitect()
  {
    return _controllerWrapper.GetProjectArchitect().ToManagedString();
  }

  public string GetProjectCity()
  {
    return _controllerWrapper.GetProjectCity().ToManagedString();
  }

  public string GetProjectCountry()
  {
    return _controllerWrapper.GetProjectCountry().ToManagedString();
  }

  public string GetProjectCustomer()
  {
    return _controllerWrapper.GetProjectCustomer().ToManagedString();
  }

  public string GetProjectData(string id)
  {
    return _controllerWrapper.GetProjectData(id).ToManagedString();
  }

  public string GetProjectDeadline()
  {
    return _controllerWrapper.GetProjectDeadline().ToManagedString();
  }

  public string GetProjectDescription()
  {
    return _controllerWrapper.GetProjectDescription().ToManagedString();
  }

  public string GetProjectDesigner()
  {
    return _controllerWrapper.GetProjectDesigner().ToManagedString();
  }

  public Guid GetProjectGuid()
  {
    return _controllerWrapper.GetProjectGuid().ToManagedGuid();
  }

  public string GetProjectName()
  {
    return _controllerWrapper.GetProjectName().ToManagedString();
  }

  public string GetProjectNumber()
  {
    return _controllerWrapper.GetProjectNumber().ToManagedString();
  }

  public string GetProjectPart()
  {
    return _controllerWrapper.GetProjectPart().ToManagedString();
  }

  public string GetProjectPostalCode()
  {
    return _controllerWrapper.GetProjectPostalCode().ToManagedString();
  }

  public string GetProjectUserAttribute(uint number)
  {
    return _controllerWrapper.GetProjectUserAttribute(number).ToManagedString();
  }

  public string GetProjectUserAttributeName(uint number)
  {
    return _controllerWrapper.GetProjectUserAttributeName(number).ToManagedString();
  }

  public string GetUserCatalogPath()
  {
    return _controllerWrapper.GetUserCatalogPath().ToManagedString();
  }

  public string GetUserFileFromDialog(string filter)
  {
    return _controllerWrapper.GetUserFileFromDialog(filter).ToManagedString();
  }

  public string GetUserFileFromDialogInPath(string filter, string path)
  {
    return _controllerWrapper.GetUserFileFromDialogInPath(filter, path).ToManagedString();
  }

  public string GetUserPathFromDialog()
  {
    return _controllerWrapper.GetUserPathFromDialog().ToManagedString();
  }

  public string GetUserPathFromDialogInPath(string path)
  {
    return _controllerWrapper.GetUserPathFromDialogInPath(path).ToManagedString();
  }

  public string GetUserString(string message)
  {
    return _controllerWrapper.GetUserString(message).ToManagedString();
  }

  public string GetUserStringWithDefaultValue(string message, string defaultValue)
  {
    return _controllerWrapper.GetUserStringWithDefaultValue(message, defaultValue).ToManagedString();
  }

  public uint Get3dBuild()
  {
    return _controllerWrapper.Get3DBuild();
  }

  public uint Get3dVersion()
  {
    return _controllerWrapper.Get3DVersion();
  }

  public uint GetUserColor(uint initialColor)
  {
    return _controllerWrapper.GetUserColor(initialColor);
  }

  public void ChangeCheckAndQueryDataToNoQueries()
  {
    _controllerWrapper.ChangeCheckAndQueryDataToNoQueries();
  }

  public void ChangeCheckAndQueryDataToQueries()
  {
    _controllerWrapper.ChangeCheckAndQueryDataToQueries();
  }

  public void ClearErrors()
  {
    _controllerWrapper.ClearErrors();
  }

  public void CloseCadworkDocumentSaved()
  {
    _controllerWrapper.CloseCadworkDocumentSaved();
  }

  public void CloseCadworkDocumentUnsaved()
  {
    _controllerWrapper.CloseCadworkDocumentUnsaved();
  }

  public void DeleteProjectData(string id)
  {
    _controllerWrapper.DeleteProjectData(id);
  }

  public void DisableAutoDisplayRefresh()
  {
    _controllerWrapper.DisableAutoDisplayRefresh();
  }

  public void DisableAutostart(string pluginName)
  {
    _controllerWrapper.DisableAutostart(pluginName);
  }

  public void DisableDirectInfo()
  {
    _controllerWrapper.DisableDirectInfo();
  }

  public void DisableUpdateVariant()
  {
    _controllerWrapper.DisableUpdateVariant();
  }

  public void EnableAutoDisplayRefresh()
  {
    _controllerWrapper.EnableAutoDisplayRefresh();
  }

  public void EnableAutostart(string pluginName)
  {
    _controllerWrapper.EnableAutostart(pluginName);
  }

  public void EnableDirectInfo()
  {
    _controllerWrapper.EnableDirectInfo();
  }

  public void EnableUpdateVariant()
  {
    _controllerWrapper.EnableUpdateVariant();
  }

  public void ExecuteShortcut(ShortcutKeyModifier shortcutKeyModifier, ShortcutKey shortcutKey)
  {
    _controllerWrapper.ExecuteShortcut(shortcutKeyModifier.ToNativeShortcutKeyModifier(), shortcutKey.ToNativeShortcutKey());
  }

  public void ExportScreenToImage(string fileName, uint scalingFactor)
  {
    _controllerWrapper.ExportScreenToImage(fileName, scalingFactor);
  }

  public void HideNorthArrow()
  {
    _controllerWrapper.HideNorthArrow();
  }

  public void HideProgressBar()
  {
    _controllerWrapper.HideProgressBar();
  }

  public void InitLxSdk()
  {
    _controllerWrapper.InitLxSdk();
  }

  public void LoadAttributeDisplaySettings(string fileName)
  {
    _controllerWrapper.LoadAttributeDisplaySettings(fileName);
  }

  public void LoadElementAttributeDisplaySettings(string fileName, ICollection<ulong> elementIds)
  {
    _controllerWrapper.LoadElementAttributeDisplaySettings(fileName, elementIds.ToNativeElementIdList(factoryWrapper));
  }

  public void PopCheckAndQueryData()
  {
    _controllerWrapper.PopCheckAndQueryData();
  }

  public void PrintError(string message)
  {
    _controllerWrapper.PrintError(message);
  }

  public void PrintMessage(string message, uint row, uint column)
  {
    _controllerWrapper.PrintMessage(message, row, column);
  }

  public void PrintToConsole(string message)
  {
    _controllerWrapper.PrintToConsole(message);
  }

  public void PushCheckAndQueryData()
  {
    _controllerWrapper.PushCheckAndQueryData();
  }

  public void Save3dFileSilently()
  {
    _controllerWrapper.Save3DFileSilently();
  }

  public void SetGlobalOrigin(Vec3 globalOrigin)
  {
    _controllerWrapper.SetGlobalOrigin(globalOrigin.ToNativeVector());
  }

  public void SetGlobalXOffset(double offset)
  {
    _controllerWrapper.SetGlobalXOffset(offset);
  }

  public void SetGlobalYOffset(double offset)
  {
    _controllerWrapper.SetGlobalYOffset(offset);
  }

  public void SetGlobalZOffset(double offset)
  {
    _controllerWrapper.SetGlobalZOffset(offset);
  }

  public void SetNorthAngle(double northAngle)
  {
    _controllerWrapper.SetNorthAngle(northAngle);
  }

  public void SetProjectAddress(string address)
  {
    _controllerWrapper.SetProjectAddress(address);
  }

  public void SetProjectArchitect(string projectArchitect)
  {
    _controllerWrapper.SetProjectArchitect(projectArchitect);
  }

  public void SetProjectCity(string city)
  {
    _controllerWrapper.SetProjectCity(city);
  }

  public void SetProjectCountry(string country)
  {
    _controllerWrapper.SetProjectCountry(country);
  }

  public void SetProjectCustomer(string projectCustomer)
  {
    _controllerWrapper.SetProjectCustomer(projectCustomer);
  }

  public void SetProjectData(string id, string data)
  {
    _controllerWrapper.SetProjectData(id, data);
  }

  public void SetProjectDeadline(string projectDeadline)
  {
    _controllerWrapper.SetProjectDeadline(projectDeadline);
  }

  public void SetProjectDescription(string description)
  {
    _controllerWrapper.SetProjectDescription(description);
  }

  public void SetProjectDesigner(string projectDesigner)
  {
    _controllerWrapper.SetProjectDesigner(projectDesigner);
  }

  public void SetProjectElevation(double elevation)
  {
    _controllerWrapper.SetProjectElevation(elevation);
  }

  public void SetProjectLatitude(double latitude)
  {
    _controllerWrapper.SetProjectLatitude(latitude);
  }

  public void SetProjectLongitude(double longitude)
  {
    _controllerWrapper.SetProjectLongitude(longitude);
  }

  public void SetProjectName(string projectName)
  {
    _controllerWrapper.SetProjectName(projectName);
  }

  public void SetProjectNumber(string projectNumber)
  {
    _controllerWrapper.SetProjectNumber(projectNumber);
  }

  public void SetProjectPart(string projectPart)
  {
    _controllerWrapper.SetProjectPart(projectPart);
  }

  public void SetProjectPostalCode(string postalCode)
  {
    _controllerWrapper.SetProjectPostalCode(postalCode);
  }

  public void SetProjectUserAttribute(uint number, string userAttribute)
  {
    _controllerWrapper.SetProjectUserAttribute(number, userAttribute);
  }

  public void SetProjectUserAttributeName(uint number, string userAttributeName)
  {
    _controllerWrapper.SetProjectUserAttributeName(number, userAttributeName);
  }

  public void SetUseOfGlobalCoordinates(bool useGlobalCoordinates)
  {
    _controllerWrapper.SetUseOfGlobalCoordinates(useGlobalCoordinates);
  }

  public void ShowNorthArrow()
  {
    _controllerWrapper.ShowNorthArrow();
  }

  public void ShowProgressBar()
  {
    _controllerWrapper.ShowProgressBar();
  }

  public void StartProjectDataDialog()
  {
    _controllerWrapper.StartProjectDataDialog();
  }

  public void UpdateProgressBar(int value)
  {
    _controllerWrapper.UpdateProgressBar(value);
  }
};
