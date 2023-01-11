
using System.Collections.Generic;

namespace MoveMe
{
    public class Car:Vehicle
    {
        private List<Passenger> _passengers;

        public Car(string brand, List<Passenger> passengers = null):base(brand)
        {
            throw new System.NotImplementedException();
        }

        public List<Passenger> Passengers
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public void LoadPassenger(List<Passenger> passengers)
        {
            throw new System.NotImplementedException();
        }
    }
}
