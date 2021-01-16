using MarsRover.Domain;

namespace MarsRover.Business.Command
{
    public interface ICommandInvoker
    {
        void Move(string command, VehicleContext vehicleContext);
    }
}
