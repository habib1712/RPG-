public class Fight
{
    public Fight(Player player, Creature creature)
    {

        static void Slow(string text, int delay = 10)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }
        // action list
        List<string> actions = new List<string> { "1: View inventory ", "2: Use an Item ", "3: Attack ", "4: View stats ", "5: Give up" };
        Console.WriteLine();

        //actions

        while (true)
        {

            Console.WriteLine("Choose an action:");
            foreach (string act in actions) { Console.WriteLine(act); }
            Console.WriteLine();
            try
            {
                Console.Write("Action: ");
                int choice = int.Parse(Console.ReadLine());


                bool EnemyAttack = true;

                switch (choice)
                {
                    case 1:
                        {
                            player.ShowInventory();
                            EnemyAttack = false;
                            break;
                        }

                    case 2:
                        {
                            player.UseItem();
                            break;
                        }

                    case 3:
                        {
                            player.Attack(creature, player);
                            break;
                        }

                    case 4:
                        {
                            player.ShowStats();
                            EnemyAttack = false;
                            break;
                        }

                    case 5:
                        {
                            Console.WriteLine();
                            Console.WriteLine("GAME OVER");
                            Environment.Exit(0);
                            return;
                        }

                }
                if (EnemyAttack)
                {
                    creature.Damage(player);
                }

                if (creature.EnemyHP <= 0)
                {
                    Console.WriteLine("CONGRATULATIONS YOU BEAT THE ENEMY");
                    Console.WriteLine();
                    break;
                }

                if (player.Health <= 0)
                {
                    Console.WriteLine("YOU HAVE DIED: you've let down your village...");
                    Console.WriteLine();
                    Environment.Exit(0);
                }

            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("ERROR: ENTER A NUMBER ");


            }
        }
    }
}
