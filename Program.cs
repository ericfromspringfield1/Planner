using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            City Megalopis = new City ("Megalopis", 1985);
            Megalopis.mayor = "Robert Pattinson";


            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            {
                FiveOneTwoEigth.Width = 800;
                FiveOneTwoEigth.Depth = 400;
                FiveOneTwoEigth.Stories = 6;
                FiveOneTwoEigth.Construct();
                FiveOneTwoEigth.Purchase("Michael");
                FiveOneTwoEigth.Designer("TurdBoi");
                FiveOneTwoEigth.Description();
                Megalopis.Buildings.Add(FiveOneTwoEigth);

            }

            Building ThreeTwoOne = new Building("321 Bowwood Drive");
            {
                ThreeTwoOne.Width = 600;
                ThreeTwoOne.Depth = 200;
                ThreeTwoOne.Stories = 2;
                ThreeTwoOne.Construct();
                ThreeTwoOne.Purchase("Ryan Gosling");
                ThreeTwoOne.Designer("Jakey G");
                ThreeTwoOne.Description();
                Megalopis.Buildings.Add(ThreeTwoOne);
            }
            Building ThreeFiveOneZero = new Building("3510 Omega Drive");

                ThreeFiveOneZero.Width = 700;
                ThreeFiveOneZero.Depth = 300;
                ThreeFiveOneZero.Stories = 1;
                ThreeFiveOneZero.Construct();
                ThreeFiveOneZero.Purchase("Joaquin Phoenix");
                ThreeFiveOneZero.Designer("Leonardo DeVinci");
                ThreeFiveOneZero.Description();
                Megalopis.Buildings.Add(ThreeFiveOneZero);

                foreach (Building building in Megalopis.Buildings)
            {
                building.Description();
            }

        }




    }
}