// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;
using Cadwork.Api.Interop.Wrappers.Structs;

namespace Cadwork.Api.Interop.Wrappers.Controllers;

public class ConnectorAxisControllerWrapper
{
  private readonly IntPtr _nativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public ConnectorAxisControllerWrapper(IntPtr nativePtr)
  {
    _nativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<ConnectorAxisControllerInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(GetLastErrorDelegate), Marshal.GetDelegateForFunctionPointer<GetLastErrorDelegate>(vTable!.getLastErrorFunctionPtr) },
      { typeof(CreateStandardConnectorDelegate), Marshal.GetDelegateForFunctionPointer<CreateStandardConnectorDelegate>(vTable.createStandardConnectorFunctionPtr) },
      { typeof(GetItemGuidByNameDelegate), Marshal.GetDelegateForFunctionPointer<GetItemGuidByNameDelegate>(vTable.getItemGuidByNameFunctionPtr) },
      { typeof(GetBoltLengthDelegate), Marshal.GetDelegateForFunctionPointer<GetBoltLengthDelegate>(vTable.getBoltLengthFunctionPtr) },
      { typeof(SetBoltLengthDelegate), Marshal.GetDelegateForFunctionPointer<SetBoltLengthDelegate>(vTable.setBoltLengthFunctionPtr) },
      { typeof(GetBoltOverLengthDelegate), Marshal.GetDelegateForFunctionPointer<GetBoltOverLengthDelegate>(vTable.getBoltOverLengthFunctionPtr) },
      { typeof(SetBoltOverLengthDelegate), Marshal.GetDelegateForFunctionPointer<SetBoltOverLengthDelegate>(vTable.setBoltOverLengthFunctionPtr) },
      { typeof(GetBoltLengthAutomaticDelegate), Marshal.GetDelegateForFunctionPointer<GetBoltLengthAutomaticDelegate>(vTable.getBoltLengthAutomaticFunctionPtr) },
      { typeof(SetBoltLengthAutomaticDelegate), Marshal.GetDelegateForFunctionPointer<SetBoltLengthAutomaticDelegate>(vTable.setBoltLengthAutomaticFunctionPtr) },
      { typeof(GetBoltItemGuidDelegate), Marshal.GetDelegateForFunctionPointer<GetBoltItemGuidDelegate>(vTable.getBoltItemGuidFunctionPtr) },
      { typeof(SetBoltItemDelegate), Marshal.GetDelegateForFunctionPointer<SetBoltItemDelegate>(vTable.setBoltItemFunctionPtr) },
      { typeof(SetDiameterDelegate), Marshal.GetDelegateForFunctionPointer<SetDiameterDelegate>(vTable.setDiameterFunctionPtr) },
      { typeof(SetSectionDiameterDelegate), Marshal.GetDelegateForFunctionPointer<SetSectionDiameterDelegate>(vTable.setSectionDiameterFunctionPtr) },
      { typeof(GetSectionDiameterDelegate), Marshal.GetDelegateForFunctionPointer<GetSectionDiameterDelegate>(vTable.getSectionDiameterFunctionPtr) },
      { typeof(GetAxisItemsGuiDsDelegate), Marshal.GetDelegateForFunctionPointer<GetAxisItemsGuiDsDelegate>(vTable.getAxisItemsGUIDsFunctionPtr) },
      { typeof(GetAxisItemNameDelegate), Marshal.GetDelegateForFunctionPointer<GetAxisItemNameDelegate>(vTable.getAxisItemNameFunctionPtr) },
      { typeof(GetAxisItemMaterialDelegate), Marshal.GetDelegateForFunctionPointer<GetAxisItemMaterialDelegate>(vTable.getAxisItemMaterialFunctionPtr) },
      { typeof(GetAxisItemNormDelegate), Marshal.GetDelegateForFunctionPointer<GetAxisItemNormDelegate>(vTable.getAxisItemNormFunctionPtr) },
      { typeof(GetAxisItemStrengthCategoryDelegate), Marshal.GetDelegateForFunctionPointer<GetAxisItemStrengthCategoryDelegate>(vTable.getAxisItemStrengthCategoryFunctionPtr) },
      { typeof(GetAxisItemUserFieldDelegate), Marshal.GetDelegateForFunctionPointer<GetAxisItemUserFieldDelegate>(vTable.getAxisItemUserFieldFunctionPtr) },
      { typeof(GetAxisItemOrderNumberDelegate), Marshal.GetDelegateForFunctionPointer<GetAxisItemOrderNumberDelegate>(vTable.getAxisItemOrderNumberFunctionPtr) },
      { typeof(GetBoltOrderNumberDelegate), Marshal.GetDelegateForFunctionPointer<GetBoltOrderNumberDelegate>(vTable.getBoltOrderNumberFunctionPtr) },
      { typeof(CheckAxisDelegate), Marshal.GetDelegateForFunctionPointer<CheckAxisDelegate>(vTable.checkAxisFunctionPtr) },
      { typeof(ClearErrorsDelegate), Marshal.GetDelegateForFunctionPointer<ClearErrorsDelegate>(vTable.clearErrorsFunctionPtr) },
      { typeof(UpdateAxisCuttingAbilityDelegate), Marshal.GetDelegateForFunctionPointer<UpdateAxisCuttingAbilityDelegate>(vTable.updateAxisCuttingAbilityFunctionPtr) },
      { typeof(GetSectionCountDelegate), Marshal.GetDelegateForFunctionPointer<GetSectionCountDelegate>(vTable.getSectionCountFunctionPtr) },
      { typeof(GetSectionMaterialNameDelegate), Marshal.GetDelegateForFunctionPointer<GetSectionMaterialNameDelegate>(vTable.getSectionMaterialNameFunctionPtr) },
      { typeof(GetStandardConnectorListDelegate), Marshal.GetDelegateForFunctionPointer<GetStandardConnectorListDelegate>(vTable.getStandardConnectorListFunctionPtr) },
      { typeof(StartConfigurationDialogDelegate), Marshal.GetDelegateForFunctionPointer<StartConfigurationDialogDelegate>(vTable.startConfigurationDialogFunctionPtr) },
      { typeof(CreateBlankConnectorDelegate), Marshal.GetDelegateForFunctionPointer<CreateBlankConnectorDelegate>(vTable.createBlankConnectorFunctionPtr) },
      { typeof(GetSectionContactElementDelegate), Marshal.GetDelegateForFunctionPointer<GetSectionContactElementDelegate>(vTable.getSectionContactElementFunctionPtr) },
      { typeof(GetBoltDiameterDelegate), Marshal.GetDelegateForFunctionPointer<GetBoltDiameterDelegate>(vTable.getBoltDiameterFunctionPtr) },
      { typeof(ImportFromFileDelegate), Marshal.GetDelegateForFunctionPointer<ImportFromFileDelegate>(vTable.importFromFileFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public IntPtr GetLastError(IntPtr aErrorCode) => GetDelegate<GetLastErrorDelegate>().Invoke(_nativePtr, aErrorCode);
  public ulong CreateStandardConnector(string aAxisName, CVector3 aPoint1, CVector3 aPoint2) => GetDelegate<CreateStandardConnectorDelegate>().Invoke(_nativePtr, aAxisName, aPoint1, aPoint2);
  public IntPtr GetItemGuidByName(string aName, ulong aItemType) => GetDelegate<GetItemGuidByNameDelegate>().Invoke(_nativePtr, aName, aItemType);
  public double GetBoltLength(ulong aAxisId) => GetDelegate<GetBoltLengthDelegate>().Invoke(_nativePtr, aAxisId);
  public void SetBoltLength(ulong aAxisId, double aLength) => GetDelegate<SetBoltLengthDelegate>().Invoke(_nativePtr, aAxisId, aLength);
  public double GetBoltOverLength(ulong aAxisId) => GetDelegate<GetBoltOverLengthDelegate>().Invoke(_nativePtr, aAxisId);
  public void SetBoltOverLength(ulong aAxisId, double aOverLength) => GetDelegate<SetBoltOverLengthDelegate>().Invoke(_nativePtr, aAxisId, aOverLength);
  public bool GetBoltLengthAutomatic(ulong aAxisId) => GetDelegate<GetBoltLengthAutomaticDelegate>().Invoke(_nativePtr, aAxisId);
  public void SetBoltLengthAutomatic(ulong aAxisId, bool aLengthAutomatic) => GetDelegate<SetBoltLengthAutomaticDelegate>().Invoke(_nativePtr, aAxisId, aLengthAutomatic);
  public IntPtr GetBoltItemGuid(ulong aAxisId) => GetDelegate<GetBoltItemGuidDelegate>().Invoke(_nativePtr, aAxisId);
  public void SetBoltItem(ulong aAxisId, string aItemGuid) => GetDelegate<SetBoltItemDelegate>().Invoke(_nativePtr, aAxisId, aItemGuid);
  public void SetDiameter(ulong aAxisId, double aDiameter) => GetDelegate<SetDiameterDelegate>().Invoke(_nativePtr, aAxisId, aDiameter);
  public void SetSectionDiameter(ulong aAxisId, uint aSectionNr, double aDiameter) => GetDelegate<SetSectionDiameterDelegate>().Invoke(_nativePtr, aAxisId, aSectionNr, aDiameter);
  public double GetSectionDiameter(ulong aAxisId, uint aSectionNr) => GetDelegate<GetSectionDiameterDelegate>().Invoke(_nativePtr, aAxisId, aSectionNr);
  public IntPtr GetAxisItemsGuiDs(ulong aAxisId) => GetDelegate<GetAxisItemsGuiDsDelegate>().Invoke(_nativePtr, aAxisId);
  public IntPtr GetAxisItemName(string aGuid) => GetDelegate<GetAxisItemNameDelegate>().Invoke(_nativePtr, aGuid);
  public IntPtr GetAxisItemMaterial(string aGuid) => GetDelegate<GetAxisItemMaterialDelegate>().Invoke(_nativePtr, aGuid);
  public IntPtr GetAxisItemNorm(string aGuid) => GetDelegate<GetAxisItemNormDelegate>().Invoke(_nativePtr, aGuid);
  public IntPtr GetAxisItemStrengthCategory(string aGuid) => GetDelegate<GetAxisItemStrengthCategoryDelegate>().Invoke(_nativePtr, aGuid);
  public IntPtr GetAxisItemUserField(string aGuid, int aUserItemNr) => GetDelegate<GetAxisItemUserFieldDelegate>().Invoke(_nativePtr, aGuid, aUserItemNr);
  public IntPtr GetAxisItemOrderNumber(string aGuid) => GetDelegate<GetAxisItemOrderNumberDelegate>().Invoke(_nativePtr, aGuid);
  public IntPtr GetBoltOrderNumber(ulong aAxisId) => GetDelegate<GetBoltOrderNumberDelegate>().Invoke(_nativePtr, aAxisId);
  public bool CheckAxis(ulong aAxisId) => GetDelegate<CheckAxisDelegate>().Invoke(_nativePtr, aAxisId);
  public void ClearErrors() => GetDelegate<ClearErrorsDelegate>().Invoke(_nativePtr);
  public void UpdateAxisCuttingAbility(IntPtr aAxisIDs) => GetDelegate<UpdateAxisCuttingAbilityDelegate>().Invoke(_nativePtr, aAxisIDs);
  public int GetSectionCount(ulong aAxisId) => GetDelegate<GetSectionCountDelegate>().Invoke(_nativePtr, aAxisId);
  public IntPtr GetSectionMaterialName(ulong aAxisId, uint aSectionNr) => GetDelegate<GetSectionMaterialNameDelegate>().Invoke(_nativePtr, aAxisId, aSectionNr);
  public IntPtr GetStandardConnectorList() => GetDelegate<GetStandardConnectorListDelegate>().Invoke(_nativePtr);
  public void StartConfigurationDialog() => GetDelegate<StartConfigurationDialogDelegate>().Invoke(_nativePtr);
  public ulong CreateBlankConnector(double aDiameter, CVector3 aPoint1, CVector3 aPoint2) => GetDelegate<CreateBlankConnectorDelegate>().Invoke(_nativePtr, aDiameter, aPoint1, aPoint2);
  public ulong GetSectionContactElement(ulong aAxisId, uint aSectionNr) => GetDelegate<GetSectionContactElementDelegate>().Invoke(_nativePtr, aAxisId, aSectionNr);
  public double GetBoltDiameter(ulong aAxisId) => GetDelegate<GetBoltDiameterDelegate>().Invoke(_nativePtr, aAxisId);
  public void ImportFromFile(string aFilePath) => GetDelegate<ImportFromFileDelegate>().Invoke(_nativePtr, aFilePath);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class ConnectorAxisControllerInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr getLastErrorFunctionPtr;
    internal IntPtr createStandardConnectorFunctionPtr;
    internal IntPtr getItemGuidByNameFunctionPtr;
    internal IntPtr getBoltLengthFunctionPtr;
    internal IntPtr setBoltLengthFunctionPtr;
    internal IntPtr getBoltOverLengthFunctionPtr;
    internal IntPtr setBoltOverLengthFunctionPtr;
    internal IntPtr getBoltLengthAutomaticFunctionPtr;
    internal IntPtr setBoltLengthAutomaticFunctionPtr;
    internal IntPtr getBoltItemGuidFunctionPtr;
    internal IntPtr setBoltItemFunctionPtr;
    internal IntPtr setDiameterFunctionPtr;
    internal IntPtr setSectionDiameterFunctionPtr;
    internal IntPtr getSectionDiameterFunctionPtr;
    internal IntPtr getAxisItemsGUIDsFunctionPtr;
    internal IntPtr getAxisItemNameFunctionPtr;
    internal IntPtr getAxisItemMaterialFunctionPtr;
    internal IntPtr getAxisItemNormFunctionPtr;
    internal IntPtr getAxisItemStrengthCategoryFunctionPtr;
    internal IntPtr getAxisItemUserFieldFunctionPtr;
    internal IntPtr getAxisItemOrderNumberFunctionPtr;
    internal IntPtr getBoltOrderNumberFunctionPtr;
    internal IntPtr checkAxisFunctionPtr;
    internal IntPtr clearErrorsFunctionPtr;
    internal IntPtr updateAxisCuttingAbilityFunctionPtr;
    internal IntPtr getSectionCountFunctionPtr;
    internal IntPtr getSectionMaterialNameFunctionPtr;
    internal IntPtr getStandardConnectorListFunctionPtr;
    internal IntPtr startConfigurationDialogFunctionPtr;
    internal IntPtr createBlankConnectorFunctionPtr;
    internal IntPtr getSectionContactElementFunctionPtr;
    internal IntPtr getBoltDiameterFunctionPtr;
    internal IntPtr importFromFileFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetLastErrorDelegate(IntPtr thisPtr, IntPtr aErrorCode);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateStandardConnectorDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aAxisName, CVector3 aPoint1, CVector3 aPoint2);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetItemGuidByNameDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aName, ulong aItemType);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetBoltLengthDelegate(IntPtr thisPtr, ulong aAxisId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetBoltLengthDelegate(IntPtr thisPtr, ulong aAxisId, double aLength);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetBoltOverLengthDelegate(IntPtr thisPtr, ulong aAxisId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetBoltOverLengthDelegate(IntPtr thisPtr, ulong aAxisId, double aOverLength);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetBoltLengthAutomaticDelegate(IntPtr thisPtr, ulong aAxisId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetBoltLengthAutomaticDelegate(IntPtr thisPtr, ulong aAxisId, bool aLengthAutomatic);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetBoltItemGuidDelegate(IntPtr thisPtr, ulong aAxisId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetBoltItemDelegate(IntPtr thisPtr, ulong aAxisId, [MarshalAs(UnmanagedType.LPWStr)] string aItemGuid);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetDiameterDelegate(IntPtr thisPtr, ulong aAxisId, double aDiameter);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetSectionDiameterDelegate(IntPtr thisPtr, ulong aAxisId, uint aSectionNr, double aDiameter);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetSectionDiameterDelegate(IntPtr thisPtr, ulong aAxisId, uint aSectionNr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAxisItemsGuiDsDelegate(IntPtr thisPtr, ulong aAxisId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAxisItemNameDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aGuid);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAxisItemMaterialDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aGuid);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAxisItemNormDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aGuid);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAxisItemStrengthCategoryDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aGuid);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAxisItemUserFieldDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aGuid, int aUserItemNr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetAxisItemOrderNumberDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aGuid);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetBoltOrderNumberDelegate(IntPtr thisPtr, ulong aAxisId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool CheckAxisDelegate(IntPtr thisPtr, ulong aAxisId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ClearErrorsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void UpdateAxisCuttingAbilityDelegate(IntPtr thisPtr, IntPtr aAxisIDs);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate int GetSectionCountDelegate(IntPtr thisPtr, ulong aAxisId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetSectionMaterialNameDelegate(IntPtr thisPtr, ulong aAxisId, uint aSectionNr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetStandardConnectorListDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void StartConfigurationDialogDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateBlankConnectorDelegate(IntPtr thisPtr, double aDiameter, CVector3 aPoint1, CVector3 aPoint2);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong GetSectionContactElementDelegate(IntPtr thisPtr, ulong aAxisId, uint aSectionNr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetBoltDiameterDelegate(IntPtr thisPtr, ulong aAxisId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ImportFromFileDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aFilePath);
}
