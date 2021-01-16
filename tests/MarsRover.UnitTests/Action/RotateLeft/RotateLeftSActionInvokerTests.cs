using MarsRover.Business.Action.RotateLeft;
using MarsRover.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.UnitTests.Action.RotateLeft
{
    [TestClass]
    public class RotateLeftSActionInvokerTests
    {
        [TestMethod]
        public void Move_Always_DirectionE()
        {
            var instance = new RotateLeftSActionInvoker();
            var vehicleContet = new VehicleContext();

            instance.Move(vehicleContet);

            Assert.AreEqual(Direction.E, vehicleContet.Direction);
        }
    }
}
