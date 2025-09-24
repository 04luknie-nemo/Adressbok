namespace Adressbok.Logic;

class Entity
{
    public int Id { get; }
    public DateTime CreatedAt { get; } = DateTime.Now;
    public DateTime UpdateAt { get; private set; } = DateTime.Now;

    public Entity()
    {
        Id = Random.Shared.Next(1, 1000000);
    }

    public void SetUpdatedAt()
    {
        UpdateAt = DateTime.Now;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Skapad: {CreatedAt}, Uppdaterad:{UpdateAt}";
    }
}

