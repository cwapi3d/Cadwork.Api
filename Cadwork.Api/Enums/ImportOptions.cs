// Copyright (C) Cadwork. All rights reserved.

namespace Cadwork.Api.Enums;

/// <summary>
///
/// </summary>
[Flags]
public enum ImportOptions
{
  None,
  ImportSaved2dPlanes,
  ImportSavedScenes,
  ImportExportSolids,
  ResetPositionNumbers,
}
