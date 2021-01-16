using MarsRover.Domain;

namespace MarsRover.Business.Action.Move
{
    public class MoveWActionInvoker : AbstractMoveActionInvoker
    {
        protected override bool IsAvailableNext(Position currentPosition, Position availablePosition)
        {
            if (currentPosition.X <= 0)
            {
                return false;
            }
            return true;
        }

        protected override void MoveInternal(VehicleContext vehicleContext)
        {
            vehicleContext.CurrentPosition.X--;
        }
    }
}
