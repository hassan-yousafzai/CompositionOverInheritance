namespace CarPlant
{
	public class MitsubishiTriton
	{
        private readonly Wheel _frontLeft;
        private readonly Wheel _frontRight;
        private readonly Wheel _rearLeft;
        private readonly Wheel _rearRight;

        public MitsubishiTriton()
        {
            _frontLeft = new Wheel("front left");
            _frontRight = new Wheel("front right");
            _rearLeft = new Wheel("rear left");
            _rearRight = new Wheel("rear right");
        }

		public string Name()
		{
			return "Mitsubishi Triton";
		}

        public void Accelerate(int kph)
        {
            _frontLeft.rotate(kph);
            _frontRight.rotate(kph);
            _rearLeft.rotate(kph);
            _rearRight.rotate(kph);
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
}