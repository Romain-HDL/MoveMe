using System;

namespace MoveMe
{
    public class Vehicle : IVehicle
    {
        private string _brand = "";
        private bool _engineState = false;

        public Vehicle(string brand)
        {
            throw new NotImplementedException();
        }

        public string Brand
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Boolean IsEngineStarted
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void StartEngine()
        {
            throw new NotImplementedException();
        }

        public void StopEngine()
        {
            throw new NotImplementedException();
        }

        public class VehicleException : Exception { }

        public class MotorStartException : VehicleException { };
    }
}
