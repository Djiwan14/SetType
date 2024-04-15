using NUnit.Framework;

namespace ConsoleApp1
{
    [TestFixture]
    public class UnitTest1
    {
        //1. Testing Add() method
        [Test]
        public void TestAdd()
        {
            // Arrange
            var numbers = new Set();
            int element = 69;

            // Act
            numbers.Add(element);

            // Assert
            Assert.That(numbers.CheckIfIn(element), Is.True);
        }
        //2.1 Testing Delete() method
        [Test]
        public void TestDelete()
        {
            // Arrange
            var numbers = new Set();
            int element = 5;
            numbers.Add(element);

            // Act
            numbers.Delete(element);

            // Assert
            Assert.That(numbers.CheckIfIn(element), Is.False);
        }

        //2.2 Testing Delete() method
        [Test]
        public void TestDeleteFromEmptySet()
        {
            // Arrange
            var numbers = new Set();
            int element = 10;

            // Act
            numbers.Delete(element);

            // Assert
            Assert.IsFalse(numbers.CheckIfIn(element));
        }

        //2.3 Testing Delete() method
        [Test]
        public void TestDeleteNonExistingElement()
        {
            // Arrange
            var numbers = new Set();
            int[] elements = { 5, 4, 8, 6 };
            foreach(int element in elements)
            {
                numbers.Add(element);
            }
            int i = 9;


            // Act
            numbers.Delete(i);

            // Assert
            Assert.That(numbers.CheckIfIn(i), Is.False);
        }

        //3.1 Testing CheckIsEmpty() method
        [Test]
        public void TestCheckIsEmptyReturnsTrue()
        {
            // Arrange
            var numbers = new Set();

            // Act
            bool result = numbers.CheckIsEmpty();

            // Assert
            Assert.IsTrue(numbers.CheckIsEmpty());
        }
        //3.2 Testing CheckIsEmpty() method
        [Test]
        public void TestCheckIsEmptyReturnsFalse()
        {
            // Arrange
            var numbers = new Set();
            int element = 5;
            numbers.Add(element);

            // Act
            bool result = numbers.CheckIsEmpty();

            // Assert
            Assert.IsFalse(numbers.CheckIsEmpty());
        }

        //4.1 Testing CheckIfIn() method
        [Test]
        public void TestCheckIfInReturnsTrue()
        {
            var numbers = new Set();
            int element = 5;
            numbers.Add(element);

            // Act
            bool isIn = numbers.CheckIfIn(element);

            // Assert
            Assert.IsTrue(numbers.CheckIfIn(element));
        }
        //4.2 Testing CheckIfIn() method
        [Test]
        public void TestCheckIfInReturnsFalse()
        {
            var numbers = new Set();
            int element = 5;

            // Act
            bool isIn = numbers.CheckIfIn(element);

            // Assert
            Assert.IsFalse(numbers.CheckIfIn(element));
        }
        [Test]
        //5.1 Testing GetRandomNumber() method
        public void TestGetRandomNumber()
        {
            var numbers = new Set();
            int[] elements = { 5, 7, 8 };
            foreach (int i in elements)
            {
                numbers.Add(i);
            }
            int randomNum = numbers.GetRandomNumber();
            Assert.That(numbers.CheckIfIn(randomNum), Is.True);
        }

        //5.2 Testing GetRandomNumber() method
        [Test]
        public void TestGetRandomNumberFromEmptySet()
        {
            var numbers = new Set();
            
            int randomNum = numbers.GetRandomNumber();
            Assert.IsFalse(numbers.CheckIfIn(randomNum));
        }

        [Test]
        //6. Testing GetSum() method
        public void TestGetSum()
        {
            var numbers = new Set();
            int sum = 0;
            int[] elements = { 1, 4, 8, 9 };
            foreach (int i in elements)
            {
                sum += i;
                numbers.Add(i);
            }
            Assert.IsTrue(sum == numbers.GetSum());
        }
    }
}