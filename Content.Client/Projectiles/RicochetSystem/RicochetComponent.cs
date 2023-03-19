using Robust.Shared.Analyzers;
using Robust.Shared.GameObjects;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Shared.Weapons.Ranged.Components;

[RegisterComponent]
public sealed class RicochetComponent : Component
{
    [ViewVariables(VVAccess.ReadWrite), DataField("minAngle")]
    public float minAngle = 1f;

    [ViewVariables(VVAccess.ReadWrite), DataField("maxAngle")]
    public float maxAngle = 30f;

    [ViewVariables(VVAccess.ReadWrite), DataField("dmgFallOff")]
    public float dmgFallOff = 0.3f;

    [ViewVariables(VVAccess.ReadWrite), DataField("speedFallOff")]
    public float speedFallOff = 0.8f;

    [ViewVariables(VVAccess.ReadWrite), DataField("ricochetPreci")]
    public float ricochetPrecision = 0.8f;

    [ViewVariables(VVAccess.ReadWrite), DataField("ricochetChance")]
    public float ricochetChance = 1f;

}
