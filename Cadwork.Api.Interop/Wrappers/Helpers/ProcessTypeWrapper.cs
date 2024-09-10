// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Helpers;

public class ProcessTypeWrapper
{
  public readonly IntPtr NativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public ProcessTypeWrapper(IntPtr nativePtr)
  {
    NativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<ProcessTypeInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(DestroyDelegate), Marshal.GetDelegateForFunctionPointer<DestroyDelegate>(vTable!.destroyFunctionPtr) },
      { typeof(SetNoneDelegate), Marshal.GetDelegateForFunctionPointer<SetNoneDelegate>(vTable.setNoneFunctionPtr) },
      { typeof(IsNoneDelegate), Marshal.GetDelegateForFunctionPointer<IsNoneDelegate>(vTable.isNoneFunctionPtr) },
      { typeof(SetPurlinDelegate), Marshal.GetDelegateForFunctionPointer<SetPurlinDelegate>(vTable.setPurlinFunctionPtr) },
      { typeof(IsPurlinDelegate), Marshal.GetDelegateForFunctionPointer<IsPurlinDelegate>(vTable.isPurlinFunctionPtr) },
      { typeof(SetStudDelegate), Marshal.GetDelegateForFunctionPointer<SetStudDelegate>(vTable.setStudFunctionPtr) },
      { typeof(IsStudDelegate), Marshal.GetDelegateForFunctionPointer<IsStudDelegate>(vTable.isStudFunctionPtr) },
      { typeof(SetRafterDelegate), Marshal.GetDelegateForFunctionPointer<SetRafterDelegate>(vTable.setRafterFunctionPtr) },
      { typeof(IsRafterDelegate), Marshal.GetDelegateForFunctionPointer<IsRafterDelegate>(vTable.isRafterFunctionPtr) },
      { typeof(SetJackRafterDelegate), Marshal.GetDelegateForFunctionPointer<SetJackRafterDelegate>(vTable.setJackRafterFunctionPtr) },
      { typeof(IsJackRafterDelegate), Marshal.GetDelegateForFunctionPointer<IsJackRafterDelegate>(vTable.isJackRafterFunctionPtr) },
      { typeof(SetHipValleyDelegate), Marshal.GetDelegateForFunctionPointer<SetHipValleyDelegate>(vTable.setHipValleyFunctionPtr) },
      { typeof(IsHipValleyDelegate), Marshal.GetDelegateForFunctionPointer<IsHipValleyDelegate>(vTable.isHipValleyFunctionPtr) },
      { typeof(SetLogDelegate), Marshal.GetDelegateForFunctionPointer<SetLogDelegate>(vTable.setLogFunctionPtr) },
      { typeof(IsLogDelegate), Marshal.GetDelegateForFunctionPointer<IsLogDelegate>(vTable.isLogFunctionPtr) },
      { typeof(SetTrussDelegate), Marshal.GetDelegateForFunctionPointer<SetTrussDelegate>(vTable.setTrussFunctionPtr) },
      { typeof(IsTrussDelegate), Marshal.GetDelegateForFunctionPointer<IsTrussDelegate>(vTable.isTrussFunctionPtr) },
      { typeof(SetTreadDelegate), Marshal.GetDelegateForFunctionPointer<SetTreadDelegate>(vTable.setTreadFunctionPtr) },
      { typeof(IsTreadDelegate), Marshal.GetDelegateForFunctionPointer<IsTreadDelegate>(vTable.isTreadFunctionPtr) },
      { typeof(SetUser1Delegate), Marshal.GetDelegateForFunctionPointer<SetUser1Delegate>(vTable.setUser1FunctionPtr) },
      { typeof(IsUser1Delegate), Marshal.GetDelegateForFunctionPointer<IsUser1Delegate>(vTable.isUser1FunctionPtr) },
      { typeof(SetUser2Delegate), Marshal.GetDelegateForFunctionPointer<SetUser2Delegate>(vTable.setUser2FunctionPtr) },
      { typeof(IsUser2Delegate), Marshal.GetDelegateForFunctionPointer<IsUser2Delegate>(vTable.isUser2FunctionPtr) },
      { typeof(SetUser3Delegate), Marshal.GetDelegateForFunctionPointer<SetUser3Delegate>(vTable.setUser3FunctionPtr) },
      { typeof(IsUser3Delegate), Marshal.GetDelegateForFunctionPointer<IsUser3Delegate>(vTable.isUser3FunctionPtr) },
      { typeof(SetUser4Delegate), Marshal.GetDelegateForFunctionPointer<SetUser4Delegate>(vTable.setUser4FunctionPtr) },
      { typeof(IsUser4Delegate), Marshal.GetDelegateForFunctionPointer<IsUser4Delegate>(vTable.isUser4FunctionPtr) },
      { typeof(SetUser5Delegate), Marshal.GetDelegateForFunctionPointer<SetUser5Delegate>(vTable.setUser5FunctionPtr) },
      { typeof(IsUser5Delegate), Marshal.GetDelegateForFunctionPointer<IsUser5Delegate>(vTable.isUser5FunctionPtr) },
      { typeof(SetPanel1Delegate), Marshal.GetDelegateForFunctionPointer<SetPanel1Delegate>(vTable.setPanel1FunctionPtr) },
      { typeof(IsPanel1Delegate), Marshal.GetDelegateForFunctionPointer<IsPanel1Delegate>(vTable.isPanel1FunctionPtr) },
      { typeof(SetPanel2Delegate), Marshal.GetDelegateForFunctionPointer<SetPanel2Delegate>(vTable.setPanel2FunctionPtr) },
      { typeof(IsPanel2Delegate), Marshal.GetDelegateForFunctionPointer<IsPanel2Delegate>(vTable.isPanel2FunctionPtr) },
      { typeof(SetPanel3Delegate), Marshal.GetDelegateForFunctionPointer<SetPanel3Delegate>(vTable.setPanel3FunctionPtr) },
      { typeof(IsPanel3Delegate), Marshal.GetDelegateForFunctionPointer<IsPanel3Delegate>(vTable.isPanel3FunctionPtr) },
      { typeof(SetPanel4Delegate), Marshal.GetDelegateForFunctionPointer<SetPanel4Delegate>(vTable.setPanel4FunctionPtr) },
      { typeof(IsPanel4Delegate), Marshal.GetDelegateForFunctionPointer<IsPanel4Delegate>(vTable.isPanel4FunctionPtr) },
      { typeof(SetPanel5Delegate), Marshal.GetDelegateForFunctionPointer<SetPanel5Delegate>(vTable.setPanel5FunctionPtr) },
      { typeof(IsPanel5Delegate), Marshal.GetDelegateForFunctionPointer<IsPanel5Delegate>(vTable.isPanel5FunctionPtr) },
      { typeof(SetRoughVolumeFramedWallDelegate), Marshal.GetDelegateForFunctionPointer<SetRoughVolumeFramedWallDelegate>(vTable.setRoughVolumeFramedWallFunctionPtr) },
      { typeof(IsRoughVolumeFramedWallDelegate), Marshal.GetDelegateForFunctionPointer<IsRoughVolumeFramedWallDelegate>(vTable.isRoughVolumeFramedWallFunctionPtr) },
      { typeof(SetRoughVolumeSolidWoodWallDelegate), Marshal.GetDelegateForFunctionPointer<SetRoughVolumeSolidWoodWallDelegate>(vTable.setRoughVolumeSolidWoodWallFunctionPtr) },
      { typeof(IsRoughVolumeSolidWoodWallDelegate), Marshal.GetDelegateForFunctionPointer<IsRoughVolumeSolidWoodWallDelegate>(vTable.isRoughVolumeSolidWoodWallFunctionPtr) },
      { typeof(SetRoughVolumeLogHomeDelegate), Marshal.GetDelegateForFunctionPointer<SetRoughVolumeLogHomeDelegate>(vTable.setRoughVolumeLogHomeFunctionPtr) },
      { typeof(IsRoughVolumeLogHomeDelegate), Marshal.GetDelegateForFunctionPointer<IsRoughVolumeLogHomeDelegate>(vTable.isRoughVolumeLogHomeFunctionPtr) },
      { typeof(GetCadworkValueDelegate), Marshal.GetDelegateForFunctionPointer<GetCadworkValueDelegate>(vTable.getCadworkValueFunctionPtr) },
      { typeof(SetCadworkValueDelegate), Marshal.GetDelegateForFunctionPointer<SetCadworkValueDelegate>(vTable.setCadworkValueFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public void Destroy() => GetDelegate<DestroyDelegate>().Invoke(NativePtr);
  public void SetNone() => GetDelegate<SetNoneDelegate>().Invoke(NativePtr);
  public bool IsNone() => GetDelegate<IsNoneDelegate>().Invoke(NativePtr);
  public void SetPurlin() => GetDelegate<SetPurlinDelegate>().Invoke(NativePtr);
  public bool IsPurlin() => GetDelegate<IsPurlinDelegate>().Invoke(NativePtr);
  public void SetStud() => GetDelegate<SetStudDelegate>().Invoke(NativePtr);
  public bool IsStud() => GetDelegate<IsStudDelegate>().Invoke(NativePtr);
  public void SetRafter() => GetDelegate<SetRafterDelegate>().Invoke(NativePtr);
  public bool IsRafter() => GetDelegate<IsRafterDelegate>().Invoke(NativePtr);
  public void SetJackRafter() => GetDelegate<SetJackRafterDelegate>().Invoke(NativePtr);
  public bool IsJackRafter() => GetDelegate<IsJackRafterDelegate>().Invoke(NativePtr);
  public void SetHipValley() => GetDelegate<SetHipValleyDelegate>().Invoke(NativePtr);
  public bool IsHipValley() => GetDelegate<IsHipValleyDelegate>().Invoke(NativePtr);
  public void SetLog() => GetDelegate<SetLogDelegate>().Invoke(NativePtr);
  public bool IsLog() => GetDelegate<IsLogDelegate>().Invoke(NativePtr);
  public void SetTruss() => GetDelegate<SetTrussDelegate>().Invoke(NativePtr);
  public bool IsTruss() => GetDelegate<IsTrussDelegate>().Invoke(NativePtr);
  public void SetTread() => GetDelegate<SetTreadDelegate>().Invoke(NativePtr);
  public bool IsTread() => GetDelegate<IsTreadDelegate>().Invoke(NativePtr);
  public void SetUser1() => GetDelegate<SetUser1Delegate>().Invoke(NativePtr);
  public bool IsUser1() => GetDelegate<IsUser1Delegate>().Invoke(NativePtr);
  public void SetUser2() => GetDelegate<SetUser2Delegate>().Invoke(NativePtr);
  public bool IsUser2() => GetDelegate<IsUser2Delegate>().Invoke(NativePtr);
  public void SetUser3() => GetDelegate<SetUser3Delegate>().Invoke(NativePtr);
  public bool IsUser3() => GetDelegate<IsUser3Delegate>().Invoke(NativePtr);
  public void SetUser4() => GetDelegate<SetUser4Delegate>().Invoke(NativePtr);
  public bool IsUser4() => GetDelegate<IsUser4Delegate>().Invoke(NativePtr);
  public void SetUser5() => GetDelegate<SetUser5Delegate>().Invoke(NativePtr);
  public bool IsUser5() => GetDelegate<IsUser5Delegate>().Invoke(NativePtr);
  public void SetPanel1() => GetDelegate<SetPanel1Delegate>().Invoke(NativePtr);
  public bool IsPanel1() => GetDelegate<IsPanel1Delegate>().Invoke(NativePtr);
  public void SetPanel2() => GetDelegate<SetPanel2Delegate>().Invoke(NativePtr);
  public bool IsPanel2() => GetDelegate<IsPanel2Delegate>().Invoke(NativePtr);
  public void SetPanel3() => GetDelegate<SetPanel3Delegate>().Invoke(NativePtr);
  public bool IsPanel3() => GetDelegate<IsPanel3Delegate>().Invoke(NativePtr);
  public void SetPanel4() => GetDelegate<SetPanel4Delegate>().Invoke(NativePtr);
  public bool IsPanel4() => GetDelegate<IsPanel4Delegate>().Invoke(NativePtr);
  public void SetPanel5() => GetDelegate<SetPanel5Delegate>().Invoke(NativePtr);
  public bool IsPanel5() => GetDelegate<IsPanel5Delegate>().Invoke(NativePtr);
  public void SetRoughVolumeFramedWall() => GetDelegate<SetRoughVolumeFramedWallDelegate>().Invoke(NativePtr);
  public bool IsRoughVolumeFramedWall() => GetDelegate<IsRoughVolumeFramedWallDelegate>().Invoke(NativePtr);
  public void SetRoughVolumeSolidWoodWall() => GetDelegate<SetRoughVolumeSolidWoodWallDelegate>().Invoke(NativePtr);
  public bool IsRoughVolumeSolidWoodWall() => GetDelegate<IsRoughVolumeSolidWoodWallDelegate>().Invoke(NativePtr);
  public void SetRoughVolumeLogHome() => GetDelegate<SetRoughVolumeLogHomeDelegate>().Invoke(NativePtr);
  public bool IsRoughVolumeLogHome() => GetDelegate<IsRoughVolumeLogHomeDelegate>().Invoke(NativePtr);
  public int GetCadworkValue() => GetDelegate<GetCadworkValueDelegate>().Invoke(NativePtr);
  public void SetCadworkValue(int aProcessType) => GetDelegate<SetCadworkValueDelegate>().Invoke(NativePtr, aProcessType);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class ProcessTypeInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr destroyFunctionPtr;
    internal IntPtr setNoneFunctionPtr;
    internal IntPtr isNoneFunctionPtr;
    internal IntPtr setPurlinFunctionPtr;
    internal IntPtr isPurlinFunctionPtr;
    internal IntPtr setStudFunctionPtr;
    internal IntPtr isStudFunctionPtr;
    internal IntPtr setRafterFunctionPtr;
    internal IntPtr isRafterFunctionPtr;
    internal IntPtr setJackRafterFunctionPtr;
    internal IntPtr isJackRafterFunctionPtr;
    internal IntPtr setHipValleyFunctionPtr;
    internal IntPtr isHipValleyFunctionPtr;
    internal IntPtr setLogFunctionPtr;
    internal IntPtr isLogFunctionPtr;
    internal IntPtr setTrussFunctionPtr;
    internal IntPtr isTrussFunctionPtr;
    internal IntPtr setTreadFunctionPtr;
    internal IntPtr isTreadFunctionPtr;
    internal IntPtr setUser1FunctionPtr;
    internal IntPtr isUser1FunctionPtr;
    internal IntPtr setUser2FunctionPtr;
    internal IntPtr isUser2FunctionPtr;
    internal IntPtr setUser3FunctionPtr;
    internal IntPtr isUser3FunctionPtr;
    internal IntPtr setUser4FunctionPtr;
    internal IntPtr isUser4FunctionPtr;
    internal IntPtr setUser5FunctionPtr;
    internal IntPtr isUser5FunctionPtr;
    internal IntPtr setPanel1FunctionPtr;
    internal IntPtr isPanel1FunctionPtr;
    internal IntPtr setPanel2FunctionPtr;
    internal IntPtr isPanel2FunctionPtr;
    internal IntPtr setPanel3FunctionPtr;
    internal IntPtr isPanel3FunctionPtr;
    internal IntPtr setPanel4FunctionPtr;
    internal IntPtr isPanel4FunctionPtr;
    internal IntPtr setPanel5FunctionPtr;
    internal IntPtr isPanel5FunctionPtr;
    internal IntPtr setRoughVolumeFramedWallFunctionPtr;
    internal IntPtr isRoughVolumeFramedWallFunctionPtr;
    internal IntPtr setRoughVolumeSolidWoodWallFunctionPtr;
    internal IntPtr isRoughVolumeSolidWoodWallFunctionPtr;
    internal IntPtr setRoughVolumeLogHomeFunctionPtr;
    internal IntPtr isRoughVolumeLogHomeFunctionPtr;
    internal IntPtr getCadworkValueFunctionPtr;
    internal IntPtr setCadworkValueFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DestroyDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetNoneDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsNoneDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetPurlinDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsPurlinDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetStudDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsStudDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetRafterDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsRafterDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetJackRafterDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsJackRafterDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetHipValleyDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsHipValleyDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetLogDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsLogDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetTrussDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsTrussDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetTreadDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsTreadDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetUser1Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsUser1Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetUser2Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsUser2Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetUser3Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsUser3Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetUser4Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsUser4Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetUser5Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsUser5Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetPanel1Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsPanel1Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetPanel2Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsPanel2Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetPanel3Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsPanel3Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetPanel4Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsPanel4Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetPanel5Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsPanel5Delegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetRoughVolumeFramedWallDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsRoughVolumeFramedWallDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetRoughVolumeSolidWoodWallDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsRoughVolumeSolidWoodWallDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetRoughVolumeLogHomeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsRoughVolumeLogHomeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate int GetCadworkValueDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCadworkValueDelegate(IntPtr thisPtr, int aProcessType);
}
