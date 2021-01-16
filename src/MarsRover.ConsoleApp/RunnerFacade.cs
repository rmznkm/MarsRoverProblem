using MarsRover.Business.Action;
using MarsRover.Business.Action.Move;
using MarsRover.Business.Action.RotateLeft;
using MarsRover.Business.Action.RotateRight;
using MarsRover.Business.Command;
using MarsRover.Domain;

namespace MarsRoverConsoleApp
{
    public class RunnerFacade
    {
        private readonly MultipleCommandInvoker commandInvoker;
        public RunnerFacade()
        {
            //It is possible with DI
            var rotateLeftActionInvoker = new ActionDeciderByPositionActionInvoker(
                   new RotateLeftNActionInvoker(),
                   new RotateLeftSActionInvoker(),
                   new RotateLeftWActionInvoker(),
                   new RotateLeftEActionInvoker()
               );

            var rotaeRightActionInvoker = new ActionDeciderByPositionActionInvoker(
                new RotateRightNActionInvoker(),
                new RotateRightSActionInvoker(),
                new RotateRightWActionInvoker(),
                new RotateRightEActionInvoker()
            );

            var moveActionInvoker = new ActionDeciderByPositionActionInvoker(
               new MoveNActionInvoker(),
               new MoveSActionInvoker(),
               new MoveWActionInvoker(),
               new MoveEActionInvoker()
            );

            var singleCommandInvoker = new SingleCommandInvoker(moveActionInvoker, rotateLeftActionInvoker, rotaeRightActionInvoker);
            commandInvoker = new MultipleCommandInvoker(singleCommandInvoker);
        }

        public void Run(string commnad, VehicleContext vehicleContext)
        {
            commandInvoker.Move(commnad, vehicleContext);
        }
    }
}
