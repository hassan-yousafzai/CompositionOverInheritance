namespace CarPlant
{
	public class SandBuggy : FourWheelDriveCar
	{
		public override string Name()
		{
			return "Sand Buggy";
		}

        public override void TurnLeft(int degrees)
        {
			_frontLeft.turnLeft(degrees);
			_frontRight.turnLeft(degrees);
			_rearLeft.turnLeft(degrees);
            _rearRight.turnLeft(degrees);
        }

        public override void TurnRight(int degrees)
        {
            _frontLeft.turnRight(degrees);
            _frontRight.turnRight(degrees);
            _rearLeft.turnRight(degrees);
            _rearRight.turnRight(degrees);
        }
	}
}