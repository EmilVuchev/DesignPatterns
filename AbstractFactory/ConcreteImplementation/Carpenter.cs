﻿using AbstractFactory.Interfaces;

namespace AbstractFactory.ConcreteImplementation
{
    internal class Carpenter : IDoorFittingExpert
    {
        public void GetDescription()
        {
            Console.WriteLine("I can only fit wooden doors");
        }
    }
}
