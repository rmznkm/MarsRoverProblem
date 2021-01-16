using MarsRover.Domain;

namespace MarsRover.Business.Action.Move
{
    public class MoveNActionInvoker : AbstractMoveActionInvoker
    {
        protected override bool IsAvailableNext(Position currentPosition, Position availablePosition)
        {
            if (currentPosition.Y >= availablePosition.Y)
            {
                return false;
            }
            return true;
        }

        protected override void MoveInternal(VehicleContext vehicleContext)
        {
            vehicleContext.CurrentPosition.Y++;
        }
    }
}
