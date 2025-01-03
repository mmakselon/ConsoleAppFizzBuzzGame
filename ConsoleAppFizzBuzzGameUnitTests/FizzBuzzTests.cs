using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFizzBuzzGame.UnitTests
{
    public class FizzBuzzTests
    {
        //public void MetodaTestowana_Scenariusz_OczekiwaneZachowanie()
        [Test]
        public void CheckNumber_WhenInputIsDivisibleOnlyBy3_ShouldReturnFizz()
        {
            //Arrange
            var fizzBuzz = new FizzBuzz();

            //Act
            var result = fizzBuzz.CheckNumber(3);

            //Assert
            Assert.That(result, Is.EqualTo("Fizz"));

        }

        [Test]
        public void CheckNumber_WhenInputIsDivisibleOnlyBy5_ShouldReturnBuzz()
        {
            //Arrange
            var fizzBuzz = new FizzBuzz();

            //Act
            var result = fizzBuzz.CheckNumber(5);

            //Assert
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void CheckNumber_WhenInputIsDivisibleBy3And5_ShouldReturnFizzBuzz()
        {
            //Arrange
            var fizzBuzz = new FizzBuzz();

            //Act
            var result = fizzBuzz.CheckNumber(15);

            //Assert
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_WhenInputIsNotDivisibleBy3And5_ShouldReturnInput()
        {
            //Arrange
            var fizzBuzz = new FizzBuzz();

            //Act
            var result = fizzBuzz.CheckNumber(1);

            //Assert
            Assert.That(result, Is.EqualTo("1"));
        }
    }
}
