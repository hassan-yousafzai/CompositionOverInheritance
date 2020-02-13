using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarPlant
{
    [TestClass]
    public class RobinReliantTest
    {
        private Car _robinReliant;

        [TestInitialize]
        public void Init()
        {
            CarPlant.LOG = "";
            _robinReliant = CarPlant.makeRobinReliant();
        }

        [TestMethod]
        public void HasTheCorrectName()
        {
            Assert.AreEqual("Robin Reliant", _robinReliant.Name());
        }

        [TestMethod]
        public void TurningLeftOnlyTurnsTheFrontCentreWheel()
        {
            var degrees = TestHelpers.randomDegrees();
            _robinReliant.TurnLeft(degrees);
            Assert.AreEqual("front centre turning left " + degrees + " degrees\n", CarPlant.LOG);
        }       
        
        [TestMethod]
        public void TurningRightOnlyTurnsTheFrontCentreWheel()
        {
            var degrees = TestHelpers.randomDegrees();
            _robinReliant.TurnRight(degrees);
            Assert.AreEqual("front centre turning right " + degrees + " degrees\n", CarPlant.LOG);
        }

        [TestMethod]
        public void AcceleratingOnlyTurnsTheRearWheels()
        {
            var speed = TestHelpers.randomSpeed();
            _robinReliant.Accelerate(speed);
            Assert.AreEqual("rear left accelerating " + speed + " kph\n"
                            + "rear right accelerating " + speed + " kph\n", CarPlant.LOG);
        }
    }
}
