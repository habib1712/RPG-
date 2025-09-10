public class Player
{
    public string Name;
    public int Health;
    public int Mana;
    public int Strength;
    public List<string> Inventory;

    //PLAYER
    public Player(string name)
    {
        Name = name;
        Health = 100;
        Mana = 5;
        Strength = 10;
        Inventory = new List<string>();
    }

    //SHOW inventory
    public void ShowInventory()
    {
        Console.WriteLine();
        Console.WriteLine("Inventory: " + string.Join(", ", Inventory));
        Console.WriteLine();
        Console.WriteLine("Return to action menu? (type anything)");
        Console.ReadLine();
    }

    //SHOW STATS
    public void ShowStats()
    {
        Console.WriteLine();
        Console.WriteLine($"{Name} Stats:");
        Console.WriteLine("Health: " + Health);
        Console.WriteLine("Mana: " + Mana);
        Console.WriteLine("Strength: " + Strength);
        Console.WriteLine();
        Console.WriteLine("Return to action menu? (type anything)");
        Console.ReadLine();
    }

    //PLAYER USE ITEM MENU
    private Random rand = new Random();
    public void UseItem()
    {


        int healed;
        int manaAmount = rand.Next(12, 25);
        int StrAdd = rand.Next(5, 15);

        Console.WriteLine();
        Console.WriteLine("Which item would you like to use?");

        // display options
        List<string> UseInv = new List<string> { "1: strength ", "2: heal ", "3: mana " };
        foreach (string item in UseInv) { Console.WriteLine(item); }
        Console.WriteLine();
        Console.Write("Item: ");

        int itemN = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (Inventory.Contains("Life Amulet"))
        {
            healed = rand.Next(33, 65);
        }
        else
        healed = rand.Next(13, 32);
        if (itemN == 2)
        {
            Console.WriteLine("You restored " + healed + " health");

            Health += healed;
        }
        if (itemN == 3)
        {
            Console.WriteLine("You restored " + manaAmount + " mana");

            Mana += manaAmount;
        }
        if (itemN == 1)
        {
            Console.WriteLine("You increased your strength by " + StrAdd);

            Strength += StrAdd;
        }
    }

    // PLAYER ATTACK MENU

    public void Attack(Creature creature, Player player)
    {

        int swrd = rand.Next(1, 5) + Strength;
        int fireBall = rand.Next(16, 34);
        int waterJet = rand.Next(17, 36);
        int Poison = rand.Next(5, 19);
        int Explo = rand.Next(30, 90);

        int fireCost = 8;
        int waterCost = 11;
        int poisonCost = 15;
        int ExploCost = 50;

        Console.WriteLine();
        Console.WriteLine("Which attack would you like to use? ");
        List<string> AttackChoice = new List<string> { "1: Sword Slash ", "2: Fireball: 8 MANA ", "3: Water Jet: 11 MANA ", "4: Poison Shot: 15 MANA (deals poison) " };
        
        // adds explosion spell after defeating mage
        if (Inventory.Contains("Explosion"))
        {
            AttackChoice.Add("5: EXPLOSION: 40 MANA");
        }

        foreach (string ChoseMove in AttackChoice) { Console.WriteLine(ChoseMove); }
        Console.Write("Action: ");

        int AtkAc = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (AtkAc == 1)
        {
            Console.WriteLine(player.Name + " Slashed the enemy dealing " + swrd + " Damage");
            creature.EnemyHP -= swrd;
            Console.WriteLine("Enemy Remaining HP: " + creature.EnemyHP);
        }

        if (AtkAc == 2)
        {
            if (Mana >= fireCost)
            {
                Mana -= fireCost;
                Console.WriteLine(player.Name + " Casted a fireball spell and dealt " + fireBall + " Damage");
                creature.EnemyHP -= fireBall;
                Console.WriteLine("Enemy Remaining HP: " + creature.EnemyHP);
            }
            if (Mana <= fireCost)
            {
                Console.WriteLine("Not enough mana: " + Mana);
            }
        }

        if (AtkAc == 3)
        {
            if (Mana >= waterCost)
            {
                Mana -= waterCost;
                Console.WriteLine(player.Name + " Casted WaterJet and dealt " + waterJet + " Damage");
                creature.EnemyHP -= waterJet;
                Console.WriteLine("Enemy Remaining HP: " + creature.EnemyHP);
            }
            if (Mana <= waterCost)
            {
                Console.WriteLine("Not enough mana: " + Mana);
            }
        }

        if (AtkAc == 4)
        {
            if (Mana >= poisonCost)
            {
                Mana -= poisonCost;
                Console.WriteLine(player.Name + " Shot Poison and dealt " + Poison + " Damage ");
                creature.EnemyHP -= Poison;
                Console.WriteLine("Enemy Remaining HP: " + creature.EnemyHP);
            }
            if (Mana <= poisonCost)
            {
                Console.WriteLine("Not enough mana: " + Mana);
            }

        }
        
        if (AtkAc == 5 && Inventory.Contains("Explosion"))
        {
            if (Mana >= ExploCost)
            {
                Mana -= ExploCost;
                Console.WriteLine(player.Name + " Casted EXPLOSION " + Explo + " Damage");
                creature.EnemyHP -= Explo;
                Console.WriteLine("Enemy Remaining HP: " + creature.EnemyHP);
            }
            if (Mana <= ExploCost)
            {
                Console.WriteLine("Not enough mana: " + Mana);
            }
        }
    }
}


