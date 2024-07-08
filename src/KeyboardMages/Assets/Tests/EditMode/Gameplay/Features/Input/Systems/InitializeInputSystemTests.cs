using System.Linq;
using CodeBase.Gameplay.Features.Input.Systems;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.EditMode.Gameplay.Features.Input.Systems
{
    public class InitializeInputSystemTests
    {
        [Test]
        public void WhenInitialize_ThenShouldCreateEntity_WithInputComponent()
        {
            // arrange
            var system = new InitializeInputSystem();
            
            // act
            system.Initialize();
            
            // assert
            var entities = Contexts.sharedInstance.input.GetEntities();
            
            entities.Should().NotBeEmpty();
            entities.Single().isInput.Should().BeTrue();
        }
    }
}