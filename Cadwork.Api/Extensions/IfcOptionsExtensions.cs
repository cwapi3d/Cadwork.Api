// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Implementations.Helpers;
using Cadwork.Api.Interfaces.Helpers;
using Cadwork.Api.Interop.Wrappers.Factories;
using Cadwork.Api.Interop.Wrappers.Helpers;

namespace Cadwork.Api.Extensions;

internal static class IfcOptionsExtensions
{
  internal static IntPtr ToNativeIfcOptions(this IIfcOptions data, ControllerFactoryWrapper factory)
  {
    var wrapper = new IfcOptionsWrapper(factory.CreateIfcOptions());

    var innerWrapperA = new IfcOptionsProjectDataWrapper(wrapper.GetCwApi3DIfcOptionsProjectData());
    var innerWrapperB = new IfcOptionsPropertiesWrapper(wrapper.GetCwApi3DIfcOptionsProperties());
    var innerWrapperC = new IfcOptionsLevelOfDetailWrapper(wrapper.GetCwApi3DIfcOptionsLevelOfDetail());
    var innerWrapperD = new IfcOptionsAggregationWrapper(wrapper.GetCwApi3DIfcOptionsAggregation());

    innerWrapperA.SetExportProjectNameAsIfcProject(data.ProjectData.HasFlag(IfcOptionsProjectData.ExportProjectNameAsIfcProject));
    innerWrapperA.SetExportAddressInIfcSite(data.ProjectData.HasFlag(IfcOptionsProjectData.ExportAddressInIfcSite));
    innerWrapperA.SetExportCoordinatesInIfcSite(data.ProjectData.HasFlag(IfcOptionsProjectData.ExportCoordinatesInIfcSite));
    innerWrapperA.SetExportTrueNorthInGeometricContext(data.ProjectData.HasFlag(IfcOptionsProjectData.ExportTrueNorthInGeometricContext));
    innerWrapperA.SetExportTrueNorthInObjectPlacement(data.ProjectData.HasFlag(IfcOptionsProjectData.ExportTrueNorthInObjectPlacement));

    // innerWrapperB.SetCadworkAttributeForIfcLayer();

    // innerWrapperB.SetCadworkAttributeForIfcTag();

    innerWrapperB.SetExportEmptyBuildingAndStoreys(data.Properties.HasFlag(IfcOptionsProperties.ExportEmptyBuildingAndStoreys));
    innerWrapperB.SetExportCadwork3dPSet(data.Properties.HasFlag(IfcOptionsProperties.ExportCadworkPSet));
    innerWrapperB.SetIgnoreUserAttributesUsedInUserPSets(data.Properties.HasFlag(IfcOptionsProperties.IgnoreUserAttributesUsedInUserPSets));
    innerWrapperB.SetExportBimWoodProperty(data.Properties.HasFlag(IfcOptionsProperties.ExportBimWoodProperty));
    innerWrapperC.SetExportEndTypeMaterialization(data.LevelOfDetail.HasFlag(IfcOptionsLevelOfDetail.ExportEndTypes));
    innerWrapperC.SetCutEndTypeCounterparts(data.LevelOfDetail.HasFlag(IfcOptionsLevelOfDetail.CutEndTypeCounterparts));
    innerWrapperC.SetExportConnectorAxesDrillingAxes(data.LevelOfDetail.HasFlag(IfcOptionsLevelOfDetail.CutConnectorAxesDrillingAxes));
    innerWrapperC.SetExportConnectorAxesComponents(data.LevelOfDetail.HasFlag(IfcOptionsLevelOfDetail.ExportConnectorAxesComponents));
    innerWrapperC.SetCutDrillingAxes(data.LevelOfDetail.HasFlag(IfcOptionsLevelOfDetail.CutDrillingAxes));
    innerWrapperC.SetExportInstallationRoundMaterialization(data.LevelOfDetail.HasFlag(IfcOptionsLevelOfDetail.ExportRoundMepElements));
    innerWrapperC.SetExportInstallationRectangularMaterialization(data.LevelOfDetail.HasFlag(IfcOptionsLevelOfDetail.ExportRectangularMepElements));
    innerWrapperC.SetCutInstallationRound(data.LevelOfDetail.HasFlag(IfcOptionsLevelOfDetail.CutRoundMepElements));
    innerWrapperC.SetCutInstallationRectangular(data.LevelOfDetail.HasFlag(IfcOptionsLevelOfDetail.CutRectangularMepElements));
    innerWrapperC.SetExportSweptSolidForSimpleGeometry(data.LevelOfDetail.HasFlag(IfcOptionsLevelOfDetail.ExportSweptSolidForSimpleGeometry));
    innerWrapperD.SetConsiderElementModuleAggregation(data.Aggregation.HasFlag(IfcOptionsAggregation.ConsiderElementModuleAggregation));

    if (data.Aggregation.HasFlag(IfcOptionsAggregation.AggregationByGroup))
    {
      innerWrapperD.SetElementModuleAggregationAttribute(IfcOptionsAggregationWrapper.ElementGroupingType.Group);
    }

    if (data.Aggregation.HasFlag(IfcOptionsAggregation.AggregationBySubgroup))
    {
      innerWrapperD.SetElementModuleAggregationAttribute(IfcOptionsAggregationWrapper.ElementGroupingType.Subgroup);
    }

    if (data.Aggregation.HasFlag(IfcOptionsAggregation.CombineWithAssembly))
    {
      innerWrapperD.SetExportElementCombineBehavior(IfcOptionsAggregationWrapper.IfcElementCombineBehaviour.ElementAssembly);
    }

    if (data.Aggregation.HasFlag(IfcOptionsAggregation.CombineWithModule))
    {
      innerWrapperD.SetExportElementCombineBehavior(IfcOptionsAggregationWrapper.IfcElementCombineBehaviour.ElementModule);
    }

    innerWrapperD.SetExportCoverGeometry(data.Aggregation.HasFlag(IfcOptionsAggregation.ExportCoverGeometry));

    return wrapper.NativePtr;
  }

  internal static IIfcOptions ToManagedIfcOptions(this IntPtr data)
  {
    var wrapper = new IfcOptionsWrapper(data);

    var innerWrapperA = new IfcOptionsProjectDataWrapper(wrapper.GetCwApi3DIfcOptionsProjectData());
    var innerWrapperB = new IfcOptionsPropertiesWrapper(wrapper.GetCwApi3DIfcOptionsProperties());
    var innerWrapperC = new IfcOptionsLevelOfDetailWrapper(wrapper.GetCwApi3DIfcOptionsLevelOfDetail());
    var innerWrapperD = new IfcOptionsAggregationWrapper(wrapper.GetCwApi3DIfcOptionsAggregation());

    var options = new IfcOptions();

    throw new NotImplementedException();

    // TODO: Implement

    return options;
  }
}
