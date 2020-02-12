namespace CarPlant {
	public class CarPlant
	{
        public static string LOG;
		public static Car makeToyotaCorolla()
		{
			return new Car("Toyota Corolla")
                .WithWheelDrive(new FrontWheelDrive())
                .WithAcceleration(new FrontWheelAcceleration());
        }

		public static Car makeToyotaCorollaSports()
		{
			return new Car("Toyota Corolla sports")
                .WithWheelDrive(new FrontWheelDrive())
                .WithAcceleration(new RearWheelAcceleration());
		}

        public static Car makeSandBuggyLite()
        {
            return new Car("Sand Buggy Lite")
                .WithWheelDrive(new FourWheelDrive())
                .WithAcceleration(new RearWheelAcceleration());
        }

		public static Car makeMitsubishiTriton()
        {
            return new Car("Mitsubishi Triton")
                .WithWheelDrive(new FrontWheelDrive())
                .WithAcceleration(new FourWheelAcceleration());

        }

		public static Car makeSandBuggy()
		{
			return new Car("Sand Buggy")
                .WithWheelDrive(new FourWheelDrive())
                .WithAcceleration(new FourWheelAcceleration());
		}
	}
}