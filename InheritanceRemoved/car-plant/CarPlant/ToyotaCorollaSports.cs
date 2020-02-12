namespace CarPlant
{
	public class ToyotaCorollaSports
	{
        private readonly Wheel _frontLeft;
        public readonly Wheel _frontRight;
        public readonly Wheel _rearLeft;
        public readonly Wheel _rearRight;

        public ToyotaCorollaSports()
        {
            _frontLeft = new Wheel("front left");
            _frontRight = new Wheel("front right");
            _rearLeft = new Wheel("rear left");
            _rearRight = new Wheel("rear right");
        }

		public string Name()
		{
			return "Toyota Corolla sports";
		}

        public void Accelerate(int kph)
        {
            _rearLeft.rotate(kph);
            _rearRight.rotate(kph);
        }

        public virtual void TurnLeft(int degrees)
        {
            _frontLeft.turnLeft(degrees);
            _frontRight.turnLeft(degrees);
        }

        public virtual void TurnRight(int degrees)
        {
            _frontLeft.turnRight(degrees);
            _frontRight.turnRight(degrees);
        }
	}
}