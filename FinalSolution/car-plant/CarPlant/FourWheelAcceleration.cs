namespace CarPlant
{
    public class FourWheelAcceleration : IAcceleration
    {
        private readonly IWheel _frontLeft;
        private readonly IWheel _frontRight;
        private readonly IWheel _rearLeft;
        private readonly IWheel _rearRight;

        public FourWheelAcceleration(IWheel frontLeft, IWheel frontRight, IWheel rearLeft, IWheel rearRight)
        {
            _frontLeft = frontLeft;
            _frontRight = frontRight;
            _rearLeft = rearLeft;
            _rearRight = rearRight;
        }

        public void Accelerate(int kph)
        {
            _frontLeft.Rotate(kph);
            _frontRight.Rotate(kph);
            _rearLeft.Rotate(kph);
            _rearRight.Rotate(kph);
        }
    }
}