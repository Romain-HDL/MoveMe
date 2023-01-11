using NUnit.Framework;
using MoveMe;


namespace TestMoveMe
{
    public class TestPassenger
    {
        private string _name;
        private string _cityOfDestination;
        private Passenger _passenger;

        [SetUp]
        public void Setup()
        {
            _name = "John";
            _cityOfDestination = "Zürich";
            _passenger = new Passenger(_name, _cityOfDestination);
        }

        [Test]
        public void Properties_AfterInstantiation_Success()
        {
            //given
            //refer to Setup()

            //when
            //Event triggers by the assertion

            //then
            Assert.AreEqual(_name, _passenger.Name);
            Assert.AreEqual(_cityOfDestination, _passenger.CityOfDestination);
        }

        [Test]
        public void LookLandscap_NominalCase_Success()
        {
            //given
            string expectedMessage = "Je profite du paysage";

            //when
            //Event triggers by the assertion

            //then
            Assert.AreEqual(expectedMessage, _passenger.LookLandscap());
        }
    }
}