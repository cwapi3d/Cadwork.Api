// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Interfaces.Helpers;

namespace Cadwork.Api.Implementations.Helpers;

public class TextObjectOptions : ITextObjectOptions
{
  public TextElementType ElementType { get; set; }
  public bool Bold { get; set; }
  public bool HeightIsRelative { get; set; }
  public bool Italic { get; set; }
  public double Height { get; set; }
  public double Thickness { get; set; }
  public int Color { get; set; }
  public string FontName { get; set; } = "";
  public string Text { get; set; } = "";
}
