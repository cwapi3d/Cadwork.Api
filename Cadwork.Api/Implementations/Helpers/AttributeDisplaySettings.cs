// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Interfaces.Helpers;

namespace Cadwork.Api.Implementations.Helpers;

public class AttributeDisplaySettings : IAttributeDisplaySettings
{
  public AttributeDisplayTextPositionType Type { get; set; }
  public uint Value { get; set; }
}
