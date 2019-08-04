using Infrastructure.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class RandomClass
    {
        private readonly ITestFrameworkService _testFrameworkService;
        public RandomClass(ITestFrameworkService testFrameworkService)
        {
            _testFrameworkService = testFrameworkService;
        }

        public void RunCode()
        {
            _testFrameworkService.FindAndWait();

        }
    }
}
