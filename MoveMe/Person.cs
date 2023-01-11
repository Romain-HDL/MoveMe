using System;

namespace MoveMe
{
    public class Person : IPerson
    {
        private string _name;

        public Person(string name)
        {
            throw new NotImplementedException();
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }
            
        public virtual string Eat()
        {
            throw new NotImplementedException();
        }

        public string Drink() 
        {
            throw new NotImplementedException();
        }

        public virtual string Sleep() 
        {
            throw new NotImplementedException();
        }
    }
}
