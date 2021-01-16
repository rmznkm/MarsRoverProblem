using MarsRover.Business.Action;
using MarsRover.Domain;
using System.Collections.Generic;

namespace MarsRover.Business.Command
{
    public class SingleCommandInvoker : ICommandInvoker
    {
        private readonly IDictionary<string, IActionInvoker> actionInvokerMap = new Dictionary<string, IActionInvoker>();

        public SingleCommandInvoker(IActionInvoker moveActionInvoker,
            IActionInvoker rotateLeftActionInvoker,
            IActionInvoker rotateRightInvoker)
        {

            actionInvokerMap.Add("M", moveActionInvoker);
            actionInvokerMap.Add("L", rotateLeftActionInvoker);
            actionInvokerMap.Add("R", rotateRightInvoker);
        }

        public void Move(string command, VehicleContext vehicleContext)
        {
            if (!actionInvokerMap.ContainsKey(command))
            {
                throw new System.Exception($"Unknown commmand:{command}");
            }
            actionInvokerMap[command].Move(vehicleContext);
        }
    }
}
