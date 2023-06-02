﻿using AbstractFactory.Interfaces;

namespace AbstractFactory.ConcreteImplementation
{
    public class Welder : IDoorFittingExpert
    {
        public void GetDescription()
        {
            Console.WriteLine("I can only fit iron doors");
        }
    }
}
