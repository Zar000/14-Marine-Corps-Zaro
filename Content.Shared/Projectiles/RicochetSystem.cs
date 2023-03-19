using JetBrains.Annotations;
using Content.Shared.Weapons.Ranged.Components;
using Content.Shared.Projectiles;
using Robust.Shared.Physics.Events;
using static Content.Shared.Projectiles.SharedProjectileSystem;

namespace Content.Shared.Weapons.Ranged.Systems;

[UsedImplicitly]
public sealed class RicochetSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<RicochetComponent, ImpactEffectEvent>(Ricochet);
    }

    private void Ricochet(EntityUid uid, RicochetComponent component, ImpactEffectEvent args)
    {
        //OK
    }
}
