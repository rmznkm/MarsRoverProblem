using MarsRover.Domain;

namespace MarsRover.Business.Action
{
    public interface IActionInvoker
    {
        void Move(VehicleContext vehicleContext);
    }
}
