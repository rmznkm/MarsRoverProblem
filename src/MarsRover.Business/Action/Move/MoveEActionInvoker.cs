using MarsRover.Domain;

namespace MarsRover.Business.Action.Move
{
    public class MoveEActionInvoker : AbstractMoveActionInvoker
    {
        protected override bool IsAvailableNext(Position currentPosition, Position availablePosition)
        {
            if (currentPosition.X >= availablePosition.X)
            {
                return false;
            }
            return true;
        }

        protected override void MoveInternal(VehicleContext vehicleContext)
        {
            vehicleContext.CurrentPosition.X++;
        }
    }
}
