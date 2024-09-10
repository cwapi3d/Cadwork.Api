// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;
using Cadwork.Api.Interop.Wrappers.Structs;

namespace Cadwork.Api.Interop.Wrappers.Controllers;

public class UtilityControllerWrapper
{
  private readonly IntPtr _nativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public UtilityControllerWrapper(IntPtr nativePtr)
  {
    _nativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<UtilityControllerInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(GetLastErrorDelegate), Marshal.GetDelegateForFunctionPointer<GetLastErrorDelegate>(vTable!.getLastErrorFunctionPtr) },
      { typeof(Get3DVersionDelegate), Marshal.GetDelegateForFunctionPointer<Get3DVersionDelegate>(vTable.get3DVersionFunctionPtr) },
      { typeof(Get3DBuildDelegate), Marshal.GetDelegateForFunctionPointer<Get3DBuildDelegate>(vTable.get3DBuildFunctionPtr) },
      { typeof(Get3DWindowHandleDelegate), Marshal.GetDelegateForFunctionPointer<Get3DWindowHandleDelegate>(vTable.get3DWindowHandleFunctionPtr) },
      { typeof(Get3DFileNameDelegate), Marshal.GetDelegateForFunctionPointer<Get3DFileNameDelegate>(vTable.get3DFileNameFunctionPtr) },
      { typeof(Get3DFilePathDelegate), Marshal.GetDelegateForFunctionPointer<Get3DFilePathDelegate>(vTable.get3DFilePathFunctionPtr) },
      { typeof(SetProjectDataDelegate), Marshal.GetDelegateForFunctionPointer<SetProjectDataDelegate>(vTable.setProjectDataFunctionPtr) },
      { typeof(GetProjectDataDelegate), Marshal.GetDelegateForFunctionPointer<GetProjectDataDelegate>(vTable.getProjectDataFunctionPtr) },
      { typeof(PrintErrorDelegate), Marshal.GetDelegateForFunctionPointer<PrintErrorDelegate>(vTable.printErrorFunctionPtr) },
      { typeof(GetLanguageDelegate), Marshal.GetDelegateForFunctionPointer<GetLanguageDelegate>(vTable.getLanguageFunctionPtr) },
      { typeof(PrintMessageDelegate), Marshal.GetDelegateForFunctionPointer<PrintMessageDelegate>(vTable.printMessageFunctionPtr) },
      { typeof(GetUserIntDelegate), Marshal.GetDelegateForFunctionPointer<GetUserIntDelegate>(vTable.getUserIntFunctionPtr) },
      { typeof(GetUserDoubleDelegate), Marshal.GetDelegateForFunctionPointer<GetUserDoubleDelegate>(vTable.getUserDoubleFunctionPtr) },
      { typeof(GetUserBoolDelegate), Marshal.GetDelegateForFunctionPointer<GetUserBoolDelegate>(vTable.getUserBoolFunctionPtr) },
      { typeof(GetUserStringDelegate), Marshal.GetDelegateForFunctionPointer<GetUserStringDelegate>(vTable.getUserStringFunctionPtr) },
      { typeof(GetProjectNameDelegate), Marshal.GetDelegateForFunctionPointer<GetProjectNameDelegate>(vTable.getProjectNameFunctionPtr) },
      { typeof(SetProjectNameDelegate), Marshal.GetDelegateForFunctionPointer<SetProjectNameDelegate>(vTable.setProjectNameFunctionPtr) },
      { typeof(GetProjectNumberDelegate), Marshal.GetDelegateForFunctionPointer<GetProjectNumberDelegate>(vTable.getProjectNumberFunctionPtr) },
      { typeof(SetProjectNumberDelegate), Marshal.GetDelegateForFunctionPointer<SetProjectNumberDelegate>(vTable.setProjectNumberFunctionPtr) },
      { typeof(GetProjectPartDelegate), Marshal.GetDelegateForFunctionPointer<GetProjectPartDelegate>(vTable.getProjectPartFunctionPtr) },
      { typeof(SetProjectPartDelegate), Marshal.GetDelegateForFunctionPointer<SetProjectPartDelegate>(vTable.setProjectPartFunctionPtr) },
      { typeof(GetProjectArchitectDelegate), Marshal.GetDelegateForFunctionPointer<GetProjectArchitectDelegate>(vTable.getProjectArchitectFunctionPtr) },
      { typeof(SetProjectArchitectDelegate), Marshal.GetDelegateForFunctionPointer<SetProjectArchitectDelegate>(vTable.setProjectArchitectFunctionPtr) },
      { typeof(GetProjectCustomerDelegate), Marshal.GetDelegateForFunctionPointer<GetProjectCustomerDelegate>(vTable.getProjectCustomerFunctionPtr) },
      { typeof(SetProjectCustomerDelegate), Marshal.GetDelegateForFunctionPointer<SetProjectCustomerDelegate>(vTable.setProjectCustomerFunctionPtr) },
      { typeof(GetProjectDesignerDelegate), Marshal.GetDelegateForFunctionPointer<GetProjectDesignerDelegate>(vTable.getProjectDesignerFunctionPtr) },
      { typeof(SetProjectDesignerDelegate), Marshal.GetDelegateForFunctionPointer<SetProjectDesignerDelegate>(vTable.setProjectDesignerFunctionPtr) },
      { typeof(GetProjectDeadlineDelegate), Marshal.GetDelegateForFunctionPointer<GetProjectDeadlineDelegate>(vTable.getProjectDeadlineFunctionPtr) },
      { typeof(SetProjectDeadlineDelegate), Marshal.GetDelegateForFunctionPointer<SetProjectDeadlineDelegate>(vTable.setProjectDeadlineFunctionPtr) },
      { typeof(GetProjectUserAttributeDelegate), Marshal.GetDelegateForFunctionPointer<GetProjectUserAttributeDelegate>(vTable.getProjectUserAttributeFunctionPtr) },
      { typeof(SetProjectUserAttributeDelegate), Marshal.GetDelegateForFunctionPointer<SetProjectUserAttributeDelegate>(vTable.setProjectUserAttributeFunctionPtr) },
      { typeof(GetProjectUserAttributeNameDelegate), Marshal.GetDelegateForFunctionPointer<GetProjectUserAttributeNameDelegate>(vTable.getProjectUserAttributeNameFunctionPtr) },
      { typeof(SetProjectUserAttributeNameDelegate), Marshal.GetDelegateForFunctionPointer<SetProjectUserAttributeNameDelegate>(vTable.setProjectUserAttributeNameFunctionPtr) },
      { typeof(GetProjectLatitudeDelegate), Marshal.GetDelegateForFunctionPointer<GetProjectLatitudeDelegate>(vTable.getProjectLatitudeFunctionPtr) },
      { typeof(GetProjectLongitudeDelegate), Marshal.GetDelegateForFunctionPointer<GetProjectLongitudeDelegate>(vTable.getProjectLongitudeFunctionPtr) },
      { typeof(SetProjectLatitudeDelegate), Marshal.GetDelegateForFunctionPointer<SetProjectLatitudeDelegate>(vTable.setProjectLatitudeFunctionPtr) },
      { typeof(SetProjectLongitudeDelegate), Marshal.GetDelegateForFunctionPointer<SetProjectLongitudeDelegate>(vTable.setProjectLongitudeFunctionPtr) },
      { typeof(GetProjectAddressDelegate), Marshal.GetDelegateForFunctionPointer<GetProjectAddressDelegate>(vTable.getProjectAddressFunctionPtr) },
      { typeof(SetProjectAddressDelegate), Marshal.GetDelegateForFunctionPointer<SetProjectAddressDelegate>(vTable.setProjectAddressFunctionPtr) },
      { typeof(GetProjectPostalCodeDelegate), Marshal.GetDelegateForFunctionPointer<GetProjectPostalCodeDelegate>(vTable.getProjectPostalCodeFunctionPtr) },
      { typeof(SetProjectPostalCodeDelegate), Marshal.GetDelegateForFunctionPointer<SetProjectPostalCodeDelegate>(vTable.setProjectPostalCodeFunctionPtr) },
      { typeof(GetProjectCityDelegate), Marshal.GetDelegateForFunctionPointer<GetProjectCityDelegate>(vTable.getProjectCityFunctionPtr) },
      { typeof(SetProjectCityDelegate), Marshal.GetDelegateForFunctionPointer<SetProjectCityDelegate>(vTable.setProjectCityFunctionPtr) },
      { typeof(GetProjectCountryDelegate), Marshal.GetDelegateForFunctionPointer<GetProjectCountryDelegate>(vTable.getProjectCountryFunctionPtr) },
      { typeof(SetProjectCountryDelegate), Marshal.GetDelegateForFunctionPointer<SetProjectCountryDelegate>(vTable.setProjectCountryFunctionPtr) },
      { typeof(Get3DUserProfilePathDelegate), Marshal.GetDelegateForFunctionPointer<Get3DUserProfilePathDelegate>(vTable.get3DUserProfilePathFunctionPtr) },
      { typeof(GetUserFileFromDialogDelegate), Marshal.GetDelegateForFunctionPointer<GetUserFileFromDialogDelegate>(vTable.getUserFileFromDialogFunctionPtr) },
      { typeof(GetClientNumberDelegate), Marshal.GetDelegateForFunctionPointer<GetClientNumberDelegate>(vTable.getClientNumberFunctionPtr) },
      { typeof(GetUserPointDelegate), Marshal.GetDelegateForFunctionPointer<GetUserPointDelegate>(vTable.getUserPointFunctionPtr) },
      { typeof(DisableAutoDisplayRefreshDelegate), Marshal.GetDelegateForFunctionPointer<DisableAutoDisplayRefreshDelegate>(vTable.disableAutoDisplayRefreshFunctionPtr) },
      { typeof(EnableAutoDisplayRefreshDelegate), Marshal.GetDelegateForFunctionPointer<EnableAutoDisplayRefreshDelegate>(vTable.enableAutoDisplayRefreshFunctionPtr) },
      { typeof(CreateNewGuidDelegate), Marshal.GetDelegateForFunctionPointer<CreateNewGuidDelegate>(vTable.createNewGUIDFunctionPtr) },
      { typeof(PrintToConsoleDelegate), Marshal.GetDelegateForFunctionPointer<PrintToConsoleDelegate>(vTable.printToConsoleFunctionPtr) },
      { typeof(ExportScreenToImageDelegate), Marshal.GetDelegateForFunctionPointer<ExportScreenToImageDelegate>(vTable.exportScreenToImageFunctionPtr) },
      { typeof(GetNewUserFileFromDialogDelegate), Marshal.GetDelegateForFunctionPointer<GetNewUserFileFromDialogDelegate>(vTable.getNewUserFileFromDialogFunctionPtr) },
      { typeof(ApiAutostartDelegate), Marshal.GetDelegateForFunctionPointer<ApiAutostartDelegate>(vTable.apiAutostartFunctionPtr) },
      { typeof(EnableAutostartDelegate), Marshal.GetDelegateForFunctionPointer<EnableAutostartDelegate>(vTable.enableAutostartFunctionPtr) },
      { typeof(DisableAutostartDelegate), Marshal.GetDelegateForFunctionPointer<DisableAutostartDelegate>(vTable.disableAutostartFunctionPtr) },
      { typeof(CheckAutostartDelegate), Marshal.GetDelegateForFunctionPointer<CheckAutostartDelegate>(vTable.checkAutostartFunctionPtr) },
      { typeof(DeleteProjectDataDelegate), Marshal.GetDelegateForFunctionPointer<DeleteProjectDataDelegate>(vTable.deleteProjectDataFunctionPtr) },
      { typeof(RunExternalProgramDelegate), Marshal.GetDelegateForFunctionPointer<RunExternalProgramDelegate>(vTable.runExternalProgramFunctionPtr) },
      { typeof(Save3DFileSilentlyDelegate), Marshal.GetDelegateForFunctionPointer<Save3DFileSilentlyDelegate>(vTable.save3DFileSilentlyFunctionPtr) },
      { typeof(GetProjectGuidDelegate), Marshal.GetDelegateForFunctionPointer<GetProjectGuidDelegate>(vTable.getProjectGUIDFunctionPtr) },
      { typeof(GetLicenceFirstPartDelegate), Marshal.GetDelegateForFunctionPointer<GetLicenceFirstPartDelegate>(vTable.getLicenceFirstPartFunctionPtr) },
      { typeof(GetLicenceSecondPartDelegate), Marshal.GetDelegateForFunctionPointer<GetLicenceSecondPartDelegate>(vTable.getLicenceSecondPartFunctionPtr) },
      { typeof(ShowProgressBarDelegate), Marshal.GetDelegateForFunctionPointer<ShowProgressBarDelegate>(vTable.showProgressBarFunctionPtr) },
      { typeof(UpdateProgressBarDelegate), Marshal.GetDelegateForFunctionPointer<UpdateProgressBarDelegate>(vTable.updateProgressBarFunctionPtr) },
      { typeof(HideProgressBarDelegate), Marshal.GetDelegateForFunctionPointer<HideProgressBarDelegate>(vTable.hideProgressBarFunctionPtr) },
      { typeof(GetUserColorDelegate), Marshal.GetDelegateForFunctionPointer<GetUserColorDelegate>(vTable.getUserColorFunctionPtr) },
      { typeof(Get3DLinearUnitsDelegate), Marshal.GetDelegateForFunctionPointer<Get3DLinearUnitsDelegate>(vTable.get3DLinearUnitsFunctionPtr) },
      { typeof(Get3DLinearDisplayUnitsDelegate), Marshal.GetDelegateForFunctionPointer<Get3DLinearDisplayUnitsDelegate>(vTable.get3DLinearDisplayUnitsFunctionPtr) },
      { typeof(Get3DAngularUnitsDelegate), Marshal.GetDelegateForFunctionPointer<Get3DAngularUnitsDelegate>(vTable.get3DAngularUnitsFunctionPtr) },
      { typeof(Get3DAngularDisplayUnitsDelegate), Marshal.GetDelegateForFunctionPointer<Get3DAngularDisplayUnitsDelegate>(vTable.get3DAngularDisplayUnitsFunctionPtr) },
      { typeof(Get3DBuildDateDelegate), Marshal.GetDelegateForFunctionPointer<Get3DBuildDateDelegate>(vTable.get3DBuildDateFunctionPtr) },
      { typeof(GetProjectElevationDelegate), Marshal.GetDelegateForFunctionPointer<GetProjectElevationDelegate>(vTable.getProjectElevationFunctionPtr) },
      { typeof(SetProjectElevationDelegate), Marshal.GetDelegateForFunctionPointer<SetProjectElevationDelegate>(vTable.setProjectElevationFunctionPtr) },
      { typeof(ClearErrorsDelegate), Marshal.GetDelegateForFunctionPointer<ClearErrorsDelegate>(vTable.clearErrorsFunctionPtr) },
      { typeof(PushCheckAndQueryDataDelegate), Marshal.GetDelegateForFunctionPointer<PushCheckAndQueryDataDelegate>(vTable.pushCheckAndQueryDataFunctionPtr) },
      { typeof(PopCheckAndQueryDataDelegate), Marshal.GetDelegateForFunctionPointer<PopCheckAndQueryDataDelegate>(vTable.popCheckAndQueryDataFunctionPtr) },
      { typeof(ChangeCheckAndQueryDataToNoQueriesDelegate), Marshal.GetDelegateForFunctionPointer<ChangeCheckAndQueryDataToNoQueriesDelegate>(vTable.changeCheckAndQueryDataToNoQueriesFunctionPtr) },
      { typeof(ChangeCheckAndQueryDataToQueriesDelegate), Marshal.GetDelegateForFunctionPointer<ChangeCheckAndQueryDataToQueriesDelegate>(vTable.changeCheckAndQueryDataToQueriesFunctionPtr) },
      { typeof(IsDirectInfoEnabledDelegate), Marshal.GetDelegateForFunctionPointer<IsDirectInfoEnabledDelegate>(vTable.isDirectInfoEnabledFunctionPtr) },
      { typeof(EnableDirectInfoDelegate), Marshal.GetDelegateForFunctionPointer<EnableDirectInfoDelegate>(vTable.enableDirectInfoFunctionPtr) },
      { typeof(DisableDirectInfoDelegate), Marshal.GetDelegateForFunctionPointer<DisableDirectInfoDelegate>(vTable.disableDirectInfoFunctionPtr) },
      { typeof(LoadAttributeDisplaySettingsDelegate), Marshal.GetDelegateForFunctionPointer<LoadAttributeDisplaySettingsDelegate>(vTable.loadAttributeDisplaySettingsFunctionPtr) },
      { typeof(GetProjectDescriptionDelegate), Marshal.GetDelegateForFunctionPointer<GetProjectDescriptionDelegate>(vTable.getProjectDescriptionFunctionPtr) },
      { typeof(SetProjectDescriptionDelegate), Marshal.GetDelegateForFunctionPointer<SetProjectDescriptionDelegate>(vTable.setProjectDescriptionFunctionPtr) },
      { typeof(StartProjectDataDialogDelegate), Marshal.GetDelegateForFunctionPointer<StartProjectDataDialogDelegate>(vTable.startProjectDataDialogFunctionPtr) },
      { typeof(InitLxSdkDelegate), Marshal.GetDelegateForFunctionPointer<InitLxSdkDelegate>(vTable.initLxSDKFunctionPtr) },
      { typeof(LoadElementAttributeDisplaySettingsDelegate), Marshal.GetDelegateForFunctionPointer<LoadElementAttributeDisplaySettingsDelegate>(vTable.loadElementAttributeDisplaySettingsFunctionPtr) },
      { typeof(GetGlobalXOffsetDelegate), Marshal.GetDelegateForFunctionPointer<GetGlobalXOffsetDelegate>(vTable.getGlobalXOffsetFunctionPtr) },
      { typeof(SetGlobalXOffsetDelegate), Marshal.GetDelegateForFunctionPointer<SetGlobalXOffsetDelegate>(vTable.setGlobalXOffsetFunctionPtr) },
      { typeof(GetGlobalYOffsetDelegate), Marshal.GetDelegateForFunctionPointer<GetGlobalYOffsetDelegate>(vTable.getGlobalYOffsetFunctionPtr) },
      { typeof(SetGlobalYOffsetDelegate), Marshal.GetDelegateForFunctionPointer<SetGlobalYOffsetDelegate>(vTable.setGlobalYOffsetFunctionPtr) },
      { typeof(GetGlobalZOffsetDelegate), Marshal.GetDelegateForFunctionPointer<GetGlobalZOffsetDelegate>(vTable.getGlobalZOffsetFunctionPtr) },
      { typeof(SetGlobalZOffsetDelegate), Marshal.GetDelegateForFunctionPointer<SetGlobalZOffsetDelegate>(vTable.setGlobalZOffsetFunctionPtr) },
      { typeof(ShowNorthArrowDelegate), Marshal.GetDelegateForFunctionPointer<ShowNorthArrowDelegate>(vTable.showNorthArrowFunctionPtr) },
      { typeof(HideNorthArrowDelegate), Marshal.GetDelegateForFunctionPointer<HideNorthArrowDelegate>(vTable.hideNorthArrowFunctionPtr) },
      { typeof(IsNorthArrowVisibleDelegate), Marshal.GetDelegateForFunctionPointer<IsNorthArrowVisibleDelegate>(vTable.isNorthArrowVisibleFunctionPtr) },
      { typeof(GetNorthAngleDelegate), Marshal.GetDelegateForFunctionPointer<GetNorthAngleDelegate>(vTable.getNorthAngleFunctionPtr) },
      { typeof(SetNorthAngleDelegate), Marshal.GetDelegateForFunctionPointer<SetNorthAngleDelegate>(vTable.setNorthAngleFunctionPtr) },
      { typeof(GetUserFileFromDialogInPathDelegate), Marshal.GetDelegateForFunctionPointer<GetUserFileFromDialogInPathDelegate>(vTable.getUserFileFromDialogInPathFunctionPtr) },
      { typeof(GetNewUserFileFromDialogInPathDelegate), Marshal.GetDelegateForFunctionPointer<GetNewUserFileFromDialogInPathDelegate>(vTable.getNewUserFileFromDialogInPathFunctionPtr) },
      { typeof(GetMillimetreFromImperialStringDelegate), Marshal.GetDelegateForFunctionPointer<GetMillimetreFromImperialStringDelegate>(vTable.getMillimetreFromImperialStringFunctionPtr) },
      { typeof(GetImperialStringFromMillimetreDelegate), Marshal.GetDelegateForFunctionPointer<GetImperialStringFromMillimetreDelegate>(vTable.getImperialStringFromMillimetreFunctionPtr) },
      { typeof(EnableUpdateVariantDelegate), Marshal.GetDelegateForFunctionPointer<EnableUpdateVariantDelegate>(vTable.enableUpdateVariantFunctionPtr) },
      { typeof(DisableUpdateVariantDelegate), Marshal.GetDelegateForFunctionPointer<DisableUpdateVariantDelegate>(vTable.disableUpdateVariantFunctionPtr) },
      { typeof(GetPluginPathDelegate), Marshal.GetDelegateForFunctionPointer<GetPluginPathDelegate>(vTable.getPluginPathFunctionPtr) },
      { typeof(GetUserPointsDelegate), Marshal.GetDelegateForFunctionPointer<GetUserPointsDelegate>(vTable.getUserPointsFunctionPtr) },
      { typeof(GetUserPointsWithCountDelegate), Marshal.GetDelegateForFunctionPointer<GetUserPointsWithCountDelegate>(vTable.getUserPointsWithCountFunctionPtr) },
      { typeof(GetUserCatalogPathDelegate), Marshal.GetDelegateForFunctionPointer<GetUserCatalogPathDelegate>(vTable.getUserCatalogPathFunctionPtr) },
      { typeof(GetUserPathFromDialogDelegate), Marshal.GetDelegateForFunctionPointer<GetUserPathFromDialogDelegate>(vTable.getUserPathFromDialogFunctionPtr) },
      { typeof(GetUserPathFromDialogInPathDelegate), Marshal.GetDelegateForFunctionPointer<GetUserPathFromDialogInPathDelegate>(vTable.getUserPathFromDialogInPathFunctionPtr) },
      { typeof(ExecuteShortcutDelegate), Marshal.GetDelegateForFunctionPointer<ExecuteShortcutDelegate>(vTable.executeShortcutFunctionPtr) },
      { typeof(CloseCadworkDocumentSavedDelegate), Marshal.GetDelegateForFunctionPointer<CloseCadworkDocumentSavedDelegate>(vTable.closeCadworkDocumentSavedFunctionPtr) },
      { typeof(CloseCadworkDocumentUnsavedDelegate), Marshal.GetDelegateForFunctionPointer<CloseCadworkDocumentUnsavedDelegate>(vTable.closeCadworkDocumentUnsavedFunctionPtr) },
      { typeof(GetUseOfGlobalCoordinatesDelegate), Marshal.GetDelegateForFunctionPointer<GetUseOfGlobalCoordinatesDelegate>(vTable.getUseOfGlobalCoordinatesFunctionPtr) },
      { typeof(SetUseOfGlobalCoordinatesDelegate), Marshal.GetDelegateForFunctionPointer<SetUseOfGlobalCoordinatesDelegate>(vTable.setUseOfGlobalCoordinatesFunctionPtr) },
      { typeof(GetGlobalOriginDelegate), Marshal.GetDelegateForFunctionPointer<GetGlobalOriginDelegate>(vTable.getGlobalOriginFunctionPtr) },
      { typeof(SetGlobalOriginDelegate), Marshal.GetDelegateForFunctionPointer<SetGlobalOriginDelegate>(vTable.setGlobalOriginFunctionPtr) },
      { typeof(CreateSnapshotDelegate), Marshal.GetDelegateForFunctionPointer<CreateSnapshotDelegate>(vTable.createSnapshotFunctionPtr) },
      { typeof(RunExternalProgramFromCustomDirectoryDelegate), Marshal.GetDelegateForFunctionPointer<RunExternalProgramFromCustomDirectoryDelegate>(vTable.runExternalProgramFromCustomDirectoryFunctionPtr) },
      { typeof(Get3dMainWindowGeometryDelegate), Marshal.GetDelegateForFunctionPointer<Get3dMainWindowGeometryDelegate>(vTable.get3dMainWindowGeometryFunctionPtr) },
      { typeof(GetProjectDataKeysDelegate), Marshal.GetDelegateForFunctionPointer<GetProjectDataKeysDelegate>(vTable.getProjectDataKeysFunctionPtr) },
      { typeof(GetUserIntWithDefaultValueDelegate), Marshal.GetDelegateForFunctionPointer<GetUserIntWithDefaultValueDelegate>(vTable.getUserIntWithDefaultValueFunctionPtr) },
      { typeof(GetUserDoubleWithDefaultValueDelegate), Marshal.GetDelegateForFunctionPointer<GetUserDoubleWithDefaultValueDelegate>(vTable.getUserDoubleWithDefaultValueFunctionPtr) },
      { typeof(GetUserStringWithDefaultValueDelegate), Marshal.GetDelegateForFunctionPointer<GetUserStringWithDefaultValueDelegate>(vTable.getUserStringWithDefaultValueFunctionPtr) },
    };
  }

  public enum ShortcutKey
  {
    F1 = 1,
    F2 = 2,
    F3 = 3,
    F4 = 4,
    F5 = 5,
    F6 = 6,
    F7 = 7,
    F8 = 8,
    F9 = 9,
    F10 = 10,
    F11 = 11,
    F12 = 12,
  };

  public enum ShortcutKeyModifier
  {
    None = 0,
    Shift = 1,
    Control = 2,
    Alt = 3,
  };

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public IntPtr GetLastError(IntPtr aErrorCode) => GetDelegate<GetLastErrorDelegate>().Invoke(_nativePtr, aErrorCode);
  public uint Get3DVersion() => GetDelegate<Get3DVersionDelegate>().Invoke(_nativePtr);
  public uint Get3DBuild() => GetDelegate<Get3DBuildDelegate>().Invoke(_nativePtr);
  public IntPtr Get3DWindowHandle() => GetDelegate<Get3DWindowHandleDelegate>().Invoke(_nativePtr);
  public IntPtr Get3DFileName() => GetDelegate<Get3DFileNameDelegate>().Invoke(_nativePtr);
  public IntPtr Get3DFilePath() => GetDelegate<Get3DFilePathDelegate>().Invoke(_nativePtr);
  public void SetProjectData(string aId, string aData) => GetDelegate<SetProjectDataDelegate>().Invoke(_nativePtr, aId, aData);
  public IntPtr GetProjectData(string aId) => GetDelegate<GetProjectDataDelegate>().Invoke(_nativePtr, aId);
  public void PrintError(string aMessage) => GetDelegate<PrintErrorDelegate>().Invoke(_nativePtr, aMessage);
  public IntPtr GetLanguage() => GetDelegate<GetLanguageDelegate>().Invoke(_nativePtr);
  public void PrintMessage(string aMessage, uint aRow, uint aColumn) => GetDelegate<PrintMessageDelegate>().Invoke(_nativePtr, aMessage, aRow, aColumn);
  public int GetUserInt(string aMessage) => GetDelegate<GetUserIntDelegate>().Invoke(_nativePtr, aMessage);
  public double GetUserDouble(string aMessage) => GetDelegate<GetUserDoubleDelegate>().Invoke(_nativePtr, aMessage);
  public bool GetUserBool(string aMessage, bool aDefaultYes) => GetDelegate<GetUserBoolDelegate>().Invoke(_nativePtr, aMessage, aDefaultYes);
  public IntPtr GetUserString(string aMessage) => GetDelegate<GetUserStringDelegate>().Invoke(_nativePtr, aMessage);
  public IntPtr GetProjectName() => GetDelegate<GetProjectNameDelegate>().Invoke(_nativePtr);
  public void SetProjectName(string aProjectName) => GetDelegate<SetProjectNameDelegate>().Invoke(_nativePtr, aProjectName);
  public IntPtr GetProjectNumber() => GetDelegate<GetProjectNumberDelegate>().Invoke(_nativePtr);
  public void SetProjectNumber(string aProjectNumber) => GetDelegate<SetProjectNumberDelegate>().Invoke(_nativePtr, aProjectNumber);
  public IntPtr GetProjectPart() => GetDelegate<GetProjectPartDelegate>().Invoke(_nativePtr);
  public void SetProjectPart(string aProjectPart) => GetDelegate<SetProjectPartDelegate>().Invoke(_nativePtr, aProjectPart);
  public IntPtr GetProjectArchitect() => GetDelegate<GetProjectArchitectDelegate>().Invoke(_nativePtr);
  public void SetProjectArchitect(string aProjectArchitect) => GetDelegate<SetProjectArchitectDelegate>().Invoke(_nativePtr, aProjectArchitect);
  public IntPtr GetProjectCustomer() => GetDelegate<GetProjectCustomerDelegate>().Invoke(_nativePtr);
  public void SetProjectCustomer(string aProjectCustomer) => GetDelegate<SetProjectCustomerDelegate>().Invoke(_nativePtr, aProjectCustomer);
  public IntPtr GetProjectDesigner() => GetDelegate<GetProjectDesignerDelegate>().Invoke(_nativePtr);
  public void SetProjectDesigner(string aProjectDesigner) => GetDelegate<SetProjectDesignerDelegate>().Invoke(_nativePtr, aProjectDesigner);
  public IntPtr GetProjectDeadline() => GetDelegate<GetProjectDeadlineDelegate>().Invoke(_nativePtr);
  public void SetProjectDeadline(string aProjectDeadline) => GetDelegate<SetProjectDeadlineDelegate>().Invoke(_nativePtr, aProjectDeadline);
  public IntPtr GetProjectUserAttribute(uint aNumber) => GetDelegate<GetProjectUserAttributeDelegate>().Invoke(_nativePtr, aNumber);
  public void SetProjectUserAttribute(uint aNumber, string aUserAttribute) => GetDelegate<SetProjectUserAttributeDelegate>().Invoke(_nativePtr, aNumber, aUserAttribute);
  public IntPtr GetProjectUserAttributeName(uint aNumber) => GetDelegate<GetProjectUserAttributeNameDelegate>().Invoke(_nativePtr, aNumber);
  public void SetProjectUserAttributeName(uint aNumber, string aUserAttributeName) => GetDelegate<SetProjectUserAttributeNameDelegate>().Invoke(_nativePtr, aNumber, aUserAttributeName);
  public double GetProjectLatitude() => GetDelegate<GetProjectLatitudeDelegate>().Invoke(_nativePtr);
  public double GetProjectLongitude() => GetDelegate<GetProjectLongitudeDelegate>().Invoke(_nativePtr);
  public void SetProjectLatitude(double aLatitude) => GetDelegate<SetProjectLatitudeDelegate>().Invoke(_nativePtr, aLatitude);
  public void SetProjectLongitude(double aLongitude) => GetDelegate<SetProjectLongitudeDelegate>().Invoke(_nativePtr, aLongitude);
  public IntPtr GetProjectAddress() => GetDelegate<GetProjectAddressDelegate>().Invoke(_nativePtr);
  public void SetProjectAddress(string aAddress) => GetDelegate<SetProjectAddressDelegate>().Invoke(_nativePtr, aAddress);
  public IntPtr GetProjectPostalCode() => GetDelegate<GetProjectPostalCodeDelegate>().Invoke(_nativePtr);
  public void SetProjectPostalCode(string aPostalCode) => GetDelegate<SetProjectPostalCodeDelegate>().Invoke(_nativePtr, aPostalCode);
  public IntPtr GetProjectCity() => GetDelegate<GetProjectCityDelegate>().Invoke(_nativePtr);
  public void SetProjectCity(string aCity) => GetDelegate<SetProjectCityDelegate>().Invoke(_nativePtr, aCity);
  public IntPtr GetProjectCountry() => GetDelegate<GetProjectCountryDelegate>().Invoke(_nativePtr);
  public void SetProjectCountry(string aCountry) => GetDelegate<SetProjectCountryDelegate>().Invoke(_nativePtr, aCountry);
  public IntPtr Get3DUserProfilePath() => GetDelegate<Get3DUserProfilePathDelegate>().Invoke(_nativePtr);
  public IntPtr GetUserFileFromDialog(string aFilter) => GetDelegate<GetUserFileFromDialogDelegate>().Invoke(_nativePtr, aFilter);
  public IntPtr GetClientNumber() => GetDelegate<GetClientNumberDelegate>().Invoke(_nativePtr);
  public CVector3 GetUserPoint() => GetDelegate<GetUserPointDelegate>().Invoke(_nativePtr);
  public void DisableAutoDisplayRefresh() => GetDelegate<DisableAutoDisplayRefreshDelegate>().Invoke(_nativePtr);
  public void EnableAutoDisplayRefresh() => GetDelegate<EnableAutoDisplayRefreshDelegate>().Invoke(_nativePtr);
  public IntPtr CreateNewGuid() => GetDelegate<CreateNewGuidDelegate>().Invoke(_nativePtr);
  public void PrintToConsole(string aMessage) => GetDelegate<PrintToConsoleDelegate>().Invoke(_nativePtr, aMessage);
  public void ExportScreenToImage(string aFilePath, uint aFactor) => GetDelegate<ExportScreenToImageDelegate>().Invoke(_nativePtr, aFilePath, aFactor);
  public IntPtr GetNewUserFileFromDialog(string aFilter) => GetDelegate<GetNewUserFileFromDialogDelegate>().Invoke(_nativePtr, aFilter);
  public uint ApiAutostart(string aApiName, uint aOption) => GetDelegate<ApiAutostartDelegate>().Invoke(_nativePtr, aApiName, aOption);
  public void EnableAutostart(string aApiName) => GetDelegate<EnableAutostartDelegate>().Invoke(_nativePtr, aApiName);
  public void DisableAutostart(string aApiName) => GetDelegate<DisableAutostartDelegate>().Invoke(_nativePtr, aApiName);
  public bool CheckAutostart(string aApiName) => GetDelegate<CheckAutostartDelegate>().Invoke(_nativePtr, aApiName);
  public void DeleteProjectData(string aId) => GetDelegate<DeleteProjectDataDelegate>().Invoke(_nativePtr, aId);
  public bool RunExternalProgram(string aName) => GetDelegate<RunExternalProgramDelegate>().Invoke(_nativePtr, aName);
  public void Save3DFileSilently() => GetDelegate<Save3DFileSilentlyDelegate>().Invoke(_nativePtr);
  public IntPtr GetProjectGuid() => GetDelegate<GetProjectGuidDelegate>().Invoke(_nativePtr);
  public IntPtr GetLicenceFirstPart() => GetDelegate<GetLicenceFirstPartDelegate>().Invoke(_nativePtr);
  public IntPtr GetLicenceSecondPart() => GetDelegate<GetLicenceSecondPartDelegate>().Invoke(_nativePtr);
  public void ShowProgressBar() => GetDelegate<ShowProgressBarDelegate>().Invoke(_nativePtr);
  public void UpdateProgressBar(int aValue) => GetDelegate<UpdateProgressBarDelegate>().Invoke(_nativePtr, aValue);
  public void HideProgressBar() => GetDelegate<HideProgressBarDelegate>().Invoke(_nativePtr);
  public uint GetUserColor(uint aInitialColor) => GetDelegate<GetUserColorDelegate>().Invoke(_nativePtr, aInitialColor);
  public IntPtr Get3DLinearUnits() => GetDelegate<Get3DLinearUnitsDelegate>().Invoke(_nativePtr);
  public IntPtr Get3DLinearDisplayUnits() => GetDelegate<Get3DLinearDisplayUnitsDelegate>().Invoke(_nativePtr);
  public IntPtr Get3DAngularUnits() => GetDelegate<Get3DAngularUnitsDelegate>().Invoke(_nativePtr);
  public IntPtr Get3DAngularDisplayUnits() => GetDelegate<Get3DAngularDisplayUnitsDelegate>().Invoke(_nativePtr);
  public IntPtr Get3DBuildDate() => GetDelegate<Get3DBuildDateDelegate>().Invoke(_nativePtr);
  public double GetProjectElevation() => GetDelegate<GetProjectElevationDelegate>().Invoke(_nativePtr);
  public void SetProjectElevation(double aElevation) => GetDelegate<SetProjectElevationDelegate>().Invoke(_nativePtr, aElevation);
  public void ClearErrors() => GetDelegate<ClearErrorsDelegate>().Invoke(_nativePtr);
  public void PushCheckAndQueryData() => GetDelegate<PushCheckAndQueryDataDelegate>().Invoke(_nativePtr);
  public void PopCheckAndQueryData() => GetDelegate<PopCheckAndQueryDataDelegate>().Invoke(_nativePtr);
  public void ChangeCheckAndQueryDataToNoQueries() => GetDelegate<ChangeCheckAndQueryDataToNoQueriesDelegate>().Invoke(_nativePtr);
  public void ChangeCheckAndQueryDataToQueries() => GetDelegate<ChangeCheckAndQueryDataToQueriesDelegate>().Invoke(_nativePtr);
  public bool IsDirectInfoEnabled() => GetDelegate<IsDirectInfoEnabledDelegate>().Invoke(_nativePtr);
  public void EnableDirectInfo() => GetDelegate<EnableDirectInfoDelegate>().Invoke(_nativePtr);
  public void DisableDirectInfo() => GetDelegate<DisableDirectInfoDelegate>().Invoke(_nativePtr);
  public void LoadAttributeDisplaySettings(string aFilePath) => GetDelegate<LoadAttributeDisplaySettingsDelegate>().Invoke(_nativePtr, aFilePath);
  public IntPtr GetProjectDescription() => GetDelegate<GetProjectDescriptionDelegate>().Invoke(_nativePtr);
  public void SetProjectDescription(string aDescription) => GetDelegate<SetProjectDescriptionDelegate>().Invoke(_nativePtr, aDescription);
  public void StartProjectDataDialog() => GetDelegate<StartProjectDataDialogDelegate>().Invoke(_nativePtr);
  public void InitLxSdk() => GetDelegate<InitLxSdkDelegate>().Invoke(_nativePtr);
  public void LoadElementAttributeDisplaySettings(string aFilePath, IntPtr aElements) => GetDelegate<LoadElementAttributeDisplaySettingsDelegate>().Invoke(_nativePtr, aFilePath, aElements);
  public double GetGlobalXOffset() => GetDelegate<GetGlobalXOffsetDelegate>().Invoke(_nativePtr);
  public void SetGlobalXOffset(double aOffset) => GetDelegate<SetGlobalXOffsetDelegate>().Invoke(_nativePtr, aOffset);
  public double GetGlobalYOffset() => GetDelegate<GetGlobalYOffsetDelegate>().Invoke(_nativePtr);
  public void SetGlobalYOffset(double aOffset) => GetDelegate<SetGlobalYOffsetDelegate>().Invoke(_nativePtr, aOffset);
  public double GetGlobalZOffset() => GetDelegate<GetGlobalZOffsetDelegate>().Invoke(_nativePtr);
  public void SetGlobalZOffset(double aOffset) => GetDelegate<SetGlobalZOffsetDelegate>().Invoke(_nativePtr, aOffset);
  public void ShowNorthArrow() => GetDelegate<ShowNorthArrowDelegate>().Invoke(_nativePtr);
  public void HideNorthArrow() => GetDelegate<HideNorthArrowDelegate>().Invoke(_nativePtr);
  public bool IsNorthArrowVisible() => GetDelegate<IsNorthArrowVisibleDelegate>().Invoke(_nativePtr);
  public double GetNorthAngle() => GetDelegate<GetNorthAngleDelegate>().Invoke(_nativePtr);
  public void SetNorthAngle(double aNorthAngle) => GetDelegate<SetNorthAngleDelegate>().Invoke(_nativePtr, aNorthAngle);
  public IntPtr GetUserFileFromDialogInPath(string aFilter, string aPath) => GetDelegate<GetUserFileFromDialogInPathDelegate>().Invoke(_nativePtr, aFilter, aPath);
  public IntPtr GetNewUserFileFromDialogInPath(string aFilter, string aPath) => GetDelegate<GetNewUserFileFromDialogInPathDelegate>().Invoke(_nativePtr, aFilter, aPath);
  public double GetMillimetreFromImperialString(string aValue) => GetDelegate<GetMillimetreFromImperialStringDelegate>().Invoke(_nativePtr, aValue);
  public IntPtr GetImperialStringFromMillimetre(double aValue) => GetDelegate<GetImperialStringFromMillimetreDelegate>().Invoke(_nativePtr, aValue);
  public void EnableUpdateVariant() => GetDelegate<EnableUpdateVariantDelegate>().Invoke(_nativePtr);
  public void DisableUpdateVariant() => GetDelegate<DisableUpdateVariantDelegate>().Invoke(_nativePtr);
  public IntPtr GetPluginPath() => GetDelegate<GetPluginPathDelegate>().Invoke(_nativePtr);
  public IntPtr GetUserPoints() => GetDelegate<GetUserPointsDelegate>().Invoke(_nativePtr);
  public IntPtr GetUserPointsWithCount(ulong aCount) => GetDelegate<GetUserPointsWithCountDelegate>().Invoke(_nativePtr, aCount);
  public IntPtr GetUserCatalogPath() => GetDelegate<GetUserCatalogPathDelegate>().Invoke(_nativePtr);
  public IntPtr GetUserPathFromDialog() => GetDelegate<GetUserPathFromDialogDelegate>().Invoke(_nativePtr);
  public IntPtr GetUserPathFromDialogInPath(string aPath) => GetDelegate<GetUserPathFromDialogInPathDelegate>().Invoke(_nativePtr, aPath);
  public void ExecuteShortcut(ShortcutKeyModifier aShortcutKeyModifier, ShortcutKey aShortcutKey) => GetDelegate<ExecuteShortcutDelegate>().Invoke(_nativePtr, aShortcutKeyModifier, aShortcutKey);
  public void CloseCadworkDocumentSaved() => GetDelegate<CloseCadworkDocumentSavedDelegate>().Invoke(_nativePtr);
  public void CloseCadworkDocumentUnsaved() => GetDelegate<CloseCadworkDocumentUnsavedDelegate>().Invoke(_nativePtr);
  public bool GetUseOfGlobalCoordinates() => GetDelegate<GetUseOfGlobalCoordinatesDelegate>().Invoke(_nativePtr);
  public void SetUseOfGlobalCoordinates(bool aUseOfGlobalCoordinates) => GetDelegate<SetUseOfGlobalCoordinatesDelegate>().Invoke(_nativePtr, aUseOfGlobalCoordinates);
  public CVector3 GetGlobalOrigin() => GetDelegate<GetGlobalOriginDelegate>().Invoke(_nativePtr);
  public void SetGlobalOrigin(CVector3 aGlobalOrigin) => GetDelegate<SetGlobalOriginDelegate>().Invoke(_nativePtr, aGlobalOrigin);
  public IntPtr CreateSnapshot(string aFormat, int aQuality, bool aWhiteBackground) => GetDelegate<CreateSnapshotDelegate>().Invoke(_nativePtr, aFormat, aQuality, aWhiteBackground);
  public bool RunExternalProgramFromCustomDirectory(string aFilePath) => GetDelegate<RunExternalProgramFromCustomDirectoryDelegate>().Invoke(_nativePtr, aFilePath);
  public CWindowGeometry Get3dMainWindowGeometry() => GetDelegate<Get3dMainWindowGeometryDelegate>().Invoke(_nativePtr);
  public IntPtr GetProjectDataKeys() => GetDelegate<GetProjectDataKeysDelegate>().Invoke(_nativePtr);
  public int GetUserIntWithDefaultValue(string aMessage, int aDefaultValue) => GetDelegate<GetUserIntWithDefaultValueDelegate>().Invoke(_nativePtr, aMessage, aDefaultValue);
  public double GetUserDoubleWithDefaultValue(string aMessage, double aDefaultValue) => GetDelegate<GetUserDoubleWithDefaultValueDelegate>().Invoke(_nativePtr, aMessage, aDefaultValue);
  public IntPtr GetUserStringWithDefaultValue(string aMessage, string aDefaultValue) => GetDelegate<GetUserStringWithDefaultValueDelegate>().Invoke(_nativePtr, aMessage, aDefaultValue);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class UtilityControllerInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr getLastErrorFunctionPtr;
    internal IntPtr get3DVersionFunctionPtr;
    internal IntPtr get3DBuildFunctionPtr;
    internal IntPtr get3DWindowHandleFunctionPtr;
    internal IntPtr get3DFileNameFunctionPtr;
    internal IntPtr get3DFilePathFunctionPtr;
    internal IntPtr setProjectDataFunctionPtr;
    internal IntPtr getProjectDataFunctionPtr;
    internal IntPtr printErrorFunctionPtr;
    internal IntPtr getLanguageFunctionPtr;
    internal IntPtr printMessageFunctionPtr;
    internal IntPtr getUserIntFunctionPtr;
    internal IntPtr getUserDoubleFunctionPtr;
    internal IntPtr getUserBoolFunctionPtr;
    internal IntPtr getUserStringFunctionPtr;
    internal IntPtr getProjectNameFunctionPtr;
    internal IntPtr setProjectNameFunctionPtr;
    internal IntPtr getProjectNumberFunctionPtr;
    internal IntPtr setProjectNumberFunctionPtr;
    internal IntPtr getProjectPartFunctionPtr;
    internal IntPtr setProjectPartFunctionPtr;
    internal IntPtr getProjectArchitectFunctionPtr;
    internal IntPtr setProjectArchitectFunctionPtr;
    internal IntPtr getProjectCustomerFunctionPtr;
    internal IntPtr setProjectCustomerFunctionPtr;
    internal IntPtr getProjectDesignerFunctionPtr;
    internal IntPtr setProjectDesignerFunctionPtr;
    internal IntPtr getProjectDeadlineFunctionPtr;
    internal IntPtr setProjectDeadlineFunctionPtr;
    internal IntPtr getProjectUserAttributeFunctionPtr;
    internal IntPtr setProjectUserAttributeFunctionPtr;
    internal IntPtr getProjectUserAttributeNameFunctionPtr;
    internal IntPtr setProjectUserAttributeNameFunctionPtr;
    internal IntPtr getProjectLatitudeFunctionPtr;
    internal IntPtr getProjectLongitudeFunctionPtr;
    internal IntPtr setProjectLatitudeFunctionPtr;
    internal IntPtr setProjectLongitudeFunctionPtr;
    internal IntPtr getProjectAddressFunctionPtr;
    internal IntPtr setProjectAddressFunctionPtr;
    internal IntPtr getProjectPostalCodeFunctionPtr;
    internal IntPtr setProjectPostalCodeFunctionPtr;
    internal IntPtr getProjectCityFunctionPtr;
    internal IntPtr setProjectCityFunctionPtr;
    internal IntPtr getProjectCountryFunctionPtr;
    internal IntPtr setProjectCountryFunctionPtr;
    internal IntPtr get3DUserProfilePathFunctionPtr;
    internal IntPtr getUserFileFromDialogFunctionPtr;
    internal IntPtr getClientNumberFunctionPtr;
    internal IntPtr getUserPointFunctionPtr;
    internal IntPtr disableAutoDisplayRefreshFunctionPtr;
    internal IntPtr enableAutoDisplayRefreshFunctionPtr;
    internal IntPtr createNewGUIDFunctionPtr;
    internal IntPtr printToConsoleFunctionPtr;
    internal IntPtr exportScreenToImageFunctionPtr;
    internal IntPtr getNewUserFileFromDialogFunctionPtr;
    internal IntPtr apiAutostartFunctionPtr;
    internal IntPtr enableAutostartFunctionPtr;
    internal IntPtr disableAutostartFunctionPtr;
    internal IntPtr checkAutostartFunctionPtr;
    internal IntPtr deleteProjectDataFunctionPtr;
    internal IntPtr runExternalProgramFunctionPtr;
    internal IntPtr save3DFileSilentlyFunctionPtr;
    internal IntPtr getProjectGUIDFunctionPtr;
    internal IntPtr getLicenceFirstPartFunctionPtr;
    internal IntPtr getLicenceSecondPartFunctionPtr;
    internal IntPtr showProgressBarFunctionPtr;
    internal IntPtr updateProgressBarFunctionPtr;
    internal IntPtr hideProgressBarFunctionPtr;
    internal IntPtr getUserColorFunctionPtr;
    internal IntPtr get3DLinearUnitsFunctionPtr;
    internal IntPtr get3DLinearDisplayUnitsFunctionPtr;
    internal IntPtr get3DAngularUnitsFunctionPtr;
    internal IntPtr get3DAngularDisplayUnitsFunctionPtr;
    internal IntPtr get3DBuildDateFunctionPtr;
    internal IntPtr getProjectElevationFunctionPtr;
    internal IntPtr setProjectElevationFunctionPtr;
    internal IntPtr clearErrorsFunctionPtr;
    internal IntPtr pushCheckAndQueryDataFunctionPtr;
    internal IntPtr popCheckAndQueryDataFunctionPtr;
    internal IntPtr changeCheckAndQueryDataToNoQueriesFunctionPtr;
    internal IntPtr changeCheckAndQueryDataToQueriesFunctionPtr;
    internal IntPtr isDirectInfoEnabledFunctionPtr;
    internal IntPtr enableDirectInfoFunctionPtr;
    internal IntPtr disableDirectInfoFunctionPtr;
    internal IntPtr loadAttributeDisplaySettingsFunctionPtr;
    internal IntPtr getProjectDescriptionFunctionPtr;
    internal IntPtr setProjectDescriptionFunctionPtr;
    internal IntPtr startProjectDataDialogFunctionPtr;
    internal IntPtr initLxSDKFunctionPtr;
    internal IntPtr loadElementAttributeDisplaySettingsFunctionPtr;
    internal IntPtr getGlobalXOffsetFunctionPtr;
    internal IntPtr setGlobalXOffsetFunctionPtr;
    internal IntPtr getGlobalYOffsetFunctionPtr;
    internal IntPtr setGlobalYOffsetFunctionPtr;
    internal IntPtr getGlobalZOffsetFunctionPtr;
    internal IntPtr setGlobalZOffsetFunctionPtr;
    internal IntPtr showNorthArrowFunctionPtr;
    internal IntPtr hideNorthArrowFunctionPtr;
    internal IntPtr isNorthArrowVisibleFunctionPtr;
    internal IntPtr getNorthAngleFunctionPtr;
    internal IntPtr setNorthAngleFunctionPtr;
    internal IntPtr getUserFileFromDialogInPathFunctionPtr;
    internal IntPtr getNewUserFileFromDialogInPathFunctionPtr;
    internal IntPtr getMillimetreFromImperialStringFunctionPtr;
    internal IntPtr getImperialStringFromMillimetreFunctionPtr;
    internal IntPtr enableUpdateVariantFunctionPtr;
    internal IntPtr disableUpdateVariantFunctionPtr;
    internal IntPtr getPluginPathFunctionPtr;
    internal IntPtr getUserPointsFunctionPtr;
    internal IntPtr getUserPointsWithCountFunctionPtr;
    internal IntPtr getUserCatalogPathFunctionPtr;
    internal IntPtr getUserPathFromDialogFunctionPtr;
    internal IntPtr getUserPathFromDialogInPathFunctionPtr;
    internal IntPtr executeShortcutFunctionPtr;
    internal IntPtr closeCadworkDocumentSavedFunctionPtr;
    internal IntPtr closeCadworkDocumentUnsavedFunctionPtr;
    internal IntPtr getUseOfGlobalCoordinatesFunctionPtr;
    internal IntPtr setUseOfGlobalCoordinatesFunctionPtr;
    internal IntPtr getGlobalOriginFunctionPtr;
    internal IntPtr setGlobalOriginFunctionPtr;
    internal IntPtr createSnapshotFunctionPtr;
    internal IntPtr runExternalProgramFromCustomDirectoryFunctionPtr;
    internal IntPtr get3dMainWindowGeometryFunctionPtr;
    internal IntPtr getProjectDataKeysFunctionPtr;
    internal IntPtr getUserIntWithDefaultValueFunctionPtr;
    internal IntPtr getUserDoubleWithDefaultValueFunctionPtr;
    internal IntPtr getUserStringWithDefaultValueFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetLastErrorDelegate(IntPtr thisPtr, IntPtr aErrorCode);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate uint Get3DVersionDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate uint Get3DBuildDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr Get3DWindowHandleDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr Get3DFileNameDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr Get3DFilePathDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetProjectDataDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aId, [MarshalAs(UnmanagedType.LPWStr)] string aData);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetProjectDataDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void PrintErrorDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aMessage);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetLanguageDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void PrintMessageDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aMessage, uint aRow, uint aColumn);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate int GetUserIntDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aMessage);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetUserDoubleDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aMessage);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetUserBoolDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aMessage, bool aDefaultYes);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetUserStringDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aMessage);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetProjectNameDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetProjectNameDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aProjectName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetProjectNumberDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetProjectNumberDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aProjectNumber);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetProjectPartDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetProjectPartDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aProjectPart);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetProjectArchitectDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetProjectArchitectDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aProjectArchitect);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetProjectCustomerDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetProjectCustomerDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aProjectCustomer);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetProjectDesignerDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetProjectDesignerDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aProjectDesigner);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetProjectDeadlineDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetProjectDeadlineDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aProjectDeadline);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetProjectUserAttributeDelegate(IntPtr thisPtr, uint aNumber);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetProjectUserAttributeDelegate(IntPtr thisPtr, uint aNumber, [MarshalAs(UnmanagedType.LPWStr)] string aUserAttribute);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetProjectUserAttributeNameDelegate(IntPtr thisPtr, uint aNumber);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetProjectUserAttributeNameDelegate(IntPtr thisPtr, uint aNumber, [MarshalAs(UnmanagedType.LPWStr)] string aUserAttributeName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetProjectLatitudeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetProjectLongitudeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetProjectLatitudeDelegate(IntPtr thisPtr, double aLatitude);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetProjectLongitudeDelegate(IntPtr thisPtr, double aLongitude);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetProjectAddressDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetProjectAddressDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aAddress);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetProjectPostalCodeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetProjectPostalCodeDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aPostalCode);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetProjectCityDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetProjectCityDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aCity);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetProjectCountryDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetProjectCountryDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aCountry);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr Get3DUserProfilePathDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetUserFileFromDialogDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aFilter);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetClientNumberDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate CVector3 GetUserPointDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DisableAutoDisplayRefreshDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void EnableAutoDisplayRefreshDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CreateNewGuidDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void PrintToConsoleDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aMessage);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ExportScreenToImageDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath, uint aFactor);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetNewUserFileFromDialogDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aFilter);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate uint ApiAutostartDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aApiName, uint aOption);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void EnableAutostartDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aApiName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DisableAutostartDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aApiName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool CheckAutostartDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aApiName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DeleteProjectDataDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool RunExternalProgramDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void Save3DFileSilentlyDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetProjectGuidDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetLicenceFirstPartDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetLicenceSecondPartDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ShowProgressBarDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void UpdateProgressBarDelegate(IntPtr thisPtr, int aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void HideProgressBarDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate uint GetUserColorDelegate(IntPtr thisPtr, uint aInitialColor);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr Get3DLinearUnitsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr Get3DLinearDisplayUnitsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr Get3DAngularUnitsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr Get3DAngularDisplayUnitsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr Get3DBuildDateDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetProjectElevationDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetProjectElevationDelegate(IntPtr thisPtr, double aElevation);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ClearErrorsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void PushCheckAndQueryDataDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void PopCheckAndQueryDataDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ChangeCheckAndQueryDataToNoQueriesDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ChangeCheckAndQueryDataToQueriesDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsDirectInfoEnabledDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void EnableDirectInfoDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DisableDirectInfoDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void LoadAttributeDisplaySettingsDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetProjectDescriptionDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetProjectDescriptionDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aDescription);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void StartProjectDataDialogDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void InitLxSdkDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void LoadElementAttributeDisplaySettingsDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath, IntPtr aElements);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetGlobalXOffsetDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetGlobalXOffsetDelegate(IntPtr thisPtr, double aOffset);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetGlobalYOffsetDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetGlobalYOffsetDelegate(IntPtr thisPtr, double aOffset);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetGlobalZOffsetDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetGlobalZOffsetDelegate(IntPtr thisPtr, double aOffset);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ShowNorthArrowDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void HideNorthArrowDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsNorthArrowVisibleDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetNorthAngleDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetNorthAngleDelegate(IntPtr thisPtr, double aNorthAngle);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetUserFileFromDialogInPathDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aFilter, [MarshalAs(UnmanagedType.LPWStr)] string aPath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetNewUserFileFromDialogInPathDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aFilter, [MarshalAs(UnmanagedType.LPWStr)] string aPath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetMillimetreFromImperialStringDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetImperialStringFromMillimetreDelegate(IntPtr thisPtr, double aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void EnableUpdateVariantDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DisableUpdateVariantDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetPluginPathDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetUserPointsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetUserPointsWithCountDelegate(IntPtr thisPtr, ulong aCount);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetUserCatalogPathDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetUserPathFromDialogDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetUserPathFromDialogInPathDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aPath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ExecuteShortcutDelegate(IntPtr thisPtr, ShortcutKeyModifier aShortcutKeyModifier, ShortcutKey aShortcutKey);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void CloseCadworkDocumentSavedDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void CloseCadworkDocumentUnsavedDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetUseOfGlobalCoordinatesDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetUseOfGlobalCoordinatesDelegate(IntPtr thisPtr, bool aUseOfGlobalCoordinates);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate CVector3 GetGlobalOriginDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetGlobalOriginDelegate(IntPtr thisPtr, CVector3 aGlobalOrigin);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr CreateSnapshotDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aFormat, int aQuality, bool aWhiteBackground);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool RunExternalProgramFromCustomDirectoryDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate CWindowGeometry Get3dMainWindowGeometryDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetProjectDataKeysDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate int GetUserIntWithDefaultValueDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aMessage, int aDefaultValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetUserDoubleWithDefaultValueDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aMessage, double aDefaultValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetUserStringWithDefaultValueDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aMessage, [MarshalAs(UnmanagedType.LPWStr)] string aDefaultValue);
}
