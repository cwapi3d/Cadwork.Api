// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Interop.Wrappers.Factories;
using Cadwork.Api.Interop.Wrappers.Helpers;

namespace Cadwork.Api.Extensions;

internal static class ImportOptionsExtensions
{
  internal static IntPtr ToNativeImportOptions(this ImportOptions data, ControllerFactoryWrapper factory)
  {
    var wrapper = new ImportOptionsWrapper(factory.CreateImport3dcOptions());

    wrapper.SetImportSaved2dPlanes(data.HasFlag(ImportOptions.ImportSaved2dPlanes));
    wrapper.SetImportSavedScenes(data.HasFlag(ImportOptions.ImportSavedScenes));
    wrapper.SetImportExportSolids(data.HasFlag(ImportOptions.ImportExportSolids));
    wrapper.SetResetPositionNumbers(data.HasFlag(ImportOptions.ResetPositionNumbers));

    return wrapper.NativePtr;
  }
}
