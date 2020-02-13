namespace CarPlant
{
    public class FrontWheelAcceleration : IAcceleration
    {
        private readonly IWheel _frontLeft;
        private readonly IWheel _frontRight;

        public FrontWheelAcceleration(IWheel frontLeft, IWheel frontRight)
        {
            _frontLeft = frontLeft;
            _frontRight = frontRight;
        }
        
        public void Accelerate(int kph)
        {
            _frontLeft.Rotate(kph);
            _frontRight.Rotate(kph);
        }
    }
}