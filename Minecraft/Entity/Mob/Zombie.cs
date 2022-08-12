namespace Minecraft.Entity.Mob;

public class Zombie : Mob, IHostileMob
{
    public string DisplayName => "Zombie";
    public override int MaxHealth => 20;

    public static readonly int MeleeAttackDamage = 5;

    void IHostileMob.MeleeAttack(IMob target)
    {
        Console.WriteLine("Zombie performs melee attack");
        target.TakeDamage(5);
    }
}