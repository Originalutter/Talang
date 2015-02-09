using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void should_work
        {
            Assert.That(true, Is.EqualTo(true));
        }
    }
}
