namespace MarsRover.Domain
{
    public class VehicleContext
    {
        public Position CurrentPosition { get; set; }
        public Position AvailablePosition { get; set; }
        public Direction Direction { get; set; } = Direction.N;
    }
}
