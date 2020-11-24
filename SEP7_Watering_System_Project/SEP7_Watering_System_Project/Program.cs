using System;
using System.IO.Ports;

namespace ReadDataTest
{
    class Program
    {

        public static void Main(string[] args)
        {
            try
            {
                SerialPort port = new SerialPort();
                port.BaudRate = 9600;
                port.PortName = "COM1";
                port.Open();

                try
                {
                    while (true)
                    {
                        string s = port.ReadLine();
                        Console.WriteLine(s);
                        System.Threading.Thread.Sleep(500);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error reading the serial port");
                    Console.WriteLine(ex.ToString());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error opening the serial port");
                Console.WriteLine(ex.ToString());
            }

        }
    }
}

