// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;

namespace Cadwork.Api.Extensions;

internal static class ImageFormatExtensions
{
  internal static string ToNativeImageFormat(this ImageFormat data)
  {
    return data switch
    {
      ImageFormat.Bmp => ".bmp",
      ImageFormat.Jpg => ".jpg",
      ImageFormat.Jpeg => ".jpeg",
      ImageFormat.Png => ".png",
      _ => throw new ArgumentOutOfRangeException(nameof(data), data, null)
    };
  }
}
