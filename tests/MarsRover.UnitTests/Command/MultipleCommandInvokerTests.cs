using MarsRover.Business.Command;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace MarsRover.UnitTests.Command
{
    [TestClass]
    public class MultipleCommandInvokerTests
    {
        Mock<ICommandInvoker> SingleCommandInvoker = new Mock<ICommandInvoker>();

        [TestMethod]
        public void Move_IfCommandNull_ThrowsException()
        {
            var instance = new MultipleCommandInvoker(SingleCommandInvoker.Object);
            Assert.ThrowsException<NullReferenceException>(() => instance.Move(null, null));
        }

        [TestMethod]
        public void Move_IfCommandEmpty_NotCallSingleInvoker()
        {
            var instance = new MultipleCommandInvoker(SingleCommandInvoker.Object);
            instance.Move(string.Empty, null);
            SingleCommandInvoker.Verify(x => x.Move(It.IsAny<string>(), null),Times.Never);
        }

        [TestMethod]
        public void Move_CallMove_CallSingleInvokerSameCount()
        {
            string command = "TESTCOMMAND";
            var instance = new MultipleCommandInvoker(SingleCommandInvoker.Object);
            instance.Move(command, null);
            SingleCommandInvoker.Verify(x => x.Move(It.IsAny<string>(), null), Times.AtLeast(command.Length));
            SingleCommandInvoker.Verify(x => x.Move(It.IsAny<string>(), null), Times.AtMost(command.Length));
        }
    }
}
