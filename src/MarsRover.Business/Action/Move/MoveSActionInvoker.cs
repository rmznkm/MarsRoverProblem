using MarsRover.Domain;

namespace MarsRover.Business.Action.Move
{
    public class MoveSActionInvoker : AbstractMoveActionInvoker
    {
        protected override bool IsAvailableNext(Position currentPosition, Position availablePosition)
        {
            if (currentPosition.Y <= 0)
            {
                return false;
            }
            return true;
        }

        protected override void MoveInternal(VehicleContext vehicleContext)
        {
            vehicleContext.CurrentPosition.Y--;
        }
    }
}
