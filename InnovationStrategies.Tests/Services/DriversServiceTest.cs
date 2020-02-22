using AutoFixture;
using InnovationStrategies;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovationStrategiesTests.Services
{
    [TestFixture]
    public class DriversServiceTest
    {
        Fixture fixture = new Fixture();

        [Test]
        public void DoSomething_WhenInvoked_ShouldThrowNotImplementedException()
        {
            // Arrange
            var target = fixture.Create<DriversService>();
            var dni = fixture.Create<string>();
            var name = fixture.Create<string>();
            var surnames = fixture.Create<string>();

            // Act
            TestDelegate act = () => target.AddDriver(dni, name, surnames);

            // Assert
            Assert.That(act, Throws.Exception.TypeOf<NotImplementedException>());
        }

        [Test]
        public void DoSomething_WhenInvokedWithNullInput_ShouldThrowArgumentNullException()
        {
            // Arrange
            var target = fixture.Create<DriversService>();
            string dni = null;
            string name = null;
            string surnames = null;

            // Act
            TestDelegate act = () => target.AddDriver(dni, name, surnames);

            // Assert
            Assert.That(act, Throws.Exception.TypeOf<ArgumentNullException>());
        }
    }
}
