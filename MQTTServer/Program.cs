﻿using System;
using uPLibrary.Networking.M2Mqtt;

namespace MQTTServer
{
    class Program
    {
        static void Main(string[] args)
        {
            MqttBroker broker = new MqttBroker();
            
            broker.Start();
            Console.WriteLine("MQTT Broker started!");

            Console.ReadLine();

            broker.Stop();
            Console.WriteLine("Bye.");
        }

    }
}
