using MarsRover.Business.Action.RotateRight;
using MarsRover.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.UnitTests.Action.RotateRight
{
    [TestClass]
    public class RotateRightWActionInvokerTests
    {
        [TestMethod]
        public void Move_Always_DirectionN()
        {
            var instance = new RotateRightWActionInvoker();
            var vehicleContet = new VehicleContext();

            instance.Move(vehicleContet);

            Assert.AreEqual(Direction.N, vehicleContet.Direction);
        }
    }
}
