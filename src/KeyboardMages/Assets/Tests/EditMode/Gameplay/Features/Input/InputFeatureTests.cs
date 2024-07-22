using System.Linq;
using CodeBase.Gameplay.Features.Input;
using CodeBase.Gameplay.Features.Input.Service;
using CodeBase.Infrastructure.Systems;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using UnityEngine;
using Zenject;

namespace Tests.EditMode.Gameplay.Features.Input
{
    public class InputFeatureTests
    {
        [Test]
        public void WhenExecute_AndHasInput_ThenShouldCreateEntityWithInput_AndInputAxisComponents()
        {
            // arrange
            var container = new DiContainer();
            var contexts = new Contexts();
            var axis = new Vector2(10f, 10f);

            var mockedInput = new Mock<IInput>();
            mockedInput.Setup(input => input.HasAxis).Returns(true);
            mockedInput.Setup(input => input.Axis).Returns(axis);

            container.Bind<IInput>().FromInstance(mockedInput.Object);
            container.Bind<InputContext>().FromInstance(contexts.input);

            var systems = new SystemFactory(container);
            var inputFeature = new InputFeature(systems);
            
            // act
            inputFeature.Initialize();
            inputFeature.Execute();
            
            // assert
            var entities = contexts.input.GetEntities();
            var entity = entities.Single();

            entity.isInput.Should().BeTrue();
            entity.hasAxisInput.Should().BeTrue();
            entity.AxisInput.Should().Be(axis);
        }
    }
}