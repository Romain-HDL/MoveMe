using System;

namespace MoveMe
{
    public class Person : IPerson
    {
        private string _name;

        public Person(string name)
        {
            _name = name;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }
            
        public virtual string Eat()
        {
            return "Je mange";
        }

        public string Drink() 
        {
            return "Je bois";
        }

        public virtual string Sleep() 
        {
            return "Je dors";
        }
    }
}
