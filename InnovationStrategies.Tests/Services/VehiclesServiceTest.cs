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
    public class VehiclesServiceTest
    {
        Fixture fixture = new Fixture();

        [Test]
        public void DoSomething_WhenInvoked_ShouldThrowNotImplementedException()
        {
            // Arrange
            var target = fixture.Create<VehiclesService>();
            var reg = fixture.Create<string>();
            var brand = fixture.Create<string>();
            var model = fixture.Create<string>();
            var dni = fixture.Create<string>();

            // Act
            TestDelegate act = () => target.AddVehicle(reg, brand, model, dni);

            // Assert
            Assert.That(act, Throws.Exception.TypeOf<NotImplementedException>());
        }

        [Test]
        public void DoSomething_WhenInvokedWithNullInput_ShouldThrowArgumentNullException()
        {
            // Arrange
            var target = fixture.Create<VehiclesService>();
            string reg = null;
            string brand = null;
            string model = null;
            string dni = null;

            // Act
            TestDelegate act = () => target.AddVehicle(reg, brand, model, dni);

            // Assert
            Assert.That(act, Throws.Exception.TypeOf<ArgumentNullException>());
        }
    }
}
