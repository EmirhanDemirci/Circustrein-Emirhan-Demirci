using System;
using CircusTrein;
using CircusTrein.Models;
using Xunit;

namespace XUnitCircusTrein
{
    public class WagonTest
    {
        private Wagon _wagon;

        public WagonTest()
        {
           _wagon = new Wagon();
        }

        [Fact]
        public void CheckRules_2_Large_Carnivores_Returns_False()
        {
            // Arrange
            Animal animal1 = new Animal(TypeAnimal.Carnivore, Format.Large);
            Animal animal2 = new Animal(TypeAnimal.Carnivore, Format.Large);
            _wagon.AddAnimal(animal1);

            // Act
            var ruleChecked = _wagon.CheckRules(animal2);

            // Assert
            Assert.False(ruleChecked);
        }

        [Fact]
        public void CheckRules_3_Large_Herbivores_Returns_False()
        {
            // Arrange
            Animal animal1 = new Animal(TypeAnimal.Herbivore, Format.Large);
            Animal animal2 = new Animal(TypeAnimal.Herbivore, Format.Large);
            Animal animal3 = new Animal(TypeAnimal.Herbivore, Format.Large);
            _wagon.AddAnimal(animal1);
            _wagon.AddAnimal(animal2);

            // Act
            var ruleChecked = _wagon.CheckRules(animal3);

            // Assert
            Assert.False(ruleChecked);
        }

        [Fact]
        public void CheckRules_1_Large_Carnivore_And_1_Large_Herbivore_Returns_False()
        {
            // Arrange
            Animal animal1 = new Animal(TypeAnimal.Carnivore, Format.Large);
            Animal animal2 = new Animal(TypeAnimal.Herbivore, Format.Large);
            _wagon.AddAnimal(animal1);

            // Act
            var ruleChecked = _wagon.CheckRules(animal2);

            // Assert
            Assert.False(ruleChecked);
        }

        [Fact]
        public void CheckRules_2_Large_Herbivores_Returns_True()
        {
            // Arrange
            Animal animal1 = new Animal(TypeAnimal.Herbivore, Format.Large);
            Animal animal2 = new Animal(TypeAnimal.Herbivore, Format.Large);
            _wagon.AddAnimal(animal1);

            // Act
            var ruleChecked = _wagon.CheckRules(animal2);

            // Assert
            Assert.True(ruleChecked);
        }

        [Fact]
        public void CheckRules_1_Small_Carnivore_And_2_Medium_Herbivore_Returns_True()
        {
            // Arrange
            Animal animal1 = new Animal(TypeAnimal.Carnivore, Format.Small);
            Animal animal2 = new Animal(TypeAnimal.Herbivore, Format.Medium);
            Animal animal3 = new Animal(TypeAnimal.Herbivore, Format.Medium);
            _wagon.AddAnimal(animal1);
            _wagon.AddAnimal(animal2);

            // Act
            var ruleChecked = _wagon.CheckRules(animal3);

            // Assert
            Assert.True(ruleChecked);
        }

        [Fact]
        public void CheckRules_2_Small_Carnivore_And_4_Medium_Herbivore_Returns_False()
        {
            // Arrange
            Animal animal1 = new Animal(TypeAnimal.Carnivore, Format.Small);
            Animal animal2 = new Animal(TypeAnimal.Carnivore, Format.Small);
            Animal animal3 = new Animal(TypeAnimal.Herbivore, Format.Medium);
            Animal animal4 = new Animal(TypeAnimal.Herbivore, Format.Medium);
            Animal animal5 = new Animal(TypeAnimal.Herbivore, Format.Medium);
            Animal animal6 = new Animal(TypeAnimal.Herbivore, Format.Medium);
            _wagon.AddAnimal(animal1);
            _wagon.AddAnimal(animal2);
            _wagon.AddAnimal(animal3);
            _wagon.AddAnimal(animal4);
            _wagon.AddAnimal(animal5);

            // Act
            var ruleChecked = _wagon.CheckRules(animal6);

            // Assert
            Assert.False(ruleChecked);
        }

        [Fact]
        public void CheckRules_2_Small_Herbivore_And_2_Medium_Herbivore_Returns_True()
        {
            // Arrange
            Animal animal1 = new Animal(TypeAnimal.Herbivore, Format.Small);
            Animal animal2 = new Animal(TypeAnimal.Herbivore, Format.Small);
            Animal animal3 = new Animal(TypeAnimal.Herbivore, Format.Medium);
            Animal animal4 = new Animal(TypeAnimal.Herbivore, Format.Medium);
            _wagon.AddAnimal(animal1);
            _wagon.AddAnimal(animal2);
            _wagon.AddAnimal(animal3);

            // Act
            var ruleChecked = _wagon.CheckRules(animal4);

            // Assert
            Assert.True(ruleChecked);
        }

        [Fact]
        public void CheckRules_1_Large_Herbivore_And_2_Small_Herbivore_Returns_True()
        {
            // Arrange
            Animal animal1 = new Animal(TypeAnimal.Herbivore, Format.Large);
            Animal animal2 = new Animal(TypeAnimal.Herbivore, Format.Small);
            Animal animal3 = new Animal(TypeAnimal.Herbivore, Format.Small);
            _wagon.AddAnimal(animal1);
            _wagon.AddAnimal(animal2);

            // Act
            var ruleChecked = _wagon.CheckRules(animal3);

            // Assert
            Assert.True(ruleChecked);
        }
        [Fact]
        public void CheckRules_2_Small_Herbivore_And_2_Small_Carnivore_Returns_False()
        {
            // Arrange
            Animal animal1 = new Animal(TypeAnimal.Herbivore, Format.Small);
            Animal animal2 = new Animal(TypeAnimal.Herbivore, Format.Small);
            Animal animal3 = new Animal(TypeAnimal.Carnivore, Format.Small);
            Animal animal4 = new Animal(TypeAnimal.Carnivore, Format.Small);
            _wagon.AddAnimal(animal1);
            _wagon.AddAnimal(animal2);
            _wagon.AddAnimal(animal3);

            // Act
            var ruleChecked = _wagon.CheckRules(animal4);

            // Assert
            Assert.False(ruleChecked);
        }
    }
}
