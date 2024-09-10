// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Helpers;

public class IfcElementTypeWrapper
{
  public readonly IntPtr NativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public IfcElementTypeWrapper(IntPtr nativePtr)
  {
    NativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<IfcElementTypeInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(DestroyDelegate), Marshal.GetDelegateForFunctionPointer<DestroyDelegate>(vTable!.destroyFunctionPtr) },
      { typeof(IsNoneDelegate), Marshal.GetDelegateForFunctionPointer<IsNoneDelegate>(vTable.isNoneFunctionPtr) },
      { typeof(IsIfcBeamDelegate), Marshal.GetDelegateForFunctionPointer<IsIfcBeamDelegate>(vTable.isIfcBeamFunctionPtr) },
      { typeof(IsIfcColumnDelegate), Marshal.GetDelegateForFunctionPointer<IsIfcColumnDelegate>(vTable.isIfcColumnFunctionPtr) },
      { typeof(IsIfcCurtainWallDelegate), Marshal.GetDelegateForFunctionPointer<IsIfcCurtainWallDelegate>(vTable.isIfcCurtainWallFunctionPtr) },
      { typeof(IsIfcDoorDelegate), Marshal.GetDelegateForFunctionPointer<IsIfcDoorDelegate>(vTable.isIfcDoorFunctionPtr) },
      { typeof(IsIfcMemberDelegate), Marshal.GetDelegateForFunctionPointer<IsIfcMemberDelegate>(vTable.isIfcMemberFunctionPtr) },
      { typeof(IsIfcPlateDelegate), Marshal.GetDelegateForFunctionPointer<IsIfcPlateDelegate>(vTable.isIfcPlateFunctionPtr) },
      { typeof(IsIfcRailingDelegate), Marshal.GetDelegateForFunctionPointer<IsIfcRailingDelegate>(vTable.isIfcRailingFunctionPtr) },
      { typeof(IsIfcRampDelegate), Marshal.GetDelegateForFunctionPointer<IsIfcRampDelegate>(vTable.isIfcRampFunctionPtr) },
      { typeof(IsIfcRampFlightDelegate), Marshal.GetDelegateForFunctionPointer<IsIfcRampFlightDelegate>(vTable.isIfcRampFlightFunctionPtr) },
      { typeof(IsIfcRoofDelegate), Marshal.GetDelegateForFunctionPointer<IsIfcRoofDelegate>(vTable.isIfcRoofFunctionPtr) },
      { typeof(IsIfcSlabDelegate), Marshal.GetDelegateForFunctionPointer<IsIfcSlabDelegate>(vTable.isIfcSlabFunctionPtr) },
      { typeof(IsIfcStairDelegate), Marshal.GetDelegateForFunctionPointer<IsIfcStairDelegate>(vTable.isIfcStairFunctionPtr) },
      { typeof(IsIfcStairFlightDelegate), Marshal.GetDelegateForFunctionPointer<IsIfcStairFlightDelegate>(vTable.isIfcStairFlightFunctionPtr) },
      { typeof(IsIfcWallDelegate), Marshal.GetDelegateForFunctionPointer<IsIfcWallDelegate>(vTable.isIfcWallFunctionPtr) },
      { typeof(IsIfcWallStandardCaseDelegate), Marshal.GetDelegateForFunctionPointer<IsIfcWallStandardCaseDelegate>(vTable.isIfcWallStandardCaseFunctionPtr) },
      { typeof(IsIfcWindowDelegate), Marshal.GetDelegateForFunctionPointer<IsIfcWindowDelegate>(vTable.isIfcWindowFunctionPtr) },
      { typeof(SetNoneDelegate), Marshal.GetDelegateForFunctionPointer<SetNoneDelegate>(vTable.setNoneFunctionPtr) },
      { typeof(SetIfcBeamDelegate), Marshal.GetDelegateForFunctionPointer<SetIfcBeamDelegate>(vTable.setIfcBeamFunctionPtr) },
      { typeof(SetIfcColumnDelegate), Marshal.GetDelegateForFunctionPointer<SetIfcColumnDelegate>(vTable.setIfcColumnFunctionPtr) },
      { typeof(SetIfcCurtainWallDelegate), Marshal.GetDelegateForFunctionPointer<SetIfcCurtainWallDelegate>(vTable.setIfcCurtainWallFunctionPtr) },
      { typeof(SetIfcDoorDelegate), Marshal.GetDelegateForFunctionPointer<SetIfcDoorDelegate>(vTable.setIfcDoorFunctionPtr) },
      { typeof(SetIfcMemberDelegate), Marshal.GetDelegateForFunctionPointer<SetIfcMemberDelegate>(vTable.setIfcMemberFunctionPtr) },
      { typeof(SetIfcPlateDelegate), Marshal.GetDelegateForFunctionPointer<SetIfcPlateDelegate>(vTable.setIfcPlateFunctionPtr) },
      { typeof(SetIfcRailingDelegate), Marshal.GetDelegateForFunctionPointer<SetIfcRailingDelegate>(vTable.setIfcRailingFunctionPtr) },
      { typeof(SetIfcRampDelegate), Marshal.GetDelegateForFunctionPointer<SetIfcRampDelegate>(vTable.setIfcRampFunctionPtr) },
      { typeof(SetIfcRampFlightDelegate), Marshal.GetDelegateForFunctionPointer<SetIfcRampFlightDelegate>(vTable.setIfcRampFlightFunctionPtr) },
      { typeof(SetIfcRoofDelegate), Marshal.GetDelegateForFunctionPointer<SetIfcRoofDelegate>(vTable.setIfcRoofFunctionPtr) },
      { typeof(SetIfcSlabDelegate), Marshal.GetDelegateForFunctionPointer<SetIfcSlabDelegate>(vTable.setIfcSlabFunctionPtr) },
      { typeof(SetIfcStairDelegate), Marshal.GetDelegateForFunctionPointer<SetIfcStairDelegate>(vTable.setIfcStairFunctionPtr) },
      { typeof(SetIfcStairFlightDelegate), Marshal.GetDelegateForFunctionPointer<SetIfcStairFlightDelegate>(vTable.setIfcStairFlightFunctionPtr) },
      { typeof(SetIfcWallDelegate), Marshal.GetDelegateForFunctionPointer<SetIfcWallDelegate>(vTable.setIfcWallFunctionPtr) },
      { typeof(SetIfcWallStandardCaseDelegate), Marshal.GetDelegateForFunctionPointer<SetIfcWallStandardCaseDelegate>(vTable.setIfcWallStandardCaseFunctionPtr) },
      { typeof(SetIfcWindowDelegate), Marshal.GetDelegateForFunctionPointer<SetIfcWindowDelegate>(vTable.setIfcWindowFunctionPtr) },
      { typeof(IsIfcBuildingElementProxyDelegate), Marshal.GetDelegateForFunctionPointer<IsIfcBuildingElementProxyDelegate>(vTable.isIfcBuildingElementProxyFunctionPtr) },
      { typeof(IsIfcChimneyDelegate), Marshal.GetDelegateForFunctionPointer<IsIfcChimneyDelegate>(vTable.isIfcChimneyFunctionPtr) },
      { typeof(IsIfcCoveringDelegate), Marshal.GetDelegateForFunctionPointer<IsIfcCoveringDelegate>(vTable.isIfcCoveringFunctionPtr) },
      { typeof(IsIfcFootingDelegate), Marshal.GetDelegateForFunctionPointer<IsIfcFootingDelegate>(vTable.isIfcFootingFunctionPtr) },
      { typeof(IsIfcFurnishingElementDelegate), Marshal.GetDelegateForFunctionPointer<IsIfcFurnishingElementDelegate>(vTable.isIfcFurnishingElementFunctionPtr) },
      { typeof(IsIfcOpeningElementDelegate), Marshal.GetDelegateForFunctionPointer<IsIfcOpeningElementDelegate>(vTable.isIfcOpeningElementFunctionPtr) },
      { typeof(IsIfcSpaceDelegate), Marshal.GetDelegateForFunctionPointer<IsIfcSpaceDelegate>(vTable.isIfcSpaceFunctionPtr) },
      { typeof(IsIfcFlowSegmentDelegate), Marshal.GetDelegateForFunctionPointer<IsIfcFlowSegmentDelegate>(vTable.isIfcFlowSegmentFunctionPtr) },
      { typeof(IsIfcBuildingElementPartDelegate), Marshal.GetDelegateForFunctionPointer<IsIfcBuildingElementPartDelegate>(vTable.isIfcBuildingElementPartFunctionPtr) },
      { typeof(IsIfcDiscreteAccessoryDelegate), Marshal.GetDelegateForFunctionPointer<IsIfcDiscreteAccessoryDelegate>(vTable.isIfcDiscreteAccessoryFunctionPtr) },
      { typeof(IsIfcFastenerDelegate), Marshal.GetDelegateForFunctionPointer<IsIfcFastenerDelegate>(vTable.isIfcFastenerFunctionPtr) },
      { typeof(IsIfcMechanicalFastenerDelegate), Marshal.GetDelegateForFunctionPointer<IsIfcMechanicalFastenerDelegate>(vTable.isIfcMechanicalFastenerFunctionPtr) },
      { typeof(SetIfcBuildingElementProxyDelegate), Marshal.GetDelegateForFunctionPointer<SetIfcBuildingElementProxyDelegate>(vTable.setIfcBuildingElementProxyFunctionPtr) },
      { typeof(SetIfcChimneyDelegate), Marshal.GetDelegateForFunctionPointer<SetIfcChimneyDelegate>(vTable.setIfcChimneyFunctionPtr) },
      { typeof(SetIfcCoveringDelegate), Marshal.GetDelegateForFunctionPointer<SetIfcCoveringDelegate>(vTable.setIfcCoveringFunctionPtr) },
      { typeof(SetIfcFootingDelegate), Marshal.GetDelegateForFunctionPointer<SetIfcFootingDelegate>(vTable.setIfcFootingFunctionPtr) },
      { typeof(SetIfcFurnishingElementDelegate), Marshal.GetDelegateForFunctionPointer<SetIfcFurnishingElementDelegate>(vTable.setIfcFurnishingElementFunctionPtr) },
      { typeof(SetIfcOpeningElementDelegate), Marshal.GetDelegateForFunctionPointer<SetIfcOpeningElementDelegate>(vTable.setIfcOpeningElementFunctionPtr) },
      { typeof(SetIfcSpaceDelegate), Marshal.GetDelegateForFunctionPointer<SetIfcSpaceDelegate>(vTable.setIfcSpaceFunctionPtr) },
      { typeof(SetIfcFlowSegmentDelegate), Marshal.GetDelegateForFunctionPointer<SetIfcFlowSegmentDelegate>(vTable.setIfcFlowSegmentFunctionPtr) },
      { typeof(SetIfcBuildingElementPartDelegate), Marshal.GetDelegateForFunctionPointer<SetIfcBuildingElementPartDelegate>(vTable.setIfcBuildingElementPartFunctionPtr) },
      { typeof(SetIfcDiscreteAccessoryDelegate), Marshal.GetDelegateForFunctionPointer<SetIfcDiscreteAccessoryDelegate>(vTable.setIfcDiscreteAccessoryFunctionPtr) },
      { typeof(SetIfcFastenerDelegate), Marshal.GetDelegateForFunctionPointer<SetIfcFastenerDelegate>(vTable.setIfcFastenerFunctionPtr) },
      { typeof(SetIfcMechanicalFastenerDelegate), Marshal.GetDelegateForFunctionPointer<SetIfcMechanicalFastenerDelegate>(vTable.setIfcMechanicalFastenerFunctionPtr) },
      { typeof(IsIfcElementAssemblyDelegate), Marshal.GetDelegateForFunctionPointer<IsIfcElementAssemblyDelegate>(vTable.isIfcElementAssemblyFunctionPtr) },
      { typeof(SetIfcElementAssemblyDelegate), Marshal.GetDelegateForFunctionPointer<SetIfcElementAssemblyDelegate>(vTable.setIfcElementAssemblyFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public void Destroy() => GetDelegate<DestroyDelegate>().Invoke(NativePtr);
  public bool IsNone() => GetDelegate<IsNoneDelegate>().Invoke(NativePtr);
  public bool IsIfcBeam() => GetDelegate<IsIfcBeamDelegate>().Invoke(NativePtr);
  public bool IsIfcColumn() => GetDelegate<IsIfcColumnDelegate>().Invoke(NativePtr);
  public bool IsIfcCurtainWall() => GetDelegate<IsIfcCurtainWallDelegate>().Invoke(NativePtr);
  public bool IsIfcDoor() => GetDelegate<IsIfcDoorDelegate>().Invoke(NativePtr);
  public bool IsIfcMember() => GetDelegate<IsIfcMemberDelegate>().Invoke(NativePtr);
  public bool IsIfcPlate() => GetDelegate<IsIfcPlateDelegate>().Invoke(NativePtr);
  public bool IsIfcRailing() => GetDelegate<IsIfcRailingDelegate>().Invoke(NativePtr);
  public bool IsIfcRamp() => GetDelegate<IsIfcRampDelegate>().Invoke(NativePtr);
  public bool IsIfcRampFlight() => GetDelegate<IsIfcRampFlightDelegate>().Invoke(NativePtr);
  public bool IsIfcRoof() => GetDelegate<IsIfcRoofDelegate>().Invoke(NativePtr);
  public bool IsIfcSlab() => GetDelegate<IsIfcSlabDelegate>().Invoke(NativePtr);
  public bool IsIfcStair() => GetDelegate<IsIfcStairDelegate>().Invoke(NativePtr);
  public bool IsIfcStairFlight() => GetDelegate<IsIfcStairFlightDelegate>().Invoke(NativePtr);
  public bool IsIfcWall() => GetDelegate<IsIfcWallDelegate>().Invoke(NativePtr);
  public bool IsIfcWallStandardCase() => GetDelegate<IsIfcWallStandardCaseDelegate>().Invoke(NativePtr);
  public bool IsIfcWindow() => GetDelegate<IsIfcWindowDelegate>().Invoke(NativePtr);
  public void SetNone() => GetDelegate<SetNoneDelegate>().Invoke(NativePtr);
  public void SetIfcBeam() => GetDelegate<SetIfcBeamDelegate>().Invoke(NativePtr);
  public void SetIfcColumn() => GetDelegate<SetIfcColumnDelegate>().Invoke(NativePtr);
  public void SetIfcCurtainWall() => GetDelegate<SetIfcCurtainWallDelegate>().Invoke(NativePtr);
  public void SetIfcDoor() => GetDelegate<SetIfcDoorDelegate>().Invoke(NativePtr);
  public void SetIfcMember() => GetDelegate<SetIfcMemberDelegate>().Invoke(NativePtr);
  public void SetIfcPlate() => GetDelegate<SetIfcPlateDelegate>().Invoke(NativePtr);
  public void SetIfcRailing() => GetDelegate<SetIfcRailingDelegate>().Invoke(NativePtr);
  public void SetIfcRamp() => GetDelegate<SetIfcRampDelegate>().Invoke(NativePtr);
  public void SetIfcRampFlight() => GetDelegate<SetIfcRampFlightDelegate>().Invoke(NativePtr);
  public void SetIfcRoof() => GetDelegate<SetIfcRoofDelegate>().Invoke(NativePtr);
  public void SetIfcSlab() => GetDelegate<SetIfcSlabDelegate>().Invoke(NativePtr);
  public void SetIfcStair() => GetDelegate<SetIfcStairDelegate>().Invoke(NativePtr);
  public void SetIfcStairFlight() => GetDelegate<SetIfcStairFlightDelegate>().Invoke(NativePtr);
  public void SetIfcWall() => GetDelegate<SetIfcWallDelegate>().Invoke(NativePtr);
  public void SetIfcWallStandardCase() => GetDelegate<SetIfcWallStandardCaseDelegate>().Invoke(NativePtr);
  public void SetIfcWindow() => GetDelegate<SetIfcWindowDelegate>().Invoke(NativePtr);
  public bool IsIfcBuildingElementProxy() => GetDelegate<IsIfcBuildingElementProxyDelegate>().Invoke(NativePtr);
  public bool IsIfcChimney() => GetDelegate<IsIfcChimneyDelegate>().Invoke(NativePtr);
  public bool IsIfcCovering() => GetDelegate<IsIfcCoveringDelegate>().Invoke(NativePtr);
  public bool IsIfcFooting() => GetDelegate<IsIfcFootingDelegate>().Invoke(NativePtr);
  public bool IsIfcFurnishingElement() => GetDelegate<IsIfcFurnishingElementDelegate>().Invoke(NativePtr);
  public bool IsIfcOpeningElement() => GetDelegate<IsIfcOpeningElementDelegate>().Invoke(NativePtr);
  public bool IsIfcSpace() => GetDelegate<IsIfcSpaceDelegate>().Invoke(NativePtr);
  public bool IsIfcFlowSegment() => GetDelegate<IsIfcFlowSegmentDelegate>().Invoke(NativePtr);
  public bool IsIfcBuildingElementPart() => GetDelegate<IsIfcBuildingElementPartDelegate>().Invoke(NativePtr);
  public bool IsIfcDiscreteAccessory() => GetDelegate<IsIfcDiscreteAccessoryDelegate>().Invoke(NativePtr);
  public bool IsIfcFastener() => GetDelegate<IsIfcFastenerDelegate>().Invoke(NativePtr);
  public bool IsIfcMechanicalFastener() => GetDelegate<IsIfcMechanicalFastenerDelegate>().Invoke(NativePtr);
  public void SetIfcBuildingElementProxy() => GetDelegate<SetIfcBuildingElementProxyDelegate>().Invoke(NativePtr);
  public void SetIfcChimney() => GetDelegate<SetIfcChimneyDelegate>().Invoke(NativePtr);
  public void SetIfcCovering() => GetDelegate<SetIfcCoveringDelegate>().Invoke(NativePtr);
  public void SetIfcFooting() => GetDelegate<SetIfcFootingDelegate>().Invoke(NativePtr);
  public void SetIfcFurnishingElement() => GetDelegate<SetIfcFurnishingElementDelegate>().Invoke(NativePtr);
  public void SetIfcOpeningElement() => GetDelegate<SetIfcOpeningElementDelegate>().Invoke(NativePtr);
  public void SetIfcSpace() => GetDelegate<SetIfcSpaceDelegate>().Invoke(NativePtr);
  public void SetIfcFlowSegment() => GetDelegate<SetIfcFlowSegmentDelegate>().Invoke(NativePtr);
  public void SetIfcBuildingElementPart() => GetDelegate<SetIfcBuildingElementPartDelegate>().Invoke(NativePtr);
  public void SetIfcDiscreteAccessory() => GetDelegate<SetIfcDiscreteAccessoryDelegate>().Invoke(NativePtr);
  public void SetIfcFastener() => GetDelegate<SetIfcFastenerDelegate>().Invoke(NativePtr);
  public void SetIfcMechanicalFastener() => GetDelegate<SetIfcMechanicalFastenerDelegate>().Invoke(NativePtr);
  public bool IsIfcElementAssembly() => GetDelegate<IsIfcElementAssemblyDelegate>().Invoke(NativePtr);
  public void SetIfcElementAssembly() => GetDelegate<SetIfcElementAssemblyDelegate>().Invoke(NativePtr);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class IfcElementTypeInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr destroyFunctionPtr;
    internal IntPtr isNoneFunctionPtr;
    internal IntPtr isIfcBeamFunctionPtr;
    internal IntPtr isIfcColumnFunctionPtr;
    internal IntPtr isIfcCurtainWallFunctionPtr;
    internal IntPtr isIfcDoorFunctionPtr;
    internal IntPtr isIfcMemberFunctionPtr;
    internal IntPtr isIfcPlateFunctionPtr;
    internal IntPtr isIfcRailingFunctionPtr;
    internal IntPtr isIfcRampFunctionPtr;
    internal IntPtr isIfcRampFlightFunctionPtr;
    internal IntPtr isIfcRoofFunctionPtr;
    internal IntPtr isIfcSlabFunctionPtr;
    internal IntPtr isIfcStairFunctionPtr;
    internal IntPtr isIfcStairFlightFunctionPtr;
    internal IntPtr isIfcWallFunctionPtr;
    internal IntPtr isIfcWallStandardCaseFunctionPtr;
    internal IntPtr isIfcWindowFunctionPtr;
    internal IntPtr setNoneFunctionPtr;
    internal IntPtr setIfcBeamFunctionPtr;
    internal IntPtr setIfcColumnFunctionPtr;
    internal IntPtr setIfcCurtainWallFunctionPtr;
    internal IntPtr setIfcDoorFunctionPtr;
    internal IntPtr setIfcMemberFunctionPtr;
    internal IntPtr setIfcPlateFunctionPtr;
    internal IntPtr setIfcRailingFunctionPtr;
    internal IntPtr setIfcRampFunctionPtr;
    internal IntPtr setIfcRampFlightFunctionPtr;
    internal IntPtr setIfcRoofFunctionPtr;
    internal IntPtr setIfcSlabFunctionPtr;
    internal IntPtr setIfcStairFunctionPtr;
    internal IntPtr setIfcStairFlightFunctionPtr;
    internal IntPtr setIfcWallFunctionPtr;
    internal IntPtr setIfcWallStandardCaseFunctionPtr;
    internal IntPtr setIfcWindowFunctionPtr;
    internal IntPtr isIfcBuildingElementProxyFunctionPtr;
    internal IntPtr isIfcChimneyFunctionPtr;
    internal IntPtr isIfcCoveringFunctionPtr;
    internal IntPtr isIfcFootingFunctionPtr;
    internal IntPtr isIfcFurnishingElementFunctionPtr;
    internal IntPtr isIfcOpeningElementFunctionPtr;
    internal IntPtr isIfcSpaceFunctionPtr;
    internal IntPtr isIfcFlowSegmentFunctionPtr;
    internal IntPtr isIfcBuildingElementPartFunctionPtr;
    internal IntPtr isIfcDiscreteAccessoryFunctionPtr;
    internal IntPtr isIfcFastenerFunctionPtr;
    internal IntPtr isIfcMechanicalFastenerFunctionPtr;
    internal IntPtr setIfcBuildingElementProxyFunctionPtr;
    internal IntPtr setIfcChimneyFunctionPtr;
    internal IntPtr setIfcCoveringFunctionPtr;
    internal IntPtr setIfcFootingFunctionPtr;
    internal IntPtr setIfcFurnishingElementFunctionPtr;
    internal IntPtr setIfcOpeningElementFunctionPtr;
    internal IntPtr setIfcSpaceFunctionPtr;
    internal IntPtr setIfcFlowSegmentFunctionPtr;
    internal IntPtr setIfcBuildingElementPartFunctionPtr;
    internal IntPtr setIfcDiscreteAccessoryFunctionPtr;
    internal IntPtr setIfcFastenerFunctionPtr;
    internal IntPtr setIfcMechanicalFastenerFunctionPtr;
    internal IntPtr isIfcElementAssemblyFunctionPtr;
    internal IntPtr setIfcElementAssemblyFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void DestroyDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsNoneDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsIfcBeamDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsIfcColumnDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsIfcCurtainWallDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsIfcDoorDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsIfcMemberDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsIfcPlateDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsIfcRailingDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsIfcRampDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsIfcRampFlightDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsIfcRoofDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsIfcSlabDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsIfcStairDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsIfcStairFlightDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsIfcWallDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsIfcWallStandardCaseDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsIfcWindowDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetNoneDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIfcBeamDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIfcColumnDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIfcCurtainWallDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIfcDoorDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIfcMemberDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIfcPlateDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIfcRailingDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIfcRampDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIfcRampFlightDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIfcRoofDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIfcSlabDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIfcStairDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIfcStairFlightDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIfcWallDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIfcWallStandardCaseDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIfcWindowDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsIfcBuildingElementProxyDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsIfcChimneyDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsIfcCoveringDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsIfcFootingDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsIfcFurnishingElementDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsIfcOpeningElementDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsIfcSpaceDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsIfcFlowSegmentDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsIfcBuildingElementPartDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsIfcDiscreteAccessoryDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsIfcFastenerDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsIfcMechanicalFastenerDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIfcBuildingElementProxyDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIfcChimneyDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIfcCoveringDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIfcFootingDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIfcFurnishingElementDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIfcOpeningElementDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIfcSpaceDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIfcFlowSegmentDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIfcBuildingElementPartDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIfcDiscreteAccessoryDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIfcFastenerDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIfcMechanicalFastenerDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool IsIfcElementAssemblyDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetIfcElementAssemblyDelegate(IntPtr thisPtr);
}
