// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;
using Cadwork.Api.Interop.Wrappers.Structs;

namespace Cadwork.Api.Interop.Wrappers.Controllers;

public class DimensionControllerWrapper
{
  private readonly IntPtr _nativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public DimensionControllerWrapper(IntPtr nativePtr)
  {
    _nativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<DimensionControllerInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(GetLastErrorDelegate), Marshal.GetDelegateForFunctionPointer<GetLastErrorDelegate>(vTable!.getLastErrorFunctionPtr) },
      { typeof(CreateDimensionDelegate), Marshal.GetDelegateForFunctionPointer<CreateDimensionDelegate>(vTable.createDimensionFunctionPtr) },
      { typeof(SetOrientationDelegate), Marshal.GetDelegateForFunctionPointer<SetOrientationDelegate>(vTable.setOrientationFunctionPtr) },
      { typeof(AddSegmentDelegate), Marshal.GetDelegateForFunctionPointer<AddSegmentDelegate>(vTable.addSegmentFunctionPtr) },
      { typeof(SetPrecisionDelegate), Marshal.GetDelegateForFunctionPointer<SetPrecisionDelegate>(vTable.setPrecisionFunctionPtr) },
      { typeof(SetTextSizeDelegate), Marshal.GetDelegateForFunctionPointer<SetTextSizeDelegate>(vTable.setTextSizeFunctionPtr) },
      { typeof(SetLineThicknessDelegate), Marshal.GetDelegateForFunctionPointer<SetLineThicknessDelegate>(vTable.setLineThicknessFunctionPtr) },
      { typeof(SetTotalDimensionDelegate), Marshal.GetDelegateForFunctionPointer<SetTotalDimensionDelegate>(vTable.setTotalDimensionFunctionPtr) },
      { typeof(SetTextColorDelegate), Marshal.GetDelegateForFunctionPointer<SetTextColorDelegate>(vTable.setTextColorFunctionPtr) },
      { typeof(SetLineColorDelegate), Marshal.GetDelegateForFunctionPointer<SetLineColorDelegate>(vTable.setLineColorFunctionPtr) },
      { typeof(SetDefaultAnchorLengthDelegate), Marshal.GetDelegateForFunctionPointer<SetDefaultAnchorLengthDelegate>(vTable.setDefaultAnchorLengthFunctionPtr) },
      { typeof(SetDistanceDelegate), Marshal.GetDelegateForFunctionPointer<SetDistanceDelegate>(vTable.setDistanceFunctionPtr) },
      { typeof(ShiftDistanceAndTextsDelegate), Marshal.GetDelegateForFunctionPointer<ShiftDistanceAndTextsDelegate>(vTable.shiftDistanceAndTextsFunctionPtr) },
      { typeof(GetDimensionPointsDelegate), Marshal.GetDelegateForFunctionPointer<GetDimensionPointsDelegate>(vTable.getDimensionPointsFunctionPtr) },
      { typeof(GetDefaultAnchorLengthDelegate), Marshal.GetDelegateForFunctionPointer<GetDefaultAnchorLengthDelegate>(vTable.getDefaultAnchorLengthFunctionPtr) },
      { typeof(GetDistanceDelegate), Marshal.GetDelegateForFunctionPointer<GetDistanceDelegate>(vTable.getDistanceFunctionPtr) },
      { typeof(GetPlaneNormalDelegate), Marshal.GetDelegateForFunctionPointer<GetPlaneNormalDelegate>(vTable.getPlaneNormalFunctionPtr) },
      { typeof(GetPlaneXlDelegate), Marshal.GetDelegateForFunctionPointer<GetPlaneXlDelegate>(vTable.getPlaneXlFunctionPtr) },
      { typeof(GetSegmentCountDelegate), Marshal.GetDelegateForFunctionPointer<GetSegmentCountDelegate>(vTable.getSegmentCountFunctionPtr) },
      { typeof(GetSegmentDistanceDelegate), Marshal.GetDelegateForFunctionPointer<GetSegmentDistanceDelegate>(vTable.getSegmentDistanceFunctionPtr) },
      { typeof(GetSegmentDirectionDelegate), Marshal.GetDelegateForFunctionPointer<GetSegmentDirectionDelegate>(vTable.getSegmentDirectionFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public IntPtr GetLastError(IntPtr aErrorCode) => GetDelegate<GetLastErrorDelegate>().Invoke(_nativePtr, aErrorCode);
  public ulong CreateDimension(CVector3 aXl, CVector3 aPlaneNormal, CVector3 aDistance, IntPtr aDimensionPoints) => GetDelegate<CreateDimensionDelegate>().Invoke(_nativePtr, aXl, aPlaneNormal, aDistance, aDimensionPoints);
  public void SetOrientation(IntPtr aElements, CVector3 aViewDir, CVector3 aViewDirUp) => GetDelegate<SetOrientationDelegate>().Invoke(_nativePtr, aElements, aViewDir, aViewDirUp);
  public void AddSegment(ulong aElement, CVector3 aSegment) => GetDelegate<AddSegmentDelegate>().Invoke(_nativePtr, aElement, aSegment);
  public void SetPrecision(IntPtr aElements, uint aPrecision) => GetDelegate<SetPrecisionDelegate>().Invoke(_nativePtr, aElements, aPrecision);
  public void SetTextSize(IntPtr aElements, double aTextSize) => GetDelegate<SetTextSizeDelegate>().Invoke(_nativePtr, aElements, aTextSize);
  public void SetLineThickness(IntPtr aElements, double aThickness) => GetDelegate<SetLineThicknessDelegate>().Invoke(_nativePtr, aElements, aThickness);
  public void SetTotalDimension(IntPtr aElements, bool aTotal) => GetDelegate<SetTotalDimensionDelegate>().Invoke(_nativePtr, aElements, aTotal);
  public void SetTextColor(IntPtr aElements, uint aColorId) => GetDelegate<SetTextColorDelegate>().Invoke(_nativePtr, aElements, aColorId);
  public void SetLineColor(IntPtr aElements, uint aColorId) => GetDelegate<SetLineColorDelegate>().Invoke(_nativePtr, aElements, aColorId);
  public void SetDefaultAnchorLength(IntPtr aElements, double aLength) => GetDelegate<SetDefaultAnchorLengthDelegate>().Invoke(_nativePtr, aElements, aLength);
  public void SetDistance(IntPtr aElements, CVector3 aDistance) => GetDelegate<SetDistanceDelegate>().Invoke(_nativePtr, aElements, aDistance);
  public void ShiftDistanceAndTexts(IntPtr aElements, bool aShifted) => GetDelegate<ShiftDistanceAndTextsDelegate>().Invoke(_nativePtr, aElements, aShifted);
  public IntPtr GetDimensionPoints(ulong aElement) => GetDelegate<GetDimensionPointsDelegate>().Invoke(_nativePtr, aElement);
  public double GetDefaultAnchorLength(ulong aElement) => GetDelegate<GetDefaultAnchorLengthDelegate>().Invoke(_nativePtr, aElement);
  public CVector3 GetDistance(ulong aElement) => GetDelegate<GetDistanceDelegate>().Invoke(_nativePtr, aElement);
  public CVector3 GetPlaneNormal(ulong aElement) => GetDelegate<GetPlaneNormalDelegate>().Invoke(_nativePtr, aElement);
  public CVector3 GetPlaneXl(ulong aElement) => GetDelegate<GetPlaneXlDelegate>().Invoke(_nativePtr, aElement);
  public int GetSegmentCount(ulong aElement) => GetDelegate<GetSegmentCountDelegate>().Invoke(_nativePtr, aElement);
  public double GetSegmentDistance(ulong aElement, int aSegmentIndex) => GetDelegate<GetSegmentDistanceDelegate>().Invoke(_nativePtr, aElement, aSegmentIndex);
  public CVector3 GetSegmentDirection(ulong aElement, int aSegmentIndex) => GetDelegate<GetSegmentDirectionDelegate>().Invoke(_nativePtr, aElement, aSegmentIndex);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class DimensionControllerInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr getLastErrorFunctionPtr;
    internal IntPtr createDimensionFunctionPtr;
    internal IntPtr setOrientationFunctionPtr;
    internal IntPtr addSegmentFunctionPtr;
    internal IntPtr setPrecisionFunctionPtr;
    internal IntPtr setTextSizeFunctionPtr;
    internal IntPtr setLineThicknessFunctionPtr;
    internal IntPtr setTotalDimensionFunctionPtr;
    internal IntPtr setTextColorFunctionPtr;
    internal IntPtr setLineColorFunctionPtr;
    internal IntPtr setDefaultAnchorLengthFunctionPtr;
    internal IntPtr setDistanceFunctionPtr;
    internal IntPtr shiftDistanceAndTextsFunctionPtr;
    internal IntPtr getDimensionPointsFunctionPtr;
    internal IntPtr getDefaultAnchorLengthFunctionPtr;
    internal IntPtr getDistanceFunctionPtr;
    internal IntPtr getPlaneNormalFunctionPtr;
    internal IntPtr getPlaneXlFunctionPtr;
    internal IntPtr getSegmentCountFunctionPtr;
    internal IntPtr getSegmentDistanceFunctionPtr;
    internal IntPtr getSegmentDirectionFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetLastErrorDelegate(IntPtr thisPtr, IntPtr aErrorCode);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate ulong CreateDimensionDelegate(IntPtr thisPtr, CVector3 aXl, CVector3 aPlaneNormal, CVector3 aDistance, IntPtr aDimensionPoints);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetOrientationDelegate(IntPtr thisPtr, IntPtr aElements, CVector3 aViewDir, CVector3 aViewDirUp);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void AddSegmentDelegate(IntPtr thisPtr, ulong aElement, CVector3 aSegment);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetPrecisionDelegate(IntPtr thisPtr, IntPtr aElements, uint aPrecision);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetTextSizeDelegate(IntPtr thisPtr, IntPtr aElements, double aTextSize);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetLineThicknessDelegate(IntPtr thisPtr, IntPtr aElements, double aThickness);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetTotalDimensionDelegate(IntPtr thisPtr, IntPtr aElements, bool aTotal);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetTextColorDelegate(IntPtr thisPtr, IntPtr aElements, uint aColorId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetLineColorDelegate(IntPtr thisPtr, IntPtr aElements, uint aColorId);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetDefaultAnchorLengthDelegate(IntPtr thisPtr, IntPtr aElements, double aLength);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetDistanceDelegate(IntPtr thisPtr, IntPtr aElements, CVector3 aDistance);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void ShiftDistanceAndTextsDelegate(IntPtr thisPtr, IntPtr aElements, bool aShifted);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate IntPtr GetDimensionPointsDelegate(IntPtr thisPtr, ulong aElement);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetDefaultAnchorLengthDelegate(IntPtr thisPtr, ulong aElement);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate CVector3 GetDistanceDelegate(IntPtr thisPtr, ulong aElement);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate CVector3 GetPlaneNormalDelegate(IntPtr thisPtr, ulong aElement);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate CVector3 GetPlaneXlDelegate(IntPtr thisPtr, ulong aElement);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate int GetSegmentCountDelegate(IntPtr thisPtr, ulong aElement);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetSegmentDistanceDelegate(IntPtr thisPtr, ulong aElement, int aSegmentIndex);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate CVector3 GetSegmentDirectionDelegate(IntPtr thisPtr, ulong aElement, int aSegmentIndex);
}
