// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;

namespace Cadwork.Api.Extensions;

internal static class FbxFormatExtensions
{
  internal static uint ToNativeFbxFormat(this FbxFormat data)
  {
    return data switch
    {
      FbxFormat.Fbx6Ascii => 5,
      FbxFormat.Fbx6Binary => 4,
      FbxFormat.Fbx6Encrypted => 6,
      FbxFormat.FbxAscii => 2,
      FbxFormat.FbxBinary => 1,
      FbxFormat.FbxEncrypted => 3,
      _ => throw new ArgumentOutOfRangeException(nameof(data), data, null)
    };
  }
}
