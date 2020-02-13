namespace CarPlant
{
    public class Car
    {
        public readonly string _name;
        private readonly IWheelDrive _wheelDrive;
        private readonly IAcceleration _acceleration;
        
        public Car(string name)
        {
            _name = name;
        }

        private Car(string name, IWheelDrive wheelDrive, IAcceleration acceleration)
        {
            _name = name;
            _wheelDrive = wheelDrive;
            _acceleration = acceleration;
        }

        public string Name()
        {
            return _name;
        }

        public void TurnLeft(int degrees)
        {
            _wheelDrive.TurnLeft(degrees);
        }

        public void TurnRight(int degrees)
        {
            _wheelDrive.TurnRight(degrees);
        }

        public void Accelerate(int kph)
        {
            _acceleration.Accelerate(kph);
        }

        public Car WithWheelSteering(IWheelDrive wheelDrive)
        {
            return new Car(_name, wheelDrive, _acceleration);
        }

        public Car WithWheelAcceleration(IAcceleration acceleration)
        {
            return new Car(_name, _wheelDrive, acceleration);
        }
    }
}