using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDSample.SRP
{
    public class BadWay
    {
        public class Person
        {
            public string Name { get; set; }

            public bool Create()
            {
                return true;
            }
        }
    }

    public class SRP
    {
        public class Person
        {
            public string Name { get; set; }
        }

        public class PersonService<Person>
        {
            public bool Create()
            {
                return true;
            }
        }
    }
}
