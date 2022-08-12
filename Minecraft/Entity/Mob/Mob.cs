namespace Minecraft.Entity.Mob;

interface IMob : IEntity
{
    public int Health { get; }
    public int MaxHealth => throw new NotImplementedException();
}

interface IHostileMob : IMob
{
    protected void MeleeAttack(IMob target)
    {
        throw new NotImplementedException();
    }

    protected void RangedAttack(IMob target)
    {
        throw new NotImplementedException();
    }
}

public abstract class Mob : Entity, IMob
{
    public int Health { get; private set; }
    public abstract int MaxHealth { get; }

    protected Mob()
    {
        Health = MaxHealth; // TODO ask on stack overflow
    }

    public override void TakeDamage(int damage)
    {
        Health = Math.Max(0, Health - damage);
    }

    public override void Kill()
    {
        Health = 0;
    }
}