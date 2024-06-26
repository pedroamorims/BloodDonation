using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Tests
{
    internal class TestStartup
    {
        public static IServiceProvider Provider()
        {
            var serviceCollection = new ServiceCollection();
           
            return serviceCollection.BuildServiceProvider();
        }
    }
}
