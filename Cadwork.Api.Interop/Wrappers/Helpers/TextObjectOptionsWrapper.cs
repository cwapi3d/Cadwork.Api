// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Helpers;

public class TextObjectOptionsWrapper
{
  public readonly IntPtr NativePtr;

  private readonly Dictionary<Type, Delegate> _functionDelegates;

  public TextObjectOptionsWrapper(IntPtr nativePtr)
  {
    NativePtr = nativePtr;
    var vTable = Marshal.PtrToStructure<TextObjectOptionsInterfaceVTable>(Marshal.ReadIntPtr(nativePtr));

    _functionDelegates = new Dictionary<Type, Delegate>
    {
      { typeof(SetFontNameDelegate), Marshal.GetDelegateForFunctionPointer<SetFontNameDelegate>(vTable!.setFontNameFunctionPtr) },
      { typeof(GetFontNameDelegate), Marshal.GetDelegateForFunctionPointer<GetFontNameDelegate>(vTable.getFontNameFunctionPtr) },
      { typeof(SetTextDelegate), Marshal.GetDelegateForFunctionPointer<SetTextDelegate>(vTable.setTextFunctionPtr) },
      { typeof(GetTextDelegate), Marshal.GetDelegateForFunctionPointer<GetTextDelegate>(vTable.getTextFunctionPtr) },
      { typeof(SetBoldDelegate), Marshal.GetDelegateForFunctionPointer<SetBoldDelegate>(vTable.setBoldFunctionPtr) },
      { typeof(GetBoldDelegate), Marshal.GetDelegateForFunctionPointer<GetBoldDelegate>(vTable.getBoldFunctionPtr) },
      { typeof(SetItalicDelegate), Marshal.GetDelegateForFunctionPointer<SetItalicDelegate>(vTable.setItalicFunctionPtr) },
      { typeof(GetItalicDelegate), Marshal.GetDelegateForFunctionPointer<GetItalicDelegate>(vTable.getItalicFunctionPtr) },
      { typeof(SetHeightDelegate), Marshal.GetDelegateForFunctionPointer<SetHeightDelegate>(vTable.setHeightFunctionPtr) },
      { typeof(GetHeightDelegate), Marshal.GetDelegateForFunctionPointer<GetHeightDelegate>(vTable.getHeightFunctionPtr) },
      { typeof(SetElementTypeDelegate), Marshal.GetDelegateForFunctionPointer<SetElementTypeDelegate>(vTable.setElementTypeFunctionPtr) },
      { typeof(GetElementTypeDelegate), Marshal.GetDelegateForFunctionPointer<GetElementTypeDelegate>(vTable.getElementTypeFunctionPtr) },
      { typeof(SetThicknessDelegate), Marshal.GetDelegateForFunctionPointer<SetThicknessDelegate>(vTable.setThicknessFunctionPtr) },
      { typeof(GetThicknessDelegate), Marshal.GetDelegateForFunctionPointer<GetThicknessDelegate>(vTable.getThicknessFunctionPtr) },
      { typeof(SetColorDelegate), Marshal.GetDelegateForFunctionPointer<SetColorDelegate>(vTable.setColorFunctionPtr) },
      { typeof(GetColorDelegate), Marshal.GetDelegateForFunctionPointer<GetColorDelegate>(vTable.getColorFunctionPtr) },
      { typeof(SetHeightRelativeDelegate), Marshal.GetDelegateForFunctionPointer<SetHeightRelativeDelegate>(vTable.setHeightRelativeFunctionPtr) },
      { typeof(GetHeightRelativeDelegate), Marshal.GetDelegateForFunctionPointer<GetHeightRelativeDelegate>(vTable.getHeightRelativeFunctionPtr) },
    };
  }

  private TDelegate GetDelegate<TDelegate>() where TDelegate : Delegate
  {
    return (TDelegate)_functionDelegates[typeof(TDelegate)];
  }

  public enum TextElementType
  {
    Line = 0,
    Surface = 1,
    Volume = 2,
    Raster = 3,
  };

  public void SetFontName(string aFontName) => GetDelegate<SetFontNameDelegate>().Invoke(NativePtr, aFontName);
  public string GetFontName() => GetDelegate<GetFontNameDelegate>().Invoke(NativePtr);
  public void SetText(string aText) => GetDelegate<SetTextDelegate>().Invoke(NativePtr, aText);
  public string GetText() => GetDelegate<GetTextDelegate>().Invoke(NativePtr);
  public void SetBold(bool aValue) => GetDelegate<SetBoldDelegate>().Invoke(NativePtr, aValue);
  public bool GetBold() => GetDelegate<GetBoldDelegate>().Invoke(NativePtr);
  public void SetItalic(bool aValue) => GetDelegate<SetItalicDelegate>().Invoke(NativePtr, aValue);
  public bool GetItalic() => GetDelegate<GetItalicDelegate>().Invoke(NativePtr);
  public void SetHeight(double aHeight) => GetDelegate<SetHeightDelegate>().Invoke(NativePtr, aHeight);
  public double GetHeight() => GetDelegate<GetHeightDelegate>().Invoke(NativePtr);
  public void SetElementType(TextElementType aElementType) => GetDelegate<SetElementTypeDelegate>().Invoke(NativePtr, aElementType);
  public TextElementType GetElementType() => GetDelegate<GetElementTypeDelegate>().Invoke(NativePtr);
  public void SetThickness(double aThickness) => GetDelegate<SetThicknessDelegate>().Invoke(NativePtr, aThickness);
  public double GetThickness() => GetDelegate<GetThicknessDelegate>().Invoke(NativePtr);
  public void SetColor(int aColorNr) => GetDelegate<SetColorDelegate>().Invoke(NativePtr, aColorNr);
  public int GetColor() => GetDelegate<GetColorDelegate>().Invoke(NativePtr);
  public void SetHeightRelative(bool aValue) => GetDelegate<SetHeightRelativeDelegate>().Invoke(NativePtr, aValue);
  public bool GetHeightRelative() => GetDelegate<GetHeightRelativeDelegate>().Invoke(NativePtr);

  [StructLayout(LayoutKind.Sequential)]
  private sealed class TextObjectOptionsInterfaceVTable
  {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    internal IntPtr setFontNameFunctionPtr;
    internal IntPtr getFontNameFunctionPtr;
    internal IntPtr setTextFunctionPtr;
    internal IntPtr getTextFunctionPtr;
    internal IntPtr setBoldFunctionPtr;
    internal IntPtr getBoldFunctionPtr;
    internal IntPtr setItalicFunctionPtr;
    internal IntPtr getItalicFunctionPtr;
    internal IntPtr setHeightFunctionPtr;
    internal IntPtr getHeightFunctionPtr;
    internal IntPtr setElementTypeFunctionPtr;
    internal IntPtr getElementTypeFunctionPtr;
    internal IntPtr setThicknessFunctionPtr;
    internal IntPtr getThicknessFunctionPtr;
    internal IntPtr setColorFunctionPtr;
    internal IntPtr getColorFunctionPtr;
    internal IntPtr setHeightRelativeFunctionPtr;
    internal IntPtr getHeightRelativeFunctionPtr;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
  }

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetFontNameDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aFontName);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate string GetFontNameDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetTextDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)] string aText);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate string GetTextDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetBoldDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetBoldDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetItalicDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetItalicDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetHeightDelegate(IntPtr thisPtr, double aHeight);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetHeightDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetElementTypeDelegate(IntPtr thisPtr, TextElementType aElementType);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate TextElementType GetElementTypeDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetThicknessDelegate(IntPtr thisPtr, double aThickness);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate double GetThicknessDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetColorDelegate(IntPtr thisPtr, int aColorNr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate int GetColorDelegate(IntPtr thisPtr);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate void SetHeightRelativeDelegate(IntPtr thisPtr, bool aValue);

  [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
  private delegate bool GetHeightRelativeDelegate(IntPtr thisPtr);
}
