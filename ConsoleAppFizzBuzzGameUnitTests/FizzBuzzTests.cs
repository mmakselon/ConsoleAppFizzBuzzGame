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
    }
}
