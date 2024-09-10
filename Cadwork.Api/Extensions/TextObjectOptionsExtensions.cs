// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Interop.Wrappers.Factories;
using Cadwork.Api.Interop.Wrappers.Helpers;

namespace Cadwork.Api.Extensions;

internal static class TextObjectOptionsExtensions
{
  internal static IntPtr ToNativeTextObjectOptions(this ITextObjectOptions data, ControllerFactoryWrapper factory)
  {
    var wrapper = new TextObjectOptionsWrapper(factory.CreateTextObjectOptions());

    wrapper.SetFontName(data.FontName);
    wrapper.SetText(data.Text);
    wrapper.SetBold(data.Bold);
    wrapper.SetItalic(data.Italic);
    wrapper.SetHeight(data.Height);

    switch (data.ElementType)
    {
      case TextElementType.Line:
        wrapper.SetElementType(TextObjectOptionsWrapper.TextElementType.Line);
        break;
      case TextElementType.Raster:
        wrapper.SetElementType(TextObjectOptionsWrapper.TextElementType.Raster);
        break;
      case TextElementType.Surface:
        wrapper.SetElementType(TextObjectOptionsWrapper.TextElementType.Surface);
        break;
      case TextElementType.Volume:
        wrapper.SetElementType(TextObjectOptionsWrapper.TextElementType.Volume);
        break;
      default:
        throw new ArgumentOutOfRangeException();
    }

    wrapper.SetThickness(data.Thickness);
    wrapper.SetColor(data.Color);
    wrapper.SetHeightRelative(data.HeightIsRelative);

    return wrapper.NativePtr;
  }
}
