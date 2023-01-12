
using System.Collections.Generic;

namespace MoveMe
{
    public class Car:Vehicle
    {
        private List<Passenger> _passengers;

        public Car(string brand, List<Passenger> passengers = null):base(brand)
        {
            _passengers = passengers;
        }

        public List<Passenger> Passengers
        {
            get
            {
                return _passengers;
            }
        }

        public void LoadPassenger(List<Passenger> passengers)
        {
            _passengers = passengers;
        }
    }
}
