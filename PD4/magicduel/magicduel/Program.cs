using magicduel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magicduel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> players= new List<Player>();   
            List<Stats> skillset= new List<Stats>();

            while (true)
            {
                Console.Clear();
                string option = menu();
                if (option == "1")
                {
                    addPlayer(players);
                }
                else if (option == "2")
                {
                    addSkill(skillset);  
                }
                else if (option=="3")
                {
                    displayinfo(players);

                }
                else if (option=="4")
                {
                    learnskill(skillset, players);
                }
                else if (option == "5")
                {
                    Attack(players);
                }
                else  
                {
                    break;
                }
            }
        }
        static string menu()
        {
            Console.WriteLine("1.Add Player");
            Console.WriteLine("2.Add Skill Statistics");
            Console.WriteLine("3.Display player info");
            Console.WriteLine("4.Learn a Skill");
            Console.WriteLine("5.Attack");
            Console.WriteLine("6.Exit");
            Console.WriteLine();
            Console.WriteLine("Enter a option...");
            string option=Console.ReadLine();
            return option;
        }
        static void addPlayer(List<Player> players)
        {
            Player player = new Player();
            Console.WriteLine("Enter the name of the player: ");
            player.name=Console.ReadLine();
            Console.WriteLine("Enter the maximum health of the player: ");
            player.maxHealth=float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the energy of the player: ");
            player.energy = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the maximum energy of the player: ");
            player.maxEnergy = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the armour of the player: ");
            player.armour = float.Parse(Console.ReadLine());
            players.Add(player);
        }
        static void addSkill(List<Stats> skillset)
        {
            Stats skill = new Stats();
            Console.WriteLine("Enter the name of the skill: ");
            skill.name = Console.ReadLine();
            Console.WriteLine("Enter the damage of the skill: ");
            skill.damage = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the penetration of the skill: ");
            skill.penetration = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the healing of the skill: ");
            skill.heal = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the cost of the skill: ");
            skill.cost = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the description of the skill: ");
            skill.description = Console.ReadLine();
            skillset.Add(skill);
        }
        static void displayinfo(List<Player> players)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(players[i].name);
                Console.WriteLine(players[i].health);
                Console.WriteLine(players[i].energy);
                Console.WriteLine(players[i].armour);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static string Attack(List<Player> players)
        {
           Console.WriteLine("Enter the name of the who is attacking");
            String attacker = Console.ReadLine();

            Console.WriteLine("Enter the name of the target: ");
            string target= Console.ReadLine();

            for (int i = 0; i < players.Count; i++)
            {
                if (attacker == players[i].name)
                {
                    for (int j = 0; j < players.Count; j++)
                    {
                        if (target == players[j].name)
                        {
                            return players[i].attack(players[j]);
                            
                        }
                        else
                        {
                            return " ";
                        }
                    }

                }
                else
                {
                    return " ";
                }
            }
            return " ";
        }
        static void learnskill(List<Stats> skillset,List<Player> players)
        {
            Console.WriteLine("Enter the name of the skill: ");
            string name=Console.ReadLine();
            for (int i = 0; i < skillset.Count; i++)
            {
                if (name == skillset[i].name)
                {
                    Console.WriteLine("Enter the name of the Player: ");
                    string plname = Console.ReadLine();
                    for(int j = 0;j < players.Count; j++)
                    {
                        if(plname == players[j].name)
                        {
                            players[i].learnskill(skillset[i]);
                            Console.WriteLine("Skill has been added");
                            Console.ReadKey();
                        }
                    }
               }
            }
        }
    }
}
