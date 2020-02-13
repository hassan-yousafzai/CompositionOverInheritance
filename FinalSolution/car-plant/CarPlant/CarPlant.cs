namespace CarPlant {
	public class CarPlant
	{
        public static string LOG;
        private static readonly IWheel FrontLeft = new Wheel("front left");
        private static readonly IWheel FrontRight = new Wheel("front right");
        private static readonly IWheel RearLeft = new Wheel("rear left");
        private static readonly IWheel RearRight = new Wheel("rear right");
        private static readonly IWheel FrontCentre = new Wheel("front centre");

        public static Car makeToyotaCorolla() =>
            new Car("Toyota Corolla")
                .WithWheelSteering(new FrontWheelSteering(FrontLeft, FrontRight))
                .WithWheelAcceleration(new FrontWheelAcceleration(FrontLeft, FrontRight));

        public static Car makeToyotaCorollaSports() =>
            new Car("Toyota Corolla sports")
                .WithWheelSteering(new FrontWheelSteering(FrontLeft, FrontRight))
                .WithWheelAcceleration(new RearWheelAcceleration(RearLeft, RearRight));

        public static Car makeSandBuggyLite() =>
            new Car("Sand Buggy Lite")
                .WithWheelSteering(new FourWheelSteering(FrontLeft, FrontRight, RearLeft, RearRight))
                .WithWheelAcceleration(new RearWheelAcceleration(RearLeft, RearRight));

        public static Car makeMitsubishiTriton() =>
            new Car("Mitsubishi Triton")
                .WithWheelSteering(new FrontWheelSteering(FrontLeft, FrontRight))
                .WithWheelAcceleration(new FourWheelAcceleration(FrontLeft, FrontRight, RearLeft, RearRight));

        public static Car makeSandBuggy() =>
            new Car("Sand Buggy")
                .WithWheelSteering(new FourWheelSteering(FrontLeft, FrontRight, RearLeft, RearRight))
                .WithWheelAcceleration(new FourWheelAcceleration(FrontLeft, FrontRight, RearLeft, RearRight));

        public static Car makeRobinReliant() =>
            new Car("Robin Reliant")
                .WithWheelSteering(new FrontCentreWheelSteering(FrontCentre))
                .WithWheelAcceleration(new RearWheelAcceleration(RearLeft, RearRight));
    }
}