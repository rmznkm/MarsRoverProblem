using MarsRover.Domain;

namespace MarsRover.Business.Action.RotateLeft
{
    public class RotateLeftSActionInvoker : IActionInvoker
    {
        public void Move(VehicleContext vehicleContext)
        {
            vehicleContext.Direction = Direction.E;
        }
    }
}
