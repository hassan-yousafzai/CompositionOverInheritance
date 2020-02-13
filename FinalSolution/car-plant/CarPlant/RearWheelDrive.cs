namespace CarPlant
{
    public class RearWheelDrive : IWheelDrive
    {
        private readonly IWheel _rearLeft;
        private readonly IWheel _rearRight;

        public RearWheelDrive(IWheel rearLeft, IWheel rearRight)
        {
            _rearLeft = rearLeft;
            _rearRight = rearRight;
        }

        public void TurnLeft(int degrees)
        {
            _rearLeft.TurnLeft(degrees);
            _rearRight.TurnLeft(degrees);
        }

        public void TurnRight(int degrees)
        {
            _rearLeft.TurnRight(degrees);
            _rearRight.TurnRight(degrees);
        }
    }
}