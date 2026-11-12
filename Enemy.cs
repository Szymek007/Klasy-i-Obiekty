public class Enemy
{
    public string Name { get; }
    public int Health { get; set; }
    public int Damage { get; }
    public int MaxHealth { get; set;}

    public Enemy(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }

    public bool TakeDamage(int damage)
    {
        if (damage <= 0)
        {
            return false;
        }
        
        if (!IsAlive())
        {
            return false;
        }
        
        Health -= damage;

        if (Health < 0)
        {
            Health = 0;
        }
        return true;
    }

    public bool IsAlive()
    {
        return Health > 0;
    }

   public bool Heal (int amount)
    {
        if (amount <= 0)
        {
            return false;
        }

        if (Health <= 0)
        {
            return false;
        }

        Health += amount;
        
        if (Health > MaxHealth)
        {
            Health = MaxHealth;
        }
        return true;
    }
}    
