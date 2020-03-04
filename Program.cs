using System;

namespace Planner {
    class Program {
        static void Main (string[] args) {

            Building NSS = new Building ("301 Plus Park Ave") {
                Width = 250,
                Depth = 250,
                Stories = 5
            };

            NSS.Construct ();
            NSS.Purchase ("Steve");
            Console.WriteLine (NSS.ToString ());

            Building OldNSS = new Building ("500 Interstate Blvd S");
            OldNSS.Width = 150;
            OldNSS.Depth = 150;
            OldNSS.Stories = 3;

            OldNSS.Construct ();
            OldNSS.Purchase ("John");
            Console.WriteLine (OldNSS.ToString ());

            Building House = new Building ("1201 First Str") {
                Width = 100,
                Depth = 100,
                Stories = 1
            };

            House.Construct ();
            House.Purchase ("Mom");
            Console.WriteLine (House.ToString ());

        }
    }
}