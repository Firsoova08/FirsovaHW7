using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirsovaHW7
{
    internal class Car
    {
        public string Model;
        public int Speed;
        public int MaxSpeed;
        public Car(string model, int maxSpeed)
        {
            this.Model = model;
            this.MaxSpeed = maxSpeed;
            this.Speed = 0;
        }
            public void Accelerate(int delta) { 
        
            int newSpeed = this.Speed + delta;
            if (newSpeed > this.MaxSpeed)
            {
                this.Speed = this.MaxSpeed;
                Console.WriteLine($"Достигнута максимальная скорость: {this.MaxSpeed} км/ч");
            }
            else
            {
                this.Speed = newSpeed;
                Console.WriteLine($"Скорость увеличена до: {this.Speed} км/ч");
            }
            }

        public void Brake()
        {
            this.Speed = 0;
            Console.WriteLine("Автомобиль остановился");
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Модель: {this.Model}, Текущая скорость: {this.Speed} км/ч");
        }
    }
}
    
