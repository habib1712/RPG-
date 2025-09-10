public class Creature

{
    // ENEMY HP 
    public int EnemyHP = 150;
    private Random rand = new Random();
    public virtual void Damage(Player player)
    {

        //ENEMY DAMAGE
        int DamageAmount = rand.Next(2, 20);

        Console.WriteLine();
        player.Health -= DamageAmount;


        if (DamageAmount <= 10)
        {
            Console.WriteLine(player.Name + " barely took a graze and lost " + DamageAmount + " HP");


        }
        if (DamageAmount >= 11 && DamageAmount <= 20)
        {
            Console.WriteLine(player.Name + " Took damage and lost " + DamageAmount + " HP");

        }
        if (DamageAmount >= 21)
        {
            Console.WriteLine(player.Name + " Recieved HEAVY damage and lost " + DamageAmount + " HP");

        }
    }

}

public class Goblin : Creature
{
    public Goblin()
    {
        EnemyHP = 150;
    }
    private Random rand = new Random();
    public override void Damage(Player player)
    {
        int DamageAmount = rand.Next(2, 20);

        Console.WriteLine();
        player.Health -= DamageAmount;
        if (DamageAmount <= 10)
        {
            Console.WriteLine("Goblin grazed you: " + player.Name + " lost " + DamageAmount + " HP");


        }
        if (DamageAmount >= 11 && DamageAmount <= 20)
        {
            Console.WriteLine("Goblin swung the club: " + player.Name + " lost " + DamageAmount + " HP");

        }
        if (DamageAmount >= 21)
        {
            Console.WriteLine("Goblin used SPIKED SMASHED:" + player.Name +  " RECEIVED HEAVY DAMAGE AND lost " + DamageAmount + " HP");

        }
    }
}

public class Troll : Creature
{
    public Troll()
    {
        EnemyHP = 300;
    }
    private Random rand = new Random();
    public override void Damage(Player player)
    {
        int DamageAmount = rand.Next(8, 38);

        Console.WriteLine();
        player.Health -= DamageAmount;
        if (DamageAmount <= 15)
        {
            Console.WriteLine("Troll GRAZED" + player.Name + " and lost " + DamageAmount + " HP");


        }
        if (DamageAmount >= 16 && DamageAmount <= 29)
        {
            Console.WriteLine("Troll used SLASH: " + player.Name + " lost " + DamageAmount + " HP");

        }
        if (DamageAmount >= 30)
        {
            Console.WriteLine("Troll used PIERCING STAB:" + player.Name + " recieved HEAVY damage and lost " + DamageAmount + " HP");

        }
    }
}

public class Mage : Creature
{
    public Mage()
    {
        EnemyHP = 450;
    }
    private Random rand = new Random();
    public override void Damage(Player player)
    {
        int DamageAmount = rand.Next(20, 50);

        Console.WriteLine();
        player.Health -= DamageAmount;
        if (DamageAmount <= 20)
        {
            Console.WriteLine("Mage SHOT you with FIREBALL: " + player.Name + " lost " + DamageAmount + " HP");


        }
        if (DamageAmount >= 21 && DamageAmount <= 36)
        {
            Console.WriteLine("Mage used LIGHTNING BOLT: " + player.Name + " lost " + DamageAmount + " HP");

        }
        if (DamageAmount >= 37)
        {
            Console.WriteLine("Mage used EXPLOSION:" + player.Name + " recieved HEAVY damage and lost " + DamageAmount + " HP");

        }
    }
}

public class Dragon : Creature
{
    public Dragon()
    {
        EnemyHP = 600;
    }
    private Random rand = new Random();
    public override void Damage(Player player)
    {
        int DamageAmount = rand.Next(20, 80);

        Console.WriteLine();
        player.Health -= DamageAmount;
        if (DamageAmount <= 30)
        {
            Console.WriteLine("Dragon used SCRATCH: " + player.Name + " lost " + DamageAmount + " HP");


        }
        if (DamageAmount >= 31 && DamageAmount <= 60)
        {
            Console.WriteLine("Dragon used TAIL SWEEP: " + player.Name + " lost " + DamageAmount + " HP");

        }
        if (DamageAmount >= 61)
        {
            Console.WriteLine("Dragon used FIRE DRAGON ROAR: " + player.Name + " recieved HEAVY damage and lost " + DamageAmount + " HP");

        }
    }
}