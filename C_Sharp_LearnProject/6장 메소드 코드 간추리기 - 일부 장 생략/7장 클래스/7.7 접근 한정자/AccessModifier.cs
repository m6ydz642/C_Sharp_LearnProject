using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier
{
  class WaterHeater
    {
        protected int temperature;

        public void Setemperature(int temperature)
        {
            if (temperature < -5 || temperature > 42)
            {
                throw new Exception("Out of temperature range");
            }
            this.temperature = temperature;
        }

        internal void TurnOnWater()
        {
            Console.WriteLine($"Turn on water : {temperature}");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {

            try
            {
                WaterHeater heater = new WaterHeater();
                heater.Setemperature(20);
                heater.TurnOnWater();

                heater.Setemperature(-2);
                heater.TurnOnWater();

                heater.Setemperature(50); // 위의 Setemperature 에 if문에 조건에 해당되므로 예외발생
                heater.TurnOnWater();
            }catch(Exception e)
            {
                Console.WriteLine("e message : {0}", e.Message);
            }

        }
    }

    
}
