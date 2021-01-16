using MarsRover.Domain;

namespace MarsRover.Business.Action.RotateRight
{
    public class RotateRightSActionInvoker : IActionInvoker
    {
        public void Move(VehicleContext vehicleContext)
        {
            vehicleContext.Direction = Direction.W;
        }
    }
}
