using AbstractFactoryPattern.AbstractFactory;
using AbstractFactoryPattern.AbstractFactory.Factory;
using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Assets obj = AssetFactory.GetAssets("Trainee"); //Based on the Employee type Assests are given
        }
    }
}
