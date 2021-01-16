using MarsRover.Business.Action.Move;
using MarsRover.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.UnitTests.Action.Move
{
    [TestClass]
    public class MoveEActionInvokerTests
    {
        [TestMethod]
        public void Move_IfHasNoAvailableX_ThrowsException()
        {
            var instance = new MoveEActionInvoker();

            var currentPosition = new Position { X = 0, Y = 0 };
            var availablePosition = new Position { X = 0, Y = 0 };
            var vehicleContet = new VehicleContext { AvailablePosition = availablePosition, CurrentPosition = currentPosition };

            Assert.ThrowsException<System.Exception>(() => instance.Move(vehicleContet));
        }

        [TestMethod]
        public void Move_IfHasAvailableX_XPlusOne()
        {
            var instance = new MoveEActionInvoker();

            var currentPosition = new Position { X = 0, Y = 0 };
            var availablePosition = new Position { X = 1, Y = 0 };
            var vehicleContet = new VehicleContext { AvailablePosition = availablePosition, CurrentPosition = currentPosition };
            instance.Move(vehicleContet);

            Assert.AreEqual(1, vehicleContet.CurrentPosition.X);
        }
    }
}
