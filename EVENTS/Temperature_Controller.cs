using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVENTS
{
    public delegate void TemperatureChangeHandler(string message);

    public class TemperatureMonitor
    {
        public event TemperatureChangeHandler OnTemperatureChange;

        private int _temperature;
        

        public int Temperature
        {
            get
            {
                return _temperature;
            }

            set
            {
                _temperature = value;

                if(_temperature >35)
                {
                    //Raise EVENT!!
                    RaiseTemperatureChangeEvent("Temperature is above threshold");
                }
            }
        }

        protected virtual void RaiseTemperatureChangeEvent(string message)
        {
            OnTemperatureChange?.Invoke(message);
        }
    }


    public class TemperatueAlert 
    {
        public void OnTemperatureChange(string message)
        {
            Console.WriteLine("Alert: "+message);
        }
    }
    internal class Temperature_Controller
    {
        static void Main(string[] args)
        {
            TemperatureMonitor monitor = new TemperatureMonitor();  
            TemperatueAlert alert = new TemperatueAlert();

            monitor.OnTemperatureChange += alert.OnTemperatureChange;

            monitor.Temperature = 20;
            Console.WriteLine("Please enter the temperature");
            monitor.Temperature=int.Parse(Console.ReadLine());
        }
    }
}
