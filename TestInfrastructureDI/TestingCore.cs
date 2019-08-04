using System;
using Infrastructure.Services;
using Infrastructure.Services.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Infrastructure
{
    [TestClass]
    public class TestingCore
    {
        private ITestFrameworkService _testFrameworkService;
        public TestingCore()
        {
            RegisterTypes();
            _testFrameworkService = DependencyInjector.Retrieve<ITestFrameworkService>();
        }

        private static void RegisterTypes()
        {
            DependencyInjector.Register<ITestFrameworkService, TestFrameworkService>();
        }

        public void FindAndWait()
        {
            _testFrameworkService.FindAndWait();
        }
    }
}
