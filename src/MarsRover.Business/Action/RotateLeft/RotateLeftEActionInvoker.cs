using MarsRover.Domain;

namespace MarsRover.Business.Action.RotateLeft
{
    public class RotateLeftEActionInvoker : IActionInvoker
    {
        public void Move(VehicleContext vehicleContext)
        {
            vehicleContext.Direction = Direction.N;
        }
    }
}
