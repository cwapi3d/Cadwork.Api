// Copyright (C) Cadwork. All rights reserved.

using System.Runtime.InteropServices;

namespace Cadwork.Api.Interop.Wrappers.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct CBimTeamUploadResult
{
  public enum CBimTeamUploadResultCode
  {
    Ok,
    ErrorGeneralError,
    ErrorTooManyModels,
    ErrorInsufficientStorage,
    ErrorInvalidProjectId,
    ErrorAuthenticationFailed,
  };

  public CBimTeamUploadResultCode mUploadResultCode;
  public string mShareLink;
}
