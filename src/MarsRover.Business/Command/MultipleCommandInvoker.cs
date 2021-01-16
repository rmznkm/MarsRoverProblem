using MarsRover.Domain;

namespace MarsRover.Business.Command
{
    public class MultipleCommandInvoker
    {
        private readonly ICommandInvoker singleCommandInvoker;

        public MultipleCommandInvoker(ICommandInvoker singleCommandInvoker) {
            this.singleCommandInvoker = singleCommandInvoker;
        }

        public void Move(string command, VehicleContext vehicleContext)
        {
            foreach (var item in command)
            {
                singleCommandInvoker.Move(item.ToString(), vehicleContext);
            }
        }
    }
}
