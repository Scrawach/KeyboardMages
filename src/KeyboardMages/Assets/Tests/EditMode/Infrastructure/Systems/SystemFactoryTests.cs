using CodeBase.Infrastructure.Systems;
using Entitas;
using FluentAssertions;
using NUnit.Framework;
using Zenject;

namespace Tests.EditMode.Infrastructure.Systems
{
    public class SystemFactoryTests
    {
        [Test]
        public void WhenCreateSystem_ThenShouldReturnSystem()
        {
            // arrange
            var systems = new SystemFactory(new DiContainer());

            // act
            var system = systems.Create<MockedSystem>();

            // assert
            system.Should().NotBeNull();
            system.Should().BeOfType<MockedSystem>();
        }

        public class MockedSystem : ISystem { }
    }
}