namespace CarPlant
{
    public class RearWheelDrive : IWheelDrive
    {
        private readonly Wheel _rearLeft;
        private readonly Wheel _rearRight;

        public RearWheelDrive()
        {
            _rearLeft = new Wheel("rear left");
            _rearRight = new Wheel("rear right");
        }
        
        public void TurnLeft(int degrees)
        {
            _rearLeft.turnLeft(degrees);
            _rearRight.turnLeft(degrees);
        }

        public void TurnRight(int degrees)
        {
            _rearLeft.turnRight(degrees);
            _rearRight.turnRight(degrees);
        }

    }
}