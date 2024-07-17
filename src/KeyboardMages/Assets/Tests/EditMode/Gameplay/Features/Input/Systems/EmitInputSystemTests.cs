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
        public void WhenExecute_AndHasInput_ThenShouldAddInputAxisComponent_OnInputEntity_WithInputComponent()
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
            var entities = contexts.input.GetEntities();
            var entity = entities.Single();
            
            entities.Should().NotBeEmpty();
            entity.isInput.Should().BeTrue();
            entity.hasAxisInput.Should().BeTrue();
            entity.AxisInput.Should().Be(axis);
        }

        [Test]
        public void WhenExecute_AndHasNotInput_ThenShouldRemoveInputAxisComponent_OnInputEntity_WithInputComponent()
        {
            // arrange
            var axis = new Vector2(25f, 25f);
            var mockedInput = new MockedInput(true, axis);
            var contexts = new Contexts();
            
            var emitInputSystem = new EmitInputSystem(contexts.input, mockedInput);
            contexts.input.CreateEntity().isInput = true;

            // act
            emitInputSystem.Execute();
            mockedInput.HasAxis = false;
            emitInputSystem.Execute();

            // assert
            var entities = contexts.input.GetEntities();
            var entity = entities.Single();
            
            entities.Should().NotBeEmpty();
            entity.isInput.Should().BeTrue();
            entity.hasAxisInput.Should().BeFalse();
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