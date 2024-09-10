// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Interfaces.Helpers;

namespace Cadwork.Api.Implementations.Helpers;

public class Error : IError
{
  public int Code { get; set; }
  public string Message { get; set; } = "";
}
