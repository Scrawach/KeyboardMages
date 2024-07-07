using System;
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

        [Test]
        public void WhenCreateSystem_WithExternalArguments_ThenShouldReturnSystem_WithTheseArguments()
        {
            // arrange 
            var systems = new SystemFactory(new DiContainer());
            var expected = 25;
            
            // act
            var system = systems.Create<MockedSystemWithArguments>(expected);
            
            // assert
            system.Should().NotBeNull();
            system.Should().BeOfType<MockedSystemWithArguments>();
            system.Value.Should().Be(expected);
        }

        [Test]
        public void WhenCreateSystem_AndCantDoIt_ThenShouldThrowZenjectException()
        {
            // arrange
            var systems = new SystemFactory(new DiContainer());
            
            // act
            Action act = () => systems.Create<MockedSystemWithArguments>();
            
            // assert
            act.Should().Throw<ZenjectException>();
        }

        public class MockedSystem : ISystem { }

        public class MockedSystemWithArguments : ISystem
        {
            public int Value { get; }
            
            public MockedSystemWithArguments(int value) => 
                Value = value;
        }
    }
}