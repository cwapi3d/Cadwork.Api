// Copyright (C) Cadwork. All rights reserved.

namespace Cadwork.Api.Enums;

/// <summary>
///
/// </summary>
[Flags]
public enum ExtendedSettings
{
  None,
  PieceByPieceExportWithDimensions,
  PieceByPieceExportWithoutDimensions,
  WallExport,
  GroupExport,
  ChiefElement,
  MfbExport,
  LogHomeExport,
  BtlWallExport,
  LogMacroExport,
  Outline,
  IgnoreForConnectorAxis,
}
