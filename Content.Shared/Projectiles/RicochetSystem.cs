using JetBrains.Annotations;
using Content.Shared.Weapons.Ranged.Components;
using Robust.Shared.Physics.Events;
namespace Content.Shared.Weapons.Ranged.Systems;

[UsedImplicitly]
public sealed class RicochetSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<RicochetComponent, StartCollideEvent>(Ricochet);
    }

    private void Ricochet(EntityUid uid, RicochetComponent component, ref StartCollideEvent args)
    {
        //
    }
}
