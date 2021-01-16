using MarsRover.Domain;

namespace MarsRover.Business.Action.RotateRight
{
    public class RotateRightWActionInvoker : IActionInvoker
    {
        public void Move(VehicleContext vehicleContext)
        {
            vehicleContext.Direction = Direction.N;
        }
    }
}
