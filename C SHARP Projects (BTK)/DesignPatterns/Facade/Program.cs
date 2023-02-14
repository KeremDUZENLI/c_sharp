using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager cM = new CustomerManager();
            cM.Save();


            Console.ReadLine();
        }
    }

    interface ILogging
    {
        void Log();
    }

    interface ICaching
    {
        void Cache();
    }

    internal interface IAuthorizing
    {
        void Authorize();
    }

    internal interface IValidating
    {
        void Validate();
    }

    class Logging:ILogging
    {
        public void Log()
        {
            Console.WriteLine("Logged");
        }
    }

    class Caching:ICaching
    {
        public void Cache()
        {
            Console.WriteLine("Cached");
        }
    }

    class Authorizing:IAuthorizing
    {
        public void Authorize()
        {
            Console.WriteLine("Authorized");
        }
    }

    class Validating : IValidating
    {
        public void Validate()
        {
            Console.WriteLine("Validated");
        }
    }

    class CustomerManager 
    {
        private CrossCuttongConcernsFacade _concerns;

        public CustomerManager()
        {
            _concerns = new CrossCuttongConcernsFacade();
        }

        public void Save()
        {
            _concerns.Logging.Log();
            _concerns.Caching.Cache();
            _concerns.Authorizing.Authorize();
            _concerns.Validating.Validate();
            Console.WriteLine("Saved");
        }
    }

    class CrossCuttongConcernsFacade
    {
        public ILogging Logging;
        public ICaching Caching;
        public IAuthorizing Authorizing;
        public IValidating Validating;

        public CrossCuttongConcernsFacade()
        {
            Logging = new Logging();
            Caching = new Caching();
            Authorizing = new Authorizing();
            Validating = new Validating();
        }
    }
}
