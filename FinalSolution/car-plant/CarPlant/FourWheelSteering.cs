namespace CarPlant
{
    public class FourWheelSteering : IWheelDrive
    {
        private readonly IWheel _frontLeft;
        private readonly IWheel _frontRight;
        private readonly IWheel _rearLeft;
        private readonly IWheel _rearRight;

        public FourWheelSteering(IWheel frontLeft, IWheel frontRight, IWheel rearLeft, IWheel rearRight)
        {
            _frontLeft = frontLeft;
            _frontRight = frontRight;
            _rearLeft = rearLeft;
            _rearRight = rearRight;
        }
        
        public void TurnLeft(int degrees)
        {
            _frontLeft.TurnLeft(degrees);
            _frontRight.TurnLeft(degrees);
            _rearLeft.TurnLeft(degrees);
            _rearRight.TurnLeft(degrees);
        }

        public void TurnRight(int degrees)
        {
            _frontLeft.TurnRight(degrees);
            _frontRight.TurnRight(degrees);
            _rearLeft.TurnRight(degrees);
            _rearRight.TurnRight(degrees);
        }
    }
}