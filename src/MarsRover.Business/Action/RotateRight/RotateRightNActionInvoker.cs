using MarsRover.Domain;

namespace MarsRover.Business.Action.RotateRight
{
    public class RotateRightNActionInvoker : IActionInvoker
    {
        public void Move(VehicleContext vehicleContext)
        {
            vehicleContext.Direction = Direction.E;
        }
    }
}
