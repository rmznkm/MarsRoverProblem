using MarsRover.Domain;

namespace MarsRover.Business.Action.RotateLeft
{
    public class RotateLeftNActionInvoker : IActionInvoker
    {
        public void Move(VehicleContext vehicleContext)
        {
            vehicleContext.Direction = Direction.W;
        }
    }
}
