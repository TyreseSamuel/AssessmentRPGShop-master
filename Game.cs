using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop3
{
    class Game
    {
        Player player = new Player();
        Shop shop = new Shop();

        public void Menu()
        {
            load();
            string choice = "";
            while (choice != "0")
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: Buy Items");
                Console.WriteLine("2: Sell Items");
                Console.WriteLine("3: View Items");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    player.buy(shop.sell(0));
                    player.buy(shop.sell(1));
                }
                else if (choice == "2")
                {
                    shop.buy(player.sell(0));
                    shop.buy(player.sell(1));
                }
                else if (choice == "3")
                {
                    player.PrintItem();
                }
            }
            save();
        }
        //this function should be called when the program begins
        //that way your shop will have items in it when the game begins
        public void load()
        {
            shop.load();
        }
        public void save()
        {
            shop.save();
            player.save();
        }
    }
}
