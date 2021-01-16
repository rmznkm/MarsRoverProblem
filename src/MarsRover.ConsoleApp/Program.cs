using MarsRover.Domain;
using System;
using System.Collections.Generic;

namespace MarsRoverConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            RunnerFacade runner = new RunnerFacade();

            var availablePosiiton = new Position { X = 5, Y = 5 };

            string command1 = "LMLMLMLMM";
            var currentPostion1 = new Position { X = 1, Y = 2 };
            var direction1 = Direction.N;
            var vehicleContext1 = new VehicleContext { AvailablePosition = availablePosiiton, CurrentPosition = currentPostion1, Direction = direction1 };

            string command2 = "MMRMMRMRRM";
            var currentPostion2 = new Position { X = 3, Y = 3 };
            var direction2 = Direction.E;
            var vehicleContext2 = new VehicleContext { AvailablePosition = availablePosiiton, CurrentPosition = currentPostion2, Direction = direction2 };


            var vehicleContexts = new List<VehicleContext> { vehicleContext1, vehicleContext2 };
            var commands = new List<string> { command1, command2 };

            for (int i = 0; i < vehicleContexts.Count; i++)
            {
                runner.Run(commands[i], vehicleContexts[i]);
                Console.WriteLine($"X{i}:{vehicleContexts[i].CurrentPosition.X} Y{i}:{vehicleContexts[i].CurrentPosition.Y} D{i}:{vehicleContexts[i].Direction}");
            }
        }
    }
}
