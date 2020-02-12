namespace CarPlant
{
    public class FrontWheelDrive : IWheelDrive
    {
        private readonly Wheel _frontLeft;
        private readonly Wheel _frontRight;

        public FrontWheelDrive()
        {
            _frontLeft = new Wheel("front left");
            _frontRight = new Wheel("front right");
        }

        public void TurnLeft(int degrees)
        {
            _frontLeft.turnLeft(degrees);
            _frontRight.turnLeft(degrees);
        }

        public void TurnRight(int degrees)
        {
            _frontLeft.turnRight(degrees);
            _frontRight.turnRight(degrees);
        }
    }

    public interface IAcceleration
    {
        void Accelerate(int kph);
    }

    public class FrontWheelAcceleration : IAcceleration
    {
        private readonly Wheel _frontLeft;
        private readonly Wheel _frontRight;

        public FrontWheelAcceleration()
        {
            _frontLeft = new Wheel("front left");
            _frontRight = new Wheel("front right");
        }
        
        public void Accelerate(int kph)
        {
            _frontLeft.rotate(kph);
            _frontRight.rotate(kph);
        }
    }

    public class RearWheelAcceleration : IAcceleration
    {
        private readonly Wheel _rearLeft;
        private readonly Wheel _rearRight;

        public RearWheelAcceleration()
        {
            _rearLeft = new Wheel("rear left");
            _rearRight = new Wheel("rear right");
        }

        public void Accelerate(int kph)
        {
            _rearLeft.rotate(kph);
            _rearRight.rotate(kph);
        }
    }

    public class FourWheelAcceleration : IAcceleration
    {
        private readonly Wheel _frontLeft;
        private readonly Wheel _frontRight;
        private readonly Wheel _rearLeft;
        private readonly Wheel _rearRight;

        public FourWheelAcceleration()
        {
            _frontLeft = new Wheel("front left");
            _frontRight = new Wheel("front right");
            _rearLeft = new Wheel("rear left");
            _rearRight = new Wheel("rear right");
        }

        public void Accelerate(int kph)
        {
            _frontLeft.rotate(kph);
            _frontRight.rotate(kph);
            _rearLeft.rotate(kph);
            _rearRight.rotate(kph);
        }
    }
}