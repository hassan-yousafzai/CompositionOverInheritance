namespace CarPlant {
	public class CarPlant
	{
        public static string LOG;

		public static ToyotaCorolla makeToyotaCorolla()
		{
			return new ToyotaCorolla();
		}

		public static ToyotaCorollaSports makeToyotaCorollaSports()
		{
			return new ToyotaCorollaSports();
		}

		public static MitsubishiTriton makeMitsubishiTriton()
		{
			return new MitsubishiTriton();
		}

		public static SandBuggy makeSandBuggy()
		{
			return new SandBuggy();
		}

		public static SandBuggyLite makeSandBuggyLite()
		{
			return new SandBuggyLite();
		}
	}
}