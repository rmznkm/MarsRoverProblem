using MarsRover.Business.Action.RotateRight;
using MarsRover.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.UnitTests.Action.RotateRight
{
    [TestClass]
    public class RotateRightNActionInvokerTests
    {
        [TestMethod]
        public void Move_Always_DirectionE()
        {
            var instance = new RotateRightNActionInvoker();
            var vehicleContet = new VehicleContext();

            instance.Move(vehicleContet);

            Assert.AreEqual(Direction.E, vehicleContet.Direction);
        }
    }
}
