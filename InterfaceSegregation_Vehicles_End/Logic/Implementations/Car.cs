﻿using System;
using InterfaceSegregation_Vehicles_End.Logic.Contracts;

namespace InterfaceSegregation_Vehicles_End.Logic.Implementations
{
    public class Car : IIdentifiableVehicle, IDrivable
    {
        public string LicencePlate { get; private set; }
        public int Speed { get; private set; }
        public Coordinate3D CurrentLocation { get; private set; }

        public void IncreaseSpeedBy(int value)
        {
            Speed += value;
        }

        public void DecreaseSpeedBy(int value)
        {
            Speed -= value;
        }

        public void DriveTo(float latitude, float longitude)
        {
            // TODO: implement math calculation for the car to go 
            // from current location to new location, using the current speed
            CurrentLocation = new Coordinate3D(latitude, longitude, CurrentLocation.Altitude);
        }

        public void RollWindowsDown()
        {
            Console.WriteLine("Car.RollWindowsDown");
        }

        public Car(string licencePlate, float latitude, float longitude)
        {
            this.LicencePlate = licencePlate;
            this.CurrentLocation = new Coordinate3D(latitude, longitude, 0);
        }
    }
}
