using System;

namespace 建造者模式
{
    /// <summary>
    /// 具体创建者，具体的车型的创建者，例如：奥迪
    /// </summary>
    public sealed class AoDiBuilder : IBuilder
    {
        private readonly Car aoDiCar = new Car();

        private void UsePartBase(string partName,string part = null)
        {
            if(part == null)
            {
                part = $"Default {partName}";
            }

            this.aoDiCar.Add(partName,part);
        }

        public IBuilder UseCarDoor(string part = null)
        {
            this.UsePartBase("Door",part);
            return this;
        }

        public IBuilder UseCarWheel(string part = null)
        {
            this.UsePartBase("Wheel",part);
            return this;
        }

        public IBuilder UseCarEngine(string part = null)
        {
            this.UsePartBase("Engine",part);
            return this;
        }

        public IBuilder UseOtherPart(string partName,string part)
        {
            this.aoDiCar.Add(partName,part);
            return this;
        }

        public Car BuildCar()
        {
            Console.WriteLine("汽车开始在组装.......");
            Console.WriteLine("汽车组装好了");
            return this.aoDiCar;
        }
    }
}