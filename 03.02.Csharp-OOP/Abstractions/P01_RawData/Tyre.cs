﻿namespace P01_RawData
{
    public class Tyre
    {
        private int age;
        private double pressure;

        public Tyre(int age, double pressure)
        {
            this.age = age;
            this.pressure = pressure;
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public double Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }


    }
}