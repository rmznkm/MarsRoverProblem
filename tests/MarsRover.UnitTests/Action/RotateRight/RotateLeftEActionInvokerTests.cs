using MarsRover.Business.Action.RotateRight;
using MarsRover.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.UnitTests.Action.RotateRight
{
    [TestClass]
    public class RotateRightEActionInvokerTests
    {
        [TestMethod]
        public void Move_Always_DirectionS()
        {
            var instance = new RotateRightEActionInvoker();
            var vehicleContet = new VehicleContext();

            instance.Move(vehicleContet);

            Assert.AreEqual(Direction.S, vehicleContet.Direction);
        }
    }
}
