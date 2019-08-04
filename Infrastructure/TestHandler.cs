using Infrastructure.Services;
using Infrastructure.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Infrastructure
{
    public static class TestHandler
    {
        public static void Handle(Action action)
        {
            
            action.Invoke();
        }

        
    }
}
