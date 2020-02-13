namespace CarPlant {
	public class CarPlant
	{
        public static string LOG;
        private static readonly IWheel FrontLeft = new Wheel("front left");
        private static readonly IWheel FrontRight = new Wheel("front right");
        private static readonly IWheel RearLeft = new Wheel("rear left");
        private static readonly IWheel RearRight = new Wheel("rear right");

		public static Car makeToyotaCorolla()
		{
            return new Car("Toyota Corolla")
                .WithWheelDrive(new FrontWheelDrive(FrontLeft, FrontRight))
                .WithAcceleration(new FrontWheelAcceleration(FrontLeft, FrontRight));
        }

		public static Car makeToyotaCorollaSports()
		{
			return new Car("Toyota Corolla sports")
                .WithWheelDrive(new FrontWheelDrive(FrontLeft, FrontRight))
                .WithAcceleration(new RearWheelAcceleration(RearLeft, RearRight));
		}

        public static Car makeSandBuggyLite()
        {
            return new Car("Sand Buggy Lite")
                .WithWheelDrive(new FourWheelDrive(FrontLeft, FrontRight, RearLeft, RearRight))
                .WithAcceleration(new RearWheelAcceleration(RearLeft, RearRight));
        }

		public static Car makeMitsubishiTriton()
        {
            return new Car("Mitsubishi Triton")
                .WithWheelDrive(new FrontWheelDrive(FrontLeft, FrontRight))
                .WithAcceleration(new FourWheelAcceleration(FrontLeft, FrontRight, RearLeft, RearRight));
        }

		public static Car makeSandBuggy()
		{
			return new Car("Sand Buggy")
                .WithWheelDrive(new FourWheelDrive(FrontLeft, FrontRight, RearLeft, RearRight))
                .WithAcceleration(new FourWheelAcceleration(FrontLeft, FrontRight, RearLeft, RearRight));
		}
    }
}