using NUnit.Framework;
using System;
using CinemaCSApp;

namespace CinemaCSApp_Test
{
    [TestFixture]
    public class TicketPriceController_Test
    {
        [Test]
        [TestCase(1, "adult", "friday", 4, 14.5)]
        [TestCase(2, "adult", "monday", 5, -1)]
        [TestCase(1, "student", "wednesday", 4, -1)]
        [TestCase(3, "adult", "thursday", 1, 43.5)]
        [TestCase(1, "adult", "tuesday", 4, -1)]
        public void Adult_Before_5(int pr_quantity, string pr_person, string pr_day, decimal pr_time, decimal expectedResult)
        {
            decimal result;

            // ARRANGE
            TicketPriceController priceController = new TicketPriceController();

            // Act
            result = priceController.Adult_Before_5(pr_quantity, pr_person, pr_day, pr_time);

            // Log result
            Console.WriteLine($"Test case - Quantity:{pr_quantity}, Person:{pr_person}, Day:{pr_day}, Time:{pr_time}");
            Console.WriteLine($"Expected Result:{expectedResult}, Result:{result}");

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase(1, "adult", "Monday",5.30,17.5)]
        [TestCase(2, "adult", "Wednesday", 5, 35)]
        [TestCase(1, "adult", "Tuesday", 8.30, -1)]
        [TestCase(1, "adult", "Friday", 3.30, -1)]
        [TestCase(10, "adult", "Saturday", 7, 175)]
        public void Adult_After_5(int pr_quantity, string pr_person, string pr_day, decimal pr_time, decimal expectedResult)
        {
            decimal result;

            // ARRANGE
            TicketPriceController priceController = new TicketPriceController();

            // Act
            result = priceController.Adult_After_5(pr_quantity, pr_person, pr_day, pr_time);

            // Log result
            Console.WriteLine($"Test case - Quantity:{pr_quantity}, Person:{pr_person}, Day:{pr_day}, Time:{pr_time}");
            Console.WriteLine($"Expected Result:{expectedResult}, Result:{result}");

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase(1, "adult", "Tuesday", 13)]
        [TestCase(3, "adult", "Tuesday", 39)]
        [TestCase(1, "adult", "Wednesday", -1)]
        [TestCase(1, "senior", "Tuesday", -1)]
        [TestCase(0, "adult", "Tuesday", -1)]
        public void Adult_Tuesday(int pr_quantity, string pr_person, string pr_day, decimal expectedResult)
        {
            decimal result;

            // ARRANGE
            TicketPriceController priceController = new TicketPriceController();

            // Act
            result = priceController.Adult_Tuesday(pr_quantity, pr_person, pr_day);

            // Log result
            Console.WriteLine($"Test case - Quantity:{pr_quantity}, Person:{pr_person}, Day:{pr_day}");
            Console.WriteLine($"Expected Result:{expectedResult}, Result:{result}");

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase(1, "child", 12)]
        [TestCase(100, "child", 1200)]
        [TestCase(1, "adult", -1)]
        [TestCase(1, "student", -1)]
        [TestCase(1, "family", -1)]
        public void Child_Under_16(int pr_quantity, string pr_person, decimal expectedResult)
        {
            decimal result;

            // ARRANGE
            TicketPriceController priceController = new TicketPriceController();

            // Act
            result = priceController.Child_Under_16(pr_quantity, pr_person);

            // Log result
            Console.WriteLine($"Test case - Quantity:{pr_quantity}, Person:{pr_person}");
            Console.WriteLine($"Expected Result:{expectedResult}, Result:{result}");

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase(1, "senior", 12.5)]
        [TestCase(50, "senior", 625)]
        [TestCase(1, "adult", -1)]
        [TestCase(1, "student", -1)]
        [TestCase(0, "senior", -1)]
        public void Senior(int pr_quantity, string pr_person, decimal expectedResult)
        {
            decimal result;

            // ARRANGE
            TicketPriceController priceController = new TicketPriceController();

            // Act
            result = priceController.Senior(pr_quantity, pr_person);

            // Log result
            Console.WriteLine($"Test case - Quantity:{pr_quantity}, Person:{pr_person}");
            Console.WriteLine($"Expected Result:{expectedResult}, Result:{result}");

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase(1, "student", 14)]
        [TestCase(25, "student", 350)]
        [TestCase(5, "adult", -1)]
        [TestCase(100, "child", -1)]
        [TestCase(3, "family", -1)]
        public void Student(int pr_quantity, string pr_person, decimal expectedResult)
        {
            decimal result;

            // ARRANGE
            TicketPriceController priceController = new TicketPriceController();

            // Act
            result = priceController.Student(pr_quantity, pr_person);

            // Log result
            Console.WriteLine($"Test case - Quantity:{pr_quantity}, Person:{pr_person}");
            Console.WriteLine($"Expected Result:{expectedResult}, Result:{result}");

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase(1, 2, 2, 46)]
        [TestCase(1, 1, 3, 46)]
        [TestCase(1, 1, 1, -1)]
        [TestCase(1, 3, 1, -1)]
        [TestCase(2, 4, 4, -1)]
        public void Family_Pass(int pr_quantity_ticket, int pr_quantity_adult, int pr_quantity_child, decimal expectedResult)
        {
            decimal result;

            // ARRANGE
            TicketPriceController priceController = new TicketPriceController();

            // Act
            result = priceController.Family_Pass(pr_quantity_ticket, pr_quantity_adult, pr_quantity_child);

            // Log result
            Console.WriteLine($"Test case - ticket(s):{pr_quantity_ticket}, Adult(s):{pr_quantity_adult}, Child(ren):{pr_quantity_child}");
            Console.WriteLine($"Expected Result:{expectedResult}, Result:{result}");

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase(1, "adult", "thursday", 21.5)]
        [TestCase(2, "adult", "thursday", 43)]
        [TestCase(1, "adult", "wednesday",-1)]
        [TestCase(1, "student", "thursday", -1)]
        [TestCase(1, "child", "thursday", -1)]
        public void Chick_Flick_Thursday(int pr_quantity, string pr_person, string pr_day, decimal expectedResult)
        {
            decimal result;

            // ARRANGE
            TicketPriceController priceController = new TicketPriceController();

            // Act
            result = priceController.Chick_Flick_Thursday(pr_quantity, pr_person, pr_day);

            // Log result
            Console.WriteLine($"Test case - Quantity:{pr_quantity}, Person(s):{pr_person}, Day:{pr_day}");
            Console.WriteLine($"Expected Result:{expectedResult}, Result:{result}");

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase(1, "wednesday", false, 12)]
        [TestCase(2, "wednesday", false, 24)]
        [TestCase(1, "sunday", false, -1)]
        [TestCase(1, "wednesday", true, -1)]
        [TestCase(0, "tuesday", true, -1)]
        public void Kids_Carers(int pr_quantity, string pr_day, bool pr_holiday, decimal expectedResult)
        {
            decimal result;

            // ARRANGE
            TicketPriceController priceController = new TicketPriceController();

            // Act
            result = priceController.Kids_Careers(pr_quantity, pr_day, pr_holiday);

            // Log result
            Console.WriteLine($"Test case - Quantity:{pr_quantity}, Day(s):{pr_day}, Holiday:{pr_holiday}");
            Console.WriteLine($"Expected Result:{expectedResult}, Result:{result}");

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

    }
    
}
