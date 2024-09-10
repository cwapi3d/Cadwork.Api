// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Controllers;

public class MultiLayerWallControllerWrapper
{
  private readonly IntPtr _nativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public MultiLayerWallControllerWrapper(IntPtr nativePtr)
  {
    _nativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<MultiLayerWallControllerInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(GetMultiLayerWallsDelegate), Marshal.GetDelegateForFunctionPointer<GetMultiLayerWallsDelegate>(vTable!.getMultiLayerWallsFunctionPtr) },
      { typeof(GetMultiLayerSetNameDelegate), Marshal.GetDelegateForFunctionPointer<GetMultiLayerSetNameDelegate>(vTable.getMultiLayerSetNameFunctionPtr) },
      { typeof(SetMultiLayerSetNameDelegate), Marshal.GetDelegateForFunctionPointer<SetMultiLayerSetNameDelegate>(vTable.setMultiLayerSetNameFunctionPtr) },
      { typeof(GetElementMultiLayerSetDelegate), Marshal.GetDelegateForFunctionPointer<GetElementMultiLayerSetDelegate>(vTable.getElementMultiLayerSetFunctionPtr) },
      { typeof(SetElementMultiLayerSetDelegate), Marshal.GetDelegateForFunctionPointer<SetElementMultiLayerSetDelegate>(vTable.setElementMultiLayerSetFunctionPtr) },
      { typeof(CreateMultiLayerWallDelegate), Marshal.GetDelegateForFunctionPointer<CreateMultiLayerWallDelegate>(vTable.createMultiLayerWallFunctionPtr) },
      { typeof(GetCoverNameDelegate), Marshal.GetDelegateForFunctionPointer<GetCoverNameDelegate>(vTable.getCoverNameFunctionPtr) },
      { typeof(SetCoverNameDelegate), Marshal.GetDelegateForFunctionPointer<SetCoverNameDelegate>(vTable.setCoverNameFunctionPtr) },
      { typeof(GetCoverMaterialDelegate), Marshal.GetDelegateForFunctionPointer<GetCoverMaterialDelegate>(vTable.getCoverMaterialFunctionPtr) },
      { typeof(SetCoverMaterialDelegate), Marshal.GetDelegateForFunctionPointer<SetCoverMaterialDelegate>(vTable.setCoverMaterialFunctionPtr) },
      { typeof(GetCoverThicknessDelegate), Marshal.GetDelegateForFunctionPointer<GetCoverThicknessDelegate>(vTable.getCoverThicknessFunctionPtr) },
      { typeof(SetCoverThicknessDelegate), Marshal.GetDelegateForFunctionPointer<SetCoverThicknessDelegate>(vTable.setCoverThicknessFunctionPtr) },
      { typeof(GetLayerCountDelegate), Marshal.GetDelegateForFunctionPointer<GetLayerCountDelegate>(vTable.getLayerCountFunctionPtr) },
      { typeof(AddLayerDelegate), Marshal.GetDelegateForFunctionPointer<AddLayerDelegate>(vTable.addLayerFunctionPtr) },
      { typeof(GetLayerNameDelegate), Marshal.GetDelegateForFunctionPointer<GetLayerNameDelegate>(vTable.getLayerNameFunctionPtr) },
      { typeof(SetLayerNameDelegate), Marshal.GetDelegateForFunctionPointer<SetLayerNameDelegate>(vTable.setLayerNameFunctionPtr) },
      { typeof(GetLayerMaterialDelegate), Marshal.GetDelegateForFunctionPointer<GetLayerMaterialDelegate>(vTable.getLayerMaterialFunctionPtr) },
      { typeof(SetLayerMaterialDelegate), Marshal.GetDelegateForFunctionPointer<SetLayerMaterialDelegate>(vTable.setLayerMaterialFunctionPtr) },
      { typeof(GetLayerThicknessDelegate), Marshal.GetDelegateForFunctionPointer<GetLayerThicknessDelegate>(vTable.getLayerThicknessFunctionPtr) },
      { typeof(SetLayerThicknessDelegate), Marshal.GetDelegateForFunctionPointer<SetLayerThicknessDelegate>(vTable.setLayerThicknessFunctionPtr) },
      { typeof(GetLayerTypeDelegate), Marshal.GetDelegateForFunctionPointer<GetLayerTypeDelegate>(vTable.getLayerTypeFunctionPtr) },
      { typeof(SetLayerTypeDelegate), Marshal.GetDelegateForFunctionPointer<SetLayerTypeDelegate>(vTable.setLayerTypeFunctionPtr) },
      { typeof(GetCoverColorDelegate), Marshal.GetDelegateForFunctionPointer<GetCoverColorDelegate>(vTable.getCoverColorFunctionPtr) },
      { typeof(SetCoverColorDelegate), Marshal.GetDelegateForFunctionPointer<SetCoverColorDelegate>(vTable.setCoverColorFunctionPtr) },
    };
  }

  public enum MultiLayerType
  {
    Undefined = 0,
    Structure = 1,
    Panel = 2,
    Lathing = 3,
    Air = 4,
    Covering = 5,
  };

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public List<ulong> GetMultiLayerWalls() => GetDelegate<GetMultiLayerWallsDelegate>().Invoke(_nativePtr);
  public IntPtr GetMultiLayerSetName(ulong aSetId) => GetDelegate<GetMultiLayerSetNameDelegate>().Invoke(_nativePtr, aSetId);
  public void SetMultiLayerSetName(ulong aSetId, string aSetName) => GetDelegate<SetMultiLayerSetNameDelegate>().Invoke(_nativePtr, aSetId, aSetName);
  public ulong GetElementMultiLayerSet(ulong aElementId) => GetDelegate<GetElementMultiLayerSetDelegate>().Invoke(_nativePtr, aElementId);
  public void SetElementMultiLayerSet(ulong aElementId, ulong aSetId) => GetDelegate<SetElementMultiLayerSetDelegate>().Invoke(_nativePtr, aElementId, aSetId);
  public ulong CreateMultiLayerWall(string aSetName) => GetDelegate<CreateMultiLayerWallDelegate>().Invoke(_nativePtr, aSetName);
  public IntPtr GetCoverName(ulong aSetId) => GetDelegate<GetCoverNameDelegate>().Invoke(_nativePtr, aSetId);
  public void SetCoverName(ulong aSetId, string aCoverName) => GetDelegate<SetCoverNameDelegate>().Invoke(_nativePtr, aSetId, aCoverName);
  public ulong GetCoverMaterial(ulong aSetId) => GetDelegate<GetCoverMaterialDelegate>().Invoke(_nativePtr, aSetId);
  public void SetCoverMaterial(ulong aSetId, ulong aCoverMaterial) => GetDelegate<SetCoverMaterialDelegate>().Invoke(_nativePtr, aSetId, aCoverMaterial);
  public double GetCoverThickness(ulong aSetId) => GetDelegate<GetCoverThicknessDelegate>().Invoke(_nativePtr, aSetId);
  public void SetCoverThickness(ulong aSetId, double aCoverThickness) => GetDelegate<SetCoverThicknessDelegate>().Invoke(_nativePtr, aSetId, aCoverThickness);
  public ulong GetLayerCount(ulong aSetId) => GetDelegate<GetLayerCountDelegate>().Invoke(_nativePtr, aSetId);
  public void AddLayer(ulong aSetId, MultiLayerType aType, string aName, ulong aMaterialId, double aThickness) => GetDelegate<AddLayerDelegate>().Invoke(_nativePtr, aSetId, aType, aName, aMaterialId, aThickness);
  public IntPtr GetLayerName(ulong aSetId, ulong aLayerIndex) => GetDelegate<GetLayerNameDelegate>().Invoke(_nativePtr, aSetId, aLayerIndex);
  public void SetLayerName(ulong aSetId, ulong aLayerIndex, string aName) => GetDelegate<SetLayerNameDelegate>().Invoke(_nativePtr, aSetId, aLayerIndex, aName);
  public ulong GetLayerMaterial(ulong aSetId, ulong aLayerIndex) => GetDelegate<GetLayerMaterialDelegate>().Invoke(_nativePtr, aSetId, aLayerIndex);
  public void SetLayerMaterial(ulong aSetId, ulong aLayerIndex, ulong aMaterialId) => GetDelegate<SetLayerMaterialDelegate>().Invoke(_nativePtr, aSetId, aLayerIndex, aMaterialId);
  public double GetLayerThickness(ulong aSetId, ulong aLayerIndex) => GetDelegate<GetLayerThicknessDelegate>().Invoke(_nativePtr, aSetId, aLayerIndex);
  public void SetLayerThickness(ulong aSetId, ulong aLayerIndex, double aThickness) => GetDelegate<SetLayerThicknessDelegate>().Invoke(_nativePtr, aSetId, aLayerIndex, aThickness);
  public MultiLayerType GetLayerType(ulong aSetId, ulong aLayerIndex) => GetDelegate<GetLayerTypeDelegate>().Invoke(_nativePtr, aSetId, aLayerIndex);
  public void SetLayerType(ulong aSetId, ulong aLayerIndex, MultiLayerType aType) => GetDelegate<SetLayerTypeDelegate>().Invoke(_nativePtr, aSetId, aLayerIndex, aType);
  public uint GetCoverColor(ulong aSetId) => GetDelegate<GetCoverColorDelegate>().Invoke(_nativePtr, aSetId);
  public void SetCoverColor(ulong aSetId, uint aCoverColor) => GetDelegate<SetCoverColorDelegate>().Invoke(_nativePtr, aSetId, aCoverColor);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class MultiLayerWallControllerInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr getMultiLayerWallsFunctionPtr;
    internal IntPtr getMultiLayerSetNameFunctionPtr;
    internal IntPtr setMultiLayerSetNameFunctionPtr;
    internal IntPtr getElementMultiLayerSetFunctionPtr;
    internal IntPtr setElementMultiLayerSetFunctionPtr;
    internal IntPtr createMultiLayerWallFunctionPtr;
    internal IntPtr getCoverNameFunctionPtr;
    internal IntPtr setCoverNameFunctionPtr;
    internal IntPtr getCoverMaterialFunctionPtr;
    internal IntPtr setCoverMaterialFunctionPtr;
    internal IntPtr getCoverThicknessFunctionPtr;
    internal IntPtr setCoverThicknessFunctionPtr;
    internal IntPtr getLayerCountFunctionPtr;
    internal IntPtr addLayerFunctionPtr;
    internal IntPtr getLayerNameFunctionPtr;
    internal IntPtr setLayerNameFunctionPtr;
    internal IntPtr getLayerMaterialFunctionPtr;
    internal IntPtr setLayerMaterialFunctionPtr;
    internal IntPtr getLayerThicknessFunctionPtr;
    internal IntPtr setLayerThicknessFunctionPtr;
    internal IntPtr getLayerTypeFunctionPtr;
    internal IntPtr setLayerTypeFunctionPtr;
    internal IntPtr getCoverColorFunctionPtr;
    internal IntPtr setCoverColorFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate List<ulong> GetMultiLayerWallsDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetMultiLayerSetNameDelegate(IntPtr thisPtr, ulong aSetId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetMultiLayerSetNameDelegate(IntPtr thisPtr, ulong aSetId, [MarshalAs(UnmanagedType.LPWStr)] string aSetName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong GetElementMultiLayerSetDelegate(IntPtr thisPtr, ulong aElementId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetElementMultiLayerSetDelegate(IntPtr thisPtr, ulong aElementId, ulong aSetId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateMultiLayerWallDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aSetName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetCoverNameDelegate(IntPtr thisPtr, ulong aSetId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCoverNameDelegate(IntPtr thisPtr, ulong aSetId, [MarshalAs(UnmanagedType.LPWStr)] string aCoverName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong GetCoverMaterialDelegate(IntPtr thisPtr, ulong aSetId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCoverMaterialDelegate(IntPtr thisPtr, ulong aSetId, ulong aCoverMaterial);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetCoverThicknessDelegate(IntPtr thisPtr, ulong aSetId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCoverThicknessDelegate(IntPtr thisPtr, ulong aSetId, double aCoverThickness);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong GetLayerCountDelegate(IntPtr thisPtr, ulong aSetId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void AddLayerDelegate(IntPtr thisPtr, ulong aSetId, MultiLayerType aType, [MarshalAs(UnmanagedType.LPWStr)] string aName, ulong aMaterialId, double aThickness);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetLayerNameDelegate(IntPtr thisPtr, ulong aSetId, ulong aLayerIndex);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetLayerNameDelegate(IntPtr thisPtr, ulong aSetId, ulong aLayerIndex, [MarshalAs(UnmanagedType.LPWStr)] string aName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong GetLayerMaterialDelegate(IntPtr thisPtr, ulong aSetId, ulong aLayerIndex);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetLayerMaterialDelegate(IntPtr thisPtr, ulong aSetId, ulong aLayerIndex, ulong aMaterialId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetLayerThicknessDelegate(IntPtr thisPtr, ulong aSetId, ulong aLayerIndex);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetLayerThicknessDelegate(IntPtr thisPtr, ulong aSetId, ulong aLayerIndex, double aThickness);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate MultiLayerType GetLayerTypeDelegate(IntPtr thisPtr, ulong aSetId, ulong aLayerIndex);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetLayerTypeDelegate(IntPtr thisPtr, ulong aSetId, ulong aLayerIndex, MultiLayerType aType);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate uint GetCoverColorDelegate(IntPtr thisPtr, ulong aSetId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetCoverColorDelegate(IntPtr thisPtr, ulong aSetId, uint aCoverColor);
}
