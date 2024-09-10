// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Controllers;

public class EndTypeControllerWrapper
{
  private readonly IntPtr _nativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public EndTypeControllerWrapper(IntPtr nativePtr)
  {
    _nativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<EndTypeControllerInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(GetLastErrorDelegate), Marshal.GetDelegateForFunctionPointer<GetLastErrorDelegate>(vTable!.getLastErrorFunctionPtr) },
      { typeof(GetEndTypeNameDelegate), Marshal.GetDelegateForFunctionPointer<GetEndTypeNameDelegate>(vTable.getEndTypeNameFunctionPtr) },
      { typeof(GetEndTypeIdDelegate), Marshal.GetDelegateForFunctionPointer<GetEndTypeIdDelegate>(vTable.getEndTypeIDFunctionPtr) },
      { typeof(GetEndTypeIdStartDelegate), Marshal.GetDelegateForFunctionPointer<GetEndTypeIdStartDelegate>(vTable.getEndTypeIdStartFunctionPtr) },
      { typeof(GetEndTypeIdEndDelegate), Marshal.GetDelegateForFunctionPointer<GetEndTypeIdEndDelegate>(vTable.getEndTypeIdEndFunctionPtr) },
      { typeof(GetEndTypeIdFacDelegate), Marshal.GetDelegateForFunctionPointer<GetEndTypeIdFacDelegate>(vTable.getEndTypeIdFacFunctionPtr) },
      { typeof(GetEndTypeNameStartDelegate), Marshal.GetDelegateForFunctionPointer<GetEndTypeNameStartDelegate>(vTable.getEndTypeNameStartFunctionPtr) },
      { typeof(GetEndTypeNameEndDelegate), Marshal.GetDelegateForFunctionPointer<GetEndTypeNameEndDelegate>(vTable.getEndTypeNameEndFunctionPtr) },
      { typeof(GetEndTypeNameFacDelegate), Marshal.GetDelegateForFunctionPointer<GetEndTypeNameFacDelegate>(vTable.getEndTypeNameFacFunctionPtr) },
      { typeof(SetEndTypeNameStartDelegate), Marshal.GetDelegateForFunctionPointer<SetEndTypeNameStartDelegate>(vTable.setEndTypeNameStartFunctionPtr) },
      { typeof(SetEndTypeNameEndDelegate), Marshal.GetDelegateForFunctionPointer<SetEndTypeNameEndDelegate>(vTable.setEndTypeNameEndFunctionPtr) },
      { typeof(SetEndTypeNameFacDelegate), Marshal.GetDelegateForFunctionPointer<SetEndTypeNameFacDelegate>(vTable.setEndTypeNameFacFunctionPtr) },
      { typeof(SetEndTypeIdStartDelegate), Marshal.GetDelegateForFunctionPointer<SetEndTypeIdStartDelegate>(vTable.setEndTypeIdStartFunctionPtr) },
      { typeof(SetEndTypeIdEndDelegate), Marshal.GetDelegateForFunctionPointer<SetEndTypeIdEndDelegate>(vTable.setEndTypeIdEndFunctionPtr) },
      { typeof(SetEndTypeIdFacDelegate), Marshal.GetDelegateForFunctionPointer<SetEndTypeIdFacDelegate>(vTable.setEndTypeIdFacFunctionPtr) },
      { typeof(CreateNewEndTypeDelegate), Marshal.GetDelegateForFunctionPointer<CreateNewEndTypeDelegate>(vTable.createNewEndTypeFunctionPtr) },
      { typeof(ClearErrorsDelegate), Marshal.GetDelegateForFunctionPointer<ClearErrorsDelegate>(vTable.clearErrorsFunctionPtr) },
      { typeof(GetExistingTenonIdsDelegate), Marshal.GetDelegateForFunctionPointer<GetExistingTenonIdsDelegate>(vTable.getExistingTenonIdsFunctionPtr) },
      { typeof(GetExistingLengtheningIdsDelegate), Marshal.GetDelegateForFunctionPointer<GetExistingLengtheningIdsDelegate>(vTable.getExistingLengtheningIdsFunctionPtr) },
      { typeof(GetExistingDovetailIdsDelegate), Marshal.GetDelegateForFunctionPointer<GetExistingDovetailIdsDelegate>(vTable.getExistingDovetailIdsFunctionPtr) },
      { typeof(GetExistingDovetailDadoIdsDelegate), Marshal.GetDelegateForFunctionPointer<GetExistingDovetailDadoIdsDelegate>(vTable.getExistingDovetailDadoIdsFunctionPtr) },
      { typeof(GetExistingJapaneseTenonIdsDelegate), Marshal.GetDelegateForFunctionPointer<GetExistingJapaneseTenonIdsDelegate>(vTable.getExistingJapaneseTenonIdsFunctionPtr) },
      { typeof(StartEndTypeDialogDelegate), Marshal.GetDelegateForFunctionPointer<StartEndTypeDialogDelegate>(vTable.startEndTypeDialogFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public IntPtr GetLastError(IntPtr aErrorCode) => GetDelegate<GetLastErrorDelegate>().Invoke(_nativePtr, aErrorCode);
  public IntPtr GetEndTypeName(ulong aId) => GetDelegate<GetEndTypeNameDelegate>().Invoke(_nativePtr, aId);
  public ulong GetEndTypeId(string aName) => GetDelegate<GetEndTypeIdDelegate>().Invoke(_nativePtr, aName);
  public ulong GetEndTypeIdStart(ulong aId) => GetDelegate<GetEndTypeIdStartDelegate>().Invoke(_nativePtr, aId);
  public ulong GetEndTypeIdEnd(ulong aId) => GetDelegate<GetEndTypeIdEndDelegate>().Invoke(_nativePtr, aId);
  public ulong GetEndTypeIdFac(ulong aId, uint aFaceNumber) => GetDelegate<GetEndTypeIdFacDelegate>().Invoke(_nativePtr, aId, aFaceNumber);
  public IntPtr GetEndTypeNameStart(ulong aId) => GetDelegate<GetEndTypeNameStartDelegate>().Invoke(_nativePtr, aId);
  public IntPtr GetEndTypeNameEnd(ulong aId) => GetDelegate<GetEndTypeNameEndDelegate>().Invoke(_nativePtr, aId);
  public IntPtr GetEndTypeNameFac(ulong aId, uint aFaceNumber) => GetDelegate<GetEndTypeNameFacDelegate>().Invoke(_nativePtr, aId, aFaceNumber);
  public void SetEndTypeNameStart(ulong aId, string aName) => GetDelegate<SetEndTypeNameStartDelegate>().Invoke(_nativePtr, aId, aName);
  public void SetEndTypeNameEnd(ulong aId, string aName) => GetDelegate<SetEndTypeNameEndDelegate>().Invoke(_nativePtr, aId, aName);
  public void SetEndTypeNameFac(ulong aElementId, string aName, uint aFaceNumber) => GetDelegate<SetEndTypeNameFacDelegate>().Invoke(_nativePtr, aElementId, aName, aFaceNumber);
  public void SetEndTypeIdStart(ulong aElementId, ulong aEndTypeId) => GetDelegate<SetEndTypeIdStartDelegate>().Invoke(_nativePtr, aElementId, aEndTypeId);
  public void SetEndTypeIdEnd(ulong aElementId, ulong aEndTypeId) => GetDelegate<SetEndTypeIdEndDelegate>().Invoke(_nativePtr, aElementId, aEndTypeId);
  public void SetEndTypeIdFac(ulong aElementId, ulong aEndTypeId, uint aFaceNumber) => GetDelegate<SetEndTypeIdFacDelegate>().Invoke(_nativePtr, aElementId, aEndTypeId, aFaceNumber);
  public ulong CreateNewEndType(string aEndTypeName, uint aEndTypeId, string aFolderName) => GetDelegate<CreateNewEndTypeDelegate>().Invoke(_nativePtr, aEndTypeName, aEndTypeId, aFolderName);
  public void ClearErrors() => GetDelegate<ClearErrorsDelegate>().Invoke(_nativePtr);
  public IntPtr GetExistingTenonIds() => GetDelegate<GetExistingTenonIdsDelegate>().Invoke(_nativePtr);
  public IntPtr GetExistingLengtheningIds() => GetDelegate<GetExistingLengtheningIdsDelegate>().Invoke(_nativePtr);
  public IntPtr GetExistingDovetailIds() => GetDelegate<GetExistingDovetailIdsDelegate>().Invoke(_nativePtr);
  public IntPtr GetExistingDovetailDadoIds() => GetDelegate<GetExistingDovetailDadoIdsDelegate>().Invoke(_nativePtr);
  public IntPtr GetExistingJapaneseTenonIds() => GetDelegate<GetExistingJapaneseTenonIdsDelegate>().Invoke(_nativePtr);
  public ulong StartEndTypeDialog() => GetDelegate<StartEndTypeDialogDelegate>().Invoke(_nativePtr);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class EndTypeControllerInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr getLastErrorFunctionPtr;
    internal IntPtr getEndTypeNameFunctionPtr;
    internal IntPtr getEndTypeIDFunctionPtr;
    internal IntPtr getEndTypeIdStartFunctionPtr;
    internal IntPtr getEndTypeIdEndFunctionPtr;
    internal IntPtr getEndTypeIdFacFunctionPtr;
    internal IntPtr getEndTypeNameStartFunctionPtr;
    internal IntPtr getEndTypeNameEndFunctionPtr;
    internal IntPtr getEndTypeNameFacFunctionPtr;
    internal IntPtr setEndTypeNameStartFunctionPtr;
    internal IntPtr setEndTypeNameEndFunctionPtr;
    internal IntPtr setEndTypeNameFacFunctionPtr;
    internal IntPtr setEndTypeIdStartFunctionPtr;
    internal IntPtr setEndTypeIdEndFunctionPtr;
    internal IntPtr setEndTypeIdFacFunctionPtr;
    internal IntPtr createNewEndTypeFunctionPtr;
    internal IntPtr clearErrorsFunctionPtr;
    internal IntPtr getExistingTenonIdsFunctionPtr;
    internal IntPtr getExistingLengtheningIdsFunctionPtr;
    internal IntPtr getExistingDovetailIdsFunctionPtr;
    internal IntPtr getExistingDovetailDadoIdsFunctionPtr;
    internal IntPtr getExistingJapaneseTenonIdsFunctionPtr;
    internal IntPtr startEndTypeDialogFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetLastErrorDelegate(IntPtr thisPtr, IntPtr aErrorCode);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetEndTypeNameDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong GetEndTypeIdDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong GetEndTypeIdStartDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong GetEndTypeIdEndDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong GetEndTypeIdFacDelegate(IntPtr thisPtr, ulong aId, uint aFaceNumber);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetEndTypeNameStartDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetEndTypeNameEndDelegate(IntPtr thisPtr, ulong aId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetEndTypeNameFacDelegate(IntPtr thisPtr, ulong aId, uint aFaceNumber);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetEndTypeNameStartDelegate(IntPtr thisPtr, ulong aId, [MarshalAs(UnmanagedType.LPWStr)] string aName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetEndTypeNameEndDelegate(IntPtr thisPtr, ulong aId, [MarshalAs(UnmanagedType.LPWStr)] string aName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetEndTypeNameFacDelegate(IntPtr thisPtr, ulong aElementId, [MarshalAs(UnmanagedType.LPWStr)] string aName, uint aFaceNumber);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetEndTypeIdStartDelegate(IntPtr thisPtr, ulong aElementId, ulong aEndTypeId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetEndTypeIdEndDelegate(IntPtr thisPtr, ulong aElementId, ulong aEndTypeId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetEndTypeIdFacDelegate(IntPtr thisPtr, ulong aElementId, ulong aEndTypeId, uint aFaceNumber);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateNewEndTypeDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aEndTypeName, uint aEndTypeId, [MarshalAs(UnmanagedType.LPWStr)] string aFolderName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ClearErrorsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetExistingTenonIdsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetExistingLengtheningIdsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetExistingDovetailIdsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetExistingDovetailDadoIdsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetExistingJapaneseTenonIdsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong StartEndTypeDialogDelegate(IntPtr thisPtr);
}
