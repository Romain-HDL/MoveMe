using MoveMe;
using NUnit.Framework;

namespace TestMoveMe
{
    public class TestMove
    {
        private string _brand = "";
        private Car _car;

        [SetUp]
        public void SetUp()
        {
            _brand = "BMW";
            _car = new Car(_brand);
        }

        [Test]
        public void Properties_AfterInstantiation_Success()
        {
            //given
            //refer to Setup()

            //when
            //Event triggers by the assertion

            //then
            Assert.AreEqual(_brand, _car.Brand);
            Assert.IsFalse(_car.IsEngineStarted);
            Assert.IsNull(_car.Passengers);
        }

        [Test]
        public void StartEngine_NominalCase_Success()
        {
            //given
            //refer to Setup()
            Assert.IsFalse(_car.IsEngineStarted);

            //when
            _car.StartEngine();

            //then
            Assert.IsTrue(_car.IsEngineStarted);
        }

        [Test]
        public void StopEngine_NominalCase_Success()
        {
            //given
            //refer to Setup()
            _car.StartEngine();
            Assert.IsTrue(_car.IsEngineStarted);

            //when
            _car.StopEngine();

            //then
            Assert.IsFalse(_car.IsEngineStarted);
        }
    }
}