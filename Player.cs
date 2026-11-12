public class Player
{
    public string Name { get; }
    public int Health { get; set; }
    public int MaxHealth { get; set; }
    public int Gold { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }
    
    public Player(string name, int maxHealth, int gold)
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = maxHealth;
        Gold = gold;
        Level = 1;
        Experience = 0;
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
    

    public bool Heal(int amount)
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

    public bool IsAlive()
    {
        return Health > 0;
    }

    public void GainExperience (int amount)
    {
        Experience += amount;

        while (Experience >= 100)
        {
            Experience -= 100;
            Level += 1;
            MaxHealth += 20;
            Health = MaxHealth;
        }
    }
}
