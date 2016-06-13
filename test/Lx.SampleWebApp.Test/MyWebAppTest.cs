using Lx.SampleWebApp.Services;
using Xunit;

namespace Lx.SampleWebApp.Test
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class MyWebAppTest
    {
        [Fact]
        public void MainTest()
        {
            var myService = new MySampleService();
        }
    }
}
