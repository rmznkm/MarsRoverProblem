using MarsRover.Domain;

namespace MarsRover.Business.Action.Move
{
    public abstract class AbstractMoveActionInvoker : IActionInvoker
    {
        public void Move(VehicleContext vehicleContext)
        {
            if (IsAvailableNext(vehicleContext.CurrentPosition, vehicleContext.AvailablePosition))
            {
                MoveInternal(vehicleContext);
            }
            else
            {
                throw new System.Exception($"{this.GetType()} Over limit movement." +
                    $"Current Position: {vehicleContext.CurrentPosition.X} {vehicleContext.CurrentPosition.Y}." +
                    $"Available Position: {vehicleContext.AvailablePosition.X} {vehicleContext.AvailablePosition.Y}");
            }
        }

        protected abstract bool IsAvailableNext(Position currentPosition, Position availablePosition);

        protected abstract void MoveInternal(VehicleContext vehicleContext);
    }
}
