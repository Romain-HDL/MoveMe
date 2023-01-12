using System;

namespace MoveMe
{
    public class Passenger : Person
    {
        private readonly string _cityOfDestination;
        
        public Passenger(string name, string destinationCity):base(name)
        {
            _cityOfDestination = destinationCity;
        }

        public string CityOfDestination
        {
            get
            {
                return _cityOfDestination;
            }
        }

        public string LookLandscap() 
        {
            return "Je profite du paysage";
        }
    }
}
