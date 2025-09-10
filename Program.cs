using System; 
using System.Collections.Generic; 

class Program 
{
    static void Main()
    {
        
// the slow text
        static void Slow(string text, int delay = 10)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }


        // Start game
        Slow("Enter your name: ", 40);
        string playerName = Console.ReadLine();

        Slow("Welcome to the RPG game: " + playerName);
        Console.WriteLine();

        Slow("YOU WAKE UP");
        Slow($"stranger: ah so you're finally awake, it's been a while {playerName}. A lot has happened ever since you were asleep, I mean take a look outside, our village is covered in ice");
        Slow($"stranger: Come on then get up and visit the main hall we're serving soup.");
        Console.WriteLine();
        Slow($"It's cold");
        Console.WriteLine();
        Slow($"Random Lady: {playerName} YOU'RE FINALLY AWAKE, our village has been through a lot ever since you've been asleep and ever since #### died");
        Slow($"Random Lady: You must be hungry let's go to the main hall, it's important we eat, there's been a huge food shortage and a lot of lives were lost due to hunger..");
        Console.WriteLine();

        Slow($"After eating {playerName} is approached by the elder");
        Console.WriteLine();
        Slow($"Elder: {playerName} I was waiting for you to wake up from your slumber! You're the only person I believe who can complete this quest. Our village really needs you to do this");
        Slow("You: what quest?");
        Slow("Elder: Do you know what has been happening? (yes/no)");
        Console.WriteLine();

        Slow("Choose: Option 1 (yes) or Option 2 (no)");
        int answer = 0;
        while (answer != 1 && answer != 2)
        {
            try
            {
                answer = int.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        Slow("Ah great! you're all caught up well i have arranged for someone to meet you at the gate");
                        break;

                    case 2:
                        Slow("Elder: Our village is in a deep frozen state for months, many lives were lost and our food is running very low and these temperatures are killing everyone.");
                        Slow("Elder: By Obtaining the eternal flame from the dragons denn up in the mountain it will drastically save our village");
                        Slow("Elder: now that you're filled in on what has happened, Go to the main get I have arranged for you to meet someone there");
                        break;

                    default:

                        Slow("Elder: sorry i didn't understand that (reply with yes/no)");
                        answer = 0;
                        break;

                }
            }
            catch (FormatException)
            {
                Slow("FORMAT ERROR ENTER A NUMBER OF EITHER 1 OR 2");
            }

        }
        Console.WriteLine();
        Slow($"gate man: OH HEY {playerName} ITS ME! I've been waiting for you");
        Slow("gate man: I've been assigned an important job to give you these items");
        Console.WriteLine();
        Slow("You have recieved a sword, strength potion, healing potion and a mana potion");

        Console.WriteLine();
        Slow("gate man: these items will help you on your journey to obtain the eternal flame, just follow along the path it'll lead you up the mountain");
        Slow("gate man: I wish you the best, the village is relying on you");
        Console.WriteLine();

        Slow("On your path you encounter a goblin", 30);
        Slow("The goblin isn't friendly it's screaming and pulled out it's club",30 );

        Player player = new Player(playerName);

        //GOBLIN FIGHT
        Console.WriteLine(@"⠀⢠⠤⢲⢯⢫⡉⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡠⣴⡊⣟⠆
⠀⠀⡸⣘⡲⢾⡡⠂⠀⡠⠔⠒⠒⠢⡄⠀⠀⠀⠀⣐⡨⠯⠗⣩⡶
⠀⣨⣀⠔⠘⠖⡘⠀⠘⠀⠀⣶⡆⠀⠈⣆⠀⠀⢈⠐⠞⢲⠂⢱⠀
⢠⡟⠄⠁⡒⠈⢀⠔⠙⣄⠀⠀⠀⠀⡰⠁⠈⢂⠀⠓⡤⠔⠈⣵⠂
⠘⡁⠀⠀⠻⡄⡜⢨⣄⡀⠉⠲⠮⠉⢀⣠⣤⡙⠄⡤⠃⠀⠀⠜⡆
⠀⠣⠀⠀⠀⠹⡀⠸⣿⢾⡗⢢⣤⣶⠿⣾⠝⠀⡘⠁⠀⠀⠀⡔⠀
⠀⠀⠳⡀⠀⠀⠹⣄⠀⠉⠉⠙⠋⠈⠉⠀⣄⡴⠁⠀⠀⢀⡜⠁⠀
⠀⠀⠀⠉⢄⠀⠀⠉⠑⠤⣄⣀⢀⣤⣠⠺⠃⠀⠀⠀⡔⠁⠀⠀⠀
⠀⠀⠀⠀⠀⠡⡀⠠⣄⢀⠀⠈⠉⠡⠁⠀⣠⠜⠀⠸⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⢠⠓⠀⠁⠙⠑⠄⣠⡤⠺⠊⠋⠀⠀⢣⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠈⡀⠀⠀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡘⠀⠀⠀⠀⠀
⠀⠀⠀⢀⡀⠀⡘⢦⠀⡍⠁⠒⠒⠒⠂⢉⡁⠀⡠⠁⠀⠀⠀⠀⠀
⠀⠀⠀⣗⣈⣭⢞⢷⣷⠚⡄⠀⠀⠀⠠⣿⣳⢭⣏⣀⠀⠀⠀⠀⠀
⠀⠀⠀⠙⠳⠬⢤⣁⣭⠛⢾⠀⠀⠀⠀⠈⡕⠯⠄⠀⣴⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⠉⠀⠀⠀⠀⠀⠀⠉⠉⠉⠀⠀⠀⠀⠀");

        Creature creature = new Goblin();

        new Fight(player, creature);

        Slow("");
        Slow("That goblin had nothing to drop..");
        Slow("You make your way up the long mountain, surprisingly it's been very peaceful");
        Slow("The cold must've killed most of them or put them into hiding");
        Slow($"As {playerName} is walking up a mountain. A SWORD came flying out of nowwhere and lands a few meters ahead of him", 30);
        Console.WriteLine();
        Slow("A large trolls falls from the sky landing on it's two feet and picks up the sword", 30);
        Slow("It uses a hand gesture to tell you to fight", 30);

        //TROLL 
        Console.WriteLine(@"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣠⣤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡴⢯⡼⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢿⣲⣄⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣼⡤⠼⡄⠀⠀⠀⠀⠀⠀⠀⠀⡠⠒⠉⠉⠢⡀⠀⠀⠀⠀⠀⢸⠧⠼⡆⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣧⠀⡤⠚⢓⡦⠤⣤⠔⡦⠖⠻⠁⠀⠸⠆⠀⡷⣤⠤⣀⣀⢴⡛⠒⢤⣹⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢟⠀⣠⠊⠀⡰⣡⠊⠀⢀⡠⠷⠄⣀⣠⠔⠳⡈⠳⡈⢦⠀⠘⢄⢠⠏⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⡟⢩⣍⢺⣷⠃⠀⢰⢃⠤⠤⢤⣀⠞⠉⠳⣄⠀⢱⡈⣦⠖⢾⡃⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⣤⠖⠒⠢⢵⣮⣝⣻⠇⠀⢀⡼⠁⠀⠀⢰⣿⣷⡄⠀⠘⡄⠀⣿⣔⣩⢯⠷⠊⠉⠙⢦⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⢀⡴⠋⠀⠀⢠⠤⠬⣑⣾⠀⠀⠘⣿⣄⠀⠀⢈⣿⡟⠀⠀⣠⡇⠀⢸⠗⣛⠡⠄⠐⢧⠀⠈⢆⠀⠀
⠀⠀⠀⠀⠀⠀⢀⡎⠀⠀⠀⣠⠃⠀⠀⠀⢹⠀⠀⠀⠈⠙⠛⠋⠁⠀⠘⢳⣿⠛⠀⠀⢸⠉⠀⠀⠀⠀⢸⡀⠀⠸⡄⠀
⠀⠀⠀⠀⠀⣴⡿⠀⠀⠀⢰⣇⡀⠀⠀⠀⢸⡀⠀⠀⠀⣠⠴⡞⠉⠉⣏⢉⠏⣆⠀⠀⡜⠀⠀⠀⣀⠤⢼⠃⠀⢀⣷⠀
⠀⠀⠀⠀⠐⡇⢀⠀⠀⠀⢈⠀⣹⠀⠀⠀⠀⣇⠀⣠⢾⡄⢰⠛⡄⢸⠹⡜⠀⢸⡄⢀⠇⠀⠀⠀⣇⠀⡄⠀⠀⠘⠛⡄
⢀⣀⣀⣠⣤⣼⣿⣄⡆⠀⣿⡏⠁⠀⠀⠀⠀⡏⠸⣹⡾⠽⠷⠤⠼⠧⠴⠧⢤⠼⠿⣾⠀⠀⠀⠀⢹⡾⠇⠀⠀⠀⢰⠃
⠘⣿⣝⠛⠛⣛⣿⣿⠭⣙⠉⠀⠀⠀⠀⠀⢀⣽⠋⢡⠛⠉⠉⠒⠒⠒⠛⠒⢦⠉⠒⠇⠀⠀⠀⠀⠈⠓⠒⠛⠒⠛⠋⠀
⠀⠈⠙⠥⣀⣠⣞⠟⢀⡼⠃⠀⠀⣠⠔⠊⠁⣸⠆⡆⠀⠀⠀⠈⠙⠒⠠⠀⢀⡇⣸⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⣠⠊⢁⡔⠋⢀⡤⠒⠉⣀⣤⡴⠚⠁⠀⡇⠀⠀⠀⠀⠀⠀⠀⠀⢸⠃⠈⠒⢄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⢻⡀⠘⠓⠚⣁⡤⠔⣋⡵⠋⠀⣀⠴⠊⠉⠑⠒⠒⠒⠒⠒⠒⠒⠋⠉⠲⢄⡀⠑⠢⢀⣀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠱⠶⠶⠭⠕⠻⡏⠀⠀⠀⣞⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠟⠂⠀⠀⢨⠆⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⡗⠀⠀⢺⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠏⠀⠀⠀⢸⠋⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡆⠀⠀⠸⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡞⠀⠀⠀⣰⠃⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⢀⡤⡤⢤⡤⢼⠃⠀⠀⠀⢣⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⠞⠀⠀⢀⠤⣧⠤⢴⣤⡀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⢸⣧⠃⡏⠀⠀⠁⠀⠀⠀⢈⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣇⠉⠀⣀⠁⠀⠈⡆⠀⣹⣷⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠉⠓⠛⠒⠒⠊⠉⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⠉⠉⠉⠉⠉⠉⠉⠁⠀⠀⠀⠀⠀");
        creature = new Troll();
        new Fight(player, creature);
        Slow("");
        Slow("That Troll was a lot stronger than the goblin");
        Slow("You picked up a Life Amulet the troll dropped");
        Console.WriteLine();

        Slow("Life Amulet effects: +50 health, +30 mana, +20,40 increased healing  ", 30);
        player.Inventory.Add("Life Amulet");


//DIAGLOGUE
        Slow("you decide to take camp and rest for the night in a cave");
        Slow("Your health and mana is restored back to default after taking camp and sleeping");
        player.Health = 150;
        player.Mana = 35;
        Console.WriteLine();
        Slow("You wake up, it's bright but still foggy and cold");
        Slow("After your meal you decide to climb the mountain further");
        Slow("You find an wide open zone with the rest of the path on the other side");
        Console.WriteLine();

        Slow("But there are random pillars?");
        Slow("As you walk towards the path fire ball comes out of nowhere and HITS YOU", 30);
        Console.WriteLine();
        Slow("Luckily you reacted quick and only lost 10hp");
        player.Health = 140;
        Slow($"{playerName} HP: {player.Health}");
        Console.WriteLine();
        Slow("you look to see something in a robe descending from a pillar to the ground", 30);
        Slow("it takes out a staff and points it at you", 30);
        Slow("You tell something is coming", 40);
        Console.WriteLine();
        Slow("A bolt of lightning charges at you but luckily you dodge");
        Console.WriteLine();
        Slow("it's time to fight", 50);


        //MAGE FIGHT
        Console.WriteLine(@"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⢞⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣄⣀⠀⠀⠀⣠⣴⣵⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡤⠞⢱⣽⣿⣷⣖⢹⣿⢿⣿⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠻⣿⣏⣻⣿⣿⣿⣿⣿⣿⣽⣄⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡞⠉⢹⣿⣿⣿⣿⣿⡟⠁⡻⣴⣮⣿⣷⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣥⣤⣼⡟⣿⣿⣿⣟⣠⣠⣽⣿⣿⡿⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠛⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣾⡿⣭⣿⣿⣿⣿⣿⡿⠆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⣿⢿⣿⣿⣿⡻⣇⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣿⡧⣴⣿⣟⣿⣿⢻⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣼⣝⣿⣿⣿⣞⡹⠿⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⢶⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⣿⣿⣿⣿⡴⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⠤⠖⢦⣀⣀⣀⣠⠎⣸⠀⣀⣀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣴⡿⣿⣿⡿⠋⠀⠀⠀⠀⡠⢶⣲⣶⣲⣶⡶⠖⠦⣼⣦⣆⡈⢻⣷⣾⣷⣶⠿⠿⠿⢧⣊⣉⣳⣤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣼⣝⣴⣿⡿⠁⠀⠀⠀⠀⠘⠷⠋⠁⠉⠻⢿⣿⡿⣶⣼⣛⡛⠿⣿⣿⣿⡟⠁⢰⣦⡀⠀⠀⠹⣅⠘⠛⢦⣶⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣾⣿⣿⣿⡟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣨⡷⠈⠙⣿⣿⣆⠀⢠⣿⡃⠀⠀⠹⣿⣿⣾⠖⠚⢦⡤⣾⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣶⠶⣿⣿⣿⣿⡟⠀⠀⠀⠀⠀⠀⣠⠔⢋⣱⣶⢿⣿⢿⢿⣿⣿⣿⣿⣎⠻⢿⣿⣿⣷⣄⡀⠀⠬⠭⡾⢻⣿⣆⡙⢸⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⣿⠷⢦⣸⣿⠿⠉⠙⡆⠀⠀⠀⢀⣼⣡⠞⢫⣿⡴⠋⣀⣴⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⡆⠙⢿⣣⠀⠸⠁⣀⣙⣿⣿⣽⡿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⢠⣿⣿⣿⣷⣟⣷⢳⠀⠀⢀⣼⠏⣿⢝⣽⣿⣿⣿⡿⠿⠿⢿⣿⠿⠛⠛⠉⠻⣿⣿⣿⣄⠈⠛⣷⡅⣾⣿⣿⣿⠿⣿⡅⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⢰⣧⠛⢺⣿⣿⣿⣿⣿⣿⣿⡀⢰⣿⠟⠋⠁⣀⣾⠟⠋⠀⠀⠀⠀⠐⣆⠴⢒⡴⢋⡔⠈⢿⣿⣿⣿⣷⣮⣿⣌⣋⠉⣹⣤⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⣀⣀⢘⣿⣶⣿⣿⣿⣿⣿⣿⣿⣁⢳⡈⠯⣳⣶⣿⣿⡏⠀⠀⠀⠠⠄⠀⢱⠈⠳⡥⣴⡋⣀⡴⡛⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⣞⠁⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⣌⠲⣄⣤⣿⣿⡀⠀⠀⢀⣤⠔⠒⠋⠀⠀⠙⠢⣍⠻⢾⣭⣿⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⢠⡖⢿⣷⣸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡏⠘⣿⣿⣷⠒⠶⢿⡇⠀⠀⠀⠀⠀⠀⠀⠀⢱⠀⠁⠩⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣟⠢⣄⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠘⠧⣄⣙⣿⣿⣿⣿⠿⡙⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⢿⣿⣿⣷⡀⣸⣿⣄⠀⡀⠀⠀⠀⠀⠀⢸⠀⢀⣼⣿⣿⣍⣿⣿⣿⣿⣿⣿⣿⣿⣿⣽⣷⣯⣙⠒⢶⠀⠀⠀⠀
⠀⠀⠀⠀⣠⣾⣿⣿⡿⠉⠛⣆⠙⢿⣿⣿⣿⣿⣿⣿⣿⣿⣧⣀⣨⣿⣝⣿⣿⣿⣿⠻⣿⣿⣇⠀⠀⢀⣠⣿⠴⠯⠟⠻⠿⣿⣿⠿⣿⣿⣿⣿⠿⠿⠿⠿⢿⣿⣿⣿⣼⣟⢦⠀⠀
⠀⠐⣒⡿⠞⢙⣿⠛⣇⠀⡞⠁⠀⠈⠛⠿⣿⣿⣿⣿⣿⣿⠿⠟⡛⢛⣿⡯⠟⣿⣿⣟⠻⣍⠛⠛⠚⣿⡿⠷⠶⠟⠒⠀⠀⢹⣿⣇⣀⠀⠀⠀⠀⠀⠀⠀⢤⣿⣿⣿⡿⣡⣿⠀⠀
⠉⠉⡡⠖⢚⡿⠃⣰⠋⢳⡹⣄⠀⠀⠀⠀⢙⣿⡟⣿⣿⣟⣀⡼⠛⠉⠀⠀⠀⣸⣿⣿⣶⣌⠓⠀⠀⣿⣿⡿⠾⠍⢀⠈⠉⣻⣿⣿⣿⣶⣶⣶⣿⣷⣶⣾⣿⣿⣿⣭⣾⣿⡾⡀⠀
⠀⡼⠁⠀⠘⠶⣤⠟⠀⠀⠑⠾⠆⠀⠀⣾⣽⠞⣳⠏⠙⠚⠉⠀⠀⠀⠀⢀⣀⣿⣿⣿⣻⣿⣿⣿⣶⣿⣿⣤⣾⣷⠀⣸⣍⣽⣿⣿⣿⣿⡿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⡀⠀
⠓⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣟⡡⠚⠁⠀⠀⠀⠀⠀⠀⣠⣶⣯⣾⣿⣿⣿⡿⣿⣿⣟⣻⣿⣿⣿⣿⣯⣿⣿⣿⣿⣿⣿⣿⣿⣇⢾⣿⣿⣷⡝⢿⣿⣿⣿⡛⣾⣆⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⠟⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⣿⣿⣿⣏⣩⠋⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣵⣴⣮⣽⣿⣿⣧⡟⢿⣾⡿⣿⣿⣿⣦⣿⣿⠟⠛⠿⣟⠳⡄
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣀⣀⡤⢲⣿⢿⣿⣿⣿⣿⣿⡧⢀⣽⡿⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡆⠈⠓⠃⠈⠛⠋⠛⠻⣼⡆⠀⠀⠀⠉⠁
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⡽⠼⠓⣾⠏⣡⠞⣿⣿⣿⣷⣿⣿⣿⡿⢥⣴⣹⡟⠛⠿⢿⣿⣿⣿⣿⣿⣿⣿⣿⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠓⠚⠀⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⠋⠉⠀⠀⠀⠈⢻⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣿⣿⣿⣿⢿⣿⣄⠀⠀⠀⠀⠐⠀⠀⢻⣿⣿⣿⣿⣿⣿⡅⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠛⠛⣿⣿⣿⣟⣿⣷⣌⡉⠛⠲⣄⠀⠀⠀⠀⢀⣿⣿⣿⣿⣿⣿⡟⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢿⣿⣏⡏⠉⢿⣿⣿⣿⠀⠘⣦⣀⣼⣿⣿⣿⣿⣿⣿⡟⢹⣧⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣟⣩⠇⢠⣿⣿⣿⣟⢷⣄⣈⣘⣿⣿⣿⣟⢻⣿⣿⣷⣾⣏⡗⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢶⣿⣿⣿⣿⣿⣿⣿⣿⣟⣛⣿⣿⣿⣿⣿⣾⢻⣿⣯⠟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣾⣿⣿⣿⣿⣻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣤⣾⣿⣿⣿⣿⣿⣿⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣸⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢈⣯⣿⡿⣻⣿⣿⣿⢻⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣶⣾⣿⣿⣿⣿⣧⣿⢻⣏⣿⣾⣿⡿⠿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣾⣿⣽⡏⢿⣿⣿⣿⡿⠟⠛⠋⠁⢀⡀⠀⠙⢿⣿⣿⣿⣿⣻⣾⡿⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⠓⠻⣿⠽⠓⠛⠿⢿⣧⠀⠀⠀⢦⡀⢄⠙⢦⡀⣬⣿⣿⢯⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠻⢿⣶⣦⣿⣿⡶⣬⣷⣿⣿⣿⣷⢳⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        creature = new Mage();
        new Fight(player, creature);
        Console.WriteLine();
        Slow("That mage was tough");
        Slow("Mage dropped a few items");
        Slow("Magic cloak: increases your defense/health by 60, mana by 55", 30);
        Slow("You also learned a new spell: EXPLOSION", 50);
        //NEW SPELL
        player.Inventory.Add("Explosion");

        Console.WriteLine();
        Slow("you find another cave, do you want to rest for the night and restore your health and mana back to normal?");
        Console.WriteLine();
        Slow("Choose: Option 1 (yes) or Option 2 (no)");


        int bosschoice = 0;
        while (bosschoice != 1 && bosschoice != 2)
        {
            try
            {
                bosschoice = int.Parse(Console.ReadLine());
                switch (bosschoice)
                {
                    case 1:
                        Slow("You rest for the night and restore your stats back to normal");
                        Console.WriteLine();
                        player.Health = 210;
                        player.Mana = 90;
                        


                        break;

                    case 2:
                        Slow("You continue up the mountain after defeating the mage");
                        break;

                    default:

                        Slow("(reply with yes/no)");
                        bosschoice = 0;
                        break;

                }
            }
            catch (FormatException)
            {
                Slow("FORMAT ERROR ENTER A NUMBER OF EITHER 1 OR 2");
            }

        }


// DRAGON FIGHT
        Slow("You make your way up to the top, it's a bit chilly...");
        Slow("You reach the top and see a large cave with a glowing light", 30);
        Slow("But it's empty with no enemy?", 30);
        Console.WriteLine();

        Slow("You go inside to grab the eternal flame", 20);
        Slow("it's a long journey back down");
        Slow("You take your time getting down, taking a rest during the night");
        Slow("As you come down you see a large glowing light", 30);
        Console.WriteLine();
        Slow("THE VILLAGE IS ON FIRE",20);
        Slow("There's a dragon hovering over the village roaring", 20);
        Slow("You rush down the rest of the mountain heading straight for the village");
        Slow("You see there's many casualaties with the first sight being the gate man being burnt to a crisp");
        Console.WriteLine();
        Slow("you try to get the dragons attention by screaming but it doesn't work");
        Slow("You take out the eternal flame which catches it's attention and it stares at you", 30);
        Slow("You can't fight whislt carrying that so you give it to someone and get it's attention by shooting multiple fireballs at the dragon");

        Console.WriteLine();

        Slow("It's focussed on you again and you run away from the village whilst shooting at it to keep it on you");
        Console.WriteLine();
        Slow("because of this you lost 30 mana", 30);
        Slow("you're finally in an open area and ready to slay the dragon", 50);
        Console.WriteLine();
        player.Mana = 60;


        Console.WriteLine(@"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠻⡗⢦⣄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⢀⣤⣤⡤⠤⠶⠿⣶⣦⣄⣙⣦⠙⢿⡓⢦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠳⣄⠀⠀⠀⠭⣉⠓⠒⠚⠽⡄⢹⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⣋⡿⠀⠀⠀⣀⡽⠀⠀⠀⠘⢈⠳⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣷⡆⢠⠖⠚⣇⠀⣙⡶⠄⠈⠰⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣼⠁⠐⣧⣾⡄⣄⠘⣆⡈⠷⠄⣤⣶⠈⢿⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⠋⠛⣦⣘⢿⣇⣿⣿⠉⠹⣗⠦⣈⠘⣾⡿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢱⡾⠛⣏⠿⠧⡀⠈⠳⣄⡙⠊⠉⠛⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣤⡤⣤⡴⠉⠀⠀⠈⢳⡀⠑⠦⡀⠈⠑⢄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⣠⣬⠷⢮⣙⣒⣤⡤⠀⠀⢹⡄⡄⢱⠀⠀⠈⢳⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠈⠛⠳⣄⠀⠀⠀⠀⠠⣌⣩⠿⠀⠒⣼⡇⠇⠈⠳⡄⠀⠈⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⢈⣹⣤⣖⣸⣍⣿⠽⠤⠒⠚⠋⠀⠀⠀⠀⢸⠀⠀⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⣠⠾⠛⠋⠉⠉⠀⠀⠀⠀⣠⡤⠂⠀⠀⢠⡀⢰⠋⠀⢠⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⢀⣠⠤⣶⡾⠅⠀⠀⠀⠀⠀⠀⠀⠀⠸⡏⢺⠀⠀⠀⢈⣇⠜⠃⠀⣾⡈⢳⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⢻⠇⡴⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣼⠋⠈⠀⠀⢠⠞⠋⠀⢀⡾⠁⠉⠀⢻⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⢠⣏⡼⠁⠀⠀⠀⢀⡤⠤⠔⠊⢉⣡⠼⠓⠀⠀⢀⣴⣋⣀⡠⠶⠻⣄⡀⠀⠀⠈⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⣸⡿⠁⢠⠔⠒⠚⢋⡤⠖⠊⢩⡟⠀⠀⢀⣠⠞⠋⠉⠁⠀⠀⠀⠀⠀⠉⢹⠀⠀⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀
⢼⢻⠇⡤⠇⠀⢀⣴⠋⠀⠀⠀⣼⣠⠴⠚⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⢧⣀⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠙⣿⡰⠂⠀⢠⣿⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⣿⡇⠀⠀⣏⢻⡀⢀⣠⠴⠛⠉⠓⠢⢄⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠈⢿⣄⡀⠘⢆⡙⠋⠀⢀⡠⠔⠦⠐⠒⣚⠙⣲⡦⠄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠙⢧⡀⠀⠈⠉⠉⠁⣀⠀⣀⡴⠚⠉⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠙⣶⣤⡀⠉⠘⠛⠻⣅⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠈⠳⡌⠁⠒⢄⠀⠈⠑⢢⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠈⠳⠤⣄⣁⣀⣀⣀⣛⣲⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⡀");
        creature = new Dragon();
        new Fight(player, creature);

        Console.WriteLine();
        Slow("you've slain the dragon and withheld some serious injuries but the village was saved");
        Slow(" the village faced many damages and casualities but it was finally saved");
        Slow("the eternal flame heat up the villge providing heat for everyone and allowed them to cook food, no more raw food and burning up the limited resources");
        Console.WriteLine();
        Slow("Congratulations you've beat the game", 50);
        Console.WriteLine();
        Console.WriteLine();
        Slow("Hi! Habib speaking, this was a short quick game I made to test my C#. I know a lot can be improved and added but it was a small project to test what I can do.", 40);
        Slow("THANKS FOR PLAYING!!!", 40);
        Console.WriteLine();

    } 
} 
