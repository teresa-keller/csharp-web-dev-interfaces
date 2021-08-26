using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;
            List<Flavor> bonusFlavors = menu.Flavors;
            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.
            Console.WriteLine("Flavors:");
            foreach (Flavor flavor in availableFlavors)
            {
                Console.WriteLine(flavor.Name);
            }
            Console.WriteLine(" ");
            availableFlavors.Sort(new FlavorComparer());
            

            Console.WriteLine("Cones:");
            foreach (Cone cone in availableCones)
            {
                Console.WriteLine(cone.Name + ": " + cone.Cost);
            }
            
            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.
            Console.WriteLine(" ");
            availableCones.Sort(new ConeComparer());
            
            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.
            Console.WriteLine("Sorted Flavors:");
            foreach (Flavor flavor in availableFlavors)
            {
                Console.WriteLine(flavor.Name);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Sorted Cones:");
            foreach (Cone cone in availableCones)
            {
                Console.WriteLine(cone.Name + ": " +  string.Format("{0:C}", cone.Cost));
            }
            Console.WriteLine(" ");
            Console.WriteLine("Bonus Flavors:");
            foreach (Flavor bonusFlavor in bonusFlavors)
            {
                Console.WriteLine(bonusFlavor.Name + ": Allergen count - " + bonusFlavor.Allergens.Count);
            }
            bonusFlavors.Sort(new AllergenComparer());
            Console.WriteLine(" ");
            Console.WriteLine("Bonus Sorted Flavors:");
            foreach (Flavor bonusFlavor in bonusFlavors)
            {
                Console.WriteLine(bonusFlavor.Name + ": Allergen count - " + bonusFlavor.Allergens.Count);
            }
        }
    }
}
