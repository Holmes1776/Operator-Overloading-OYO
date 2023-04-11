using System.Diagnostics;

namespace yesToDonuts
{
    public class I_Like_Donuts
    {
        public int donut { get; set; }
        public string type { get; set; }

        // ++ -- 
        public static I_Like_Donuts operator ++(I_Like_Donuts item)
        {
            item.donut++;
            return item;
        }
        public static I_Like_Donuts operator --(I_Like_Donuts item)
        {
            item.donut--;
            return item;
        }

        // == !=
        public static bool operator ==(I_Like_Donuts left, I_Like_Donuts right)
        {
            bool condition = false;
            if (left.donut == right.donut)
            {
                condition = true;
            }
            return condition;
        }
        public static bool operator !=(I_Like_Donuts left, I_Like_Donuts right)
        {
            bool condition = false;
            if (left.donut != right.donut)
            {
                condition = true;
            }
            return condition;
        }

        // * /
        public static I_Like_Donuts operator *(I_Like_Donuts left, I_Like_Donuts right)
        {
            I_Like_Donuts item = new I_Like_Donuts();
            item = left * right;
            return item;
        }
        public static I_Like_Donuts operator /(I_Like_Donuts left, I_Like_Donuts right)
        {
            I_Like_Donuts item = new I_Like_Donuts();
            item = left / right;
            return item;
        }

        static void Main(string[] args)
        {
            Random r = new Random();
            I_Like_Donuts[] donuts = new I_Like_Donuts[10];
            Console.Write("Original Number of donuts for each person: ");
            for (int i = 0; i < donuts.Length; i++)
            {
                donuts[i] = new I_Like_Donuts();
                donuts[i].donut = r.Next(1, 20);
                Console.Write(" " + donuts[i].donut);
            }

            donuts[1].type = "Plain";
            donuts[2].type = "Creme Filled";
            donuts[3].type = "Cinnimon";
            donuts[4].type = "Chocolate";
            donuts[5].type = "Powdered Sugar";
            donuts[6].type = "Cake";
            donuts[7].type = "Donut Hole";
            donuts[8].type = "Glazed";
            donuts[9].type = "Pink";
            donuts[0].type = "Sprinkled";

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("New Numbers after eating one or getting one donut: ");
            for (int i = 0; i < donuts.Length; i++)
            {
                if (donuts[i].donut % 2 == 0)
                {
                    donuts[i].donut++;
                }
                else
                {
                    donuts[i].donut--;
                }
                Console.Write(" " + donuts[i].donut);
            }
            Console.WriteLine();
            Console.WriteLine();

            I_Like_Donuts numToAdd = new I_Like_Donuts();
            numToAdd.donut = r.Next(1, 20);
            Console.Write($"They all got {numToAdd.donut}x extra donuts: ");

            for (int i = 0; i < donuts.Length; i++)
            {
                donuts[i].donut *= numToAdd.donut;
                Console.Write($"{donuts[i].donut} ");
            }

            Console.WriteLine();
            Console.WriteLine();

            I_Like_Donuts numToSub = new I_Like_Donuts();
            numToSub.donut = r.Next(1, 20);
            Console.Write($"They all ate donuts till they have 1/{numToSub.donut} remaining donuts:");

            for (int i = 0; i < donuts.Length; i++)
            {
                donuts[i].donut /= numToSub.donut;
                Console.Write($" {donuts[i].donut} ");
            }

            Console.WriteLine();
            Console.WriteLine();

            I_Like_Donuts Compare = new I_Like_Donuts();
            Compare.donut = r.Next(1, 50);
            Console.WriteLine($"The Magic Number of Donuts is {Compare.donut}:");

            for (int i = 0; i < donuts.Length; i++)
            {
                bool equal = donuts[i].donut == Compare.donut;
                bool inequal = donuts[i].donut != Compare.donut;
                if (equal)
                {
                    Console.WriteLine($"Person {i + 1}'s donut count of donut type {donuts[i].type} is equal to {Compare.donut}. They win all the donuts");
                }
                else if (inequal)
                {
                    Console.WriteLine($"Person {i + 1}'s donut count of donut type {donuts[i].type} isn't equal to {Compare.donut}.");
                }
                else
                {
                    Console.WriteLine("Error, no donuts");
                }
            }
        }
    }
}