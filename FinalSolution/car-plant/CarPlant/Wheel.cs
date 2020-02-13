namespace CarPlant {
    public interface IWheel
    {
        void TurnLeft(int degrees);
        void TurnRight(int degrees);
        void Rotate(int kph);
    }

	public class Wheel : IWheel
    {
		private readonly string _name;

		public Wheel(string name) {
			_name = name;
		}

		public void TurnLeft(int degrees) {
			CarPlant.LOG += _name + " turning left " + degrees + " degrees\n";
		}

		public void TurnRight(int degrees) {
			CarPlant.LOG += _name + " turning right " + degrees + " degrees\n";
		}

		public void Rotate(int kph) {
			CarPlant.LOG += _name + " accelerating " + kph + " kph\n";
		}
	}
}