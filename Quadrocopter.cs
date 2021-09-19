using System;
using System.Collections.Generic;
using System.Threading;

namespace OTUS_Interfaces
{
    //4.Создать класс Quadcopter, наследующий IFlyingRobot и IChargeable.
    //В нём создать список компонентов List _components = new List { "rotor1", "rotor2", "rotor3", "rotor4" }
    //и возвращать его из метода GetComponents().
    class Quadrocopter : IFlyingRobot, IChargeable
    {
        private List<string> _components = new() { "rotor1", "rotor2", "rotor3", "rotor4" };

        public List<string> GetComponents()
        {
            return _components;
        }

        //5.Реализовать метод Charge() должен писать в консоль "Charging..." и через 3 секунды "Charged!".
        //Ожидание в 3 секунды реализовать через Thread.Sleep(3000).
        public void Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged!");

        }

        //6.Реализовать все методы интерфейсов в классах. До этого пункта достаточно "throw new NotImplementedException();"
        string IRobot.GetInfo()
        {
            return "Interface IRobot implementation";
        }

        string IRobot.GetRobotType()
        {
            return "Interface IRobot implementation";
        }

        string IChargeable.GetInfo()
        {
            return "Interface IChargeable implementation";
        }

        string IFlyingRobot.GetRobotType()
        {
            return "Interface IFlyingRobot implementation";
        }
    }
}
