using MarsRover.Domain;

namespace MarsRover.Business.Action.RotateLeft
{
    public class RotateLeftWActionInvoker : IActionInvoker
    {
        public void Move(VehicleContext vehicleContext)
        {
            vehicleContext.Direction = Direction.S;
        }
    }
}
