using JetBrains.Annotations;
using Content.Client.Projectiles;
using Content.Shared.Weapons.Ranged.Components;

namespace Content.Shared.Weapons.Ranged.Systems;

[UsedImplicitly]
public sealed class RicochetSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<RicochetComponent, ProjectileHitEvent>(Ricochet);
    }

    private void Ricochet(EntityUid uid, RicochetComponent component, ProjectileHitEvent args)
    {
    }
}

