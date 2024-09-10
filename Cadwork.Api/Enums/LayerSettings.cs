// Copyright (C) Cadwork. All rights reserved.

namespace Cadwork.Api.Enums;

/// <summary>
///
/// </summary>
[Flags]
public enum LayerSettings
{
  None,
  WithoutOutput,
  WithDimensionsOutput,
  WithoutDimensionsOutput,
  WithAttributesOutput,
}
