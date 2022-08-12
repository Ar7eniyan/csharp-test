namespace Minecraft.Entity;

interface IEntity
{
    public string DisplayName => throw new NotImplementedException();

    public void TakeDamage(int damage);
    public void Kill();
}

public abstract class Entity : IEntity
{
    public abstract void TakeDamage(int damage);
    public abstract void Kill();
}