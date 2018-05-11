﻿using System;
using System.Threading;
using BenchmarkDotNet.Running;
using MQTTnet.Diagnostics;

namespace MQTTnet.Benchmarks
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"MQTTnet - BenchmarkApp.{TargetFrameworkInfoProvider.TargetFramework}");
            Console.WriteLine("1 = MessageProcessingBenchmark");
            Console.WriteLine("2 = SerializerBenchmark");

            var pressedKey = Console.ReadKey(true);
            switch (pressedKey.KeyChar)
            {
                case '1':
                    BenchmarkRunner.Run<MessageProcessingBenchmark>();
                    break;
                case '2':
                    BenchmarkRunner.Run<SerializerBenchmark>();
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }
    }
}
