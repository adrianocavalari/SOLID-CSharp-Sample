using System;
using System.Collections.Generic;
using System.Text;
using static SOLIDSample.DIP.DIP2;

/// <summary>
/// Dependency Inversion Principle
/// high level modules should not depend on low level modules; both should depend on abstractions. 
///     Abstractions should not depend on details.  Details should depend upon abstractions
/// </summary>

namespace SOLIDSample.DIP
{
    public class DIP2
    {
        public class Service
        {

            public bool Save()
            {
                return RepositoryFactory.CreateRepository().Save();
            }
        }

        public class Repository2
        {
            public bool Save()
            {
                //Save on DB
                return true;
            }
        }
    }

    public static class RepositoryFactory
    {
        //Centralize the Object Creation, this class could be in a IoT
        public static Repository2 CreateRepository()
        {
            return new Repository2();
        }
    }
}
