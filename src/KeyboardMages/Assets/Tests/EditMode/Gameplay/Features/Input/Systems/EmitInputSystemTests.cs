using System.Linq;
using CodeBase.Common.Entities;
using CodeBase.Gameplay.Features.Input.Service;
using CodeBase.Gameplay.Features.Input.Systems;
using FluentAssertions;
using NUnit.Framework;
using UnityEngine;

namespace Tests.EditMode.Gameplay.Features.Input.Systems
{
    public class EmitInputSystemTests
    {
        [Test]
        public void WhenExecute_ThenShouldAddInputAxisComponent_OnInputEntity_WithInputComponent()
        {
            // arrange
            var axis = new Vector2(25f, 25f);
            var mockedInput = new MockedInput(true, axis);
            var contexts = new Contexts();
            
            var emitInputSystem = new EmitInputSystem(contexts.input, mockedInput);
            contexts.input.CreateEntity().isInput = true;

            // act
            emitInputSystem.Execute();

            // assert
            var entities = Contexts.sharedInstance.input.GetEntities();

            entities.Should().NotBeEmpty();
            entities.Single().isInput.Should().BeTrue();
            entities.Single().axisInput.Should().Be(axis);
        }
        
        public class MockedInput : IInput
        {
            public MockedInput(bool hasAxis, Vector2 axis)
            {
                HasAxis = hasAxis;
                Axis = axis;
            }

            public bool HasAxis { get; set; }
            public Vector2 Axis { get; set; }
        }
    }
}