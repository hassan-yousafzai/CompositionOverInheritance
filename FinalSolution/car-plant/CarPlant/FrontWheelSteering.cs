namespace CarPlant
{
    public class FrontWheelSteering : IWheelDrive
    {
        private readonly IWheel _frontLeft;
        private readonly IWheel _frontRight;

        public FrontWheelSteering(IWheel frontLeft, IWheel frontRight)
        {
            _frontLeft = frontLeft;
            _frontRight = frontRight;
        }

        public void TurnLeft(int degrees)
        {
            _frontLeft.TurnLeft(degrees);
            _frontRight.TurnLeft(degrees);
        }

        public void TurnRight(int degrees)
        {
            _frontLeft.TurnRight(degrees);
            _frontRight.TurnRight(degrees);
        }
    }
}