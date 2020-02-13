namespace CarPlant
{
    public class FrontCentreWheelSteering : IWheelDrive
    {
        private readonly IWheel _frontCentre;

        public FrontCentreWheelSteering(IWheel frontCentre)
        {
            _frontCentre = frontCentre;
        }

        public void TurnLeft(int degrees)
        {
            _frontCentre.TurnLeft(degrees);
        }

        public void TurnRight(int degrees)
        {
            _frontCentre.TurnRight(degrees);
        }
    }
}