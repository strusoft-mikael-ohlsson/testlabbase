using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTests
{
    using MyWpfApp.ViewModels;

    using NUnit.Framework;

    [TestFixture]
    public class MainVmTests
    {

        [Test]
        public void ShouldBeAbleToCreate()
        {
            var result = new MainVm();

            Assert.NotNull(result);
        }

        [Test]
        public void MessageEmptyOnStart()
        {
            var result = new MainVm();

            Assert.AreEqual(string.Empty, result.Message);            
        }


        [Test]
        public void MessageHelloAfterClickt()
        {
            var result = new MainVm();
            result.ClickCommand.Execute(null);
            Assert.AreEqual("Hello!", result.Message);
        }
    }
}
