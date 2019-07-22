using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Dependency Inversion Principle
/// high level modules should not depend on low level modules; both should depend on abstractions. 
///     Abstractions should not depend on details.  Details should depend upon abstractions
/// </summary>

namespace SOLIDSample.DIP
{

    public class BadWay
    {
        public class Service
        {
            public bool Save()
            {
                //New is glue
                return new Repository().Save();
                //or

                var repository = new Repository();

                return repository.Save();
            }
        }

        public class Repository
        {
            public bool Save()
            {
                //Save on DB
                return true;
            }
        }

    }

    public class DIP
    {
        public class Service
        {
            private readonly Repository repository;

            public Service(Repository repository)
            {
                this.repository = repository;
            }

            public bool Save()
            {
                return repository.Save();
            }
        }

        public class Repository
        {
            public bool Save()
            {
                //Save on DB
                return true;
            }
        }
    }
}
