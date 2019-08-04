using System;
using Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class TestClass1 : TestingCore
    {
        

        [TestMethod]
        public void TestMethod1()
        {
            TestHandler.Handle(() =>
            {
                //Calls base class method which calls FindAndWait from ITestFrameworkSerice
                FindAndWait();

                //Creates a random class which has ITestFrameworkSerice injected into constructor, RunCode calls FindAndWait  
                var randomClass = DependencyInjector.Retrieve<RandomClass>();
                randomClass.RunCode();

            });
        }
    }
}
