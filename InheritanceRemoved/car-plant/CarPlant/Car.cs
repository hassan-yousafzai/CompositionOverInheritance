using System;

namespace CarPlant
{
	public abstract class Car
	{
		private readonly Wheel _frontLeft;
        private readonly Wheel _frontRight;
        private readonly Wheel _rearLeft;
        private readonly Wheel _rearRight;

		public abstract string Name ();
		public abstract void Accelerate(int kmsPerHour);

		protected Car()
		{
			_frontLeft = new Wheel("front left");
			_frontRight = new Wheel("front right");
			_rearLeft = new Wheel("rear left");
			_rearRight = new Wheel("rear right");
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