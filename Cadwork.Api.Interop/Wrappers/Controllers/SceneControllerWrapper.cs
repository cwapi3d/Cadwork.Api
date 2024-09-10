// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Controllers;

public class SceneControllerWrapper
{
  private readonly IntPtr _nativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public SceneControllerWrapper(IntPtr nativePtr)
  {
    _nativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<SceneControllerInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(GetLastErrorDelegate), Marshal.GetDelegateForFunctionPointer<GetLastErrorDelegate>(vTable!.getLastErrorFunctionPtr) },
      { typeof(AddSceneDelegate), Marshal.GetDelegateForFunctionPointer<AddSceneDelegate>(vTable.addSceneFunctionPtr) },
      { typeof(RenameSceneDelegate), Marshal.GetDelegateForFunctionPointer<RenameSceneDelegate>(vTable.renameSceneFunctionPtr) },
      { typeof(DeleteSceneDelegate), Marshal.GetDelegateForFunctionPointer<DeleteSceneDelegate>(vTable.deleteSceneFunctionPtr) },
      { typeof(AddElementsToSceneDelegate), Marshal.GetDelegateForFunctionPointer<AddElementsToSceneDelegate>(vTable.addElementsToSceneFunctionPtr) },
      { typeof(RemoveElementsFromSceneDelegate), Marshal.GetDelegateForFunctionPointer<RemoveElementsFromSceneDelegate>(vTable.removeElementsFromSceneFunctionPtr) },
      { typeof(GetElementsFromSceneDelegate), Marshal.GetDelegateForFunctionPointer<GetElementsFromSceneDelegate>(vTable.getElementsFromSceneFunctionPtr) },
      { typeof(ActivateSceneDelegate), Marshal.GetDelegateForFunctionPointer<ActivateSceneDelegate>(vTable.activateSceneFunctionPtr) },
      { typeof(ClearErrorsDelegate), Marshal.GetDelegateForFunctionPointer<ClearErrorsDelegate>(vTable.clearErrorsFunctionPtr) },
      { typeof(GetSceneListDelegate), Marshal.GetDelegateForFunctionPointer<GetSceneListDelegate>(vTable.getSceneListFunctionPtr) },
      { typeof(GroupScenesDelegate), Marshal.GetDelegateForFunctionPointer<GroupScenesDelegate>(vTable.groupScenesFunctionPtr) },
      { typeof(UngroupScenesDelegate), Marshal.GetDelegateForFunctionPointer<UngroupScenesDelegate>(vTable.ungroupScenesFunctionPtr) },
      { typeof(IsScenePresentDelegate), Marshal.GetDelegateForFunctionPointer<IsScenePresentDelegate>(vTable.isScenePresentFunctionPtr) },
      { typeof(SetGroupTabColorDelegate), Marshal.GetDelegateForFunctionPointer<SetGroupTabColorDelegate>(vTable.setGroupTabColorFunctionPtr) },
      { typeof(RenameSceneGroupDelegate), Marshal.GetDelegateForFunctionPointer<RenameSceneGroupDelegate>(vTable.renameSceneGroupFunctionPtr) },
      { typeof(GetGroupIndexByNameDelegate), Marshal.GetDelegateForFunctionPointer<GetGroupIndexByNameDelegate>(vTable.getGroupIndexByNameFunctionPtr) },
      { typeof(RenameSceneGroupByIndexDelegate), Marshal.GetDelegateForFunctionPointer<RenameSceneGroupByIndexDelegate>(vTable.renameSceneGroupByIndexFunctionPtr) },
      { typeof(GroupScenesWithNameDelegate), Marshal.GetDelegateForFunctionPointer<GroupScenesWithNameDelegate>(vTable.groupScenesWithNameFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public IntPtr GetLastError(IntPtr aErrorCode) => GetDelegate<GetLastErrorDelegate>().Invoke(_nativePtr, aErrorCode);
  public bool AddScene(string aName) => GetDelegate<AddSceneDelegate>().Invoke(_nativePtr, aName);
  public bool RenameScene(string aOldName, string aNewName) => GetDelegate<RenameSceneDelegate>().Invoke(_nativePtr, aOldName, aNewName);
  public bool DeleteScene(string aName) => GetDelegate<DeleteSceneDelegate>().Invoke(_nativePtr, aName);
  public bool AddElementsToScene(string aName, IntPtr aElementIDs) => GetDelegate<AddElementsToSceneDelegate>().Invoke(_nativePtr, aName, aElementIDs);
  public bool RemoveElementsFromScene(string aName, IntPtr aElementIDs) => GetDelegate<RemoveElementsFromSceneDelegate>().Invoke(_nativePtr, aName, aElementIDs);
  public IntPtr GetElementsFromScene(string aName) => GetDelegate<GetElementsFromSceneDelegate>().Invoke(_nativePtr, aName);
  public bool ActivateScene(string aName) => GetDelegate<ActivateSceneDelegate>().Invoke(_nativePtr, aName);
  public void ClearErrors() => GetDelegate<ClearErrorsDelegate>().Invoke(_nativePtr);
  public IntPtr GetSceneList() => GetDelegate<GetSceneListDelegate>().Invoke(_nativePtr);
  public ulong GroupScenes(IntPtr aSceneNames) => GetDelegate<GroupScenesDelegate>().Invoke(_nativePtr, aSceneNames);
  public void UngroupScenes(ulong aGroupIndex) => GetDelegate<UngroupScenesDelegate>().Invoke(_nativePtr, aGroupIndex);
  public bool IsScenePresent(string aName) => GetDelegate<IsScenePresentDelegate>().Invoke(_nativePtr, aName);
  public void SetGroupTabColor(string aSceneGroupName, int aRed, int aGreen, int aBlue, int aAlpha) => GetDelegate<SetGroupTabColorDelegate>().Invoke(_nativePtr, aSceneGroupName, aRed, aGreen, aBlue, aAlpha);
  public void RenameSceneGroup(string aOldName, string aNewName) => GetDelegate<RenameSceneGroupDelegate>().Invoke(_nativePtr, aOldName, aNewName);
  public ulong GetGroupIndexByName(string aSceneGroupName) => GetDelegate<GetGroupIndexByNameDelegate>().Invoke(_nativePtr, aSceneGroupName);
  public void RenameSceneGroupByIndex(ulong aGroupIndex, string aNewName) => GetDelegate<RenameSceneGroupByIndexDelegate>().Invoke(_nativePtr, aGroupIndex, aNewName);
  public ulong GroupScenesWithName(IntPtr aSceneNames, string aGroupName) => GetDelegate<GroupScenesWithNameDelegate>().Invoke(_nativePtr, aSceneNames, aGroupName);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class SceneControllerInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr getLastErrorFunctionPtr;
    internal IntPtr addSceneFunctionPtr;
    internal IntPtr renameSceneFunctionPtr;
    internal IntPtr deleteSceneFunctionPtr;
    internal IntPtr addElementsToSceneFunctionPtr;
    internal IntPtr removeElementsFromSceneFunctionPtr;
    internal IntPtr getElementsFromSceneFunctionPtr;
    internal IntPtr activateSceneFunctionPtr;
    internal IntPtr clearErrorsFunctionPtr;
    internal IntPtr getSceneListFunctionPtr;
    internal IntPtr groupScenesFunctionPtr;
    internal IntPtr ungroupScenesFunctionPtr;
    internal IntPtr isScenePresentFunctionPtr;
    internal IntPtr setGroupTabColorFunctionPtr;
    internal IntPtr renameSceneGroupFunctionPtr;
    internal IntPtr getGroupIndexByNameFunctionPtr;
    internal IntPtr renameSceneGroupByIndexFunctionPtr;
    internal IntPtr groupScenesWithNameFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetLastErrorDelegate(IntPtr thisPtr, IntPtr aErrorCode);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool AddSceneDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool RenameSceneDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aOldName, [MarshalAs(UnmanagedType.LPWStr)] string aNewName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool DeleteSceneDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool AddElementsToSceneDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aName, IntPtr aElementIDs);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool RemoveElementsFromSceneDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aName, IntPtr aElementIDs);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetElementsFromSceneDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool ActivateSceneDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ClearErrorsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetSceneListDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong GroupScenesDelegate(IntPtr thisPtr, IntPtr aSceneNames);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void UngroupScenesDelegate(IntPtr thisPtr, ulong aGroupIndex);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsScenePresentDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetGroupTabColorDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aSceneGroupName, int aRed, int aGreen, int aBlue, int aAlpha);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void RenameSceneGroupDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aOldName, [MarshalAs(UnmanagedType.LPWStr)] string aNewName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong GetGroupIndexByNameDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aSceneGroupName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void RenameSceneGroupByIndexDelegate(IntPtr thisPtr, ulong aGroupIndex, [MarshalAs(UnmanagedType.LPWStr)] string aNewName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong GroupScenesWithNameDelegate(IntPtr thisPtr, IntPtr aSceneNames, [MarshalAs(UnmanagedType.LPWStr)] string aGroupName);
}
