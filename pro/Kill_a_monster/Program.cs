using System;
using System.Collections.Generic;

namespace Kill_a_monster
{
    class Program
    {

        public static bool running = true;
        static void Main(string[] args)
        {
            //namen van monsters
            List<Monster> monsters = new List<Monster>();

            monsters.Add(new Monster("guard", 100));
            monsters.Add(new Monster("demon", 100));
            monsters.Add(new Monster("king", 100));
            monsters.Add(new Monster("knight", 100));
            monsters.Add(new Monster("god", 100));
        
        
        while(running == true) {
            bool victory = true;
            Console.Clear();
                foreach (Monster m in monsters) {
                    m.writeNameAndHP();
                    if (m.hp > 0) {
                        victory = false;
                    }
                }
                if (victory == true) {
                Console.WriteLine("Congrats! You win!");
                    return;
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Type which monster you want to hit!");
                    Console.ResetColor();
                    string input = Console.ReadLine();


                foreach(Monster m in monsters) {
                    if (input == m.Naam ) {
                        m.hp -= 25;
                    }
                }
            }
        }
    }
}
