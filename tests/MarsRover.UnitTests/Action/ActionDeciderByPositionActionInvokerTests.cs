using MarsRover.Business.Action;
using MarsRover.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace MarsRover.UnitTests.Action
{
    [TestClass]
    public class ActionDeciderByPositionActionInvokerTests
    {
        Mock<IActionInvoker> NActionInvoker = new Mock<IActionInvoker>();
        Mock<IActionInvoker> SActionInvoker = new Mock<IActionInvoker>();
        Mock<IActionInvoker> WActionInvoker = new Mock<IActionInvoker>();
        Mock<IActionInvoker> EActionInvoker = new Mock<IActionInvoker>();

        [TestMethod]
        public void Move_IfDirectionN_CallNActionInvoker()
        {
            var instance = new ActionDeciderByPositionActionInvoker(NActionInvoker.Object, SActionInvoker.Object, WActionInvoker.Object, EActionInvoker.Object);
            var vehicleContext = new VehicleContext { Direction = Direction.N };
            instance.Move(vehicleContext);

            NActionInvoker.Verify(x => x.Move(vehicleContext), Times.Once);
            SActionInvoker.Verify(x => x.Move(vehicleContext), Times.Never);
            WActionInvoker.Verify(x => x.Move(vehicleContext), Times.Never);
            EActionInvoker.Verify(x => x.Move(vehicleContext), Times.Never);
        }

        [TestMethod]
        public void Move_IfDirectionS_CallSActionInvoker()
        {
            var instance = new ActionDeciderByPositionActionInvoker(NActionInvoker.Object, SActionInvoker.Object, WActionInvoker.Object, EActionInvoker.Object);
            var vehicleContext = new VehicleContext { Direction = Direction.S };
            instance.Move(vehicleContext);

            NActionInvoker.Verify(x => x.Move(vehicleContext), Times.Never);
            SActionInvoker.Verify(x => x.Move(vehicleContext), Times.Once);
            WActionInvoker.Verify(x => x.Move(vehicleContext), Times.Never);
            EActionInvoker.Verify(x => x.Move(vehicleContext), Times.Never);
        }

        [TestMethod]
        public void Move_IfDirectionE_CallEActionInvoker()
        {
            var instance = new ActionDeciderByPositionActionInvoker(NActionInvoker.Object, SActionInvoker.Object, WActionInvoker.Object, EActionInvoker.Object);
            var vehicleContext = new VehicleContext { Direction = Direction.E };
            instance.Move(vehicleContext);

            NActionInvoker.Verify(x => x.Move(vehicleContext), Times.Never);
            SActionInvoker.Verify(x => x.Move(vehicleContext), Times.Never);
            WActionInvoker.Verify(x => x.Move(vehicleContext), Times.Never);
            EActionInvoker.Verify(x => x.Move(vehicleContext), Times.Once);
        }

        [TestMethod]
        public void Move_IfDirectionW_CallWActionInvoker()
        {
            var instance = new ActionDeciderByPositionActionInvoker(NActionInvoker.Object, SActionInvoker.Object, WActionInvoker.Object, EActionInvoker.Object);
            var vehicleContext = new VehicleContext { Direction = Direction.W };
            instance.Move(vehicleContext);

            NActionInvoker.Verify(x => x.Move(vehicleContext), Times.Never);
            SActionInvoker.Verify(x => x.Move(vehicleContext), Times.Never);
            WActionInvoker.Verify(x => x.Move(vehicleContext), Times.Once);
            EActionInvoker.Verify(x => x.Move(vehicleContext), Times.Never);
        }
    }
}
