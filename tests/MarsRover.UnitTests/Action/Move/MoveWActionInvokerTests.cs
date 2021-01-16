using MarsRover.Business.Action.Move;
using MarsRover.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.UnitTests.Action.Move
{
    [TestClass]
    public class MoveWActionInvokerTests
    {
        [TestMethod]
        public void Move_IfHasNoAvailableX_ThrowsException()
        {
            var instance = new MoveWActionInvoker();

            var currentPosition = new Position { X = 0, Y = 0 };
            var availablePosition = new Position { X = 0, Y = 0 };
            var vehicleContet = new VehicleContext { AvailablePosition = availablePosition, CurrentPosition = currentPosition };

            Assert.ThrowsException<System.Exception>(() => instance.Move(vehicleContet));
        }

        [TestMethod]
        public void Move_IfHasAvailableX_XMinesOne()
        {
            var instance = new MoveWActionInvoker();

            var currentPosition = new Position { X = 1, Y = 0 };
            var availablePosition = new Position { X = 1, Y = 0 };
            var vehicleContet = new VehicleContext { AvailablePosition = availablePosition, CurrentPosition = currentPosition };
            instance.Move(vehicleContet);

            Assert.AreEqual(0, vehicleContet.CurrentPosition.X);
        }
    }
}
