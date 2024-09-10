// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;
using Cadwork.Api.Interop.Wrappers.Structs;

namespace Cadwork.Api.Interop.Wrappers.Helpers;

public class FacetListWrapper
{
  public readonly IntPtr NativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public FacetListWrapper(IntPtr nativePtr)
  {
    NativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<FacetListInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(DestroyDelegate), Marshal.GetDelegateForFunctionPointer<DestroyDelegate>(vTable!.destroyFunctionPtr) },
      { typeof(CountDelegate), Marshal.GetDelegateForFunctionPointer<CountDelegate>(vTable.countFunctionPtr) },
      { typeof(AtDelegate), Marshal.GetDelegateForFunctionPointer<AtDelegate>(vTable.atFunctionPtr) },
      { typeof(GetExternalPolygonDelegate), Marshal.GetDelegateForFunctionPointer<GetExternalPolygonDelegate>(vTable.getExternalPolygonFunctionPtr) },
      { typeof(GetInternalPolygonsDelegate), Marshal.GetDelegateForFunctionPointer<GetInternalPolygonsDelegate>(vTable.getInternalPolygonsFunctionPtr) },
      { typeof(GetVerticesForReferenceFaceDelegate), Marshal.GetDelegateForFunctionPointer<GetVerticesForReferenceFaceDelegate>(vTable.getVerticesForReferenceFaceFunctionPtr) },
      { typeof(GetExternalPolygonForReferenceFaceDelegate), Marshal.GetDelegateForFunctionPointer<GetExternalPolygonForReferenceFaceDelegate>(vTable.getExternalPolygonForReferenceFaceFunctionPtr) },
      { typeof(GetInternalPolygonsForReferenceFaceDelegate), Marshal.GetDelegateForFunctionPointer<GetInternalPolygonsForReferenceFaceDelegate>(vTable.getInternalPolygonsForReferenceFaceFunctionPtr) },
      { typeof(GetNormalVectorDelegate), Marshal.GetDelegateForFunctionPointer<GetNormalVectorDelegate>(vTable.getNormalVectorFunctionPtr) },
      { typeof(GetDistanceToOriginDelegate), Marshal.GetDelegateForFunctionPointer<GetDistanceToOriginDelegate>(vTable.getDistanceToOriginFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public void Destroy() => GetDelegate<DestroyDelegate>().Invoke(NativePtr);
  public uint Count() => GetDelegate<CountDelegate>().Invoke(NativePtr);
  public IntPtr At(uint aIndex) => GetDelegate<AtDelegate>().Invoke(NativePtr, aIndex);
  public IntPtr GetExternalPolygon(uint aIndex) => GetDelegate<GetExternalPolygonDelegate>().Invoke(NativePtr, aIndex);
  public IntPtr GetInternalPolygons(uint aIndex) => GetDelegate<GetInternalPolygonsDelegate>().Invoke(NativePtr, aIndex);
  public IntPtr GetVerticesForReferenceFace() => GetDelegate<GetVerticesForReferenceFaceDelegate>().Invoke(NativePtr);
  public IntPtr GetExternalPolygonForReferenceFace() => GetDelegate<GetExternalPolygonForReferenceFaceDelegate>().Invoke(NativePtr);
  public IntPtr GetInternalPolygonsForReferenceFace() => GetDelegate<GetInternalPolygonsForReferenceFaceDelegate>().Invoke(NativePtr);
  public CVector3 GetNormalVector(uint aIndex) => GetDelegate<GetNormalVectorDelegate>().Invoke(NativePtr, aIndex);
  public double GetDistanceToOrigin(uint aIndex) => GetDelegate<GetDistanceToOriginDelegate>().Invoke(NativePtr, aIndex);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class FacetListInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr destroyFunctionPtr;
    internal IntPtr countFunctionPtr;
    internal IntPtr atFunctionPtr;
    internal IntPtr getExternalPolygonFunctionPtr;
    internal IntPtr getInternalPolygonsFunctionPtr;
    internal IntPtr getVerticesForReferenceFaceFunctionPtr;
    internal IntPtr getExternalPolygonForReferenceFaceFunctionPtr;
    internal IntPtr getInternalPolygonsForReferenceFaceFunctionPtr;
    internal IntPtr getNormalVectorFunctionPtr;
    internal IntPtr getDistanceToOriginFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DestroyDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate uint CountDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr AtDelegate(IntPtr thisPtr, uint aIndex);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetExternalPolygonDelegate(IntPtr thisPtr, uint aIndex);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetInternalPolygonsDelegate(IntPtr thisPtr, uint aIndex);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetVerticesForReferenceFaceDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetExternalPolygonForReferenceFaceDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetInternalPolygonsForReferenceFaceDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate CVector3 GetNormalVectorDelegate(IntPtr thisPtr, uint aIndex);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetDistanceToOriginDelegate(IntPtr thisPtr, uint aIndex);
}
