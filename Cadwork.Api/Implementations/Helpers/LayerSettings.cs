// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Interfaces.Helpers;

namespace Cadwork.Api.Implementations.Helpers;

public class LayerSettings : ILayerSettings
{
  public Enums.LayerSettings Settings { get; set; }
  public int LayerNumber { get; set; }
}
