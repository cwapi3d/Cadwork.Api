// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Enums;
using Cadwork.Api.Interop.Wrappers.Factories;
using Cadwork.Api.Interop.Wrappers.Helpers;

namespace Cadwork.Api.Extensions;

internal static class IfcPredefinedTypeExtensions
{
  internal static IntPtr ToNativeIfcPredefinedType(this IfcPredefinedType data, ControllerFactoryWrapper factory)
  {
    var wrapper = new IfcPredefinedTypeWrapper(factory.CreateEmptyIfcPredefinedType());

    switch (data)
    {
      case IfcPredefinedType.None:
        wrapper.SetNone();
        break;
      case IfcPredefinedType.Ceiling:
        wrapper.SetCeiling();
        break;
      case IfcPredefinedType.Cladding:
        wrapper.SetCladding();
        break;
      case IfcPredefinedType.Flooring:
        wrapper.SetFlooring();
        break;
      case IfcPredefinedType.Insulation:
        wrapper.SetInsulation();
        break;
      case IfcPredefinedType.Membrane:
        wrapper.SetMembrane();
        break;
      case IfcPredefinedType.Roofing:
        wrapper.SetRoofing();
        break;
      case IfcPredefinedType.Sleeving:
        wrapper.SetSleeving();
        break;
      case IfcPredefinedType.Wrapping:
        wrapper.SetWrapping();
        break;
      case IfcPredefinedType.FootingBeam:
        wrapper.SetFootingBeam();
        break;
      case IfcPredefinedType.PadFooting:
        wrapper.SetPadFooting();
        break;
      case IfcPredefinedType.PileCap:
        wrapper.SetPileCap();
        break;
      case IfcPredefinedType.StripFooting:
        wrapper.SetStripFooting();
        break;
      case IfcPredefinedType.Cohesion:
        wrapper.SetCohesion();
        break;
      case IfcPredefinedType.Friction:
        wrapper.SetFriction();
        break;
      case IfcPredefinedType.Support:
        wrapper.SetSupport();
        break;
      case IfcPredefinedType.Balustrade:
        wrapper.SetBalustrade();
        break;
      case IfcPredefinedType.Guardrail:
        wrapper.SetGuardrail();
        break;
      case IfcPredefinedType.Handrail:
        wrapper.SetHandrail();
        break;
      case IfcPredefinedType.Baseslab:
        wrapper.SetBaseslab();
        break;
      case IfcPredefinedType.Floor:
        wrapper.SetFloor();
        break;
      case IfcPredefinedType.Landing:
        wrapper.SetLanding();
        break;
      case IfcPredefinedType.Roof:
        wrapper.SetRoof();
        break;
      case IfcPredefinedType.Beam:
        wrapper.SetBeam();
        break;
      case IfcPredefinedType.Hollowcore:
        wrapper.SetHollowcore();
        break;
      case IfcPredefinedType.Joist:
        wrapper.SetJoist();
        break;
      case IfcPredefinedType.Lintel:
        wrapper.SetLintel();
        break;
      case IfcPredefinedType.Spandrel:
        wrapper.SetSpandrel();
        break;
      case IfcPredefinedType.Tbeam:
        wrapper.SetTbeam();
        break;
      case IfcPredefinedType.Complex:
        wrapper.SetComplex();
        break;
      case IfcPredefinedType.Element:
        wrapper.SetElement();
        break;
      case IfcPredefinedType.Partial:
        wrapper.SetPartial();
        break;
      case IfcPredefinedType.ProvisionForSpace:
        wrapper.SetProvisionForSpace();
        break;
      case IfcPredefinedType.ProvisionForVoid:
        throw new ArgumentException();
      case IfcPredefinedType.Column:
        wrapper.SetColumn();
        break;
      case IfcPredefinedType.Pilaster:
        wrapper.SetPilaster();
        break;
      case IfcPredefinedType.Molding:
        wrapper.SetMolding();
        break;
      case IfcPredefinedType.Skirtingboard:
        wrapper.SetSkirtingboard();
        break;
      case IfcPredefinedType.Door:
        wrapper.SetDoor();
        break;
      case IfcPredefinedType.Gate:
        wrapper.SetGate();
        break;
      case IfcPredefinedType.TrapDoor:
        wrapper.SetTrapDoor();
        break;
      case IfcPredefinedType.CaissonFoundation:
        wrapper.SetCaissonFoundation();
        break;
      case IfcPredefinedType.Brace:
        wrapper.SetBrace();
        break;
      case IfcPredefinedType.Chord:
        wrapper.SetChord();
        break;
      case IfcPredefinedType.Collar:
        wrapper.SetCollar();
        break;
      case IfcPredefinedType.Member:
        wrapper.SetMember();
        break;
      case IfcPredefinedType.Mullion:
        wrapper.SetMullion();
        break;
      case IfcPredefinedType.Plate:
        wrapper.SetPlate();
        break;
      case IfcPredefinedType.Post:
        wrapper.SetPost();
        break;
      case IfcPredefinedType.Purlin:
        wrapper.SetPurlin();
        break;
      case IfcPredefinedType.Rafter:
        wrapper.SetRafter();
        break;
      case IfcPredefinedType.Stringer:
        wrapper.SetStringer();
        break;
      case IfcPredefinedType.Strut:
        wrapper.SetStrut();
        break;
      case IfcPredefinedType.Stud:
        wrapper.SetStud();
        break;
      case IfcPredefinedType.Bored:
        wrapper.SetBored();
        break;
      case IfcPredefinedType.Driven:
        wrapper.SetDriven();
        break;
      case IfcPredefinedType.Jetgrouting:
        wrapper.SetJetgrouting();
        break;
      case IfcPredefinedType.CurtainPanel:
        throw new ArgumentException();
      case IfcPredefinedType.Sheet:
        wrapper.SetSheet();
        break;
      case IfcPredefinedType.HalfTurnRamp:
        wrapper.SetHalfTurnRamp();
        break;
      case IfcPredefinedType.QuarterTurnRamp:
        wrapper.SetQuarterTurnRamp();
        break;
      case IfcPredefinedType.SpiralRamp:
        wrapper.SetSpiralRamp();
        break;
      case IfcPredefinedType.StraightRunRamp:
        wrapper.SetStraightRunRamp();
        break;
      case IfcPredefinedType.TwoQuarterTurnRamp:
        wrapper.SetTwoQuarterTurnRamp();
        break;
      case IfcPredefinedType.TwoStraightRunRamp:
        wrapper.SetTwoStraightRunRamp();
        break;
      case IfcPredefinedType.BarrelRoof:
        wrapper.SetBarrelRoof();
        break;
      case IfcPredefinedType.ButterflyRoof:
        wrapper.SetButterflyRoof();
        break;
      case IfcPredefinedType.DomeRoof:
        wrapper.SetDomeRoof();
        break;
      case IfcPredefinedType.FlatRoof:
        wrapper.SetFlatRoof();
        break;
      case IfcPredefinedType.Freeform:
        wrapper.SetFreeform();
        break;
      case IfcPredefinedType.GableRoof:
        wrapper.SetGableRoof();
        break;
      case IfcPredefinedType.GambrelRoof:
        wrapper.SetGambrelRoof();
        break;
      case IfcPredefinedType.HippedGableRoof:
        wrapper.SetHippedGableRoof();
        break;
      case IfcPredefinedType.HipRoof:
        wrapper.SetHipRoof();
        break;
      case IfcPredefinedType.MansardRoof:
        wrapper.SetMansardRoof();
        break;
      case IfcPredefinedType.PavilionRoof:
        wrapper.SetPavilionRoof();
        break;
      case IfcPredefinedType.RainbowRoof:
        wrapper.SetRainbowRoof();
        break;
      case IfcPredefinedType.ShedRoof:
        wrapper.SetShedRoof();
        break;
      case IfcPredefinedType.CurvedRunStair:
        wrapper.SetCurvedRunStair();
        break;
      case IfcPredefinedType.DoubleReturnStair:
        wrapper.SetDoubleReturnStair();
        break;
      case IfcPredefinedType.HalfTurnStair:
        wrapper.SetHalfTurnStair();
        break;
      case IfcPredefinedType.HalfWindingStair:
        wrapper.SetHalfWindingStair();
        break;
      case IfcPredefinedType.QuarterTurnStair:
        wrapper.SetQuarterTurnStair();
        break;
      case IfcPredefinedType.QuarterWindingStair:
        wrapper.SetQuarterWindingStair();
        break;
      case IfcPredefinedType.SpiralStair:
        wrapper.SetSpiralStair();
        break;
      case IfcPredefinedType.StraightRunStair:
        wrapper.SetStraightRunStair();
        break;
      case IfcPredefinedType.ThreeQuarterTurnStair:
        throw new ArgumentException();
      case IfcPredefinedType.ThreeQuarterWindingStair:
        throw new ArgumentException();
      case IfcPredefinedType.TwoCurvedRunStair:
        wrapper.SetTwoCurvedRunStair();
        break;
      case IfcPredefinedType.TwoQuarterTurnStair:
        wrapper.SetTwoQuarterTurnStair();
        break;
      case IfcPredefinedType.TwoQuarterWindingStair:
        wrapper.SetTwoQuarterWindingStair();
        break;
      case IfcPredefinedType.TwoStraightRunStair:
        wrapper.SetTwoStraightRunStair();
        break;
      case IfcPredefinedType.Curved:
        wrapper.SetCurved();
        break;
      case IfcPredefinedType.Spiral:
        wrapper.SetSpiral();
        break;
      case IfcPredefinedType.Straight:
        wrapper.SetStraight();
        break;
      case IfcPredefinedType.Winder:
        wrapper.SetWinder();
        break;
      case IfcPredefinedType.ElementedWall:
        wrapper.SetElementedWall();
        break;
      case IfcPredefinedType.Movable:
        wrapper.SetMovable();
        break;
      case IfcPredefinedType.Parapet:
        wrapper.SetParapet();
        break;
      case IfcPredefinedType.Partitioning:
        wrapper.SetPartitioning();
        break;
      case IfcPredefinedType.PlumbingWall:
        wrapper.SetPlumbingWall();
        break;
      case IfcPredefinedType.Polygonal:
        wrapper.SetPolygonal();
        break;
      case IfcPredefinedType.Shear:
        wrapper.SetShear();
        break;
      case IfcPredefinedType.SolidWall:
        wrapper.SetSolidWall();
        break;
      case IfcPredefinedType.Standard:
        wrapper.SetStandard();
        break;
      case IfcPredefinedType.Lightdome:
        wrapper.SetLightdome();
        break;
      case IfcPredefinedType.Skylight:
        wrapper.SetSkylight();
        break;
      case IfcPredefinedType.Window:
        wrapper.SetWindow();
        break;
      case IfcPredefinedType.Opening:
        wrapper.SetOpening();
        break;
      case IfcPredefinedType.Recess:
        wrapper.SetRecess();
        break;
      case IfcPredefinedType.Anchorbolt:
        wrapper.SetAnchorbolt();
        break;
      case IfcPredefinedType.Bolt:
        wrapper.SetBolt();
        break;
      case IfcPredefinedType.Dowel:
        wrapper.SetDowel();
        break;
      case IfcPredefinedType.Nail:
        wrapper.SetNail();
        break;
      case IfcPredefinedType.NailPlate:
        throw new ArgumentException();
      case IfcPredefinedType.Rivet:
        wrapper.SetRivet();
        break;
      case IfcPredefinedType.Screw:
        wrapper.SetScrew();
        break;
      case IfcPredefinedType.ShearConnector:
        throw new ArgumentException();
      case IfcPredefinedType.Staple:
        wrapper.SetStaple();
        break;
      case IfcPredefinedType.StudShearConnector:
        throw new ArgumentException();
      case IfcPredefinedType.Glue:
        wrapper.SetGlue();
        break;
      case IfcPredefinedType.Mortar:
        wrapper.SetMortar();
        break;
      case IfcPredefinedType.Weld:
        wrapper.SetWeld();
        break;
      case IfcPredefinedType.External:
        wrapper.SetExternal();
        break;
      case IfcPredefinedType.Gfa:
        wrapper.SetGfa();
        break;
      case IfcPredefinedType.Internal:
        wrapper.SetInternal();
        break;
      case IfcPredefinedType.Parking:
        wrapper.SetParking();
        break;
      case IfcPredefinedType.Space:
        wrapper.SetSpace();
        break;
      case IfcPredefinedType.AccessoryAssembly:
        wrapper.SetAccessoryAssembly();
        break;
      case IfcPredefinedType.Arch:
        wrapper.SetArch();
        break;
      case IfcPredefinedType.BeamGrid:
        wrapper.SetBeamGrid();
        break;
      case IfcPredefinedType.BracedFrame:
        wrapper.SetBracedFrame();
        break;
      case IfcPredefinedType.Girder:
        wrapper.SetGirder();
        break;
      case IfcPredefinedType.ReinforcementUnit:
        wrapper.SetReinforcementUnit();
        break;
      case IfcPredefinedType.RigidFrame:
        wrapper.SetRigidFrame();
        break;
      case IfcPredefinedType.SlabField:
        wrapper.SetSlabField();
        break;
      case IfcPredefinedType.Truss:
        wrapper.SetTruss();
        break;
      case IfcPredefinedType.CableLadderSegment:
        wrapper.SetCableLadderSegment();
        break;
      case IfcPredefinedType.CableTraySegment:
        wrapper.SetCableTraySegment();
        break;
      case IfcPredefinedType.CableTrunkingSegment:
        wrapper.SetCableTrunkingSegment();
        break;
      case IfcPredefinedType.ConduitSegment:
        wrapper.SetConduitSegment();
        break;
      case IfcPredefinedType.BusbarSegment:
        wrapper.SetBusbarSegment();
        break;
      case IfcPredefinedType.CableSegment:
        wrapper.SetCableSegment();
        break;
      case IfcPredefinedType.ConductorSegment:
        wrapper.SetConductorSegment();
        break;
      case IfcPredefinedType.CoreSegment:
        wrapper.SetCoreSegment();
        break;
      case IfcPredefinedType.FlexibleSegment:
        wrapper.SetFlexibleSegment();
        break;
      case IfcPredefinedType.RigidSegment:
        wrapper.SetRigidSegment();
        break;
      case IfcPredefinedType.Culvert:
        wrapper.SetCulvert();
        break;
      case IfcPredefinedType.Gutter:
        wrapper.SetGutter();
        break;
      case IfcPredefinedType.Spool:
        wrapper.SetSpool();
        break;
      case IfcPredefinedType.AudioVisualOutlet:
        wrapper.SetAudioVisualOutlet();
        break;
      case IfcPredefinedType.CommunicationsOutlet:
        wrapper.SetCommunicationsOutlet();
        break;
      case IfcPredefinedType.PowerOutlet:
        wrapper.SetPowerOutlet();
        break;
      case IfcPredefinedType.DataOutlet:
        wrapper.SetDataOutlet();
        break;
      case IfcPredefinedType.TelephoneOutlet:
        wrapper.SetTelephoneOutlet();
        break;
      case IfcPredefinedType.Anchoring:
        wrapper.SetAnchoring();
        break;
      case IfcPredefinedType.Edge:
        wrapper.SetEdge();
        break;
      case IfcPredefinedType.Ligature:
        wrapper.SetLigature();
        break;
      case IfcPredefinedType.Main:
        wrapper.SetMain();
        break;
      case IfcPredefinedType.Punching:
        wrapper.SetPunching();
        break;
      case IfcPredefinedType.Ring:
        wrapper.SetRing();
        break;
      default:
        throw new ArgumentOutOfRangeException(nameof(data), data, null);
    }

    return wrapper.NativePtr;
  }

  internal static IfcPredefinedType ToManagedIfcPredefinedType(this IntPtr data)
  {
    var wrapper = new IfcPredefinedTypeWrapper(data);

    if (wrapper.IsNone())
    {
      return IfcPredefinedType.None;
    }

    if (wrapper.IsCeiling())
    {
      return IfcPredefinedType.Ceiling;
    }

    if (wrapper.IsCladding())
    {
      return IfcPredefinedType.Cladding;
    }

    if (wrapper.IsFlooring())
    {
      return IfcPredefinedType.Flooring;
    }

    if (wrapper.IsInsulation())
    {
      return IfcPredefinedType.Insulation;
    }

    if (wrapper.IsMembrane())
    {
      return IfcPredefinedType.Membrane;
    }

    if (wrapper.IsRoofing())
    {
      return IfcPredefinedType.Roofing;
    }

    if (wrapper.IsSleeving())
    {
      return IfcPredefinedType.Sleeving;
    }

    if (wrapper.IsWrapping())
    {
      return IfcPredefinedType.Wrapping;
    }

    if (wrapper.IsFootingBeam())
    {
      return IfcPredefinedType.FootingBeam;
    }

    if (wrapper.IsPadFooting())
    {
      return IfcPredefinedType.PadFooting;
    }

    if (wrapper.IsPileCap())
    {
      return IfcPredefinedType.PileCap;
    }

    if (wrapper.IsStripFooting())
    {
      return IfcPredefinedType.StripFooting;
    }

    if (wrapper.IsCohesion())
    {
      return IfcPredefinedType.Cohesion;
    }

    if (wrapper.IsFriction())
    {
      return IfcPredefinedType.Friction;
    }

    if (wrapper.IsSupport())
    {
      return IfcPredefinedType.Support;
    }

    if (wrapper.IsBalustrade())
    {
      return IfcPredefinedType.Balustrade;
    }

    if (wrapper.IsGuardrail())
    {
      return IfcPredefinedType.Guardrail;
    }

    if (wrapper.IsHandrail())
    {
      return IfcPredefinedType.Handrail;
    }

    if (wrapper.IsBaseslab())
    {
      return IfcPredefinedType.Baseslab;
    }

    if (wrapper.IsFloor())
    {
      return IfcPredefinedType.Floor;
    }

    if (wrapper.IsLanding())
    {
      return IfcPredefinedType.Landing;
    }

    if (wrapper.IsRoof())
    {
      return IfcPredefinedType.Roof;
    }

    if (wrapper.IsBeam())
    {
      return IfcPredefinedType.Beam;
    }

    if (wrapper.IsHollowcore())
    {
      return IfcPredefinedType.Hollowcore;
    }

    if (wrapper.IsJoist())
    {
      return IfcPredefinedType.Joist;
    }

    if (wrapper.IsLintel())
    {
      return IfcPredefinedType.Lintel;
    }

    if (wrapper.IsSpandrel())
    {
      return IfcPredefinedType.Spandrel;
    }

    if (wrapper.IsTbeam())
    {
      return IfcPredefinedType.Tbeam;
    }

    if (wrapper.IsComplex())
    {
      return IfcPredefinedType.Complex;
    }

    if (wrapper.IsElement())
    {
      return IfcPredefinedType.Element;
    }

    if (wrapper.IsPartial())
    {
      return IfcPredefinedType.Partial;
    }

    if (wrapper.IsProvisionForSpace())
    {
      return IfcPredefinedType.ProvisionForSpace;
    }

    if (wrapper.IsProvisionForVoid())
    {
      return IfcPredefinedType.ProvisionForVoid;
    }

    if (wrapper.IsColumn())
    {
      return IfcPredefinedType.Column;
    }

    if (wrapper.IsPilaster())
    {
      return IfcPredefinedType.Pilaster;
    }

    if (wrapper.IsMolding())
    {
      return IfcPredefinedType.Molding;
    }

    if (wrapper.IsSkirtingboard())
    {
      return IfcPredefinedType.Skirtingboard;
    }

    if (wrapper.IsDoor())
    {
      return IfcPredefinedType.Door;
    }

    if (wrapper.IsGate())
    {
      return IfcPredefinedType.Gate;
    }

    if (wrapper.IsTrapDoor())
    {
      return IfcPredefinedType.TrapDoor;
    }

    if (wrapper.IsCaissonFoundation())
    {
      return IfcPredefinedType.CaissonFoundation;
    }

    if (wrapper.IsBrace())
    {
      return IfcPredefinedType.Brace;
    }

    if (wrapper.IsChord())
    {
      return IfcPredefinedType.Chord;
    }

    if (wrapper.IsCollar())
    {
      return IfcPredefinedType.Collar;
    }

    if (wrapper.IsMember())
    {
      return IfcPredefinedType.Member;
    }

    if (wrapper.IsMullion())
    {
      return IfcPredefinedType.Mullion;
    }

    if (wrapper.IsPlate())
    {
      return IfcPredefinedType.Plate;
    }

    if (wrapper.IsPost())
    {
      return IfcPredefinedType.Post;
    }

    if (wrapper.IsPurlin())
    {
      return IfcPredefinedType.Purlin;
    }

    if (wrapper.IsRafter())
    {
      return IfcPredefinedType.Rafter;
    }

    if (wrapper.IsStringer())
    {
      return IfcPredefinedType.Stringer;
    }

    if (wrapper.IsStrut())
    {
      return IfcPredefinedType.Strut;
    }

    if (wrapper.IsStud())
    {
      return IfcPredefinedType.Stud;
    }

    if (wrapper.IsBored())
    {
      return IfcPredefinedType.Bored;
    }

    if (wrapper.IsDriven())
    {
      return IfcPredefinedType.Driven;
    }

    if (wrapper.IsJetgrouting())
    {
      return IfcPredefinedType.Jetgrouting;
    }

    if (wrapper.IsCurtainPanel())
    {
      return IfcPredefinedType.CurtainPanel;
    }

    if (wrapper.IsSheet())
    {
      return IfcPredefinedType.Sheet;
    }

    if (wrapper.IsHalfTurnRamp())
    {
      return IfcPredefinedType.HalfTurnRamp;
    }

    if (wrapper.IsQuarterTurnRamp())
    {
      return IfcPredefinedType.QuarterTurnRamp;
    }

    if (wrapper.IsSpiralRamp())
    {
      return IfcPredefinedType.SpiralRamp;
    }

    if (wrapper.IsStraightRunRamp())
    {
      return IfcPredefinedType.StraightRunRamp;
    }

    if (wrapper.IsTwoQuarterTurnRamp())
    {
      return IfcPredefinedType.TwoQuarterTurnRamp;
    }

    if (wrapper.IsTwoStraightRunRamp())
    {
      return IfcPredefinedType.TwoStraightRunRamp;
    }

    if (wrapper.IsBarrelRoof())
    {
      return IfcPredefinedType.BarrelRoof;
    }

    if (wrapper.IsButterflyRoof())
    {
      return IfcPredefinedType.ButterflyRoof;
    }

    if (wrapper.IsDomeRoof())
    {
      return IfcPredefinedType.DomeRoof;
    }

    if (wrapper.IsFlatRoof())
    {
      return IfcPredefinedType.FlatRoof;
    }

    if (wrapper.IsFreeform())
    {
      return IfcPredefinedType.Freeform;
    }

    if (wrapper.IsGableRoof())
    {
      return IfcPredefinedType.GableRoof;
    }

    if (wrapper.IsGambrelRoof())
    {
      return IfcPredefinedType.GambrelRoof;
    }

    if (wrapper.IsHippedGableRoof())
    {
      return IfcPredefinedType.HippedGableRoof;
    }

    if (wrapper.IsHipRoof())
    {
      return IfcPredefinedType.HipRoof;
    }

    if (wrapper.IsMansardRoof())
    {
      return IfcPredefinedType.MansardRoof;
    }

    if (wrapper.IsPavilionRoof())
    {
      return IfcPredefinedType.PavilionRoof;
    }

    if (wrapper.IsRainbowRoof())
    {
      return IfcPredefinedType.RainbowRoof;
    }

    if (wrapper.IsShedRoof())
    {
      return IfcPredefinedType.ShedRoof;
    }

    if (wrapper.IsCurvedRunStair())
    {
      return IfcPredefinedType.CurvedRunStair;
    }

    if (wrapper.IsDoubleReturnStair())
    {
      return IfcPredefinedType.DoubleReturnStair;
    }

    if (wrapper.IsHalfTurnStair())
    {
      return IfcPredefinedType.HalfTurnStair;
    }

    if (wrapper.IsHalfWindingStair())
    {
      return IfcPredefinedType.HalfWindingStair;
    }

    if (wrapper.IsQuarterTurnStair())
    {
      return IfcPredefinedType.QuarterTurnStair;
    }

    if (wrapper.IsQuarterWindingStair())
    {
      return IfcPredefinedType.QuarterWindingStair;
    }

    if (wrapper.IsSpiralStair())
    {
      return IfcPredefinedType.SpiralStair;
    }

    if (wrapper.IsStraightRunStair())
    {
      return IfcPredefinedType.StraightRunStair;
    }

    if (wrapper.IsThreeQuarterTurnStair())
    {
      return IfcPredefinedType.ThreeQuarterTurnStair;
    }

    if (wrapper.IsThreeQuarterWindingStair())
    {
      return IfcPredefinedType.ThreeQuarterWindingStair;
    }

    if (wrapper.IsTwoCurvedRunStair())
    {
      return IfcPredefinedType.TwoCurvedRunStair;
    }

    if (wrapper.IsTwoQuarterTurnStair())
    {
      return IfcPredefinedType.TwoQuarterTurnStair;
    }

    if (wrapper.IsTwoQuarterWindingStair())
    {
      return IfcPredefinedType.TwoQuarterWindingStair;
    }

    if (wrapper.IsTwoStraightRunStair())
    {
      return IfcPredefinedType.TwoStraightRunStair;
    }

    if (wrapper.IsCurved())
    {
      return IfcPredefinedType.Curved;
    }

    if (wrapper.IsSpiral())
    {
      return IfcPredefinedType.Spiral;
    }

    if (wrapper.IsStraight())
    {
      return IfcPredefinedType.Straight;
    }

    if (wrapper.IsWinder())
    {
      return IfcPredefinedType.Winder;
    }

    if (wrapper.IsElementedWall())
    {
      return IfcPredefinedType.ElementedWall;
    }

    if (wrapper.IsMovable())
    {
      return IfcPredefinedType.Movable;
    }

    if (wrapper.IsParapet())
    {
      return IfcPredefinedType.Parapet;
    }

    if (wrapper.IsPartitioning())
    {
      return IfcPredefinedType.Partitioning;
    }

    if (wrapper.IsPlumbingWall())
    {
      return IfcPredefinedType.PlumbingWall;
    }

    if (wrapper.IsPolygonal())
    {
      return IfcPredefinedType.Polygonal;
    }

    if (wrapper.IsShear())
    {
      return IfcPredefinedType.Shear;
    }

    if (wrapper.IsSolidWall())
    {
      return IfcPredefinedType.SolidWall;
    }

    if (wrapper.IsStandard())
    {
      return IfcPredefinedType.Standard;
    }

    if (wrapper.IsLightdome())
    {
      return IfcPredefinedType.Lightdome;
    }

    if (wrapper.IsSkylight())
    {
      return IfcPredefinedType.Skylight;
    }

    if (wrapper.IsWindow())
    {
      return IfcPredefinedType.Window;
    }

    if (wrapper.IsOpening())
    {
      return IfcPredefinedType.Opening;
    }

    if (wrapper.IsRecess())
    {
      return IfcPredefinedType.Recess;
    }

    if (wrapper.IsAnchorbolt())
    {
      return IfcPredefinedType.Anchorbolt;
    }

    if (wrapper.IsBolt())
    {
      return IfcPredefinedType.Bolt;
    }

    if (wrapper.IsDowel())
    {
      return IfcPredefinedType.Dowel;
    }

    if (wrapper.IsNail())
    {
      return IfcPredefinedType.Nail;
    }

    if (wrapper.IsNailPlate())
    {
      return IfcPredefinedType.NailPlate;
    }

    if (wrapper.IsRivet())
    {
      return IfcPredefinedType.Rivet;
    }

    if (wrapper.IsScrew())
    {
      return IfcPredefinedType.Screw;
    }

    if (wrapper.IsShearConnector())
    {
      return IfcPredefinedType.ShearConnector;
    }

    if (wrapper.IsStaple())
    {
      return IfcPredefinedType.Staple;
    }

    if (wrapper.IsStudShearConnector())
    {
      return IfcPredefinedType.StudShearConnector;
    }

    if (wrapper.IsGlue())
    {
      return IfcPredefinedType.Glue;
    }

    if (wrapper.IsMortar())
    {
      return IfcPredefinedType.Mortar;
    }

    if (wrapper.IsWeld())
    {
      return IfcPredefinedType.Weld;
    }

    if (wrapper.IsExternal())
    {
      return IfcPredefinedType.External;
    }

    if (wrapper.IsGfa())
    {
      return IfcPredefinedType.Gfa;
    }

    if (wrapper.IsInternal())
    {
      return IfcPredefinedType.Internal;
    }

    if (wrapper.IsParking())
    {
      return IfcPredefinedType.Parking;
    }

    if (wrapper.IsSpace())
    {
      return IfcPredefinedType.Space;
    }

    if (wrapper.IsAccessoryAssembly())
    {
      return IfcPredefinedType.AccessoryAssembly;
    }

    if (wrapper.IsArch())
    {
      return IfcPredefinedType.Arch;
    }

    if (wrapper.IsBeamGrid())
    {
      return IfcPredefinedType.BeamGrid;
    }

    if (wrapper.IsBracedFrame())
    {
      return IfcPredefinedType.BracedFrame;
    }

    if (wrapper.IsGirder())
    {
      return IfcPredefinedType.Girder;
    }

    if (wrapper.IsReinforcementUnit())
    {
      return IfcPredefinedType.ReinforcementUnit;
    }

    if (wrapper.IsRigidFrame())
    {
      return IfcPredefinedType.RigidFrame;
    }

    if (wrapper.IsSlabField())
    {
      return IfcPredefinedType.SlabField;
    }

    if (wrapper.IsTruss())
    {
      return IfcPredefinedType.Truss;
    }

    if (wrapper.IsCableLadderSegment())
    {
      return IfcPredefinedType.CableLadderSegment;
    }

    if (wrapper.IsCableTraySegment())
    {
      return IfcPredefinedType.CableTraySegment;
    }

    if (wrapper.IsCableTrunkingSegment())
    {
      return IfcPredefinedType.CableTrunkingSegment;
    }

    if (wrapper.IsConduitSegment())
    {
      return IfcPredefinedType.ConduitSegment;
    }

    if (wrapper.IsBusbarSegment())
    {
      return IfcPredefinedType.BusbarSegment;
    }

    if (wrapper.IsCableSegment())
    {
      return IfcPredefinedType.CableSegment;
    }

    if (wrapper.IsConductorSegment())
    {
      return IfcPredefinedType.ConductorSegment;
    }

    if (wrapper.IsCoreSegment())
    {
      return IfcPredefinedType.CoreSegment;
    }

    if (wrapper.IsFlexibleSegment())
    {
      return IfcPredefinedType.FlexibleSegment;
    }

    if (wrapper.IsRigidSegment())
    {
      return IfcPredefinedType.RigidSegment;
    }

    if (wrapper.IsCulvert())
    {
      return IfcPredefinedType.Culvert;
    }

    if (wrapper.IsGutter())
    {
      return IfcPredefinedType.Gutter;
    }

    if (wrapper.IsSpool())
    {
      return IfcPredefinedType.Spool;
    }

    if (wrapper.IsAudioVisualOutlet())
    {
      return IfcPredefinedType.AudioVisualOutlet;
    }

    if (wrapper.IsCommunicationsOutlet())
    {
      return IfcPredefinedType.CommunicationsOutlet;
    }

    if (wrapper.IsPowerOutlet())
    {
      return IfcPredefinedType.PowerOutlet;
    }

    if (wrapper.IsDataOutlet())
    {
      return IfcPredefinedType.DataOutlet;
    }

    if (wrapper.IsTelephoneOutlet())
    {
      return IfcPredefinedType.TelephoneOutlet;
    }

    if (wrapper.IsAnchoring())
    {
      return IfcPredefinedType.Anchoring;
    }

    if (wrapper.IsEdge())
    {
      return IfcPredefinedType.Edge;
    }

    if (wrapper.IsLigature())
    {
      return IfcPredefinedType.Ligature;
    }

    if (wrapper.IsMain())
    {
      return IfcPredefinedType.Main;
    }

    if (wrapper.IsPunching())
    {
      return IfcPredefinedType.Punching;
    }

    if (wrapper.IsRing())
    {
      return IfcPredefinedType.Ring;
    }

    return IfcPredefinedType.None;
  }
}
