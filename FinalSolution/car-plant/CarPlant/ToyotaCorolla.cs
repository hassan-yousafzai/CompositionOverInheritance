namespace CarPlant
{
	public class ToyotaCorolla
	{
        private readonly Wheel _frontLeft;
        private readonly Wheel _frontRight;

		public ToyotaCorolla()
        {
			_frontLeft = new Wheel("front left");
            _frontRight = new Wheel("front right");
		}

		public string Name()
		{
			return "Toyota Corolla";
		}

        public void Accelerate(int kph)
        {
            _frontLeft.rotate(kph);
            _frontRight.rotate(kph);
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