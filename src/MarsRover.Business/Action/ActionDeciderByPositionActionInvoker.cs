using MarsRover.Domain;
using System.Collections.Generic;

namespace MarsRover.Business.Action
{
    public class ActionDeciderByPositionActionInvoker : IActionInvoker
    {
        private readonly IDictionary<Direction, IActionInvoker> actionInvokerMap = new Dictionary<Direction, IActionInvoker>();

        public ActionDeciderByPositionActionInvoker(IActionInvoker nActionInvoker,
            IActionInvoker sActionInvoker,
            IActionInvoker wActionInvoker,
            IActionInvoker eActionInvoker)
        {
            actionInvokerMap.Add(Direction.N, nActionInvoker);
            actionInvokerMap.Add(Direction.S, sActionInvoker);
            actionInvokerMap.Add(Direction.W, wActionInvoker);
            actionInvokerMap.Add(Direction.E, eActionInvoker);
        }

        public void Move(VehicleContext vehicleContext)
        {
            if (!actionInvokerMap.ContainsKey(vehicleContext.Direction))
            {
                throw new System.Exception($"Undefined direction case status:{vehicleContext.Direction}");
            }
            actionInvokerMap[vehicleContext.Direction].Move(vehicleContext);
        }
    }
}
