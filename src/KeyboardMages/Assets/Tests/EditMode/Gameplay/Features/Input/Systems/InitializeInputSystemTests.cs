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
            var contexts = new Contexts();
            var system = new InitializeInputSystem(contexts.input);
            
            // act
            system.Initialize();
            
            // assert
            var entities = contexts.input.GetEntities();
            
            entities.Should().NotBeEmpty();
            entities.Single().isInput.Should().BeTrue();
        }
    }
}