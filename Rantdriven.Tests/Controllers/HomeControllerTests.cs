using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Rantdriven.Controllers;

namespace Rantdriven.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTests
    {
        [Test]
        public void Setup()
        {
        }

        public void TestIndex()
        {
            var controller = new HomeController();
            var view = controller.Index();
            
            
        }

        [Test]
        public void TearDown()
        {
            
        }
    }
}
