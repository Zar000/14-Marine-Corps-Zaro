using JetBrains.Annotations;
using Content.Shared.Weapons.Ranged.Components;
using Robust.Shared.Physics.Events;
using Robust.Shared.Random;
namespace Content.Shared.Weapons.Ranged.Systems;

[UsedImplicitly]
public sealed class RicochetSystem : EntitySystem
{
    [Dependency] private readonly IRobustRandom _random = default!;
    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<RicochetComponent, StartCollideEvent>(Ricochet);
    }

    private void Ricochet(EntityUid uid, RicochetComponent component, ref StartCollideEvent args)
    {
        float chance = _random.NextFloat(0f, 1f);
        if(!(chance <= component.ricochetChance)){
            return;
        }

    }
}
