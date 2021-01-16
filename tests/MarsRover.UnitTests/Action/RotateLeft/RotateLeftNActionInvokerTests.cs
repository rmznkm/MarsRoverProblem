using MarsRover.Business.Action.RotateLeft;
using MarsRover.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.UnitTests.Action.RotateLeft
{
    [TestClass]
    public class RotateLeftNActionInvokerTests
    {
        [TestMethod]
        public void Move_Always_DirectionW()
        {
            var instance = new RotateLeftNActionInvoker();
            var vehicleContet = new VehicleContext();

            instance.Move(vehicleContet);

            Assert.AreEqual(Direction.W, vehicleContet.Direction);
        }
    }
}
