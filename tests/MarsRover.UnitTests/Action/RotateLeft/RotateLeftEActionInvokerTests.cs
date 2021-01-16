using MarsRover.Business.Action.RotateLeft;
using MarsRover.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.UnitTests.Action.RotateLeft
{
    [TestClass]
    public class RotateLeftEActionInvokerTests
    {
        [TestMethod]
        public void Move_Always_DirectionN()
        {
            var instance = new RotateLeftEActionInvoker();
            var vehicleContet = new VehicleContext();

            instance.Move(vehicleContet);

            Assert.AreEqual(Direction.N, vehicleContet.Direction);
        }
    }
}
