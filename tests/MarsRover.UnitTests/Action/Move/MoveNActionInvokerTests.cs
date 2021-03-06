﻿using MarsRover.Business.Action.Move;
using MarsRover.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.UnitTests.Action.Move
{
    [TestClass]
    public class MoveNActionInvokerTests
    {
        [TestMethod]
        public void Move_IfHasNoAvailableY_ThrowsException()
        {
            var instance = new MoveNActionInvoker();

            var currentPosition = new Position { X = 0, Y = 0 };
            var availablePosition = new Position { X = 0, Y = 0 };
            var vehicleContet = new VehicleContext { AvailablePosition = availablePosition, CurrentPosition = currentPosition };

            Assert.ThrowsException<System.Exception>(() => instance.Move(vehicleContet));
        }

        [TestMethod]
        public void Move_IfHasAvailableY_YPlusOne()
        {
            var instance = new MoveNActionInvoker();

            var currentPosition = new Position { X = 0, Y = 0 };
            var availablePosition = new Position { X = 0, Y = 1 };
            var vehicleContet = new VehicleContext { AvailablePosition = availablePosition, CurrentPosition = currentPosition };
            instance.Move(vehicleContet);

            Assert.AreEqual(1, vehicleContet.CurrentPosition.Y);
        }
    }
}
