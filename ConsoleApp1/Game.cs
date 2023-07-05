using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Game
    {
        private string A;
        private string B;
        private string C;
        private string D;
        private int damage1;
        private int damage2;
        private int damage3;
        private int damage4;

        public void Tournament() // Podawanie imion dla bohaterów
        {
            Console.WriteLine("Podaj imię Bohatera A: ");
            A = Console.ReadLine();
            Console.WriteLine("Podaj imię Bohatera B: ");
            B = Console.ReadLine();
            Console.WriteLine("Podaj imię Bohatera C: ");
            C = Console.ReadLine();
            Console.WriteLine("Podaj imię Bohatera D: ");
            D = Console.ReadLine();
        }

        private void HeroA() // Bohater A
        {
            Console.WriteLine(" - Hey! " +
                " - My name is - " + A + ". I am the strongest warrior of the Kingdom! " +
                " - It's time for a battle! " +
                " - Ha-ha!" +
                "");
            Console.WriteLine("Autor: The " + A + " has 2 skills. First skill is Battle Hunger, that can give 1 more damage and the second one is Battle Call, that can dodge 1 damage from the enemies.");
        }

        private void HeroB() // Bohater B
        {
            Console.WriteLine("- Hi! My name is - " + B +
                "- I am the best Archer in the World!");
            Console.WriteLine("Autor: The " + B + " has 2 skills. First one is Arrow Rain, that gives him +1 to damage and the second one is PowerShot, that gives him +2 to damage.");
        }

        private void HeroC() // Bohater C
        {
            Console.WriteLine(" - Hello! - I am " + C + "!- I will smash all the enemies on my way! - I promised my family to protect the honor of our Kingdom!");
            Console.WriteLine("Autor: The" + C + " has 2 skills. One of them is Magic Chakra, which can freeze the enemy, that means he can dodge the attack! Also, he has a second skill, Ice Blast, that skill can deal critical +1 damage in 30%.");
        }

        private void HeroD() // Bohater D
        {
            Console.WriteLine(" - Greetings! My name is the " + D + " - If somebody stands on my way, I will CRUSH YOU DOWN...");
            Console.WriteLine("Autor:" + D + " has 2 skills. First one is Wraith Punch, that skill can make one +1 more damage to his attack. The second is SHIELD OF THE MASTER!!! That skill can dodge 3 damage from the other hero.");
        }

        private void Battle() // Początek bitwy
        {
            Console.WriteLine("Autor: In the left red corner is... The " + A + ". In the right blue corner is... The " + B + ". Applause for the 2 Heroes!");
            Console.WriteLine("3");
            Console.WriteLine("2!");
            Console.WriteLine("1!");
            Console.WriteLine("Fight!");
        }


        private void MatchAB() // Bitwa A z B
        {
            Random random = new Random();
            damage1 = random.Next(11);
            damage2 = random.Next(11);
            int battlehunger1 = random.Next(11);
            int battlecall1 = random.Next(11);
            int arrowrain1 = random.Next(11);
            int powershot1 = random.Next(11);

            Console.WriteLine("Damage of the first hero is: " + damage1);
            Console.WriteLine("Damage of the second hero is: " + damage2);

            if (battlehunger1 > 5)
            {
                Console.WriteLine("The hero in the red corner gives +1 damage.");
                damage1 += 1;
            }
            else
            {
                Console.WriteLine("The hero in the red corner didn't dodge the attack.");
            }

            if (battlecall1 > 4)
            {
                Console.WriteLine("The " + A + " dodged the attack, which gives him 1 more armor. So he dodged 1 damage.");
                damage2 -= 1;
            }
            else
            {
                Console.WriteLine("The " + A + " didn't dodge the damage.");
            }

            if (arrowrain1 > 4)
            {
                Console.WriteLine("The " + B + " provides +1 damage.");
                damage2 += 1;
            }
            else
            {
                Console.WriteLine("The " + B + " didn't give +1 damage.");
            }

            if (powershot1 > 4)
            {
                Console.WriteLine("The " + B + " makes +2 damage to his enemy.");
                damage2 += 2;
            }
            else
            {
                Console.WriteLine("The " + B + " doesn't make +2 damage to his enemy.");
            }

            if (damage1 > damage2)
            {
                Console.WriteLine("The hero " + A + " in the red corner won!");

                Console.WriteLine("Autor: In the left red corner is... The " + C + ". In the right blue corner is... The " + D + ". Applause for the 2 Heroes!");
                Console.WriteLine("3");
                Console.WriteLine("2!");
                Console.WriteLine("1!");
                Console.WriteLine("Fight!");
            }
            if (damage2 > damage1)
            {
                Console.WriteLine("The hero in the blue " + B + " corner won!");
                Console.WriteLine("Autor: In the left red corner is... The " + C + ". In the right blue corner is... The " + D + ". Applause for the 2 Heroes!");
                Console.WriteLine("3");
                Console.WriteLine("2!");
                Console.WriteLine("1!");
                Console.WriteLine("Fight!");
            }

        }

        private void MatchCD() // Bitwa C z D
        {
            Random random = new Random();
            damage3 = random.Next(11);
            damage4 = random.Next(11);
            int chakra1 = random.Next(11);
            int iceblast1 = random.Next(11);
            int punch1 = random.Next(11);
            int shield1 = random.Next(11);

            Console.WriteLine("Damage of the first hero is: " + damage3);
            Console.WriteLine("Damage of the second hero is: " + damage4);

            if (chakra1 > 5)
            {
                Console.WriteLine("The " + C + " dodged the attack!");
                damage4 = 0;
            }
            else
            {
                Console.WriteLine("The " + C + " didn't dodge the attack.");
            }

            if (iceblast1 > 6)
            {
                Console.WriteLine("The " + C + " gives +1 more damage.");
                damage3 += 1;
            }
            else
            {
                Console.WriteLine("The " + C + " doesn't give +1 damage.");
            }

            if (punch1 > 5)
            {
                Console.WriteLine("The " + D + " gives +1 more damage.");
                damage4 += 1;
            }
            else
            {
                Console.WriteLine("The " + D + " doesn't give +1 damage.");
            }

            if (shield1 > 3)
            {
                Console.WriteLine("The " + D + " SHIELD WORKED AND HE DODGED 3 DAMAGE!!!");
                damage3 -= 3;
            }
            else
            {
                Console.WriteLine(D + " Shield didn't work");
            }

            if (damage3 > damage4)
            {
                Console.WriteLine("The hero in the red corner " + C + " won! CONGRATULATIONS!!!");
            }
            else
            {
                Console.WriteLine("The hero in the blue corner " + D + " won! CONGRATULATIONS!!!");
            }
        }

        public void Result() // Rezultat główny
        {

        }

        public void secondround()
        {
            if (damage1 > damage2 && damage3 > damage4)
            {
                Console.WriteLine("The Fight will be between " + A + " and " + C + "!!!");

                Random random = new Random();
                int damage5 = random.Next(11);
                int damage6 = random.Next(11);
                int battlehunger1 = random.Next(11);
                int battlecall1 = random.Next(11);
                int chakra1 = random.Next(11);
                int iceblast1 = random.Next(11);

                Console.WriteLine("Damage of the first hero " + A + " is: " + damage5);
                Console.WriteLine("Damage of the second hero " + C + " is: " + damage6);

                if (battlehunger1 > 5)
                {
                    Console.WriteLine("The hero in the red corner gives +1 damage.");
                    damage5 += 1;
                }
                else
                {
                    Console.WriteLine("The hero in the red corner didn't dodge the attack.");
                }

                if (battlecall1 > 4)
                {
                    Console.WriteLine("The " + A + " dodged the attack, which gives him 1 more armor. So he dodged 1 damage.");
                    damage6 -= 1;
                }
                else
                {
                    Console.WriteLine("The " + A + " didn't dodge the damage.");
                }

                if (chakra1 > 5)
                {
                    Console.WriteLine("The " + C + " dodged the attack!");
                    damage5 = 0;
                }
                else
                {
                    Console.WriteLine("The " + C + " didn't dodge the attack.");
                }

                if (iceblast1 > 6)
                {
                    Console.WriteLine("The " + C + " gives +1 more damage.");
                    damage6 += 1;
                }
                else
                {
                    Console.WriteLine("The " + C + " doesn't give +1 damage.");
                }
                if (damage5 > damage6)
                {
                    Console.WriteLine("The winner is " + A + "!!!");
                }
                else
                {
                    Console.WriteLine("The winner is " + C + "!!!");
                }


            }
            if (damage2 > damage1 && damage3 > damage4)
            {
                Console.WriteLine("The fight will be between " + B + " and " + D + "!!!");

                Random random = new Random();
                int damage7 = random.Next(11);
                int damage8 = random.Next(11);
                int arrowrain1 = random.Next(11);
                int powershot1 = random.Next(11);
                int chakra1 = random.Next(11);
                int iceblast1 = random.Next(11);

                Console.WriteLine("Damage of the first hero " + B + " is: " + damage7);
                Console.WriteLine("Damage of the second hero " + C + " is: " + damage8);

                if (arrowrain1 > 4)
                {
                    Console.WriteLine("The hero in the red corner gives +1 damage.");
                    damage7 += 1;
                }
                else
                {
                    Console.WriteLine("The hero in the red corner didn't use his arrowrain.");
                }

                if (powershot1 > 4)
                {
                    Console.WriteLine("The " + B + " uses his Powershot, that gives him +2 of damage");
                    damage7 += 2;
                }
                else
                {
                    Console.WriteLine("The " + B + " didn't use his PowerShot.");
                }

                if (chakra1 > 5)
                {
                    Console.WriteLine("The " + C + " DODGED ATTACK!!!");
                    damage7 = 0;
                }
                else
                {
                    Console.WriteLine("The " + C + " didn't dodge the attack.");
                }

                if (iceblast1 > 6)
                {
                    Console.WriteLine("The " + C + " gives +1 more damage.");
                    damage8 += 1;
                }
                else
                {
                    Console.WriteLine("The " + C + " doesn't give +1 damage.");
                }
                if (damage7 > damage8)
                {
                    Console.WriteLine("The winner is " + A + "!!!");
                }
                else
                {
                    Console.WriteLine("The winner is " + C + "!!!");
                }

            }

            if (damage1 > damage2 && damage3 < damage4)
            {
                Console.WriteLine("The fight will be between " + A + " and " + D + "!!!");

                Random random = new Random();
                int damage9 = random.Next(11);
                int damage10 = random.Next(11);
                int battlehunger1 = random.Next(11);
                int battlecall1 = random.Next(11);
                int punch1 = random.Next(11);
                int shield1 = random.Next(11);

                Console.WriteLine("Damage of the first hero " + A + " is: " + damage9);
                Console.WriteLine("Damage of the second hero " + D + " is: " + damage10);

                if (battlehunger1 > 5)
                {
                    Console.WriteLine("The hero in the red corner gives +1 damage.");
                    damage9 += 1;
                }
                else
                {
                    Console.WriteLine("The hero in the red corner didn't dodge the attack.");
                }

                if (battlecall1 > 4)
                {
                    Console.WriteLine("The " + A + " dodged the attack, which gives him 1 more armor. So he dodged 1 damage.");
                    damage10 -= 1;
                }
                else
                {
                    Console.WriteLine("The " + A + " didn't dodge the damage.");
                }

                if (punch1 > 5)
                {
                    Console.WriteLine("The " + D + " used his PUNCH! That gives +1 to damage!");
                    damage10 += 1;
                }
                else
                {
                    Console.WriteLine("The " + D + " didn't use his punch.");
                }

                if (shield1 > 3)
                {
                    Console.WriteLine("The " + D + " USED HIS SHIELD!!! That gives him +3 armour.");
                    damage9 -= 3;
                }
                else
                {
                    Console.WriteLine("The " + D + " didn't use his shield.");
                }
                if (damage9 > damage10)
                {
                    Console.WriteLine("The winner is " + A + "!!!");
                }
                else
                {
                    Console.WriteLine("The winner is " + D + "!!!");
                }

            }

            if (damage2 > damage1 && damage3 > damage4)
            {
                Console.WriteLine("The fight will be between " + B + " and " + C + "!!!");

                Random random = new Random();
                int damage11 = random.Next(11);
                int damage12 = random.Next(11);
                int arrowrain1 = random.Next(11);
                int powershot1 = random.Next(11);
                int chakra1 = random.Next(11);
                int iceblast1 = random.Next(11);

                Console.WriteLine("Damage of the first hero " + B + " is: " + damage11);
                Console.WriteLine("Damage of the second hero " + C + " is: " + damage12);
                if (arrowrain1 > 4)
                {
                    Console.WriteLine("The hero in the red corner gives +1 damage.");
                    damage11 += 1;
                }
                else
                {
                    Console.WriteLine("The hero in the red corner didn't use his arrowrain.");
                }

                if (powershot1 > 4)
                {
                    Console.WriteLine("The " + B + " used his powershot that gives +2 to damage.");
                    damage12 += 2;
                }
                else
                {
                    Console.WriteLine("The " + B + " didn't use powershot.");
                }

                if (chakra1 > 5)
                {
                    Console.WriteLine("The " + C + " dodged the attack!");
                    damage11 = 0;
                }
                else
                {
                    Console.WriteLine("The " + C + " didn't dodge the attack.");
                }

                if (iceblast1 > 6)
                {
                    Console.WriteLine("The " + C + " gives +1 more damage.");
                    damage12 += 1;
                }
                else
                {
                    Console.WriteLine("The " + C + " doesn't give +1 damage.");
                }
                if (damage11 > damage12)
                {
                    Console.WriteLine("The winner is " + B + "!!!");
                }
                else
                {
                    Console.WriteLine("The winner is " + C + "!!!");
                }

            }

            if (damage2 > damage1 && damage4 > damage3)
            {
                Console.WriteLine("The fight will be between " + B + " and " + D + "!!!");

                Random random = new Random();
                int damage13 = random.Next(11);
                int damage14 = random.Next(11);
                int arrowrain1 = random.Next(11);
                int powershot1 = random.Next(11);
                int punch1 = random.Next(11);
                int shield1 = random.Next(11);

                Console.WriteLine("Damage of the first hero " + B + " is: " + damage13);
                Console.WriteLine("Damage of the second hero " + D + " is: " + damage14);
                if (arrowrain1 > 4)
                {
                    Console.WriteLine("The hero in the red corner gives +1 damage.");
                    damage13 += 1;
                }
                else
                {
                    Console.WriteLine("The hero in the red corner didn't dodge the attack.");
                }

                if (powershot1 > 4)
                {
                    Console.WriteLine("The " + B + " uses his powershot, that gives him +2 to damage");
                    damage14 += 2;
                }
                else
                {
                    Console.WriteLine("The " + B + " didn't use powershot.");
                }

                if (punch1 > 5)
                {
                    Console.WriteLine("The " + D + " uses his punch, that gives him +1 to damage.");
                    damage14 += 1;
                }
                else
                {
                    Console.WriteLine("The " + D + " didn't use his punch.");
                }

                if (shield1 > 3)
                {
                    Console.WriteLine("The " + D + " used his shield and blocked 3 damage.");
                    damage13 -= 3;
                }
                else
                {
                    Console.WriteLine("The " + D + " didn't use his shield.");
                }
                if (damage13 > damage14)
                {
                    Console.WriteLine("The winner is " + B + "!!!");
                }
                else
                {
                    Console.WriteLine("The winner is " + D + "!!!");
                }

            }
        }

        public void Fight()
        {
            Battle();
            HeroA();
            HeroB();
            MatchAB();
            HeroC();
            HeroD();
            MatchCD();
            Result();
            secondround();
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Tournament();
            game.Fight();
            game.Result();

            Console.ReadLine();
        }
    }
}
