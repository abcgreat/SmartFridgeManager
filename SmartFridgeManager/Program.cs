using System;

namespace SmartFridgeManager
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartFridgeManagerImpl fridge = new SmartFridgeManagerImpl();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("***** Initial Stocking *****");
            Console.ForegroundColor = ConsoleColor.White;

            fridge.handleItemAdded(1, "1", "bread", .7);            
            fridge.handleItemAdded(2, "2", "coffee", .6);
            fridge.handleItemAdded(3, "3", "onions", .3);
            fridge.handleItemAdded(3, "4", "avocados", .4);
            fridge.handleItemAdded(3, "5", "kale", .2);
            fridge.handleItemAdded(3, "6", "celery", .2);
            fridge.handleItemAdded(3, "7", "beets", .3);
            fridge.handleItemAdded(3, "8", "bell peppers", .3);        
            fridge.handleItemAdded(4, "9", "apples", .5);
            fridge.handleItemAdded(4, "10", "oranges", .3);
            fridge.handleItemAdded(4, "11", "strawberries", .5);
            fridge.handleItemAdded(4, "12", "bananas", .3);
            fridge.handleItemAdded(4, "13", "grapes", .4);
            fridge.handleItemAdded(4, "14", "water melons", .5);
            fridge.handleItemAdded(5, "15", "turkey", 1);
            fridge.handleItemAdded(5, "16", "pork", 1);
            fridge.handleItemAdded(5, "17", "chicken", .5);
            fridge.handleItemAdded(5, "18", "beef", 1);
            fridge.handleItemAdded(6, "19", "salmon", .3);
            fridge.handleItemAdded(7, "20", "butter", .2);
            fridge.handleItemAdded(8, "21", "cheese", .2);
            fridge.handleItemAdded(8, "22", "milk", .3);
            fridge.handleItemAdded(8, "23", "yogurt", .2);
            fridge.handleItemAdded(8, "24", "peanut butter", .2);
            fridge.handleItemAdded(9, "25", "fruit juice", .4);
            fridge.handleItemAdded(9, "26", "soy milk", .3);
            fridge.handleItemAdded(10, "27", "ketchup", .2);
            fridge.handleItemAdded(10, "28", "mustard", .3);
            fridge.handleItemAdded(11, "29", "baking soda", .4);
            
            PrintItemsInFridge(fridge, 1.0);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("***** Breakfast *****");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Remove bread");
            fridge.handleItemRemoved("1");
            Console.WriteLine("Remove butter");
            fridge.handleItemRemoved("20");
            Console.WriteLine("Remove milk");
            fridge.handleItemRemoved("22");

            PrintItemsInFridge(fridge, 1.0);

            Console.WriteLine("Added bread");
            fridge.handleItemAdded(1, "1", "bread", .5);
            Console.WriteLine("Added butter");
            fridge.handleItemAdded(8, "20", "butter", .1);
            Console.WriteLine("Added milk");
            fridge.handleItemAdded(8, "22", "milk", 0);
            
            PrintItemsInFridge(fridge, 1.0);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("***** Lunch *****");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Remove avocados");
            fridge.handleItemRemoved("4");
            Console.WriteLine("Remove kale");
            fridge.handleItemRemoved("5");
            Console.WriteLine("Remove celery");
            fridge.handleItemRemoved("6");
            Console.WriteLine("Remove bell peppers");
            fridge.handleItemRemoved("8");
            Console.WriteLine("Remove apples");
            fridge.handleItemRemoved("9");
            Console.WriteLine("Remove oranges");
            fridge.handleItemRemoved("10");
            Console.WriteLine("Remove strawberries");
            fridge.handleItemRemoved("11");
            Console.WriteLine("Remove bananas");
            fridge.handleItemRemoved("12");
            Console.WriteLine("Remove grapes");
            fridge.handleItemRemoved("13");
            Console.WriteLine("Remove bread");
            fridge.handleItemRemoved("1");

            Console.WriteLine("Added avocados");
            fridge.handleItemAdded(3, "4", "avocados", .2);
            Console.WriteLine("Added kale");
            fridge.handleItemAdded(3, "5", "kale", .1);
            Console.WriteLine("Added celery");
            fridge.handleItemAdded(3, "6", "celery", .1);
            Console.WriteLine("Added bell peppers");
            fridge.handleItemAdded(3, "8", "bell peppers", .1);
            Console.WriteLine("Added apples");
            fridge.handleItemAdded(4, "9", "apples", .3);
            Console.WriteLine("Added oranges");
            fridge.handleItemAdded(4, "10", "oranges", .1);
            Console.WriteLine("Added strawberries");
            fridge.handleItemAdded(4, "11", "strawberries", .3);
            Console.WriteLine("Added bananas");
            fridge.handleItemAdded(4, "12", "bananas", .1);
            Console.WriteLine("Added grapes");
            fridge.handleItemAdded(4, "13", "grapes", .2);
            Console.WriteLine("Added bread");
            fridge.handleItemAdded(1, "1", "bread", .3);

            PrintItemsInFridge(fridge, 1.0);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("***** Diner *****");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Remove bread");
            fridge.handleItemRemoved("1");
            Console.WriteLine("Remove onions");
            fridge.handleItemRemoved("3");
            Console.WriteLine("Remove bell peppers");
            fridge.handleItemRemoved("8");
            Console.WriteLine("Remove water melons");
            fridge.handleItemRemoved("14");
            Console.WriteLine("Remove chicken");
            fridge.handleItemRemoved("17");
            Console.WriteLine("Remove salmon");
            fridge.handleItemRemoved("19");
            Console.WriteLine("Remove butter");
            fridge.handleItemRemoved("20");
            Console.WriteLine("Remove cheese");
            fridge.handleItemRemoved("21");
            Console.WriteLine("Remove fruit juice");
            fridge.handleItemRemoved("25");
            Console.WriteLine("Remove mustard");
            fridge.handleItemRemoved("28");
            
            fridge.handleItemAdded(1, "1", "bread", .2);
            fridge.handleItemAdded(3, "3", "onions", .2);
            fridge.handleItemAdded(3, "8", "bell peppers", 0);
            fridge.handleItemAdded(4, "14", "water melons", .2);
            fridge.handleItemAdded(5, "17", "chicken", .1);
            fridge.handleItemAdded(6, "19", "salmon", .1);
            fridge.handleItemAdded(7, "20", "butter", .05);
            fridge.handleItemAdded(8, "21", "cheese", .1);
            fridge.handleItemAdded(9, "25", "fruit juice", .3);
            fridge.handleItemAdded(10, "28", "mustard", .25);

            PrintItemsInFridge(fridge, 1.0);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("***** Calculate fill factor for fruit: {0} ***** ", fridge.getFillFactor(4));
            Console.WriteLine("***** Removed items with itemType 4 *****");
            Console.ForegroundColor = ConsoleColor.White;
            fridge.forgetItem(4);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("***** Get items less than or equal to 30% full, cumulatively *****");
            PrintItemsInFridge(fridge, 0.3);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("***** Removed items with itemUUID 3 *****");
            fridge.handleItemRemoved("3");

            Console.WriteLine("***** Restock to 100 % *****");
            RestockFridge(fridge, 1.0);

            PrintItemsInFridge(fridge, 1.0);

            Console.ReadKey();
        }

        static void PrintItemsInFridge(SmartFridgeManagerImpl fridge, Double fillFactor)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("***** All Items in the fridge *****");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("--itemType--itemUUID----name-------------------------fillFactor");
            Console.WriteLine("---------------------------------------------------------------");
            foreach (Item item in fridge.getItems(fillFactor))
            {
                Console.WriteLine("{0} -- {1} -- {2} -- {3}", item.itemType.ToString().PadLeft(5,' ').PadRight(9,' '),
                    item.itemUUID.PadLeft(4, ' ').PadRight(7, ' '),
                    item.name.PadLeft(1, ' ').PadRight(25, ' '),
                    item.fillFactor);
            }
            Console.WriteLine("---------------------------------------------------------------");

            Console.ForegroundColor = ConsoleColor.White;
        }

        static void RestockFridge(SmartFridgeManagerImpl fridge, Double fillFactor)
        {
            foreach (Item item in fridge.getItems(fillFactor))
            {
                fridge.handleItemAdded(item.itemType, item.itemUUID, item.name, fillFactor);
            }
        }
    }
}
