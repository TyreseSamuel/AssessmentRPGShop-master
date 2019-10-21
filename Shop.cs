using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
namespace Shop3
{
    class Shop 
    {
        public float gold = 0.00f;
        ArrayList Inventory = new ArrayList();
        
        public void buy(Item a)
        {
            if (gold > a.cost)
            {
                gold -= a.cost;
                Inventory.Add(a);
            }
        }
        public Item sell(int index)
        {
            Item item = Inventory[index] as Item;
            Inventory.Remove(index); 
            gold += item.cost;
            return item;
        }
        public void load()
        {
            StreamReader reader = new StreamReader("ShopItemList.txt");
            int ListLength;
            Int32.TryParse(reader.ReadLine(), out ListLength);
            string itemType;
            for (int i = 0; i < ListLength; i++)
            {
                itemType = reader.ReadLine();
                if (itemType == "Weapon")
                {
                    Weapon weapon = new Weapon();
                    weapon.typeName = itemType;
                    weapon.name = reader.ReadLine();
                    weapon.description = reader.ReadLine();
                    weapon.cost = Convert.ToInt32(reader.ReadLine());
                    weapon.attackModifier = Convert.ToInt32(reader.ReadLine());
                    Inventory.Add(weapon);
                }
                else if (itemType == "Potion")
                {
                    Potion potion = new Potion();
                    potion.typeName = itemType;
                    potion.name = reader.ReadLine();
                    potion.description = reader.ReadLine();
                    potion.cost = Convert.ToInt32(reader.ReadLine());
                    potion.statModifier = Convert.ToInt32(reader.ReadLine());
                    Inventory.Add(potion);
                }
            }
        }
        //this should save each the number of items, the type of the item, and all of the items attributes
        public void save()
        {
            StreamWriter writer = new StreamWriter("ShopItemList.txt");
            foreach (Item item in Inventory)
            {
                if(item.typeName == "Weapon")
                {
                    Weapon weapon = item as Weapon;
                    writer.WriteLine(weapon.typeName);
                    writer.WriteLine(weapon.name);
                    writer.WriteLine(weapon.description);
                    writer.WriteLine(weapon.attackModifier);
                    writer.WriteLine(weapon.cost);
                }
                else if(item.typeName == "Potion")
                {
                    Potion potion = item as Potion;
                    writer.WriteLine(potion.typeName);
                    writer.WriteLine(potion.name);
                    writer.WriteLine(potion.description);
                    writer.WriteLine(potion.statModifier);
                    writer.WriteLine(potion.cost);
                }
            }
        }
    }
}
//this is what is used to save
//Unlike the reader this writes data as a string to a text file
//                        this will error until you give a path(create a text file and put the name or location here)