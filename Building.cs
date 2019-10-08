using System;

namespace Planner
{
    class Building
    {
        public string _designer { get; set; }

        public DateTime _dateConstructed { get; set; }
        
        private string _address {get; set;}
       
        private string _owner { get; set; }

        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth 
        // Volume should be read-only and should return width * depth * (3 * # of stories). Each story is 3 meters high.
        {
        get {
            return Width * Depth * (3 * Stories);
            }
        }

        public Building(string address)
        {
            {
         _address = address;
            }
        }
        public void Construct() {
    _dateConstructed = DateTime.Now;
    }
    public void Purchase(string NameOfBuyer) {
        _owner = NameOfBuyer;
    }
public void Designer (string NameofDesigner) {
            _designer = NameofDesigner;
    }

    public void CubicMeters () {

    }

    //the call for each Console.WriteLine is a field or property named at the top of the file
    public void Description() {
        Console.WriteLine($"----------------------------");
        Console.WriteLine($"{_address}");
        Console.WriteLine($"{_dateConstructed}");
        Console.WriteLine($"Bought by {_owner}");
        Console.WriteLine($"Designed by {_designer}");
        Console.WriteLine($"Cubic Meters {Width * Depth * (3 * Stories)}");


    }

    }


}






