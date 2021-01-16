using MarsRover.Domain;

namespace MarsRover.Business.Action.RotateRight
{
    public class RotateRightEActionInvoker : IActionInvoker
    {
        public void Move(VehicleContext vehicleContext)
        {
            vehicleContext.Direction = Direction.S;
        }
    }
}
