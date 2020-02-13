namespace CarPlant
{
    public class RearWheelAcceleration : IAcceleration
    {
        private readonly IWheel _rearLeft;
        private readonly IWheel _rearRight;

        public RearWheelAcceleration(IWheel rearLeft, IWheel rearRight)
        {
            _rearLeft = rearLeft;
            _rearRight = rearRight;
        }

        public void Accelerate(int kph)
        {
            _rearLeft.Rotate(kph);
            _rearRight.Rotate(kph);
        }
    }
}