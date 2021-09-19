using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_Interfaces
{
    //1.Создать интерфейс IRobot с публичным методами string GetInfo() и List GetComponents(),
    //а также string GetRobotType() с дефолтной реализацией, возвращающей значение "I am a simple robot.".
    interface IRobot
    {
        public string GetInfo()
        {
            return null;
        }

        public List<string> GetComponents()
        {
            return null;
        }

        public string GetRobotType()
        {
            return "I am a simple robot.";
        }
    }

    //2.Создать интерфейс IChargeable с методами void Charge() и string GetInfo().
    interface IChargeable
    {
        void Charge()
        {

        }

        string GetInfo()
        {
            return null;
        }
    }

    //3.Создать интерфейс IFlyingRobot как наследник IRobot с дефолтной реализацией GetRobotType(),
    //возвращающей строку "I am a flying robot.".
    interface IFlyingRobot : IRobot
    {
        public new string GetRobotType()
        {
            return "I am a flying robot.";
        }
    }
}
