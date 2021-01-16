using MarsRover.Business.Action;
using MarsRover.Business.Command;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace MarsRover.UnitTests.Command
{
    [TestClass]
    public class SingleCommandInvokerTests
    {
        Mock<IActionInvoker> MActionInvoker = new Mock<IActionInvoker>();
        Mock<IActionInvoker> LActionInvoker = new Mock<IActionInvoker>();
        Mock<IActionInvoker> RActionInvoker = new Mock<IActionInvoker>();

        [TestMethod]
        public void Move_IfCommandNull_ThrowsException()
        {
            var instance = new SingleCommandInvoker(MActionInvoker.Object, LActionInvoker.Object, RActionInvoker.Object);
            Assert.ThrowsException<System.ArgumentNullException>(() => instance.Move(null, null));
        }


        [TestMethod]
        public void Move_IfCommandEmpty_ThrowsException()
        {
            var instance = new SingleCommandInvoker(MActionInvoker.Object, LActionInvoker.Object, RActionInvoker.Object);
            Assert.ThrowsException<System.Exception>(()=> instance.Move(string.Empty, null));
        }


        [TestMethod]
        public void Move_IfCommandUnKnown_ThrowsException()
        {
            var instance = new SingleCommandInvoker(MActionInvoker.Object, LActionInvoker.Object, RActionInvoker.Object);
            Assert.ThrowsException<System.Exception>(() => instance.Move("XYZ", null));
        }


        [TestMethod]
        public void Move_IfCommandM_CallMActionInvoker()
        {
            var instance = new SingleCommandInvoker(MActionInvoker.Object, LActionInvoker.Object, RActionInvoker.Object);
            instance.Move("M", null);

            MActionInvoker.Verify(x => x.Move(null), Times.Once);
            LActionInvoker.Verify(x => x.Move(null), Times.Never);
            RActionInvoker.Verify(x => x.Move(null), Times.Never);
        }

        [TestMethod]
        public void Move_IfCommandL_CallLActionInvoker()
        {
            var instance = new SingleCommandInvoker(MActionInvoker.Object, LActionInvoker.Object, RActionInvoker.Object);
            instance.Move("L", null);

            MActionInvoker.Verify(x => x.Move(null), Times.Never);
            LActionInvoker.Verify(x => x.Move(null), Times.Once);
            RActionInvoker.Verify(x => x.Move(null), Times.Never);
        }


        [TestMethod]
        public void Move_IfCommandR_CallRActionInvoker()
        {
            var instance = new SingleCommandInvoker(MActionInvoker.Object, LActionInvoker.Object, RActionInvoker.Object);
            instance.Move("R", null);

            MActionInvoker.Verify(x => x.Move(null), Times.Never);
            LActionInvoker.Verify(x => x.Move(null), Times.Never);
            RActionInvoker.Verify(x => x.Move(null), Times.Once);
        }
    }
}
