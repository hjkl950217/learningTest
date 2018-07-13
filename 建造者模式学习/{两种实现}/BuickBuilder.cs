using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式
{

    /// <summary>
    /// 具体创建者，具体的车型的创建者，例如：别克
    /// </summary>
    public sealed class BuickBuilder : IBuilder
    {
        private readonly Car buickCar = new Car();

        public IBuilder UseCarDoor()
        {
            this.buickCar.Add("Buick's Door");
            return this;
        }

        public IBuilder UseCarWheel()
        {
            this.buickCar.Add("Buick's Wheel");
            return this;
        }

        public IBuilder UseCarEngine()
        {
            this.buickCar.Add("Buick's Engine");
            return this;
        }

        public Car BuildCar()
        {
            return this.buickCar;
        }
    }
}
