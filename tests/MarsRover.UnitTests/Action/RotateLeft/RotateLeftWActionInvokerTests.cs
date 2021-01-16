using MarsRover.Business.Action.RotateLeft;
using MarsRover.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.UnitTests.Action.RotateLeft
{
    [TestClass]
    public class RotateLeftWActionInvokerTests
    {
        [TestMethod]
        public void Move_Always_DirectionS()
        {
            var instance = new RotateLeftWActionInvoker();
            var vehicleContet = new VehicleContext();

            instance.Move(vehicleContet);

            Assert.AreEqual(Direction.S, vehicleContet.Direction);
        }
    }
}
