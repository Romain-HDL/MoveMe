using NUnit.Framework;
using MoveMe;

namespace TestMoveMe
{
    public class TestPerson
    {
        private string _name;
        private Person _person;

        [SetUp]
        public void Setup()
        {
            _name = "John";
            _person = new Person(_name);
        }

        [Test]
        public void Properties_AfterInstantiation_Success()
        {
            //given
            //refer to Setup()

            //when
            //Event triggers by the assertion

            //then
            Assert.AreEqual(_name, _person.Name);
        }
        
        [Test]
        public void Eat_NominalCase_Success()
        {
            //given
            //refer to Setup()
            string expectedMessage = "Je mange";

            //when
            //Event triggers by the assertion

            //then
            Assert.AreEqual(expectedMessage, _person.Eat());
        }

        [Test]
        public void Drink_NominalCase_Success()
        {
            //given
            string expectedMessage = "Je bois";

            //when
            //Event triggers by the assertion

            //then
            Assert.AreEqual(expectedMessage, _person.Drink());
        }

        [Test]
        public void Sleep_NominalCase_Success()
        {
            //given
            string expectedMessage = "Je dors";

            //when
            //Event triggers by the assertion

            //then
            Assert.AreEqual(expectedMessage, _person.Sleep());
        }
    }
}