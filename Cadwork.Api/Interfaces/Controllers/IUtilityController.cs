// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Structs;

namespace Cadwork.Api.Interfaces.Controllers;

using ElementId = ulong;

/// <summary>
///
/// </summary>
public interface IUtilityController
{
  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  ICollection<Vec3> GetUserPoints();

  /// <summary>
  ///
  /// </summary>
  /// <param name="pointCount"></param>
  /// <returns></returns>
  ICollection<Vec3> GetUserPointsWithCount(ulong pointCount);

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  ICollection<string> GetProjectDataKeys();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  IError GetLastError();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  Vec3 GetGlobalOrigin();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  Vec3 GetUserPoint();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  WindowGeometry Get3dMainWindowGeometry();

  /// <summary>
  ///
  /// </summary>
  /// <param name="pluginName"></param>
  /// <returns></returns>
  bool CheckAutostart(string pluginName);

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  bool GetUseOfGlobalCoordinates();

  /// <summary>
  ///
  /// </summary>
  /// <param name="message"></param>
  /// <param name="defaultToYes"></param>
  /// <returns></returns>
  bool GetUserBool(string message, bool defaultToYes);

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  bool IsDirectInfoEnabled();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  bool IsNorthArrowVisible();

  /// <summary>
  ///
  /// </summary>
  /// <param name="pluginName"></param>
  /// <returns></returns>
  bool RunExternalProgram(string pluginName);

  /// <summary>
  ///
  /// </summary>
  /// <param name="fileName"></param>
  /// <returns></returns>
  bool RunExternalProgramFromCustomDirectory(string fileName);

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  double GetGlobalXOffset();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  double GetGlobalYOffset();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  double GetGlobalZOffset();

  /// <summary>
  ///
  /// </summary>
  /// <param name="value"></param>
  /// <returns></returns>
  double GetMillimetreFromImperialString(string value);

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  double GetNorthAngle();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  double GetProjectElevation();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  double GetProjectLatitude();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  double GetProjectLongitude();

  /// <summary>
  ///
  /// </summary>
  /// <param name="message"></param>
  /// <returns></returns>
  double GetUserDouble(string message);

  /// <summary>
  ///
  /// </summary>
  /// <param name="message"></param>
  /// <param name="defaultValue"></param>
  /// <returns></returns>
  double GetUserDoubleWithDefaultValue(string message, double defaultValue);

  /// <summary>
  ///
  /// </summary>
  /// <param name="message"></param>
  /// <returns></returns>
  int GetUserInt(string message);

  /// <summary>
  ///
  /// </summary>
  /// <param name="message"></param>
  /// <param name="defaultValue"></param>
  /// <returns></returns>
  int GetUserIntWithDefaultValue(string message, int defaultValue);

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  Guid CreateNewGuid();

  /// <summary>
  ///
  /// </summary>
  /// <param name="format"></param>
  /// <param name="quality"></param>
  /// <param name="useWhiteBackground"></param>
  /// <returns></returns>
  string CreateSnapshot(ImageFormat format, int quality, bool useWhiteBackground);

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  string Get3dAngularDisplayUnits();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  string Get3dAngularUnits();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  string Get3dBuildDate();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  string Get3dFileName();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  string Get3dFilePath();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  string Get3dLinearDisplayUnits();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  string Get3dLinearUnits();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  string Get3dUserProfilePath();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  string GetClientNumber();

  /// <summary>
  ///
  /// </summary>
  /// <param name="value"></param>
  /// <returns></returns>
  string GetImperialStringFromMillimetre(double value);

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  string GetLanguage();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  string GetLicenceFirstPart();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  string GetLicenceSecondPart();

  /// <summary>
  ///
  /// </summary>
  /// <param name="filter"></param>
  /// <returns></returns>
  string GetNewUserFileFromDialog(string filter);

  /// <summary>
  ///
  /// </summary>
  /// <param name="filter"></param>
  /// <param name="path"></param>
  /// <returns></returns>
  string GetNewUserFileFromDialogInPath(string filter, string path);

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  string GetPluginPath();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  string GetProjectAddress();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  string GetProjectArchitect();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  string GetProjectCity();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  string GetProjectCountry();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  string GetProjectCustomer();

  /// <summary>
  ///
  /// </summary>
  /// <param name="id"></param>
  /// <returns></returns>
  string GetProjectData(string id);

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  string GetProjectDeadline();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  string GetProjectDescription();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  string GetProjectDesigner();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  Guid GetProjectGuid();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  string GetProjectName();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  string GetProjectNumber();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  string GetProjectPart();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  string GetProjectPostalCode();

  /// <summary>
  ///
  /// </summary>
  /// <param name="number"></param>
  /// <returns></returns>
  string GetProjectUserAttribute(uint number);

  /// <summary>
  ///
  /// </summary>
  /// <param name="number"></param>
  /// <returns></returns>
  string GetProjectUserAttributeName(uint number);

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  string GetUserCatalogPath();

  /// <summary>
  ///
  /// </summary>
  /// <param name="filter"></param>
  /// <returns></returns>
  string GetUserFileFromDialog(string filter);

  /// <summary>
  ///
  /// </summary>
  /// <param name="filter"></param>
  /// <param name="path"></param>
  /// <returns></returns>
  string GetUserFileFromDialogInPath(string filter, string path);

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  string GetUserPathFromDialog();

  /// <summary>
  ///
  /// </summary>
  /// <param name="path"></param>
  /// <returns></returns>
  string GetUserPathFromDialogInPath(string path);

  /// <summary>
  ///
  /// </summary>
  /// <param name="message"></param>
  /// <returns></returns>
  string GetUserString(string message);

  /// <summary>
  ///
  /// </summary>
  /// <param name="message"></param>
  /// <param name="defaultValue"></param>
  /// <returns></returns>
  string GetUserStringWithDefaultValue(string message, string defaultValue);

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  uint Get3dBuild();

  /// <summary>
  ///
  /// </summary>
  /// <returns></returns>
  uint Get3dVersion();

  /// <summary>
  ///
  /// </summary>
  /// <param name="initialColor"></param>
  /// <returns></returns>
  uint GetUserColor(uint initialColor);

  /// <summary>
  ///
  /// </summary>
  void ChangeCheckAndQueryDataToNoQueries();

  /// <summary>
  ///
  /// </summary>
  void ChangeCheckAndQueryDataToQueries();

  /// <summary>
  ///
  /// </summary>
  void ClearErrors();

  /// <summary>
  ///
  /// </summary>
  void CloseCadworkDocumentSaved();

  /// <summary>
  ///
  /// </summary>
  void CloseCadworkDocumentUnsaved();

  /// <summary>
  ///
  /// </summary>
  /// <param name="id"></param>
  void DeleteProjectData(string id);

  /// <summary>
  ///
  /// </summary>
  void DisableAutoDisplayRefresh();

  /// <summary>
  ///
  /// </summary>
  /// <param name="pluginName"></param>
  void DisableAutostart(string pluginName);

  /// <summary>
  ///
  /// </summary>
  void DisableDirectInfo();

  /// <summary>
  ///
  /// </summary>
  void DisableUpdateVariant();

  /// <summary>
  ///
  /// </summary>
  void EnableAutoDisplayRefresh();

  /// <summary>
  ///
  /// </summary>
  /// <param name="pluginName"></param>
  void EnableAutostart(string pluginName);

  /// <summary>
  ///
  /// </summary>
  void EnableDirectInfo();

  /// <summary>
  ///
  /// </summary>
  void EnableUpdateVariant();

  /// <summary>
  ///
  /// </summary>
  /// <param name="shortcutKeyModifier"></param>
  /// <param name="shortcutKey"></param>
  void ExecuteShortcut(ShortcutKeyModifier shortcutKeyModifier, ShortcutKey shortcutKey);

  /// <summary>
  ///
  /// </summary>
  /// <param name="fileName"></param>
  /// <param name="scalingFactor"></param>
  void ExportScreenToImage(string fileName, uint scalingFactor);

  /// <summary>
  ///
  /// </summary>
  void HideNorthArrow();

  /// <summary>
  ///
  /// </summary>
  void HideProgressBar();

  /// <summary>
  ///
  /// </summary>
  void InitLxSdk();

  /// <summary>
  ///
  /// </summary>
  /// <param name="fileName"></param>
  void LoadAttributeDisplaySettings(string fileName);

  /// <summary>
  ///
  /// </summary>
  /// <param name="fileName"></param>
  /// <param name="elementIds"></param>
  void LoadElementAttributeDisplaySettings(string fileName, ICollection<ElementId> elementIds);

  /// <summary>
  ///
  /// </summary>
  void PopCheckAndQueryData();

  /// <summary>
  ///
  /// </summary>
  /// <param name="message"></param>
  void PrintError(string message);

  /// <summary>
  ///
  /// </summary>
  /// <param name="message"></param>
  /// <param name="row"></param>
  /// <param name="column"></param>
  void PrintMessage(string message, uint row, uint column);

  /// <summary>
  ///
  /// </summary>
  /// <param name="message"></param>
  void PrintToConsole(string message);

  /// <summary>
  ///
  /// </summary>
  void PushCheckAndQueryData();

  /// <summary>
  ///
  /// </summary>
  void Save3dFileSilently();

  /// <summary>
  ///
  /// </summary>
  /// <param name="globalOrigin"></param>
  void SetGlobalOrigin(Vec3 globalOrigin);

  /// <summary>
  ///
  /// </summary>
  /// <param name="offset"></param>
  void SetGlobalXOffset(double offset);

  /// <summary>
  ///
  /// </summary>
  /// <param name="offset"></param>
  void SetGlobalYOffset(double offset);

  /// <summary>
  ///
  /// </summary>
  /// <param name="offset"></param>
  void SetGlobalZOffset(double offset);

  /// <summary>
  ///
  /// </summary>
  /// <param name="northAngle"></param>
  void SetNorthAngle(double northAngle);

  /// <summary>
  ///
  /// </summary>
  /// <param name="address"></param>
  void SetProjectAddress(string address);

  /// <summary>
  ///
  /// </summary>
  /// <param name="projectArchitect"></param>
  void SetProjectArchitect(string projectArchitect);

  /// <summary>
  ///
  /// </summary>
  /// <param name="city"></param>
  void SetProjectCity(string city);

  /// <summary>
  ///
  /// </summary>
  /// <param name="country"></param>
  void SetProjectCountry(string country);

  /// <summary>
  ///
  /// </summary>
  /// <param name="projectCustomer"></param>
  void SetProjectCustomer(string projectCustomer);

  /// <summary>
  ///
  /// </summary>
  /// <param name="id"></param>
  /// <param name="data"></param>
  void SetProjectData(string id, string data);

  /// <summary>
  ///
  /// </summary>
  /// <param name="projectDeadline"></param>
  void SetProjectDeadline(string projectDeadline);

  /// <summary>
  ///
  /// </summary>
  /// <param name="description"></param>
  void SetProjectDescription(string description);

  /// <summary>
  ///
  /// </summary>
  /// <param name="projectDesigner"></param>
  void SetProjectDesigner(string projectDesigner);

  /// <summary>
  ///
  /// </summary>
  /// <param name="elevation"></param>
  void SetProjectElevation(double elevation);

  /// <summary>
  ///
  /// </summary>
  /// <param name="latitude"></param>
  void SetProjectLatitude(double latitude);

  /// <summary>
  ///
  /// </summary>
  /// <param name="longitude"></param>
  void SetProjectLongitude(double longitude);

  /// <summary>
  ///
  /// </summary>
  /// <param name="projectName"></param>
  void SetProjectName(string projectName);

  /// <summary>
  ///
  /// </summary>
  /// <param name="projectNumber"></param>
  void SetProjectNumber(string projectNumber);

  /// <summary>
  ///
  /// </summary>
  /// <param name="projectPart"></param>
  void SetProjectPart(string projectPart);

  /// <summary>
  ///
  /// </summary>
  /// <param name="postalCode"></param>
  void SetProjectPostalCode(string postalCode);

  /// <summary>
  ///
  /// </summary>
  /// <param name="number"></param>
  /// <param name="userAttribute"></param>
  void SetProjectUserAttribute(uint number, string userAttribute);

  /// <summary>
  ///
  /// </summary>
  /// <param name="number"></param>
  /// <param name="userAttributeName"></param>
  void SetProjectUserAttributeName(uint number, string userAttributeName);

  /// <summary>
  ///
  /// </summary>
  /// <param name="useGlobalCoordinates"></param>
  void SetUseOfGlobalCoordinates(bool useGlobalCoordinates);

  /// <summary>
  ///
  /// </summary>
  void ShowNorthArrow();

  /// <summary>
  ///
  /// </summary>
  void ShowProgressBar();

  /// <summary>
  ///
  /// </summary>
  void StartProjectDataDialog();

  /// <summary>
  ///
  /// </summary>
  /// <param name="value"></param>
  void UpdateProgressBar(int value);
};
