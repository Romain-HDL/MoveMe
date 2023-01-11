using NUnit.Framework;
using MoveMe;

namespace TestMoveMe
{
    public class TestVehicle
    {
        private string _brand = "";
        private Vehicle _vehicle;
        
        [SetUp]
        public void SetUp()
        {
            _brand = "BMW";
            _vehicle = new Vehicle(_brand); 
        }

        [Test]
        public void Properties_AfterInstantiation_Success()
        {
            //given
            //refer to Setup()

            //when
            //Event triggers by the assertion

            //then
            Assert.AreEqual(_brand, _vehicle.Brand);
            Assert.IsFalse(_vehicle.IsEngineStarted);
        }
        
        [Test]
        public void StartEngine_NominalCase_Success()
        {
            //given
            //refer to Setup()
            Assert.IsFalse(_vehicle.IsEngineStarted);

            //when
            _vehicle.StartEngine();

            //then
            Assert.IsTrue(_vehicle.IsEngineStarted);
        }

        [Test]
        public void StopEngine_NominalCase_Success()
        {
            //given
            //refer to Setup()
            _vehicle.StartEngine();
            Assert.IsTrue(_vehicle.IsEngineStarted);

            //when
            _vehicle.StopEngine();

            //then
            Assert.IsFalse(_vehicle.IsEngineStarted);
        }
    }
}