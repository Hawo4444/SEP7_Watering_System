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


                        string[] data = s.Split(',');
                       
                        double b, d, e;
                        
                       double.TryParse(data[0], out b);
                       double.TryParse(data[1], out d);
                       double.TryParse(data[1], out e);


                        Console.WriteLine("b = " + b);
                        Console.WriteLine("d = " + d);
                        Console.WriteLine("e = " + e);
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

