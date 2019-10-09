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
        public double Depth {get; set;}
        private double Volume  
        // Volume should be read-only and should return width * depth * (3 * # of stories). Each story is 3 meters high.
        {
        get {
            return Width * Depth * (3 * Stories);
            }
        }
// Define a constructor method that accepts a single string argument - address - so that you can send as a parameter 
// when you create each instance with new Building("800 8th Street");.
// The constructor's logic should set the _address field's value to the argument value
        public Building(string address)
        {
            {
         _address = address;
            }
        }
        // Define a Construct() method. The method's logic should set the _dateConstructed field's value to DateTime.Now
        public void Construct() {
    _dateConstructed = DateTime.Now;
    }
    // Define a Purchase() method. The method should accept a single string argument of the name of the person purchasing a building. 
    // The method should take that string and assign it to the private _owner field.
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






