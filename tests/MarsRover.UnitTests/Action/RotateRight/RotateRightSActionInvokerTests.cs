using MarsRover.Business.Action.RotateRight;
using MarsRover.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.UnitTests.Action.RotateRight
{
    [TestClass]
    public class RotateRightSActionInvokerTests
    {
        [TestMethod]
        public void Move_Always_DirectionW()
        {
            var instance = new RotateRightSActionInvoker();
            var vehicleContet = new VehicleContext();

            instance.Move(vehicleContet);

            Assert.AreEqual(Direction.W, vehicleContet.Direction);
        }
    }
}
