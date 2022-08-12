namespace Minecraft.Entity.Mob;

public class Skeleton : Mob, IHostileMob
{
    public string DisplayName => "Skeleton";
    public override int MaxHealth => 20;

    public static readonly int RangedAttackDamage = 3; 

    void IHostileMob.RangedAttack(IMob target)
    {
        Console.WriteLine("Skeleton performs ranged attack");
        target.TakeDamage(RangedAttackDamage);
    }
}